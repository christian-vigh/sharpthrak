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

	# region WS_ Window style constants
	/// <summary>
	/// Window styles constants.
	/// </summary>
	public enum WS_Constants : ulong
	   {
		# region BS_* : Button styles
		/// <summary>
		/// Creates a button that is the same as a check box, except that the box can be grayed as well as checked or cleared. 
		/// <para>
		/// Use the grayed state to show that the state of the check box is not determined.
		/// </para>
		/// </summary>
		BS_3STATE           		=  0x00000005L,

		/// <summary>
		/// Creates a button that is the same as a three-state check box, except that the box changes its state when the user selects it. 
		/// The state cycles through checked, indeterminate, and cleared.
		/// </summary>
		BS_AUTO3STATE       		=  0x00000006L,

		/// <summary>
		/// Creates a button that is the same as a check box, except that the check state automatically toggles between checked and cleared 
		/// each time the user selects the check box.
		/// </summary>
		BS_AUTOCHECKBOX     		=  0x00000003L,

		/// <summary>
		/// Creates a button that is the same as a radio button, except that when the user selects it, the system automatically sets the button's check state 
		/// to checked and automatically sets the check state for all other buttons in the same group to cleared.
		/// </summary>
		BS_AUTORADIOBUTTON  		=  0x00000009L,

		/// <summary>
		/// Specifies that the button displays a bitmap.
		/// </summary>
		BS_BITMAP           		=  0x00000080L,

		/// <summary>
		/// Places text at the bottom of the button rectangle.
		/// </summary>
		BS_BOTTOM           		=  0x00000800L,

		/// <summary>
		/// Centers text horizontally in the button rectangle.
		/// </summary>
		BS_CENTER           		=  0x00000300L,

		/// <summary>
		/// Creates a small, empty check box with text. By default, the text is displayed to the right of the check box. 
		/// <para>
		/// To display the text to the left of the check box, combine this flag with the BS_LEFTTEXT style (or with the equivalent BS_RIGHTBUTTON style).
		/// </para>
		/// </summary>
		BS_CHECKBOX         		=  0x00000002L,

		/// <summary>
		/// Windows Vista and Version 6.00. Creates a command link button that behaves like a BS_PUSHBUTTON style button, but the command link button 
		/// has a green arrow on the left pointing to the button text. A caption for the button text can be set by sending the BCM_SETNOTE message to the button.
		/// </summary>
		BS_COMMANDLINK			=  0x0000000EL,

		/// <summary>
		/// Windows Vista and Version 6.00. Creates a command link button that behaves like a BS_PUSHBUTTON style button. 
		/// <para>
		/// If the button is in a dialog box, the user can select the command link button by pressing the ENTER key, even when the command link button 
		/// does not have the input focus. This style is useful for enabling the user to quickly select the most likely (default) option.
		/// </para>
		/// </summary>
		BS_DEFCOMMANDLINK		=  0x0000000FL,

		/// <summary>
		/// Creates a push button that behaves like a BS_PUSHBUTTON style button, but has a distinct appearance. 
		/// <para>
		/// If the button is in a dialog box, the user can select the button by pressing the ENTER key, even when the button does not have the input focus. 
		/// </para>
		/// <para>
		/// This style is useful for enabling the user to quickly select the most likely (default) option.
		/// </para>
		/// </summary>
		BS_DEFPUSHBUTTON    		=  0x00000001L,

		/// <summary>
		/// Windows Vista and Version 6.00. Creates a split button that behaves like a BS_PUSHBUTTON style button, but also has a distinctive appearance. 
		/// <para>
		/// If the split button is in a dialog box, the user can select the split button by pressing the ENTER key, even when the split button does not have 
		/// the input focus. This style is useful for enabling the user to quickly select the most likely (default) option.
		/// </para>
		/// </summary>
		BS_DEFSPLITBUTTON		=  0x0000000DL,

		/// <summary>
		/// Specifies that the button is two-dimensional; it does not use the default shading to create a 3-D image. 
		/// </summary>
		BS_FLAT             		=  0x00008000L,

		/// <summary>
		/// Creates a rectangle in which other controls can be grouped. Any text associated with this style is displayed in the rectangle's upper left corner.
		/// </summary>
		BS_GROUPBOX         		=  0x00000007L,

		/// <summary>
		/// Specifies that the button displays an icon.
		/// </summary>
		BS_ICON             		=  0x00000040L,

		/// <summary>
		/// Left-justifies the text in the button rectangle. However, if the button is a check box or radio button that does not have the BS_RIGHTBUTTON style, 
		/// the text is left justified on the right side of the check box or radio button.
		/// </summary>
		BS_LEFT             		=  0x00000100L,

		/// <summary>
		/// Places text on the left side of the radio button or check box when combined with a radio button or check box style. Same as the BS_RIGHTBUTTON style.
		/// </summary>
		BS_LEFTTEXT         		=  0x00000020L,

		/// <summary>
		/// Wraps the button text to multiple lines if the text string is too long to fit on a single line in the button rectangle.
		/// </summary>
		BS_MULTILINE        		=  0x00002000L,

		/// <summary>
		/// Enables a button to send BN_KILLFOCUS and BN_SETFOCUS notification codes to its parent window. 
		/// <para>
		/// Note that buttons send the BN_CLICKED notification code regardless of whether it has this style. 
		/// </para>
		/// <para>
		/// To get BN_DBLCLK notification codes, the button must have the BS_RADIOBUTTON or BS_OWNERDRAW style.
		/// </para>
		/// </summary>
		BS_NOTIFY           		=  0x00004000L,

		/// <summary>
		/// Creates an owner-drawn button. The owner window receives a WM_DRAWITEM message when a visual aspect of the button has changed. 
		/// <para>
		/// Do not combine the BS_OWNERDRAW style with any other button styles.
		/// </para>
		/// </summary>
		BS_OWNERDRAW        		=  0x0000000BL,

		/// <summary>
		/// Creates a pushbox control.
		/// </summary>
		BS_PUSHBOX          		=  0x0000000AL,

		/// <summary>
		/// Creates a push button that posts a WM_COMMAND message to the owner window when the user selects the button.
		/// </summary>
		BS_PUSHBUTTON       		=  0x00000000L,

		/// <summary>
		/// Makes a button (such as a check box, three-state check box, or radio button) look and act like a push button. 
		/// <para>
		/// The button looks raised when it isn't pushed or checked, and sunken when it is pushed or checked.
		/// </para>
		/// </summary>
		BS_PUSHLIKE         		=  0x00001000L,

		/// <summary>
		/// Creates a small circle with text. By default, the text is displayed to the right of the circle. To display the text to the left of the circle, 
		/// combine this flag with the BS_LEFTTEXT style (or with the equivalent BS_RIGHTBUTTON style). 
		/// <para>
		/// Use radio buttons for groups of related, but mutually exclusive choices.
		/// </para>
		/// </summary>
		BS_RADIOBUTTON      		=  0x00000004L,

		/// <summary>
		/// Right-justifies text in the button rectangle. However, if the button is a check box or radio button that does not have the BS_RIGHTBUTTON style, 
		/// the text is right justified on the right side of the check box or radio button.
		/// </summary>
		BS_RIGHT            		=  0x00000200L,

		/// <summary>
		/// Positions a radio button's circle or a check box's square on the right side of the button rectangle. Same as the BS_LEFTTEXT style.
		/// </summary>
		BS_RIGHTBUTTON      		=  BS_LEFTTEXT,

		/// <summary>
		/// Windows Vista and Version 6.00. Creates a split button. A split button has a drop down arrow.
		/// </summary>
		BS_SPLITBUTTON			=  0x0000000CL,

		/// <summary>
		/// Specifies that the button displays text.
		/// </summary>
		BS_TEXT             		=  0x00000000L,

		/// <summary>
		/// Places text at the top of the button rectangle.
		/// </summary>
		BS_TOP              		=  0x00000400L,

		/// <summary>
		/// Windows 2000: A composite style bit that results from using the OR operator on BS_* style bits. 
		/// <para>
		/// It can be used to mask out valid BS_* bits from a given bitmask. Note that this is out of date and does not correctly include all valid styles. 
		/// Thus, you should not use this style.
		/// </para>
		/// </summary>
		BS_TYPEMASK         		=  0x0000000FL,

		/// <summary>
		/// Obsolete, but provided for compatibility with 16-bit versions of Windows. Applications should use BS_OWNERDRAW instead.
		/// </summary>
		BS_USERBUTTON       		=  0x00000008L,

		/// <summary>
		/// Places text in the middle (vertically) of the button rectangle.
		/// </summary>
		BS_VCENTER          		=  0x00000C00L,
		# endregion


		# region CBS_* : ComboBox styles
		/// <summary>
		/// Automatically scrolls the text in an edit control to the right when the user types a character at the end of the line. 
		/// <para>
		/// If this style is not set, only text that fits within the rectangular boundary is allowed.
		/// </para>
		/// </summary>
		CBS_AUTOHSCROLL       		=  0x0040L,

		/// <summary>
		/// Shows a disabled vertical scroll bar in the list box when the box does not contain enough items to scroll. 
		/// <para>
		/// Without this style, the scroll bar is hidden when the list box does not contain enough items.
		/// </para>
		/// </summary>
		CBS_DISABLENOSCROLL   		=  0x0800L,

		/// <summary>
		/// Similar to CBS_SIMPLE, except that the list box is not displayed unless the user selects an icon next to the edit control.
		/// </summary>
		CBS_DROPDOWN          		=  0x0002L,

		/// <summary>
		/// Similar to CBS_DROPDOWN, except that the edit control is replaced by a static text item that displays the current selection in the list box.
		/// </summary>
		CBS_DROPDOWNLIST      		=  0x0003L,

		/// <summary>
		/// Specifies that an owner-drawn combo box contains items consisting of strings. The combo box maintains the memory and address for the strings 
		/// so the application can use the CB_GETLBTEXT message to retrieve the text for a particular item.
		/// </summary>
		CBS_HASSTRINGS        		=  0x0200L,

		/// <summary>
		/// Converts to lowercase all text in both the selection field and the list. 
		/// </summary>
		CBS_LOWERCASE         		=  0x4000L,

		/// <summary>
		/// Specifies that the size of the combo box is exactly the size specified by the application when it created the combo box. 
		/// <para>
		/// Normally, the system sizes a combo box so that it does not display partial items.
		/// </para>
		/// </summary>
		CBS_NOINTEGRALHEIGHT  		=  0x0400L,

		/// <summary>
		/// Converts text entered in the combo box edit control from the Windows character set to the OEM character set and then back to the Windows character set. 
		/// <para>
		/// This ensures proper character conversion when the application calls the CharToOem function to convert a Windows string in the combo box to OEM characters. 
		/// </para>
		/// <para>
		/// This style is most useful for combo boxes that contain file names and applies only to combo boxes created with the CBS_SIMPLE or CBS_DROPDOWN style.
		/// </para>
		/// </summary>
		CBS_OEMCONVERT        		=  0x0080L,

		/// <summary>
		/// Specifies that the owner of the list box is responsible for drawing its contents and that the items in the list box are all the same height. 
		/// <para>
		/// The owner window receives a WM_MEASUREITEM message when the combo box is created and a WM_DRAWITEM message when a visual aspect of the combo box has changed.
		/// </para>
		/// </summary>
		CBS_OWNERDRAWFIXED    		=  0x0010L,

		/// <summary>
		/// Specifies that the owner of the list box is responsible for drawing its contents and that the items in the list box are variable in height. 
		/// <para>
		/// The owner window receives a WM_MEASUREITEM message for each item in the combo box when you create the combo box and a WM_DRAWITEM message when 
		/// a visual aspect of the combo box has changed.
		/// </para>
		/// </summary>
		CBS_OWNERDRAWVARIABLE 		=  0x0020L,

		/// <summary>
		/// Displays the list box at all times. The current selection in the list box is displayed in the edit control.
		/// </summary>
		CBS_SIMPLE            		=  0x0001L,

		/// <summary>
		/// Automatically sorts strings added to the list box.
		/// </summary>
		CBS_SORT              		=  0x0100L,

		/// <summary>
		/// Converts to uppercase all text in both the selection field and the list.
		/// </summary>
		CBS_UPPERCASE         		=  0x2000L,
		# endregion


		# region DS_* : Dialog box styles
		/// <summary>
		/// Obsolete. The system automatically applies the three-dimensional look to dialog boxes created by applications.
		/// </summary>
		DS_3DLOOK           		=  0x0004L,

		/// <summary>
		/// Indicates that the coordinates of the dialog box are screen coordinates. If this style is not specified, the coordinates are client coordinates.
		/// </summary>
		DS_ABSALIGN         		=  0x0001L,

		/// <summary>
		/// Centers the dialog box in the working area of the monitor that contains the owner window. 
		/// <para>
		/// If no owner window is specified, the dialog box is centered in the working area of a monitor determined by the system. 
		/// </para>
		/// <para>
		/// The working area is the area not obscured by the taskbar or any appbars.
		/// </para>
		/// </summary>
		DS_CENTER           		=  0x0800L,

		/// <summary>
		/// Centers the dialog box on the mouse cursor.
		/// </summary>
		DS_CENTERMOUSE      		=  0x1000L,

		/// <summary>
		/// Includes a question mark in the title bar of the dialog box. When the user clicks the question mark, the cursor changes to a question mark with a pointer. 
		/// <para>
		/// If the user then clicks a control in the dialog box, the control receives a WM_HELP message. The control should pass the message to the dialog box procedure, 
		/// which should call the function using the HELP_WM_HELP command. The help application displays a pop-up window that typically contains help for the control.
		/// </para>
		/// <para>
		/// Note that DS_CONTEXTHELP is only a placeholder. When the dialog box is created, the system checks for DS_CONTEXTHELP and, if it is there, adds 
		/// WS_EX_CONTEXTHELP to the extended style of the dialog box. WS_EX_CONTEXTHELP cannot be used with the WS_MAXIMIZEBOX or WS_MINIMIZEBOX styles.
		/// </para>
		/// </summary>
		DS_CONTEXTHELP      		=  0x2000L,

		/// <summary>
		/// Creates a dialog box that works well as a child window of another dialog box, much like a page in a property sheet. 
		/// <para>
		/// This style allows the user to tab among the control windows of a child dialog box, use its accelerator keys, and so on.
		/// </para>
		/// </summary>
		DS_CONTROL          		=  0x0400L,

		/// <summary>
		/// Causes the dialog box to use the SYSTEM_FIXED_FONT instead of the default SYSTEM_FONT. 
		/// <para>
		/// This is a monospace font compatible with the System font in 16-bit versions of Windows earlier than 3.0.
		/// </para>
		/// </summary>
		DS_FIXEDSYS         		=  0x0008L,

		/// <summary>
		/// Applies to 16-bit applications only. This style directs edit controls in the dialog box to allocate memory from the application's data segment. 
		/// Otherwise, edit controls allocate storage from a global memory object.
		/// </summary>
		DS_LOCALEDIT        		=  0x0020L,

		/// <summary>
		/// Creates a dialog box with a modal dialog-box frame that can be combined with a title bar and window menu by specifying the WS_CAPTION and WS_SYSMENU styles.
		/// </summary>
		DS_MODALFRAME       		=  0x0080L,

		/// <summary>
		/// Creates the dialog box even if errors occur — for example, if a child window cannot be created or if the system cannot create a special data segment 
		/// for an edit control.
		/// </summary>
		DS_NOFAILCREATE     		=  0x0010L,

		/// <summary>
		/// Suppresses WM_ENTERIDLE messages that the system would otherwise send to the owner of the dialog box while the dialog box is displayed.
		/// </summary>
		DS_NOIDLEMSG        		=  0x0100L,

		/// <summary>
		/// Indicates that the header of the dialog box template (either standard or extended) contains additional data specifying the font to use for text 
		/// in the client area and controls of the dialog box. If possible, the system selects a font according to the specified font data. 
		/// <para>
		/// The system passes a handle to the font to the dialog box and to each control by sending them the WM_SETFONT message. 
		/// </para>
		/// <para>
		/// For descriptions of the format of this font data, see DLGTEMPLATE and DLGTEMPLATEEX.
		/// </para>
		/// <para>
		/// If neither DS_SETFONT nor DS_SHELLFONT is specified, the dialog box template does not include the font data.
		/// </para>
		/// </summary>
		DS_SETFONT          		=  0x0040L,

		/// <summary>
		/// Causes the system to use the SetForegroundWindow function to bring the dialog box to the foreground. 
		/// <para>
		/// This style is useful for modal dialog boxes that require immediate attention from the user regardless of whether the owner window is the foreground window.
		/// The system restricts which processes can set the foreground window. For more information, see Foreground and Background Windows.
		/// </para>
		/// </summary>
		DS_SETFOREGROUND    		=  0x0200L,

		/// <summary>
		/// Indicates that the dialog box should use the system font. The typeface member of the extended dialog box template must be set to MS Shell Dlg. 
		/// Otherwise, this style has no effect. It is also recommended that you use the DIALOGEX Resource, rather than the DIALOG Resource.
		/// <para>
		/// The system selects a font using the font data specified in the pointsize, weight, and italic members. 
		/// </para>
		/// <para>
		/// The system passes a handle to the font to the dialog box and to each control by sending them the WM_SETFONT message.
		/// </para>
		/// <para>
		/// If neither DS_SHELLFONT nor DS_SETFONT is specified, the extended dialog box template does not include the font data.
		/// </para>
		/// </summary>
		DS_SHELLFONT        		=  ( DS_SETFONT | DS_FIXEDSYS ),

		/// <summary>
		/// This style is obsolete and is included for compatibility with 16-bit versions of Windows. 
		/// <para>
		/// If you specify this style, the system creates the dialog box with the WS_EX_TOPMOST style. 
		/// This style does not prevent the user from accessing other windows on the desktop.
		/// </para>
		/// <para>
		/// Do not combine this style with the DS_CONTROL style.
		/// </para>
		/// </summary>
		DS_SYSMODAL         		=  0x0002L,

		/// <summary>
		/// Undocumented.
		/// </summary>
		DS_USEPIXELS        		=  0x8000L,
		# endregion


		# region ES_* : Edit control styles
		/// <summary>
		/// Automatically scrolls text to the right by 10 characters when the user types a character at the end of the line. 
		/// When the user presses the ENTER key, the control scrolls all text back to position zero.
		/// </summary>
		ES_AUTOHSCROLL	    	=  0x0080L,

		/// <summary>
		/// Automatically scrolls text up one page when the user presses the ENTER key on the last line.
		/// </summary>
		ES_AUTOVSCROLL      	=  0x0040L,

		/// <summary>
		/// Centers text in a single-line or multiline edit control.
		/// </summary>
		ES_CENTER           	=  0x0001L,

		/// <summary>
		/// Aligns text with the left margin.
		/// </summary>
		ES_LEFT             	=  0x0000L,

		/// <summary>
		/// Converts all characters to lowercase as they are typed into the edit control.
		/// To change this style after the control has been created, use SetWindowLong.
		/// </summary>
		ES_LOWERCASE        	=  0x0010L,

		/// <summary>
		/// Designates a multiline edit control. The default is single-line edit control. 
		/// When the multiline edit control is in a dialog box, the default response to pressing the ENTER key is to activate the default button. 
		/// <para>
		/// To use the ENTER key as a carriage return, use the ES_WANTRETURN style.
		/// </para>
		/// <para>
		/// When the multiline edit control is not in a dialog box and the ES_AUTOVSCROLL style is specified, the edit control shows as many lines 
		/// as possible and scrolls vertically when the user presses the ENTER key. If you do not specify ES_AUTOVSCROLL, the edit control shows as many lines 
		/// as possible and beeps if the user presses the ENTER key when no more lines can be displayed.
		/// </para>
		/// <para>
		/// If you specify the ES_AUTOHSCROLL style, the multiline edit control automatically scrolls horizontally when the caret goes past 
		/// the right edge of the control. To start a new line, the user must press the ENTER key. 
		/// </para>
		/// <para>
		/// If you do not specify ES_AUTOHSCROLL, the control automatically wraps words to the beginning of the next line when necessary. 
		/// A new line is also started if the user presses the ENTER key. The window size determines the position of the Wordwrap. 
		/// </para>
		/// <para>
		/// If the window size changes, the Wordwrapping position changes and the text is redisplayed.
		/// </para>
		/// <para>
		/// Multiline edit controls can have scroll bars. An edit control with scroll bars processes its own scroll bar messages. 
		/// </para>
		/// <para>
		/// Note that edit controls without scroll bars scroll as described in the previous paragraphs and process any scroll messages sent by the parent window.
		/// </para>
		/// </summary>
		ES_MULTILINE        	=  0x0004L,

		/// <summary>
		/// Negates the default behavior for an edit control. 
		/// <para>
		/// The default behavior hides the selection when the control loses the input focus and inverts the selection when the control receives the input focus. 
		/// </para>
		/// <para>
		/// If you specify ES_NOHIDESEL, the selected text is inverted, even if the control does not have the focus.
		/// </para>
		/// </summary>
		ES_NOHIDESEL        	=  0x0100L,

		/// <summary>
		/// Allows only digits to be entered into the edit control. Note that, even with this set, it is still possible to paste non-digits into the edit control. 
		/// To change this style after the control has been created, use SetWindowLong.
		/// <para>
		/// To translate text that was entered into the edit control to an integer value, use the GetDlgItemInt function. 
		/// </para>
		/// <para>
		/// To set the text of the edit control to the string representation of a specified integer, use the SetDlgItemInt function.
		/// </para>
		/// </summary>
		ES_NUMBER           	=  0x2000L,

		/// <summary>
		/// Converts text entered in the edit control. The text is converted from the Windows character set to the OEM character set and then back 
		/// to the Windows character set. This ensures proper character conversion when the application calls the CharToOem function to convert a Windows string 
		/// in the edit control to OEM characters. This style is most useful for edit controls that contain file names that will be used on file systems that do not 
		/// support Unicode. 
		/// <para>
		/// To change this style after the control has been created, use SetWindowLong. 
		/// </para>
		/// </summary>
		ES_OEMCONVERT       	=  0x0400L,

		/// <summary>
		/// Displays an asterisk (*) for each character typed into the edit control. This style is valid only for single-line edit controls. 
		/// <para>
		/// Windows XP: If the edit control is from user32.dll, the default password character is an asterisk. However, if the edit control is from comctl32.dll version 6, 
		/// the default character is a black circle. 
		/// </para>
		/// <para>
		/// To change the characters that is displayed, or set or clear this style, use the EM_SETPASSWORDCHAR message. 
		/// </para>
		/// <para>
		/// Note : Comctl32.dll version 6 is not redistributable but it is included in Windows XP or later. To use Comctl32.dll version 6, specify it in a manifest. 
		/// </para>
		/// </summary>
		ES_PASSWORD         	=  0x0020L,

		/// <summary>
		/// Prevents the user from typing or editing text in the edit control.
		/// <para>
		/// To change this style after the control has been created, use the EM_SETREADONLY message. 
		/// </para>
		/// </summary>
		ES_READONLY         	=  0x0800L,

		/// <summary>
		/// Right-aligns text in a single-line or multiline edit control.
		/// </summary>
		ES_RIGHT            	=  0x0002L,

		/// <summary>
		/// Converts all characters to uppercase as they are typed into the edit control. 
		/// <para>
		/// To change this style after the control has been created, use SetWindowLong.
		/// </para>
		/// </summary>
		ES_UPPERCASE        	=  0x0008L,

		/// <summary>
		/// Specifies that a carriage return be inserted when the user presses the ENTER key while entering text into a multiline edit control in a dialog box. 
		/// <para>
		/// If you do not specify this style, pressing the ENTER key has the same effect as pressing the dialog box's default push button. 
		/// This style has no effect on a single-line edit control. 
		/// </para>
		/// <para>
		/// To change this style after the control has been created, use SetWindowLong.
		/// </para>
		/// </summary>
		ES_WANTRETURN       	=  0x1000L,
		# endregion


		# region LBS_* : Listbox styles
		/// <summary>
		/// Notifies a list box that it is part of a combo box. 
		/// <para>
		/// This allows coordination between the two controls so that they present a unified UI. 
		/// </para>
		/// <para>
		/// The combo box itself must set this style. If the style is set by anything but the combo box, the list box will regard itself incorrectly as a child 
		/// of a combo box and a failure will result.
		/// </para>
		/// </summary>
		LBS_COMBOBOX			=  0x8000L,

		/// <summary>
		/// Shows a disabled horizontal or vertical scroll bar when the list box does not contain enough items to scroll. 
		/// <para>
		/// If you do not specify this style, the scroll bar is hidden when the list box does not contain enough items. 
		/// </para>
		/// <para>
		/// This style must be used with the WS_VSCROLL or WS_HSCROLL style.
		/// </para>
		/// </summary>
		LBS_DISABLENOSCROLL   		=  0x1000L,

		/// <summary>
		/// Allows multiple items to be selected by using the SHIFT key and the mouse or special key combinations.
		/// </summary>
		LBS_EXTENDEDSEL       		=  0x0800L,

		/// <summary>
		/// Specifies that a list box contains items consisting of strings. The list box maintains the memory and addresses for the strings so that 
		/// the application can use the LB_GETTEXT message to retrieve the text for a particular item. 
		/// <para>
		//  By default, all list boxes except owner-drawn list boxes have this style. You can create an owner-drawn list box either with or without this style.
		/// </para>
		/// <para>
		/// For owner-drawn list boxes without this style, the LB_GETTEXT message retrieves the value associated with an item (the item data). 
		/// </para>
		/// </summary>
		LBS_HASSTRINGS        		=  0x0040L,

		/// <summary>
		/// Specifies a multi-column list box that is scrolled horizontally. 
		/// <para>
		/// The list box automatically calculates the width of the columns, or an application can set the width by using the LB_SETCOLUMNWIDTH message. 
		/// </para>
		/// <para>
		/// If a list box has the LBS_OWNERDRAWFIXED style, an application can set the width when the list box sends the WM_MEASUREITEM message. 
		/// </para>
		/// <para>
		/// A list box with the LBS_MULTICOLUMN style cannot scroll vertically—it ignores any WM_VSCROLL messages it receives.
		/// The LBS_MULTICOLUMN and LBS_OWNERDRAWVARIABLE styles cannot be combined. If both are specified, LBS_OWNERDRAWVARIABLE is ignored.
		/// </para>
		/// </summary>
		LBS_MULTICOLUMN       		=  0x0200L,

		/// <summary>
		/// Turns string selection on or off each time the user clicks or double-clicks a string in the list box. The user can select any number of strings.
		/// </summary>
		LBS_MULTIPLESEL       		=  0x0008L,

		/// <summary>
		/// Specifies a no-data list box. Specify this style when the count of items in the list box will exceed one thousand. 
		/// <para>
		/// A no-data list box resembles an owner-drawn list box except that it contains no string or bitmap data for an item. 
		/// </para>
		/// <para>
		/// A no-data list box resembles an owner-drawn list box except that it contains no string or bitmap data for an item. 
		/// </para>
		/// <para>
		/// Commands to add, insert, or delete an item always ignore any specified item data; requests to find a string within the list box always fail. 
		/// </para>
		/// <para>
		/// The system sends the WM_DRAWITEM message to the owner window when an item must be drawn. The itemID member of the DRAWITEMSTRUCT structure 
		/// passed with the WM_DRAWITEM message specifies the line number of the item to be drawn. A no-data list box does not send a WM_DELETEITEM message.
		/// </para>
		/// </summary>
		LBS_NODATA            		=  0x2000L,

		/// <summary>
		/// Specifies that the size of the list box is exactly the size specified by the application when it created the list box. 
		/// Normally, the system sizes a list box so that the list box does not display partial items.
		/// <para>
		/// For list boxes with the LBS_OWNERDRAWVARIABLE style, the LBS_NOINTEGRALHEIGHT style is always enforced.
		/// </para>
		/// </summary>
		LBS_NOINTEGRALHEIGHT  		=  0x0100L,

		/// <summary>
		/// Specifies that the list box's appearance is not updated when changes are made.
		/// <para>
		/// To change the redraw state of the control, use the WM_SETREDRAW message.
		/// </para>
		/// </summary>
		LBS_NOREDRAW          		=  0x0004L,

		/// <summary>
		/// Specifies that the list box contains items that can be viewed but not selected. 
		/// </summary>
		LBS_NOSEL             		=  0x4000L,

		/// <summary>
		/// Causes the list box to send a notification code to the parent window whenever the user clicks a list box item (LBN_SELCHANGE), 
		/// double-clicks an item (LBN_DBLCLK), or cancels the selection (LBN_SELCANCEL). 
		/// </summary>
		LBS_NOTIFY            		=  0x0001L,

		/// <summary>
		/// Specifies that the owner of the list box is responsible for drawing its contents and that the items in the list box are the same height. 
		/// <para>
		/// The owner window receives a WM_MEASUREITEM message when the list box is created and a WM_DRAWITEM message when a visual aspect of the list box has changed.
		/// </para>
		/// </summary>
		LBS_OWNERDRAWFIXED    		=  0x0010L,

		/// <summary>
		/// Specifies that the owner of the list box is responsible for drawing its contents and that the items in the list box are variable in height. 
		/// <para>
		/// The owner window receives a WM_MEASUREITEM message for each item in the box when the list box is created and a WM_DRAWITEM message when 
		/// a visual aspect of the list box has changed.
		/// </para>
		/// <para>
		/// This style causes the LBS_NOINTEGRALHEIGHT style to be enabled.
		/// </para>
		/// <para>
		/// This style is ignored if the LBS_MULTICOLUMN style is specified. 
		/// </para>
		/// </summary>
		LBS_OWNERDRAWVARIABLE 		=  0x0020L,

		/// <summary>
		/// Sorts strings in the list box alphabetically.
		/// </summary>
		LBS_SORT              		=  0x0002L,

		/// <summary>
		/// Sorts strings in the list box alphabetically. The parent window receives a notification code whenever the user clicks a list box item, 
		/// double-clicks an item, or or cancels the selection. The list box has a vertical scroll bar, and it has borders on all sides. 
		/// <para>
		/// This style combines the LBS_NOTIFY, LBS_SORT, WS_VSCROLL, and WS_BORDER styles.
		/// </para>
		/// </summary>
		LBS_STANDARD          		=  (LBS_NOTIFY | LBS_SORT | WS_VSCROLL | WS_BORDER),

		/// <summary>
		/// Enables a list box to recognize and expand tab characters when drawing its strings. You can use the LB_SETTABSTOPS message to specify tab stop positions. 
		/// The default tab positions are 32 dialog template units apart. Dialog template units are the device-independent units used in dialog box templates. 
		/// <para>
		/// To convert measurements from dialog template units to screen units (pixels), use the MapDialogRect function.
		/// </para>
		/// </summary>
		LBS_USETABSTOPS       		=  0x0080L,

		/// <summary>
		/// Specifies that the owner of the list box receives WM_VKEYTOITEM messages whenever the user presses a key and the list box has the input focus. 
		/// <para>
		/// This enables an application to perform special processing on the keyboard input.
		/// </para>
		/// </summary>
		LBS_WANTKEYBOARDINPUT 		=  0x0400L,
		# endregion


		# region MDIS_* : MDI window styles
		/// <summary>
		/// Indicates that the MDI child can have all the WS_ style bits.
		/// <para>
		/// If not specified, the MDI child can only have the WS_MINIMIZE, WS_MAXIMIZE, WS_HSCROLL and WS_VSCROLL style bits.
		/// </para>
		/// </summary>
		MDIS_ALL_CHILD_STYLES		=  0x00000001L,
		# endregion


		# region SBS_* : Scrollbar styles
		/// <summary>
		/// Aligns the bottom edge of the scroll bar with the bottom edge of the rectangle defined by the x, y, nWidth, and nHeight parameters of CreateWindowEx function.
		/// <para>
		/// The scroll bar has the default height for system scroll bars. Use this style with the SBS_HORZ style.
		/// </para>
		/// </summary>
		SBS_BOTTOMALIGN				=  0x0004L,

		/// <summary>
		/// Designates a horizontal scroll bar. If neither the SBS_BOTTOMALIGN nor SBS_TOPALIGN style is specified, the scroll bar has the height, width, and 
		/// position specified by the x, y, nWidth, and nHeight parameters of CreateWindowEx.
		/// </summary>
		SBS_HORZ				=  0x0000L,

		/// <summary>
		/// Aligns the left edge of the scroll bar with the left edge of the rectangle defined by the x, y, nWidth, and nHeight parameters of CreateWindowEx. 
		/// <para>
		/// The scroll bar has the default width for system scroll bars. Use this style with the SBS_VERT style.
		/// </para>
		/// </summary>
		SBS_LEFTALIGN				=  0x0002L,

		/// <summary>
		/// Aligns the right edge of the scroll bar with the right edge of the rectangle defined by the x, y, nWidth, and nHeight parameters of CreateWindowEx. 
		/// The scroll bar has the default width for system scroll bars. Use this style with the SBS_VERT style.
		/// </summary>
		SBS_RIGHTALIGN				=  0x0004L,

		/// <summary>
		/// Designates a size box. If you specify neither the SBS_SIZEBOXBOTTOMRIGHTALIGN nor the SBS_SIZEBOXTOPLEFTALIGN style, the size box has the height, 
		/// width, and position specified by the x, y, nWidth, and nHeight parameters of CreateWindowEx. 
		/// </summary>
		SBS_SIZEBOX				=  0x0008L,

		/// <summary>
		/// Aligns the lower right corner of the size box with the lower right corner of the rectangle specified by the x, y, nWidth, and nHeight parameters of CreateWindowEx.
		/// <para>
		/// The size box has the default size for system size boxes. Use this style with the SBS_SIZEBOX style.
		/// </para>
		/// </summary>
		SBS_SIZEBOXBOTTOMRIGHTALIGN		=  0x0004L,

		/// <summary>
		/// Aligns the upper left corner of the size box with the upper left corner of the rectangle specified by the x, y, nWidth, and nHeight parameters of CreateWindowEx.
		/// <para>
		/// The size box has the default size for system size boxes. Use this style with the SBS_SIZEBOX style.
		/// </para>
		/// </summary>
		SBS_SIZEBOXTOPLEFTALIGN			=  0x0002L,

		/// <summary>
		/// Same as SBS_SIZEBOX, but with a raised edge. 
		/// </summary>
		SBS_SIZEGRIP				=  0x0010L,

		/// <summary>
		/// Aligns the top edge of the scroll bar with the top edge of the rectangle defined by the x, y, nWidth, and nHeight parameters of CreateWindowEx. 
		/// <para>
		/// The scroll bar has the default height for system scroll bars. Use this style with the SBS_HORZ style.
		/// </para>
		/// </summary>
		SBS_TOPALIGN				=  0x0002L,

		/// <summary>
		/// Designates a vertical scroll bar. If you specify neither the SBS_RIGHTALIGN nor the SBS_LEFTALIGN style, the scroll bar has the height, width, 
		/// and position specified by the x, y, nWidth, and nHeight parameters of CreateWindowEx.
		/// </summary>
		SBS_VERT				=  0x0001L,
		# endregion


		# region SS_* window styles
		/// <summary>
		/// A bitmap is to be displayed in the static control. The text is the name of a bitmap (not a filename) defined elsewhere in the resource file. 
		/// <para>
		/// The style ignores the nWidth and nHeight parameters; the control automatically sizes itself to accommodate the bitmap.
		/// </para>
		/// </summary>
		SS_BITMAP           		=  0x0000000EL,

		/// <summary>
		/// A box with a frame drawn in the same color as the window frames. This color is black in the default color scheme.
		/// </summary>
		SS_BLACKFRAME       		=  0x00000007L,

		/// <summary>
		/// A rectangle filled with the current window frame color. This color is black in the default color scheme.
		/// </summary>
		SS_BLACKRECT        		=  0x00000004L,

		/// <summary>
		/// A simple rectangle and centers the text in the rectangle. The text is formatted before it is displayed. 
		/// Words that extend past the end of a line are automatically wrapped to the beginning of the next centered line. 
		/// Words that are longer than the width of the control are truncated.
		/// </summary>
		SS_CENTER           		=  0x00000001L,

		/// <summary>
		/// A bitmap is centered in the static control that contains it. The control is not resized, so that a bitmap too large for the control will be clipped.
		/// <para>
		/// If the static control contains a single line of text, the text is centered vertically in the client area of the control.
		/// </para>
		/// <para>
		/// As of Windows XP, this style bit no longer results in unused portions of the control being filled with the color of the top left pixel of the bitmap or icon. 
		/// </para>
		/// <para>
		/// Unused portions of the control will remain the background color.
		/// </para>
		/// </summary>
		SS_CENTERIMAGE      		=  0x00000200L,

		/// <summary>
		/// The static control duplicates the text-displaying characteristics of a multiline edit control. Specifically, the average character width is calculated 
		/// in the same manner as with an edit control, and the function does not display a partially visible last line.
		/// </summary>
		SS_EDITCONTROL      		=  0x00002000L,

		/// <summary>
		/// Masks for any option associated with ellipsis handling.
		/// </summary>
		SS_ELLIPSISMASK     		=  0x0000C000L,

		/// <summary>
		/// If the end of a string does not fit in the rectangle, it is truncated and ellipses are added. 
		/// <para>
		/// If a word that is not at the end of the string goes beyond the limits of the rectangle, it is truncated without ellipses. 
		/// </para>
		/// <para>
		/// Using this style will force the control’s text to be on one line with no word wrap. Compare with SS_PATHELLIPSIS and SS_WORDELLIPSIS.
		/// </para>
		/// </summary>
		SS_ENDELLIPSIS      		=  0x00004000L,

		/// <summary>
		/// An enhanced metafile is to be displayed in the static control. The text is the name of a metafile. 
		/// <para>
		/// An enhanced metafile static control has a fixed size; the metafile is scaled to fit the static control's client area.
		/// </para>
		/// </summary>
		SS_ENHMETAFILE      		=  0x0000000FL,

		/// <summary>
		/// Draws the frame of the static control using the EDGE_ETCHED edge style. For more information, see the DrawEdge function.
		/// </summary>
		SS_ETCHEDFRAME      		=  0x00000012L,

		/// <summary>
		/// Draws the top and bottom edges of the static control using the EDGE_ETCHED edge style. For more information, see the DrawEdge function.
		/// </summary>
		SS_ETCHEDHORZ       		=  0x00000010L,

		/// <summary>
		/// Draws the left and right edges of the static control using the EDGE_ETCHED edge style. For more information, see the DrawEdge function.
		/// </summary>
		SS_ETCHEDVERT       		=  0x00000011L,

		/// <summary>
		/// A box with a frame drawn with the same color as the screen background (desktop). This color is gray in the default color scheme.
		/// </summary>
		SS_GRAYFRAME        		=  0x00000008L,

		/// <summary>
		/// A rectangle filled with the current screen background color. This color is gray in the default color scheme.
		/// </summary>
		SS_GRAYRECT         		=  0x00000005L,

		/// <summary>
		/// An icon to be displayed in the dialog box. If the control is created as part of a dialog box, the text is the name of an icon (not a filename) 
		/// defined elsewhere in the resource file. If the control is created via CreateWindow or a related function, the text is the name of an icon 
		/// (not a filename) defined in the resource file associated with the module specified by the hInstance parameter to CreateWindow. 
		/// <para>
		/// The icon can be an animated cursor. 
		/// </para>
		/// <para>
		/// The style ignores the CreateWindow parameters nWidth and nHeight; the control automatically sizes itself to accommodate the icon. 
		/// As it uses the LoadIcon function, the SS_ICON style can load only icons of dimensions SM_CXICON and SM_CYICON. 
		/// This restriction can be bypassed by using the SS_REALSIZEIMAGE style in addition to SS_ICON. 
		/// </para>
		/// <para>
		/// If an icon cannot be loaded through LoadIcon, an attempt is made to load the specified resource as a cursor using LoadCursor. 
		/// </para>
		/// <para>
		/// If that too fails, an attempt is made to load from the device driver using LoadImage.
		/// </para>
		/// </summary>
		SS_ICON             		=  0x00000003L,

		/// <summary>
		/// A simple rectangle and left-aligns the text in the rectangle. The text is formatted before it is displayed. 
		/// <para>
		/// Words that extend past the end of a line are automatically wrapped to the beginning of the next left-aligned line. 
		/// Words that are longer than the width of the control are truncated.
		/// </para>
		/// </summary>
		SS_LEFT             		=  0x00000000L,

		/// <summary>
		/// A simple rectangle and left-aligns the text in the rectangle. Tabs are expanded, but words are not wrapped. 
		/// Text that extends past the end of a line is clipped.
		/// </summary>
		SS_LEFTNOWORDWRAP   		=  0x0000000CL,

		/// <summary>
		/// Prevents interpretation of any ampersand (&) characters in the control's text as accelerator prefix characters. 
		/// These are displayed with the ampersand removed and the next character in the string underlined. 
		/// <para>
		/// This static control style may be included with any of the defined static controls. You can combine SS_NOPREFIX with other styles. 
		/// This can be useful when filenames or other strings that may contain an ampersand (&) must be displayed in a static control in a dialog box.
		/// </para>
		/// </summary>
		SS_NOPREFIX         		=  0x00000080L,

		/// <summary>
		/// Sends the parent window STN_CLICKED, STN_DBLCLK, STN_DISABLE, and STN_ENABLE notification codes when the user clicks or double-clicks the control.
		/// </summary>
		SS_NOTIFY           		=  0x00000100L,

		/// <summary>
		/// The owner of the static control is responsible for drawing the control. The owner window receives a WM_DRAWITEM message whenever the control needs to be drawn.
		/// </summary>
		SS_OWNERDRAW        		=  0x0000000DL,

		/// <summary>
		/// Replaces characters in the middle of the string with ellipses so that the result fits in the specified rectangle. 
		/// <para>
		/// If the string contains backslash (\) characters, SS_PATHELLIPSIS preserves as much as possible of the text after the last backslash. 
		/// </para>
		/// <para>
		/// Using this style will force the control’s text to be on one line with no word wrap. Compare with SS_ENDELLIPSIS and SS_WORDELLIPSIS.
		/// </para>
		/// </summary>
		SS_PATHELLIPSIS     		=  0x00008000L,

		/// <summary>
		/// Adjusts the bitmap to fit the size of the static control. For example, changing the locale can change the system font, and thus controls might be resized. 
		/// If a static control had a bitmap, the bitmap would no longer fit the control. This style bit dictates automatic redimensioning of bitmaps to fit their controls.
		/// <para>
		/// If SS_CENTERIMAGE is specified, the bitmap or icon is centered (and clipped if needed). If SS_CENTERIMAGE is not specified, the bitmap or icon is stretched 
		/// or shrunk. Note that the redimensioning in the two axes are independent, and the result may have a changed aspect ratio. 
		/// </para>
		/// </summary>
		SS_REALSIZECONTROL  		=  0x00000040L,

		/// <summary>
		/// Specifies that the actual resource width is used and the icon is loaded using LoadImage. SS_REALSIZEIMAGE is always used in conjunction with SS_ICON. 
		/// SS_REALSIZEIMAGE uses LoadImage, overriding the process normally followed under SS_ICON. It does not load cursors; 
		/// if LoadImage fails, no further attempts to load are made. It uses the actual resource width. The static control is resized accordingly, 
		/// but the icon remains aligned to the originally specified left and top edges of the control.
		/// <para>
		/// Note that if SS_CENTERIMAGE is also specified, the icon is centered within the control's space, which was specified using the CreateWindow parameters nWidth and nHeight.
		/// </para>
		/// </summary>
		SS_REALSIZEIMAGE    		=  0x00000800L,

		/// <summary>
		/// A simple rectangle and right-aligns the text in the rectangle. The text is formatted before it is displayed. 
		/// <para>
		/// Words that extend past the end of a line are automatically wrapped to the beginning of the next right-aligned line. 
		/// Words that are longer than the width of the control are truncated.
		/// </para>
		/// </summary>
		SS_RIGHT            		=  0x00000002L,

		/// <summary>
		/// The lower right corner of a static control with the SS_BITMAP or SS_ICON style is to remain fixed when the control is resized. 
		/// Only the top and left sides are adjusted to accommodate a new bitmap or icon.
		/// </summary>
		SS_RIGHTJUST        		=  0x00000400L,

		/// <summary>
		/// A simple rectangle and displays a single line of left-aligned text in the rectangle. The text line cannot be shortened or altered in any way. 
		/// Also, if the control is disabled, the control does not gray its text.
		/// </summary>
		SS_SIMPLE           		=  0x0000000BL,

		/// <summary>
		/// Draws a half-sunken border around a static control.
		/// </summary>
		SS_SUNKEN           		=  0x00001000L,

		/// <summary>
		/// A composite style bit that results from using the OR operator on SS_* style bits. Can be used to mask out valid SS_* bits from a given bitmask. 
		/// <para>
		/// Note that this is out of date and does not correctly include all valid styles. Thus, you should not use this style.
		/// </para>
		/// </summary>
		SS_TYPEMASK         		=  0x0000001FL,

		/// <summary>
		/// Specifies a user-defined item.
		/// </summary>
		SS_USERITEM         		=  0x0000000AL,

		/// <summary>
		/// A box with a frame drawn with the same color as the window background. This color is white in the default color scheme.
		/// </summary>
		SS_WHITEFRAME       		=  0x00000009L,

		/// <summary>
		/// A rectangle filled with the current window background color. This color is white in the default color scheme.
		/// </summary>
		SS_WHITERECT        		=  0x00000006L,

		/// <summary>
		/// Truncates any word that does not fit in the rectangle and adds ellipses. Using this style will force the control’s text to be on one line with no word wrap. 
		/// <para>
		/// Compare with SS_ENDELLIPSIS and SS_PATHELLIPSIS.
		/// </para>
		/// </summary>
		SS_WORDELLIPSIS     		=  0x0000C000L,
		# endregion


		# region WS_* : Window styles
		/// <summary>
		/// The window has a thin-line border.
		/// </summary>
		WS_BORDER			=  0x00800000L,

		/// <summary>
		/// The window has a title bar (includes the WS_BORDER style).
		/// </summary>
		WS_CAPTION			=  WS_BORDER |  WS_DLGFRAME,

		/// <summary>
		/// The window is a child window. A window with this style cannot have a menu bar. This style cannot be used with the WS_POPUP style.
		/// </summary>
		WS_CHILD			=  0x40000000L,

		/// <summary>
		/// Same as the WS_CHILD style.
		/// </summary>
		WS_CHILDWINDOW			=  WS_CHILD, 

		/// <summary>
		/// Excludes the area occupied by child windows when drawing occurs within the parent window. 
		/// This style is used when creating the parent window.
		/// </summary>
		WS_CLIPCHILDREN			=  0x02000000L,

		/// <summary>
		/// Clips child windows relative to each other; that is, when a particular child window receives a WM_PAINT message, 
		/// the WS_CLIPSIBLINGS style clips all other overlapping child windows out of the region of the child window to be updated. 
		/// <para>
		/// If WS_CLIPSIBLINGS is not specified and child windows overlap, it is possible, when drawing within the client area of a child window, 
		/// to draw within the client area of a neighboring child window.
		/// </para>
		/// </summary>
		WS_CLIPSIBLINGS			=  0x04000000L,

		/// <summary>
		/// The window is initially disabled. A disabled window cannot receive input from the user. 
		/// To change this after a window has been created, use the EnableWindow function.
		/// </summary>
		WS_DISABLED			=  0x08000000L, 

		/// <summary>
		/// The window has a border of a style typically used with dialog boxes. A window with this style cannot have a title bar.
		/// </summary>
		WS_DLGFRAME			=  0x00400000L,

		/// <summary>
		/// The window is the first control of a group of controls. The group consists of this first control and all controls defined after it, 
		/// up to the next control with the WS_GROUP style. 
		/// <para>
		/// The first control in each group usually has the WS_TABSTOP style so that the user can move from group to group. 
		/// The user can subsequently change the keyboard focus from one control in the group to the next control in the group by using the direction keys.
		/// </para>
		/// <para>
		/// You can turn this style on and off to change dialog box navigation. To change this style after a window has been created, use the SetWindowLong function.
		/// </para>
		/// </summary>
		WS_GROUP			=  0x00020000L,

		/// <summary>
		/// The window has a horizontal scroll bar.
		/// </summary>
		WS_HSCROLL			=  0x00100000L,

		/// <summary>
		/// The window is initially minimized. Same as the WS_MINIMIZE style.
		/// </summary>
		WS_ICONIC			=  WS_MINIMIZE,

		/// <summary>
		/// The window is initially maximized.
		/// </summary>
		WS_MAXIMIZE			=  0x01000000L,

		/// <summary>
		/// The window has a maximize button. Cannot be combined with the WS_EX_CONTEXTHELP style. 
		/// The WS_SYSMENU style must also be specified. 
		/// </summary>
		WS_MAXIMIZEBOX			=  0x00010000L,

		/// <summary>
		/// The window is initially minimized. Same as the WS_ICONIC style.
		/// </summary>
		WS_MINIMIZE			=  0x20000000L,

		/// <summary>
		/// The window has a minimize button. Cannot be combined with the WS_EX_CONTEXTHELP style. 
		/// The WS_SYSMENU style must also be specified. 
		/// </summary>
		WS_MINIMIZEBOX			=  0x00020000L,

		/// <summary>
		/// The window is an overlapped window. An overlapped window has a title bar and a border. 
		/// Same as the WS_TILED style.
		/// </summary>
		WS_OVERLAPPED			=  0x00000000L,

		/// <summary>
		/// The window is an overlapped window. Same as the WS_TILEDWINDOW style. 
		/// </summary>
		WS_OVERLAPPED_WINDOW		=  WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,

		/// <summary>
		/// The windows is a pop-up window. This style cannot be used with the WS_CHILD style.
		/// </summary>
		WS_POPUP			=  0x80000000L,

		/// <summary>
		/// The window is a pop-up window. The WS_CAPTION and WS_POPUPWINDOW styles must be combined to make the window menu visible.
		/// </summary>
		WS_POPUPWINDOW			=  WS_POPUP | WS_BORDER | WS_SYSMENU,

		/// <summary>
		/// The window has a sizing border. Same as the WS_THICKFRAME style.
		/// </summary>
		WS_SIZEBOX			=  0x00040000L,

		/// <summary>
		/// The window has a window menu on its title bar. The WS_CAPTION style must also be specified.
		/// </summary>
		WS_SYSMENU			=  0x00080000L,

		/// <summary>
		/// The window is a control that can receive the keyboard focus when the user presses the TAB key. 
		/// <para>
		/// Pressing the TAB key changes the keyboard focus to the next control with the WS_TABSTOP style.
		/// </para>
		/// <para>
		/// You can turn this style on and off to change dialog box navigation. To change this style after a window has been created, use the SetWindowLong function. 
		/// </para>
		/// <para>
		/// For user-created windows and modeless dialogs to work with tab stops, alter the message loop to call the IsDialogMessage function.
		/// </para>
		/// </summary>
		WS_TABSTOP			=  0x00010000L,

		/// <summary>
		/// The window has a sizing border. Same as the WS_SIZEBOX style.
		/// </summary>
		WS_THICKFRAME			=  WS_SIZEBOX,

		/// <summary>
		/// The window is an overlapped window. An overlapped window has a title bar and a border. 
		/// Same as the WS_OVERLAPPED style.
		/// </summary>
		WS_TILED			=  WS_OVERLAPPED,

		/// <summary>
		/// The window is an overlapped window. Same as the WS_OVERLAPPED_WINDOW style. 
		/// </summary>
		WS_TILEDWINDOW			=  WS_OVERLAPPED_WINDOW,

		/// <summary>
		/// The window is initially visible.
		/// <para>
		/// This style can be turned on and off by using the ShowWindow or SetWindowPos function.
		/// </para>
		/// </summary>
		WS_VISIBLE			=  0x10000000L,

		/// <summary>
		/// The window has a vertical scroll bar.
		/// </summary>
		WS_VSCROLL			=  0x00200000L,
		# endregion


		/// <summary>
		/// Zero value.
		/// </summary>
		WS_NONE				=  0x00000000L		// Appears at the end so that preceding value definitions can end with a trailing comma

	    }
	# endregion
    }