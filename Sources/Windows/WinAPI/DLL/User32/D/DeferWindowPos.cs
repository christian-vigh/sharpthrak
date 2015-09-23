/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DeferWindowPos.cs

    DESCRIPTION
        DeferWindowPos() Windows function.

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
		/// Updates the specified multiple-window – position structure for the specified window. The function then returns a handle to the updated structure. 
		/// The EndDeferWindowPos function uses the information in this structure to change the position and size of a number of windows simultaneously. 
		/// The BeginDeferWindowPos function creates the structure. 
		/// </summary>
		/// <param name="hWinPosInfo">
		/// A handle to a multiple-window – position structure that contains size and position information for one or more windows. 
		/// This structure is returned by BeginDeferWindowPos or by the most recent call to DeferWindowPos. 
		/// </param>
		/// <param name="hwnd">
		/// A handle to the window for which update information is stored in the structure. All windows in a multiple-window – position structure must have the same parent. 
		/// </param>
		/// <param name="hWndInsertAfter">
		/// A handle to the window that precedes the positioned window in the Z order. This parameter must be a window handle or one of the HWND_Constants values. 
		/// This parameter is ignored if the SWP_NOZORDER flag is set in the uFlags parameter. 
		/// </param>
		/// <param name="x">The x-coordinate of the window's upper-left corner. </param>
		/// <param name="y">The y-coordinate of the window's upper-left corner. </param>
		/// <param name="cx">The window's new width, in pixels. </param>
		/// <param name="cy">The window's new height, in pixels. </param>
		/// <param name="uFlags">A combination of one or more SWP_Constants values.</param>
		/// <returns></returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	DeferWindowPos ( IntPtr  hWinPosInfo, IntPtr  hwnd, IntPtr  hWndInsertAfter, 
								 int  x, int  y, int  cx, int  cy, SWP_Constants  uFlags ) ;
		# endregion


		# region Version with HWND_Constants for the hWndInsertAfter parameter
		/// <summary>
		/// Updates the specified multiple-window – position structure for the specified window. The function then returns a handle to the updated structure. 
		/// The EndDeferWindowPos function uses the information in this structure to change the position and size of a number of windows simultaneously. 
		/// The BeginDeferWindowPos function creates the structure. 
		/// </summary>
		/// <param name="hWinPosInfo">
		/// A handle to a multiple-window – position structure that contains size and position information for one or more windows. 
		/// This structure is returned by BeginDeferWindowPos or by the most recent call to DeferWindowPos. 
		/// </param>
		/// <param name="hwnd">
		/// A handle to the window for which update information is stored in the structure. All windows in a multiple-window – position structure must have the same parent. 
		/// </param>
		/// <param name="hWndInsertAfter">
		/// A handle to the window that precedes the positioned window in the Z order. This parameter must be a window handle or one of the HWND_Constants values. 
		/// This parameter is ignored if the SWP_NOZORDER flag is set in the uFlags parameter. 
		/// </param>
		/// <param name="x">The x-coordinate of the window's upper-left corner. </param>
		/// <param name="y">The y-coordinate of the window's upper-left corner. </param>
		/// <param name="cx">The window's new width, in pixels. </param>
		/// <param name="cy">The window's new height, in pixels. </param>
		/// <param name="uFlags">A combination of one or more SWP_Constants values.</param>
		/// <returns></returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	DeferWindowPos ( IntPtr  hWinPosInfo, IntPtr  hwnd, HWND_Constants  hWndInsertAfter, 
								 int  x, int  y, int  cx, int  cy, SWP_Constants  uFlags ) ;
		# endregion
	    }
    }