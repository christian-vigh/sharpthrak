/**************************************************************************************************************

    NAME
        WinAPI/Constants/C/CBN.cs

    DESCRIPTION
        Combobox notification messages.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region CBN_ notification messages.
	/// <summary>
	/// Notification messages from combo boxes.
	/// </summary>
	public enum CBN_Constants		:  int
	   {
		/// <summary>
		/// Sent when the list box of a combo box has been closed.
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// If the user changed the current selection, the combo box also sends the CBN_SELCHANGE notification code when the drop-down list closes. 
		/// In general, you cannot predict the order in which notification codes will be sent. 
		/// In particular, a CBN_SELCHANGE notification code may occur either before or after a CBN_CLOSEUP notification code. 
		/// <para>
		/// To execute a specific process each time the user selects a list item, you can handle either the CBN_SELCHANGE or CBN_CLOSEUP notification code. 
		/// Typically, you would wait for the CBN_CLOSEUP notification code before processing a change in the current selection. 
		/// This can be particularly important if a significant amount of processing is required. 
		/// </para>
		/// <para>
		/// This notification code is not sent to a combo box that has the CBS_SIMPLE style. 
		/// </para>
		/// </remarks>
		CBN_CLOSEUP			=  8,

		/// <summary>
		/// Sent when the user double-clicks a string in the list box of a combo box. 
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code occurs only for a combo box with the CBS_SIMPLE style. 
		/// <para>
		/// In a combo box with the CBS_DROPDOWN or CBS_DROPDOWNLIST style, a double-click cannot occur because a single click closes the list box. 
		/// </para>
		/// </remarks>
		CBN_DBLCLK			=  2,

		/// <summary>
		/// Sent when the list box of a combo box is about to be made visible. 
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is only sent if the combo box has the CBS_DROPDOWN or CBS_DROPDOWNLIST style. 
		/// </remarks>
		CBN_DROPDOWN			=  7,

		/// <summary>
		/// Sent after the user has taken an action that may have altered the text in the edit control portion of a combo box. 
		/// <para>
		/// Unlike the CBN_EDITUPDATE notification code, this notification code is sent after the system updates the screen. 
		/// </para>
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// If the combo box has the CBS_DROPDOWNLIST style, this notification code is not sent. 
		/// </remarks>
		CBN_EDITCHANGE			=  5,

		/// <summary>
		/// Sent when the edit control portion of a combo box is about to display altered text. 
		/// <para>
		/// This notification code is sent after the control has formatted the text, but before it displays the text. 
		/// </para>
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// If the combo box has the CBS_DROPDOWNLIST style, this notification code is not sent. 
		/// </remarks>
		CBN_EDITUPDATE			=  6,

		/// <summary>
		/// Sent when a combo box cannot allocate enough memory to meet a specific request. 
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		CBN_ERRSPACE			=  (-1),

		/// <summary>
		/// Sent when a combo box loses the keyboard focus. 
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box.</LPARAM>
		CBN_KILLFOCUS			=  4,

		/// <summary>
		/// Sent when the user changes the current selection in the list box of a combo box. 
		/// <para>
		/// The user can change the selection by clicking in the list box or by using the arrow keys. 
		/// </para>
		/// <para>
		/// The parent window of the combo box receives this notification code in the form of a WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// To get the index of the current selection, send the CB_GETCURSEL message to the control.
		/// <para>
		/// The CBN_SELCHANGE notification code is not sent when the current selection is set using the CB_SETCURSEL message. 
		/// </para>
		/// </remarks>
		CBN_SELCHANGE			=  1,

		/// <summary>
		/// Sent when the user selects an item, but then selects another control or closes the dialog box. It indicates the user's initial selection is to be ignored. 
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// In a combo box with the CBS_SIMPLE style, the CBN_SELENDCANCEL notification code is not sent. 
		/// <para>
		/// The CBN_SELENDOK notification code is sent immediately before every CBN_SELCHANGE notification code. 
		/// </para>
		/// </remarks>
		CBN_SELENDCANCEL		=  10,

		/// <summary>
		/// Sent when the user selects a list item, or selects an item and then closes the list. It indicates that the user's selection is to be processed. 
		/// <para>
		/// The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		/// 
		/// <remarks>
		/// In a combo box with the CBS_SIMPLE style, the CBN_SELENDOK notification code is sent immediately before every CBN_SELCHANGE notification code. 
		/// </remarks>
		CBN_SELENDOK			=  9,

		/// <summary>
		/// Sent when a combo box receives the keyboard focus. The parent window of the combo box receives this notification code through the WM_COMMAND message. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the control identifier of the combo box. The HIWORD specifies the notification code. 
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the combo box. </LPARAM>
		CBN_SETFOCUS			=  3
	    }
	# endregion
    }
