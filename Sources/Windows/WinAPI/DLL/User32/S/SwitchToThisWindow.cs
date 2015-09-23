/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SwitchToThisWindow.cs

    DESCRIPTION
        SwitchToThisWindow() Windows function.

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
		/// Switches focus to the specified window and brings it to the foreground.
		/// </summary>
		/// <param name="hWnd">A handle to the window. </param>
		/// <param name="fAltTab">
		/// A TRUE for this parameter indicates that the window is being switched to using the Alt/Ctl+Tab key sequence. 
		/// This parameter should be FALSE otherwise.
		/// </param>
		/// 
		/// <remarks>
		/// This function is typically called to maintain window z-ordering. 
		/// <br/>
		/// <para>
		/// This function was not included in the SDK headers and libraries until Windows XP with Service Pack 1 (SP1) and Windows Server 2003. 
		/// If you do not have a header file and import library for this function, you can call the function using LoadLibrary and GetProcAddress.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern void	SwitchToThisWindow ( IntPtr  hWnd, bool  fAltTab ) ;
		# endregion
	    }
    }