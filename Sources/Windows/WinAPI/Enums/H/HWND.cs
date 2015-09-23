/**************************************************************************************************************

    NAME
        WinAPI/Enums/H/HWND.cs

    DESCRIPTION
        HWND constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region HWND_ constants
	/// <summary>
	/// Special values for the hwndInsertAfter parameter of the SetWindowPos() function.
	/// </summary>
	public enum HWND_Constants : int
	   {
		/// <summary>
		/// Places the window at the bottom of the Z order. 
		/// If the hWnd parameter identifies a topmost window, the window loses its topmost status and is placed at the bottom of all other windows.
		/// </summary>
		HWND_BOTTOM		=  1,

		/// <summary>
		/// Places the window above all non-topmost windows (that is, behind all topmost windows). This flag has no effect if the window is already a non-topmost window.
		/// </summary>
		HWND_NOTOPMOST		=  -2,

		/// <summary>
		/// Places the window at the top of the Z order.
		/// </summary>
		HWND_TOP		=  0,

		/// <summary>
		/// Places the window above all non-topmost windows. The window maintains its topmost position even when it is deactivated.
		/// </summary>
		HWND_TOPMOST		=  -1,
	    }
	# endregion
    }