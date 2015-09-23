/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsIconic.cs

    DESCRIPTION
        IsIconic() Windows function.

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
		/// Determines whether the specified window is minimized (iconic).
		/// </summary>
		/// <param name="hwnd">A handle to the window to be tested.</param>
		/// <returns>
		/// If the window is iconic, the return value is nonzero.
		/// <para>
		/// If the window is not iconic, the return value is zero.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsIconic ( IntPtr  hwnd ) ;
		# endregion
	    }
    }