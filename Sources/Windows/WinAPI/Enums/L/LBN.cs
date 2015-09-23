/**************************************************************************************************************

    NAME
        WinAPI/Constants/L/LBN.cs

    DESCRIPTION
        Listbox notification messages.

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
	# region LBN_ notification messages.
	/// <summary>
	/// Notification messages from listboxes.
	/// </summary>
	public enum LBN_Constants		:  int
	   {
		/// <summary>
		/// Notifies the application that the user has double-clicked an item in a list box. 
		/// <para>
		/// The parent window of the list box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the identifier of the list box. The HIWORD specifies the notification code.
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the list box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is sent only by a list box that has the LBS_NOTIFY style. 
		/// </remarks>
		LBN_DBLCLK			=  2,

		/// <summary>
		/// Notifies the application that the list box cannot allocate enough memory to meet a specific request. 
		/// <para>
		/// The parent window of the list box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the identifier of the list box. The HIWORD specifies the notification code.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Handle to the list box. 
		/// </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is sent only by a list box that has the LBS_NOTIFY style. 
		/// </remarks>
		LBN_ERRSPACE			=  (-2),

		/// <summary>
		/// Notifies the application that the list box has lost the keyboard focus. 
		/// <para>
		/// The parent window of the list box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the identifier of the list box. The HIWORD specifies the notification code.
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the list box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is sent only by a list box that has the LBS_NOTIFY style. 
		/// </remarks>
		LBN_KILLFOCUS			=  5,

		/// <summary>
		/// Notifies the application that the user has canceled the selection in a list box. 
		/// <para>
		/// The parent window of the list box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the identifier of the list box. The HIWORD specifies the notification code.
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the list box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is sent only by a list box that has the LBS_NOTIFY style. 
		/// </remarks>
		LBN_SELCANCEL			=  3,

		/// <summary>
		/// Notifies the application that the user has canceled the selection in a list box. 
		/// <para>
		/// The parent window of the list box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the identifier of the list box. The HIWORD specifies the notification code.
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the list box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is sent only by a list box that has the LBS_NOTIFY style. 
		/// </remarks>
		LBN_SELCHANGE			=  1,

		/// <summary>
		/// Notifies the application that the list box has received the keyboard focus. 
		/// <para>
		/// The parent window of the list box receives this notification code through the WM_COMMAND message. 
		/// </para>
		/// </summary>
		/// 
		/// <WPARAM>
		/// The LOWORD contains the identifier of the list box. The HIWORD specifies the notification code.
		/// </WPARAM>
		/// 
		/// <LPARAM>Handle to the list box. </LPARAM>
		/// 
		/// <remarks>
		/// This notification code is sent only by a list box that has the LBS_NOTIFY style. 
		/// </remarks>
		LBN_SETFOCUS			=  4
	    }
	# endregion
    }
