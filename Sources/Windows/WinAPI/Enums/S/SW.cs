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

	# region SW_ ShowWindow constants
	/// <summary>
	/// Constants used for the ShowWindow() API function.
	/// </summary>
	public enum  SW_Constants
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		SW_NONE				=  0,

		/// <summary>
		/// Hides the window and activates another window. Same as HIDE_WINDOW.
		/// </summary>
		SW_HIDE				=  0,

		/// <summary>
		/// Hides the window and activates another window. Same as SW_HIDE.
		/// </summary>
		HIDE_WINDOW			=  0,

		/// <summary>
		/// Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position.
		/// <para>
		/// An application should specify this flag when displaying the window for the first time. 
		/// </para>
		/// <para>
		/// Same as SHOW_OPENWINDOW and SW_NORMAL.
		/// </para>
		/// </summary>
		SW_SHOWNORMAL			=  1,

		/// <summary>
		/// Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position. 
		/// <para>
		/// An application should specify this flag when displaying the window for the first time. 
		/// </para>
		/// <para>
		/// Same as SW_SHOWNORMAL and SW_NORMAL.
		/// </para>
		/// </summary>
		SHOW_OPENWINDOW			=  1,

		/// <summary>
		/// Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position. 
		/// <para>
		/// An application should specify this flag when displaying the window for the first time. 
		/// </para>
		/// <para>
		/// Same as SHOW_OPENWINDOW and SW_SHOWNORMAL.
		/// </para>
		/// </summary>
		SW_NORMAL			=  1,

		/// <summary>
		/// Activates the window and displays it as a minimized window. Same as SHOW_ICONWINDOW.
		/// </summary>
		SW_SHOWMINIMIZED		=  2,

		/// <summary>
		/// Activates the window and displays it as a minimized window. Same as SW_SHOWMINIMIZED.
		/// </summary>
		SHOW_ICONWINDOW			=  2,

		/// <summary>
		/// Activates the window and displays it as a maximized window. Same as SW_MAXIMIZE and SHOW_FULLSCREEN.
		/// </summary>
		SW_SHOWMAXIMIZED		=  3,

		/// <summary>
		/// Activates the window and displays it as a maximized window. Same as SW_SHOWMAXIMIZED and SHOW_FULLSCREEN.
		/// </summary>
		SW_MAXIMIZE			=  3,

		/// <summary>
		/// Activates the window and displays it as a maximized window. Same as SW_MAXIMIZE and SW_SHOWMAXIMIZED.
		/// </summary>
		SHOW_FULLSCREEN			=  3,

		/// <summary>
		/// Displays a window in its most recent size and position. 
		/// <para>
		/// This value is similar to SW_SHOWNORMAL, except that the window is not activated. 
		/// </para>
		/// <para>
		/// Same as SHOW_OPENNOACTIVATE.
		/// </para>
		/// </summary>
		SW_SHOWNOACTIVATE		=  4,

		/// <summary>
		/// Displays a window in its most recent size and position. 
		/// <para>
		/// This value is similar to SW_SHOWNORMAL, except that the window is not activated. 
		/// </para>
		/// <para>
		/// Same as SW_SHOWNOACTIVATE.
		/// </para>
		/// </summary>
		SHOW_OPENNOACTIVATE		=  4,

		/// <summary>
		/// Activates the window and displays it in its current size and position. 
		/// </summary>
		SW_SHOW				=  5,

		/// <summary>
		/// Minimizes the specified window and activates the next top-level window in the Z order.
		/// </summary>
		SW_MINIMIZE			=  6,

		/// <summary>
		/// Displays the window as a minimized window. This value is similar to SW_SHOWMINIMIZED, except the window is not activated.
		/// </summary>
		SW_SHOWMINNOACTIVE		=  7,

		/// <summary>
		/// Displays the window in its current size and position. This value is similar to SW_SHOW, except that the window is not activated.
		/// </summary>
		SW_SHOWNA			=  8,

		/// <summary>
		/// Activates and displays the window. If the window is minimized or maximized, the system restores it to its original size and position. 
		/// <para>
		/// An application should specify this flag when restoring a minimized window.
		/// </para>
		/// </summary>
		SW_RESTORE			=  9,

		/// <summary>
		/// Sets the show state based on the SW_ value specified in the STARTUPINFO structure passed to the CreateProcess function
		/// by the program that started the application. 
		/// </summary>
		SW_SHOWDEFAULT			= 10,

		/// <summary>
		/// Minimizes a window, even if the thread that owns the window is not responding. 
		/// <para>
		/// This flag should only be used when minimizing windows from a different thread.
		/// </para>
		/// </summary>
		SW_FORCEMINIMIZE		= 11
	    }
	# endregion


	# region SW_ WM_SHOWWINDOW identifiers
	/// <summary>
	/// lParam value of the WM_SHOWWINDOW message. Specifies the status of the window being shown. 
	/// If lParam is zero, the message was sent because of a call to the ShowWindow function; otherwise, lParam is one of this enum values. 
	/// </summary>
	public enum SW_WM_SHOWWINDOW_Constants
	   {
		/// <summary>
		/// The window is being uncovered because a maximize window was restored or minimized.
		/// </summary>
		SW_OTHERUNZOOM			=  4,

		/// <summary>
		/// The window is being covered by another window that has been maximized.
		/// </summary>
		SW_OTHERZOOM			=  2,

		/// <summary>
		/// The window's owner window is being minimized.
		/// </summary>
		SW_PARENTCLOSING		=  1,

		/// <summary>
		/// The window's owner window is being restored.
		/// </summary>
		SW_PARENTOPENING		=  3
	    }
	# endregion
    }