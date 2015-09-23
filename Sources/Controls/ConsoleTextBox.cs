/**************************************************************************************************************

    NAME
        ConsoleTextBox.cs

    DESCRIPTION
        A console text box used internally by the ShellForm component.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/18]     [Author : CV]
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


using   Thrak. Core. Assembly ;
using   Thrak. Graphics ;
using	Thrak. WinAPI. Enums ;
using   Thrak. WinAPI. DLL ;


namespace Thrak. Forms
   {
	internal partial class ConsoleTextBox : RichTextBox
	   {
		// Parent form
		internal ShellForm	ShellParent ;


		/// <summary>
		/// Default constructor.
		/// </summary>
		internal ConsoleTextBox ( )
		   {
			InitializeComponent ( ) ;
			this. WordWrap = false ;
		    }


		/// <summary>
		/// Shows the caret.
		/// </summary>
		internal void  ShowCaret ( )
		   {
			if  ( ShellParent  !=  null   &&  ShellParent. p_CaretBitmap  !=  null )
			   {
				User32. CreateCaret ( this. Handle, ShellParent. p_CaretBitmap. GetHbitmap ( ), 0, 0 ) ;
				User32. ShowCaret ( this. Handle ) ;
			    }
		    }


		/// <summary>
		/// General window proc, mainly used to forward message to the parent window.
		/// </summary>
		protected override void  WndProc ( ref Message  msg )
		   {
			// The shell parent may be null, for example when loading the Visual Studio project...
			if  ( ShellParent  ==  null )
			   {
				base. WndProc ( ref  msg ) ;
				return ;
			    }

			// Forward some messages to the shell parent window
			bool		Handled		=  false ;

			
			switch  ( ( WM_Constants )  msg. Msg )
			   {
				// Forward keyboard and mouse messages
				case	WM_Constants. WM_KEYDOWN	:
				case	WM_Constants. WM_KEYUP		:
				case	WM_Constants. WM_CHAR		:
				case	WM_Constants. WM_SYSKEYDOWN	:
				case	WM_Constants. WM_SYSKEYUP	:
				case	WM_Constants. WM_SYSCHAR	:
				case	WM_Constants. WM_LBUTTONDOWN	:
				case    WM_Constants. WM_RBUTTONDOWN	:
				case	WM_Constants. WM_XBUTTONDOWN	:
				case	WM_Constants. WM_LBUTTONUP	:
				case    WM_Constants. WM_RBUTTONUP	:
				case	WM_Constants. WM_XBUTTONUP	:
					ShellParent. OnConsoleMessage ( ref  msg, out  Handled ) ;
					break ;

				default :
					break ;
			    }
			    

			// If the message was not handled by the shell parent form, then let the base class a chance to process it
			if  ( ! Handled )
				base. WndProc ( ref  msg ) ;

			// We can safely change the caret in the following situations :
			// - When the window is repainted
			// - When we receive a notification message. Note that since we are a subclass of the RitchTextBox, we should
			//   not receive them directly ; actually, we receive them through a WM_REFLECT message from MFC.
			// - When the window receives the focus
			if  ( ( int ) msg. Msg  ==  ( int ) WM_Constants. WM_PAINT  ||
			      ( int ) msg. Msg  ==  ( int ) WM_Constants. WM_REFLECT + ( int ) WM_Constants. WM_NOTIFY )
			   {
				ShowCaret ( ) ;
			    }
			else if  ( ( int ) msg. Msg  ==  ( int ) WM_Constants. WM_SETFOCUS ) 
			   {
				ShowCaret ( ) ;
			    }
		    }
	    }
    }
