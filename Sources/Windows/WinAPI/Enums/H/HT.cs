/**************************************************************************************************************

    NAME
        WinAPI/Constants/H/HT.cs

    DESCRIPTION
        Constants for WM_NCHITTEST and MOUSEHOOKSTRUCT position codes.

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
	# region HT_ constants for WM_NCHITTEST and MOUSEHOOKSTRUCT position codes
	/// <summary>
	/// HT_ constants for WM_NCHITTEST and MOUSEHOOKSTRUCT position codes. Indicates the position of the cursor hotspot.
	/// </summary>
	public enum  HT_Constants	:  int
	   {
		/// <summary>
		/// In the border of a window that does not have a sizing border.
		/// </summary>
		HTBORDER            		=  18,

		/// <summary>
		/// In the lower-horizontal border of a resizable window (the user can click the mouse to resize the window vertically).
		/// </summary>
		HTBOTTOM            		=  15,

		/// <summary>
		/// In the lower-left corner of a border of a resizable window (the user can click the mouse to resize the window diagonally).
		/// </summary>
		HTBOTTOMLEFT        		=  16,

		/// <summary>
		/// In the lower-right corner of a border of a resizable window (the user can click the mouse to resize the window diagonally).
		/// Same as HTSIZELAST.
		/// </summary>
		HTBOTTOMRIGHT       		=  17,

		/// <summary>
		/// In the title bar.
		/// </summary>
		HTCAPTION           		=  2,

		/// <summary>
		/// In the client area.
		/// </summary>
		HTCLIENT            		=  1,

		/// <summary>
		/// In the Close button.
		/// </summary>
		HTCLOSE             		=  20,

		/// <summary>
		/// On the screen background or on a dividing line between windows 
		/// <para>
		/// (same as HTNOWHERE, except that the DefWindowProc function produces a system beep to indicate an error).
		/// </para>
		/// </summary>
		HTERROR             		=  (-2),

		/// <summary>
		/// In the size box (same as HTSIZE).
		/// </summary>
		HTGROWBOX           		=  4,

		/// <summary>
		/// In the Help button.
		/// </summary>
		HTHELP              		=  21,

		/// <summary>
		/// In the horizontal scroll bar.
		/// </summary>
		HTHSCROLL           		=  6,

		/// <summary>
		/// In the left border of a resizable window (the user can click the mouse to resize the window horizontally).
		/// <para>
		/// Same as HTSIZEFIRST.
		/// </para>
		/// </summary>
		HTLEFT              		=  10,

		/// <summary>
		/// In the Maximize button. Same as HTZOOM.
		/// </summary>
		HTMAXBUTTON         		=  9,

		/// <summary>
		/// In a menu.
		/// </summary>
		HTMENU              		=  5,

		/// <summary>
		/// In the Minimize button.
		/// </summary>
		HTMINBUTTON         		=  8,

		/// <summary>
		/// On the screen background or on a dividing line between windows
		/// </summary>
		HTNOWHERE           		=  0,

		/// <summary>
		/// 
		/// </summary>
		HTOBJECT            		=  19,

		/// <summary>
		/// In the Minimize button.
		/// </summary>
		HTREDUCE            		=  HTMINBUTTON,

		/// <summary>
		/// In the right border of a resizable window (the user can click the mouse to resize the window horizontally).
		/// </summary>
		HTRIGHT             		=  11,

		/// <summary>
		/// In the size box (same as HTGROWBOX). Same as HTGROWBOX.
		/// </summary>
		HTSIZE              		=  HTGROWBOX,

		/// <summary>
		/// In the left border of a resizable window (the user can click the mouse to resize the window horizontally).
		/// Same as HTSIZEFIRST.
		/// </summary>
		HTSIZEFIRST         		=  HTLEFT,

		/// <summary>
		/// In the lower-right corner of a border of a resizable window (the user can click the mouse to resize the window diagonally).
		/// Same as HTBOTTOMRIGHT.
		/// </summary>
		HTSIZELAST          		=  HTBOTTOMRIGHT,

		/// <summary>
		/// In a window menu or in a Close button in a child window.
		/// </summary>
		HTSYSMENU           		=  3,

		/// <summary>
		/// In the upper-horizontal border of a window.
		/// </summary>
		HTTOP               		=  12,

		/// <summary>
		/// In the upper-left corner of a window border.
		/// </summary>
		HTTOPLEFT           		=  13,

		/// <summary>
		/// In the upper-right corner of a window border.
		/// </summary>
		HTTOPRIGHT          		=  14,

		/// <summary>
		/// In a window currently covered by another window in the same thread 
		/// (the message will be sent to underlying windows in the same thread until one of them returns a code that is not HTTRANSPARENT).
		/// </summary>
		HTTRANSPARENT       		=  (-1),

		/// <summary>
		/// In the vertical scroll bar.
		/// </summary>
		HTVSCROLL           		=  7,

		/// <summary>
		/// In a Maximize button. same as HTMAXBUTTON.
		/// </summary>
		HTZOOM              		=  HTMAXBUTTON,
	    }
	# endregion
   }