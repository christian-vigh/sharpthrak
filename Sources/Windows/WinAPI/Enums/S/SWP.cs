/**************************************************************************************************************

    NAME
        WinAPI/Constants/S/SWP.cs

    DESCRIPTION
        SWP constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region SWP_ constants
	/// <summary>
	/// SetWindowPos flags.
	/// </summary>
	public enum SWP_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		SWP_NONE		=  0x0000,

		/// <summary>
		/// Draws a frame (defined in the window's class description) around the window. Same as the SWP_FRAMECHANGED flag.
		/// </summary>
		SWP_DRAWFRAME		=  0x0020,

		/// <summary>
		/// Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed. 
		/// <para>
		/// If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
		/// </para>
		/// </summary>
		SWP_FRAMECHANGED	=  0x0020,

		/// <summary>
		/// Hides the window.
		/// </summary>
		SWP_HIDEWINDOW		=  0x0080,

		/// <summary>
		/// Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the topmost or non-topmost group 
		/// (depending on the setting of the hwndInsertAfter member).
		/// </summary>
		SWP_NOACTIVATE		=  0x0010,

		/// <summary>
		/// Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back 
		/// into the client area after the window is sized or repositioned.
		/// </summary>
		SWP_NOCOPYBITS		=  0x0100,

		/// <summary>
		/// Retains the current position (ignores the x and y members).
		/// </summary>
		SWP_NOMOVE		=  0x0002,

		/// <summary>
		/// Does not change the owner window's position in the Z order.
		/// </summary>
		SWP_NOOWNERZORDER	=  0x0200,

		/// <summary>
		/// Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area 
		/// (including the title bar and scroll bars), and any part of the parent window uncovered as a result of the window being moved. 
		/// <para>
		/// When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
		/// </para>
		/// </summary>
		SWP_NOREDRAW		=  0x0008,

		/// <summary>
		/// Does not change the owner window's position in the Z order. Same as the SWP_NOOWNERZORDER flag.
		/// </summary>
		SWP_NOREPOSITION	=  0x0200,

		/// <summary>
		/// Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
		/// </summary>
		SWP_NOSENDCHANGING	=  0x0400,

		/// <summary>
		/// Retains the current size (ignores the cx and cy members).
		/// </summary>
		SWP_NOSIZE		=  0x0001,

		/// <summary>
		/// Retains the current Z order (ignores the hwndInsertAfter member).
		/// </summary>
		SWP_NOZORDER		=  0x0004,

		/// <summary>
		/// Displays the window.
		/// </summary>
		SWP_SHOWWINDOW		=  0x0040,

		/// <summary>
		/// Prevents generation of the WM_SYNCPAINT message.
		/// </summary>
		SWP_DEFERERASE		=  0x2000,

		/// <summary>
		/// If the calling thread and the thread that owns the window are attached to different input queues, the system posts the request to the thread 
		/// that owns the window. This prevents the calling thread from blocking its execution while other threads process the request. 
		/// </summary>
		SWP_ASYNCWINDOWPOS	=  0x4000
	    }
	# endregion
    }