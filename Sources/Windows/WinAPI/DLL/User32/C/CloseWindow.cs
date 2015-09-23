/**************************************************************************************************************

    NAME
        WinAPI/User32/C/CloseWindow.cs

    DESCRIPTION
        CloseWindow() Windows function.

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
		/// Minimizes (but does not destroy) the specified window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window to be minimized. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// To destroy a window, an application must use the DestroyWindow function. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CloseWindow ( IntPtr  hwnd ) ;
		# endregion
	    }
    }