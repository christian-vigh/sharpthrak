/**************************************************************************************************************

    NAME
        WinAPI/User32/M/MoveWindow.cs

    DESCRIPTION
        MoveWindow() Windows function.

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
		/// Changes the position and dimensions of the specified window. For a top-level window, the position and dimensions are relative to the upper-left corner of the screen. 
		/// For a child window, they are relative to the upper-left corner of the parent window's client area. 
		/// </summary>
		/// <param name="hwnd">A handle to the window. </param>
		/// <param name="X">The new position of the left side of the window. </param>
		/// <param name="Y">The new position of the top of the window. </param>
		/// <param name="nWidth">The new width of the window. </param>
		/// <param name="nHeight">The new height of the window. </param>
		/// <param name="bRepaint">
		/// Indicates whether the window is to be repainted. If this parameter is TRUE, the window receives a message. 
		/// If the parameter is FALSE, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title bar and scroll bars), 
		/// and any part of the parent window uncovered as a result of moving a child window. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the bRepaint parameter is TRUE, the system sends the WM_PAINT message to the window procedure immediately after moving the window 
		/// (that is, the MoveWindow function calls the UpdateWindow function). 
		/// If bRepaint is FALSE, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
		/// <br/>
		/// <para>
		/// MoveWindow sends the WM_WINDOWPOSCHANGING, WM_WINDOWPOSCHANGED, WM_MOVE, WM_SIZE, and WM_NCCALCSIZE messages to the window. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	MoveWindow ( IntPtr  hwnd, int  X, int  Y, int  nWidth, int  nHeight, bool  bRepaint ) ;
		# endregion
	    }
    }