/**************************************************************************************************************

    NAME
        WinAPI/Constants/H/HCBT.cs

    DESCRIPTION
        CBT hook codes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region HCBT_ hook codes
	/// <summary>
	/// The code that the hook procedure uses to determine how to process the message. If nCode is less than zero, the hook procedure must pass the message to 
	/// the CallNextHookEx function without further processing and should return the value returned by CallNextHookEx.
	/// </summary>
	public enum  HCBT_Constants	:  uint
	   {
		/// <summary>
		/// The system is about to activate a window.
		/// </summary>
		HCBT_ACTIVATE			=  5,

		/// <summary>
		/// The system has removed a mouse message from the system message queue. 
		/// <para>
		/// Upon receiving this hook code, a CBT application must install a WH_JOURNALPLAYBACK hook procedure in response to the mouse message.
		/// </para>
		/// </summary>
		HCBT_CLICKSKIPPED		=  6,

		/// <summary>
		/// A window is about to be created. The system calls the hook procedure before sending the WM_CREATE or WM_NCCREATE message to the window. 
		/// If the hook procedure returns a nonzero value, the system destroys the window; the CreateWindow function returns NULL, but the WM_DESTROY message 
		/// is not sent to the window. If the hook procedure returns zero, the window is created normally. 
		/// <para>
		/// At the time of the HCBT_CREATEWND notification, the window has been created, but its final size and position may not have been determined and 
		/// its parent window may not have been established. It is possible to send messages to the newly created window, although it has not yet received 
		/// WM_NCCREATE or WM_CREATE messages. 
		/// </para>
		/// <para>
		/// It is also possible to change the position in the z-order of the newly created window by modifying the hwndInsertAfter member of the CBT_CREATEWND structure.
		/// </para>
		/// </summary>
		HCBT_CREATEWND			=  3,

		/// <summary>
		/// A window is about to be destroyed.
		/// </summary>
		HCBT_DESTROYWND			=  4,

		/// <summary>
		/// The system has removed a keyboard message from the system message queue. 
		/// <para>
		/// Upon receiving this hook code, a CBT application must install a WH_JOURNALPLAYBACK hook procedure in response to the keyboard message.
		/// </para>
		/// </summary>
		HCBT_KEYSKIPPED			=  7,

		/// <summary>
		/// A window is about to be minimized or maximized.
		/// </summary>
		HCBT_MINMAX			=  1,

		/// <summary>
		/// A window is about to be moved or sized.
		/// </summary>
		HCBT_MOVESIZE			=  0,

		/// <summary>
		/// The system has retrieved a WM_QUEUESYNC message from the system message queue.
		/// </summary>
		HCBT_QS				=  2,

		/// <summary>
		/// A window is about to receive the keyboard focus.
		/// </summary>
		HCBT_SETFOCUS			=  9,

		/// <summary>
		/// A system command is about to be carried out. This allows a CBT application to prevent task switching by means of hot keys.
		/// </summary>
		HCBT_SYSCOMMAND			=  8
	    }
	# endregion
   }