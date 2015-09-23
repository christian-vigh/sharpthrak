/**************************************************************************************************************

    NAME
        WinAPI/User32/P/PeekMessage.cs

    DESCRIPTION
        PeekMessage() Windows function.

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
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Dispatches incoming sent messages, checks the thread message queue for a posted message, and retrieves the message (if any exist).
 		/// </summary>
		/// <param name="lpMsg">A pointer to an MSG structure that receives message information.</param>
		/// <param name="hWnd">
		/// A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		/// <para>
		/// If hWnd is NULL, PeekMessage retrieves messages for any window that belongs to the current thread, and any messages on the current thread's message queue 
		/// whose hwnd value is NULL (see the MSG structure). Therefore if hWnd is NULL, both window messages and thread messages are processed.
		/// </para>
		/// <para>
		/// If hWnd is -1, PeekMessage retrieves only messages on the current thread's message queue whose hwnd value is NULL, that is, thread messages as posted by 
		/// PostMessage (when the hWnd parameter is NULL) or PostThreadMessage.
		/// </para>
		/// </param>
		/// <param name="wMsgFilterMin">
		/// The value of the first message in the range of messages to be examined. Use WM_KEYFIRST (0x0100) to specify the first keyboard message or WM_MOUSEFIRST (0x0200) 
		/// to specify the first mouse message.
		/// <para>
		/// If wMsgFilterMin and wMsgFilterMax are both zero, PeekMessage returns all available messages (that is, no range filtering is performed).
		/// </para>
		/// </param>
		/// <param name="wMsgFilterMax">
		/// The value of the last message in the range of messages to be examined. Use WM_KEYLAST to specify the last keyboard message or WM_MOUSELAST to specify the 
		/// last mouse message.
		/// <para>
		/// If wMsgFilterMin and wMsgFilterMax are both zero, PeekMessage returns all available messages (that is, no range filtering is performed).
		/// </para>
		/// </param>
		/// <param name="wRemoveMsg">Specifies how messages are to be handled.</param>
		/// <returns>
		/// If a message is available, the return value is nonzero.
		/// <para>
		/// If no messages are available, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// PeekMessage retrieves messages associated with the window identified by the hWnd parameter or any of its children as specified by the IsChild function, 
		/// and within the range of message values given by the wMsgFilterMin and wMsgFilterMax parameters. Note that an application can only use the low word in the 
		/// wMsgFilterMin and wMsgFilterMax parameters; the high word is reserved for the system.
		/// <para>
		/// Note that PeekMessage always retrieves WM_QUIT messages, no matter which values you specify for wMsgFilterMin and wMsgFilterMax.
		/// </para>
		/// <para>
		/// During this call, the system delivers pending, nonqueued messages, that is, messages sent to windows owned by the calling thread using the SendMessage, 
		/// SendMessageCallback, SendMessageTimeout, or SendNotifyMessage function. Then the first queued message that matches the specified filter is retrieved. 
		/// </para>
		/// <para>
		/// The system may also process internal events. If no filter is specified, messages are processed in the following order :
		/// </para>
		/// <para>• Sent messages</para>
		/// <para>• Posted messages</para>
		/// <para>• Input (hardware) messages and system internal events</para>
		/// <para>• Sent messages (again)</para>
		/// <para>• WM_PAINT messages</para>
		/// <para>• WM_TIMER messages</para>
		/// <br/>
		/// <para>
		/// To retrieve input messages before posted messages, use the wMsgFilterMin and wMsgFilterMax parameters. 
		/// </para>
		/// <para>
		/// The PeekMessage function normally does not remove WM_PAINT messages from the queue. WM_PAINT messages remain in the queue until they are processed. 
		/// However, if a WM_PAINT message has a NULL update region, PeekMessage does remove it from the queue.
		/// </para>
		/// <para>
		/// If a top-level window stops responding to messages for more than several seconds, the system considers the window to be not responding and replaces it 
		/// with a ghost window that has the same z-order, location, size, and visual attributes. This allows the user to move it, resize it, or even close the application. 
		/// However, these are the only actions available because the application is actually not responding. 
		/// </para>
		/// <para>
		/// When an application is being debugged, the system does not generate a ghost window. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool PeekMessage ( out MSG  lpMsg, IntPtr  hWnd, 
						WM_Constants  wMsgFilterMin, WM_Constants  wMsgFilterMax, 
						PM_Constants  wRemoveMsg ) ;
		# endregion
	    }
    }