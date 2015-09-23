/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowText.cs

    DESCRIPTION
        GetWindowText() Windows function.

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
		/// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is a control, the text of the control is copied. 
		/// However, GetWindowText cannot retrieve the text of a control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control containing the text. </param>
		/// <param name="lpString">
		/// The buffer that will receive the text. If the string is as long or longer than the buffer, the string is truncated and terminated with a null character. 
		/// </param>
		/// <param name="nMaxCount">
		/// The maximum number of characters to copy to the buffer, including the null character. If the text exceeds this limit, it is truncated. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the copied string, not including the terminating null character. 
		/// If the window has no title bar or text, if the title bar is empty, or if the window or control handle is invalid, the return value is zero. 
		/// To get extended error information, call GetLastError. 
		/// <br/>
		/// <para>
		/// This function cannot retrieve the text of an edit control in another application.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the target window is owned by the current process, GetWindowText causes a WM_GETTEXT message to be sent to the specified window or control. 
		/// If the target window is owned by another process and has a caption, GetWindowText retrieves the window caption text. 
		/// If the window does not have a caption, the return value is a null string. This behavior is by design. 
		/// It allows applications to call GetWindowText without becoming unresponsive if the process that owns the target window is not responding. 
		/// However, if the target window is not responding and it belongs to the calling application, GetWindowText will cause the calling application to become unresponsive. 
		/// <br/>
		/// <para>
		/// To retrieve the text of a control in another process, send a WM_GETTEXT message directly instead of calling GetWindowText. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	GetWindowText ( IntPtr  hWnd, StringBuilder  lpString, int  nMaxCount ) ;
		# endregion


		# region Version with an out String for lpString
		/// <summary>
		/// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is a control, the text of the control is copied. 
		/// However, GetWindowText cannot retrieve the text of a control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control containing the text. </param>
		/// <param name="lpString">
		/// The buffer that will receive the text. If the string is as long or longer than the buffer, the string is truncated and terminated with a null character. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the copied string, not including the terminating null character. 
		/// If the window has no title bar or text, if the title bar is empty, or if the window or control handle is invalid, the return value is zero. 
		/// To get extended error information, call GetLastError. 
		/// <br/>
		/// <para>
		/// This function cannot retrieve the text of an edit control in another application.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the target window is owned by the current process, GetWindowText causes a WM_GETTEXT message to be sent to the specified window or control. 
		/// If the target window is owned by another process and has a caption, GetWindowText retrieves the window caption text. 
		/// If the window does not have a caption, the return value is a null string. This behavior is by design. 
		/// It allows applications to call GetWindowText without becoming unresponsive if the process that owns the target window is not responding. 
		/// However, if the target window is not responding and it belongs to the calling application, GetWindowText will cause the calling application to become unresponsive. 
		/// <br/>
		/// <para>
		/// To retrieve the text of a control in another process, send a WM_GETTEXT message directly instead of calling GetWindowText. 
		/// </para>
		/// </remarks>
		public static int 	GetWindowText ( IntPtr  hWnd, out String  lpString )
		   {
			int		length		=  GetWindowTextLength ( hWnd ) + 1 ;
			StringBuilder	sb		=  new StringBuilder ( length ) ;
			int		result ;


			result		=  GetWindowText ( hWnd, sb, length ) ;
			lpString	=  sb. ToString ( ) ;

			return ( result ) ;
		    }
		# endregion
	    }
    }