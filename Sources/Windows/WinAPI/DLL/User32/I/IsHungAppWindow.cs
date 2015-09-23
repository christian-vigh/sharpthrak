/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsHungAppWindow.cs

    DESCRIPTION
        IsHungAppWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Determines whether the system considers that a specified application is not responding. An application is considered to be not responding 
		/// if it is not waiting for input, is not in startup processing, and has not called PeekMessage within the internal timeout period of 5 seconds. 
 		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested. </param>
		/// <returns>The return value is TRUE if the window stops responding; otherwise, it is FALSE. Ghost windows always return TRUE.</returns>
		/// <remarks>
		/// The Windows timeout criteria of 5 seconds is subject to change.
		/// <para>
		/// This function was not included in the SDK headers and libraries until Windows XP Service Pack 1 (SP1) and Windows Server 2003. 
		/// </para>
		/// <para>
		/// If you do not have a header file and import library for this function, you can call the function using LoadLibrary and GetProcAddress.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsHungAppWindow ( IntPtr  hWnd ) ;
		# endregion
	    }
    }