/**************************************************************************************************************

    NAME
	Form.cs		

    DESCRIPTION
        Encapsulation of the System.Windows.Forms.Form class.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/04]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Collections ;
using   System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Drawing ;
using   System. Reflection ;
using	System. Text ;
using	System. Windows. Forms ;
using   System. Threading ;


using   Thrak. Input ;


namespace Thrak. Forms
   {
	public partial class Form : global::System. Windows. Forms. Form
	   {
		# region Types
		/// <summary>
		/// Defines the special effects to be applied during form opening and closing.
		/// </summary>
		public enum FadingOption
		   {
			None		=  0x00,		// No special effect
			OnShow		=  0x01,		// The form appears gradually
			OnClose		=  0x02,		// The form disappears gradually
			Both		=  0x03			// The form appears and disappears gradually
		    }
		# endregion


		# region Data members
		// Private data members
		private	FadingOption			p_FadingOption		=  FadingOption. None ;		// Fading option
		private double				p_FadingStep		=  0.04 ;			// Opacity change increment
		private uint				p_FadingInterval	=  25 ;				// Opacity change interval
		private Boolean				p_PreventUserClosing	=  false ;			// True if Alt+F4 is disabled
		private FormSettingsBase		p_PersistentSettings	=  null ;			// Persistent form settings
		private Boolean				p_PersistAppearance	=  false ;			// True if position and size are to be persisted
		private Shortcuts			p_Shortcuts		=  new Shortcuts ( ) ;		// Holds keyboard shortcuts
		private bool				p_ShortcutsEnabled	=  true ;			// Set to false if shortcuts are to be ignored

		/// <summary>
		/// Handles a shortcut or a combination of shortcuts initially added through the Shortcuts property.
		/// </summary>
		public  event ShortcutEventHandler	Shortcut ;						// KeyboardShortcut handling events
		# endregion

		
		# region Constructor
		/// <summary>
		/// Class constructor.
		/// </summary>
		public Form ( )
		   {
			InitializeComponent ( ) ;
		    }
		# endregion


		# region Properties
  
		# region Fading options
		/// <summary>
		/// Gets/sets the form fading options.
		/// </summary>
		[ 
			Category ( "Thrak" ), 
			Description ( 
					"Fading options for form opening and closing. Fading modifies the form opacity at defined time intervals.\n" +
					"Fading option can be None (no fading), OnShow (the form appears gradually), OnClose (the form fades gradually), " +
					"Both (fading applies to both for opening and closing)."
				     )
		 ]
		public FadingOption  Fading
		   {
			get { return ( p_FadingOption ) ; }
			set { p_FadingOption = value ; }
		    }


		/// <summary>
		/// Gets/sets the step to be used for opacity update when fading.
		/// </summary>
		[ Category ( "Thrak" ), Description ( "Increment to be used when changing the form opacity during the form opening/closing." ) ]
		public double FadingStep
		   {
			get { return ( p_FadingStep ) ; }
			set 
			   {
				if  ( value > 0  &&  value  <  this. Opacity )
					p_FadingStep = value ;
			    }
		    }


		/// <summary>
		/// Gets/sets the interval, in milliseconds, between two opacity updates.
		/// </summary>
		[ Category ( "Thrak" ), Description ( "Interval in milliseconds between two updates of the form's opacity when fading." ) ]
		public uint  FadingInterval
		   {
			get { return ( p_FadingInterval ) ; }
			set
			   {
				if  ( value  >  0 ) 
					p_FadingInterval = value ;
			    }
		    }

		# endregion

		# region Various properties
		/// <summary>
		/// Gets/sets the flag that indicates if the user can close the form, using a combination such Alt+F4.
		/// </summary>
		[ Category ( "Thrak" ), Description ( "Indicates if the user can close the window using key combinations such as Alt+F4." ) ]
		public Boolean  PreventUserClosing 
		   {
			get { return ( p_PreventUserClosing ) ; }
			set { p_PreventUserClosing = value ; }
		    }

		/// <summary>
		/// Gets/sets the persistent settings object.
		/// </summary>
		[ Browsable ( false ) ]
		public FormSettingsBase  PersistentSettingsClass
		   {
			get { return ( p_PersistentSettings ) ; }
			set {  p_PersistentSettings = value ; }
		    }


		/// <summary>
		/// Gets/sets a value indicating whether the form appearance (size & position) should be saved and restored.
		/// </summary>
		[ Category ( "Thrak" ), Description ( "Indicates whether the form position and size should be saved upon exiting and restored at application startup." ) ]
		public Boolean  PersistAppearance 
		   {
			get { return ( p_PersistAppearance ) ; }
			set { p_PersistAppearance = value ; }
		    }


		/// <summary>
		/// Gets the Shortcuts object that holds the shortcuts defined for this form.
		/// </summary>
		[ Browsable ( false ) ]
		public Shortcuts  Shortcuts
		   {
			get { return ( p_Shortcuts ) ; }
			set { p_Shortcuts = value ; }
		    }


		/// <summary>
		/// Gets/sets a flag indicating whether the shortcuts in the shortcut table should be processed or not.
		/// </summary>
		[ Category ( "Thrak" ), Description ( "Gets/sets a flag indicating whether the shortcuts in the shortcut table should be processed or not." ) ]
		public bool  ShortcutsEnabled
		   {
			get { return ( p_ShortcutsEnabled ) ; }
			set
			   {
				p_ShortcutsEnabled	=  value ;

				if  ( ! value )
					p_Shortcuts. Clear ( ) ;
			    }
		    }
		# endregion

		# endregion


		# region Form events

		# region Form_Load event
		/// <summary>
		/// Handles the form Load event. If special fading effects have been specified, apply them.
		/// </summary>
		/// <param name="sender">Object that sent the event.</param>
		/// <param name="e">Event parameters.</param>
		private void Form_Load ( object sender, EventArgs e )
		   {
			// If persistent settings are to apply, load them
			// The caller can assign to the PersistentSettings property its own class deriving from FormSettingsBase.
			// If no assignment is made, the StandardFormSettings class is used.
			if  ( p_PersistAppearance )
			   {
				if  ( p_PersistentSettings  ==  null )
					p_PersistentSettings	=  new StandardFormSettings ( this ) ;

				p_PersistentSettings. Load ( ) ;
			     }

			// If fading option contains the OnShow flag, make the window appear smoothly
			if  ( p_FadingOption  ==  FadingOption. OnShow  ||  p_FadingOption  ==  FadingOption. Both )
			   {
				// Remember initial window opacity and make this window totally transparent
				double	InitialOpacity		=  this. Opacity ;

				this. Opacity		=  0 ;

				// Blocking process : change opacity until it reaches its initial value
				while ( this. Opacity + p_FadingStep <  InitialOpacity )
				   {
					this. Opacity	+=  p_FadingStep ;
					Thread. Sleep ( ( int ) p_FadingInterval ) ;
				    }

				// Make sure we reach the initial opacity value defined in the forms designer
				this. Opacity	= InitialOpacity ;
			    }

			// Find controls implementing the IShortcutClient interface
			FindShortcutHandlers ( this. Controls ) ;
		    }
		# endregion

		# region Form_FormClosing event
		/// <summary>
		/// Handles the form Closing event. If special fading effects have been specified, apply them.
		/// </summary>
		/// <param name="sender">Object that sent the event.</param>
		/// <param name="e">Event parameters.</param>
		private void Form_FormClosing ( object sender, FormClosingEventArgs e )
		   {
			// If persistent settings apply, save them
			if  ( p_PersistAppearance  &&  p_PersistentSettings  !=  null )
				p_PersistentSettings. Save ( ) ;

			// Process the fading option
			if  ( p_FadingOption  ==  FadingOption. OnClose  ||  p_FadingOption  ==  FadingOption. Both )
			   {
				while ( this. Opacity - p_FadingStep  >  0 )
				   {
					this. Opacity	-=  p_FadingStep ;
					Application. DoEvents ( ) ;			// Process any pending events such as form updating...
					Thread. Sleep ( ( int ) p_FadingInterval ) ;
				    }
			    }
		    }
		# endregion

		# endregion


		# region Overridden methods
		/// <summary>
		/// When the PreventUserClosing flag is set to true, the window won't close even if the Close() method
		/// is called. Overriding this method makes sure that if the application requested form closing, despite
		/// the current value of the flag, the form will be closed.
		/// </summary>
		public new void Close ( )
		   {
			p_PreventUserClosing	=  false ;
			base. Close ( ) ;
		    }


		/// <summary>
		/// Prevents form close if came from user and the PreventUserClosing flag is set to true.
		/// </summary>
		protected override void OnFormClosing ( FormClosingEventArgs e ) 
		   { 
			if  ( p_PreventUserClosing )
			   {
				switch ( e. CloseReason )   
				   {     
					case	CloseReason. UserClosing :       
						e. Cancel = true ;       
						return ;   
				    }    
			    }
			     			    
			base. OnFormClosing ( e ) ; 
		     }


		/// <summary>
		/// Performs the following tasks :
		/// <para>- Handle the shortcuts defined in the Shortcuts property.</para>
		/// </summary>
		protected override void OnKeyDown ( KeyEventArgs e )
		   {
			// Call the base keydown handler and return if key has been processed
			base. OnKeyDown ( e ) ;

			if  ( e. Handled )
				return ;

			// Otherwise, if shortcuts are enabled, declare this new event to the shortcut handler.
			if ( p_ShortcutsEnabled )
			   {
				ShortcutEventArgs  hke  =  p_Shortcuts. HandleKeyEvent ( e ) ;

				if  ( hke  !=  null )
					OnShortcut ( hke ) ;
			    }
		    }


		/// <summary>
		/// Process the shortcuts defined in the Shortcuts property.
		/// </summary>
		/// <param name="sender">Sender object.</param>
		/// <param name="e">A HotKeyEventArgs object, that contains information about the shortcut sequence currently caught.</param>
		protected virtual void OnShortcut ( ShortcutEventArgs  e )
		   {
			if  ( e. Hotkey. Handler  !=  null )
				e. Hotkey. Handler ( e ) ;
			else if  ( Shortcut  !=  null )
				Shortcut ( e ) ;
		    }
		# endregion


		# region Support methods
		/// <summary>
		/// Find controls in this form that implement the IShortcutClient interface to add their definitions in the shortcut table.
		/// </summary>
		private void  FindShortcutHandlers ( ICollection  controls )
		   {
			// Loop through control collection
			foreach  ( Control  control  in  controls )
			   {
				// If shortcut client, then get its definitions
				if  ( control  is  IShortcutClient )
				   {
					IShortcutClient		client		=  ( IShortcutClient ) control ;
					KeyboardShortcut []	shortcuts	=  client. Shortcuts ;
					ShortcutEventHandler	handler		=  new ShortcutEventHandler ( client. Execute ) ;
	
					// Loop through IShortcutClient shortcut definitions
					foreach  ( KeyboardShortcut  shortcut  in  shortcuts )
					   {
						// If the definition already contains a handle, don't use the default one (client.Execute)
						if  ( shortcut. Handler  !=  null )
							handler		=  shortcut. Handler ;

						// Add the new shortcut
						p_Shortcuts += new KeyboardShortcut ( shortcut. Id, shortcut. Sequence, handler ) ;
					    }
				    }

				// If this control is a container, recursively walk through its children
				if  ( control. Controls. Count  >  0 )
					FindShortcutHandlers ( control. Controls ) ;
			    }
		    }
		# endregion
	   }
    }
