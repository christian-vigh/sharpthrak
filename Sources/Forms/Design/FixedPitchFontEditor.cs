/**************************************************************************************************************

    NAME
        FixedPitchFontEditor.cs

    DESCRIPTION
        A Font property editor for fixed-pitch fonts, including the appropriate type converted.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/17]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. Collections ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using   System. Drawing. Design ;
using	System. Text ;
using	System. Windows. Forms ;
using   System. Windows. Forms. Design ;

using   Thrak. WinAPI. DLL ;


namespace Thrak. Forms
   {
	# region FixedPitchFontEditor class
	/// <summary>
	/// A font chooser for the Font property of the ShellForm form that selects only fixed-pitch fonts.
	/// </summary>
	internal class  FixedPitchFontEditor	:  UITypeEditor
	   {
		private FontDialog	FontDialog	=  null ;		// Last used FontDialog object


		// Default constructor
		FixedPitchFontEditor ( ) : base ( )
		   { }


		// Shows a Font chooser dialog box, using the specified value (a Font object) as the initial value.
		public override object EditValue ( ITypeDescriptorContext  context, IServiceProvider  provider, object  value )
		   {
			object		result 	=  value ; 


			if  ( provider  !=  null )
			   {
				IWindowsFormsEditorService	EditorService = 
					( IWindowsFormsEditorService ) provider. GetService ( typeof ( IWindowsFormsEditorService ) ) ;

				if (  EditorService  !=  null ) 
				   {
					if  ( this. FontDialog  ==  null )		// Create the font dialog object only upon first invocation
					   {
						this. FontDialog			=  new FontDialog ( ) ;
						this. FontDialog. ShowApply		=  false ;
						this. FontDialog. ShowColor		=  false ;
						this. FontDialog. AllowVerticalFonts	=  false ;
						this. FontDialog. FixedPitchOnly	=  true ;
						this. FontDialog. AllowScriptChange	=  false ;
						this. FontDialog. ShowEffects		=  false ;
					    }

					// Initializes the FontDialog Font's property with the specified value, if not null
					Font	FontValue	=  value as  Font ;

					if  ( FontValue  !=  null )
						this. FontDialog. Font	=  FontValue ;

					// Show the dialog box ; don't forget to give the focus back to the control which lost it
					IntPtr	hwndFocus	=  User32. GetFocus ( ) ;

					if  ( FontDialog.ShowDialog ( )  ==  DialogResult. OK )
						result	=  FontDialog. Font ;

					User32. SetFocus ( hwndFocus ) ;
				    }
			    }

			// All done, return
			return ( result ) ;
		    }

		
		// Returns the editor type (say : "we will popup a dialog box")
		public override UITypeEditorEditStyle GetEditStyle ( ITypeDescriptorContext context )
		   {
			return ( UITypeEditorEditStyle. Modal ) ;
		    }
	    }
	# endregion
    }
