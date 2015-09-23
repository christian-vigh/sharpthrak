/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowPlacement.cs

    DESCRIPTION
        GetWindowPlacement() Windows function.

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
		/// Retrieves the show state and the restored, minimized, and maximized positions of the specified window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window. </param>
		/// <param name="lpwndpl">
		/// A pointer to the WINDOWPLACEMENT structure that receives the show state and position information. Before calling GetWindowPlacement, 
		/// set the length member to sizeof(WINDOWPLACEMENT). GetWindowPlacement fails if lpwndpl-> length is not set correctly. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The flags member of WINDOWPLACEMENT retrieved by this function is always zero. If the window identified by the hWnd parameter is maximized, 
		/// the showCmd member is SW_SHOWMAXIMIZED. If the window is minimized, showCmd is SW_SHOWMINIMIZED. Otherwise, it is SW_SHOWNORMAL. 
		/// <para>
		/// The length member of WINDOWPLACEMENT must be set to sizeof(WINDOWPLACEMENT). If this member is not set correctly, the function returns FALSE. 
		/// For additional remarks on the proper use of window placement coordinates, see WINDOWPLACEMENT. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetWindowPlacement ( IntPtr  hwnd, out WINDOWPLACEMENT  lpwndpl ) ;
		# endregion
	    }
    }