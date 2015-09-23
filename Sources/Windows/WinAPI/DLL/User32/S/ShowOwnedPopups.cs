/**************************************************************************************************************

    NAME
        WinAPI/User32/S/ShowOwnedPopups.cs

    DESCRIPTION
        ShowOwnedPopups() Windows function.

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
		/// Shows or hides all pop-up windows owned by the specified window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window that owns the pop-up windows to be shown or hidden. </param>
		/// <param name="fShow">If this parameter is TRUE, all hidden pop-up windows are shown. If this parameter is FALSE, all visible pop-up windows are hidden. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// ShowOwnedPopups shows only windows hidden by a previous call to ShowOwnedPopups. For example, if a pop-up window is hidden by using the ShowWindow function, 
		/// subsequently calling ShowOwnedPopups with the fShow parameter set to TRUE does not cause the window to be shown. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ShowOwnedPopups ( IntPtr  hwnd, bool  fShow ) ;
		# endregion
	    }
    }