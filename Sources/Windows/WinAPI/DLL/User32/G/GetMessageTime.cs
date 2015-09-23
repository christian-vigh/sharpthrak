/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetMessageTime.cs

    DESCRIPTION
        GetMessageTime() Windows function.

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
		/// Retrieves the message time for the last message retrieved by the GetMessage function. The time is a long integer that specifies the elapsed time, 
		/// in milliseconds, from the time the system was started to the time the message was created (that is, placed in the thread's message queue). 
 		/// </summary>
		/// <returns>
		/// The return value specifies the message time.
		/// </returns>
		/// <remarks>
		/// The return value from the GetMessageTime function does not necessarily increase between subsequent messages, because the value wraps to zero 
		/// if the timer count exceeds the maximum value for a long integer. 
		/// <br/>
		/// <para>
		/// To calculate time delays between messages, verify that the time of the second message is greater than the time of the first message; then, 
		/// subtract the time of the first message from the time of the second message. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern ulong 	GetMessageTime ( ) ;
		# endregion
	    }
    }