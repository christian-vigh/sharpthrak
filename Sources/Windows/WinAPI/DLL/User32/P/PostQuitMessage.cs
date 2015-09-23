/**************************************************************************************************************

    NAME
        WinAPI/User32/P/PostQuitMessage.cs

    DESCRIPTION
        PostQuitMessage() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
		/// Indicates to the system that a thread has made a request to terminate (quit). It is typically used in response to a WM_DESTROY message.
		/// </summary>
		/// <param name="nExitCode">The application exit code. This value is used as the wParam parameter of the WM_QUIT message.</param>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern void 	PostQuitMessage ( int  nExitCode ) ;
		# endregion
	    }
    }