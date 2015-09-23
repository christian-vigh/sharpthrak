/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowTextLength.cs

    DESCRIPTION
        GetWindowTextLength() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Retrieves the length, in characters, of the specified window's title bar text (if the window has a title bar). 
		/// If the specified window is a control, the function retrieves the length of the text within the control. 
		/// However, GetWindowTextLength cannot retrieve the length of the text of an edit control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control.</param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the text. 
		/// Under certain conditions, this value may actually be greater than the length of the text.
		/// <br/>
		/// <para>
		/// If the window has no text, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the target window is owned by the current process, GetWindowTextLength causes a WM_GETTEXTLENGTH message to be sent to the specified window or control. 
		/// <br/>
		/// <para>
		/// Under certain conditions, the GetWindowTextLength function may return a value that is larger than the actual length of the text. 
		/// This occurs with certain mixtures of ANSI and Unicode, and is due to the system allowing for the possible existence of 
		/// double-byte character set (DBCS) characters within the text. 
		/// The return value, however, will always be at least as large as the actual length of the text; you can thus always use it to guide buffer allocation. 
		/// This behavior can occur when an application uses both ANSI functions and common dialogs, which use Unicode. 
		/// It can also occur when an application uses the ANSI version of GetWindowTextLength with a window whose window procedure is Unicode, or the Unicode version 
		/// of GetWindowTextLength with a window whose window procedure is ANSI.
		/// <br/>
		/// <para>
		/// To obtain the exact length of the text, use the WM_GETTEXT, LB_GETTEXT, or CB_GETLBTEXT messages, or the GetWindowText function.
		/// </para>
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	GetWindowTextLength ( IntPtr  hWnd ) ;
		# endregion
	    }
    }