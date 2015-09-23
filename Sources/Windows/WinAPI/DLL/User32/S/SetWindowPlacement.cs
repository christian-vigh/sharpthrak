/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetWindowPlacement.cs

    DESCRIPTION
        SetWindowPlacement() Windows function.

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
		/// Sets the show state and the restored, minimized, and maximized positions of the specified window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window. </param>
		/// <param name="lpwndpl">
		/// A pointer to a WINDOWPLACEMENT structure that specifies the new show state and window positions.
		/// <br/>
		/// <para>
		/// Before calling SetWindowPlacement, set the length member of the WINDOWPLACEMENT structure to sizeof(WINDOWPLACEMENT). 
		/// SetWindowPlacement fails if the length member is not set correctly.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the information specified in WINDOWPLACEMENT would result in a window that is completely off the screen, the system will automatically adjust 
		/// the coordinates so that the window is visible, taking into account changes in screen resolution and multiple monitor configuration. 
		/// <br/>
		/// <para>
		/// The length member of WINDOWPLACEMENT must be set to sizeof(WINDOWPLACEMENT). If this member is not set correctly, the function returns FALSE. 
		/// For additional remarks on the proper use of window placement coordinates, see WINDOWPLACEMENT. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetWindowPlacement ( IntPtr  hwnd, ref WINDOWPLACEMENT  lpwndpl ) ;
		# endregion
	    }
    }