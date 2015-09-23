/**************************************************************************************************************

    NAME
        WinAPI/User32/W/WaitForInputIdle.cs

    DESCRIPTION
        WaitForInputIdle() Windows function.

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
		/// Waits until the specified process has finished processing its initial input and is waiting for user input with no input pending, 
		/// or until the time-out interval has elapsed.
		/// </summary>
		/// <param name="hProcess">
		/// A handle to the process. If this process is a console application or does not have a message queue, WaitForInputIdle returns immediately.
		/// </param>
		/// <param name="dwMilliseconds">
		/// The time-out interval, in milliseconds. If dwMilliseconds is INFINITE, the function does not return until the process is idle.
		/// </param>
		/// <returns>
		/// The function returns :
		/// <para>- ERROR_Constants.NO_ERROR if the wait was satisfied successfully.</para>
		/// <para>- ERROR_Constants.WAIT_TIMEOUT if the wait was terminated because the time-out interval elapsed.</para>
		/// <para>- ERROR_Constants.WAIT_FAILED if an error occurred.</para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	WaitForInputIdle ( IntPtr  hProcess, uint  dwMilliseconds ) ;
		# endregion
	    }
    }