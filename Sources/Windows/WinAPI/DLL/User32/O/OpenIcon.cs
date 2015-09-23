/**************************************************************************************************************

    NAME
        WinAPI/User32/O/OpenIcon.cs

    DESCRIPTION
        OpenIcon() Windows function.

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
		/// Restores a minimized (iconic) window to its previous size and position; it then activates the window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window to be restored and activated. </param>
		/// <returns>
		/// the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// OpenIcon sends a WM_QUERYOPEN message to the given window. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	OpenIcon ( IntPtr  hwnd ) ;
		# endregion
	    }
    }