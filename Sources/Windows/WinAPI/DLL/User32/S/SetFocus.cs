/**************************************************************************************************************

    NAME
        WinAPI/Functions/S/SetFocus.cs

    DESCRIPTION
        SetFocus() Windows function.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Sets the keyboard focus to the specified window. The window must be attached to the calling thread's message queue. 
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window that will receive the keyboard input. If this parameter is NULL, keystrokes are ignored. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to the window that previously had the keyboard focus. 
		/// If the hWnd parameter is invalid or the window is not attached to the calling thread's message queue, the return value is NULL. 
		/// To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// The SetFocus function sends a WM_KILLFOCUS message to the window that loses the keyboard focus and a WM_SETFOCUS message to the window 
		/// that receives the keyboard focus. It also activates either the window that receives the focus or the parent of the window that receives 
		/// the focus. 
		/// <br/>
		/// <para>
		/// If a window is active but does not have the focus, any key pressed will produce the WM_SYSCHAR, WM_SYSKEYDOWN, or WM_SYSKEYUP message.
		/// If the VK_MENU key is also pressed, the lParam parameter of the message will have bit 30 set. 
		/// Otherwise, the messages produced do not have this bit set. 
		/// </para>
		/// <br/>
		/// <para>
		/// By using the AttachThreadInput function, a thread can attach its input processing to another thread.
		/// This allows a thread to call SetFocus to set the keyboard focus to a window attached to another thread's message queue. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	SetFocus ( IntPtr  hWnd ) ;
		# endregion
	    }
    }