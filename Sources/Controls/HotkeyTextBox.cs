/**************************************************************************************************************

    NAME
        Hotkey.cs

    DESCRIPTION
        Hotkey editor textbox.
	While the focus is in a HotkeyTextBox control, all keyboard keys are redirected to the control, including
	the system keys such as ALT or as any ALT+char combination (note however that the Windows and ContextMenu
	keys are still active, because the keyboard hook is located at a lower level).
 
	The only unprocessed key is TAB, which sets the focus to the next available control in a form.

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


using   Thrak. Input ;
using   Thrak. WinAPI. Enums ;


namespace Thrak. Forms
   {
	/// <summary>
	/// Implements a control used for entering keyboard hotkeys.
	/// </summary>
	public partial class HotkeyTextBox :  TextBox
	   {
		# region Private data members
		// Max authorized shortcuts
		private int			p_MaxShortcuts		=  1 ;
		// Indicates whether modifiers are required for a hotkey
		private bool			p_ModifiersRequired	=  true ;
		// Hotkeys sequence
		private HotkeySequence		p_Sequence		=  new HotkeySequence ( ) ;
		# endregion


		# region Constructor
		/// <summary>
		/// Default constructor.
		/// </summary>
		public HotkeyTextBox ( )
		   {
			base. Multiline	=  false ;
			InitializeComponent ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the maximum number of shortcuts allowed for this control.
		/// </summary>
		[Category ( "Thrak" )]
		[Description ( "Gets/sets the maximum number of shortcuts allowed for this control." )]
		[Browsable ( true )]
		public int  MaxShortcuts
		   {
			get { return ( p_MaxShortcuts ) ; }
			set
			   {
				if  ( value  >  0 )
					p_MaxShortcuts	=  value ;
			    }
		    }


		/// <summary>
		/// Returns the list of hotkeys entered by the user.
		/// </summary>
		[Browsable ( false )]
		public HotkeySequence	Hotkeys
		   {
			get { return ( p_Sequence ) ; }
		    }
		# endregion


		# region Parent properties
		/// <summary>
		/// Forces the control to be non-multiline.
		/// </summary>
		public override bool Multiline
		   {
			get { return ( base. Multiline ) ; }
			set { base. Multiline = false ; }
		    }


		/// <summary>
		/// Overridden Text property, to ensure the caret is always at the end of the displayed string.
		/// </summary>
		public override string  Text
		   {
			get { return ( base. Text ) ; }
			set
			   {
				base. Text	=  value ;
				base. Select ( value. Length, 0 ) ;
			    }
		    }


		/// <summary>
		/// Indicates if a hotkey must include modifiers such as Control, Alt or shift.
		/// <para>If set to false, even a single keystroke such as "A" will be accepted as a shortcut.</para>
		/// </summary>
		[Category ( "Thrak" )]
		[Description ( "Indicates if a hotkey must include modifiers such as Control, Alt or shift." )]
		[Browsable ( true )]
		public bool			ModifiersRequired
		   {
			get { return ( p_ModifiersRequired ) ; }
			set { p_ModifiersRequired = value ; }
		    }
		# endregion


		# region General methods
		/// <summary>
		/// Clears the entered sequences.
		/// </summary>
		public new void  Clear ( )
		   {
			p_Sequence. Clear ( ) ;
			this. Text	=  "" ;
		    }
		# endregion


		# region Keyboard methods
		/// <summary>
		/// Handles keydown events.
		/// </summary>
		protected override void OnKeyDown ( KeyEventArgs e )
		   {
			// Clear the last entered hotkey if the backspace key is hit
			if  ( e. KeyCode  ==  Keys. Back  ||  e. KeyCode  ==  Keys. Delete )
			   {
				if  ( p_Sequence. RemoveLast ( ) )
					this. Text	=  p_Sequence. ToString ( ) ;
			    }
			// TAB is the only key that we don't process, since it allows the user to cycle through a form's controls.
			else if  ( e. KeyCode  ==  Keys. Tab )
				base. OnKeyDown ( e ) ;
			// Otherwise add the shortcut to the list, if the maximum number of shortcuts has not yet been reached
			else if  ( p_Sequence. Count  <  p_MaxShortcuts  &&  
					( ! p_ModifiersRequired  ||  ( e. Modifiers  & ( Keys. Control | Keys. Alt | Keys. Shift ) )  !=  0 ) )
			   {
				// Well, the Hotkey object trows an exception if the key combination is not defined in his authorized keys table
				try
				   {
					Hotkey		hotkey		=  new Hotkey ( e. Modifiers, e. KeyCode ) ;

					p_Sequence. Add ( hotkey ) ;
					this. Text	=  p_Sequence. ToString ( ) ;
					e. Handled	=  true ;
					this. Focus ( ) ;
				    }
				catch 
				   { }
			    }
		    }


		/// <summary>
		/// Prevent the base class to handle unnecessary orphan WM_KEYUP messages.
		/// </summary>
		protected override void OnKeyUp ( KeyEventArgs e )
		   {
			e. Handled	=  true ;
		    }


		/// <summary>
		/// Handles char events.
		/// </summary>
		protected override void OnKeyPress ( KeyPressEventArgs e )
		   {
			e. Handled	=  true ;
		    }


		/// <summary>
		/// Override the standard window proc to replace WM_SYSKEYDOWN, WM_SYSKEYUP, WM_SYSCHAR and WM_SYSDEADCHAR messages,
		/// which are replaced by normal WM_KEYDOWN, WM_KEYUP, WM_CHAR and WM_DEADCHAR messages.
		/// <para>
		/// The purpose of this process is to be able to catch the ALT key before the parent form itself, so that pressing the
		/// ALT key won't focus on the form's menu strip.
		/// </para>
		/// </summary>
		protected override void WndProc ( ref Message m )
		   {
			switch  ( m. Msg )
			   {
				case	( int ) WM_Constants. WM_SYSKEYDOWN :
					m. Msg	=  ( int ) WM_Constants. WM_KEYDOWN ;
					break ;

				case	( int ) WM_Constants. WM_SYSKEYUP :
					m. Msg	=  ( int ) WM_Constants. WM_KEYUP ;
					break ;

				case	( int ) WM_Constants. WM_SYSCHAR :
					m. Msg	=  ( int ) WM_Constants. WM_CHAR ;
					break ;

				case	( int ) WM_Constants. WM_SYSDEADCHAR :
					m. Msg	=  ( int ) WM_Constants. WM_DEADCHAR ;
					break ;
			    }

			base. WndProc ( ref m ) ;
		    }
		# endregion
	    }
    }
