/**************************************************************************************************************

    NAME
        ShellForm.cs

    DESCRIPTION
        Implements a shell-like window.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/17]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using   System. Drawing. Design ;
using	System. Text ;
using	System. Threading ;
using	System. Windows. Forms ;
using   System. Windows. Forms. Design ;

using   Thrak. Core. Assembly ;
using   Thrak. Graphics ;
using   Thrak. WinAPI. DLL ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. Forms
   {
	# region ShellForm class
	public partial class ShellForm : Thrak. Forms. Form
	   {
		# region Constants
		/// <summary>
		/// Minimum console width, in characters.
		/// </summary>
		public const int		MinConsoleWidth		=  10 ;

		/// <summary>
		/// Minimum console height, in lines.
		/// </summary>
		public const int		MinConsoleHeight	=  2 ;

		/// <summary>
		/// Maximum console width, in characters.
		/// </summary>
		public const int		MaxConsoleWidth		=  255 ;

		/// <summary>
		/// Maximum console height, in lines.
		/// </summary>
		public const int		MaxConsoleHeight	=  80 ;

		/// <summary>
		/// End of file character.
		/// </summary>
		public const int		EOF			=  -1 ;
		# endregion


		# region Delegates
		// Insertion mode change
		public delegate void	InsertModeChanged	( ShellForm  sender, InsertModeChangedEventArgs  e ) ;
		public event		InsertModeChanged	ShellInsertModeChanged ;

		// Character input
		public delegate void	CharacterInput		( ShellForm  sender, CharacterInputEventArgs  e ) ;
		public event		CharacterInput		ShellCharacterInput ;

		// Command input
		public delegate void	CommandInput		( ShellForm  sender, CommandInputEventArgs  e ) ;
		public event		CommandInput		ShellCommandInput ;

		// Interrupt
		public delegate void	Interrupt		( ShellForm  sender, EventArgs  e ) ;
		public event		Interrupt		ShellInterrupt ;
		# endregion


		# region Private data members
		// Color for text typed in at the command prompt
		private ColorPair		p_TextColor		=  new ColorPair ( Color. Green, Color. Black ) ;
		// Color for prompt
		private ColorPair		p_PromptColor		=  new ColorPair ( Color. Green, Color. Black ) ;
		// Color for output text
		private ColorPair		p_OutputColor		=  new ColorPair ( Color. Green, Color. Black ) ;
		// Color for error output text
		private ColorPair		p_ErrorColor		=  new ColorPair ( Color. Green, Color. Black ) ;
		// Color for input text
		private ColorPair		p_InputColor		=  new ColorPair ( Color. Green, Color. Black ) ;

		// Size in characters (width and height)
		private Size			p_Size			=  new Size ( 80, 25 ) ;
		// Size in pixels
		private Size			p_ConsoleSize ;
		// Average character size
		private Size			p_CharacterSize ;

		// Caret shapes, expressed in percentage relative to the current font
		internal Rectangle		p_InsertionCaret	=  new Rectangle ( 0, 0,  10, 100 ) ;
		internal Rectangle		p_OverstrikeCaret	=  new Rectangle ( 0, 0, 100, 100 ) ;
		internal Rectangle		p_Caret ;
		internal Color			p_CaretColor		=  Color. Green ;
		internal Bitmap			p_CaretBitmap		=  null ;


		// Editor flags and variables
		internal bool			p_InsertMode		=  true ;		// Insert/overstrike flag
		internal int			p_PromptLength ;				// Prompt length for the current line
		internal ShellHistory		p_History ;					// Command history
		internal ShellHistoryNavigator	p_HistoryNavigator	=  null ;		// Allows to cycle through history
		internal bool			p_ShowStatusBar		=  false ;		// Displays/hides the status bar

		// IO related properties
		internal Prompt			p_Prompt		=  new Prompt ( ) ;
		internal String			p_ReadBuffer		=  "" ;

		// History related properties

		// Design mode flag
		internal bool			p_DesignMode ;

		// Delegates that can be called from the interpreter task
		private delegate void		WriteColorPairDelegate	 ( String  text, ColorPair  color ) ;
		private delegate void		WriteColorDelegate	 ( String  text, Color  color ) ;
		private delegate String		ReadLineDelegate	 ( ) ;
		private delegate int		ReadDelegate		 ( ) ;
		private delegate void		ProcessCommandDelegate	 ( CommandInputEventArgs  args ) ;

		// Stuff related to interpreter task execution
		private Thread			InterpreterThread		=  null ;		// Interpreter thread
		private volatile bool		InterpreterThreadRunning	=  false ;		// True when the thread is running
		private volatile bool		AsynchronousInterpreter		=  false ;		// True when interpreter is asynchronous
		private volatile bool		IsClosing			=  false ;		// True when the form is closing

		// Delegates
		private WriteColorDelegate		WriteColorFunction ;
		private WriteColorPairDelegate		WriteColorPairFunction ;
		private ReadLineDelegate		ReadLineFunction ;
		private ReadDelegate			ReadFunction ;
		private ProcessCommandDelegate		ProcessCommandFunction ;

		# endregion


		# region Constructor
		/// <summary>
		/// Class constructor.
		/// </summary>
		public ShellForm ( )
		   {
			// Design mode or not ?
			p_DesignMode	=  ApplicationAssembly. DesignMode ;

			// Initialize delegates
			ProcessCommandFunction		=  new ProcessCommandDelegate ( this. ProcessCommand ) ;
			ReadLineFunction		=  new ReadLineDelegate ( this. ReadLine ) ;
			ReadFunction			=  new ReadDelegate ( this. Read ) ;
			WriteColorFunction		=  new WriteColorDelegate ( this. Write ) ;
			WriteColorPairFunction		=  new WriteColorPairDelegate ( this. Write ) ;

			// Initialize form's components.
			InitializeComponent ( ) ;

			// Perform some initializations for design mode
			if (  p_DesignMode )
			   {
				base. Font	=  new Font ( "Courier new", 10 ) ;		// Default fixed-pitch form font
			    }

			// Various initializations	
			Console. ShellParent	=  this ;					// Declare we are the console object parent...
			InsertModeChange ( p_InsertMode ) ;					// Set editing mode together with the caret
			p_History = new ShellHistory ( this ) ;					// Command-line history
			
			// Various events
			ShellCommandInput += this. OnCommand ;
			ShellInterrupt    += this. OnInterrupt ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the caret color.
		/// </summary>
		[Category ( "Shell Window" ), Description ( "Specifies the caret color." )]
		public Color  CaretColor
		   {
			get { return ( p_CaretColor ) ; }
			set { p_CaretColor = value ; }
		    }


		/// <summary>
		/// Gets/sets the console size.
		/// </summary>
		[Category ( "Shell Window" ), Description ( "Size in characters of the console window." )]
		public Size  ConsoleSize 
		   {
			get { return ( p_Size ) ; }
			set { SizeChange ( value ) ; }
		    }

	
		/// <summary>
		/// Gets/sets the foreground and background colors for the error output text.
		/// </summary>
		[DesignerSerializationVisibility ( DesignerSerializationVisibility. Content )]
		[Category ( "Shell Window" ), Description ( "Specifies the foreground and background color for the error output text." )]
		public ColorPair  ErrorColor
		   {
			get { return ( p_ErrorColor ) ; }
			set { p_ErrorColor = value ; }
		    }


		/// <summary>
		/// Gets the command history.
		/// </summary>
		[Browsable ( false )]
		public ShellHistory	History
		   {
			get { return ( p_History ) ; }
		    }


		/// <summary>
		/// Overrides the form's Font property to use our own font chooser dialog.
		/// </summary>
		[Editor ( typeof ( FixedPitchFontEditor ), typeof ( System. Drawing. Design. UITypeEditor ) )]
		public override Font  Font 
		   {
			get { return ( base. Font ) ; }
			set 
			   { 
				base. Font		=  value ;  
				Console. Font		=  value ;
				SizeChange ( p_Size ) ;
			    }
		    }


		/// <summary>
		/// Gets/sets the foreground and background colors for the input text.
		/// </summary>
		[DesignerSerializationVisibility ( DesignerSerializationVisibility. Content )]
		[Category ( "Shell Window" ), Description ( "Specifies the foreground and background color for the input text." )]
		public ColorPair  InputColor
		   {
			get { return ( p_InputColor ) ; }
			set { p_InputColor = value ; }
		    }


		/// <summary>
		/// Gets/sets the caret to be used in editor insertion mode.
		/// </summary>
		[Category ( "Shell Window" ), Description ( "Specifies the caret to be used in editor insertion mode." )]
		public Rectangle  InsertionCaret
		   {
			get { return ( p_InsertionCaret ) ; }
			set { p_InsertionCaret = NormalizedRectangle ( value ) ; }
		    }

		
		/// <summary>
		/// Gets/sets the insert mode.
		/// </summary>
		[Category ( "Shell Window" ), Description ( "Indicates the initial editing mode : Insert (true) or overstrike (false)." )]
		public bool  InsertMode
		   {
			get { return ( p_InsertMode ) ; }
			set { InsertModeChange ( value ) ; }
		    }


		/// <summary>
		/// Gets/sets the foreground and background colors for the output text.
		/// </summary>
		[DesignerSerializationVisibility (DesignerSerializationVisibility. Content )]
		[Category ( "Shell Window" ), Description ( "Specifies the foreground and background color for the output text." )]
		public ColorPair  OutputColor
		   {
			get { return ( p_OutputColor ) ; }
			set { p_OutputColor = value ; }
		    }


		/// <summary>
		/// Gets/sets the caret to be used in editor overstrike mode.
		/// </summary>
		[Category ( "Shell Window" ), Description ( "Specifies the caret to be used in editor overstrike mode." )]
		public Rectangle  OverStrikeCaret
		   {
			get { return ( p_OverstrikeCaret ) ; }
			set { p_OverstrikeCaret = NormalizedRectangle ( value ) ; }
		    }


		/// <summary>
		/// Gets/sets the prompt to be displayed.
		/// </summary>
		[Browsable ( false )]
		public Prompt  Prompt
		   {
			get { return ( p_Prompt ) ; }
			set { p_Prompt = value ; }
		    }


		/// <summary>
		/// Gets/sets a value indicating if the status bar is to be shown or not.
		/// </summary>
		[Category ( "Shell Window" ), Description ( "Shows/hides the status bar." )]
		public bool	ShowStatusBar
		   {
			get { return ( p_ShowStatusBar ) ; }
			set
			   {
				p_ShowStatusBar			=  value ;
				ShellStatusBar. Visible		=  value ;
			    }
		    }

		
		/// <summary>
		/// Gets/sets the foreground and background colors for the prompt string.
		/// </summary>
		[DesignerSerializationVisibility (DesignerSerializationVisibility. Content )]
		[Category ( "Shell Window" ), Description ( "Specifies the foreground and background color for the prompt string." )]
		public ColorPair  PromptColor
		   {
			get { return ( p_PromptColor ) ; }
			set { p_PromptColor = value ; }
		    }


		/// <summary>
		/// Gets/sets the foreground and background colors for the text typed in at the command prompt.
		/// </summary>
		[DesignerSerializationVisibility (DesignerSerializationVisibility. Content )]
		[Category ( "Shell Window" ), Description ( "Specifies the foreground and background color for the text typed by the user at the command prompt." )]
		public ColorPair  TextColor
		   {
			get { return ( p_TextColor ) ; }
			set { p_TextColor = value ; }
		    }


		# endregion


		# region Form events
		/// <summary>
		/// Performs some initializations, such as adjusting the form size.
		/// </summary>
		private void  ShellForm_Load ( object  sender, EventArgs  e )
		   {
			// Adjust the console size
			SizeChange ( p_Size ) ;
		    }


		/// <summary>
		/// Stops any interpreter loop started so far.
		/// </summary>
		private void ShellForm_FormClosing ( object sender, FormClosingEventArgs e )
		   {
			IsClosing = true ;

			if  ( InterpreterThreadRunning )
				this. Stop ( ) ;
		    }


		/// <summary>
		/// Resizes the console if the form size is changed.
		/// </summary>
		private void ShellForm_SizeChanged ( object sender, EventArgs e )
		   {
			if  ( this. Handle  !=  IntPtr. Zero  &&  this. Console  !=  null  &&  this. Console. Handle  !=  IntPtr. Zero )
			   {
				Console. Width		=  this. ClientSize. Width ;
				Console. Height		=  this. ClientSize. Height ;
			    }
		    }
		# endregion


		# region Forwarded console events
		/// <summary>
		/// Handles Window message from the rich text control.
		/// </summary>
		/// <param name="msg">Message data.</param>
		/// <param name="handled">Set to true if the function handled the message.</param>
		internal void  OnConsoleMessage ( ref Message  msg, out bool  handled )
		   {
			int		selection_index			=  Console. SelectionStart ;
			int		line_index			=  Console. GetLineFromCharIndex ( selection_index ) ;
			int		line_character_index		=  Console. GetFirstCharIndexFromLine ( line_index ) ;
			int		character_index			=  selection_index - line_character_index ;
			int		last_line_index			=  Console. GetLineFromCharIndex ( Console. Text. Length ) ;
			int		last_line_character_index	=  Console. GetFirstCharIndexFromLine ( last_line_index ) ;
			bool		echo_char ;


			switch  ( msg. Msg )
			   {
				// WM_KEYDOWN -
				//	Process various keys, such as direction keys.
				case	( int ) WM_Constants. WM_KEYDOWN :
					switch  ( ( int ) msg. WParam )
					   {
						// INSERT key -
						//	Toggles insertion mode.
						case  ( int ) VK_Constants. VK_INSERT :
							InsertModeChange ( !  p_InsertMode ) ;
							handled = true ;
							break ;

						// RETURN key -
						//	Puts a line break.
						//	Note : there is no need to echo this character.
						case  ( int ) VK_Constants. VK_RETURN :
							echo_char	=  true ;
							ProcessInputChar ( '\n', ref echo_char ) ;

							if  ( echo_char )
								Write ( "\n", p_OutputColor ) ;

							handled = true ;
							break ;

						// BACKSPACE key -
						//	Deletes the character left to the cursor
						case  ( int ) VK_Constants. VK_BACK :
							// If the selection is outside the current line, the selection will be cancelled 
							// before processing the key
							if  ( Console. SelectionStart  <  last_line_character_index + p_PromptLength )
							   {
								Console. SelectionStart		=  Console. Text. Length ;
								Console. SelectionLength	=  0 ;

								// In this case, no character will be erased
								handled = true ;
								break ;
							    }

							if  ( character_index  >  p_PromptLength )
							   {
								Console. SelectionStart -- ;
								Console. SelectionLength	=  1 ;
								Console. SelectedText		=  "" ;
							    }

							// Update read buffer
							if  ( p_PromptLength  <  Console. Lines [ line_index ]. Length )
								p_ReadBuffer	=  Console. Lines [ line_index ]. Substring ( p_PromptLength ) ;

							p_HistoryNavigator = null ;
							handled = true ;
							break ;

						// DEL key -
						//	Deletes the character right to the cursor.
						case  ( int ) VK_Constants. VK_DELETE :
							// If the selection is outside the current line, the selection will be cancelled 
							// before processing the key
							if  ( Console. SelectionStart  <  last_line_character_index + p_PromptLength )
							   {
								Console. SelectionStart		=  Console. Text. Length ;
								Console. SelectionLength	=  0 ;
							    }

							Console. SelectionLength	=  1 ;
							Console. SelectedText		=  "" ;

							// Update read buffer
							if  ( p_PromptLength  <  Console. Lines [ line_index ]. Length )
								p_ReadBuffer	=  Console. Lines [ line_index ]. Substring ( p_PromptLength ) ;

							p_HistoryNavigator = null ;
							handled = true ;
							break ;

						// LEFT key -
						//	Moves the cursor one character left 
						case  ( int ) VK_Constants. VK_LEFT :
							if  ( character_index  >  p_PromptLength )
								Console. SelectionStart -- ;
							handled = true ;
							break ;

						// RIGHT key :
						//	Moves the cursor one character right.
						case  ( int ) VK_Constants. VK_RIGHT :
							if  ( character_index  <  Console. Lines [ line_index ]. Length )
								Console. SelectionStart ++ ;
							handled = true ;
							break ;

						// UP key :
						//	Recalls the last command in the history.
						// CTRL+UP :
						//	Scrolls up one line.
						case  ( int ) VK_Constants. VK_UP :
							// Crtl+Up : Scroll one line up
							if  ( ( User32. GetAsyncKeyState ( ( int ) VK_Constants. VK_CONTROL )  &  0x8000 ) !=  0 )
								User32.SendMessage ( Console.Handle, ( uint ) WM_Constants. WM_VSCROLL, 
										( int ) SB_Command_Constants. SB_LINEUP, 1 ) ;
							// Up key alone
							else
							   {
								// Create a history navigator if needed, using the current input text
								if  ( p_HistoryNavigator  ==  null )
									p_HistoryNavigator = new ShellHistoryNavigator ( p_History, 
										Console. Text. Substring ( last_line_character_index + p_PromptLength ) ) ;

								// Move backwards
								p_HistoryNavigator. Backward ( ) ;

								// Get current entry 
								ShellHistoryEntry	she	=  p_HistoryNavigator. Current ;

								// If an entry exists, replace the current input line with it
								if  ( she  !=  null )
								   {
									Console. SelectionStart		=  last_line_character_index + p_PromptLength ;
									Console. SelectionLength	=  Console. Text. Length - last_line_character_index - 
														p_PromptLength ;
									Console. SelectionBackColor	=  p_OutputColor. Background ;
									Console. SelectionColor		=  p_OutputColor. Foreground ;
									Console. SelectedText		=  she. Text ;
									p_ReadBuffer			=  she. Text ;
								    }
							    }

							handled = true ;
							break ;

						// DOWN key :
						//	Recalls the next command in the history.
						// CTRL+DOWN :
						//	Scrolls down one line.
						case  ( int ) VK_Constants. VK_DOWN :
							// CTRL+DOWN : scroll one line down
							if  ( ( User32. GetAsyncKeyState ( ( int ) VK_Constants. VK_CONTROL )  &  0x8000 ) !=  0 )
								User32.SendMessage ( Console.Handle, ( uint ) WM_Constants. WM_VSCROLL, 
										( int ) SB_Command_Constants. SB_LINEDOWN, 1 ) ;
							// Up key alone
							else
							   {
								// Create a history navigator if needed, using the current input text
								if  ( p_HistoryNavigator  ==  null )
									p_HistoryNavigator = new ShellHistoryNavigator ( p_History, 
										Console. Text. Substring ( last_line_character_index + p_PromptLength ) ) ;

								// Move backwards
								p_HistoryNavigator. Forward ( ) ;

								// Get current entry 
								ShellHistoryEntry	she	=  p_HistoryNavigator. Current ;

								// If an entry exists, replace the current input line with it
								if  ( she  !=  null )
								   {
									Console. SelectionStart		=  last_line_character_index + p_PromptLength ;
									Console. SelectionLength	=  Console. Text. Length - last_line_character_index - 
														p_PromptLength ;
									Console. SelectionBackColor	=  p_OutputColor. Background ;
									Console. SelectionColor		=  p_OutputColor. Foreground ;
									Console. SelectedText		=  she. Text ;
									p_ReadBuffer			=  she. Text ;
								    }
							    }
	
							handled = true ;
							break ;

						// NEXT key :
						//	Scrolls one page down.
						// CTRL+NEXT :
						//	Show history.
						case  ( int ) VK_Constants. VK_NEXT :
							if  ( ( User32. GetAsyncKeyState ( ( int ) VK_Constants. VK_CONTROL )  &  0x8000 ) !=  0 )
								ShowHistory ( last_line_character_index ) ;
							else
								User32.SendMessage ( Console.Handle, ( uint ) WM_Constants. WM_VSCROLL, 
										( int ) SB_Command_Constants. SB_PAGEDOWN, 1 ) ;
							handled = true ;
							break ;

						// PRIOR key :
						//	Scrolls one page up.
						case  ( int ) VK_Constants. VK_PRIOR :
							if  ( ( User32. GetAsyncKeyState ( ( int ) VK_Constants. VK_CONTROL )  &  0x8000 ) !=  0 )
								ShowHistory ( last_line_character_index ) ;
							else
								User32.SendMessage ( Console.Handle, ( uint ) WM_Constants. WM_VSCROLL, 
										( int ) SB_Command_Constants. SB_PAGEUP, 1 ) ;

							handled = true ;
							break ;

						// HOME key :
						//	Moves the cursor to beginning of line.
						// CTRL+HOME :
						//	Scrolls to the beginning of the contents.
						case  ( int ) VK_Constants. VK_HOME :
							if  ( ( User32. GetAsyncKeyState ( ( int ) VK_Constants. VK_CONTROL )  &  0x8000 ) !=  0 )
								User32.SendMessage ( Console.Handle, ( uint ) WM_Constants. WM_VSCROLL, 
										( int ) SB_Command_Constants. SB_TOP, 0 ) ;
							// Home key alone
							else
								Console. SelectionStart		=  line_character_index + p_PromptLength ;

							handled	= true ;
							break ;

						// END key :
						//	Moves the cursor to the end of line.
						case  ( int ) VK_Constants. VK_END :
							if  ( ( User32. GetAsyncKeyState ( ( int ) VK_Constants. VK_CONTROL )  &  0x8000 ) !=  0 )
								User32.SendMessage ( Console.Handle, ( uint ) WM_Constants. WM_VSCROLL, 
										( int ) SB_Command_Constants. SB_BOTTOM, 0 ) ;
							// End key alone
							else
								Console. SelectionStart		=  Console. Text. Length ;

							handled = true ;
							break ;

						// Keys handled by the rich textbox
						case  ( int ) VK_Constants. VK_E :		// Center text
						case  ( int ) VK_Constants. VK_L :		// Left align text
						case  ( int ) VK_Constants. VK_R :		// Right align text
						case  ( int ) VK_Constants. VK_V :		// Ctrl+V
							handled = true ;
							break ;

						// Other keys -
						//	Say that we didn't handle the message.
						default :
							handled = false ;
							break ;
					    }
					break ;

				// WM_KEYDOWN -
				//	Process other various keys, which could have been handled with WM_KEYDOWN...
				case	( int ) WM_Constants. WM_KEYUP :
					switch ( ( int ) msg. WParam )
					   {
						case	( int ) VK_Constants. VK_TAB :
							handled = true ;
							break ;

						default :
							handled = false ;
							break ;
					    }
					break ;

				// WM_CHAR -
				//	Collects characters to the read buffer.
				case	( int ) WM_Constants. WM_CHAR :
					switch ( ( int ) msg. WParam )
					   {
						// Characters to ignore
						case    0x01 :				// Ctrl+A : let the control select all the text
						case    0x02 :				// Ctrl+B
						case    0x04 :				// Ctrl+D
						case    0x05 :				// Ctrl+E
						case    0x06 :				// Ctrl+F
						case    0x07 :				// Ctrl+G
						case    0x08 :				// Ctrl+H : Backspace character, sent even if we process VK_BACK !
						case	0x0A :				// Ignore line feeds (only keep carriage returns)
						case    0x0B :				// Ctrl+K
						case    0x0C :				// Ctrl+L
						case    0x0E :				// Ctrl+N
						case    0x0F :				// Ctrl+O
						case    0x10 :				// Ctrl+P
						case    0x11 :				// Ctrl+Q
						case    0x12 :				// Ctrl+R
						case    0x13 :				// Ctrl+S
						case    0x14 :				// Ctrl+T
						case    0x15 :				// Ctrl+U
						case    0x16 :				// Ctrl+V
						case    0x17 :				// Ctrl+W
						case    0x18 :				// Ctrl+X
						case    0x19 :				// Ctrl+Y
						case    0x1A :				// Ctrl+Z
						case    0x1C :
						case    0x1D :
						case    0x1E :
						case    0x1F :
							handled		= true ;
							break ;

						// Ctrl + C : Interrupt
						case    0x03 :
							if  ( ShellInterrupt  !=  null )
								ShellInterrupt ( this, new EventArgs ( ) ) ;
							break ;

						// Ctrl+I : Tab
						case    0x09 :
							break ;

						// ESC : Empty the current command line
						case	0x1B :				
							p_ReadBuffer			=  "" ;
							Console. SelectionStart		=  line_character_index + p_PromptLength ;
							Console. SelectionLength	=  Console. Text. Length - Console. SelectionStart ;
							Console. SelectedText		=  "" ;
							break ;

						// Carriage return : end of line marker
						case    0x0D :
							p_ReadBuffer	+=  "\n" ;
							break ;

						// Other characters
						default :
							// Preprocess character
							echo_char	=  true ;
							ProcessInputChar ( ( char ) msg. WParam, ref echo_char ) ;

							// If the selection is outside the current line, the selection will be cancelled and
							// the character will be inserted at the end of the current line
							if  ( Console. SelectionStart  <  last_line_character_index + p_PromptLength )
							   {
								Console. SelectionStart		=  Console. Text. Length ;
								Console. SelectionLength	=  0 ;
							    }

							// If character is to be echoed, add it in the rich edit textbox
							if  ( echo_char )
							   {
								if  ( p_InsertMode )
									Console. SelectionLength	=  0 ;
								else
									Console. SelectionLength	=  1 ;

								Console. SelectionColor		=  p_OutputColor. Foreground ;
								Console. SelectionBackColor	=  p_OutputColor. Background ;
								Console. SelectedText		=  ( ( char ) msg. WParam ). ToString ( ) ;
							    }

							// Update read buffer
							if  ( p_PromptLength  <  Console. Lines [ line_index ]. Length )
								p_ReadBuffer	=  Console. Lines [ line_index ]. Substring ( p_PromptLength ) ;

							break ;
					    }

					p_HistoryNavigator = null ;
					handled = true ;
					break ;

				// Other messages -
				//	Say that we didn't handle the message.
				default :
					handled = false ;
					break ;
			    }
		    }
		# endregion


		# region Interpreter functions
		/// <summary>
		/// Runs the interpreter loop.
		/// </summary>
		public virtual void Run ( ThreadStart  ts  =  null )
		   {
			if  ( InterpreterThreadRunning )
				throw new ShellAlreadyStartedException ( ) ;

			if  ( ts  ==  null )
				ts	=  new ThreadStart ( this. InterpretCommands ) ;

			AsynchronousInterpreter		=  true ;
			InterpreterThreadRunning	=  true ;
			InterpreterThread		=  new Thread ( ts ) ;
			InterpreterThread. Start ( ) ;
		    }


		/// <summary>
		/// Brutally aborts the currently running interpreter loop.
		/// </summary>
		public void  Abort ( )
		   {
			if  ( ! InterpreterThreadRunning )
				throw new ShellNotStartedException ( ) ;

			InterpreterThreadRunning	=  false ;
			InterpreterThread. Abort ( ) ;
			InterpreterThread		=  null ;
		    }


		/// <summary>
		/// Kindly stops the currently running interpreter loop.
		/// </summary>
		public void  Stop ( )
		   {
			InterpreterThreadRunning	=  false ;
			InterpreterThread		=  null ;
		    }


		/// <summary>
		/// Gets a value indicating if the interpreter loop is running.
		/// </summary>
		public bool  IsInterpreterThreadRunning
		   {
			get { return ( InterpreterThreadRunning ) ; }
		    }


		/// <summary>
		/// Returns true if the form is shutting down or if the interpreter loop is exiting.
		/// </summary>
		protected bool  ShutdownRequested
		   {
			get 
			   { 
				return ( IsClosing  ||  
						( AsynchronousInterpreter  &&  ! InterpreterThreadRunning ) ) ;
			    }
		    }

		
		/// <summary>
		/// Reads a character from the current window. To be called from an asynchronous interpreter task.
		/// </summary>
		protected int  InterpreterRead ( )
		   {
			int		ch	=  ( int ) this. Invoke ( ReadFunction ) ;

			return ( ch ) ;
		    }


		/// <summary>
		/// Reads a line from the current window. To be called from an asynchronous interpreter task.
		/// </summary>
		protected String  InterpreterReadLine ( )
		   {
			String		s	=  ( String ) this. Invoke ( ReadLineFunction ) ;

			return ( s ) ;
		    }


		/// <summary>
		/// Writes text to the current window. To be called from an asynchronous interpreter task.
		/// </summary>
		protected void  InterpreterWrite ( String  text, ColorPair  colors )
		   {
			this. Invoke ( WriteColorPairFunction, text, colors ) ;
		    }


		/// <summary>
		/// Writes text to the current window. To be called from an asynchronous interpreter task.
		/// </summary>
		protected void  InterpreterWrite ( String  text, Color  color )
		   {
			this. Invoke ( WriteColorFunction, text, color ) ;
		    }


		/// <summary>
		/// Throws the 'new command input' events. To be called from an asynchronous interpreter task.
		/// </summary>
		protected void  InterpreterProcessCommand ( CommandInputEventArgs  args )
		   {
			this. Invoke ( ProcessCommandFunction, args ) ;
		    }


		/// <summary>
		/// Thread interpreter loop.
		/// </summary>
		private void	InterpretCommands ( )
		   {
			String		PromptText ;


			// Reader loop
			while  ( ! ShutdownRequested )
			   {
				// Write prompt
				PromptText	=  p_Prompt. Text ;
				p_PromptLength	=  PromptText. Length ;			// Remember current prompt length for line editor

				InterpreterWrite ( PromptText, p_PromptColor ) ;
				
				// Get next command. This one does not require calling Invoke() since it does not access any UI item.
				String		cmd ;

				try
				   {
					cmd = InterpreterReadLine ( ) ;
				    }
				catch ( ShellInterruptException )		// Handle Ctrl+C requests
				   {
					p_ReadBuffer	=  "" ;
					InterpreterWrite ( "^C", p_OutputColor ) ;
					continue ;
				    }

				// Exit if shutdown requested 
				if (  ShutdownRequested )
					break ;

				// Process only non-empty lines
				if  ( cmd. Trim ( )  !=  "" )
				   {
					// Build command event args
					CommandInputEventArgs	args	=  new CommandInputEventArgs ( cmd ) ;

					// Process command
					InterpreterProcessCommand ( args ) ;
				    }
			    }
		    }


		/// <summary>
		/// Processes a command from the shell window.
		/// </summary>
		private void  ProcessCommand ( CommandInputEventArgs  args )
		   {
			// Process command
			try 
			   {
				ShellCommandInput ( this, args ) ;

				// Add command to the history
				p_History. Add ( args. Command, 
							Console. GetLineFromCharIndex ( Console. Text. Length ) ) ;
				p_HistoryNavigator = null ;

				// If command is not recognized by derived class, throw an exception
				if  ( ! args. Handled )
					throw new ShellInvalidCommandException ( args. Argv [0] ) ;
			    }
			catch ( Exception  e )
			   {
				Write ( e. Message + "\n", p_ErrorColor ) ;
			    }
		    }


		/// <summary>
		/// Command processor. Derived classes can implement their own processor.
		/// </summary>
		private void  OnCommand ( ShellForm  sender, CommandInputEventArgs  e )
		   {
		    }


		/// <summary>
		/// Interrupt handler event (Ctrl+C).
		/// </summary>
		private void  OnInterrupt ( ShellForm  sender, EventArgs  e )
		   {
			p_ReadBuffer = "" ;
			throw new ShellInterruptException ( ) ;
		    }
		# endregion


		# region I/O methods
		/// <summary>
		/// Reads a character from the console.
		/// </summary>
		/// <returns>The character that has been read.</returns>
		public int  Read ( )
		   {
			// Wait next character
			while  ( p_ReadBuffer. Length  ==  0 )
			   {
				Thread. Sleep ( 10 ) ;
				Application. DoEvents ( ) ;

				// Handle the case where the interpreter thread wants to shut down gracefully...
				if  ( ShutdownRequested )
					return ( EOF ) ;
			    }

			// Dumb way of processing input buffer ; should use a circular buffer instead...
			Char	ch	=  p_ReadBuffer [0] ;

			p_ReadBuffer	=  p_ReadBuffer. Substring ( 1 ) ;

			return ( ch ) ;
		    }


		/// <summary>
		/// Reads an entire line from the console (until a newline character has been encountered).
		/// </summary>
		public String  ReadLine ( )
		   {
			String		result		=  "" ;


			while  ( true )
			   {
				// Handle the case where the interpreter thread wants to shut down gracefully...
				if  ( ShutdownRequested )
					break ;

				// Check if last input character is a newline
				if  ( p_ReadBuffer. Length  >  0 )
				   {
					if  ( p_ReadBuffer  [ p_ReadBuffer. Length - 1 ]  ==  '\n' )
						break ;
				    }

				// Wait a little bit...
				Thread. Sleep ( 10 ) ;

				try 
				   {
					Application. DoEvents ( ) ;
				    }
				catch  ( ShellInterruptException )
				   {
					Write ( "^C\n", p_OutputColor ) ;
					break ;
				    }
			    }

			// Return the input buffer contents, and clear the original one
			result		=  p_ReadBuffer ;
			p_ReadBuffer	=  "" ;
			return ( result ) ;
		    }



		/// <summary>
		/// Writes the specified text to the shell window.
		/// </summary>
		public void  Write ( String  text )
		   {
			Console. AppendText ( text ) ;
			Console. Select ( Console. TextLength, 0 ) ;
		    }


		/// <summary>
		/// Writes text to the shell window, using the specified color.
		/// </summary>
		public void  Write  ( String  text, Color  textcolor )
		   {
			if  ( text. Length  ==  0 )
				return ;

			int		start, end ;

			start		=  Console. TextLength ;
			Console. AppendText ( text ) ;
			end		=  Console. TextLength ;

			Console. Select ( start, end - start ) ;
			Console. SelectionColor		=  textcolor ;
			Console. Select ( Console. TextLength, 0 ) ;
		    }


		/// <summary>
		/// Writes text to the shell window, using the specified color pair.
		/// </summary>
		public void  Write  ( String  text, ColorPair  textcolor )
		   {
			if  ( text. Length  ==  0 )
				return ;

			int		start, end ;

			start		=  Console. TextLength ;
			Console. AppendText ( text ) ;
			end		=  Console. TextLength ;

			Console. Select ( start, end - start ) ;
			Console. SelectionColor		=  textcolor. Foreground ;
			Console. SelectionBackColor	=  textcolor. Background ;
			Console. Select ( Console. TextLength, 0 ) ;
		    }
		# endregion


		# region Support functions
		/// <summary>
		/// Changes the current insertion mode.
		/// </summary>
		/// <param name="value">True for insertion mode, false for overstriker.</param>
		private void  InsertModeChange ( bool  value )
		   {
			p_InsertMode	=  value ;

			if  ( value ) 
				p_Caret	=  p_InsertionCaret ;
			else
				p_Caret	=  p_OverstrikeCaret ;

			SizeChange ( p_Size ) ;

			if  ( ShellInsertModeChanged   !=  null )
				ShellInsertModeChanged ( this, new InsertModeChangedEventArgs ( p_InsertMode ) ) ;

			ShellStatusBarInsertLabel. Text		=  ( value ) ? "INS" : "OVR" ;
		    }


		/// <summary>
		/// Normalizes a rectangle, making sure all coordinates are between 0 and 100%.
		/// </summary>
		private Rectangle  NormalizedRectangle ( Rectangle  rect )
		   {
			if  ( rect. X  <  0 )
				rect. X		=  0 ;
			else if  ( rect. X  >  100 )
				rect.  X	=  100 ;

			if  ( rect. Y  <  0 )
				rect. Y		=  0 ;
			else if  ( rect. Y  >  100 )
				rect. Y		=  100 ;

			if  ( rect. Width  <  0 )
				rect. Width	=  0 ;

			if  ( rect. Height  <  0 )
				rect. Height	=  0 ;

			return ( rect ) ;
		    }


		/// <summary>
		/// Normalizes a size, making sure it is within the authorized min/max width and height.
		/// </summary>
		private Size  NormalizedSize ( Size   value )
		   {
			if  ( value. Width  <  MinConsoleWidth )
				value. Width	=  MinConsoleWidth ;
			else if  ( value. Width  >  MaxConsoleWidth )
				value. Width	=  MaxConsoleWidth ;

			if  ( value. Height  <  MinConsoleHeight )
				value. Height	=  MinConsoleHeight ;
			else if  ( value. Height  >  MaxConsoleHeight )
				value. Height	=  MaxConsoleHeight ;

			return ( value ) ;
		    }


		/// <summary>
		/// Processes an input char, echoing it if necessary.
		/// </summary>
		private void  ProcessInputChar ( char  ch, ref bool  echo )
		   {
			String		value ;


			//p_ReadBuffer. Append ( ch ) ;

			if  ( ShellCharacterInput  !=  null )
			   {
				CharacterInputEventArgs		e	=  new CharacterInputEventArgs ( ch, echo ) ;

				ShellCharacterInput ( this, e ) ;
				echo	=  e. Echo ;
				value   =  e. Input ;
			    }
			else
				value	=  ch. ToString ( ) ;
		    }


		/// <summary>
		/// Shows the history.
		/// </summary>
		/// <param name="cmd_index">Index of the first character of the currently typed command.</param>
		private void  ShowHistory ( int  cmd_index )
		   {
			HistoryForm		hf	=  new HistoryForm ( this ) ;

			
			if  ( hf. ShowDialog ( )  ==  DialogResult. OK )
			   {
				if  ( hf. CommandText  !=  "" )
				   {
					Console. SelectionStart		=  cmd_index + p_PromptLength ;
					Console. SelectionLength	=  Console. Text. Length - cmd_index - p_PromptLength ;
					Console. SelectionBackColor	=  p_OutputColor. Background ;
					Console. SelectionColor		=  p_OutputColor. Foreground ;
					Console. SelectedText		=  hf. CommandText ;
					p_ReadBuffer			=  hf. CommandText ;
				    }
			    }
		    }


		/// <summary>
		/// Changes the size (width and height in characters) of the console.
		/// </summary>
		private void  SizeChange ( Size  value )
		   {
			// Make sure that the new cols*lines size has correct values
			p_Size	=  NormalizedSize ( value ) ;

			// We will have to measure how many pixels takes a string of p_Size.Width characters.
			// Curiously, taking the size of one single character multiplied by the number of characters we want
			// does not give the same result as taking the size of a string of p_Size.Width characters.
			// We will thus build a string of p_Size.Width characters and measure it.
			// Note that measuring the height of one line and multiplying it by p_Size.Height gives the correct result !
			// Note also that this method works only because we are using fixed-pitch fonts.
			String				test		=  new String ( '0', p_Size. Width ) ;
			System. Drawing. Graphics	gdi		=  Console. CreateGraphics ( ) ;
			SizeF				fsize ;

			gdi. PageUnit		=  GraphicsUnit. Pixel ;
			fsize			=  gdi. MeasureString ( test, base. Font ) ;
			gdi. Dispose ( ) ;

			// Adjust console size and enclosing form client area accordingly
			SuspendLayout ( ) ;
			Console. ClientSize	=  new Size ( ( int ) fsize. Width, ( int ) ( p_Size. Height * fsize. Height ) ) ;
			ClientSize		=  Console. Size ;
			ResumeLayout ( ) ;

			// Save actual console size ; could serve later...
			p_ConsoleSize. Width	=  ( int ) fsize. Width ;
			p_ConsoleSize. Height	=  ( int ) fsize. Height ;

			// Save character size
			p_CharacterSize. Width	=  p_ConsoleSize. Width / p_Size. Width ;
			p_CharacterSize. Height =  base. Font. Height ;

			// Get the correct caret dimensions
			if  ( p_InsertMode )
				p_Caret		=  p_InsertionCaret ;
			else
				p_Caret		=  p_OverstrikeCaret ;

			// Recreate the caret bitmap
			Rectangle	rect		=  p_Caret ;
			Rectangle	absrect		=  new Rectangle ( ) ;

			absrect. X		=  ( int ) System. Math. Ceiling ( ( double ) ( ( p_CharacterSize. Width  * rect. X      ) / 100 ) ) ;
			absrect. Y		=  ( int ) System. Math. Ceiling ( ( double ) ( ( p_CharacterSize. Height * rect. Y      ) / 100 ) ) ;
			absrect. Width		=  ( int ) System. Math. Ceiling ( ( double ) ( ( p_CharacterSize. Width  * rect. Width  ) / 100 ) ) ;
			absrect. Height		=  ( int ) System. Math. Ceiling ( ( double ) ( ( p_CharacterSize. Height * rect. Height ) / 100 ) ) ;

			if  ( absrect. Width  ==  0 )
				absrect. Width = 1 ;

			if  ( absrect. Height  ==  0 )
				absrect. Height = 1 ;

			absrect. Height ++ ;		// It's visually more comfortable to have one more pixel at the bottom of the caret

			Bitmap		caret		=  new Bitmap ( absrect. Width, absrect. Height ) ;
			SolidBrush	white_brush	=  new SolidBrush ( Color. White ) ;
			SolidBrush	caret_brush	=  new SolidBrush ( p_CaretColor ) ;

			gdi		=  System. Drawing. Graphics. FromImage ( caret ) ;
			gdi. FillRectangle ( white_brush, 0, 0, p_CharacterSize. Width, p_CharacterSize. Height ) ;
			gdi. FillRectangle ( caret_brush, absrect ) ;
			gdi. Dispose ( ) ;

			p_CaretBitmap	=  caret ;

			Console. ShowCaret ( ) ;
		    }
		# endregion

	    }
	# endregion
     }
