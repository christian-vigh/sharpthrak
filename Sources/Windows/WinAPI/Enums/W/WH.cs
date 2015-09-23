/**************************************************************************************************************

    NAME
        WinAPI/Constants/W/WH.cs

    DESCRIPTION
        Windows hook constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	# region WH_ Windows hook constants
	/// <summary>
	/// Window hook constants.
	/// </summary>
	public enum WH_Constants : int
	   { 
		/// <summary>
		/// The WH_CALLWNDPROC and WH_CALLWNDPROCRET hooks enable you to monitor messages sent to window procedures. 
		/// <para>
		/// The system calls a WH_CALLWNDPROC hook procedure before passing the message to the receiving window procedure, 
		/// and calls the WH_CALLWNDPROCRET hook procedure after the window procedure has processed the message. 
		/// </para>
		/// </summary>
		WH_CALLWNDPROC      		=  4,

		/// <summary>
		/// The WH_CALLWNDPROC and WH_CALLWNDPROCRET hooks enable you to monitor messages sent to window procedures. 
		/// <para>
		/// The system calls a WH_CALLWNDPROC hook procedure before passing the message to the receiving window procedure, 
		/// and calls the WH_CALLWNDPROCRET hook procedure after the window procedure has processed the message. 
		/// </para>
		/// <br/>
		/// <para>
		/// The WH_CALLWNDPROCRET hook passes a pointer to a CWPRETSTRUCT structure to the hook procedure. 
		/// </para>
		/// <para>
		/// The structure contains the return value from the window procedure that processed the message, as well as the message parameters associated with the message. 
		/// Subclassing the window does not work for messages set between processes. 
		/// </para>
		/// </summary>
		WH_CALLWNDPROCRET  		=  12,

		/// <summary>
		/// The system calls a WH_CBT hook procedure before activating, creating, destroying, minimizing, maximizing, moving, or sizing a window; 
		/// before completing a system command; before removing a mouse or keyboard event from the system message queue; before setting the input focus; 
		/// or before synchronizing with the system message queue. 
		/// <para>
		/// The value the hook procedure returns determines whether the system allows or prevents one of these operations. 
		/// </para>
		/// <para>
		/// The WH_CBT hook is intended primarily for computer-based training (CBT) applications. 
		/// </para>
		/// </summary>
		WH_CBT              		=  5,

		/// <summary>
		/// The system calls a WH_DEBUG hook procedure before calling hook procedures associated with any other hook in the system. 
		/// <para>
		/// You can use this hook to determine whether to allow the system to call hook procedures associated with other types of hooks. 
		/// </para>
		/// </summary>
		WH_DEBUG            		=  9,

		/// <summary>
		/// The WH_FOREGROUNDIDLE hook enables you to perform low priority tasks during times when its foreground thread is idle. 
		/// <para>
		/// The system calls a WH_FOREGROUNDIDLE hook procedure when the application's foreground thread is about to become idle. 
		/// </para>
		/// </summary>
		WH_FOREGROUNDIDLE  		=  11,

		/// <summary>
		/// The WH_GETMESSAGE hook enables an application to monitor messages about to be returned by the GetMessage or PeekMessage function. 
		/// <para>
		/// You can use the WH_GETMESSAGE hook to monitor mouse and keyboard input and other messages posted to the message queue. 
		/// </para>
		/// </summary>
		WH_GETMESSAGE       		=  3,

		/// <summary>
		/// Hardware specific message.
		/// </summary>
		WH_HARDWARE         		=  8,

		/// <summary>
		/// The WH_JOURNALPLAYBACK hook enables an application to insert messages into the system message queue. You can use this hook to play back a series of 
		/// mouse and keyboard events recorded earlier by using WH_JOURNALRECORD. 
		/// <para>
		/// Regular mouse and keyboard input is disabled as long as a WH_JOURNALPLAYBACK hook is installed. A WH_JOURNALPLAYBACK hook is a global hook—it 
		/// cannot be used as a thread-specific hook. 
		/// </para>
		/// <para>
		/// The WH_JOURNALPLAYBACK hook returns a time-out value. This value tells the system how many milliseconds to wait before processing the current message 
		/// from the playback hook. This enables the hook to control the timing of the events it plays back. 
		/// </para>
		/// </summary>
		WH_JOURNALPLAYBACK  		=  1,

		/// <summary>
		/// The WH_JOURNALRECORD hook enables you to monitor and record input events. 
		/// <para>
		/// Typically, you use this hook to record a sequence of mouse and keyboard events to play back later by using WH_JOURNALPLAYBACK. 
		/// </para>
		/// <para>
		/// The WH_JOURNALRECORD hook is a global hook—it cannot be used as a thread-specific hook. 
		/// </para>
		/// </summary>
		WH_JOURNALRECORD    		=  0,

		/// <summary>
		/// The WH_KEYBOARD hook enables an application to monitor message traffic for WM_KEYDOWN and WM_KEYUP messages about to be returned by the 
		/// GetMessage or PeekMessage function. You can use the WH_KEYBOARD hook to monitor keyboard input posted to a message queue. 
		/// </summary>
		WH_KEYBOARD         		=  2,

		/// <summary>
		/// The WH_KEYBOARD_LL hook enables you to monitor keyboard input events about to be posted in a thread input queue. 
		/// </summary>
		WH_KEYBOARD_LL     		=  13,

		/// <summary>
		/// The WH_MOUSE hook enables you to monitor mouse messages about to be returned by the GetMessage or PeekMessage function. 
		/// You can use the WH_MOUSE hook to monitor mouse input posted to a message queue. 
		/// </summary>
		WH_MOUSE            		=  7,

		/// <summary>
		/// The WH_MOUSE_LL hook enables you to monitor mouse input events about to be posted in a thread input queue. 
		/// </summary>
		WH_MOUSE_LL        		=  14,

		/// <summary>
		/// The WH_MSGFILTER and WH_SYSMSGFILTER hooks enable you to monitor messages about to be processed by a menu, scroll bar, message box, or dialog box, 
		/// and to detect when a different window is about to be activated as a result of the user's pressing the ALT+TAB or ALT+ESC key combination. 
		/// <para>
		/// The WH_MSGFILTER hook can only monitor messages passed to a menu, scroll bar, message box, or dialog box created by the application that installed 
		/// the hook procedure. The WH_SYSMSGFILTER hook monitors such messages for all applications. 
		/// </para>
		/// <para>
		/// The WH_MSGFILTER and WH_SYSMSGFILTER hooks enable you to perform message filtering during modal loops that is equivalent to the filtering done 
		/// in the main message loop. For example, an application often examines a new message in the main loop between the time it retrieves the message from 
		/// the queue and the time it dispatches the message, performing special processing as appropriate. 
		/// </para>
		/// <para>
		/// However, during a modal loop, the system retrieves and dispatches messages without allowing an application the chance to filter the messages 
		/// in its main message loop. If an application installs a WH_MSGFILTER or WH_SYSMSGFILTER hook procedure, the system calls the procedure during the modal loop. 
		/// </para>
		/// <para>
		/// An application can call the WH_MSGFILTER hook directly by calling the CallMsgFilter function. By using this function, the application can use the same code 
		/// to filter messages during modal loops as it uses in the main message loop. 
		/// </para>
		/// <para>
		/// To do so, encapsulate the filtering operations in a WH_MSGFILTER hook procedure and call CallMsgFilter between the calls to 
		/// the GetMessage and DispatchMessage functions :
		/// </para>
		/// <br/>
		/// <code>
		///		while (GetMessage(&msg, (HWND) NULL, 0, 0)) 
		///		   {		
		///			if (!CallMsgFilter(&qmsg, 0)) 
		///				DispatchMessage(&qmsg); 
		///		    } 
		/// </code>
		/// <br/>
		/// <para>
		/// The last argument of CallMsgFilter is simply passed to the hook procedure; you can enter any value. 
		/// </para>
		/// <para>
		/// The hook procedure, by defining a constant such as MSGF_MAINLOOP, can use this value to determine where the procedure was called from. 
		/// </para>
		/// </summary>
		WH_MSGFILTER        		=  (-1),

		/// <summary>
		/// A shell application can use the WH_SHELL hook to receive important notifications. The system calls a WH_SHELL hook procedure when the shell application 
		/// is about to be activated and when a top-level window is created or destroyed. 
		/// <para>
		/// Note that custom shell applications do not receive WH_SHELL messages. Therefore, any application that registers itself as the default shell must call 
		/// the SystemParametersInfo function before it (or any other application) can receive WH_SHELL messages. 
		/// </para>
		/// <para>
		/// This function must be called with SPI_SETMINIMIZEDMETRICS and a MINIMIZEDMETRICS structure. Set the iArrange member of this structure to ARW_HIDE.
		/// </para>
		/// </summary>
		WH_SHELL           		=  10,

		/// <summary>
		/// The WH_MSGFILTER and WH_SYSMSGFILTER hooks enable you to monitor messages about to be processed by a menu, scroll bar, message box, or dialog box, 
		/// and to detect when a different window is about to be activated as a result of the user's pressing the ALT+TAB or ALT+ESC key combination. 
		/// <para>
		/// The WH_MSGFILTER hook can only monitor messages passed to a menu, scroll bar, message box, or dialog box created by the application that installed 
		/// the hook procedure. The WH_SYSMSGFILTER hook monitors such messages for all applications. 
		/// </para>
		/// <para>
		/// The WH_MSGFILTER and WH_SYSMSGFILTER hooks enable you to perform message filtering during modal loops that is equivalent to the filtering done 
		/// in the main message loop. For example, an application often examines a new message in the main loop between the time it retrieves the message from 
		/// the queue and the time it dispatches the message, performing special processing as appropriate. 
		/// </para>
		/// <para>
		/// However, during a modal loop, the system retrieves and dispatches messages without allowing an application the chance to filter the messages 
		/// in its main message loop. If an application installs a WH_MSGFILTER or WH_SYSMSGFILTER hook procedure, the system calls the procedure during the modal loop. 
		/// </para>
		/// <para>
		/// An application can call the WH_MSGFILTER hook directly by calling the CallMsgFilter function. By using this function, the application can use the same code 
		/// to filter messages during modal loops as it uses in the main message loop. 
		/// </para>
		/// <para>
		/// To do so, encapsulate the filtering operations in a WH_MSGFILTER hook procedure and call CallMsgFilter between the calls to 
		/// the GetMessage and DispatchMessage functions :
		/// </para>
		/// <br/>
		/// <code>
		///		while (GetMessage(&msg, (HWND) NULL, 0, 0)) 
		///		   {		
		///			if (!CallMsgFilter(&qmsg, 0)) 
		///				DispatchMessage(&qmsg); 
		///		    } 
		/// </code>
		/// <br/>
		/// <para>
		/// The last argument of CallMsgFilter is simply passed to the hook procedure; you can enter any value. 
		/// </para>
		/// <para>
		/// The hook procedure, by defining a constant such as MSGF_MAINLOOP, can use this value to determine where the procedure was called from. 
		/// </para>
		/// </summary>
		WH_SYSMSGFILTER     		=  6
	    }
	# endregion
    }