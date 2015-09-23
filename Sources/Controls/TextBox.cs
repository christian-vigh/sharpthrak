/**************************************************************************************************************

    NAME
        TextBox.cs

    DESCRIPTION
        Adds some functionalities to the TextBox base.
  
 	Properties :
	----------
	- The FocusedAction property allows to define the text box behavior when it receives the focus :
	  . SelectAll		:  The whole textbox contents are selected ; caret is moved after the last
				   character.
	    CaretAtEnd		:  No selection occurs and the caret is moved at the end of the text.
	    Default		:  The default TexBox behavior is used.
	- The UndoLevels property which specifies how many undo levels are available (only for single line
	  controls).
 
    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/15]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Drawing ;
using	System. Data ;
using	System. Linq ;
using	System. Text ;
using	System. Windows. Forms ;


using   Thrak. Structures ;


namespace Thrak. Forms
   {
	# region TextBoxFocusAction enum
	/// <summary>
	/// Specifies what to do when a TextBox control receives the focus.
	/// </summary>
	public enum  TextBoxFocusAction
	   {
		/// <summary>
		/// The default textbox behavior is used (normally, move caret at start, no text selection).
		/// </summary>
		Default			=  0,

		/// <summary>
		/// Moves the caret at end of text.
		/// </summary>
		MoveCaretToEnd		=  1,

		/// <summary>
		/// Selects the whole content and move the caret to the end.
		/// </summary>
		SelectContent		=  2
	    }
	# endregion


	# region TextBox control
	/// <summary>
	/// TextBox control enhancements.
	/// </summary>
	public partial class TextBox : System. Windows. Forms. TextBox
	   {
		# region Private data member
		// Action to be taken when the control receives the focus
		private TextBoxFocusAction		p_FocusAction		=  TextBoxFocusAction. Default ;
		// History information
		private VersionedBuffer			p_Buffer ;
		private int				p_UndoLevels		=  256 ;
		private bool				p_UpdatingBuffer	=  false ;
		# endregion


		# region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TextBox ( )
		   {
			p_Buffer		=  new VersionedBuffer ( p_UndoLevels ) ;
			InitializeComponent ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Determines the action to be taken when the control receives the focus.
		/// </summary>
		[Category ( "Thrak" )]
		[Description ( "Determines the action to be taken when the control receives the focus." )]
		[Browsable ( true )]
		public TextBoxFocusAction	FocusAction
		   {
			get { return ( p_FocusAction ) ; }
			set { p_FocusAction = value ; }
		    }


		public override  String  Text
		   {
			get { return ( base. Text ) ; }
			set 
			   {
				base. Text	=  value ;

				if (  p_FocusAction   !=  TextBoxFocusAction. Default )
					this. Select ( this. Text. Length, 0 ) ;	    
			    }
		    }



		/// <summary>
		/// Gets/sets the number of undo levels for this text box.
		/// </summary>
		[Category ( "Thrak" )]
		[Description ( "Gets/sets the number of undo levels for this text box." )]
		[Browsable ( true )]
		public int  UndoLevels
		   {
			get { return ( p_UndoLevels ) ; }
			set
			   {
				if  ( value  >  0 )
				   {
					p_UndoLevels	=  value ;
					p_Buffer	=  new VersionedBuffer ( value ) ;
				    }
			    }
		    }
		# endregion


		# region Control events
		/// <summary>
		/// Handles the focus to the control and takes the appropriate focus action.
		/// </summary>
		protected override void OnGotFocus ( EventArgs e )
		   {
			base. OnGotFocus ( e ) ;

			switch  ( p_FocusAction )
			   {
				case  TextBoxFocusAction. Default :
					break ;

				case  TextBoxFocusAction. MoveCaretToEnd :
					this. Select ( this. Text. Length, 0 ) ;
					break ;

				case  TextBoxFocusAction. SelectContent :
					this. Select ( 0, this. Text. Length ) ;
					break ;
			    }
		    }


		/// <summary>
		/// Creates a new version of the textbox contents, unless a redo or undo is currently under process.
		/// </summary>
		protected override void OnTextChanged ( EventArgs e )
		   {
			base. OnTextChanged ( e ) ;

			if  ( ! p_UpdatingBuffer )
			   {
				p_Buffer. Add ( this. Text ) ;
			    }
		    }


		/// <summary>
		/// Process keyboard shortcuts such as Ctrl+Z (undo) or Ctrl+Y (redo).
		/// </summary>
		protected override void OnKeyDown ( KeyEventArgs e )
		   {
			if  ( e. Modifiers  ==  Keys. Control )
			   {
				// Ctrl+Z : undo
				if  ( e. KeyCode  ==  Keys. Z )
				   {
					// Say that we are programmatically updating the TextBox contents and tat no new string should
					// be added in
					p_UpdatingBuffer	=  true ;		
					this. Text		=  p_Buffer. Undo ( ) ;		// Get previous text version

					// Let the application process pending events before we set p_UpdatingBuffer to false
					Application. DoEvents ( ) ;				

					p_UpdatingBuffer	=  false ;
					e. Handled		=  true ;
				    }
				// Ctrl+Y : Redo
				else if  ( e. KeyCode  ==  Keys. Y )
				   {
					p_UpdatingBuffer	=  true ;
					this. Text		=  p_Buffer. Redo ( ) ;

					Application. DoEvents ( ) ;

					p_UpdatingBuffer	=  false ;
					e. Handled		=  true ;
				    }
			    }
		    }
		# endregion
	   }
	# endregion
    }
