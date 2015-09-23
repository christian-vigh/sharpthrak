/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SendMessage.cs

    DESCRIPTION
        SendMessage() Windows function.

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
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic signature
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, uint  wParam, uint  lParam ) ;
		# endregion


		# region Generic signature with IntPtr for WPARAM and LPARAM
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, IntPtr  lParam ) ;
		# endregion


		# region Signature with LPARAM as COMPAREITEMSTRUCT
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a COMPAREITEM structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, COMPAREITEMSTRUCT  lParam ) ;
		# endregion


		# region Signature with LPARAM as COPYDATA
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a COPYDATA structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, COPYDATASTRUCT  lParam ) ;
		# endregion


		# region Signature with LPARAM as CREATESTRUCT
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a CREATESTRUCT structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, CREATESTRUCT  lParam ) ;
		# endregion


		# region Signature with LPARAM as DELETEITEMSTRUCT
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a DELETEITEMSTRUCT structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, DELETEITEMSTRUCT  lParam ) ;
		# endregion


		# region Signature with LPARAM as GESTURENOTIFYSTRUCT
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a GESTURENOTIFYSTRUCT structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, GESTURENOTIFYSTRUCT  lParam ) ;
		# endregion


		# region Signature with LPARAM as HELPINFO
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a HELPINFO structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, HELPINFO  lParam ) ;
		# endregion


		# region Signature with LPARAM as MINMAXINFO
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a MINMAXINFO structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, MINMAXINFO  lParam ) ;
		# endregion


		# region Signature with LPARAM as out MINMAXINFO
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a MINMAXINFO structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, out MINMAXINFO  lParam ) ;
		# endregion


		# region Signature with LPARAM as out RECT
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a RECT structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, int  wParam, out RECT  lParam ) ;
		# endregion


		# region Signature with LPARAM as TITLEBARINFOEX
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a TITLEBARINFOEX structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, int  wParam, TITLEBARINFOEX  lParam ) ;
		# endregion


		# region Signature with LPARAM as out TITLEBARINFOEX
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a TITLEBARINFOEX structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, int  wParam, ref TITLEBARINFOEX  lParam ) ;
		# endregion


		# region Signature with LPARAM as out WINDOWPOS
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a WINDOWPOS structure.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, int  wParam, out WINDOWPOS  lParam ) ;
		# endregion

		# region Signature with LPARAM as String
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a string value.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, String  lParam ) ;
		# endregion


		# region Signature with LPARAM as out StringBuilder
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as an output StringBuilder object.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, int  wParam, StringBuilder  lParam ) ;
		# endregion


		# region Signature with LPARAM as out String
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as an output string value.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		public static IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, int  wParam, out String  lParam )
		   {
			if  ( wParam  <  1 )
				wParam	=  Defines. DEFAULT_OUT_STRING_LENGTH ;

			StringBuilder	value		=  new  StringBuilder ( wParam ) ;
			IntPtr		result		=  SendMessage ( hWnd, Msg, wParam, value ) ;
			
			lParam	=  value. ToString ( ) ;

			return ( result ) ;
		    }
		# endregion


		# region Signature with LPARAM as int[]
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as an array of integers.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, int []  lParam ) ;
		# endregion


		# region Signature with LPARAM as ref int[]
		/// <summary>
		/// Sends the specified message to a window or windows. 
		/// <para>
		/// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// </para>
		/// <para>
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		/// </para>
		/// <para>
		/// To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. 
		/// <para>
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, 
		/// overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </para>
		/// <para>
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </para>
		/// </param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information as a reference to an array of integers.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = false )]
		public static extern IntPtr	SendMessage ( IntPtr  hWnd, UInt32  Msg, IntPtr  wParam, ref int []  lParam ) ;
		# endregion

	    }
    }
