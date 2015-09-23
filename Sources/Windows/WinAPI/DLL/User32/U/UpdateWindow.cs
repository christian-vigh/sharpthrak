/**************************************************************************************************************

    NAME
        WinAPI/User32/U/UpdateWindow.cs

    DESCRIPTION
        UpdateWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
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
		/// The UpdateWindow function updates the client area of the specified window by sending a WM_PAINT message to the window if the window's update region is not empty. 
		/// The function sends a WM_PAINT message directly to the window procedure of the specified window, bypassing the application queue. 
		/// If the update region is empty, no message is sent.
		/// </summary>
		/// <param name="hWnd">Handle to the window to be updated.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	UpdateWindow ( IntPtr  hWnd ) ;
		# endregion
	    }
    }