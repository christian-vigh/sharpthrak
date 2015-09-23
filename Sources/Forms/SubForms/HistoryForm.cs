/**************************************************************************************************************

    NAME
        HistoryForm.cs

    DESCRIPTION
        Shows the history form.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/25]     [Author : CV]
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
	/// <summary>
	/// Shell history display & selection form.
	/// </summary>
	public partial class HistoryForm : Thrak. Forms. Form
	   {
		private ShellForm		p_Parent	=  null ;
		public String			CommandText	=  "" ;


		/// <summary>
		/// Default constructor.
		/// </summary>
		public HistoryForm ( )
		   {
			InitializeComponent ( ) ;
		    }


		/// <summary>
		/// Constructor with a ShellForm parent (for execution mode).
		/// </summary>
		public HistoryForm ( ShellForm  parent ) : this ( ) 
		   {
			p_Parent	=  parent ;
		    }


		/// <summary>
		/// Initialize localizable strings and loads command history.
		/// </summary>
		private void HistoryForm_Load ( object  sender, EventArgs  e )
		   {
			// Localized strings
			this. Text					=  Resources. Localization. Forms. HistoryForm. Title ;
			this. OkButton. Text				=  Resources. Localization. Forms. HistoryForm. OkButton ;
			this. CloseButton. Text			=  Resources. Localization. Forms. HistoryForm. CancelButton ;
			this. HistoryGrid. Columns [0]. HeaderText	=  Resources. Localization. Forms. HistoryForm. DateColumnTitle ;
			this. HistoryGrid. Columns [1]. HeaderText	=  Resources. Localization. Forms. HistoryForm. CommandColumnTitle ;
			this. EmptyHistoryLabel. Text			=  Resources. Localization. Forms. HistoryForm. EmptyHistory ;

			// Adjust column sizes
			this. HistoryGrid. Columns [1]. Width	=  this. HistoryGrid. Width - this. HistoryGrid. Columns [0]. Width ;

			// Load command history
			bool		visible			=  true ;

			if  ( p_Parent  !=  null )
			   {
				for  ( int  i = 0 ; i < p_Parent. p_History. Count ; i ++ )
				   {
					this. HistoryGrid. Rows. Add (
						p_Parent. p_History [i]. TimeStamp. ToString ( ),
						p_Parent. p_History [i]. Text ) ;
				    }

				visible		=  ( p_Parent. History. Count  ==  0 ) ;
			    }

			// "empty history" message if needed
			this. EmptyHistoryLabel. Visible	=  visible ;

			// Select last row
			if  ( this. HistoryGrid. RowCount  >  0 )
				this. HistoryGrid. CurrentCell	=  this. HistoryGrid. Rows [ this. HistoryGrid. RowCount - 1 ]. Cells [1] ;

			this. HistoryGrid. Focus ( ) ;
		    }


		/// <summary>
		/// Closes the window.
		/// </summary>
		private void CancelButton_Click ( object sender, EventArgs e )
		   {
			this. DialogResult	=  DialogResult. Cancel ;
			this. Close ( ) ;
		    }


		/// <summary>
		/// Closes the window, saving the selected command.
		/// </summary>
		private void OkButton_Click ( object sender, EventArgs e )
		   {
			this. DialogResult	=  DialogResult. OK ;

			if  ( this. HistoryGrid. CurrentRow  !=  null )
				CommandText	=  ( String ) this. HistoryGrid. CurrentRow. Cells [1]. Value ;
			
			this. Close ( ) ;
		    }


		/// <summary>
		/// Handles the escape and return keys.
		/// </summary>
		private void HistoryForm_KeyDown ( object sender, KeyEventArgs e )
		   {
			if  ( e. KeyCode  ==  Keys. Escape )
			   {
				e. Handled	=  true ;
				CancelButton_Click ( sender, null ) ;
			    }
			else if  ( e. KeyCode  ==  Keys. Enter )
			   {
				e. Handled	=  true ;
				OkButton_Click ( sender, null ) ;
			    }
		    }
	    }
    }
