/**************************************************************************************************************

    NAME
        WinAPI/User32/I/InSendMessage.cs

    DESCRIPTION
        InSendMessage() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
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
		/// Determines whether the current window procedure is processing a message that was sent from another thread (in the same process or a different process) 
		/// by a call to the SendMessage function.
		/// <para>
		/// To obtain additional information about how the message was sent, use the InSendMessageEx function.
		/// </para>
 		/// </summary>
		/// <returns>
		/// If the window procedure is processing a message sent to it from another thread using the SendMessage function, the return value is nonzero.
		/// <para>
		/// If the window procedure is not processing a message sent to it from another thread using the SendMessage function, the return value is zero. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	InSendMessage ( ) ;
		# endregion
	    }
    }