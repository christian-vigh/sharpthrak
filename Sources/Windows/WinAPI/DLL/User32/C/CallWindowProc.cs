/**************************************************************************************************************

    NAME
        WinAPI/User32/C/CallWindowProc.cs

    DESCRIPTION
        CallWindowProc() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Callbacks ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Passes message information to the specified window procedure.
		/// </summary>
		/// <param name="lpPrevWndFunc">
		/// The previous window procedure. If this value is obtained by calling the GetWindowLong function with the nIndex parameter set to GWL_WNDPROC or DWL_DLGPROC, 
		/// it is actually either the address of a window or dialog box procedure, or a special internal value meaningful only to CallWindowProc. 
		/// </param>
		/// <param name="hWnd">A handle to the window procedure to receive the message. </param>
		/// <param name="Msg">The message.</param>
		/// <param name="wParam">Additional message-specific information. The contents of this parameter depend on the value of the Msg parameter. </param>
		/// <param name="lParam">Additional message-specific information. The contents of this parameter depend on the value of the Msg parameter. </param>
		/// <returns>The return value specifies the result of the message processing and depends on the message sent. </returns>
		/// <remarks>
		/// Use the CallWindowProc function for window subclassing. Usually, all windows with the same class share one window procedure. 
		/// A subclass is a window or set of windows with the same class whose messages are intercepted and processed by another window procedure (or procedures) 
		/// before being passed to the window procedure of the class. 
		/// <para>
		/// The SetWindowLong function creates the subclass by changing the window procedure associated with a particular window, causing the system to call 
		/// the new window procedure instead of the previous one. An application must pass any messages not processed by the new window procedure to the 
		/// previous window procedure by calling CallWindowProc. This allows the application to create a chain of window procedures. 
		/// </para>
		/// <para>
		/// The CallWindowProc function handles Unicode-to-ANSI conversion. You cannot take advantage of this conversion if you call the window procedure directly. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CallWindowProc ( WNDPROC  lpPrevWndFunc, IntPtr  hWnd, uint  Msg, IntPtr  wParam, IntPtr  lParam ) ;
		# endregion
	    }
    }