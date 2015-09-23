/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetMessage.cs

    DESCRIPTION
        GetMessage() Windows function.

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
		/// Retrieves a message from the calling thread's message queue. The function dispatches incoming sent messages until a posted message is available for retrieval. 
		/// Unlike GetMessage, the PeekMessage function does not wait for a message to be posted before returning.
 		/// </summary>
		/// <param name="lpMsg">A pointer to an MSG structure that receives message information from the thread's message queue.</param>
		/// <param name="hWnd">
		/// A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		/// <para>
		/// If hWnd is NULL, GetMessage retrieves messages for any window that belongs to the current thread, and any messages on the current thread's message queue 
		/// whose hwnd value is NULL (see the MSG structure). Therefore if hWnd is NULL, both window messages and thread messages are processed.
		/// </para>
		/// <para>
		/// If hWnd is -1, GetMessage retrieves only messages on the current thread's message queue whose hwnd value is NULL, that is, thread messages as posted by 
		/// PostMessage (when the hWnd parameter is NULL) or PostThreadMessage.
		/// </para>
		/// </param>
		/// <param name="wMsgFilterMin">
		/// The integer value of the lowest message value to be retrieved. Use WM_KEYFIRST (0x0100) to specify the first keyboard message or WM_MOUSEFIRST (0x0200) 
		/// to specify the first mouse message. 
		/// <para>
		/// Use WM_INPUT here and in wMsgFilterMax to specify only the WM_INPUT messages.
		/// </para>
		/// <para>
		/// If wMsgFilterMin and wMsgFilterMax are both zero, GetMessage returns all available messages (that is, no range filtering is performed). 
		/// </para>
		/// </param>
		/// <param name="wMsgFilterMax">
		/// The integer value of the highest message value to be retrieved. Use WM_KEYLAST to specify the last keyboard message or WM_MOUSELAST to specify 
		/// the last mouse message. 
		/// <para>
		/// Use WM_INPUT here and in wMsgFilterMin to specify only the WM_INPUT messages.
		/// </para>
		/// <para>
		/// If wMsgFilterMin and wMsgFilterMax are both zero, GetMessage returns all available messages (that is, no range filtering is performed). 
		/// </para>
		///</param>
		/// <returns>
		/// If the function retrieves a message other than WM_QUIT, the return value is nonzero.
		/// <para>
		/// If the function retrieves the WM_QUIT message, the return value is zero. 
		/// </para>
		/// <para>
		/// If there is an error, the return value is -1. For example, the function fails if hWnd is an invalid window handle or lpMsg is an invalid pointer. 
		/// </para>
		/// <para>
		/// To get extended error information, call GetLastError.
		/// </para>
		/// <br/>
		/// <para>
		/// Because the return value can be nonzero, zero, or -1, avoid code like this :
		/// </para>
		/// <code>
		///	while (GetMessage( lpMsg, hWnd, 0, 0)) ...
		/// </code>
		/// <br/>
		/// The possibility of a -1 return value means that such code can lead to fatal application errors. Instead, use code like this :
		/// <br/>
		/// <code>
		///	BOOL bRet ;
		///	
		///	while( (bRet = GetMessage( &msg, hWnd, 0, 0 )) != 0)
		///	   { 
		///		if (bRet == -1)
		///		   {
		///			// handle the error and possibly exit
		///		    }
		///		else
		///		  {
		///			TranslateMessage(&msg); 
		///			DispatchMessage(&msg); 
		///		   }
		///	    }
		/// </code>
		/// </returns>
		/// <remarks>
		/// An application typically uses the return value to determine whether to end the main message loop and exit the program. 
		/// <para>
		/// The GetMessage function retrieves messages associated with the window identified by the hWnd parameter or any of its children, as specified by the 
		/// IsChild function, and within the range of message values given by the wMsgFilterMin and wMsgFilterMax parameters. 
		/// </para>
		/// <para>
		/// Note that an application can only use the low word in the wMsgFilterMin and wMsgFilterMax parameters; the high word is reserved for the system.
		/// </para>
		/// <para>
		/// Note that GetMessage always retrieves WM_QUIT messages, no matter which values you specify for wMsgFilterMin and wMsgFilterMax.
		/// </para>
		/// <para>
		/// During this call, the system delivers pending, nonqueued messages, that is, messages sent to windows owned by the calling thread using the 
		/// SendMessage, SendMessageCallback, SendMessageTimeout, or SendNotifyMessage function. Then the first queued message that matches the specified filter is retrieved. 
		/// </para>
		/// <para>
		/// The system may also process internal events. If no filter is specified, messages are processed in the following order : 
		/// </para>
		/// <para>• Sent messages </para>
		/// <para>• Posted messages</para>
		/// <para>• Input (hardware) messages and system internal events </para>
		/// <para>• Sent messages (again) </para>
		/// <para>• WM_PAINT messages </para>
		/// <para>• WM_TIMER messages </para>
		/// <br/>
		/// <para>
		/// To retrieve input messages before posted messages, use the wMsgFilterMin and wMsgFilterMax parameters. 
		/// </para>
		/// <para>
		/// GetMessage does not remove WM_PAINT messages from the queue. The messages remain in the queue until processed. 
		/// </para>
		/// If a top-level window stops responding to messages for more than several seconds, the system considers the window to be not responding and replaces it 
		/// with a ghost window that has the same z-order, location, size, and visual attributes. This allows the user to move it, resize it, or even close the application. 
		/// However, these are the only actions available because the application is actually not responding. When in the debugger mode, the system does not generate 
		/// a ghost window.
		/// <para>
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetMessage ( out MSG  lpMsg, IntPtr  hWnd, 
									WM_Constants  wMsgFilterMin, 
									WM_Constants  wMsgFilterMax ) ;
		# endregion


		# region Version with no message filter.
		/// <summary>
		/// Retrieves a message from the calling thread's message queue. The function dispatches incoming sent messages until a posted message is available for retrieval. 
		/// Unlike GetMessage, the PeekMessage function does not wait for a message to be posted before returning.
 		/// </summary>
		/// <param name="lpMsg">A pointer to an MSG structure that receives message information from the thread's message queue.</param>
		/// <param name="hWnd">
		/// A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		/// <para>
		/// If hWnd is NULL, GetMessage retrieves messages for any window that belongs to the current thread, and any messages on the current thread's message queue 
		/// whose hwnd value is NULL (see the MSG structure). Therefore if hWnd is NULL, both window messages and thread messages are processed.
		/// </para>
		/// <para>
		/// If hWnd is -1, GetMessage retrieves only messages on the current thread's message queue whose hwnd value is NULL, that is, thread messages as posted by 
		/// PostMessage (when the hWnd parameter is NULL) or PostThreadMessage.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function retrieves a message other than WM_QUIT, the return value is nonzero.
		/// <para>
		/// If the function retrieves the WM_QUIT message, the return value is zero. 
		/// </para>
		/// <para>
		/// If there is an error, the return value is -1. For example, the function fails if hWnd is an invalid window handle or lpMsg is an invalid pointer. 
		/// </para>
		/// <para>
		/// To get extended error information, call GetLastError.
		/// </para>
		/// <br/>
		/// <para>
		/// Because the return value can be nonzero, zero, or -1, avoid code like this :
		/// </para>
		/// <code>
		///	while (GetMessage( lpMsg, hWnd, 0, 0)) ...
		/// </code>
		/// <br/>
		/// The possibility of a -1 return value means that such code can lead to fatal application errors. Instead, use code like this :
		/// <br/>
		/// <code>
		///	BOOL bRet ;
		///	
		///	while( (bRet = GetMessage( &msg, hWnd, 0, 0 )) != 0)
		///	   { 
		///		if (bRet == -1)
		///		   {
		///			// handle the error and possibly exit
		///		    }
		///		else
		///		  {
		///			TranslateMessage(&msg); 
		///			DispatchMessage(&msg); 
		///		   }
		///	    }
		/// </code>
		/// </returns>
		/// <remarks>
		/// An application typically uses the return value to determine whether to end the main message loop and exit the program. 
		/// <para>
		/// The GetMessage function retrieves messages associated with the window identified by the hWnd parameter or any of its children, as specified by the 
		/// IsChild function, and within the range of message values given by the wMsgFilterMin and wMsgFilterMax parameters. 
		/// </para>
		/// <para>
		/// Note that an application can only use the low word in the wMsgFilterMin and wMsgFilterMax parameters; the high word is reserved for the system.
		/// </para>
		/// <para>
		/// Note that GetMessage always retrieves WM_QUIT messages, no matter which values you specify for wMsgFilterMin and wMsgFilterMax.
		/// </para>
		/// <para>
		/// During this call, the system delivers pending, nonqueued messages, that is, messages sent to windows owned by the calling thread using the 
		/// SendMessage, SendMessageCallback, SendMessageTimeout, or SendNotifyMessage function. Then the first queued message that matches the specified filter is retrieved. 
		/// </para>
		/// <para>
		/// The system may also process internal events. If no filter is specified, messages are processed in the following order : 
		/// </para>
		/// <para>• Sent messages </para>
		/// <para>• Posted messages</para>
		/// <para>• Input (hardware) messages and system internal events </para>
		/// <para>• Sent messages (again) </para>
		/// <para>• WM_PAINT messages </para>
		/// <para>• WM_TIMER messages </para>
		/// <br/>
		/// <para>
		/// To retrieve input messages before posted messages, use the wMsgFilterMin and wMsgFilterMax parameters. 
		/// </para>
		/// <para>
		/// GetMessage does not remove WM_PAINT messages from the queue. The messages remain in the queue until processed. 
		/// </para>
		/// If a top-level window stops responding to messages for more than several seconds, the system considers the window to be not responding and replaces it 
		/// with a ghost window that has the same z-order, location, size, and visual attributes. This allows the user to move it, resize it, or even close the application. 
		/// However, these are the only actions available because the application is actually not responding. When in the debugger mode, the system does not generate 
		/// a ghost window.
		/// <para>
		/// </para>
		/// </remarks>
		public static IntPtr 	GetMessage ( out MSG  lpMsg, IntPtr  hWnd )
		   {
			return ( GetMessage ( out  lpMsg, hWnd, WM_Constants. WM_NULL, WM_Constants. WM_NULL ) ) ;
		    }
		# endregion
	    }
    }