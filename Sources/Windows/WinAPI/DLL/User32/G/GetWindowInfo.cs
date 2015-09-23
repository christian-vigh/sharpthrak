/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowInfo.cs

    DESCRIPTION
        GetWindowInfo() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
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
		/// <summary>
		/// Retrieves information about the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose information is to be retrieved. </param>
		/// <param name="pwi">
		/// A pointer to a WINDOWINFO structure to receive the information. 
		/// <para>
		/// Note that you must set the cbSize member to sizeof(WINDOWINFO) before calling this function.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. 
		/// </para>
		/// <para>
		/// To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, EntryPoint = "GetWindowInfo", SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool GetWindowInfo ( IntPtr  hWnd, ref WINDOWINFO  pwi ) ;
	    }
    }