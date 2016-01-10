/**************************************************************************************************************

    NAME
        InputBoxForm.cs

    DESCRIPTION
        A form for asking a single input value.

    FIX
	When padding is applied by specifying non-zero values, the label is not resized accordingly if it 
	contains multiple lines. So, for now, multiline labels won't be displayed correctly.
	Thanks again, Microsoft developers.

    AUTHOR
        Christian Vigh, 01/2016.

    HISTORY
    [Version : 1.0]    [Date : 2016/01/08]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using	System. Linq ;
using	System. Text ;
using	System. Windows. Forms ;


namespace Thrak. Forms
   {
	public partial class InputBoxForm : Form
	   {
		public InputBoxForm ( )
		   {
			InitializeComponent ( ) ;
			MessageLabel. AutoSize	=  true ;
		    }


		private void OkButton_Click ( object sender, EventArgs e )
		   {
			this. DialogResult	= DialogResult. OK ;
			Close ( ) ;
		    }


		private void CancelButton_Click ( object sender, EventArgs e )
		   {
			this. DialogResult	= DialogResult. Cancel ;
			Close ( ) ;
		    }


		private void InputBoxForm_Shown ( object sender, EventArgs e )
		   {
			MessageInputTextbox. SelectAll ( ) ;
			MessageInputTextbox. Focus ( ) ;
		    }


		private void InputBoxForm_KeyDown ( object sender, KeyEventArgs e )
		   {
			if  ( e. KeyCode  ==  Keys. Escape )
				CancelButton_Click ( sender, null ) ;
		    }
	    }
    }
