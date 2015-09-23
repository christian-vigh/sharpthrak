/**************************************************************************************************************

    NAME
        FormSettings.cs

    DESCRIPTION
        Manages persistent form settings.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/09]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Collections. Generic ;
using	System. Configuration ;
using   System. Drawing	;
using   System. Reflection ;
using	System. Text ;
using   System. Windows. Forms ;


namespace Thrak. Forms
   {
	# region BinSettingToAttribute attribute
	/// <summary>
	/// Classes inheriting from the FormSettingsBase class can specify the BindSettingTo attribute, for each property
	/// to be linked with a form property.
	/// <para>
	/// There are two types of links :
	/// </para>
	/// <para>- Immediate :</para>
	/// <para>	The FormSettingsBase creates a Binding instance for this property and adds it to the Form.Databindings collection.</para>
	/// <para>- Deferred :</para>
	/// <para>The property value is assigned when the FormSettingsBase.Load() method is called, and saved when the
	/// FormSettingsBase.save() method is invoked.</para>
	/// </para>
	/// <br/>
	/// This trick is necessary for properties such as Form.WindowState, which never write back value changes into the
	/// FormSettingsBase (well, ApplicationSettingsBase) class.
	/// </summary>
	public class	BindSettingToAttribute	:  Attribute
	   {
		// Private data member
		private String		p_FormMember ;			// Associated property name in the Form object
		private Boolean		p_Deferred ;			// If true, data binding is only made during calls to Load() and Save()

		
		/// <summary>
		/// Attribute constructur.
		/// </summary>
		/// <param name="name">Form property to which the property declaring this attribute is linked.</param>
		/// <param name="deferred">When true, value updates are only made during calls to the Save() and Load() events.</param>
		public BindSettingToAttribute ( String  name, Boolean  deferred = false )
		   {
			p_FormMember	=  name ;
			p_Deferred	=  deferred ;
		    }
		    
		    
		/// <summary>
		/// Gets/sets the name of the form property to which the FormSettingsBase property declaring this attribute is linked.
		/// </summary>
		public String  Name
		   {
			get { return ( p_FormMember ) ; }
			set { p_FormMember = value ; }
		    }	


		/// <summary>
		/// Gets/sets a flag indicating whether the FormSettingsBase property is dynamically updated and saved, or whether it
		/// is loaded upon call to the Load() method and writtent back with the Save() method.
		/// </summary>
		public Boolean  Deferred 
		   {
			get { return ( p_Deferred ) ; }
			set { p_Deferred = value ; }
		    }
	    }
	# endregion


	# region FormSettingsBase class
	/// <summary>
	/// Enhances the ApplicationSettingsBase by eliminating the need to manually create data bindings between settings and forms properties.
	/// <para>
	/// When the form property has an insufficient implementation of Binding, such as the Form.WindowState property which never writes back
	/// the new property value, the associated Settings property can declare the BindSettingTo attribute, specifying "true" for the "deferred"
	/// option.
	/// </para>
	/// </summary>
	public abstract class FormSettingsBase	:  ApplicationSettingsBase
	   {
		// Form associated to those settings
		private Form 		p_Form ;


		#  region Constructor
		/// <summary>
		/// Class constructor.
		/// </summary>
		/// <param name="frm">Form to be associated with the persistent settings.</param>
		public FormSettingsBase ( Form  frm, String  settingsKey = null ) : base ( frm )
		   {
			p_Form	= frm ;

			// Use either the form type name or the supplied SettingsKey to store the information
			if  ( settingsKey  ==  null )
				base. SettingsKey	=  frm. GetType ( ). Name ;
			else
				base. SettingsKey	=  settingsKey ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the form object that have been specified when instanciating the object.
		/// </summary>
		public Form  Form 
		   {
			get { return ( p_Form ) ; }
		    }
		# endregion


		# region Load() method
		/// <summary>
		/// Load persistent form settings.
		/// </summary>
		# pragma warning disable 0219
		public virtual void  Load ( )
		   {
			Type		FormType		=  this. GetType ( ) ;			// Type object for this form

			// Loop through form properties
			foreach ( PropertyInfo  pi  in FormType. GetProperties ( ) )
			   {
				Boolean			IsSetting		=  false ;		// True if current property is a setting
				Boolean			HasDefaultValue		=  false ;		// True if it has a default value (not used)
				BindSettingToAttribute	BindTo			=  null ;		// Set to a BindSettingTo attribute object if specified for this property


				// Determine the values of the IsSetting, HasDefaultValue and BindTo variables according to the property's attributes
				foreach ( Attribute attr  in  pi. GetCustomAttributes ( true ) )
				   {
					if  ( attr  is  UserScopedSettingAttribute  ||  attr  is  ApplicationScopedSettingAttribute )
						IsSetting = true ;
					else if  ( attr  is  DefaultSettingValueAttribute )
						HasDefaultValue = true ;
					else if  ( attr is  BindSettingToAttribute ) 
						BindTo = ( BindSettingToAttribute ) attr ;
				    }

				// If the property is an application setting and binding information has been specified...
				if  ( IsSetting  &&  BindTo  !=  null )
				   {
					// If non-realtime updating, assign the setting's default value to the associated form property
					if  ( BindTo. Deferred )
					   {
						PropertyInfo			form_pi	=  p_Form. GetType ( ). GetProperty ( BindTo. Name ) ;

						form_pi. SetValue ( p_Form, this [ pi.Name ], null ) ;
					    }
					// Otherwise, create an automatic binding
					else
					   {
						Binding		B	=  new Binding ( BindTo. Name, this, pi. Name, true,
												DataSourceUpdateMode. OnPropertyChanged ) ;

						p_Form. DataBindings. Add ( B ) ;
					     }
				    }
			    }
		    }
		# pragma warning restore 0219
		# endregion


		# region Save() method
		/// <summary>
		/// Save persistent form settings. This method, which in turn calls the ApplicationSettingsBase.Save() method, is here to also
		/// save the settings that cannot be bound to form properties or that cannot be modified by data bindings.
		/// </summary>
		public override void Save ( )
		   {
			Type		FormType		=  this. GetType ( ) ;			// Type object of this form


			// Loop through settings properties
			foreach ( PropertyInfo  pi  in FormType. GetProperties ( ) )
			   {
				Boolean			IsSetting		=  false ;		// True if current property is a setting
				BindSettingToAttribute	BindTo			=  null ;		// True if it has binding information


				// Determine the values of the IsSetting and BindTo variables according to the property's attributes
				foreach ( Attribute attr  in  pi. GetCustomAttributes ( true ) )
				   {
					if  ( attr  is  UserScopedSettingAttribute  ||  attr  is  ApplicationScopedSettingAttribute )
						IsSetting = true ;
					else if  ( attr is  BindSettingToAttribute ) 
						BindTo = ( BindSettingToAttribute ) attr ;
				    }

				// If we have a setting...
				if  ( IsSetting )
				   {
					// ... that has binding information, process it
					if  ( BindTo  !=  null )
					   {
						// Deferred binding : we must manually assign the actual value from the associated form property to this setting
						if  ( BindTo. Deferred )
						   {
							PropertyInfo			form_pi	=  p_Form. GetType ( ). GetProperty ( BindTo. Name ) ;

							this [ pi. Name ] = form_pi. GetValue ( p_Form, null ) ;
						    }
					    }
				    }
			    }

			// Call the base Save() method to save this stuff.
			base. Save ( ) ;
		    }
		# endregion


		# region Property value accessor
		/// <summary>
		/// This method overrides the classic ApplicationSettingsBase indexing method for one simple case : when the setting has no
		/// default value, the value of the associated form property will be returned, instead of returning null and generating an exception.
		/// </summary>
		/// <param name="PropertyName">Setting name.</param>
		/// <returns>The setting value or default value, if not defined.</returns>
		public override object  this [ String  PropertyName ]
		   {
			get
			   {
				object		result		=  base [ PropertyName ] ;		// Get the original setting value


				// If null, this means that the setting has no default value and has never been written back...
				if  ( result  ==  null ) 
				   {
					PropertyInfo			pi	=  this. GetType ( ). GetProperty ( PropertyName ) ;	// Get property info
					BindSettingToAttribute []	bs_array ;
					BindSettingToAttribute		bs ;

					// Check if the setting property has binding information
					bs_array	=  ( BindSettingToAttribute [] ) pi. GetCustomAttributes( typeof ( BindSettingToAttribute ), true ) ;
					
					// If yes, we will simply return the value of the associated form property
					if  ( bs_array. Length > 0 )
					   {
						// Retain only the first BindSettingTo attribute declaration
						bs		=  bs_array [0] ;

						// Get the property information of the associated form property
						PropertyInfo			form_pi	=  p_Form. GetType ( ). GetProperty ( bs. Name ) ;

						// Then get the form's property value
						result			=  form_pi. GetValue ( p_Form, null ) ;

						// We have to do all of that for settings that do not have an initial value ; we make sure that the initial value
						// is that of the associated form property. Now that this work have been done, we make sure that there always be an
						// initial value by saving the associated form's property.
						base [ PropertyName ]	=  result ;
					    }
				    }

				// All done, return.
				return ( result ) ;
			    }
		    }
		# endregion
	    }
	# endregion


	# region StandardFormSettings class
	/// <summary>
	/// Basic class to save form shape (location, size and window state).
	/// <para>
	/// If you create classes derived from FormSettingsBase, you must implement a constructor that takes a Form as parameter,
	/// then call the base class constructor.
	/// </para>
	/// </summary>
	public class  StandardFormSettings	:  FormSettingsBase
	   {
		public StandardFormSettings ( Form  frm, String  settingsKey = null )
				: base ( frm, settingsKey )
		   {
		    }


		/// <summary>
		/// Location setting. Bound to Form.Location.
		/// </summary>
		[UserScopedSetting ( ), BindSettingTo ( "Location" )]
		public Point	Location
		   {
			get { return ( ( Point ) this [ "Location" ] ) ; }
			set 
			   { 
				if  ( Form. WindowState  ==  FormWindowState. Normal )
					this [ "Location" ] = value ; 
				else
					this [ "Location" ] = Form. RestoreBounds. Location ;
			    }
		    }


		/// <summary>
		/// Size setting. Bound to Form.Size.
		/// </summary>
		[UserScopedSetting ( ), BindSettingTo ( "Size" )]
		public Size	Size 
		   {
			get { return ( ( Size ) this [ "Size" ] ) ; }
			set 
			   { 
				if  ( Form. WindowState  ==  FormWindowState. Normal )
					this [ "Size" ] = value ; 
				else
					this [ "Size" ] = Form. RestoreBounds. Size ;
			    }
		    }


		/// <summary>
		/// WindowState setting. Bound to Form. WindowState.
		/// <para>
		/// Note that this binding is curiously managed by the Form.Databindings object ; it seems that the 'set' method never gets called.
		/// </para>
		/// <para>
		/// This is why we use "delayed" binding : the setting will only be written back when the Save() method is called.
		/// </para>
		/// </summary>
		[UserScopedSetting ( ), BindSettingTo ( "WindowState", true )]
		public FormWindowState		WindowState
		   {
			get { return ( ( FormWindowState ) this [ "WindowState" ] ) ; }
			set { this [ "WindowState" ] = value ; } 
		    }
	    }
	# endregion
    }
