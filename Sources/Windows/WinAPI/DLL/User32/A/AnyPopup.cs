/**************************************************************************************************************

    NAME
        WinAPI/User32/A/AnyPopup.cs

    DESCRIPTION
        AnyPopup() Windows function.

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
		/// Indicates whether an owned, visible, top-level pop-up, or overlapped window exists on the screen. The function searches the entire screen, 
		/// not just the calling application's client area.
		/// <br/>
		/// <para>
		/// This function is provided only for compatibility with 16-bit versions of Windows. It is generally not useful.
		/// </para>
		/// </summary>
		/// <returns>
		/// If a pop-up window exists, the return value is nonzero, even if the pop-up window is completely covered by other windows.
		/// <para>
		/// If a pop-up window does not exist, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function does not detect unowned pop-up windows or windows that do not have the WS_VISIBLE style bit set. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	AnyPopup ( ) ;
		# endregion
	    }
    }