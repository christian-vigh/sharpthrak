/**************************************************************************************************************

    NAME
	AsynchronousForm.cs		

    DESCRIPTION
        Implements a form that runs in a separate thread.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/008/04]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. ComponentModel ;
using	System. Drawing ;
using	System. Text ;
using   System. Threading ;
using	System. Windows. Forms ;


namespace Thrak. Forms
   {
	public partial class AsynchronousForm : Thrak. Forms. Form
	   {
		# region Delegates for asynchronous handling
		// Delegates
		private delegate Object			GetFieldDelegate ( Object  Caller, String  FieldName ) ;
		# endregion


		# region Data members
		protected Thread		FormThread ;
		# endregion


		# region Constructors
		/// <summary>
		/// Class constructor.
		/// </summary>
		public AsynchronousForm ( )
		   {
			this. FormThread	=  Thread. CurrentThread ;
			InitializeComponent ( ) ;
		    }
		# endregion
	    }
    }
