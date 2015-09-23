/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetWindowPos.cs

    DESCRIPTION
        SetWindowPos() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
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
		/// Changes the size, position, and Z order of a child, pop-up, or top-level window. These windows are ordered according to their appearance on the screen. 
		/// The topmost window receives the highest rank and is the first window in the Z order.
		/// </summary>
		/// <param name="hwnd">A handle to the window.</param>
		/// <param name="hwndInsertAfter">
		/// A handle to the window to precede the positioned window in the Z order. This parameter must be a window handle or one of the HWND_Constants values.
		/// </param>
		/// <param name="x">The new position of the left side of the window, in client coordinates. </param>
		/// <param name="y">The new position of the top of the window, in client coordinates. </param>
		/// <param name="cx">The new width of the window, in pixels. </param>
		/// <param name="cy">The new height of the window, in pixels. </param>
		/// <param name="uFlags">The window sizing and positioning flags. This parameter can be a combination of the SWP_Constants values.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// As part of the Vista re-architecture, all services were moved off the interactive desktop into Session 0. hwnd and window manager operations are 
		/// only effective inside a session and cross-session attempts to manipulate the hwnd will fail.
		/// <br/>
		/// <para>
		/// If you have changed certain window data using SetWindowLong, you must call SetWindowPos for the changes to take effect. 
		/// Use the following combination for uFlags: SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED. 
		/// </para>
		/// <br/>
		/// <para>
		/// A window can be made a topmost window either by setting the hWndInsertAfter parameter to HWND_TOPMOST and ensuring that the SWP_NOZORDER flag is not set, 
		/// or by setting a window's position in the Z order so that it is above any existing topmost windows. When a non-topmost window is made topmost, 
		/// its owned windows are also made topmost. Its owners, however, are not changed. 
		/// </para>
		/// <br/>
		/// <para>
		/// If neither the SWP_NOACTIVATE nor SWP_NOZORDER flag is specified (that is, when the application requests that a window be simultaneously activated 
		/// and its position in the Z order changed), the value specified in hWndInsertAfter is used only in the following circumstances :
		/// </para>
		/// <para>
		/// • Neither the HWND_TOPMOST nor HWND_NOTOPMOST flag is specified in hWndInsertAfter. 
		/// </para>
		/// <para>
		/// •The window identified by hWnd is not the active window. 
		/// </para>
		/// <br/>
		/// <para>
		/// An application cannot activate an inactive window without also bringing it to the top of the Z order. Applications can change an activated window's position 
		/// in the Z order without restrictions, or it can activate a window and then move it to the top of the topmost or non-topmost windows. 
		/// </para>
		/// <br/>
		/// <para>
		/// If a topmost window is repositioned to the bottom (HWND_BOTTOM) of the Z order or after any non-topmost window, it is no longer topmost. 
		/// When a topmost window is made non-topmost, its owners and its owned windows are also made non-topmost windows. 
		/// </para>
		/// <br/>
		/// <para>
		/// A non-topmost window can own a topmost window, but the reverse cannot occur. Any window (for example, a dialog box) owned by a topmost window is 
		/// itself made a topmost window, to ensure that all owned windows stay above their owner. 
		/// </para>
		/// <br/>
		/// <para>
		/// If an application is not in the foreground, and should be in the foreground, it must call the SetForegroundWindow function. 
		/// </para>
		/// <br/>
		/// <para>
		/// To use SetWindowPos to bring a window to the top, the process that owns the window must have SetForegroundWindow permission. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetWindowPos ( IntPtr  hwnd, IntPtr  hwndInsertAfter, int  x, int  y, int  cx, int  cy, SWP_Constants  uFlags ) ;
		# endregion


		# region Version with a HWND constant for the hwndInsertAfter parameter.
		/// <summary>
		/// Changes the size, position, and Z order of a child, pop-up, or top-level window. These windows are ordered according to their appearance on the screen. 
		/// The topmost window receives the highest rank and is the first window in the Z order.
		/// </summary>
		/// <param name="hwnd">A handle to the window.</param>
		/// <param name="hwndInsertAfter">
		/// A handle to the window to precede the positioned window in the Z order. This parameter must be a window handle or one of the HWND_Constants values.
		/// </param>
		/// <param name="x">The new position of the left side of the window, in client coordinates. </param>
		/// <param name="y">The new position of the top of the window, in client coordinates. </param>
		/// <param name="cx">The new width of the window, in pixels. </param>
		/// <param name="cy">The new height of the window, in pixels. </param>
		/// <param name="uFlags">The window sizing and positioning flags. This parameter can be a combination of the SWP_Constants values.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// As part of the Vista re-architecture, all services were moved off the interactive desktop into Session 0. hwnd and window manager operations are 
		/// only effective inside a session and cross-session attempts to manipulate the hwnd will fail.
		/// <br/>
		/// <para>
		/// If you have changed certain window data using SetWindowLong, you must call SetWindowPos for the changes to take effect. 
		/// Use the following combination for uFlags: SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED. 
		/// </para>
		/// <br/>
		/// <para>
		/// A window can be made a topmost window either by setting the hWndInsertAfter parameter to HWND_TOPMOST and ensuring that the SWP_NOZORDER flag is not set, 
		/// or by setting a window's position in the Z order so that it is above any existing topmost windows. When a non-topmost window is made topmost, 
		/// its owned windows are also made topmost. Its owners, however, are not changed. 
		/// </para>
		/// <br/>
		/// <para>
		/// If neither the SWP_NOACTIVATE nor SWP_NOZORDER flag is specified (that is, when the application requests that a window be simultaneously activated 
		/// and its position in the Z order changed), the value specified in hWndInsertAfter is used only in the following circumstances :
		/// </para>
		/// <para>
		/// • Neither the HWND_TOPMOST nor HWND_NOTOPMOST flag is specified in hWndInsertAfter. 
		/// </para>
		/// <para>
		/// •The window identified by hWnd is not the active window. 
		/// </para>
		/// <br/>
		/// <para>
		/// An application cannot activate an inactive window without also bringing it to the top of the Z order. Applications can change an activated window's position 
		/// in the Z order without restrictions, or it can activate a window and then move it to the top of the topmost or non-topmost windows. 
		/// </para>
		/// <br/>
		/// <para>
		/// If a topmost window is repositioned to the bottom (HWND_BOTTOM) of the Z order or after any non-topmost window, it is no longer topmost. 
		/// When a topmost window is made non-topmost, its owners and its owned windows are also made non-topmost windows. 
		/// </para>
		/// <br/>
		/// <para>
		/// A non-topmost window can own a topmost window, but the reverse cannot occur. Any window (for example, a dialog box) owned by a topmost window is 
		/// itself made a topmost window, to ensure that all owned windows stay above their owner. 
		/// </para>
		/// <br/>
		/// <para>
		/// If an application is not in the foreground, and should be in the foreground, it must call the SetForegroundWindow function. 
		/// </para>
		/// <br/>
		/// <para>
		/// To use SetWindowPos to bring a window to the top, the process that owns the window must have SetForegroundWindow permission. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetWindowPos ( IntPtr  hwnd, HWND_Constants  hwndInsertAfter, int  x, int  y, int  cx, int  cy, SWP_Constants  uFlags ) ;
		# endregion
	    }
    }