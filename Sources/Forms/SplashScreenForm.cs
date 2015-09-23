/**************************************************************************************************************

    NAME
	SplashScreenForm.cs		

    DESCRIPTION
        Generic splash screen form container.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/04]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using	System. Text ;
using	System. Windows. Forms ;


namespace Thrak. Forms
   {
	public partial class SplashScreenForm : Thrak. Forms. AsynchronousForm
	   {
		# region Constructor
		/// <summary>
		/// Class constructor.
		/// </summary>
		public SplashScreenForm ( )
		   {
			this. PreventUserClosing = true ;		// Disable closing form with Alt+F4
			InitializeComponent ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the Label object that holds the current initialization message.
		/// </summary>
		public global::System. Windows. Forms. Label	MessageLabel 
		   {
			get { return ( this. p_MessageLabel ) ; }
		    }


		/// <summary>
		/// Gets the Label object that holds the application version.
		/// </summary>
		public global::System. Windows. Forms. Label	VersionLabel 
		   {
			get { return ( this. p_VersionLabel ) ; }
		    }


		/// <summary>
		/// Gets the Label object that holds the application name.
		/// </summary>
		public global::System. Windows. Forms. Label	ApplicationNameLabel 
		   {
			get { return ( this. p_MessageLabel ) ; }
		    }


		/// <summary>
		/// Gets the ProgressBar object that holds the current progression state.
		/// </summary>
		public global::System. Windows. Forms. ProgressBar	ProgressBar 
		   {
			get { return ( this. p_ProgressBar ) ; }
		    }
		# endregion
	    }
    }
