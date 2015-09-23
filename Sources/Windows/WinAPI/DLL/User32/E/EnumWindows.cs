/**************************************************************************************************************

    NAME
        WinAPI/User32/E/EnumWindows.cs

    DESCRIPTION
        EnumWindows() Windows function.

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
using   Thrak. WinAPI. Callbacks ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		/// <summary>
		/// Enumerates all top-level windows on the screen by passing the handle to each window, in turn, to an application-defined callback function. 
		/// <para>
		/// EnumWindows continues until the last top-level window is enumerated or the callback function returns false. 
		/// </para>
		/// </summary>
		/// <param name="lpEnumFunc">Delegate to an application-defined callback function.</param>
		/// <param name="lParam">An application-defined value to be passed to the callback function. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// <para>
		/// If EnumWindowsProc returns zero, the return value is also zero. In this case, the callback function should call SetLastError to obtain 
		/// a meaningful error code to be returned to the caller of EnumWindows.
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	EnumWindows ( ENUMWNDPROC  lpEnumFunc, UInt32  lParam ) ;
	    }
    }