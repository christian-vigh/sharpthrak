/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

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

	# region WM_ constants : Standard Windows messages
	/// <summary>
	/// Window message constants.
	/// </summary>
	[MessageConstant ( )]
	public enum WM_Constants : uint
	   {
		# region WM_ACTIVATE message
		/// <summary>
		/// Sent to both the window being activated and the window being deactivated. 
		/// <para>
		/// If the windows use the same input queue, the message is sent synchronously, first to the window procedure of the top-level window 
		/// being deactivated, then to the window procedure of the top-level window being activated. 
		/// </para>
		/// <para>
		/// If the windows use different input queues, the message is sent asynchronously, so the window is activated immediately. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM class="WM_ACTIVATE_WPARAM">
		/// The low-order word is a WA_Constants value that specifies whether the window is being activated or deactivated. 
		/// <para>
		/// The high-order word specifies the minimized state of the window being activated or deactivated. 
		/// A nonzero value indicates the window is minimized. 
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM class="uint">
		/// A handle to the window being activated or deactivated, depending on the value of the wParam parameter. 
		/// <para>
		/// If the low-order word of wParam is WA_INACTIVE, lParam is the handle to the window being activated. 
		/// </para>
		/// <para>
		/// If the low-order word of wParam is WA_ACTIVE or WA_CLICKACTIVE, lParam is the handle to the window being deactivated. 
		/// </para>
		/// <para>
		/// This handle can be NULL. 
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT class="uint">
		/// If an application processes this message, it should return zero. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the window is being activated and is not minimized, the DefWindowProc function sets the keyboard focus to the window. 
		/// <para>
		/// If the window is activated by a mouse click, it also receives a WM_MOUSEACTIVATE message. 
		/// </para>
		/// </remarks>
		WM_ACTIVATE				=  0x00000006,
		# endregion

		# region WM_ACTIVATEAPP message
		/// <summary>
		/// Sent when a window belonging to a different application than the active window is about to be activated. 
		/// <para>
		/// The message is sent to the application whose window is being activated and to the application whose window is being deactivated.
		/// </para>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM class="uint">
		/// Indicates whether the window is being activated or deactivated. 
		/// <para>
		/// This parameter is TRUE if the window is being activated; it is FALSE if the window is being deactivated.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM class="uint">
		/// The thread identifier. If the wParam parameter is TRUE, lParam is the identifier of the thread that owns the window being deactivated. 
		/// <para>
		/// If wParam is FALSE, lParam is the identifier of the thread that owns the window being activated.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT class="uint">
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		WM_ACTIVATEAPP          		=  0x0000001C,
		# endregion

		# region WM_APPCOMMAND message
		/// <summary>
		/// Notifies a window that the user generated an application command event, for example, 
		/// by clicking an application command button using the mouse or typing an application command key on the keyboard.
		/// </summary>
		/// 
		/// <WPARAM class="uint">
		/// A handle to the window where the user clicked the button or pressed the key. 
		/// This can be a child window of the window receiving the message.
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_APPCOMMAND_LPARAM">
		///Use the following code to get the information contained in the lParam parameter :
		/// <br/>
		/// <code>
		///	cmd	= GET_APPCOMMAND_LPARAM(lParam);
		///	uDevice = GET_DEVICE_LPARAM(lParam);
		///	dwKeys	= GET_KEYSTATE_LPARAM(lParam);
		/// </code>
		/// <br/>
		/// Or simply use the WM_APPCOMMAND_LPARAM class to map the LPARAM parameter to human-readable values.
		/// </LPARAM>
		/// 
		/// <LRESULT class="uint">
		/// If an application processes this message, it should return TRUE.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// DefWindowProc generates the WM_APPCOMMAND message when it processes the WM_XBUTTONUP or WM_NCXBUTTONUP message, 
		/// or when the user types an application command key.
		/// <para>
		/// If a child window does not process this message and instead calls DefWindowProc, DefWindowProc will send the message to its parent window. 
		/// </para>
		/// <para>
		/// If a top level window does not process this message and instead calls DefWindowProc, DefWindowProc will call a shell hook with the hook 
		/// code equal to HSHELL_APPCOMMAND.
		/// </para>
		/// <para>
		/// To get the coordinates of the cursor if the message was generated by a mouse click, the application can call GetMessagePos. 
		/// </para>
		/// <para>
		/// An application can test whether the message was generated by the mouse by checking whether lParam contains FAPPCOMMAND_MOUSE.
		/// Unlike other windows messages, an application should return TRUE from this message if it processes it. Doing so will allow software 
		/// that simulates this message on Windows systems earlier than Windows 2000 to determine whether the window procedure processed the message 
		/// or call DefWindowProc to process it.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_APPCOMMAND                   	=  0x00000319,
		# endregion

		# region WM_ASKCBFORMATNAME message
		/// <summary>
		/// Sent to the clipboard owner by a clipboard viewer window to request the name of a CF_OWNERDISPLAY clipboard format.
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM class="uint">
		/// The size, in characters, of the buffer pointed to by the lParam parameter. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="Pointer<char>">
		/// A pointer to the buffer that is to receive the clipboard format name. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// In response to this message, the clipboard owner should copy the name of the owner-display format to the specified buffer, 
		/// not exceeding the buffer size specified by the wParam parameter. 
		/// <para>
		/// A clipboard viewer window sends this message to the clipboard owner to determine the name of the CF_OWNERDISPLAY format — 
		/// for example, to initialize a menu listing available formats. 
		/// </para>
		///</remarks>
		WM_ASKCBFORMATNAME              	=  0x0000030C,
		# endregion

		# region WM_CANCELJOURNAL message
		/// <summary>
		/// Posted to an application when a user cancels the application's journaling activities. The message is posted with a NULL window handle. 
		/// </summary>
		/// 
		/// <WPARAM  unused="true">
		/// This parameter is not used.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">
		/// This parameter is not used.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// This message does not return a value. It is meant to be processed from within an application's main loop or a GetMessage hook procedure, 
		/// not from a window procedure.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Journal record and playback modes are modes imposed on the system that let an application sequentially record or play back user input. 
		/// The system enters these modes when an application installs a JournalRecordProc or JournalPlaybackProc hook procedure. 
		/// <para>
		/// When the system is in either of these journaling modes, applications must take turns reading input from the input queue. 
		/// </para>
		/// <para>
		/// If any one application stops reading input while the system is in a journaling mode, other applications are forced to wait. 
		/// </para>
		/// <para>
		/// To ensure a robust system, one that cannot be made unresponsive by any one application, the system automatically cancels any journaling 
		/// activities when a user presses CTRL+ESC or CTRL+ALT+DEL. The system then unhooks any journaling hook procedures, and posts a WM_CANCELJOURNAL message, 
		/// with a NULL window handle, to the application that set the journaling hook. 
		/// </para>
		/// <para>
		/// The WM_CANCELJOURNAL message has a NULL window handle, therefore it cannot be dispatched to a window procedure. 
		/// </para>
		/// <br/>
		/// <para>
		/// There are two ways for an application to see a WM_CANCELJOURNAL message : 
		/// - If the application is running in its own main loop, it must catch the message between its call to GetMessage or PeekMessage and its call to DispatchMessage. 
		/// - If the application is not running in its own main loop, it must set a GetMsgProc hook procedure (through a call to SetWindowsHookEx specifying 
		/// the WH_GETMESSAGE hook type) that watches for the message. 
		/// </para>
		/// <br/>
		/// <para>
		/// When an application sees a WM_CANCELJOURNAL message, it can assume two things : the user has intentionally canceled the journal record or playback mode, 
		/// and the system has already unhooked any journal record or playback hook procedures. 
		/// </para>
		/// <br/>
		/// <para>
		/// Note that the key combinations mentioned above (CTRL+ESC or CTRL+ALT+DEL) cause the system to cancel journaling. 
		/// </para>
		/// <para>
		/// If any one application is made unresponsive, they give the user a means of recovery. The VK_CANCEL virtual key code 
		/// (usually implemented as the CTRL+BREAK key combination) is what an application that is in journal record mode should watch for as a signal 
		/// that the user wishes to cancel the journaling activity. 
		/// </para>
		/// <para>
		/// The difference is that watching for VK_CANCEL is a suggested behavior for journaling applications, whereas CTRL+ESC or CTRL+ALT+DEL cause the system 
		/// to cancel journaling regardless of a journaling application's behavior. 
		/// </para>
		/// </remarks>
		WM_CANCELJOURNAL			=  0x0000004B,
		# endregion

		# region WM_CANCELMODE message
		/// <summary>
		/// Sent to cancel certain modes, such as mouse capture. 
		/// <para>
		/// For example, the system sends this message to the active window when a dialog box or message box is displayed. 
		/// </para>
		/// <para>
		/// Certain functions also send this message explicitly to the specified window regardless of whether it is the active window. 
		/// For example, the EnableWindow function sends this message when disabling the specified window.
		/// </para>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">
		/// This parameter is not used.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">
		/// This parameter is not used.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the WM_CANCELMODE message is sent, the DefWindowProc function cancels internal processing of standard scroll bar input, 
		/// cancels internal menu processing, and releases the mouse capture.
		/// </remarks>
		WM_CANCELMODE           		=  0x00000020,
		# endregion

		# region WM_CAPTURECHANGED message
		/// <summary>
		/// Sent to the window that is losing the mouse capture.
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">
		/// This parameter is not used. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="uint">
		/// A handle to the window gaining the mouse capture. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return zero if it processes this message. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// A window receives this message even if it calls ReleaseCapture itself. 
		/// <para>
		/// An application should not attempt to set the mouse capture in response to this message.
		/// </para>
		/// <para>
		/// When it receives this message, a window should redraw itself, if necessary, to reflect the new mouse-capture state. 
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_CAPTURECHANGED               	=  0x00000215,
		# endregion

		# region WM_CHANGECBCHAIN message
		/// <summary>
		/// Sent to the first window in the clipboard viewer chain when a window is being removed from the chain. 
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the window being removed from the clipboard viewer chain. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// handle to the next window in the chain following the window being removed. 
		/// <para>
		/// This parameter is NULL if the window being removed is the last window in the chain. 
		/// </para>
		/// </LPARAM>
		///
		/// <LRESULT>
		/// If an application processes this message, it should return zero. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Each clipboard viewer window saves the handle to the next window in the clipboard viewer chain. 
		/// <para>
		/// Initially, this handle is the return value of the SetClipboardViewer function. 
		/// </para>
		/// <para>
		/// When a clipboard viewer window receives the WM_CHANGECBCHAIN message, it should call the SendMessage function to pass the message 
		/// to the next window in the chain, unless the next window is the window being removed. In this case, the clipboard viewer should save 
		/// the handle specified by the lParam parameter as the next window in the chain. 
		/// </para>
		/// </remarks>
		WM_CHANGECBCHAIN                	=  0x0000030D,
		#  endregion

		# region WM_CHANGEUISTATE message
		/// <summary>
		/// An application sends the WM_CHANGEUISTATE message to indicate that the UI state should be changed.
		/// </summary>
		/// 
		/// <WPARAM class="WM_CHANGEUISTATE_WPARAM">
		/// The low-order word specifies the action to be taken (enum UIS_Constants).
		/// <para>
		/// The high-order word specifies which UI state elements are affected or the style of the control (enum UISF_Constants).
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">
		/// The high-order word specifies which UI state elements are affected or the style of the control.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application that processes this message should return TRUE.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// A window should send this message to itself or its parent when it must change the UI state elements of all windows in the same hierarchy. 
		/// The window procedure must let DefWindowProc process this message so that the entire window tree has a consistent UI state. 
		/// <para>
		/// When the top-level window receives the WM_CHANGEUISTATE message, it sends a WM_UPDATEUISTATE message with the same parameters to all child windows. 
		/// When the system processes the WM_UPDATEUISTATE message, it makes the change in the UI state.
		/// </para>
		/// <para>
		/// If the low-order word of wParam is UIS_INITIALIZE, the system will send the WM_UPDATEUISTATE message with a UI state based on the last input event. 
		/// For example, if the last input came from the mouse, the system will hide the keyboard cues. And, if the last input came from the keyboard, the system 
		/// will show the keyboard cues. If the state that results from processing WM_CHANGEUISTATE is the same as the old state, DefWindowProc does not send this message.
		/// </para>
		/// </remarks>
		WM_CHANGEUISTATE                	=  0x00000127, 
		# endregion

		# region WM_CHAR message
		/// <summary>
		/// Posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. 
		/// The WM_CHAR message contains the character code of the key that was pressed. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The character code of the key. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return zero if it processes this message. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The WM_CHAR message uses Unicode Transformation Format (UTF)-16. 
		/// <para>
		/// Because there is not necessarily a one-to-one correspondence between keys pressed and character messages generated, 
		/// the information in the high-order word of the lParam parameter is generally not useful to applications. 
		/// </para>
		/// <para>
		/// The information in the high-order word applies only to the most recent WM_KEYDOWN message that precedes the posting of the WM_CHAR message. 
		/// </para>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and the right CTRL keys on the main section of the keyboard ; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN and arrow keys in the clusters to the left of the numeric keypad ; and the divide (/) and 
		/// ENTER keys in the numeric keypad. Some other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// <para>
		/// The WM_UNICHAR message is the same as WM_CHAR, except it uses UTF-32. It is designed to send or post Unicode characters to ANSI windows, 
		/// and it can handle Unicode Supplementary Plane characters.
		/// </para>
		/// </remarks>
		WM_CHAR                         	=  0x00000102,
		# endregion

		# region WM_CHARTOITEM message
		/// <summary>
		/// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_CHAR message. 
		/// </summary>
		/// 
		/// <WPARAM clss="WM_CHARTOITEM_WPARAM">
		/// The LOWORD specifies the character code of the key the user pressed. The HIWORD specifies the current position of the caret. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Handle to the list box. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value specifies the action that the application performed in response to the message. 
		/// <para>
		/// A return value of –1 or –2 indicates that the application handled all aspects of selecting the item and requires no further action by the list box. 
		/// </para>
		/// <para>
		/// A return value of 0 or greater specifies the zero-based index of an item in the list box and indicates that the list box should perform the 
		/// default action for the keystroke on the specified item.
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function returns –1. 
		/// <para>
		/// Only owner-drawn list boxes that do not have the LBS_HASSTRINGS style can receive this message. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a BOOL and return the value directly. 
		/// </para>
		/// <para>
		/// The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_CHARTOITEM           		=  0x0000002F,
		# endregion

		# region WM_CHILDACTIVATE message
		/// <summary>
		/// Sent to a child window when the user clicks the window's title bar or when the window is activated, moved, or sized.
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true"/>
		/// <LPARAM unused="true"/>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		WM_CHILDACTIVATE        		=  0x00000022,
		# endregion

		# region WM_CLEAR
		/// <summary>
		/// An application sends a WM_CLEAR message to an edit control or combo box to delete (clear) the current selection, if any, from the edit control. 
		/// </summary>
		/// 
		/// <WPARAM unused="true"/>
		/// <LPARAM unused="true"/>
		/// 
		/// <LRESULT>
		/// This message does not return a value. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The deletion performed by the WM_CLEAR message can be undone by sending the edit control an EM_UNDO message. 
		/// <para>
		/// To delete the current selection and place the deleted content on the clipboard, use the WM_CUT message. 
		/// </para>
		/// <para>
		/// When sent to a combo box, the WM_CLEAR message is handled by its edit control. 
		/// </para>
		/// <para>
		/// This message has no effect when sent to a combo box with the CBS_DROPDOWNLIST style. 
		/// </para>
		/// </remarks>
		WM_CLEAR                        	=  0x00000303,
		# endregion

		# region WM_CLIPBOARDUPDATE
		/// <summary>
		/// Sent when the contents of the clipboard have changed.
		/// </summary>
		/// 
		/// <WPARAM unused="true"/>
		/// <LPARAM unused="true"/>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// To register a window to receive this message, use the AddClipboardFormatListener function.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_CLIPBOARDUPDATE              	=  0x0000031D,
		# endregion

		# region WM_CLOSE
		/// <summary>
		/// Sent as a signal that a window or an application should terminate.
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true"/>
		/// <LPARAM unused="true"/>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// An application can prompt the user for confirmation, prior to destroying a window, by processing the WM_CLOSE message 
		/// and calling the DestroyWindow function only if the user confirms the choice.
		/// <para>
		/// By default, the DefWindowProc function calls the DestroyWindow function to destroy the window.
		/// </para>
		/// </remarks>
		WM_CLOSE                		=  0x00000010,
		# endregion

		# region WM_COMMAND
		/// <summary>
		/// Sent when the user selects a command item from a menu, when a control sends a notification message to its parent window, 
		/// or when an accelerator keystroke is translated. 
		/// </summary>
		/// 
		/// <WPARAM class="WM_COMMAND_WPARAM">See remarks.</WPARAM>
		/// <LPARAM>See remarks.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// Use of the wParam and lParam parameters are summarized here. 
		/// <br/>
		/// <code>
		/// <para>Message Source	wParam (high word)			wParam (low word)		lParam</para>
		/// <para>--------------	        -----------------                       -----------------               ------</para>
		/// <para>Menu                  0                                       Menu identifier (IDM_*)         0</para>
		/// <para>Accelerator           1                                       Accelerator identifier (IDM_*)  0</para>
		/// <para>Control               Control-defined notification code       Control identifier              Handle to the control window</para>
		/// </code>
		/// <br/>
		/// <para>Menus :</para>
		/// <para>
		/// If an application enables a menu separator, the system sends a WM_COMMAND message with the low-word of the wParam parameter set to zero 
		/// when the user selects the separator.
		/// </para>
		/// <para>
		/// If a menu is defined with a MENUINFO.dwStyle value of MNS_NOTIFYBYPOS, WM_MENUCOMMAND is sent instead of WM_COMMAND.
		/// </para>
		/// <br/>
		/// <para>Accelerators :</para>
		/// <para>
		/// Accelerator keystrokes that select items from the window menu are translated into WM_SYSCOMMAND messages.
		/// </para>
		/// <para>
		/// If an accelerator keystroke occurs that corresponds to a menu item when the window that owns the menu is minimized, no WM_COMMAND message is sent. 
		/// However, if an accelerator keystroke occurs that does not match any of the items in the window's menu or in the window menu, a WM_COMMAND message is sent, 
		/// even if the window is minimized.
		/// </para>
		/// </remarks>
		WM_COMMAND                      	=  0x00000111,
		# endregion

		# region WM_COMPACTING
		/// <summary>
		/// Sent to all top-level windows when the system detects more than 12.5 percent of system time over a 30- to 60-second interval is being spent 
		/// compacting memory. This indicates that system memory is low.
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The ratio of central processing unit (CPU) time currently spent by the system compacting memory to CPU time currently spent 
		/// by the system performing other operations. 
		/// <para>
		/// For example, 0x8000 represents 50 percent of CPU time spent compacting memory.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// This message is provided only for compatibility with 16-bit Windows-based applications.
		/// </remarks>
		WM_COMPACTING				=  0x00000041,
		# endregion

		# region WM_COMPAREITEM
		/// <summary>
		/// Sent to determine the relative position of a new item in the sorted list of an owner-drawn combo box or list box. 
		/// <para>
		/// Whenever the application adds a new item, the system sends this message to the owner of a combo box or list box created with the CBS_SORT or LBS_SORT style. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the identifier of the control that sent the WM_COMPAREITEM message. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Pointer to a COMPAREITEMSTRUCT structure that contains the identifiers and application-supplied data for two items in the combo or list box. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value indicates the relative position of the two items. It may be any of the values shown in the following table.
		/// <br/>
		/// <code>
		/// <para>Return code           Description</para>
		/// <para>-----------           -----------</para>
		/// <para>-1                    Item 1 precedes item 2 in the sorted order.</para>
		/// <para>0                     Items 1 and 2 are equivalent in the sorted order.</para>
		/// <para>1                     Item 1 follows item 2 in the sorted order.</para>
		/// </code>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the owner of an owner-drawn combo box or list box receives this message, the owner returns a value indicating which 
		/// of the items specified by the COMPAREITEMSTRUCT structure will appear before the other. 
		/// <para>
		/// Typically, the system sends this message several times until it determines the exact position for the new item. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a BOOL and return the value directly. 
		/// </para>
		/// <para>
		/// The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_COMPAREITEM          		=  0x00000039,
		# endregion

		#  region WM_COMMNOTIFY
		/// <summary>
		/// Superseded.
		/// </summary>
		[MessageConstant ( MessageConstantType. Superseded )]
		WM_COMMNOTIFY				=  0x00000044,
		# endregion

		# region WM_CONTEXTMENU
		/// <summary>
		/// Notifies a window that the user clicked the right mouse button (right-clicked) in the window.
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the window in which the user right-clicked the mouse. 
		/// <para>
		/// This can be a child window of the window receiving the message.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_CONTEXTMENU_LPARAM">
		/// The low-order word specifies the horizontal position of the cursor, in screen coordinates, at the time of the mouse click. 
		/// <para>
		/// The high-order word specifies the vertical position of the cursor, in screen coordinates, at the time of the mouse click. 
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT unused="true">
		/// No return value.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// A window can process this message by displaying a shortcut menu using the TrackPopupMenu or TrackPopupMenuEx functions.
		/// <br/>
		/// <para>
		/// If a window does not display a shortcut menu it should pass this message to the DefWindowProc function. 
		/// </para>
		/// <para>
		/// If a window is a child window, DefWindowProc sends the message to the parent. Otherwise, DefWindowProc displays a default shortcut menu 
		/// if the specified position is in the window's caption.
		/// </para>
		/// <para>
		/// DefWindowProc generates the WM_CONTEXTMENU message when it processes the WM_RBUTTONUP or WM_NCRBUTTONUP message or when the user types SHIFT+F10. 
		/// </para>
		/// <para>
		/// The WM_CONTEXTMENU message is also generated when the user presses and releases the VK_APPS key.
		/// </para>
		/// <para>
		/// If the context menu is generated from the keyboard—for example, if the user types SHIFT+F10—then the x- and y-coordinates are -1 and the application 
		/// should display the context menu at the location of the current selection rather than at (xPos, yPos).
		/// </para>
		/// </remarks>
		WM_CONTEXTMENU                  	=  0x0000007B,
		# endregion

		# region WM_COPYDATA
		/// <summary>
		/// An application sends the WM_COPYDATA message to pass data to another application. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the window passing the data. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a COPYDATASTRUCT structure that contains the data to be passed. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the receiving application processes this message, it should return TRUE; otherwise, it should return FALSE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The data being passed must not contain pointers or other references to objects not accessible to the application receiving the data. 
		/// While this message is being sent, the referenced data must not be changed by another thread of the sending process. 
		/// <para>
		/// The receiving application should consider the data read-only. The lParam parameter is valid only during the processing of the message. 
		/// </para>
		/// <para>
		/// The receiving application should not free the memory referenced by lParam. 
		/// </para>
		/// <para>
		/// If the receiving application must access the data after SendMessage returns, it must copy the data into a local buffer. 
		/// </para>
		/// </remarks>
		WM_COPYDATA				=  0x0000004A,
		# endregion

		# region WM_CREATE
		/// <summary>
		/// Sent when an application requests that a window be created by calling the CreateWindowEx or CreateWindow function. 
		/// (The message is sent before the function returns.) The window procedure of the new window receives this message after the window is created, 
		/// but before the window becomes visible.
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a CREATESTRUCT structure that contains information about the window being created.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero to continue creation of the window. 
		/// <para>
		/// If the application returns –1, the window is destroyed and the CreateWindowEx or CreateWindow function returns a NULL handle.
		/// </para>
		/// </LRESULT>
		WM_CREATE				=  0x00000001,
		# endregion

		# region WM_CTLCOLORBTN
		/// <summary>
		/// The WM_CTLCOLORBTN message is sent to the parent window of a button before drawing the button. 
		/// The parent window can change the button's text and background colors. 
		/// However, only owner-drawn buttons respond to the parent window processing this message. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// An HDC that specifies the handle to the display context for the button. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// An HWND that specifies the handle to the button. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it must return a handle to a brush. The system uses the brush to paint the background of the button. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the application returns a brush that it created (for example, by using the CreateSolidBrush or CreateBrushIndirect function), 
		/// the application must free the brush. If the application returns a system brush (for example, one that was retrieved by the GetStockObject 
		/// or GetSysColorBrush function), the application does not need to free the brush.
		/// <para>
		/// By default, the DefWindowProc function selects the default system colors for the button. Buttons with the BS_PUSHBUTTON, BS_DEFPUSHBUTTON, or BS_PUSHLIKE 
		/// styles do not use the returned brush. 
		/// </para>
		/// <para>
		/// By default, the DefWindowProc function selects the default system colors for the button. Buttons with the BS_PUSHBUTTON, BS_DEFPUSHBUTTON, or BS_PUSHLIKE 
		/// styles do not use the returned brush. 
		/// </para>
		/// <para>
		/// Buttons with these styles are always drawn with the default system colors. Drawing push buttons requires several different brushes-face, highlight, 
		/// and shadow-but the WM_CTLCOLORBTN message allows only one brush to be returned. 
		/// </para>
		/// <para>
		/// To provide a custom appearance for push buttons, use an owner-drawn button. For more information, see Creating Owner-Drawn Controls.
		/// </para>
		/// <para>
		/// The WM_CTLCOLORBTN message is never sent between threads. It is sent only within one thread. 
		/// </para>
		/// <para>
		/// The text color of a check box or radio button applies to the box or button, its check mark, and the text. 
		/// </para>
		/// <para>
		/// The focus rectangle for these buttons remains the system default color (typically black). The text color of a group box applies to the text 
		/// but not to the line that defines the box. The text color of a push button applies only to its focus rectangle; it does not affect the color of the text. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a INT_PTR and return the value directly. 
		/// </para>
		/// <para>
		/// If the dialog box procedure returns FALSE, then default message handling is performed. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_CTLCOLORBTN                  	=  0x00000135,
		# endregion

		# region WM_CTLCOLORDLG
		/// <summary>
		/// Sent to a dialog box before the system draws the dialog box. 
		/// <para>
		/// By responding to this message, the dialog box can set its text and background colors using the specified display device context handle. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the device context for the dialog box. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A handle to the dialog box. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it must return a handle to a brush. The system uses the brush to paint the background of the dialog box. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// By default, the DefWindowProc function selects the default system colors for the dialog box. 
		/// <para>
		/// The system does not automatically destroy the returned brush. It is the application's responsibility to destroy the brush when it is no longer needed.
		/// </para>
		/// <para>
		/// The WM_CTLCOLORDLG message is never sent between threads. It is sent only within one thread. 
		/// </para>
		/// <para>
		/// Note that the WM_CTLCOLORDLG message is sent to the dialog box itself; all of the other WM_CTLCOLOR* messages are sent to the owner of the control. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to an INT_PTR and return the value directly. 
		/// If the dialog box procedure returns FALSE, then default message handling is performed. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_CTLCOLORDLG                  	=  0x00000136,
		# endregion

		# region WM_CTLCOLOREDIT
		/// <summary>
		/// An edit control that is not read-only or disabled sends the WM_CTLCOLOREDIT message to its parent window when the control is about to be drawn. 
		/// <para>
		/// By responding to this message, the parent window can use the specified device context handle to set the text and background colors of the edit control. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the device context for the edit control window. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A handle to the edit control. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it must return the handle of a brush. The system uses the brush to paint the background of the edit control. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the application returns a brush that it created (for example, by using the CreateSolidBrush or CreateBrushIndirect function), 
		/// the application must free the brush. If the application returns a system brush (for example, one that was retrieved by the GetStockObject or 
		/// GetSysColorBrush function), the application does not need to free the brush. 
		/// <para>
		/// By default, the DefWindowProc function selects the default system colors for the edit control. 
		/// </para>
		/// <para>
		/// Read-only or disabled edit controls do not send the WM_CTLCOLOREDIT message; instead, they send the WM_CTLCOLORSTATIC message. 
		/// </para>
		/// <para>
		/// The WM_CTLCOLOREDIT message is never sent between threads, it is only sent within the same thread. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a INT_PTR and return the value directly. 
		/// If the dialog box procedure returns FALSE, then default message handling is performed. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// <para>
		/// Rich Edit: This message is not supported. To set the background color for a rich edit control, use the EM_SETBKGNDCOLOR message.
		/// </para>
		/// </remarks>
		WM_CTLCOLOREDIT                 	=  0x00000133,
		# endregion
 
		# region WM_CTLCOLORLISTBOX
		/// <summary>
		/// Sent to the parent window of a list box before the system draws the list box. 
		/// <para>
		/// By responding to this message, the parent window can set the text and background colors of the list box by using the specified display device context handle. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Handle to the device context for the list box. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Handle to the list box. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it must return a handle to a brush. The system uses the brush to paint the background of the list box.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// By default, the DefWindowProc function selects the default system colors for the list box.
		/// <para>
		/// The WM_CTLCOLORLISTBOX message is never sent between threads. It is sent only within one thread.
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a INT_PTR and return the value directly. 
		/// If the dialog box procedure returns FALSE, then default message handling is performed. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_CTLCOLORLISTBOX              	=  0x00000134,
		# endregion

		# region WM_CTLCOLORMSGBOX
		/// <summary>
		/// The WM_CTLCOLORMSGBOX message is sent to the owner window of a message box before Windows draws the message box. 
		/// <para>
		/// By responding to this message, the owner window can set the text and background colors of the message box by using the given display device context handle. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Handle of message box display context.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Hhandle of message box.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it must return the handle of a brush. Windows uses the brush to paint the background of the message box. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The WM_CTLCOLORMSGBOX message is never sent between threads. It is sent only within one thread. 
		/// </remarks>
		WM_CTLCOLORMSGBOX               	=  0x00000132,
		# endregion

		# region WM_CTLCOLORSCROLLBAR
		/// <summary>
		/// The WM_CTLCOLORSCROLLBAR message is sent to the parent window of a scroll bar control when the control is about to be drawn. 
		/// <para>
		/// By responding to this message, the parent window can use the display context handle to set the background color of the scroll bar control. 
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Handle to the device context for the scroll bar control. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Handle to the scroll bar. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it must return the handle to a brush. The system uses the brush to paint the background of the scroll bar control. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the application returns a brush that it created (for example, by using the CreateSolidBrush or CreateBrushIndirect function), the application 
		/// must free the brush. If the application returns a system brush (for example, one that was retrieved by the GetStockObject or GetSysColorBrush function), 
		/// the application does not need to free the brush. 
		/// <para>
		/// By default, the DefWindowProc function selects the default system colors for the scroll bar control. 
		/// </para>
		/// <para>
		/// The WM_CTLCOLORSCROLLBAR message is never sent between threads; it is only sent within the same thread. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a INT_PTR and return the value directly. 
		/// If the dialog box procedure returns FALSE, then default message handling is performed. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// <para>
		/// The WM_CTLCOLORSCROLLBAR message is used only by child scroll bar controls. Scrollbars attached to a window (WS_SCROLL and WS_VSCROLL) do not generate this message. 
		/// To customize the appearance of scrollbars attached to a window, use the flat scroll bar functions.
		/// </para>
		/// </remarks>
		WM_CTLCOLORSCROLLBAR            	=  0x00000137,
		# endregion

		# region WM_CTLCOLORSTATIC
		/// <summary>
		/// A static control, or an edit control that is read-only or disabled, sends the WM_CTLCOLORSTATIC message to its parent window when 
		/// the control is about to be drawn. 
		/// <para>
		/// By responding to this message, the parent window can use the specified device context handle to set the text foreground and background colors 
		/// of the static control. 
		/// </para>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Handle to the device context for the static control window. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Handle to the static control. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, the return value is a handle to a brush that the system uses to paint the background of the static control. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the application returns a brush that it created (for example, by using the CreateSolidBrush or CreateBrushIndirect function), 
		/// the application must free the brush. 
		/// <para>
		/// If the application returns a system brush (for example, one that was retrieved by the GetStockObject or GetSysColorBrush function), 
		/// the application does not need to free the brush. 
		/// </para>
		/// <para>
		/// By default, the DefWindowProc function selects the default system colors for the static control. 
		/// </para>
		/// <para>
		/// You can set the text background color of a disabled edit control, but you cannot set the text foreground color. The system always uses COLOR_GRAYTEXT. 
		/// Edit controls that are not read-only or disabled do not send the WM_CTLCOLORSTATIC message; instead, they send the WM_CTLCOLOREDIT message. 
		/// </para>
		/// <para>
		/// The WM_CTLCOLORSTATIC message is never sent between threads; it is sent only within the same thread. 
		/// </para>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a INT_PTR and return the value directly. 
		/// If the dialog box procedure returns FALSE, then default message handling is performed. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_CTLCOLORSTATIC               	=  0x00000138,
		# endregion

		# region WM_COPY
		/// <summary>
		/// An application sends the WM_COPY message to an edit control or combo box to copy the current selection to the clipboard in CF_TEXT format. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero. </LPARAM>
		/// <LRESULT>This message does not return a value. </LRESULT>
		/// 
		/// <remarks>
		/// When sent to a combo box, the WM_COPY message is handled by its edit control. This message has no effect when sent to a combo box with the CBS_DROPDOWNLIST style. 
		/// </remarks>
		WM_COPY                         	=  0x00000301,
		# endregion

		# region WM_CUT
		/// <summary>
		/// An application sends a WM_CUT message to an edit control or combo box to delete (cut) the current selection, if any, 
		/// in the edit control and copy the deleted text to the clipboard in CF_TEXT format. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero. </LPARAM>
		/// <LRESULT>This message does not return a value. </LRESULT>
		/// 
		/// <remarks>
		/// The deletion performed by the WM_CUT message can be undone by sending the edit control an EM_UNDO message. 
		/// <para>
		/// To delete the current selection without placing the deleted text on the clipboard, use the WM_CLEAR message. 
		/// </para>
		/// <para>
		/// When sent to a combo box, the WM_CUT message is handled by its edit control. 
		/// </para>
		/// <para>
		/// This message has no effect when sent to a combo box with the CBS_DROPDOWNLIST style. 
		/// </para>
		/// </remarks>
		WM_CUT                          	=  0x00000300,
		# endregion

		# region WM_DEADCHAR
		/// <summary>
		/// Posted to the window with the keyboard focus when a WM_KEYUP message is translated by the TranslateMessage function. 
		/// WM_DEADCHAR specifies a character code generated by a dead key. 
		/// <para>
		/// A dead key is a key that generates a character, such as the umlaut (double-dot), that is combined with another character to form a composite character. 
		/// For example, the umlaut-O character (Ö) is generated by typing the dead key for the umlaut character, and then typing the O key. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The character code generated by the dead key. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return zero if it processes this message. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The WM_DEADCHAR message typically is used by applications to give the user feedback about each key pressed. 
		/// For example, an application can display the accent in the current character position without moving the caret. 
		/// <para>
		/// Because there is not necessarily a one-to-one correspondence between keys pressed and character messages generated, the information in the high-order word 
		/// of the lParam parameter is generally not useful to applications. The information in the high-order word applies only to the most recent WM_KEYDOWN message 
		/// that precedes the posting of the WM_DEADCHAR message. 
		/// </para>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and the right CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and ENTER keys 
		/// in the numeric keypad. Some other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// </remarks>
		WM_DEADCHAR                     	=  0x00000103,
		# endregion

		# region WM_DELETEITEM
		/// <summary>
		/// Sent to the owner of a list box or combo box when the list box or combo box is destroyed or when items are removed by the 
		/// LB_DELETESTRING, LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT message. 
		/// <para>
		/// The system sends a WM_DELETEITEM message for each deleted item. The system sends the WM_DELETEITEM message for any deleted list box or combo box item 
		/// with nonzero item data.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the identifier of the control that sent the WM_DELETEITEM message. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Pointer to a DELETEITEMSTRUCT structure that contains information about the item deleted from a list box. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return TRUE if it processes this message. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Microsoft Windows NT and later: Windows sends a WM_DELETEITEM message only for items deleted from an owner-drawn list box 
		/// (with the LBS_OWNERDRAWFIXED or LBS_OWNERDRAWVARIABLE style) or owner-drawn combo box (with the CBS_OWNERDRAWFIXED or CBS_OWNERDRAWVARIABLE style).
		/// <para>
		/// Windows 95: Windows sends the WM_DELETEITEM message for any deleted list box or combo box item with nonzero item data.
		/// </para>
		/// </remarks>
		WM_DELETEITEM           		=  0x0000002D,
		# endregion

		# region WM_DESTROY
		/// <summary>
		/// Sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed after the window is removed from the screen. 
		/// <para>
		/// This message is sent first to the window being destroyed and then to the child windows (if any) as they are destroyed. 
		/// During the processing of the message, it can be assumed that all child windows still exist.
		/// </para>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// If the window being destroyed is part of the clipboard viewer chain (set by calling the SetClipboardViewer function), the window must remove itself from the chain
		/// by processing the ChangeClipboardChain function before returning from the WM_DESTROY message.
		/// </remarks>
		WM_DESTROY				=  0x00000002,
		# endregion

		# region WM_DESTROYCLIPBOARD
		/// <summary>
		/// Sent to the clipboard owner when a call to the EmptyClipboard function empties the clipboard. 
		/// A window receives this message through its WindowProc function. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		WM_DESTROYCLIPBOARD             	=  0x00000307,
		# endregion

		# region WM_DEVICECHANGE
		/// <summary>
		/// Notifies an application of a change to the hardware configuration of a device or the computer.
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The event that has occurred. This parameter can be one of the DBT_Constants values.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a structure that contains event-specific data. Its format depends on the value of the wParam parameter. 
		/// <para>
		/// For more information, refer to the documentation for each event.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// Return TRUE to grant the request.
		/// Return BROADCAST_QUERY_DENY to deny the request.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// For devices that offer software-controllable features, such as ejection and locking, the system typically sends a DBT_DEVICEREMOVEPENDING message 
		/// to let applications and device drivers end their use of the device gracefully. If the system forcibly removes a device, it may not send a 
		/// DBT_DEVICEQUERYREMOVE message before doing so.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_DEVICECHANGE                 	=  0x00000219,
		# endregion

		# region WM_DEVMODECHANGE
		/// <summary>
		/// The WM_DEVMODECHANGE message is sent to all top-level windows whenever the user changes device-mode settings.
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a string that specifies the device name.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return zero if it processes this message.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This message cannot be sent directly to a window. To send the WM_DEVMODECHANGE message to all top-level windows, use the SendMessageTimeout function 
		/// with the hWnd parameter set to HWND_BROADCAST.
 		/// </remarks>
		WM_DEVMODECHANGE        		=  0x0000001B,
		# endregion

		# region WM_DISPLAYCHANGE
		/// <summary>
		/// The WM_DISPLAYCHANGE message is sent to all windows when the display resolution has changed.
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The new image depth of the display, in bits per pixel.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the horizontal resolution of the screen.
		/// <para>
		/// The high-order word specifies the vertical resolution of the screen.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// This message is only sent to top-level windows. For all other windows it is posted.
		/// </LRESULT>
		WM_DISPLAYCHANGE                	=  0x0000007E,
		# endregion

		# region WM_DRAWCLIPBOARD
		/// <summary>
		/// Sent to the first window in the clipboard viewer chain when the content of the clipboard changes. This enables a clipboard viewer window 
		/// to display the new content of the clipboard. 
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero. </LPARAM>
		/// 
		/// <remarks>
		/// Only clipboard viewer windows receive this message. These are windows that have been added to the clipboard viewer chain by using the SetClipboardViewer function. 
		/// <para>
		/// Each window that receives the WM_DRAWCLIPBOARD message must call the SendMessage function to pass the message on to the next window in the clipboard viewer chain. 
		/// </para>
		/// <para>
		/// The handle to the next window in the chain is returned by SetClipboardViewer, and may change in response to a WM_CHANGECBCHAIN message. 
		/// </para>
		/// </remarks>
		WM_DRAWCLIPBOARD                	=  0x00000308,
		# endregion

		# region WM_DRAWITEM
		/// <summary>
		/// Sent to the parent window of an owner-drawn button, combo box, list box, or menu when a visual aspect of the button, combo box, list box, or menu has changed.
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Specifies the identifier of the control that sent the WM_DRAWITEM message. If the message was sent by a menu, this parameter is zero. </WPARAM>
		/// 
		/// <LPARAM>Pointer to a DRAWITEMSTRUCT structure containing information about the item to be drawn and the type of drawing required.</LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return TRUE.</LRESULT>
		/// 
		/// <remarks>
		/// By default, the DefWindowProc function draws the focus rectangle for an owner-drawn list box item. 
		/// <para>
		/// The itemAction member of the DRAWITEMSTRUCT structure specifies the drawing operation that an application should perform. 
		/// </para>
		/// <para>
		/// Before returning from processing this message, an application should ensure that the device context identified by the hDC member of the 
		/// DRAWITEMSTRUCT structure is in the default state. 
		/// </para>
		/// </remarks>
		WM_DRAWITEM             		=  0x0000002B,
		# endregion

		#  region WM_DROPFILES
		/// <summary>
		/// Sent when the user drops a file on the window of an application that has registered itself as a recipient of dropped files.
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to an internal structure describing the dropped files. Pass this handle DragFinish, DragQueryFile, or DragQueryPoint to retrieve information 
		/// about the dropped files.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">Not used ; must be zero.</LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// The HDROP handle is declared in Shellapi.h. You must include this header in your build to use WM_DROPFILES. 
		/// <para>
		/// For further discussion of how to use drag-and-drop to transfer Shell data, see Transferring Shell Data Using Drag-and-Drop or the Clipboard.
		/// </para>
		/// </remarks>
		WM_DROPFILES                    	=  0x00000233,
		# endregion

		# region WM_DWMCOLORIZATIONCOLORCHANGED
		/// <summary>
		/// Informs all top-level windows that the colorization color has changed.
		/// </summary>
		/// 
		/// <WPARAM>Specifies the new colorization color. The color format is 0xAARRGGBB.</WPARAM>
		/// <LPARAM>Specifies whether the new color is blended with opacity.</LPARAM>
		/// <LRESULT>an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// A window receives this message through its WindowProc function.
		/// <para>
		/// DwmGetColorizationColor is used to determine the current color value.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_DWMCOLORIZATIONCOLORCHANGED  	=  0x00000320,
		# endregion

		# region WM_DWMCOMPOSITIONCHANGED
		/// <summary>
		/// Informs all top-level windows that Desktop Window Manager (DWM) composition has been enabled or disabled.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used.</WPARAM>
		/// <LPARAM unused="true">Not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// A window receives this message through its WindowProc function.
		/// <para>
		/// The DwmIsCompositionEnabled function can be used to determine the current composition state.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_DWMCOMPOSITIONCHANGED        	=  0x0000031E,
		# endregion

		#  region WM_DWMNCRENDERINGCHANGED
		/// <summary>
		/// Sent when the non-client area rendering policy has changed.
		/// </summary>
		/// 
		/// <WPARAM>Specifies whether DWM rendering is enabled for the non-client area of the window. TRUE if enabled; otherwise, FALSE.</WPARAM>
		/// <LPARAM unused="true">Not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// A window receives this message through its WindowProc function.
		/// <para>
		/// The DwmGetWindowAttribute and DwmSetWindowAttribute functions are used to get or set the non-client rendering policy.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_DWMNCRENDERINGCHANGED        	=  0x0000031F,
		# endregion

		# region WM_DWMSENDICONICLIVEPREVIEWBITMAP
		/// <summary>
		/// Instructs a window to provide a static bitmap to use as a live preview (also known as a Peek preview) of that window.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used.</WPARAM>
		/// <LPARAM unused="true">Not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// A live preview (also known as a Peek preview) of a window appears when a user moves the mouse pointer over the window's thumbnail in the taskbar 
		/// or gives the thumbnail focus in the ALT+TAB window. This view is a full-sized preview of the window and can be a live snapshot or an iconic representation.
		/// Desktop Window Manager (DWM) sends this message to a window if all of the following situations are true : 
		/// <para>• Live preview has been invoked on the window.</para>
		/// <para>• The DWMWA_HAS_ICONIC_BITMAP attribute is set on the window.</para>
		/// <para>• An iconic representation is the only one that exists for this window.</para>
		/// <para>
		/// The window that receives this message should respond by generating a full-scale bitmap. The window then calls the DwmSetIconicLivePreviewBitmap function 
		/// to set the live preview. If the window does not set a bitmap in a given amount of time, DWM uses its own default iconic representation for the window.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows7 )]
		WM_DWMSENDICONICLIVEPREVIEWBITMAP	=  0x00000326,
		# endregion

		# region WM_DWMSENDICONICTHUMBNAIL
		/// <summary>
		/// Instructs a window to provide a static bitmap to use as a thumbnail representation of that window.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used.</WPARAM>
		/// <LPARAM>
		/// The HIWORD of this value is the maximum x-coordinate of the thumbnail. The LOWORD is the maximum y-coordinate. 
		/// If a thumbnail has a dimension that exceeds one or both of these values, the DWM does not accept the thumbnail.
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// DWM sends this message to a window if all of the following situations are true :
		/// <para>• DWM is displaying an iconic representation of the window.</para>
		/// <para>• The DWMWA_HAS_ICONIC_BITMAP attribute is set on the window.</para>
		/// <para>• The window did not set a cached bitmap.</para>
		/// <para>• There is room in the cache for another bitmap.</para>
		/// <para>
		/// The window that receives this message should respond by generating a bitmap that is not larger than the size that is requested in the message parameters. 
		/// </para>
		/// <para>
		/// The window then calls the DwmSetIconicThumbnail function to override the default thumbnail. If the window does not supply a bitmap in a given amount of time, 
		/// DWM uses its own default iconic representation for the window.
		/// </para>
		/// <para>
		/// The window must belong to the calling process.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows7 )]
		WM_DWMSENDICONICTHUMBNAIL        	=  0x00000323,
		# endregion

		# region WM_DWMWINDOWMAXIMIZEDCHANGE
		/// <summary>
		/// Sent when a Desktop Window Manager (DWM) composed window is maximized.
		/// </summary>
		/// 
		/// <WPARAM>Set to true to specify that the window has been maximized.</WPARAM>
		/// <LPARAM unused="true">Not used.</LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// <remarks>A window receives this message through its WindowProc function.</remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_DWMWINDOWMAXIMIZEDCHANGE     	=  0x00000321,
		# endregion

		# region WM_ENABLE
		/// <summary>
		/// Sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. 
		/// <para>
		/// This message is sent before the EnableWindow function returns, but after the enabled state (WS_DISABLED style bit) of the window has changed.
		/// </para>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Indicates whether the window has been enabled or disabled. This parameter is TRUE if the window has been enabled or FALSE 
		/// if the window has been disabled.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_ENABLE               		=  0x0000000A,
		# endregion

		# region WM_ENTERIDLE
		/// <summary>
		/// Sent to the owner window of a modal dialog box or menu that is entering an idle state. 
		/// <para>
		/// A modal dialog box or menu enters an idle state when no messages are waiting in its queue after it has processed one or more previous messages. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM class="MSGF_Constants">This parameter can be either MSGF_Constants.MSGF_DIALOGBOX or MSGF_MENU.</WPARAM>
		/// <LPARAM>A handle to the dialog box (if wParam is MSGF_DIALOGBOX) or window containing the displayed menu (if wParam is MSGF_MENU).</LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// <remarks>You can suppress the WM_ENTERIDLE message for a dialog box by creating the dialog box with the DS_NOIDLEMSG style. </remarks>
		WM_ENTERIDLE                    	=  0x00000121,
		# endregion

		# region WM_ENTERMENULOOP
		/// <summary>
		/// Notifies an application's main window procedure that a menu modal loop has been entered. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies whether the window menu was entered using the TrackPopupMenu function. 
		/// <para>
		/// This parameter has a value of TRUE if the window menu was entered using TrackPopupMenu, and FALSE if it was not. 
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>The DefWindowProc function returns zero.</remarks>
		WM_ENTERMENULOOP                	=  0x00000211,
		# endregion

		# region WM_ENTERSIZEMOVE
		/// <summary>
		/// Sent one time to a window after it enters the moving or sizing modal loop.
		/// <para>
		/// The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes 
		/// the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. 
		/// </para>
		/// <para>
		/// The operation is complete when DefWindowProc returns. 
		/// </para>
		/// <para>
		/// The system sends the WM_ENTERSIZEMOVE message regardless of whether the dragging of full windows is enabled.
		/// </para>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		WM_ENTERSIZEMOVE                	=  0x00000231,
		# endregion

		# region WM_ERASEBKGND
		/// <summary>
		/// Sent when the window background must be erased (for example, when a window is resized). 
		/// <para>
		/// The message is sent to prepare an invalidated portion of a window for painting. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the device context. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>An application should return nonzero if it erases the background; otherwise, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function erases the background by using the class background brush specified by the hbrBackground member of the WNDCLASS structure. 
		/// <para>
		/// If hbrBackground is NULL, the application should process the WM_ERASEBKGND message and erase the background. 
		/// </para>
		/// An application should return nonzero in response to WM_ERASEBKGND if it processes the message and erases the background; this indicates that no further erasing 
		/// is required. If the application returns zero, the window will remain marked for erasing. (Typically, this indicates that the fErase member of the PAINTSTRUCT 
		/// structure will be TRUE.) 
		/// <para>
		/// </para>
		/// </remarks>
		WM_ERASEBKGND           		=  0x00000014,
		# endregion

		# region WM_EXITMENULOOP
		/// <summary>
		/// Notifies an application's main window procedure that a menu modal loop has been exited. 
		/// </summary>
		/// 
		/// <WPARAM class="bool">Specifies whether the menu is a shortcut menu. This parameter has a value of TRUE if it is a shortcut menu, FALSE if it is not.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>	
		/// <remarks>The DefWindowProc function returns zero.</remarks>
		WM_EXITMENULOOP                 	=  0x00000212,
		# endregion

		# region WM_EXITSIZEMOVE
		/// <summary>
		/// Sent one time to a window, after it has exited the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks 
		/// the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of 
		/// the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns. 
		/// <para>A window receives this message through its WindowProc function. </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		WM_EXITSIZEMOVE                 	=  0x00000232,
		# endregion

		# region WM_FONTCHANGE
		/// <summary>
		/// An application sends the WM_FONTCHANGE message to all top-level windows in the system after changing the pool of font resources.
		/// <para>
		/// To send this message, call the SendMessage function with HWND_BROADCAST as the hwnd parameter.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT unused="true">Unused. An application should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// An application that adds or removes fonts from the system (for example, by using the AddFontResource or RemoveFontResource function) should send this message 
		/// to all top-level windows.
		/// <para>
		/// To send the WM_FONTCHANGE message to all top-level windows, an application can call the SendMessage function with the hwnd parameter set to HWND_BROADCAST.
		/// </para>
		/// </remarks>
		WM_FONTCHANGE           		=  0x0000001D,
		# endregion

		# region WM_GESTURE
		/// <summary>
		/// Passes information about a gesture. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Provides information identifying the gesture command and gesture-specific argument values. 
		/// This information is the same information passed in the ullArguments member of the GESTUREINFO structure.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Provides a handle to information identifying the gesture command and gesture-specific argument values. This information is retrieved by calling GetGestureInfo.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return 0. 
		/// <para>
		/// If the application does not process the message, it must call DefWindowProc. Not doing so will cause the application to leak memory because the touch input handle 
		/// will not be closed and associated process memory will not be freed.
		/// </para>
		/// </LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Windows7 )]
		WM_GESTURE                      	=  0x00000119,
		# endregion

		# region WM_GESTURENOTIFY
		/// <summary>
		/// Gives you a chance to set the gesture configuration. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Unused.</WPARAM>
		/// <LPARAM>A pointer to a GESTURENOTIFYSTRUCT.</LPARAM>
		/// <LRESULT>A value should be returned from DefWindowProc. </LRESULT>
		/// 
		/// <remarks>
		/// When the WM_GESTURENOTIFY message is received, the application can use SetGestureConfig to specify the gestures to receive. 
		/// This message should always be bubbled up using the DefWindowProc function. 
		/// <br/>
		/// <para>
		/// Note : Handling the WM_GESTURENOTIFY message will change the gesture configuration for the lifetime of the Window, not just for the next gesture. 
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows7 )]
		WM_GESTURENOTIFY                	=  0x0000011A,
		# endregion

		# region WM_GETDLGCODE
		/// <summary>
		/// Sent to the window procedure associated with a control. By default, the system handles all keyboard input to the control; the system interprets 
		/// certain types of keyboard input as dialog box navigation keys. To override this default behavior, the control can respond to the WM_GETDLGCODE message 
		/// to indicate the types of input it wants to process itself.
		/// </summary>
		/// 
		/// <WPARAM class="VK_Constants">
		/// Sent to the window procedure associated with a control. By default, the system handles all keyboard input to the control; the system interprets 
		/// certain types of keyboard input as dialog box navigation keys. 
		/// To override this default behavior, the control can respond to the WM_GETDLGCODE message to indicate the types of input it wants to process itself.
		/// </WPARAM>
		/// 
		/// <LPARAM class="IntPtr">
		/// A pointer to an MSG structure (or NULL if the system is performing a query). 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value can be any combination of the DLG_Constants enumeration.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Although the DefWindowProc function always returns zero in response to the WM_GETDLGCODE message, the window procedure for the predefined control classes 
		/// return a code appropriate for each class. 
		/// <br/>
		/// <para>
		/// The WM_GETDLGCODE message and the returned values are useful only with user-defined dialog box controls or standard controls modified by subclassing. 
		/// </para>
		/// </remarks>
		WM_GETDLGCODE                   	=  0x00000087,
		# endregion

		# region WM_GETFONT
		/// <summary>
		/// Retrieves the font with which the control is currently drawing its text. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero.</LPARAM>
		/// 
		/// <LRESULT>The return value is a handle to the font used by the control, or NULL if the control is using the system font.</LRESULT>
		WM_GETFONT              		=  0x00000031,
		# endregion

		# region MN_GETHMENU
		/// <summary>
		/// Retrieves the menu handle for the current window.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero.</LPARAM>
		/// 
		/// <LRESULT>If successful, the return value is the HMENU for the current window. If it fails, the return value is NULL.</LRESULT>
		MN_GETHMENU                     	=  0x000001E1,
		# endregion

		# region WM_GETHOTKEY
		/// <summary>
		/// Sent to determine the hot key associated with a window. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the virtual-key code and modifiers for the hot key, or NULL if no hot key is associated with the window. 
		/// The virtual-key code is in the low byte of the return value and the modifiers are in the high byte. 
		/// The modifiers can be a combination of HOTKEY_Constants values.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// These hot keys are unrelated to the hot keys set by the RegisterHotKey function. 
		/// </remarks>
		WM_GETHOTKEY            		=  0x00000033,
		# endregion

		# region WM_GETICON
		/// <summary>
		/// Sent to a window to retrieve a handle to the large or small icon associated with a window. 
		/// The system displays the large icon in the ALT+TAB dialog, and the small icon in the window caption.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM class="ICON_Constants">The type of icon being retrieved.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is a handle to the large or small icon, depending on the value of wParam. When an application receives this message, 
		/// it can return a handle to a large or small icon, or pass the message to the DefWindowProc function.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When an application receives this message, it can return a handle to a large or small icon, or pass the message to DefWindowProc.
		/// <br/>
		/// <para>
		/// DefWindowProc returns a handle to the large or small icon associated with the window, depending on the value of wParam. 
		/// </para>
		/// </remarks>
		WM_GETICON                      	=  0x0000007F,
		# endregion

		# region WM_GETMINMAXINFO
		/// <summary>
		/// Sent to a window when the size or position of the window is about to change. 
		/// An application can use this message to override the window's default maximized size and position, or its default minimum or maximum tracking size.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM>
		/// A pointer to a MINMAXINFO structure that contains the default maximized position and dimensions, and the default minimum and maximum tracking sizes. 
		/// An application can override the defaults by setting the members of this structure.
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// The maximum tracking size is the largest window size that can be produced by using the borders to size the window. 
		/// The minimum tracking size is the smallest window size that can be produced by using the borders to size the window.
		/// </remarks>
		WM_GETMINMAXINFO        		=  0x00000024,
		# endregion

		# region WM_GETTEXT
		/// <summary>
		/// Copies the text that corresponds to a window into a buffer provided by the caller. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The maximum number of characters to be copied, including the terminating null character. 
		/// <br/>
		/// <para>
		/// ANSI applications may have the string in the buffer reduced in size (to a minimum of half that of the wParam value) due to conversion from ANSI to Unicode. 
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the buffer that is to receive the text. 
		/// </LPARAM>
		/// 
		/// <LRESULT>The return value is the number of characters copied, not including the terminating null character. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function copies the text associated with the window into the specified buffer and returns the number of characters copied. 
		/// Note, for non-text static controls this gives you the text with which the control was originally created, that is, the ID number. 
		/// However, it gives you the ID of the non-text static control as originally created. That is, if you subsequently used a STM_SETIMAGE to change it 
		/// the original ID would still be returned.
		/// <br/>
		/// <para>
		/// For an edit control, the text to be copied is the content of the edit control. For a combo box, the text is the content of the edit control 
		/// (or static-text) portion of the combo box. For a button, the text is the button name. For other windows, the text is the window title. 
		/// To copy the text of an item in a list box, an application can use the LB_GETTEXT message. 
		/// </para>
		/// <br/>
		/// <para>
		/// When the WM_GETTEXT message is sent to a static control with the SS_ICON style, a handle to the icon will be returned in the first four bytes 
		/// of the buffer pointed to by lParam. This is true only if the WM_SETTEXT message has been used to set the icon. 
		/// </para>
		/// <br/>
		/// <para>
		/// Rich Edit: If the text to be copied exceeds 64K, use either the EM_STREAMOUT or EM_GETSELTEXT message.
		/// </para>
		/// <br/>
		/// <para>
		/// Sending a WM_GETTEXT message to a non-text static control, such as a static bitmap or static icon control, does not return a string value. 
		/// Instead, it returns zero. In addition, in early versions of Windows, applications could send a WM_GETTEXT message to a non-text static control 
		/// to retrieve the control's ID. To retrieve a control's ID, applications can use GetWindowLong passing GWL_ID as the index value or GetWindowLongPtr 
		/// using GWLP_ID.
		/// </para>
		/// </remarks>
		WM_GETTEXT              		=  0x0000000D,
		# endregion

		# region WM_GETTEXTLENGTH
		/// <summary>
		/// Determines the length, in characters, of the text associated with a window. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero.</LPARAM>
		/// 
		/// <LRESULT>The return value is the length of the text in characters, not including the terminating null character.</LRESULT>
		/// 
		/// <remarks>
		/// For an edit control, the text to be copied is the content of the edit control. For a combo box, the text is the content of the edit control 
		/// (or static-text) portion of the combo box. For a button, the text is the button name. For other windows, the text is the window title. 
		/// To determine the length of an item in a list box, an application can use the LB_GETTEXTLEN message. 
		/// <br/>
		/// <para>
		/// When the WM_GETTEXTLENGTH message is sent, the DefWindowProc function returns the length, in characters, of the text. Under certain conditions, 
		/// the DefWindowProc function returns a value that is larger than the actual length of the text. This occurs with certain mixtures of ANSI and Unicode, 
		/// and is due to the system allowing for the possible existence of double-byte character set (DBCS) characters within the text. 
		/// The return value, however, will always be at least as large as the actual length of the text; you can thus always use it to guide buffer allocation. 
		/// This behavior can occur when an application uses both ANSI functions and common dialogs, which use Unicode. 
		/// </para>
		/// <br/>
		/// <para>
		/// To obtain the exact length of the text, use the WM_GETTEXT, LB_GETTEXT, or CB_GETLBTEXT messages, or the GetWindowText function.
		/// </para>
		/// <br/>
		/// <para>
		/// Sending a WM_GETTEXTLENGTH message to a non-text static control, such as a static bitmap or static icon controlc, 
		/// does not return a string value. Instead, it returns zero.
		/// </para>
		/// </remarks>
		WM_GETTEXTLENGTH        		=  0x0000000E,
		# endregion

		# region WM_GETTITLEBARINFOEX
		/// <summary>
		/// Sent to request extended title bar information. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be 0.</WPARAM>
		/// <LPARAM>
		/// A pointer to a TITLEBARINFOEX structure. The message sender is responsible for allocating memory for this structure. 
		/// Set the cbSize member of this structure to sizeof(TITLEBARINFOEX) before passing this structure with the message.
		/// </LPARAM>
		/// 
		/// <LRESULT unused="true">Not used.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. WindowsVista )]
		WM_GETTITLEBARINFOEX			=  0x0000033F,
		# endregion

		# region WM_HELP
		/// <summary>
		/// Indicates that the user pressed the F1 key. If a menu is active when F1 is pressed, WM_HELP is sent to the window associated with the menu; 
		/// otherwise, WM_HELP is sent to the window that has the keyboard focus. If no window has the keyboard focus, WM_HELP is sent to the currently active window.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used. Must be zero.</WPARAM>
		/// <LPARAM>The address of a HELPINFO structure that contains information about the menu item, control, dialog box, or window for which Help is requested.</LPARAM>
		/// 
		/// <LRESULT>Returns TRUE.</LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function passes WM_HELP to the parent window of a child window or to the owner of a top-level window.
		/// </remarks>
		WM_HELP                         	=  0x00000053,
		# endregion

		# region WM_HOTKEY
		/// <summary>
		/// Posted when the user presses a hot key registered by the RegisterHotKey function. 
		/// The message is placed at the top of the message queue associated with the thread that registered the hot key. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The identifier of the hot key that generated the message. If the message was generated by a system-defined hot key, this parameter will be 
		/// either IDHOTKEY_SNAPDESKTOP (PrintScreen key) or IDHOTKEY_SNAPWINDOW (Shift-PrintScreen combination).
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the keys that were to be pressed in combination with the key specified by the high-order word to generate the WM_HOTKEY message. 
		/// This word can be one or more of MOD_Contants values.
		/// </LPARAM>
		/// 
		/// <LRESULT unused="true">Not used.</LRESULT>
		/// 
		/// <remarks>
		/// WM_HOTKEY is unrelated to the WM_GETHOTKEY and WM_SETHOTKEY hot keys. The WM_HOTKEY message is sent for generic hot keys while the 
		/// WM_SETHOTKEY and WM_GETHOTKEY messages relate to window activation hot keys.
		/// </remarks>
		WM_HOTKEY                       	=  0x00000312,
		# endregion

		# region WM_HSCROLL
		/// <summary>
		/// The WM_HSCROLL message is sent to a window when a scroll event occurs in the window's standard horizontal scroll bar. 
		/// This message is also sent to the owner of a horizontal scroll bar control when a scroll event occurs in the control. 
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The HIWORD specifies the current position of the scroll box if the LOWORD is SB_THUMBPOSITION or SB_THUMBTRACK; otherwise, this word is not used.
		/// The LOWORD specifies an SB_Constants scroll bar value that indicates the user's scrolling request.
		/// </WPARAM>
		WM_HSCROLL                      	=  0x00000114,
		# endregion

		# region WM_HSCROLLCLIPBOARD
		/// <summary>
		/// Sent to the clipboard owner by a clipboard viewer window. This occurs when the clipboard contains data in the CF_OWNERDISPLAY format and 
		/// an event occurs in the clipboard viewer's horizontal scroll bar. The owner should scroll the clipboard image and update the scroll bar values. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the clipboard viewer window.</WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word of lParam specifies a scroll bar event. This parameter can be one of the SB_Constants values. 
		/// The high-order word of lParam specifies the current position of the scroll box if the low-order word of lParam is SB_THUMBPOSITION; 
		/// otherwise, the high-order word is not used. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// The clipboard owner can use the ScrollWindow function to scroll the image in the clipboard viewer window and invalidate the appropriate region. 
		/// </remarks>
		WM_HSCROLLCLIPBOARD             	=  0x0000030E,
		# endregion

		# region WM_ICONERASEBKGND
		/// <summary>
		/// Windows NT 3.51 and earlier: The WM_ICONERASEBKGND message is sent to a minimized window when the background of the icon must be filled before painting the icon. 
		/// A window receives this message only if a class icon is defined for the window; otherwise, WM_ERASEBKGND is sent. 
		/// This message is not sent by newer versions of Windows.
		/// </summary>
		/// 
		/// <WPARAM>Handle to the device context of the icon.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// <LRESULT>An application should return nonzero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// Windows NT 3.51 and earlier: The DefWindowProc function fills the icon background with the class background brush of the parent window. On newer versions of Windows, 
		/// the DefWindowProc function ignores the message.
		/// </remarks>
		WM_ICONERASEBKGND       		=  0x00000027,
		# endregion

		# region WM_IME_CHAR
		/// <summary>
		/// Sent to an application when the IME gets a character of the conversion result. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>
		/// DBCS: A single-byte or double-byte character value. For a double-byte character, (BYTE)(wParam >> 8) contains the lead byte. 
		/// Note that the parentheses are necessary because the cast operator has higher precedence than the shift operator.
		/// <br/>
		/// <para>
		/// Unicode: A Unicode character value.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_CHAR_LPARAM">
		/// The repeat count, scan code, extended key flag, context code, previous key state flag, and transition state flag.
		/// </LPARAM>
		/// 
		/// <LRESULT unused="true">Not used.</LRESULT>
		/// 
		/// <remarks>
		/// Unlike the WM_CHAR message for a non-Unicode window, this message can include double-byte and single-byte character values. 
		/// For a Unicode window, this message is the same as WM_CHAR.
		/// <br/>
		/// <para>
		/// For a non-Unicode window, if the WM_IME_CHAR message includes a double-byte character and the application passes this message to DefWindowProc, 
		/// the IME converts this message into two WM_CHAR messages, each containing one byte of the double-byte character.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_CHAR                     	=  0x00000286,
		# endregion

		# region WM_IME_COMPOSITION
		/// <summary>
		/// Sent to an application when the IME changes composition status as a result of a keystroke. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>DBCS character representing the latest change to the composition string.</WPARAM>
		/// <LPARAM>
		/// Value specifying how the composition string or character changed. This parameter can be one or more of the IMEGCS_Constants values.
		/// </LPARAM>
		/// 
		/// <LRESULT unused="true">This message has no return value.</LRESULT>
		/// 
		/// <remarks>
		/// An application should process this message if it displays composition characters itself. Otherwise, it should send the message to the IME window.
		/// <br/>
		/// <para>
		/// If the application has created an IME window, it should pass this message to that window. 
		/// The DefWindowProc function processes this message by passing it to the default IME window. 
		/// The IME window processes this message by updating its appearance based on the change flag specified. 
		/// An application can call ImmGetCompositionString to retrieve the new composition status.
		/// </para>
		/// <br/>
		/// <para>
		/// If none of the GCS_ values are set, the message indicates that the current composition has been canceled and applications that draw the composition string 
		/// should delete the string.
		/// </para>
		/// </remarks>
		WM_IME_COMPOSITION              	=  0x0000010F,
		# endregion

		# region WM_IME_COMPOSITIONFULL
		/// <summary>
		/// Sent to an application when the IME window finds no space to extend the area for the composition window. 
		/// A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>This message has no return value.</LRESULT>
		/// 
		/// <remarks>
		/// The application should use the IMC_SETCOMPOSITIONWINDOW command to specify how the window should be displayed.
		/// <br/>
		/// <para>
		/// The IME window, instead of the IME, sends this notification message by the SendMessage function.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_COMPOSITIONFULL          	=  0x00000284,
		# endregion

		# region WM_IME_CONTROL
		/// <summary>
		/// Sent by an application to direct the IME window to carry out the requested command. The application uses this message to control the IME window 
		/// that it has created. 
		/// To send this message, the application calls the SendMessage function with the following parameters. 
		/// </summary>
		/// 
		/// <WPARAM>The command. This parameter can have one of the IMC_Constants values.</WPARAM>
		/// <LPARAM>
		/// Command-specific data, with format dependent on the value of the wParam parameter. For more information, refer to the documentation for each command. 
		/// </LPARAM>
		/// 
		/// <LRESULT>The message returns a command-specific value.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_CONTROL                  	=  0x00000283,
		# endregion

		# region WM_IME_ENDCOMPOSITION
		/// <summary>
		/// Sent to an application when the IME ends composition. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT unused="true">This message has no return value.</LRESULT>
		/// 
		/// <remarks>
		/// An application should process this message if it displays composition characters itself.
		/// <br/>
		/// <para>
		/// If the application has created an IME window, it should pass this message to that window. 
		/// The DefWindowProc function processes this message by passing it to the default IME window.
		/// </para>
		/// </remarks>
		WM_IME_ENDCOMPOSITION           	=  0x0000010E,
		# endregion
	
		# region WM_IME_KEYDOWN
		/// <summary>
		/// Sent to an application by the IME to notify the application of a key press and to keep message order. 
		/// A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>Virtual key code of the key.</WPARAM>
		/// <LPARAM>
		/// Repeat count, scan code, extended key flag, context code, previous key state flag, and transition state flag.
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return 0 if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// An application can process this message or pass it to the DefWindowProc function to generate a matching WM_KEYDOWN message.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_KEYDOWN                  	=  0x00000290,
		# endregion

		# region WM_IME_KEYUP
		/// <summary>
		/// Sent to an application by the IME to notify the application of a key release and to keep message order. 
		/// A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>Virtual key code of the key.</WPARAM>
		/// <LPARAM>Repeat count, scan code, extended key flag, context code, previous key state flag, and transition state flag.</LPARAM>
		/// <LRESULT>An application should return 0 if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// An application can process this message or pass it to the DefWindowProc function to generate a matching WM_KEYUP message.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_KEYUP                    	=  0x00000291,
		#  endregion

		# region WM_IME_NOTIFY
		/// <summary>
		/// Sent to an application to notify it of changes to the IME window. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>The command. This parameter can have one of the IMC_Constants values.</WPARAM>
		/// <LPARAM>
		/// Command-specific data, with format dependent on the value of the wParam parameter. 
		/// For more information, refer to the documentation for each command.
		/// </LPARAM>
		/// <LRESULT>The return value depends on the command sent.</LRESULT>
		/// 
		/// <remarks>
		/// An application processes this message if it is responsible for managing the IME window.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_NOTIFY                   	=  0x00000282,
		# endregion

		# region WM_IME_REQUEST
		/// <summary>
		/// Sent to an application to provide commands and request information. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>Command. This parameter can have one of the IMR_Constants values.</WPARAM>
		/// <LPARAM>Command-specific data. For more information, see the description for each command.</LPARAM>
		/// <LRESULT>Returns a command-specific value.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_IME_REQUEST                  	=  0x00000288,
		# endregion

		# region WM_IME_SELECT
		/// <summary>
		/// Sent to an application when the operating system is about to change the current IME. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>
		/// Selection indicator. This parameter specifies TRUE if the indicated IME is selected. 
		/// The parameter is set to FALSE if the specified IME is no longer selected.
		/// </WPARAM>
		/// <LPARAM>Input locale identifier associated with the IME.</LPARAM>
		/// <LRESULT unused="true">This message has no return value.</LRESULT>
		/// 
		/// <remarks>
		/// An application that has created an IME window should pass this message to that window so that it can retrieve the keyboard layout handle to the newly selected IME.
		/// <br/>
		/// <para>
		/// The DefWindowProc function processes this message by passing the information to the default IME window.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_SELECT                   	=  0x00000285,
		# endregion

		# region WM_IME_SETCONTEXT
		/// <summary>
		/// Sent to an application when a window is activated. A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM>TRUE if the window is active, and FALSE otherwise.</WPARAM>
		/// <LPARAM>Display options. This parameter can have one or more of the ISC_Constants values.</LPARAM>
		/// <LRESULT>Returns the value returned by DefWindowProc or ImmIsUIMessage.</LRESULT>
		/// 
		/// <remarks>
		/// If the application has created an IME window, it should call ImmIsUIMessage. Otherwise, it should pass this message to DefWindowProc.
		/// <br/>
		/// <para>
		/// If the application draws the composition window, the default IME window does not have to show its composition window. 
		/// In this case, the application must clear the ISC_SHOWUICOMPOSITIONWINDOW value from the lParam parameter before passing the message to DefWindowProc 
		/// or ImmIsUIMessage. To display a certain user interface window, an application should remove the corresponding value so that the IME will not display it.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_IME_SETCONTEXT               	=  0x00000281,
		# endregion

		# region WM_IME_STARTCOMPOSITION
		/// <summary>
		/// Sent immediately before the IME generates the composition string as a result of a keystroke. 
		/// A window receives this message through its WindowProc function.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT unused="true">This message has no return value.</LRESULT>
		/// 
		/// <remarks>
		/// This message is a notification to an IME window to open its composition window. 
		/// An application should process this message if it displays composition characters itself.
		/// <br/>
		/// <para>
		/// If an application has created an IME window, it should pass this message to that window. The DefWindowProc function processes the message by 
		/// passing it to the default IME window.
 		/// </para>
		/// </remarks>
		WM_IME_STARTCOMPOSITION         	=  0x0000010D,
		# endregion

		# region WM_INITDIALOG
		/// <summary>
		/// Sent to the dialog box procedure immediately before a dialog box is displayed. Dialog box procedures typically use this message to initialize controls 
		/// and carry out any other initialization tasks that affect the appearance of the dialog box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the control to receive the default keyboard focus. The system assigns the default keyboard focus only if the dialog box procedure returns TRUE. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Additional initialization data. This data is passed to the system as the lParam parameter in a call to the CreateDialogIndirectParam, CreateDialogParam, 
		/// DialogBoxIndirectParam, or DialogBoxParam function used to create the dialog box. 
		/// For property sheets, this parameter is a pointer to the PROPSHEETPAGE structure used to create the page. 
		/// This parameter is zero if any other dialog box creation function is used. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The dialog box procedure should return TRUE to direct the system to set the keyboard focus to the control specified by wParam. 
		/// Otherwise, it should return FALSE to prevent the system from setting the default keyboard focus. 
		/// <br/>
		/// <para>
		/// The dialog box procedure should return the value directly. The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The control to receive the default keyboard focus is always the first control in the dialog box that is visible, not disabled, and that has the WS_TABSTOP style. 
		/// When the dialog box procedure returns TRUE, the system checks the control to ensure that the procedure has not disabled it. 
		/// If it has been disabled, the system sets the keyboard focus to the next control that is visible, not disabled, and has the WS_TABSTOP. 
		/// <br/>
		/// <para>
		/// An application can return FALSE only if it has set the keyboard focus to one of the controls of the dialog box. 
		/// </para>
		/// </remarks>
		WM_INITDIALOG                   	=  0x00000110,
		# endregion
			
		# region WM_INITMENU
		/// <summary>
		/// Sent when a menu is about to become active. It occurs when the user clicks an item on the menu bar or presses a menu key. 
		/// This allows the application to modify the menu before it is displayed. 
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the menu to be initialized. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// A WM_INITMENU message is sent only when a menu is first accessed; only one WM_INITMENU message is generated for each access. 
		/// For example, moving the mouse across several menu items while holding down the button does not generate new messages. 
		/// WM_INITMENU does not provide information about menu items. 
		/// </remarks>
		WM_INITMENU                     	=  0x00000116,
		# endregion

		# region WM_INITMENUPOPUP
		/// <summary>
		/// Sent when a drop-down menu or submenu is about to become active. 
		/// This allows an application to modify the menu before it is displayed, without changing the entire menu. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the drop-down menu or submenu. </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the zero-based relative position of the menu item that opens the drop-down menu or submenu. 
		/// <br/>
		/// <para>
		/// The high-order word indicates whether the drop-down menu is the window menu. If the menu is the window menu, this parameter is TRUE; otherwise, it is FALSE. 
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_INITMENUPOPUP                	=  0x00000117,
		# endregion

		# region WM_INPUT
		/// <summary>
		/// Sent to the window that is getting raw input. 
		/// <br/>
		/// <para>
		/// window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>The input code. This parameter can be one of the RIM_CONSTANTS values.</WPARAM>
		/// 
		/// <LPARAM>
		/// A handle to the RAWINPUT structure that contains the raw input from the device. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// To get the wParam value, use the GET_RAWINPUT_CODE_WPARAM macro.
		/// <br/>
		/// <para>
		/// Note that lParam has the handle to the RAWINPUT structure, not a pointer to it. To get the raw data, use the handle in the call to GetRawInputData.
		/// </para>
		/// <br/>
		/// <para>
		/// Raw input is available only when the application calls RegisterRawInputDevices with valid device specifications.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_INPUT                        	=  0x000000FF,
		# endregion

		# region WM_INPUT_DEVICE_CHANGE
		/// <summary>
		/// Sent to the window that registered to receive raw input. 
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>This parameter can be one of the GIDC_Constants values.</WPARAM>
		/// <LPARAM>The handle to the raw input device. Call GetRawInputDeviceInfo to get more information regarding the device.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_INPUT_DEVICE_CHANGE          	=  0x000000FE,
		# endregion

		# region WM_INPUTLANGCHANGE
		/// <summary>
		/// Sent to the topmost affected window after an application's input language has been changed. 
		/// You should make any application-specific settings and pass the message to the DefWindowProc function, which passes the message to all first-level child windows. 
		/// These child windows can pass the message to DefWindowProc to have it pass the message to their child windows, and so on.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>The character set of the new locale.</WPARAM>
		/// <LPARAM>The input locale identifier. </LPARAM>
		/// <LRESULT>An application should return nonzero if it processes this message.</LRESULT>
		WM_INPUTLANGCHANGE              	=  0x00000051,
		# endregion

		# region WM_INPUTLANGCHANGEREQUEST
		/// <summary>
		/// Posted to the window with the focus when the user chooses a new input language, either with the hotkey (specified in the Keyboard control panel application) 
		/// or from the indicator on the system taskbar. An application can accept the change by passing the message to the DefWindowProc function or reject the change 
		/// (and prevent it from taking place) by returning immediately.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>The new input locale. This parameter can be a combination of the INPUTLANGCHANGE_Constants values.</WPARAM>
		/// <LPARAM>The input locale identifier.</LPARAM>
		/// 
		/// <LRESULT>
		/// This message is posted, not sent, to the application, so the return value is ignored. To accept the change, the application should pass the message 
		/// to DefWindowProc. To reject the change, the application should return zero without calling DefWindowProc.
 		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the DefWindowProc function receives the WM_INPUTLANGCHANGEREQUEST message, it activates the new input locale and notifies the application of 
		/// the change by sending the WM_INPUTLANGCHANGE message.
		/// <br/>
		/// <para>
		/// The language indicator is present on the taskbar only if you have installed more than one keyboard layout and if you have enabled the indicator 
		/// using the Keyboard control panel application.
 		/// </para>
		/// </remarks>
		WM_INPUTLANGCHANGEREQUEST       	=  0x00000050,
		# endregion

		# region WM_KEYDOWN
		/// <summary>
		/// Posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed. 
		/// </summary>
		/// 
		/// <WPARAM>The virtual-key code of the nonsystem key.</WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// If the F10 key is pressed, the DefWindowProc function sets an internal flag. When DefWindowProc receives the WM_KEYUP message, 
		/// the function checks whether the internal flag is set and, if so, sends a WM_SYSCOMMAND message to the top-level window. 
		/// The WM_SYSCOMMAND parameter of the message is set to SC_KEYMENU. 
		/// <br/>
		/// <para>
		/// Because of the autorepeat feature, more than one WM_KEYDOWN message may be posted before a WM_KEYUP message is posted. 
		/// The previous key state (bit 30) can be used to determine whether the WM_KEYDOWN message indicates the first down transition or a repeated down transition. 
		/// </para>
		/// <br/>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and ENTER keys 
		/// in the numeric keypad. Other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// <br/>
		/// <para>
		/// Applications must pass wParam to TranslateMessage without altering it at all.
		/// </para>
		/// </remarks>
		WM_KEYDOWN                      	=  0x00000100,
		# endregion

		# region WM_KEYUP
		/// <summary>
		/// Posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed, 
		/// or a keyboard key that is pressed when a window has the keyboard focus. 
		/// </summary>
		/// 
		/// <WPARAM>The virtual-key code of the nonsystem key.</WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function sends a WM_SYSCOMMAND message to the top-level window if the F10 key or the ALT key was released. 
		/// The wParam parameter of the message is set to SC_KEYMENU. 
		/// <br/>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and ENTER keys 
		/// in the numeric keypad. Other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// <br/>
		/// <para>
		/// Applications must pass wParam to TranslateMessage without altering it at all.
		/// </para>
		/// </remarks>
		WM_KEYUP                        	=  0x00000101,
		# endregion

		# region WM_KILLFOCUS
		/// <summary>
		/// Sent to a window immediately before it loses the keyboard focus. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the window that receives the keyboard focus. This parameter can be NULL. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// If an application is displaying a caret, the caret should be destroyed at this point. 
		/// <br/>
		/// <para>
		/// While processing this message, do not make any function calls that display or activate a window. 
		/// This causes the thread to yield control and can cause the application to stop responding to messages.
		/// </para>
		/// </remarks>
		WM_KILLFOCUS            		=  0x00000008,
		# endregion

		# region WM_LBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the left mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_LBUTTONDOWN                  	=  0x00000201,
		# endregion

		# region WM_LBUTTONUP
		/// <summary>
		/// Posted when the user releases the left mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_LBUTTONUP                    	=  0x00000202,
		# endregion

		# region WM_LBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_LBUTTONDBLCLK                	=  0x00000203,
		# endregion

		# region WM_MBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the middle mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_MBUTTONDOWN                  	=  0x00000207,
		# endregion

		# region WM_MBUTTONUP
		/// <summary>
		/// Posted when the user releases the middle mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_MBUTTONUP                    	=  0x00000208,
		# endregion

		# region WM_MBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_MBUTTONDBLCLK                	=  0x00000209,
		# endregion

		# region WM_MDIACTIVATE
		/// <summary>
		/// An application sends the WM_MDIACTIVATE message to a multiple-document interface (MDI) client window to instruct the client window 
		/// to activate a different MDI child window. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the MDI child window to be activated.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>
		/// If an application sends this message to an MDI client window, the return value is zero. 
		/// <br/>
		/// <para>
		/// An MDI child window should return zero if it processes this message. 
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// As the client window processes this message, it sends WM_MDIACTIVATE to the child window being deactivated and to the child window being activated. 
		/// The message parameters received by an MDI child window are as follows : 
		/// <br/>
		/// <para>
		/// wParam - A handle to the MDI child window being deactivated. 
		/// </para>
		/// <para>
		/// lParam - A handle to the MDI child window being activated. 
		/// </para>
		/// <br/>
		/// <para>
		/// An MDI child window is activated independently of the MDI frame window. When the frame window becomes active, the child window last activated by using 
		/// the WM_MDIACTIVATE message receives the WM_NCACTIVATE message to draw an active window frame and title bar; the child window does not receive 
		/// another WM_MDIACTIVATE message. 
		/// </para>
		/// </remarks>
		WM_MDIACTIVATE                  	=  0x00000222,
		# endregion

		# region WM_MDICASCADE
		/// <summary>
		/// An application sends the WM_MDICASCADE message to a multiple-document interface (MDI) client window to arrange all its child windows in a cascade format. 
		/// </summary>
		/// 
		/// <WPARAM>The cascade behavior. This parameter can be one or more of the MDITILE_Constants values.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is TRUE.
		/// <para>
		/// If the message fails, the return value is FALSE. 
		/// </para>
		/// </LRESULT>
		WM_MDICASCADE                   	=  0x00000227,
		# endregion

		# region WM_MDICREATE
		/// <summary>
		/// An application sends the WM_MDICREATE message to a multiple-document interface (MDI) client window to create an MDI child window. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used. </WPARAM>
		/// <LPARAM>A pointer to an MDICREATESTRUCT structure containing information that the system uses to create the MDI child window. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is the handle to the new child window.
		/// <para>
		/// If the message fails, the return value is NULL. 
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The MDI child window is created with the window style bits WS_CHILD, WS_CLIPSIBLINGS, WS_CLIPCHILDREN, WS_SYSMENU, WS_CAPTION, WS_THICKFRAME, WS_MINIMIZEBOX, 
		/// and WS_MAXIMIZEBOX, plus additional style bits specified in the MDICREATESTRUCT structure. 
		/// The system adds the title of the new child window to the window menu of the frame window. 
		/// An application should use this message to create all child windows of the client window. 
		/// <br/>
		/// <para>
		/// If an MDI client window receives any message that changes the activation of its child windows while the active child window is maximized, 
		/// the system restores the active child window and maximizes the newly activated child window. 
		/// </para>
		/// <br/>
		/// <para>
		/// When an MDI child window is created, the system sends the WM_CREATE message to the window. 
		/// The lParam parameter of the WM_CREATE message contains a pointer to a CREATESTRUCT structure. 
		/// The lpCreateParams member of this structure contains a pointer to the MDICREATESTRUCT structure passed with the WM_MDICREATE message that created 
		/// the MDI child window. 
		/// </para>
		/// <br/>
		/// <para>
		/// An application should not send a second WM_MDICREATE message while a WM_MDICREATE message is still being processed. 
		/// For example, it should not send a WM_MDICREATE message while an MDI child window is processing its WM_MDICREATE message. 
		/// </para>
		/// </remarks>
		WM_MDICREATE                    	=  0x00000220,
		# endregion

		# region WM_MDIDESTROY
		/// <summary>
		/// An application sends the WM_MDIDESTROY message to a multiple-document interface (MDI) client window to close an MDI child window. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the MDI child window to be closed.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>This message always returns zero. </LRESULT>
		/// 
		/// <remarks>
		/// This message removes the title of the MDI child window from the MDI frame window and deactivates the child window. 
		/// An application should use this message to close all MDI child windows. 
		/// <br/>
		/// <para>
		/// If an MDI client window receives a message that changes the activation of its child windows and the active MDI child window is maximized, 
		/// the system restores the active child window and maximizes the newly activated child window. 
		/// </para>
		/// </remarks>
		WM_MDIDESTROY                   	=  0x00000221,
		# endregion

		# region WM_MDIGETACTIVE
		/// <summary>
		/// An application sends the WM_MDIGETACTIVE message to a multiple-document interface (MDI) client window to retrieve the handle to the active MDI child window. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used. </WPARAM>
		/// <LPARAM>
		/// The maximized state. If this parameter is not NULL, it is a pointer to a value that indicates the maximized state of the MDI child window. 
		/// If the value is TRUE, the window is maximized; a value of FALSE indicates that it is not. If this parameter is NULL, the parameter is ignored. 
		/// </LPARAM>
		/// <LRESULT>The return value is the handle to the active MDI child window.</LRESULT>
		WM_MDIGETACTIVE                 	=  0x00000229,
		# endregion

		# region WM_MDIICONARRANGE
		/// <summary>
		/// An application sends the WM_MDIICONARRANGE message to a multiple-document interface (MDI) client window to arrange all minimized MDI child windows. 
		/// It does not affect child windows that are not minimized. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used; it must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used; it must be zero.</LPARAM>
		/// <LRESULT>This message has no return value.</LRESULT>
		WM_MDIICONARRANGE               	=  0x00000228,
		# endregion

		# region WM_MDIMAXIMIZE
		/// <summary>
		/// An application sends the WM_MDIMAXIMIZE message to a multiple-document interface (MDI) client window to maximize an MDI child window. 
		/// The system resizes the child window to make its client area fill the client window. 
		/// The system places the child window's window menu icon in the rightmost position of the frame window's menu bar, and places the child window's restore icon 
		/// in the leftmost position. The system also appends the title bar text of the child window to that of the frame window. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the MDI child window to be maximized. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// <LRESULT>The return value is always zero. </LRESULT>
		/// 
		/// <remarks>
		/// If an MDI client window receives any message that changes the activation of its child windows while the currently active MDI child window is maximized, 
		/// the system restores the active child window and maximizes the newly activated child window. 
		/// </remarks>
		WM_MDIMAXIMIZE                  	=  0x00000225,
		# endregion

		# region WM_MDINEXT
		/// <summary>
		/// An application sends the WM_MDINEXT message to a multiple-document interface (MDI) client window to activate the next or previous child window. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the MDI child window. The system activates the child window that is immediately before or after the specified child window, 
		/// depending on the value of the lParam parameter. If the wParam parameter is NULL, the system activates the child window that is immediately 
		/// before or after the currently active child window. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// If this parameter is zero, the system activates the next MDI child window and places the child window identified by the wParam parameter 
		/// behind all other child windows. If this parameter is nonzero, the system activates the previous child window, placing it in front of 
		/// the child window identified by wParam. 
		/// </LPARAM>
		/// 
		/// <LRESULT>The return value is always zero. </LRESULT>
		/// 
		/// <remarks>
		/// If an MDI client window receives any message that changes the activation of its child windows while the active MDI child window is maximized, 
		/// the system restores the active child window and maximizes the newly activated child window. 
		/// </remarks>
		WM_MDINEXT                      	=  0x00000224,
		# endregion

		# region WM_MDIREFRESHMENU
		/// <summary>
		/// An application sends the WM_MDIREFRESHMENU message to a multiple-document interface (MDI) client window to refresh the window menu of the MDI frame window. 
		/// </summary>
		/// 
		/// <>PARAM>This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM>This parameter is not used and must be zero.</LPARAM>
		/// <LRESULT>
		/// If the message succeeds, the return value is the handle to the frame window menu.
		/// <para>
		/// If the message fails, the return value is NULL. 
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// After sending this message, an application must call the DrawMenuBar function to update the menu bar. 
		/// </remarks>
		WM_MDIREFRESHMENU               	=  0x00000234,
		# endregion

		# region WM_MDIRESTORE
		/// <summary>
		/// An application sends the WM_MDIRESTORE message to a multiple-document interface (MDI) client window to restore an MDI child window 
		/// from maximized or minimized size. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the MDI child window to be restored.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		WM_MDIRESTORE                   	=  0x00000223,
		# endregion

		# region WM_MDISETMENU
		/// <summary>
		/// An application sends the WM_MDISETMENU message to a multiple-document interface (MDI) client window to replace the entire menu of an MDI frame window, 
		/// to replace the window menu of the frame window, or both. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the new frame window menu. If this parameter is NULL, the frame window menu is not changed. </WPARAM>
		/// <LPARAM>A handle to the new window menu. If this parameter is NULL, the window menu is not changed. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is the handle to the old frame window menu.
		/// <para>
		/// If the message fails, the return value is zero. 
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// After sending this message, an application must call the DrawMenuBar function to update the menu bar. 
		/// <br/>
		/// <para>
		/// If this message replaces the window menu, the MDI child window menu items are removed from the previous window menu and added to the new window menu. 
		/// </para>
		/// <br/>
		/// <para>
		/// If an MDI child window is maximized and this message replaces the MDI frame window menu, the window menu icon and restore icon are removed from 
		/// the previous frame window menu and added to the new frame window menu. 
		/// </para>
		/// </remarks>
		WM_MDISETMENU                   	=  0x00000230,
		# endregion

		# region WM_MDITILE
		/// <summary>
		/// An application sends the WM_MDITILE message to a multiple-document interface (MDI) client window to arrange all of its MDI child windows in a tile format. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The tiling option. This parameter can be one of the MDITILE_HORIZONTALLY and MDITILE_VERTICALLY values, optionally combined with MDITILE_SKIPDISABLED 
		/// to prevent disabled MDI child windows from being tiled. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is TRUE.
		/// <para>
		/// If the message fails, the return value is FALSE. 
		/// </para>
		/// </LRESULT>
		WM_MDITILE                      	=  0x00000226,
		# endregion

		# region WM_MEASUREITEM
		/// <summary>
		/// Sent to the owner window of a combo box, list box, list-view control, or menu item when the control or menu is created.
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Contains the value of the CtlID member of the MEASUREITEMSTRUCT structure pointed to by the lParam parameter. 
		/// This value identifies the control that sent the WM_MEASUREITEM message. If the value is zero, the message was sent by a menu. 
		/// If the value is nonzero, the message was sent by a combo box or by a list box. If the value is nonzero, 
		/// and the value of the itemID member of the MEASUREITEMSTRUCT pointed to by lParam is (UINT) –1, 
		/// the message was sent by a combo edit field. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="MEASUREITEMSTRUCT">
		/// Pointer to a MEASUREITEMSTRUCT structure that contains the dimensions of the owner-drawn control or menu item. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return TRUE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the owner window receives the WM_MEASUREITEM message, the owner fills in the MEASUREITEMSTRUCT structure pointed to 
		/// by the lParam parameter of the message and returns; this informs the system of the dimensions of the control. 
		/// If a list box or combo box is created with the LBS_OWNERDRAWVARIABLE or CBS_OWNERDRAWVARIABLE style, 
		/// this message is sent to the owner for each item in the control; otherwise, this message is sent once. 
		/// <br/>
		/// <para>
		/// The system sends the WM_MEASUREITEM message to the owner window of combo boxes and list boxes created with the OWNERDRAWFIXED style 
		/// before sending the WM_INITDIALOG message. As a result, when the owner receives this message, the system has not yet determined 
		/// the height and width of the font used in the control; function calls and calculations requiring these values should occur 
		/// in the main function of the application or library. 
		/// </para>
		/// </remarks>
		WM_MEASUREITEM          		=  0x0000002C,
		# endregion

		# region WM_MENUCHAR
		/// <summary>
		/// Sent when a menu is active and the user presses a key that does not correspond to any mnemonic or accelerator key. 
		/// This message is sent to the window that owns the menu. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The low-order word specifies the character code that corresponds to the key the user pressed.
		/// <para>
		/// The high-order word specifies the active menu type ; either MF_Constants.MF_POPUP or MF_SYSMENU.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A handle to the active menu. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application that processes this message should return one of the MNC_Constants values.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The low-order word is ignored if the high-order word contains 0 or 1. 
		/// <para>
		/// An application should process this message when an accelerator is used to select a menu item that displays a bitmap. 
		/// </para>
		/// </remarks>
		WM_MENUCHAR                     	=  0x00000120,
		# endregion

		# region WM_MENUCOMMAND
		/// <summary>
		/// Sent when the user makes a selection from a menu. 
		/// </summary>
		/// 
		/// <WPARAM>The zero-based index of the item selected. </WPARAM>
		/// <LPARAM>A handle to the menu for the item selected. </LPARAM>
		/// 
		/// <remarks>
		/// The WM_MENUCOMMAND message gives you a handle to the menu—so you can access the menu data in the MENUINFO structure—
		/// and also gives you the index of the selected item, which is typically what applications need. 
		/// In contrast, the WM_COMMAND message gives you the menu item identifier.
		/// <br/>
		/// <para>
		/// The WM_MENUCOMMAND message is sent only for menus that are defined with the MNS_NOTIFYBYPOS flag set 
		/// in the dwStyle member of the MENUINFO structure. 
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_MENUCOMMAND				=  0x00000126,
		# endregion

		# region WM_MENUDRAG
		/// <summary>
		/// Sent to the owner of a drag-and-drop menu when the user drags a menu item. 
		/// </summary>
		/// 
		/// <WPARAM>The position of the item where the drag operation began. </WPARAM>
		/// <LPARAM>A handle to the menu containing the item. </LPARAM>
		/// 
		/// <LRESULT>The application should return one of the MND_Constants values.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The application can call the DoDragDrop function in response to this message.
		/// <para>
		/// To create a drag-and-drop menu, call SetMenuInfo with MNS_DRAGDROP. 
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_MENUDRAG                     	=  0x00000123, 
		# endregion

		# region WM_MENUGETOBJECT
		/// <summary>
		/// Sent to the owner of a drag-and-drop menu when the mouse cursor enters a menu item or moves from the center of the item 
		/// to the top or bottom of the item. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM>A pointer to a MENUGETOBJECTINFO structure.</LPARAM>
		/// <LRESULT>The application should return one of the MNGO_COnstants values.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_MENUGETOBJECT                	=  0x00000124,
		# endregion

		# region WM_MENURBUTTONUP
		/// <summary>
		/// Sent when the user releases the right mouse button while the cursor is on a menu item. 
		/// </summary>
		/// 
		/// <WPARAM>The zero-based index of the menu item on which the right mouse button was released. </WPARAM>
		/// <LPARAM>A handle to the menu containing the item. </LPARAM>
		/// 
		/// <remarks>
		/// The WM_MENURBUTTONUP message allows applications to provide a context-sensitive menu—also known as a shortcut menu—for the menu item 
		/// specified in this message. To display a context-sensitive menu for a menu item, call the TrackPopupMenuEx function with TPM_RECURSE. 
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_MENURBUTTONUP                	=  0x00000122,
		# endregion

		# region WM_MENUSELECT
		/// <summary>
		/// Sent to a menu's owner window when the user selects a menu item. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The low-order word specifies the menu item or submenu index. If the selected item is a command item, this parameter contains 
		/// the identifier of the menu item. If the selected item opens a drop-down menu or submenu, this parameter contains the index 
		/// of the drop-down menu or submenu in the main menu, and the lParam parameter contains the handle to the main (clicked) menu; 
		/// use the GetSubMenu function to get the menu handle to the drop-down menu or submenu. 
		/// <br/>
		/// <para>
		/// The high-order word specifies one or more menu flags. This parameter can be one or more of the MF_Constants values.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>A handle to the menu that was clicked. </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// If the high-order word of wParam contains 0xFFFF and the lParam parameter contains NULL, the system has closed the menu. 
		/// <br/>
		/// <para>
		/// Do not use the value –1 for the high-order word of wParam, because this value is specified as (UINT) HIWORD(wParam). 
		/// If the value is 0xFFFF, it would be interpreted as 0x0000FFFF, not –1, because of the cast to a UINT. 
		/// </para>
		/// </remarks>
		WM_MENUSELECT                   	=  0x0000011F,
		# endregion

		# region WM_MOUSEACTIVATE
		/// <summary>
		/// Sent when the cursor is in an inactive window and the user presses a mouse button. 
		/// The parent window receives this message only if the child window passes it to the DefWindowProc function.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the top-level parent window of the window being activated. </WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// <br/>
		/// <para>
		/// The high-order word specifies the identifier of the mouse message generated when the user pressed a mouse button. 
		/// The mouse message is either discarded or posted to the window, depending on the return value.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value specifies whether the window should be activated and whether the identifier of the mouse message should be discarded. 
		/// It must be one of the MA_Constants values.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function passes the message to a child window's parent window before any processing occurs. 
		/// The parent window determines whether to activate the child window. If it activates the child window, 
		/// the parent window should return MA_NOACTIVATE or MA_NOACTIVATEANDEAT to prevent the system from processing the message further. 
		/// </remarks>
		WM_MOUSEACTIVATE        		=  0x00000021,
		# endregion

		# region WM_MOUSEHOVER
		/// <summary>
		/// Posted to a window when the cursor hovers over the client area of the window for the period of time specified in a prior call to 
		/// TrackMouseEvent.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The high-order word specifies the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// Hover tracking stops when WM_MOUSEHOVER is generated. The application must call TrackMouseEvent again if it requires further tracking 
		/// of mouse hover behavior.
		/// <br/>
		/// <para>
		/// Important : Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because these macros 
		/// return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- coordinates, 
		/// and LOWORD and HIWORD treat the coordinates as unsigned quantities.		
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Default )]
		WM_MOUSEHOVER                   	=  0x000002A1,
		# endregion

		# region WM_MOUSEHWHEEL
		/// <summary>
		/// Sent to the active window when the mouse's horizontal scroll wheel is tilted or rotated. 
		/// The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, 
		/// since DefWindowProc propagates it up the parent chain until it finds a window that processes it.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The high-order word indicates the distance the wheel is rotated, expressed in multiples or factors of WHEEL_DELTA, which is set to 120. 
		/// A positive value indicates that the wheel was rotated to the right; a negative value indicates that the wheel was rotated to the left.
		/// <br/>
		/// <para>
		/// The low-order word indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the pointer, relative to the upper-left corner of the screen. 
		/// <para>
		/// The high-order word specifies the y-coordinate of the pointer, relative to the upper-left corner of the screen.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Use the following code to obtain the information in the wParam parameter :
		/// <br/>
		/// <code>
		/// <para>
		/// fwKeys = GET_KEYSTATE_WPARAM(wParam);
		/// </para>
		/// <para>
		/// zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
		/// </para>
		/// </code>
		/// <br/>
		/// <para>
		/// Use the following code to obtain the horizontal and vertical position :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>
		/// xPos = GET_X_LPARAM(lParam); 
		/// </para>
		/// <para>
		/// yPos = GET_Y_LPARAM(lParam);
		/// </para>
		/// </code>
		/// <br/>
		/// <para>
		/// As noted above, the x-coordinate is in the low-order short of the return value; the y-coordinate is in the high-order short 
		/// (both represent signed values because they can take negative values on systems with multiple monitors). 
		/// If the return value is assigned to a variable, you can use the MAKEPOINTS macro to obtain a POINTS structure from the return value. 
		/// You can also use the GET_X_LPARAM or GET_Y_LPARAM macro to extract the x- or y-coordinate. 
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- 
		/// coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// The wheel rotation is a multiple of WHEEL_DELTA, which is set to 120. This is the threshold for action to be taken, 
		/// and one such action (for example, scrolling one increment) should occur for each delta.
		/// </para>
		/// <br/>
		/// <para>
		/// The delta was set to 120 to allow Microsoft or other vendors to build finer-resolution wheels 
		/// (for example, a freely-rotating wheel with no notches) to send more messages per rotation, but with a smaller value in each message. 
		/// To use this feature, you can either add the incoming delta values until WHEEL_DELTA is reached 
		/// (so for a delta-rotation you get the same response), or scroll partial lines in response to more frequent messages. 
		/// You can also choose your scroll granularity and accumulate deltas until it is reached.
 		/// </para>
		/// </remarks>
		WM_MOUSEHWHEEL                  	=  0x0000020E,
		# endregion

		# region WM_MOUSELEAVE
		/// <summary>
		/// Posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero.</LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// All tracking requested by TrackMouseEvent is canceled when this message is generated. 
		/// The application must call TrackMouseEvent when the mouse reenters its window if it requires further tracking of mouse hover behavior.
		/// </remarks>
		WM_MOUSELEAVE                   	=  0x000002A3,
		# endregion

		# region WM_MOUSEMOVE
		/// <summary>
		/// Posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window that contains the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The high-order word specifies the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area.
		/// </para>
		/// </LPARAM>
		/// 
		/// <remarks>
		/// Use the following code to obtain the horizontal and vertical position:
		/// <br/>
		/// <code>
		/// <para>
		/// xPos = GET_X_LPARAM(lParam);
		/// </para>
		/// <para>
		/// yPos = GET_Y_LPARAM(lParam);
		/// </para>
		/// </code>
		/// <br/>
		/// <para>
		/// As noted above, the x-coordinate is in the low-order short of the return value; the y-coordinate is in the high-order short 
		/// (both represent signed values because they can take negative values on systems with multiple monitors). 
		/// If the return value is assigned to a variable, you can use the MAKEPOINTS macro to obtain a POINTS structure from the return value. 
		/// You can also use the GET_X_LPARAM or GET_Y_LPARAM macro to extract the x- or y-coordinate. 
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because these macros 
		/// return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- coordinates, 
		/// and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Default )]
		WM_MOUSEMOVE                    	=  0x00000200,
		# endregion

		#  region WM_MOUSEWHEEL
		/// <summary>
		/// Sent to the active window when the mouse's scroll wheel is tilted or rotated. 
		/// The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, 
		/// since DefWindowProc propagates it up the parent chain until it finds a window that processes it.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The high-order word indicates the distance the wheel is rotated, expressed in multiples or factors of WHEEL_DELTA, which is set to 120. 
		/// A positive value indicates that the wheel was rotated to the right; a negative value indicates that the wheel was rotated to the left.
		/// <br/>
		/// <para>
		/// The low-order word indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the pointer, relative to the upper-left corner of the screen. 
		/// <para>
		/// The high-order word specifies the y-coordinate of the pointer, relative to the upper-left corner of the screen.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Use the following code to obtain the information in the wParam parameter :
		/// <br/>
		/// <code>
		/// <para>
		/// fwKeys = GET_KEYSTATE_WPARAM(wParam);
		/// </para>
		/// <para>
		/// zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
		/// </para>
		/// </code>
		/// <br/>
		/// <para>
		/// Use the following code to obtain the horizontal and vertical position :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>
		/// xPos = GET_X_LPARAM(lParam); 
		/// </para>
		/// <para>
		/// yPos = GET_Y_LPARAM(lParam);
		/// </para>
		/// </code>
		/// <br/>
		/// <para>
		/// As noted above, the x-coordinate is in the low-order short of the return value; the y-coordinate is in the high-order short 
		/// (both represent signed values because they can take negative values on systems with multiple monitors). 
		/// If the return value is assigned to a variable, you can use the MAKEPOINTS macro to obtain a POINTS structure from the return value. 
		/// You can also use the GET_X_LPARAM or GET_Y_LPARAM macro to extract the x- or y-coordinate. 
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- 
		/// coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// The wheel rotation is a multiple of WHEEL_DELTA, which is set to 120. This is the threshold for action to be taken, 
		/// and one such action (for example, scrolling one increment) should occur for each delta.
		/// </para>
		/// <br/>
		/// <para>
		/// The delta was set to 120 to allow Microsoft or other vendors to build finer-resolution wheels 
		/// (for example, a freely-rotating wheel with no notches) to send more messages per rotation, but with a smaller value in each message. 
		/// To use this feature, you can either add the incoming delta values until WHEEL_DELTA is reached 
		/// (so for a delta-rotation you get the same response), or scroll partial lines in response to more frequent messages. 
		/// You can also choose your scroll granularity and accumulate deltas until it is reached.
 		/// </para>
		/// <br/>
		/// <para>
		/// Note, there is no fwKeys for MSH_MOUSEWHEEL. Otherwise, the parameters are exactly the same as for WM_MOUSEWHEEL.
		/// </para>
		/// <br/>
		/// <para>
		/// It is up to the application to forward MSH_MOUSEWHEEL to any embedded objects or controls. 
		/// The application is required to send the message to an active embedded OLE application. It is optional that the application sends it 
		/// to a wheel-enabled control with focus. If the application does send the message to a control, it can check the return value to see 
		/// if the message was processed. Controls are required to return a value of TRUE if they process the message. 
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Default )]
		WM_MOUSEWHEEL                   	=  0x0000020A,
		# endregion

		# region WM_MOVE
		/// <summary>
		/// Sent after a window has been moved.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM>
		/// The x and y coordinates of the upper-left corner of the client area of the window. 
		/// The low-order word contains the x-coordinate while the high-order word contains the y coordinate. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The parameters are given in screen coordinates for overlapped and pop-up windows and in parent-client coordinates for child windows. 
		/// <br/>
		/// <para>The following example demonstrates how to obtain the position from the lParam parameter :</para>
		/// <code>
		/// <para>xPos = (int)(short) LOWORD(lParam);   // horizontal position </para>
		/// <para>yPos = (int)(short) HIWORD(lParam);   // vertical position</para>
		/// </code>
		/// <br/>
		/// <para>
		/// You can also use the MAKEPOINTS macro to convert the lParam parameter to a POINTS structure. 
		/// </para>
		/// </remarks>
		WM_MOVE					=  0x00000003,
		# endregion

		# region WM_MOVING
		/// <summary>
		/// Sent to a window that the user is moving. By processing this message, an application can monitor the position of the drag rectangle and, 
		/// if needed, change its position.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM>
		/// A pointer to a RECT structure with the current position of the window, in screen coordinates. 
		/// To change the position of the drag rectangle, an application must change the members of this structure. 
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return TRUE if it processes this message.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Default )]
		WM_MOVING                       	=  0x00000216,
		# endregion

		# region WM_NCACTIVATE
		/// <summary>
		/// Sent to a window when its nonclient area needs to be changed to indicate an active or inactive state.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Indicates when a title bar or icon needs to be changed to indicate an active or inactive state. 
		/// <para>
		/// If an active title bar or icon is to be drawn, the wParam parameter is TRUE. 
		/// </para>
		/// <para>
		/// If an inactive title bar or icon is to be drawn, wParam is FALSE. 
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// When a visual style is active for this window, this parameter is not used.
		/// <br/>
		/// <para>
		/// When a visual style is not active for this window, this parameter is a handle to an optional update region for the nonclient area 
		/// of the window. If this parameter is set to -1, DefWindowProc does not repaint the nonclient area to reflect the state change.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// When the wParam parameter is FALSE, an application should return TRUE to indicate that the system should proceed with 
		/// the default processing, or it should return FALSE to prevent the change. When wParam is TRUE, the return value is ignored. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Processing messages related to the nonclient area of a standard window is not recommended, because the application must be able to draw 
		/// all the required parts of the nonclient area for the window. If an application does process this message, it must return TRUE to direct 
		/// the system to complete the change of active window. If the window is minimized when this message is received, the application should pass 
		/// the message to the DefWindowProc function.
		/// <br/>
		/// <para>
		/// The DefWindowProc function draws the title bar or icon title in its active colors when the wParam parameter is TRUE and in 
		/// its inactive colors when wParam is FALSE.
		/// </para>
		/// </remarks>
		WM_NCACTIVATE                   	=  0x00000086,
		# endregion

		# region WM_NCCALCSIZE
		/// <summary>
		/// Sent when the size and position of a window's client area must be calculated. By processing this message, an application 
		/// can control the content of the window's client area when the size or position of the window changes.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// If wParam is TRUE, it specifies that the application should indicate which part of the client area contains valid information. 
		/// The system copies the valid information to the specified area within the new client area. 
		/// <br/>
		/// <para>
		/// If wParam is FALSE, the application does not need to indicate the valid part of the client area.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// If wParam is TRUE, lParam points to an NCCALCSIZE_PARAMS structure that contains information an application can use to calculate 
		/// the new size and position of the client rectangle. 
		/// <br/>
		/// <para>
		/// If wParam is FALSE, lParam points to a RECT structure. On entry, the structure contains the proposed window rectangle for the window. 
		/// On exit, the structure should contain the screen coordinates of the corresponding window client area.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the wParam parameter is FALSE, the application should return zero. 
		/// <para>
		/// If wParam is TRUE and an application returns zero, the old client area is preserved and is aligned with the upper-left corner of 
		/// the new client area.
		/// </para>
		/// <para>
		/// If wParam is TRUE, the application should return zero or a combination of the WVR_Constants values.
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The window may be redrawn, depending on whether the CS_HREDRAW or CS_VREDRAW class style is specified. 
		/// This is the default, backward-compatible processing of this message by the DefWindowProc function (in addition to the usual 
		/// client rectangle calculation described in the preceding table).
		/// <br/>
		/// <para>
		/// When wParam is TRUE, simply returning 0 without processing the NCCALCSIZE_PARAMS rectangles will cause the client area to resize 
		/// to the size of the window, including the window frame. This will remove the window frame and caption items from your window, 
		/// leaving only the client area displayed. 
		/// </para>
		/// <br/>
		/// <para>
		/// Starting with Windows Vista, removing the standard frame by simply returning 0 when the wParam is TRUE does not affect frames 
		/// that are extended into the client area using the DwmExtendFrameIntoClientArea function. Only the standard frame will be removed. 
		/// </para>
		/// </remarks>
		WM_NCCALCSIZE                   	=  0x00000083,
		# endregion

		# region WM_NCCREATE
		/// <summary>
		/// Sent prior to the WM_CREATE message when a window is first created.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the CREATESTRUCT structure that contains information about the window being created. 
		/// The members of CREATESTRUCT are identical to the parameters of the CreateWindowEx function. 
		/// </LPARAM>
		/// 
		/// <LRESUL>
		/// If an application processes this message, it should return TRUE to continue creation of the window. 
		/// If the application returns FALSE, the CreateWindow or CreateWindowEx function will return a NULL handle. 
		/// </LRESUL>
		WM_NCCREATE                     	=  0x00000081,
		# endregion

		# region WM_NCDESTROY
		/// <summary>
		/// Notifies a window that its nonclient area is being destroyed. The DestroyWindow function sends the WM_NCDESTROY message to 
		/// the window following the WM_DESTROY message.WM_DESTROY is used to free the allocated memory object associated with the window.
		/// <br/>
		/// <para>
		/// The WM_NCDESTROY message is sent after the child windows have been destroyed. In contrast, WM_DESTROY is sent before 
		/// the child windows are destroyed.
		/// </para>
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// <remarks>This message frees any memory internally allocated for the window.</remarks>
		WM_NCDESTROY                    	=  0x00000082,
		# endregion

		# region WM_NCHITTEST
		/// <summary>
		/// Sent to a window in order to determine what part of the window corresponds to a particular screen coordinate. 
		/// This can happen, for example, when the cursor moves, when a mouse button is pressed or released, or in response to a call to 
		/// a function such as WindowFromPoint. If the mouse is not captured, the message is sent to the window beneath the cursor. 
		/// Otherwise, the message is sent to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the screen.
		/// <para>
		/// The high-order word specifies the y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the screen.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value of the DefWindowProc function is one of the HT_Constants values, indicating the position of the cursor hot spot. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Use the following code to obtain the horizontal and vertical position: 
		/// <br/>
		/// <para>
		/// <code>
		/// <para>xPos = GET_X_LPARAM(lParam);</para>
		/// <para>yPos = GET_Y_LPARAM(lParam);</para>
		/// </code>
		/// </para>
		/// <br/>
		/// <para>
		/// As noted above, the x-coordinate is in the low-order short of the return value; the y-coordinate is in the high-order short 
		/// (both represent signed values because they can take negative values on systems with multiple monitors). 
		/// If the return value is assigned to a variable, you can use the MAKEPOINTS macro to obtain a POINTS structure from the return value. 
		/// You can also use the GET_X_LPARAM or GET_Y_LPARAM macro to extract the x- or y-coordinate. 
		/// </para>
		/// <br/>
		/// <para>
		/// Important : Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// Windows Vista: When creating custom frames that include the standard caption buttons, this message should first be passed to the 
		/// DwmDefWindowProc function. This enables the Desktop Window Manager (DWM) to provide hit-testing for the captions buttons. 
		/// If DwmDefWindowProc does not handle the message, further processing of WM_NCHITTEST may be needed. 
		/// </para>
		/// </remarks>
		WM_NCHITTEST                    	=  0x00000084,
		# endregion

		# region WM_NCLBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// <remarks>
		/// Use the following code to obtain the horizontal and vertical position: 
		/// <br/>
		/// <para>
		/// <code>
		/// <para>xPos = GET_X_LPARAM(lParam);</para>
		/// <para>yPos = GET_Y_LPARAM(lParam);</para>
		/// </code>
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// By default, the DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action.
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// <br/>
		/// <para>
		/// A window need not have the CS_DBLCLKS style to receive WM_NCLBUTTONDBLCLK messages. 
		/// </para>
		/// <br/>
		/// <para>
		/// The system generates a WM_NCLBUTTONDBLCLK message when the user presses, releases, and again presses the left mouse button 
		/// within the system's double-click time limit. Double-clicking the left mouse button actually generates four messages: 
		/// WM_NCLBUTTONDOWN, WM_NCLBUTTONUP, WM_NCLBUTTONDBLCLK, and WM_NCLBUTTONUP again. 
		/// </para>
		/// </remarks>
		WM_NCLBUTTONDBLCLK              	=  0x000000A3,
		# endregion

		# region WM_NCLBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the left mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because these macros 
		/// return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- coordinates, 
		/// and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// </remarks>
		WM_NCLBUTTONDOWN                	=  0x000000A1,
		# endregion

		# region WM_NCLBUTTONUP
		/// <summary>
		/// Posted when the user releases the left mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. The coordinates are relative to 
		/// the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// If it is appropriate to do so, the system sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// </remarks>
		WM_NCLBUTTONUP                  	=  0x000000A2,
		# endregion

		# region WM_NCMBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the middle mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because these macros 
		/// return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- coordinates, 
		/// and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// </remarks>
		WM_NCMBUTTONDOWN                	=  0x000000A7,
		# endregion

		# region WM_NCMBUTTONUP
		/// <summary>
		/// Posted when the user releases the middle mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. The coordinates are relative to 
		/// the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// If it is appropriate to do so, the system sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// </remarks>
		WM_NCMBUTTONUP                  	=  0x000000A8,
		# endregion

		# region WM_NCLBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// <remarks>
		/// Use the following code to obtain the horizontal and vertical position: 
		/// <br/>
		/// <para>
		/// <code>
		/// <para>xPos = GET_X_LPARAM(lParam);</para>
		/// <para>yPos = GET_Y_LPARAM(lParam);</para>
		/// </code>
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// By default, the DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action.
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// <br/>
		/// <para>
		/// A window need not have the CS_DBLCLKS style to receive WM_NCLBUTTONDBLCLK messages. 
		/// </para>
		/// <br/>
		/// <para>
		/// The system generates a WM_NCLBUTTONDBLCLK message when the user presses, releases, and again presses the left mouse button 
		/// within the system's double-click time limit. Double-clicking the left mouse button actually generates four messages: 
		/// WM_NCLBUTTONDOWN, WM_NCLBUTTONUP, WM_NCLBUTTONDBLCLK, and WM_NCLBUTTONUP again. 
		/// </para>
		/// </remarks>
		WM_NCMBUTTONDBLCLK              	=  0x000000A9,
		# endregion

		# region WM_NCMOUSEHOVER
		/// <summary>
		/// Posted to a window when the cursor hovers over the nonclient area of the window for the period of time specified in a prior call 
		/// to TrackMouseEvent.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// Hover tracking stops when this message is generated. 
		/// The application must call TrackMouseEvent again if it requires further tracking of mouse hover behavior.
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>	
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_NCMOUSEHOVER                 	=  0x000002A0,
		# endregion
			
		# region WM_NCMOUSELEAVE
		/// <summary>
		/// Posted to a window when the cursor leaves the nonclient area of the window specified in a prior call to TrackMouseEvent.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and should be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used and should be zero.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// All tracking requested by TrackMouseEvent is canceled when this message is generated. 
		/// The application must call TrackMouseEvent when the mouse reenters its window if it requires further tracking of mouse hover behavior.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_NCMOUSELEAVE                 	=  0x000002A2,			
		# endregion

		# region WM_NCMOUSEMOVE
		/// <summary>
		/// Posted to a window when the cursor is moved within the nonclient area of the window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// If it is appropriate to do so, the system sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important : Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// </remarks>
		WM_NCMOUSEMOVE                  	=  0x000000A0,
		# endregion

		# region WM_NCPAINT
		/// <summary>
		/// The WM_NCPAINT message is sent to a window when its frame must be painted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>handle to the update region of the window. The update region is clipped to the window frame.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>An application returns zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function paints the window frame.
		/// <br/>
		/// <para>
		/// An application can intercept the WM_NCPAINT message and paint its own custom window frame. 
		/// The clipping region for a window is always rectangular, even if the shape of the frame is altered.
		/// </para>
		/// <br/>
		/// <para>
		/// The wParam value can be passed to GetDCEx as in the following example :
		/// </para>
		/// <code>
		///	hdc = GetDCEx(hwnd, (HRGN)wParam, DCX_WINDOW|DCX_INTERSECTRGN);
		/// </code>
		/// </remarks>
		WM_NCPAINT                      	=  0x00000085,
		# endregion

		# region WM_NCRBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the right mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because these macros 
		/// return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- coordinates, 
		/// and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// </remarks>
		WM_NCRBUTTONDOWN                	=  0x000000A4,
		# endregion

		# region WM_NCRBUTTONUP
		/// <summary>
		/// Posted when the user releases the right mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. The coordinates are relative to 
		/// the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// If it is appropriate to do so, the system sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// </remarks>
		WM_NCRBUTTONUP                  	=  0x000000A5,
		# endregion

		# region WM_NCRBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the right mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// <remarks>
		/// Use the following code to obtain the horizontal and vertical position: 
		/// <br/>
		/// <para>
		/// <code>
		/// <para>xPos = GET_X_LPARAM(lParam);</para>
		/// <para>yPos = GET_Y_LPARAM(lParam);</para>
		/// </code>
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// By default, the DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action.
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// <br/>
		/// <para>
		/// A window need not have the CS_DBLCLKS style to receive WM_NCLBUTTONDBLCLK messages. 
		/// </para>
		/// <br/>
		/// <para>
		/// The system generates a WM_NCLBUTTONDBLCLK message when the user presses, releases, and again presses the left mouse button 
		/// within the system's double-click time limit. Double-clicking the left mouse button actually generates four messages: 
		/// WM_NCLBUTTONDOWN, WM_NCLBUTTONUP, WM_NCLBUTTONDBLCLK, and WM_NCLBUTTONUP again. 
		/// </para>
		/// </remarks>
		WM_NCRBUTTONDBLCLK              	=  0x000000A6,
		# endregion

		# region WM_NCXBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the X mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// <remarks>
		/// Use the following code to obtain the horizontal and vertical position: 
		/// <br/>
		/// <para>
		/// <code>
		/// <para>xPos = GET_X_LPARAM(lParam);</para>
		/// <para>yPos = GET_Y_LPARAM(lParam);</para>
		/// </code>
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// By default, the DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action.
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// <br/>
		/// <para>
		/// A window need not have the CS_DBLCLKS style to receive WM_NCLBUTTONDBLCLK messages. 
		/// </para>
		/// <br/>
		/// <para>
		/// The system generates a WM_NCLBUTTONDBLCLK message when the user presses, releases, and again presses the left mouse button 
		/// within the system's double-click time limit. Double-clicking the left mouse button actually generates four messages: 
		/// WM_NCLBUTTONDOWN, WM_NCLBUTTONUP, WM_NCLBUTTONDBLCLK, and WM_NCLBUTTONUP again. 
		/// </para>
		/// </remarks>
		WM_NCXBUTTONDBLCLK              	=  0x000000AD,
		# endregion

		# region WM_NCXBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the X mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. 
		/// The coordinates are relative to the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because these macros 
		/// return incorrect results on systems with multiple monitors. Systems with multiple monitors can have negative x- and y- coordinates, 
		/// and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// </remarks>
		WM_NCXBUTTONDOWN                	=  0x000000AB,
		# endregion

		# region WM_NCXBUTTONUP
		/// <summary>
		/// Posted when the user releases the X mouse button while the cursor is within the nonclient area of a window. 
		/// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The hit-test value returned by the DefWindowProc function as a result of processing the WM_NCHITTEST message. 
		/// For a list of hit-test values, see WM_NCHITTEST. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A POINTS structure that contains the x- and y-coordinates of the cursor. The coordinates are relative to 
		/// the upper-left corner of the screen. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function tests the specified point to find out the location of the cursor and performs the appropriate action. 
		/// If appropriate, DefWindowProc sends the WM_SYSCOMMAND message to the window. 
		/// <br/>
		/// <para>
		/// You can also use the GET_X_LPARAM and GET_Y_LPARAM macros to extract the values of the x- and y- coordinates from lParam.
		/// </para>
		/// <br/>
		/// <para>
		/// Important  Do not use the LOWORD or HIWORD macros to extract the x- and y- coordinates of the cursor position because 
		/// these macros return incorrect results on systems with multiple monitors. Systems with multiple monitors can have 
		/// negative x- and y- coordinates, and LOWORD and HIWORD treat the coordinates as unsigned quantities.
		/// </para>
		/// <br/>
		/// <para>
		/// If it is appropriate to do so, the system sends the WM_SYSCOMMAND message to the window. 
		/// </para>
		/// </remarks>
		WM_NCXBUTTONUP                  	=  0x000000AC,
		# endregion

		# region WM_NEXTDLGCTL
		/// <summary>
		/// Sent to a dialog box procedure to set the keyboard focus to a different control in the dialog box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// If lParam is TRUE, this parameter identifies the control that receives the focus. 
		/// If lParam is FALSE, this parameter indicates whether the next or previous control with the WS_TABSTOP style receives the focus. 
		/// If wParam is zero, the next control receives the focus; otherwise, the previous control with the WS_TABSTOP style receives the focus.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word indicates how the system uses wParam. If the low-order word is TRUE, wParam is a handle associated with 
		/// the control that receives the focus; otherwise, wParam is a flag that indicates whether the next or previous control with 
		/// the WS_TABSTOP style receives the focus.
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// This message performs additional dialog box management operations beyond those performed by the SetFocus function 
		/// WM_NEXTDLGCTL updates the default pushbutton border, sets the default control identifier, and automatically selects the text 
		/// of an edit control (if the target window is an edit control). 
		/// <br/>
		/// <para>
		/// Do not use the SendMessage function to send a WM_NEXTDLGCTL message if your application will concurrently process other messages 
		/// that set the focus. Use the PostMessage function instead. 
		/// </para>
		/// </remarks>
		WM_NEXTDLGCTL           		=  0x00000028,
		# endregion

		# region WM_NEXTMENU
		/// <summary>
		/// Sent to an application when the right or left arrow key is used to switch between the menu bar and the system menu. 
		/// </summary>
		/// 
		/// <WPARAM>The virtual-key code of the key.</WPARAM>
		/// <LPARAM>A pointer to a MDINEXTMENU structure that contains information about the menu to be activated.</LPARAM>
		/// 
		/// <remarks>
		/// In responding to this message, the application can specify the menu to switch to in the hmenuNext member of MDINEXTMENU 
		/// and the window to receive the menu notification messages in the hwndNext member of the MDINEXTMENU structure. 
		/// You must set both members for the changes to take effect (they are initially NULL). 
		/// </remarks>
		WM_NEXTMENU                     	=  0x00000213,
		# endregion

		# region WM_NOTIFY
		/// <summary>
		/// Sent by a common control to its parent window when an event has occurred or the control requires some information. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The identifier of the common control sending the message. This identifier is not guaranteed to be unique. 
		/// An application should use the hwndFrom or idFrom member of the NMHDR structure (passed as the lParam parameter) to identify the control. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to an NMHDR structure that contains the notification code and additional information. 
		/// For some notification messages, this parameter points to a larger structure that has the NMHDR structure as its first member. 
		/// </LPARAM>
		/// 
		/// <LRESULT>The return value is ignored except for notification messages that specify otherwise.</LRESULT>
		/// 
		/// <remarks>
		/// The destination of the message must be the HWND of the parent of the control. This value can be obtained by using GetParent.
		/// <para>Applications handle the message in the window procedure of the parent window</para>
		/// <br/>
		/// <para>
		/// Some notifications, chiefly those that have been in the API for a long time, are sent as WM_COMMAND messages.
		/// </para>
		/// <br/>
		/// <para>
		/// If the message handler is in a dialog box procedure, you must use the SetWindowLong function with DWL_MSGRESULT to set a return value.
		/// </para>
		/// <br/>
		/// <para>
		/// For Windows 2000 and later systems, the WM_NOTIFY message cannot be sent between processes.
		/// </para>
		/// <br/>
		/// <para>
		/// Many notifications are available in both ANSI and Unicode formats. The window sending the WM_NOTIFY message uses the WM_NOTIFYFORMAT message 
		/// to determine which format should be used. See WM_NOTIFYFORMAT for further discussion.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_NOTIFY				=  0x0000004E,
		# endregion

		# region WM_NOTIFYFORMAT
		/// <summary>
		/// Determines if a window accepts ANSI or Unicode structures in the WM_NOTIFY notification message. 
		/// WM_NOTIFYFORMAT messages are sent from a common control to its parent window and from the parent window to the common control.
		/// </summary>
		/// 
		/// <WPARAM>
		/// A handle to the window that is sending the WM_NOTIFYFORMAT message. If lParam is NF_QUERY, this parameter is the handle to a control. 
		/// If lParam is NF_REQUERY, this parameter is the handle to the parent window of a control. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The command value that specifies the nature of the WM_NOTIFYFORMAT message. This will be one of the NF_Constants values.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// Returns one of the NFR_Constants values.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When a common control is created, the control sends a WM_NOTIFYFORMAT message to its parent window to determine the type of structures 
		/// to use in WM_NOTIFY messages. If the parent window does not handle this message, the DefWindowProc function responds according to the type 
		/// of the parent window. That is, if the parent window is a Unicode window, DefWindowProc returns NFR_UNICODE, and if the parent window 
		/// is an ANSI window, DefWindowProc returns NFR_ANSI. If the parent window is a dialog box and does not handle this message, 
		/// the DefDlgProc function similarly responds according to the type of the dialog box (Unicode or ANSI). 
		/// <br/>
		/// <para>
		/// A parent window can change the type of structures a common control uses in WM_NOTIFY messages by setting lParam to NF_REQUERY 
		/// sending a WM_NOTIFYFORMAT message to the control. This causes the control to send an NF_QUERY form of the WM_NOTIFYFORMAT message to 
		/// the parent window. 
		/// </para>
		/// <br/>
		/// <para>
		/// All common controls will send WM_NOTIFYFORMAT messages. However, the standard Windows controls (edit controls, combo boxes, list boxes, 
		/// buttons, scroll bars, and static controls) do not.
		/// </para>
		/// </remarks>
		WM_NOTIFYFORMAT                 	=  0x00000055,
		# endregion

		# region WM_PAINT
		/// <summary>
		/// The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window. 
		/// The message is sent when the UpdateWindow or RedrawWindow function is called, or by the DispatchMessage function when the application 
		/// obtains a WM_PAINT message by using the GetMessage or PeekMessage function.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>An application returns zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// The WM_PAINT message is generated by the system and should not be sent by an application. To force a window to draw into a specific 
		/// device context, use the WM_PRINT or WM_PRINTCLIENT message. Note that this requires the target window to support 
		/// the WM_PRINTCLIENT message. Most common controls support the WM_PRINTCLIENT message.
		/// <br/>
		/// <para>
		/// The DefWindowProc function validates the update region. The function may also send the WM_NCPAINT message to the window procedure 
		/// if the window frame must be painted and send the WM_ERASEBKGND message if the window background must be erased.
		/// </para>
		/// <br/>
		/// <para>
		/// The system sends this message when there are no other messages in the application's message queue. DispatchMessage determines where 
		/// to send the message; GetMessage determines which message to dispatch. GetMessage returns the WM_PAINT message when there are no other 
		/// messages in the application's message queue, and DispatchMessage sends the message to the appropriate window procedure.
		/// </para>
		/// <br/>
		/// <para>
		/// A window may receive internal paint messages as a result of calling RedrawWindow with the RDW_INTERNALPAINT flag set. 
		/// In this case, the window may not have an update region. An application should call the GetUpdateRect function to determine whether 
		/// the window has an update region. If GetUpdateRect returns zero, the application should not call the BeginPaint and EndPaint functions.
		/// </para>
		/// <br/>
		/// <para>
		/// An application must check for any necessary internal painting by looking at its internal data structures for each WM_PAINT message, 
		/// because a WM_PAINT message may have been caused by both a non-NULL update region and a call to RedrawWindow with the 
		/// RDW_INTERNALPAINT flag set.
		/// </para>
		/// <br/>
		/// <para>
		/// The system sends an internal WM_PAINT message only once. After an internal WM_PAINT message is returned from GetMessage or PeekMessage 
		/// or is sent to a window by UpdateWindow, the system does not post or send further WM_PAINT messages until the window is invalidated 
		/// or until RedrawWindow is called again with the RDW_INTERNALPAINT flag set.
		/// </para>
		/// <br/>
		/// <para>
		/// For some common controls, the default WM_PAINT message processing checks the wParam parameter. 
		/// If wParam is non-NULL, the control assumes that the value is an HDC and paints using that device context.
 		/// </para>
		/// </remarks>
		WM_PAINT                		=  0x0000000F,
		# endregion

		# region WM_PAINTCLIPBOARD
		/// <summary>
		/// Sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format 
		/// and the clipboard viewer's client area needs repainting. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the clipboard viewer window.</WPARAM>
		/// <LPARAM>
		/// A handle to a global memory object that contains a PAINTSTRUCT structure. The structure defines the part of the client area to paint.
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// To determine whether the entire client area or just a portion of it needs repainting, the clipboard owner must compare 
		/// the dimensions of the drawing area given in the rcPaint member of PAINTSTRUCT to the dimensions given in the most recent 
		/// WM_SIZECLIPBOARD message. 
		/// <br/>
		/// <para>
		/// The clipboard owner must use the GlobalLock function to lock the memory that contains the PAINTSTRUCT structure. 
		/// Before returning, the clipboard owner must unlock that memory by using the GlobalUnlock function. 
		/// </para>
		/// </remarks>
		WM_PAINTCLIPBOARD               	=  0x00000309,
		# endregion

		# region WM_PAINTICON
		/// <summary>
		/// The WM_PAINTICON message is sent to a minimized window when the icon is to be painted. 
		/// This message is not sent by current versions of Windows, except in unusual circumstances.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		/// <remarks>
		/// This message is sent only to 16-bit windows (note that this is with a lowercase "W"), and only for compatibility reasons. 
		/// Under such conditions, the value of lParam is TRUE (the value carries no significance). 
		/// </remarks>
		WM_PAINTICON            		=  0x00000026,
		# endregion

		# region WM_PALETTECHANGED
		/// <summary>
		/// The WM_PALETTECHANGED message is sent to all top-level and overlapped windows after the window with the keyboard focus has realized
		/// its logical palette, thereby changing the system palette. This message enables a window that uses a color palette but does not have 
		/// the keyboard focus to realize its logical palette and update its client area.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the window that caused the system palette to change.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <remarks>
		/// This message must be sent to all top-level and overlapped windows, including the one that changed the system palette. 
		/// If any child windows use a color palette, this message must be passed on to them as well.
		/// <br/>
		/// <para>
		/// To avoid creating an infinite loop, a window that receives this message must not realize its palette, 
		/// unless it determines that wParam does not contain its own window handle.
		/// </para>
		/// </remarks>
		WM_PALETTECHANGED               	=  0x00000311,
		# endregion

		# region WM_PALETTEISCHANGING
		/// <summary>
		/// The WM_PALETTEISCHANGING message informs applications that an application is going to realize its logical palette.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the window that is going to realize its logical palette.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// The application changing its palette does not wait for acknowledgment of this message before changing the palette and sending 
		/// the WM_PALETTECHANGED message. As a result, the palette may already be changed by the time an application receives this message.
		/// <br/>
		/// <para>
		/// If the application either ignores or fails to process this message and a second application realizes its palette while the first 
		/// is using palette indexes, there is a strong possibility that the user will see unexpected colors during subsequent drawing operations.
		/// </para>
		/// </remarks>
		WM_PALETTEISCHANGING            	=  0x00000310,
		# endregion

		# region WM_PARENTNOTIFY
		/// <summary>
		/// Sent to a window when a significant action occurs on a descendant window. This message is now extended to include the WM_POINTERDOWN event.
		/// When the child window is being created, the system sends WM_PARENTNOTIFY just before the CreateWindow or CreateWindowEx function that 
		/// creates the window returns. When the child window is being destroyed, the system sends the message before any processing to destroy 
		/// the window takes place.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The low-order word of wParam specifies the event for which the parent is being notified. The value of the high-order word depends on 
		/// the value of the low-order word. This parameter can be one of the following values :
		/// <para>
		/// - WM_CREATE : The child window is being created. HIWORD(wParam) is the identifier of the child window. 
		/// lParam is a handle to the child window.
		/// </para>
		/// <para>
		/// - WM_DESTROY : The child window is being destroyed. HIWORD(wParam) is the identifier of the child window.
		/// lParam is a handle to the child window.
		/// </para>
		/// <para>
		/// - WM_LBUTTONDOWN : The user has placed the cursor over the child window and has clicked the left mouse button.
		/// HIWORD(wParam) is undefined. lParam is the x-coordinate of the cursor is the low-order word, and the y-coordinate of the cursor is 
		/// the high-order word.
		/// </para>
		/// <para>
		/// - WM_MBUTTONDOWN : The user has placed the cursor over the child window and has clicked the middle mouse button.
		/// HIWORD(wParam) is undefined. lParam is the x-coordinate of the cursor is the low-order word, and the y-coordinate of the cursor is 
		/// the high-order word.
		/// </para>
		/// <para>
		/// - WM_RBUTTONDOWN : The user has placed the cursor over the child window and has clicked the right mouse button.
		/// HIWORD(wParam) is undefined. lParam is the x-coordinate of the cursor is the low-order word, and the y-coordinate of the cursor is 
		/// the high-order word.
		/// </para>
		/// <para>
		/// - WM_XBUTTONDOWN : The user has placed the cursor over the child window and has clicked the first or second X button.
		/// HIWORD(wParam) indicates which button was pressed. This parameter can be one of the following values: XBUTTON1 or XBUTTON2.
		/// lParam is the x-coordinate of the cursor is the low-order word, and the y-coordinate of the cursor is the high-order word.
		/// </para>
		/// <para>
		/// - WM_POINTERDOWN : A pointer has made contact with the child window.
		/// HIWORD(wParam) contains the identifier of the pointer that generated the WM_POINTERDOWN event.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Contains the point location of this pointer. Use the following macros to retrieve the point location.
		/// <para>
		/// The •GET_X_LPARAM and •GET_Y_LPARAM macros can be used to retrieve the x/y coordinates in screen coordinates.
		/// </para>
		/// <br/>
		/// <para>
		/// Note  Because the pointer may make contact with the device over a non-trivial area, this point location may be a simplification 
		/// of a more complex pointer area. Whenever possible, an application should use the complete pointer area information instead of 
		/// the point location.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the application processes this message, it returns zero. 
		/// <para>If the application does not process this message, it calls DefWindowProc.</para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This message is also sent to all ancestor windows of the child window, including the top-level window. 
		/// <br/>
		/// <para>
		/// All child windows, except those that have the WS_EX_NOPARENTNOTIFY extended window style, send this message to their parent windows. 
		/// By default, child windows in a dialog box have the WS_EX_NOPARENTNOTIFY style, unless the CreateWindowEx function is called to create 
		/// the child window without this style. 
		/// </para>
		/// <br/>
		/// <para>
		/// This notification provides the child window's ancestor windows an opportunity to examine the pointer information and, if required, 
		/// capture the pointer using the pointer capture functions. 
		/// </para>
		/// </remarks>
		WM_PARENTNOTIFY                 	=  0x00000210,
		# endregion

		# region WM_PASTE
		/// <summary>
		/// An application sends a WM_PASTE message to an edit control or combo box to copy the current content of the clipboard to the edit control 
		/// at the current caret position. Data is inserted only if the clipboard contains data in CF_TEXT format. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero. </WPARAM>
		/// <LPARAM unused="true">This parameter is not used and must be zero. </LPARAM>
		/// <LRESULT unused="true">This message does not return a value. </LRESULT>
		/// 
		/// <remarks>
		/// When sent to a combo box, the WM_PASTE message is handled by its edit control. 
		/// This message has no effect when sent to a combo box with the CBS_DROPDOWNLIST style. 
		/// </remarks>
		WM_PASTE                        	=  0x00000302,
		# endregion

		# region WM_POWER
		/// <summary>
		/// Notifies applications that the system, typically a battery-powered personal computer, is about to enter a suspended mode.
		/// <br/>
		/// <para>
		/// Note  The WM_POWER message is obsolete. It is provided only for compatibility with 16-bit Windows-based applications. 
		/// Applications should use the WM_POWERBROADCAST message.
		/// </para>
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to window.</WPARAM>
		/// <LPARAM>
		/// The power-event notification. This parameter can be one of the following values : PWR_Constants.PWR_CRITICALRESUME, PWR_SUSPENDREQUEST 
		/// or PWR_SUSPENDRESUME.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The value an application returns depends on the value of the wParam parameter. If wParam is PWR_SUSPENDREQUEST, 
		/// the return value is PWR_FAIL to prevent the system from entering the suspended state; otherwise, it is PWR_OK. 
		/// If wParam is PWR_SUSPENDRESUME or PWR_CRITICALRESUME, the return value is zero.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This message is broadcast only to an application that is running on a system that conforms to the Advanced Power Management (APM) 
		/// basic input/output system (BIOS) specification. The message is broadcast by the power-management driver to each window returned by 
		/// the EnumWindows function.
		/// <br/>
		/// <para>
		/// The suspended mode is the state in which the greatest amount of power savings occurs, but all operational data and parameters are preserved. 
		/// Random-access memory (RAM) contents are preserved, but many devices are likely to be turned off.
		/// </para>
		/// </remarks>
		WM_POWER				=  0x00000048,
		# endregion

		# region WM_POWERBROADCAST
		/// <summary>
		/// Notifies applications that a power-management event has occurred.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The power-management event. This parameter can be one of the PBT_Constants values.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The event-specific data. For most events, this parameter is reserved and not used. 
		/// <br/>
		/// <para>
		/// If the wParam parameter is PBT_POWERSETTINGCHANGE, the lParam parameter is a pointer to a POWERBROADCAST_SETTING structure.
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return TRUE if it processes this message.
		/// <br/>
		/// <para>
		/// Windows Server 2003 and Windows XP:  An application can return BROADCAST_QUERY_DENY to deny a PBT_APMQUERYSUSPEND or 
		/// PBT_APMQUERYSUSPENDFAILED request.
		/// </para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The system always sends a PBT_APMRESUMEAUTOMATIC message whenever the system resumes. If the system resumes in response to user input 
		/// such as pressing a key, the system also sends a PBT_APMRESUMESUSPEND message after sending PBT_APMRESUMEAUTOMATIC.
		/// <br/>
		/// <para>
		/// WM_POWERBROADCAST messages do not distinguish between different low-power states. An application can determine only that the system is 
		/// entering or has resumed from a low-power state; it cannot determine the specific power state. The system records details about 
		/// power state transitions in the Windows System event log.
		/// </para>
		/// <br/>
		/// <para>
		/// To prevent the system from transitioning to a low-power state in Windows Vista, an application must call SetThreadExecutionState 
		/// to inform the system that it is in use.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_POWERBROADCAST               	=  0x00000218,
		# endregion

		# region WM_PRINT
		/// <summary>
		/// The WM_PRINT message is sent to a window to request that it draw itself in the specified device context, most commonly 
		/// in a printer device context.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the device context to draw in.</WPARAM>
		/// 
		/// <LPARAM>
		/// The drawing options. This parameter can be one or more of the PRF_COnstants values.
		/// </LPARAM>
		/// 
		/// <remarks>
		/// The DefWindowProc function processes this message based on which drawing option is specified: if PRF_CHECKVISIBLE is specified 
		/// and the window is not visible, do nothing, if PRF_NONCLIENT is specified, draw the nonclient area in the specified device context, 
		/// if PRF_ERASEBKGND is specified, send the window a WM_ERASEBKGND message, if PRF_CLIENT is specified, send the window 
		/// a WM_PRINTCLIENT message, if PRF_CHILDREN is set, send each visible child window a WM_PRINT message, if PRF_OWNED is set, 
		/// send each visible owned window a WM_PRINT message.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_PRINT                        	=  0x00000317,
		# endregion

		# region WM_PRINTCLIENT
		/// <summary>
		/// The WM_PRINTCLIENT message is sent to a window to request that it draw its client area in the specified device context, 
		/// most commonly in a printer device context.
		/// <br/>
		/// <para>
		/// Unlike WM_PRINT, WM_PRINTCLIENT is not processed by DefWindowProc. 
		/// A window should process the WM_PRINTCLIENT message through an application-defined WindowProc function for it to be used properly.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>A handle to the device context to draw in.</WPARAM>
		/// <LPARAM>The drawing options. This parameter can be one or more of the PRF_Constants values.</LPARAM>
		/// 
		/// <remarks>
		/// A window can process this message in much the same manner as WM_PAINT, except that BeginPaint and EndPaint need not be called 
		/// (a device context is provided), and the window should draw its entire client area rather than just the invalid region.
		/// <br/>
		/// <para>
		/// Windows that can be used anywhere in the system, such as controls, should process this message. It is probably worthwhile 
		/// for other windows to process this message as well because it is relatively easy to implement. 
		/// </para>
		/// <br/>
		/// <para>
		/// The AnimateWindow function requires that the window being animated implements the WM_PRINTCLIENT message.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_PRINTCLIENT                  	=  0x00000318,
		# endregion

		# region WM_QUERYDRAGICON
		/// <summary>
		/// Sent to a minimized (iconic) window. The window is about to be dragged by the user but does not have an icon defined for its class. 
		/// An application can return a handle to an icon or cursor. The system displays this cursor or icon while the user drags the icon.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <LRESULT>
		/// An application should return a handle to a cursor or icon that the system is to display while the user drags the icon. The cursor or icon must be compatible with the display driver's resolution. 
		/// If the application returns NULL, the system displays the default cursor.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the user drags the icon of a window without a class icon, the system replaces the icon with a default cursor. 
		/// If the application requires a different cursor to be displayed during dragging, it must return a handle to the cursor or icon 
		/// compatible with the display driver's resolution. If an application returns a handle to a color cursor or icon, the system converts 
		/// the cursor or icon to black and white. The application can call the LoadCursor or LoadIcon function to load a cursor or icon 
		/// from the resources in its executable (.exe) file and to retrieve this handle.
		/// <br/>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a BOOL and return the value directly. 
		/// The DWL_MSGRESULT value set by the SetWindowLong function is ignored.
		/// </para>
		/// </remarks>
		WM_QUERYDRAGICON        		=  0x00000037,
		# endregion

		# region WM_QUERYNEWPALETTE
		/// <summary>
		/// The WM_QUERYNEWPALETTE message informs a window that it is about to receive the keyboard focus, giving the window 
		/// the opportunity to realize its logical palette when it receives the focus.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <LRESULT>the window realizes its logical palette, it must return TRUE; otherwise, it must return FALSE.
		/// </LRESULT>
		WM_QUERYNEWPALETTE              	=  0x0000030F,
		# endregion

		# region WM_QUERYUISTATE
		/// <summary>
		/// An application sends the WM_QUERYUISTATE message to retrieve the UI state for a window.
		/// </summary>
		/// 
		/// <LRESULT>
		/// The return value is NULL if the focus indicators and the keyboard accelerators are visible. 
		/// Otherwise, the return value can be one or more of the UISF_Constants values.
		/// </LRESULT>
		WM_QUERYUISTATE                 	=  0x00000129,
		# endregion

		# region WM_QUEUESYNC
		/// <summary>
		/// Sent by a computer-based training (CBT) application to separate user-input messages from other messages sent through 
		/// the WH_JOURNALPLAYBACK procedure. 
		/// </summary>
		/// 
		/// <LRESULT>A CBT application should return zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// Whenever a CBT application uses the WH_JOURNALPLAYBACK procedure, the first and last messages are WM_QUEUESYNC. 
		/// This allows the CBT application to intercept and examine user-initiated messages without doing so for events that it sends. 
		/// <br/>
		/// <para>
		/// If an application specifies a NULL window handle, the message is posted to the message queue of the active window. 
		/// </para>
		/// </remarks>
		WM_QUEUESYNC            		=  0x00000023,
		# endregion

		# region WM_QUIT
		/// <summary>
		/// Indicates a request to terminate an application, and is generated when the application calls the PostQuitMessage function. 
		/// This message causes the GetMessage function to return zero.
		/// </summary>
		/// 
		/// <WPARAM>The exit code given in the PostQuitMessage function.</WPARAM>
		/// <LRESULT>
		/// This message does not have a return value because it causes the message loop to terminate before the message is sent to 
		/// the application's window procedure. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The WM_QUIT message is not associated with a window and therefore will never be received through a window's window procedure.
		/// It is retrieved only by the GetMessage or PeekMessage functions. 
		/// <br/>
		/// <para>
		/// Do not post the WM_QUIT message using the PostMessage function; use PostQuitMessage. 
		/// </para>
		/// </remarks>
		WM_QUIT                 		=  0x00000012,
		# endregion

		# region WM_RBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the right mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_RBUTTONDOWN                  	=  0x00000204,
		# endregion

		# region WM_RBUTTONUP
		/// <summary>
		/// Posted when the user releases the right mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_RBUTTONUP                    	=  0x00000205,
		# endregion

		# region WM_RBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_RBUTTONDBLCLK                	=  0x00000206,
		# endregion

		# region WM_RENDERALLFORMATS
		/// <summary>
		/// Sent to the clipboard owner before it is destroyed, if the clipboard owner has delayed rendering one or more clipboard formats. 
		/// For the content of the clipboard to remain available to other applications, the clipboard owner must render data in all the formats 
		/// it is capable of generating, and place the data on the clipboard by calling the SetClipboardData function. 
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// When responding to a WM_RENDERALLFORMATS message, the clipboard owner must call the OpenClipboard and EmptyClipboard functions 
		/// before calling SetClipboardData. 
		/// <br/>
		/// <para>
		/// When the application returns, the system removes any unrendered formats from the list of available clipboard formats.
		/// </para>
		/// </remarks>
		WM_RENDERALLFORMATS             	=  0x00000306,
		# endregion

		# region WM_RENDERFORMAT
		/// <summary>
		/// Sent to the clipboard owner if it has delayed rendering a specific clipboard format and if an application has requested data in that format.
		/// The clipboard owner must render data in the specified format and place it on the clipboard by calling the SetClipboardData function. 
		/// </summary>
		/// 
		/// <WPARAM>The clipboard format to be rendered (CF_Constants value).</WPARAM>
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// <remarks>
		/// When responding to a WM_RENDERFORMAT message, the clipboard owner must not open the clipboard before calling SetClipboardData.
		/// </remarks>
		WM_RENDERFORMAT                 	=  0x00000305,
		# endregion

		# region WM_SETFOCUS
		/// <summary>
		/// Sent to a window after it has gained the keyboard focus. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the window that has lost the keyboard focus. This parameter can be NULL.</WPARAM>
		/// 
		/// <remarks>
		/// To display a caret, an application should call the appropriate caret functions when it receives the WM_SETFOCUS message. 
		/// </remarks>
		WM_SETFOCUS             		=  0x00000007,
		# endregion

		# region WM_SETFONT
		/// <summary>
		/// Sets the font that a control is to use when drawing text. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the font (HFONT). If this parameter is NULL, the control uses the default system font to draw text.</WPARAM>
		/// <LPARAM>
		/// The low-order word of lParam specifies whether the control should be redrawn immediately upon setting the font. 
		/// If this parameter is TRUE, the control redraws itself. 
		/// </LPARAM>
		/// 
		/// <remarks>
		/// The WM_SETFONT message applies to all controls, not just those in dialog boxes. 
		/// <br/>
		/// <para>
		/// The best time for the owner of a dialog box control to set the font of the control is when it receives the WM_INITDIALOG message. 
		/// The application should call the DeleteObject function to delete the font when it is no longer needed; for example, 
		/// after it destroys the control. 
		/// </para>
		/// <br/>
		/// <para>
		/// The size of the control does not change as a result of receiving this message. To avoid clipping text that does not fit within 
		/// the boundaries of the control, the application should correct the size of the control window before it sets the font. 
		/// </para>
		/// <br/>
		/// <para>
		/// When a dialog box uses the DS_SETFONT style to set the text in its controls, the system sends the WM_SETFONT message to the dialog box 
		/// procedure before it creates the controls. An application can create a dialog box that contains the DS_SETFONT style by calling any 
		/// of the following functions : CreateDialogIndirect, CreateDialogIndirectParam, DialogBoxIndirect, DialogBoxIndirectParam.
		/// </para>
		/// </remarks>
		WM_SETFONT              		=  0x00000030,
		# endregion

		# region WM_SETHOTKEY
		/// <summary>
		/// Sent to a window to associate a hot key with the window. When the user presses the hot key, the system activates the window. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The low-order word specifies the virtual-key code to associate with the window.
		/// <para>The high-order word can be one or more of HOTKEYF_Constants values.</para>
		/// <para>Setting wParam to NULL removes the hot key associated with a window. </para>
		/// </WPARAM>
		/// 
		/// <LRESULT>
		/// The return value is one of the following :
		/// <para>(-1)  The function is unsuccessful—the hot key is invalid.</para>
		/// <para>(0)  The function is unsuccessful—the window is invalid.</para>
		/// <para>(1)  The function is successful, and no other window has the same hot key.</para>
		/// <para>(2)  The function is successful, but another window already has the same hot key.</para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// A hot key cannot be associated with a child window. 
		/// <br/>
		/// <para>
		/// When the user presses the hot key, the system generates a WM_SYSCOMMAND message with wParam equal to SC_HOTKEY and lParam equal 
		/// to the window's handle. If this message is passed on to DefWindowProc, the system will bring the window's last active popup 
		/// (if it exists) or the window itself (if there is no popup window) to the foreground.
		/// </para>
		/// <br/>
		/// <para>
		/// A window can only have one hot key. If the window already has a hot key associated with it, the new hot key replaces the old one. 
		/// If more than one window has the same hot key, the window that is activated by the hot key is random. 
		/// </para>
		/// <br/>
		/// <para>These hot keys are unrelated to the hot keys set by RegisterHotKey.</para>
		/// </remarks>
		WM_SETHOTKEY            		=  0x00000032,
		# endregion

		# region WM_SETICON
		/// <summary>
		/// Associates a new large or small icon with a window. The system displays the large icon in the ALT+TAB dialog box, and the small icon 
		/// in the window caption. 
		/// </summary>
		/// 
		/// <WPARAM>The type of icon to be set. This parameter can be one of the ICON_Constants values.</WPARAM>
		/// <LPARAM>A handle to the new large or small icon. If this parameter is NULL, the icon indicated by wParamis removed.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is a handle to the previous large or small icon, depending on the value of wParam. It is NULL if the window 
		/// previously had no icon of the type indicated by wParam.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function returns a handle to the previous large or small icon associated with the window, depending on the value of wParam.
		/// </remarks>
		WM_SETICON                      	=  0x00000080,
		# endregion

		# region WM_SETREDRAW
		/// <summary>
		/// An application sends the WM_SETREDRAW message to a window to allow changes in that window to be redrawn or to prevent changes 
		/// in that window from being redrawn.
		/// <br/>
		/// <para>
		/// To send this message, call the SendMessage function with the following parameters.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The redraw state. If this parameter is TRUE, the content can be redrawn after a change. If this parameter is FALSE, 
		/// the content cannot be redrawn after a change.
		/// </WPARAM>
		/// 
		/// <LRESULT>An application returns zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// This message can be useful if an application must add several items to a list box. The application can call this message 
		/// with wParam set to FALSE, add the items, and then call the message again with wParam set to TRUE. Finally, the application can call 
		/// RedrawWindow(hWnd, NULL, NULL, RDW_ERASE | RDW_FRAME | RDW_INVALIDATE | RDW_ALLCHILDREN) to cause the list box to be repainted.
		/// <br/>
		/// <para>
		/// Note  RedrawWindow with the specified flags is used instead of InvalidateRect because the former is necessary for some controls 
		/// that have nonclient area on their own, or have window styles that cause them to be given a nonclient area (such as WS_THICKFRAME, 
		/// WS_BORDER, or WS_EX_CLIENTEDGE). If the control does not have a nonclient area, RedrawWindow with these flags will do only as much 
		/// invalidation as InvalidateRect would.
		/// </para>
		/// <br/>
		/// <para>
		/// If the application sends the WM_SETREDRAW message to a hidden window, the window becomes visible (that is, the operating system adds 
		/// the WS_VISIBLE style to the window).
		/// </para>
		/// </remarks>
		WM_SETREDRAW            		=  0x0000000B,
		# endregion

		# region WM_SETTEXT
		/// <summary>
		/// Sets the text of a window. 
		/// </summary>
		/// 
		/// <LPARAM>A pointer to a null-terminated string that is the window text.</LPARAM>
		/// <LRESULT>
		/// The return value is TRUE if the text is set. It is FALSE (for an edit control), LB_ERRSPACE (for a list box), 
		/// or CB_ERRSPACE (for a combo box) if insufficient space is available to set the text in the edit control. 
		/// It is CB_ERR if this message is sent to a combo box without an edit control. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function sets and displays the window text. For an edit control, the text is the contents of the edit control. 
		/// For a combo box, the text is the contents of the edit-control portion of the combo box. For a button, the text is the button name. 
		/// For other windows, the text is the window title. 
		/// <br/>
		/// <para>
		/// This message does not change the current selection in the list box of a combo box. An application should use the CB_SELECTSTRING message 
		/// to select the item in a list box that matches the text in the edit control. 
		/// </para>
		/// </remarks>
		WM_SETTEXT              		=  0x0000000C,
		# endregion

		# region WM_SETTINGCHANGE
		/// <summary>
		/// A message that is sent to all top-level windows when the SystemParametersInfo function changes a system-wide setting or when 
		/// policy settings have changed.
		/// <br/>
		/// <para>
		/// Applications should send WM_SETTINGCHANGE to all top-level windows when they make changes to system parameters. 
		/// (This message cannot be sent directly to a window.) To send the WM_SETTINGCHANGE message to all top-level windows, 
		/// use the SendMessageTimeout function with the hwnd parameter set to HWND_BROADCAST.
		/// </para>
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// When the system sends this message as a result of a SystemParametersInfo call, the wParam parameter is the value of the uiAction parameter
		/// passed to the SystemParametersInfo function. For a list of values, see SystemParametersInfo. 
		/// <br/>
		/// <para>
		/// When the system sends this message as a result of a change in policy settings, this parameter indicates the type of policy 
		/// that was applied. This value is 1 if computer policy was applied or zero if user policy was applied.
		/// </para>
		/// <br/>
		/// <para>
		/// When the system sends this message as a result of a change in locale settings, this parameter is zero.
		/// </para>
		/// <br/>
		/// <para>
		/// When an application sends this message, this parameter must be NULL.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// When the system sends this message as a result of a SystemParametersInfo call, lParam is a pointer to a string that indicates 
		/// the area containing the system parameter that was changed. This parameter does not usually indicate which specific system parameter changed.
		/// (Note that some applications send this message with lParam set to NULL.) In general, when you receive this message, 
		/// you should check and reload any system parameter settings that are used by your application.
		/// <br/>
		/// <para>
		/// This string can be the name of a registry key or the name of a section in the Win.ini file. 
		/// When the string is a registry name, it typically indicates only the leaf node in the registry, not the full path.
		/// </para>
		/// <br/>
		/// <para>
		/// When the system sends this message as a result of a change in policy settings, this parameter points to the string "Policy".
		/// </para>
		/// <br/>
		/// <para>
		/// When the system sends this message as a result of a change in locale settings, this parameter points to the string "intl".
		/// </para>
		/// <br/>
		/// <para>
		/// To effect a change in the environment variables for the system or the user, broadcast this message with lParam set to the string 
		/// "Environment".
		/// </para>
		/// </LPARAM>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_SETTINGCHANGE        	=  WM_WININICHANGE,
		# endregion

		# region WM_SHOWWINDOW
		/// <summary>
		/// Sent to a window when the window is about to be hidden or shown.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Indicates whether a window is being shown. If wParam is TRUE, the window is being shown. If wParam is FALSE, the window is being hidden. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The status of the window being shown. If lParam is zero, the message was sent because of a call to the ShowWindow function; 
		/// otherwise, lParam is one of the SW_WM_SHOWWINDOW_Constants values.
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function hides or shows the window, as specified by the message. If a window has the WS_VISIBLE style when it is created, 
		/// the window receives this message after it is created, but before it is displayed. A window also receives this message when 
		/// its visibility state is changed by the ShowWindow or ShowOwnedPopups function. 
		/// <br/>
		/// <para>
		/// The WM_SHOWWINDOW message is not sent under the following circumstances : 
		/// </para>
		/// <para>• When a top-level, overlapped window is created with the WS_MAXIMIZE or WS_MINIMIZE style.</para>
		/// <para>• When the SW_SHOWNORMAL flag is specified in the call to the ShowWindow function.</para>
		/// </remarks>
		WM_SHOWWINDOW           		=  0x00000018,
		# endregion

		#  region WM_SIZE
		/// <summary>
		/// Sent to a window after its size has changed.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>The type of resizing requested. This parameter can be one of the SIZE_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word of lParam specifies the new width of the client area.
		/// <para>The high-order word of lParam specifies the new height of the client area. </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// If the SetScrollPos or MoveWindow function is called for a child window as a result of the WM_SIZE message, 
		/// the bRedraw or bRepaint parameter should be nonzero to cause the window to be repainted. 
		/// <br/>
		/// <para>
		/// Although the width and height of a window are 32-bit values, the lParam parameter contains only the low-order 16 bits of each. 
		/// </para>
		/// </remarks>
		WM_SIZE					=  0x00000005,
		# endregion

		# region WM_SIZECLIPBOARD
		/// <summary>
		/// Sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format 
		/// and the clipboard viewer's client area has changed size. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the clipboard viewer window.</WPARAM>
		/// <LPARAM>
		/// A handle to a global memory object that contains a RECT structure. The structure specifies the new dimensions 
		/// of the clipboard viewer's client area. 
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// When the clipboard viewer window is about to be destroyed or resized, a WM_SIZECLIPBOARD message is sent with a null rectangle (0, 0, 0, 0) 
		/// as the new size. This permits the clipboard owner to free its display resources. 
		/// <br/>
		/// <para>
		/// The clipboard owner must use the GlobalLock function to lock the memory object that contains RECT. Before returning, 
		/// the clipboard owner must unlock the object by using the GlobalUnlock function. 
		/// </para>
		/// </remarks>
		WM_SIZECLIPBOARD                	=  0x0000030B,
		# endregion

		# region WM_SIZING
		/// <summary>
		/// Sent to a window that the user is resizing. By processing this message, an application can monitor the size and position of 
		/// the drag rectangle and, if needed, change its size or position.
		/// <br/>
		/// <para>A window receives this message through its WindowProc function.</para>
		/// </summary>
		/// 
		/// <WPARAM>The edge of the window that is being sized. This parameter can be one of the WMSZ_Constants values.</WPARAM>
		/// <LPARAM>
		/// A pointer to a RECT structure with the screen coordinates of the drag rectangle. To change the size or position of the drag rectangle, 
		/// an application must change the members of this structure. 
		/// </LPARAM>
		/// <LRESULT>An application should return TRUE if it processes this message.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_SIZING                       	=  0x00000214,
		# endregion

		# region WM_SPOOLERSTATUS
		/// <summary>
		/// The WM_SPOOLERSTATUS message is sent from Print Manager whenever a job is added to or removed from the Print Manager queue.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>The PR_JOBSTATUS flag.</WPARAM>
		/// <LPARAM>The low-order word specifies the number of jobs remaining in the Print Manager queue.</LPARAM>
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// This message is for informational purposes only. This message is advisory and does not have guaranteed delivery semantics. 
		/// Applications should not assume that they will receive a WM_SPOOLERSTATUS message for every change in spooler status.
		/// <br/>
		/// <para>
		/// The WM_SPOOLERSTATUS message is not supported after Windows XP. To be notified of changes to the print queue status, 
		/// you can use FindFirstPrinterChangeNotification and FindNextPrinterChangeNotification.
		/// </para>
		/// </remarks>
		WM_SPOOLERSTATUS        		=  0x0000002A,
		# endregion

		# region WM_STYLECHANGED
		/// <summary>
		/// Sent to a window after the SetWindowLong function has changed one or more of the window's styles.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Indicates whether the window's styles or extended window styles have changed. This parameter can be either GWL_STYLE or GWL_EXSTYLE.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a STYLESTRUCT structure that contains the new styles for the window. An application can examine the styles, 
		/// but cannot change them. 
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		WM_STYLECHANGED                 	=  0x0000007D,
		# endregion

		# region WM_STYLECHANGING
		/// <summary>
		/// Sent to a window when the SetWindowLong function is about to change one or more of the window's styles.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Indicates whether the window's styles or extended window styles are changing. This parameter can be one or more of GWL_STYLE and 
		/// GWL_EXSTYLE.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a STYLESTRUCT structure that contains the proposed new styles for the window. An application can examine the styles and, 
		/// if necessary, change them. 
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		WM_STYLECHANGING                	=  0x0000007C,
		# endregion

		# region WM_SYSCHAR
		/// <summary>
		/// Posted to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. 
		/// It specifies the character code of a system character key — that is, a character key that is pressed while the ALT key is down. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The character code of the window menu key. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return zero if it processes this message. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the context code is zero, the message can be passed to the TranslateAccelerator function, which will handle it as though it were 
		/// a standard key message instead of a system character-key message. This allows accelerator keys to be used with the active window even if 
		/// the active window does not have the keyboard focus. 
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and the right CTRL keys on the main section of the keyboard ; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN and arrow keys in the clusters to the left of the numeric keypad ; and the divide (/) and 
		/// ENTER keys in the numeric keypad. Some other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// </remarks>
		WM_SYSCHAR                      	=  0x00000106,
		# endregion

		# region WM_SYSCOLORCHANGE
		/// <summary>
		/// The WM_SYSCOLORCHANGE message is sent to all top-level windows when a change is made to a system color setting.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <remarks>
		/// The system sends a WM_PAINT message to any window that is affected by a system color change.
		/// <br/>
		/// <para>
		/// Applications that have brushes using the existing system colors should delete those brushes and re-create them using the new system colors.
		/// </para>
		/// <br/>
		/// <para>
		/// Top level windows that use common controls must forward the WM_SYSCOLORCHANGE message to the controls; otherwise, 
		/// the controls will not be notified of the color change. This ensures that the colors used by your common controls are consistent with 
		/// those used by other user interface objects. For example, a toolbar control uses the "3D Objects" color to draw its buttons. 
		/// If the user changes the 3D Objects color but the WM_SYSCOLORCHANGE message is not forwarded to the toolbar, the toolbar buttons 
		/// will remain in their original color while the color of other buttons in the system changes.
		/// </para>
		/// </remarks>
		WM_SYSCOLORCHANGE       		=  0x00000015,
		# endregion

		# region WM_SYSCOMMAND
		/// <summary>
		/// A window receives this message when the user chooses a command from the Window menu (formerly known as the system or control menu) 
		/// or when the user chooses the maximize button, minimize button, restore button, or close button.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The type of system command requested. This parameter can be one of the SC_Constants values.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The low-order word specifies the horizontal position of the cursor, in screen coordinates, if a window menu command 
		/// is chosen with the mouse. Otherwise, this parameter is not used. 
		/// <br/>
		/// <para>
		/// The high-order word specifies the vertical position of the cursor, in screen coordinates, if a window menu command is chosen with the mouse.
		/// This parameter is –1 if the command is chosen using a system accelerator, or zero if using a mnemonic. 
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		/// 
		/// <remarks>
		/// To obtain the position coordinates in screen coordinates, use the GET_X_LPARAM and GET_Y_LPARAM macros.
		/// <br/>
		/// <para>
		/// The DefWindowProc function carries out the window menu request for the predefined actions specified in the previous table. 
		/// </para>
		/// <br/>
		/// <para>
		/// In WM_SYSCOMMAND messages, the four low-order bits of the wParam parameter are used internally by the system. 
		/// To obtain the correct result when testing the value of wParam, an application must combine the value 0xFFF0 with the wParam value 
		/// by using the bitwise AND operator. 
		/// </para>
		/// <br/>
		/// <para>
		/// The menu items in a window menu can be modified by using the GetSystemMenu, AppendMenu, InsertMenu, ModifyMenu, InsertMenuItem, 
		/// and SetMenuItemInfo functions. Applications that modify the window menu must process WM_SYSCOMMAND messages.
		/// </para>
		/// <br/>
		/// <para>
		/// An application can carry out any system command at any time by passing a WM_SYSCOMMAND message to DefWindowProc. 
		/// Any WM_SYSCOMMAND messages not handled by the application must be passed to DefWindowProc. 
		/// Any command values added by an application must be processed by the application and cannot be passed to DefWindowProc. 
		/// </para>
		/// <br/>
		/// <para>
		/// If password protection is enabled by policy, the screen saver is started regardless of what an application does with the 
		/// SC_SCREENSAVE notification—even if fails to pass it to DefWindowProc. 
		/// </para>
		/// <br/>
		/// <para>
		/// Accelerator keys that are defined to choose items from the window menu are translated into WM_SYSCOMMAND messages; 
		/// all other accelerator keystrokes are translated into WM_COMMAND messages. 
		/// </para>
		/// <br/>
		/// <para>
		/// If the wParam is SC_KEYMENU, lParam contains the character code of the key that is used with the ALT key to display the popup menu. 
		/// For example, pressing ALT+F to display the File popup will cause a WM_SYSCOMMAND with wParam equal to SC_KEYMENU and lParam equal to 'f'.
		/// </para>
		/// </remarks>
		WM_SYSCOMMAND                   	=  0x00000112,
		# endregion

		# region WM_SYSDEADCHAR
		/// <summary>
		/// Sent to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. 
		/// WM_SYSDEADCHAR specifies the character code of a system dead key — that is, a dead key that is pressed while holding down the ALT key. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The character code generated by the dead key. 
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// An application should return zero if it processes this message. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and the right CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and ENTER keys 
		/// in the numeric keypad. Some other keyboards may support the extended-key bit in the lParam parameter. 
		/// </remarks>
		WM_SYSDEADCHAR                  	=  0x00000107,
		# endregion

		# region WM_SYSKEYDOWN
		/// <summary>
		/// Posted to the window with the keyboard focus when the user presses the F10 key (which activates the menu bar) or holds down 
		/// the ALT key and then presses another key. It also occurs when no window currently has the keyboard focus; 
		/// in this case, the WM_SYSKEYDOWN message is sent to the active window. The window that receives the message can distinguish between 
		/// these two contexts by checking the context code in the lParam parameter. 
		/// </summary>
		/// 
		/// <WPARAM>The virtual-key code of key being pressed.</WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function examines the specified key and generates a WM_SYSCOMMAND message if the key is either TAB or ENTER. 
		/// <br/>
		/// <para>
		/// When the context code is zero, the message can be passed to the TranslateAccelerator function, which will handle it as though it were 
		/// a normal key message instead of a character-key message. This allows accelerator keys to be used with the active window even if 
		/// the active window does not have the keyboard focus. 
		/// </para>
		/// <br/>
		/// <para>
		/// Because of automatic repeat, more than one WM_SYSKEYDOWN message may occur before a WM_SYSKEYUP message is sent. 
		/// The previous key state (bit 30) can be used to determine whether the WM_SYSKEYDOWN message indicates the first down transition or 
		/// a repeated down transition. 
		/// </para>
		/// <br/>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, enhanced keys are the right ALT and CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) 
		/// and ENTER keys in the numeric keypad. Other keyboards may support the extended-key bit in the lParam parameter.
		/// </para>
		/// <br/>
		/// <para>
		/// This message is also sent whenever the user presses the F10 key without the ALT key. 
		/// </para>
		/// </remarks>
		WM_SYSKEYDOWN                   	=  0x00000104,
		# endregion

		# region WM_SYSKEYUP
		/// <summary>
		/// Posted to the window with the keyboard focus when the user releases a key that was pressed while the ALT key was held down. 
		/// It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYUP message is sent to the active window. 
		/// The window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter. 
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>The virtual-key code of key being released.</WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// The DefWindowProc function sends a WM_SYSCOMMAND message to the top-level window if the F10 key or the ALT key was released. 
		/// The wParam parameter of the message is set to SC_KEYMENU. 
		/// <br/>
		/// <para>
		/// When the context code is zero, the message can be passed to the TranslateAccelerator function, which will handle it as though it were 
		/// a normal key message instead of a character-key message. This allows accelerator keys to be used with the active window even if 
		/// the active window does not have the keyboard focus. 
		/// </para>
		/// <br/>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) 
		/// and ENTER keys in the numeric keypad. Other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// <br/>
		/// <para>
		/// For non-U.S. enhanced 102-key keyboards, the right ALT key is handled as a CTRL+ALT key. 
		/// The following table shows the sequence of messages that result when the user presses and releases this key :
		/// </para>
		/// <para>WM_KEYDOWN (VK_CONTROL)</para>
		/// <para>WM_KEYDOWN (VK_MENU)</para>
		/// <para>WM_KEYUP (VK_CONTROL)</para>
		/// <para>WM_SYSKEYUP (VK_MENU)</para>
		/// </remarks>
		WM_SYSKEYUP                     	=  0x00000105,
		# endregion

		# region WM_TABLET_FIRST
		/// <summary>
		/// Undocumented.
		/// </summary>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_TABLET_FIRST                 	=  0x000002c0,
		# endregion

		# region WM_TABLET_LAST
		/// <summary>
		/// Undocumented.
		/// </summary>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_TABLET_LAST                  	=  0x000002df,
		# endregion 

		# region WM_TCARD
		/// <summary>
		/// Sent to an application that has initiated a training card with Windows Help. The message informs the application when the user 
		/// clicks an authorable button. 
		/// An application initiates a training card by specifying the HELP_TCARD command in a call to the WinHelp function.
		/// </summary>
		/// 
		/// <WPARAM>A value that indicates the action the user has taken. This can be one of the ID_Constants values.</WPARAM>
		/// <LPARAM>
		/// If idAction specifies HELP_TCARD_DATA, this parameter is a long specified by the Help author. Otherwise, this parameter is zero.
		/// </LPARAM>
		WM_TCARD                        	=  0x00000052,
		# endregion

		# region WM_THEMECHANGED
		/// <summary>
		/// Broadcast to every window following a theme change event. Examples of theme change events are the activation of a theme, 
		/// the deactivation of a theme, or a transition from one theme to another.
		/// </summary>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// A window receives this message through its WindowProc function. 
		/// <br/>
		/// <para>
		/// Note : This message is posted by the operating system. Applications typically do not send this message. 
		/// </para>
		/// <br/>
		/// <para>
		/// Themes are specifications for the appearance of controls, so that the visual element of a control is treated separately from 
		/// its functionality. 
		/// </para>
		/// <br/>
		/// <para>
		/// To release an existing theme handle, call CloseThemeData. To acquire a new theme handle, use OpenThemeData.
		/// </para>
		/// <br/>
		/// <para>
		/// Following the WM_THEMECHANGED broadcast, any existing theme handles are invalid. A theme-aware window should release and reopen any of 
		/// its pre-existing theme handles when it receives the WM_THEMECHANGED message. If the OpenThemeData function returns NULL, 
		/// the window should paint unthemed.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_THEMECHANGED                 	=  0x0000031A,
		# endregion

		# region WM_TIMECHANGE
		/// <summary>
		/// A message that is sent whenever there is a change in the system time.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		/// <remarks>
		/// An application should not broadcast this message, because the system will broadcast this message when the application changes 
		/// the system time.
		/// </remarks>
		WM_TIMECHANGE           		=  0x0000001E,
		#  endregion

		# region WM_TIMER
		/// <summary>
		/// Posted to the installing thread's message queue when a timer expires. The message is posted by the GetMessage or PeekMessage function. 
		/// </summary>
		/// 
		/// <WPARAM>The timer identifier. </WPARAM>
		/// <LPARAM>A pointer to an application-defined callback function that was passed to the SetTimer function when the timer was installed.</LPARAM>
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// You can process the message by providing a WM_TIMER case in the window procedure. 
		/// Otherwise, DispatchMessage will call the TimerProc callback function specified in the call to the SetTimer function used 
		/// to install the timer. 
		/// <br/>
		/// <para>
		/// The WM_TIMER message is a low-priority message. The GetMessage and PeekMessage functions post this message only when no other 
		/// higher-priority messages are in the thread's message queue. 
		/// </para>
		/// </remarks>
		WM_TIMER                        	=  0x00000113,
		# endregion

		# region WM_TOUCH
		/// <summary>
		/// Notifies the window when one or more touch points, such as a finger or pen, touches a touch-sensitive digitizer surface.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The low-order word contains the number of touch points associated with this message. The high-order word is reserved for future use.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Contains a touch input handle that can be used in a call to GetTouchInputInfo to retrieve detailed information about the touch points 
		/// associated with this message. 
		/// <br/>
		/// <para>
		/// This handle is valid only within the current process and should not be passed cross-process except as the LPARAM in a SendMessage 
		/// or PostMessage call. 
		/// </para>
		/// <br/>
		/// <para>
		/// When the application no longer requires this handle, the application must call CloseTouchInputHandle to free the process memory associated 
		/// with this handle. Failing to do so can result in an application memory leak. 
		/// </para>
		/// <br/>
		/// <para>
		/// Note that the touch input handle in this parameter is no longer valid after the message has been passed to DefWindowProc. 
		/// DefWindowProc will close and invalidate this handle. 
		/// </para>
		/// <br/>
		/// <para>
		/// Note also that the touch input handle in this parameter is no longer valid after the message has been forwarded using PostMessage, 
		/// SendMessage, or one of their variants. These functions will close and invalidate this handle. 
		/// </para>
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an application processes this message, it should return zero. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// WM_TOUCH messages do not respect HTTRANSPARENT regions of windows. If a window returns HTTRANSPARENT in response to a WM_NCHITTEST message, 
		/// mouse messages go to the parent, and WM_TOUCH messages go directly to the window.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows7 )]
		WM_TOUCH                        	=  0x00000240,
		# endregion

		# region WM_UNDO
		/// <summary>
		/// An application sends a WM_UNDO message to an edit control to undo the last operation. When this message is sent to an edit control,
		/// the previously deleted text is restored or the previously added text is deleted. 
		/// </summary>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is TRUE. 
		/// <para>If the message fails, the return value is FALSE.</para>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Rich Edit: It is recommended that EM_UNDO be used instead of WM_UNDO.
		/// </remarks>
		WM_UNDO                         	=  0x00000304,
		# endregion

		# region WM_UNICHAR
		/// <summary>
		/// The WM_UNICHAR message can be used by an application to post input to other windows. This message contains the character code 
		/// of the key that was pressed. (Test whether a target app can process WM_UNICHAR messages by sending the message with wParam set to 
		/// UNICODE_NOCHAR.)
		/// </summary>
		/// 
		/// <WPARAM>
		/// The character code of the key. 
		/// <br/>
		/// <para>
		/// If wParam is UNICODE_NOCHAR and the application processes this message, then return TRUE. 
		/// The DefWindowProc function will return FALSE (the default). 
		/// </para>
		/// <br/>
		/// <para>
		/// If wParam is not UNICODE_NOCHAR, return FALSE. The Unicode  DefWindowProc posts a WM_CHAR message with the same parameters and
		/// the ANSI DefWindowProc function posts either one or two WM_CHAR messages with the corresponding ANSI character(s). 
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM class="WM_KEYMSG_LPARAM">
		/// The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown in the following table. 
		/// <br/>
		/// <para>
		/// The following table gives the bit layout :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Bits	Meaning</para>
		/// <para>0-15		The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. </para>
		/// <para>		If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative.</para>
		/// <para>16-23	The scan code. The value depends on the OEM.</para>
		/// <para>24		Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. </para>
		/// <para>		The value is 1 if it is an extended key; otherwise, it is 0.</para>
		/// <para>25-28	Reserved ; do not use.</para>
		/// <para>29		The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.</para>
		/// <para>30		The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.</para>
		/// <para>31		The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.</para>
		/// </code>
		/// </LPARAM>
		/// 
		/// <LRESULT>An application should return zero if it processes this message. </LRESULT>
		/// 
		/// <remarks>
		/// The WM_UNICHAR message is similar to WM_CHAR, but it uses Unicode Transformation Format (UTF)-32, whereas WM_CHAR uses UTF-16. 
		/// <br/>
		/// <para>
		/// This message is designed to send or post Unicode characters to ANSI windows and can handle Unicode Supplementary Plane characters.
		/// </para>
		/// <br/>
		/// <para>
		/// Because there is not necessarily a one-to-one correspondence between keys pressed and character messages generated, 
		/// the information in the high-order word of the lParam parameter is generally not useful to applications. 
		/// The information in the high-order word applies only to the most recent WM_KEYDOWN message that precedes the posting of 
		/// the WM_UNICHAR message. 
		/// </para>
		/// <br/>
		/// <para>
		/// For enhanced 101- and 102-key keyboards, extended keys are the right ALT and the right CTRL keys on the main section of the keyboard; 
		/// the INS, DEL, HOME, END, PAGE UP, PAGE DOWN and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and 
		/// ENTER keys in the numeric keypad. Some other keyboards may support the extended-key bit in the lParam parameter. 
		/// </para>
		/// </remarks>
		WM_UNICHAR                      	=  0x00000109,
		# endregion

		# region WM_UNINITMENUPOPUP
		/// <summary>
		/// Sent when a drop-down menu or submenu has been destroyed. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the menu.</WPARAM>
		/// <LPARAM>
		/// The high-order word identifies the menu that was destroyed. Currently, this parameter can only be MF_SYSMENU (the window menu). 
		/// </LPARAM>
		/// 
		/// <remarks>
		/// If an application receives a WM_INITMENUPOPUP message, it will receive a WM_UNINITMENUPOPUP message.
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_UNINITMENUPOPUP              	=  0x00000125,
		# endregion

		# region WM_UPDATEUISTATE
		/// <summary>
		/// An application sends the WM_UPDATEUISTATE message to change the UI state for the specified window and all its child windows.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The low-order word specifies the action to be performed. This parameter can be one of the UIS_Constants values.
		/// <para>
		/// The high-order word specifies which UI state elements are affected or the style of the control. 
		/// This parameter can be one or more of the UISF_Constants values. 
		/// </para>
		/// </WPARAM>
		/// 
		/// <remarks>
		/// A window should send this message to change the UI state of all its child windows. In contrast to the WM_CHANGEUISTATE message, 
		/// which is a notification, when DefWindowProc processes the WM_UPDATEUISTATE message it changes the UI state and propagates the changes 
		/// to all child windows.
		/// <br/>
		/// <para>
		/// The DefWindowProc function updates the UI state according to the wParam value. If the UI state is modified, the function sends 
		/// the message to all the immediate child windows. DefWindowProc also sends this message when it receives a WM_CHANGEUISTATE message
		/// notifying the system that a child window intends to modify the UI state.
		/// </para>
		/// </remarks>
		WM_UPDATEUISTATE                	=  0x00000128,
		# endregion

		# region WM_USERCHANGED
		/// <summary>
		/// Sent to all windows after the user has logged on or off. When the user logs on or off, the system updates the user-specific settings. 
		/// The system sends this message immediately after updating the settings.
		/// </summary>
		/// 
		/// <LRESULT>An application should return zero if it processes this message.</LRESULT>
		WM_USERCHANGED                  	=  0x00000054,
		# endregion

		# region WM_VKEYTOITEM
		/// <summary>
		/// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_KEYDOWN message. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD specifies the virtual-key code of the key the user pressed. The HIWORD specifies the current position of the caret. 
		/// </WPARAM>
		/// <LPARAM>Handle to the list box. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value specifies the action that the application performed in response to the message. 
		/// A return value of –2 indicates that the application handled all aspects of selecting the item and requires 
		/// no further action by the list box. (See Remarks.) 
		/// A return value of –1 indicates that the list box should perform the default action in response to the keystroke. 
		/// A return value of 0 or greater specifies the index of an item in the list box and indicates that the list box should perform 
		/// the default action for the keystroke on the specified item. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// A return value of –2 is valid only for keys that are not translated into characters by the list box control.
		/// If the WM_KEYDOWN message translates to a WM_CHAR message and the application processes the WM_VKEYTOITEM message generated 
		/// as a result of the key press, the list box ignores the return value and does the default processing for that character).
		/// WM_KEYDOWN messages generated by keys such as VK_UP, VK_DOWN, VK_NEXT, and VK_PREVIOUS are not translated to WM_CHAR messages. 
		/// In such cases, trapping the WM_VKEYTOITEM message and returning –2 prevents the list box from doing the default processing for that key.
		/// <br/>
		/// <para>
		/// To trap keys that generate a char message and do special processing, the application must subclass the list box, trap both 
		/// the WM_KEYDOWN and WM_CHAR messages, and process the messages appropriately in the subclass procedure.
		/// </para>
		/// <br/>
		/// <para>
		/// The preceding remarks apply to regular list boxes that are created with the LBS_WANTKEYBOARDINPUT style. 
		/// If the list box is owner-drawn, the application must process the WM_CHARTOITEM message. 
		/// </para>
		/// <br/>
		/// <para>The DefWindowProc function returns –1. </para>
		/// <br/>
		/// <para>
		/// If a dialog box procedure handles this message, it should cast the desired return value to a BOOL and return the value directly. 
		/// The DWL_MSGRESULT value set by the SetWindowLong function is ignored. 
		/// </para>
		/// </remarks>
		WM_VKEYTOITEM           		=  0x0000002E,
		# endregion

		# region WM_VSCROLL
		/// <summary>
		/// The WM_VSCROLL message is sent to a window when a scroll event occurs in the window's standard vertical scroll bar. 
		/// This message is also sent to the owner of a vertical scroll bar control when a scroll event occurs in the control. 
		/// <br/>
		/// <para>A window receives this message through its WindowProc function. </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The HIWORD specifies the current position of the scroll box if the LOWORD is SB_THUMBPOSITION or SB_THUMBTRACK; otherwise, 
		/// this word is not used.
		/// <br/>
		/// <para>
		/// The LOWORD specifies a scroll bar value that indicates the user's scrolling request. This parameter can be one of the SB_Constants values.
		/// </para>
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// If the message is sent by a scroll bar, this parameter is the handle to the scroll bar control. 
		/// If the message is not sent by a scroll bar, this parameter is NULL. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// The SB_THUMBTRACK request code is typically used by applications that provide feedback as the user drags the scroll box. 
		/// <br/>
		/// <para>
		/// If an application scrolls the content of the window, it must also reset the position of the scroll box by using the SetScrollPos function. 
		/// </para>
		/// <br/>
		/// <para>
		/// Note that the WM_VSCROLL message carries only 16 bits of scroll box position data. 
		/// Thus, applications that rely solely on WM_VSCROLL (and WM_HSCROLL) for scroll position data have a practical maximum position value 
		/// of 65,535. 
		/// </para>
		/// <br/>
		/// <para>
		/// However, because the SetScrollInfo, SetScrollPos, SetScrollRange, GetScrollInfo, GetScrollPos, and GetScrollRange functions support 
		/// 32-bit scroll bar position data, there is a way to circumvent the 16-bit barrier of the WM_HSCROLL and WM_VSCROLL messages. 
		/// See GetScrollInfo for a description of the technique. 
		/// </para>
		/// </remarks>
		WM_VSCROLL                      	=  0x00000115,
		# endregion

		# region WM_VSCROLLCLIPBOARD
		/// <summary>
		/// Sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and 
		/// an event occurs in the clipboard viewer's vertical scroll bar. 
		/// The owner should scroll the clipboard image and update the scroll bar values. 
		/// </summary>
		/// 
		/// <WPARAM>A handle to the clipboard viewer window.</WPARAM>
		/// <LPARAM>The low-order word of lParam specifies a scroll bar event. This parameter can be one of the SB_Constants values.</LPARAM>
		WM_VSCROLLCLIPBOARD             	=  0x0000030A,
		# endregion

		# region WM_WINDOWPOSCHANGED
		/// <summary>
		/// Sent to a window whose size, position, or place in the Z order has changed as a result of a call to the SetWindowPos function 
		/// or another window-management function.
		/// <br/>
		/// <para>A window receives this message through its WindowProc function. </para>
		/// </summary>
		/// 
		/// <LPARAM>A pointer to a WINDOWPOS structure that contains information about the window's new size and position.</LPARAM>
		/// 
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		/// 
		/// <remarks>
		/// By default, the DefWindowProc function sends the WM_SIZE and WM_MOVE messages to the window.
		/// The WM_SIZE and WM_MOVE messages are not sent if an application handles the WM_WINDOWPOSCHANGED message without calling DefWindowProc. 
		/// It is more efficient to perform any move or size change processing during the WM_WINDOWPOSCHANGED message without calling DefWindowProc.
		/// </remarks>
		WM_WINDOWPOSCHANGED			=  0x00000047,
		# endregion

		#  region WM_WINDOWPOSCHANGING
		/// <summary>
		/// Sent to a window whose size, position, or place in the Z order is about to change as a result of a call to the SetWindowPos function
		/// or another window-management function.
		/// <br/>
		/// <para>A window receives this message through its WindowProc function.</para>
		/// </summary>
		/// 
		/// <LPARAM>A pointer to a WINDOWPOS structure that contains information about the window's new size and position.</LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero. </LRESULT>
		/// 
		/// <remarks>
		/// For a window with the WS_OVERLAPPED or WS_THICKFRAME style, the DefWindowProc function sends the WM_GETMINMAXINFO message to the window. 
		/// This is done to validate the new size and position of the window and to enforce the CS_BYTEALIGNCLIENT and CS_BYTEALIGNWINDOW client styles.
		/// By not passing the WM_WINDOWPOSCHANGING message to the DefWindowProc function, an application can override these defaults. 
		/// <br/>
		/// <para>
		/// While this message is being processed, modifying any of the values in WINDOWPOS affects the window's new size, position, 
		/// or place in the Z order. An application can prevent changes to the window by setting or clearing the appropriate bits 
		/// in the flags member of WINDOWPOS. 
		/// </para>
		/// </remarks>
		WM_WINDOWPOSCHANGING			=  0x00000046,
		# endregion

		# region WM_WININICHANGE
		/// <summary>
		/// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. 
		/// The SystemParametersInfo function sends this message after an application uses the function to change a setting in WIN.INI.
		/// <br/>
		/// <para>
		/// Note : The WM_WININICHANGE message is provided only for compatibility with earlier versions of the system.
		/// Applications should use the WM_SETTINGCHANGE message.
		/// </para>
		/// </summary>
		/// 
		/// <LPARAM>
		/// A pointer to a string containing the name of the system parameter that was changed. For example, this string can be the name of 
		/// a registry key or the name of a section in the Win.ini file. This parameter is not particularly useful in determining 
		/// which system parameter changed. For example, when the string is a registry name, it typically indicates only the leaf node in the registry, 
		/// not the whole path. In addition, some applications send this message with lParam set to NULL. 
		/// In general, when you receive this message, you should check and reload any system parameter settings that are used by your application.
		/// </LPARAM>
		/// 
		/// <LRESULT>If you process this message, return zero.</LRESULT>
		/// 
		/// <remarks>
		/// To send the WM_WININICHANGE message to all top-level windows, use the SendMessage function with the hWnd parameter set to HWND_BROADCAST.
		/// <br/>
		/// <para>
		/// Calls to functions that change WIN.INI may be mapped to the registry instead. 
		/// This mapping occurs when WIN.INI and the section being changed are specified in the registry under the following key :
		/// </para>
		/// <para>
		/// <code>
		/// HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\IniFileMapping
		/// </code>
		/// </para>
		/// <br/>
		/// <para>
		/// The change in the storage location has no effect on the behavior of this message.
		/// </para>
		/// </remarks>
		WM_WININICHANGE         		=  0x0000001A,
		# endregion

		# region WM_WTSSESSION_CHANGE
		/// <summary>
		/// Notifies applications of changes in session state.
		/// <br/>
		/// <para>
		/// The window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// Status code describing the reason the session state change notification was sent. 
		/// This parameter can be one of the WTS_Constants values.
		/// </WPARAM>
		/// 
		/// <LPARAM>The identifier of the session.</LPARAM>
		/// 
		/// <remarks>
		/// This message is sent only to applications that have registered to receive this message by calling WTSRegisterSessionNotification.
		/// <br/>
		/// <para>
		/// Examples of how applications can respond to this message include releasing or acquiring console-specific resources, 
		/// determining how a screen is to be painted, or triggering console animation effects.
		/// </para>
		/// </remarks>
		[Constraint ( MinVersion = WindowsVersion. WindowsXP )]
		WM_WTSSESSION_CHANGE            	=  0x000002B1,
		# endregion

		# region WM_XBUTTONDOWN
		/// <summary>
		/// Posted when the user presses the first or second X button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		[Constraint ( MinVersion = WindowsVersion. Windows2000 )]
		WM_XBUTTONDOWN                  	=  0x0000020B,
		# endregion

		# region WM_RBUTTONUP
		/// <summary>
		/// Posted when the user releases the first or second X button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_XBUTTONUP                    	=  0x0000020C,
		# endregion

		# region WM_RBUTTONDBLCLK
		/// <summary>
		/// Posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. 
		/// If the mouse is not captured, the message is posted to the window beneath the cursor. 
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// <br/>
		/// <para>
		/// A window receives this message through its WindowProc function.
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>Indicates whether various virtual keys are down. This parameter can be one or more of the MK_Constants values.</WPARAM>
		/// <LPARAM>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// <para>
		/// The low-order word specifies the x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the client area. 
		/// </para>
		/// </LPARAM>
		/// <LRESULT>If an application processes this message, it should return zero.</LRESULT>
		WM_XBUTTONDBLCLK                	=  0x0000020D,
		# endregion

		# region WM_REFLECT
		/// <summary>
		/// Notification message sent to a subclassed windowproc.
		/// </summary>
		WM_REFLECT				=  WM_USER + 0x1C00,
		# endregion


		# region WM_xxx_FIRST and WM_xxx_LAST constants
		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_USER                 		=  0x00000400,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_APP					=  0x00008000,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_KEYFIRST				=  0x00000100,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_KEYLAST				=  0x00000109,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_IME_KEYLAST                  	=  0x0000010F,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_MOUSEFIRST                   	=  0x00000200,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_MOUSELAST                    	=  0x0000020E,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_HANDHELDFIRST			=  0x00000358,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_HANDHELDLAST				=  0x0000035F,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_AFXFIRST				=  0x00000360,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		[Constraint ( MinVersion = WindowsVersion. Windows )]
		WM_AFXLAST				=  0x0000037F,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_PENWINFIRST				=  0x00000380,

		[MessageConstant ( MessageConstantType. BaseConstant )]
		WM_PENWINLAST				=  0x0000038F,

		# endregion

		# region WM_NULL
		/// <summary>
		/// Null message. Does nothing.
		/// </summary>
		WM_NULL					=  0x00000000
		# endregion
	    }
	# endregion
    }