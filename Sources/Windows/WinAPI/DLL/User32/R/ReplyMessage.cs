/**************************************************************************************************************

    NAME
        WinAPI/User32/R/ReplyMessage.cs

    DESCRIPTION
        ReplyMessage() Windows function.

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
		/// Replies to a message sent through the SendMessage function without returning control to the function that called SendMessage.
		/// </summary>
		/// <param name="lParam">The result of the message processing. The possible values are based on the message sent.</param>
		/// <returns>
		/// If the calling thread was processing a message sent from another thread or process, the return value is nonzero.
		/// <para>
		/// If the calling thread was not processing a message sent from another thread or process, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// By calling this function, the window procedure that receives the message allows the thread that called SendMessage to continue to run 
		/// as though the thread receiving the message had returned control. The thread that calls the ReplyMessage function also continues to run. 
		/// <para>
		/// If the message was not sent through SendMessage or if the message was sent by the same thread, ReplyMessage has no effect. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ReplyMessage ( IntPtr  lParam ) ;
		# endregion


		# region Version with uint as lParam
		/// <summary>
		/// Replies to a message sent through the SendMessage function without returning control to the function that called SendMessage.
		/// </summary>
		/// <param name="lParam">The result of the message processing. The possible values are based on the message sent.</param>
		/// <returns>
		/// If the calling thread was processing a message sent from another thread or process, the return value is nonzero.
		/// <para>
		/// If the calling thread was not processing a message sent from another thread or process, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// By calling this function, the window procedure that receives the message allows the thread that called SendMessage to continue to run 
		/// as though the thread receiving the message had returned control. The thread that calls the ReplyMessage function also continues to run. 
		/// <para>
		/// If the message was not sent through SendMessage or if the message was sent by the same thread, ReplyMessage has no effect. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ReplyMessage ( uint  lParam ) ;
		# endregion
	    }
    }