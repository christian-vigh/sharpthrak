/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DefWindowProc.cs

    DESCRIPTION
        DefWindowProc() Windows function.

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
		/// Calls the default window procedure to provide default processing for any window messages that an application does not process. 
		/// This function ensures that every message is processed. DefWindowProc is called with the same parameters received by the window procedure. 
		/// </summary>
		/// <param name="hWnd">A handle to the window procedure that received the message. </param>
		/// <param name="Msg">The message. </param>
		/// <param name="wParam">Additional message information. The content of this parameter depends on the value of the Msg parameter. </param>
		/// <param name="lParam">Additional message information. The content of this parameter depends on the value of the Msg parameter. </param>
		/// <returns>The return value is the result of the message processing and depends on the message.</returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	DefWindowProc ( IntPtr  hWnd, uint  Msg, IntPtr  wParam, IntPtr  lParam ) ;
		# endregion
	    }
    }