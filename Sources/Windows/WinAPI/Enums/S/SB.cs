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

	# region SB_ scrollbar HWND identification constants
	/// <summary>
	/// Unlike other Windows controls, scrollbars are manipulated by functions. This enumeration identifies the scrollbar control to be affected.
	/// </summary>
	public enum	SB_HWND_Constants
	   {
		/// <summary>
		/// The affected scrollbar is the horizontal scrollbar of the specified window.
		/// </summary>
		SB_HORZ		=  0,

		/// <summary>
		/// The affected scrollbar is the vertical scrollbar of the specified window.
		/// </summary>
		SB_VERT		=  1,

		/// <summary>
		/// The affected scrollbar is the one whose control HWND is passed to the function.
		/// </summary>
		SB_CTL		=  2,

		/// <summary>
		/// Both horizontal and vertical scrollbars of the specified window are affected.
		/// </summary>
		SB_BOTH		=  3
	    }
	# endregion


	# region SB_ scrollbar commands
	/// <summary>
	/// Commands that can be sent to scrollbars through API functions.
	/// </summary>
	public enum  SB_Command_Constants
	   {
		/// <summary>
		/// Vertical scrollbar : Scrolls to the lower right (same as SB_RIGHT).
		/// </summary>
		SB_BOTTOM           		=  7,

		/// <summary>
		/// Ends scroll.
		/// </summary>
		SB_ENDSCROLL        		=  8,

		/// <summary>
		/// Horizontal scrollbar : Scrolls line left (same as SB_TOP).
		/// </summary>
		SB_LEFT             		=  6,

		/// <summary>
		/// Vertical scrollbar : Scrolls one line down (same as SB_LINERIGHT).
		/// </summary>
		SB_LINEDOWN         		=  1,

		/// <summary>
		/// Horizontal scrollbar : Scrolls line by one position (same as SB_LINEUP).
		/// </summary>
		SB_LINELEFT         		=  0,

		/// <summary>
		/// Horizontal scrollbar : Scrolls line by one position (same as SB_LINEDOWN).
		/// </summary>
		SB_LINERIGHT        		=  1,

		/// <summary>
		/// Vertical scrollbar : Scrolls by one line up (same as SB_LINELEFT).
		/// </summary>
		SB_LINEUP           		=  0,

		/// <summary>
		/// Vertical scrollbar : Scrolls by one page down (same as SB_PAGERIGHT).
		/// </summary>
		SB_PAGEDOWN         		=  3,

		/// <summary>
		/// Horizontal scrollbar : Scrolls by one page left (same as SB_PAGEUP).
		/// </summary>
		SB_PAGELEFT         		=  2,

		/// <summary>
		/// Horizontal scrollbar : Scrolls by one page right (same as SB_PAGEDOWN).
		/// </summary>
		SB_PAGERIGHT        		=  3,

		/// <summary>
		/// Vertical scrollbar : Scrolls by one page up (same as SB_PAGELEFT).
		/// </summary>
		SB_PAGEUP           		=  2,

		/// <summary>
		/// Horizontal scrollbar : Scrolls by one position right (same as SB_BOTTOM).
		/// </summary>
		SB_RIGHT            		=  7,

		/// <summary>
		/// The user has dragged the scroll box (thumb) and released the mouse button. 
		/// The HIWORD indicates the position of the scroll box at the end of the drag operation.
		/// </summary>
		SB_THUMBPOSITION    		=  4,

		/// <summary>
		/// The user is dragging the scroll box. This message is sent repeatedly until the user releases the mouse button. 
		/// The HIWORD indicates the position that the scroll box has been dragged to.
		/// </summary>
		SB_THUMBTRACK       		=  5,

		/// <summary>
		/// Vertical scrollbar : Scrolls to the top (same as SB_LEFT).
		/// </summary>
		SB_TOP              		=  6
	    }
	# endregion
    }