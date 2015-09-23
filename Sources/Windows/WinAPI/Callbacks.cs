/**************************************************************************************************************

    NAME
        Callbacks.cs

    DESCRIPTION
        Windows function callbacls.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;
using   Thrak. WinAPI. Enums ;
using   Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. Callbacks
   {
	# region CBTHOOKPROC - Callback for CBTHOOKPROC windows hook function
	/// <summary>
	/// The code that the hook procedure uses to determine how to process the message.
	/// <para>
	/// If nCode is less than zero, the hook procedure must pass the message to the CallNextHookEx function without further processing and should return the value 
	/// returned by CallNextHookEx. 
	/// </para>
	/// </summary>
	/// <param name="nCode">
	/// The code that the hook procedure uses to determine how to process the message. 
	/// <para>
	/// If nCode is less than zero, the hook procedure must pass the message to the CallNextHookEx function without further processing and should return the value 
	/// returned by CallNextHookEx. 
	/// </para>
	/// </param>
	/// <param name="wParam">Depends on the nCode parameter.</param>
	/// <param name="lParam">Depends on the nCode parameter.	</param>
	/// <returns></returns>
	public delegate bool	CBTHOOKPROC	( HCBT_Constants  nCode, IntPtr  wParam, IntPtr  lParam ) ;
	# endregion

	
	# region DLGPROC - Callback function for a dialog box window
	/// <summary>
	/// Callback function for a dialog box window.
	/// </summary>
	/// <param name="hWnd">Destination window.</param>
	/// <param name="uMsg">Message sent to the window.</param>
	/// <param name="wParam">Additional WPARAM information.</param>
	/// <param name="lParam">Additional LPARAM information.</param>
	/// <returns>The return value depends on the <paramref name="uMsg"/> value.</returns>
	public delegate IntPtr	DLGPROC ( IntPtr  hWnd, uint  uMsg, IntPtr  wParam, IntPtr  lParam ) ;
	# endregion


	# region ENUMWNDPROC - Callback for EnumWindows()
	/// <summary>
	/// An application-defined callback function used with the EnumWindows function. It receives top-level window handles. 
	/// <para>
	/// EnumWindowsProc is a placeholder for the application-defined function name. 
	/// </para>
	/// </summary>
	/// <param name="hWnd">A handle to a top-level window. </param>
	/// <param name="lParam">The application-defined value given in EnumWindows.</param>
	/// <returns>To continue enumeration, the callback function must return true; to stop enumeration, it must return false.</returns>
	public delegate bool	ENUMWNDPROC  ( IntPtr  hWnd, IntPtr lParam ) ;
	# endregion


	# region HOOKPROC - Callback for HOOKPROC windows hook function
	/// <summary>
	/// The code that the hook procedure uses to determine how to process the message. 
	/// <para>
	/// If nCode is less than zero, the hook procedure must pass the message to the CallNextHookEx function without further processing and should return the value 
	/// returned by CallNextHookEx. 
	/// </para>
	/// </summary>
	/// <param name="nCode">Hook message code.</param>
	/// <param name="wParam">Depends on the nCode parameter.</param>
	/// <param name="lParam">Depends on the nCode parameter.</param>
	/// <returns>To continue enumeration, the callback function must return true; to stop enumeration, it must return false.</returns>
	public delegate bool	HOOKPROC	( int  nCode, IntPtr  wParam, IntPtr  lParam ) ;
	# endregion


	# region MSGBOXCALLBACK - Callback help function for MessageBoxIndirect
	/// <summary>
	/// Help function called by MessageBoxIndirect when the user requests help.
	/// </summary>
	/// <param name="lpHelpInfo">Help context information.</param>
	public  delegate void	MSGBOXCALLBACK  ( HELPINFO  lpHelpInfo ) ;
	# endregion


	# region PROGRESS_ROUTINE - Callback used by the CopyFileEx function
	/// <summary>
	/// An application-defined callback function used with the CopyFileEx, MoveFileTransacted, and MoveFileWithProgress functions. 
	/// It is called when a portion of a copy or move operation is completed. The LPPROGRESS_ROUTINE type defines a pointer to this callback function. 
	/// </summary>
	/// <param name="TotalFileSize">The total size of the file, in bytes.</param>
	/// <param name="TotalBytesTransferred">
	/// The total number of bytes transferred from the source file to the destination file since the copy operation began.
	/// </param>
	/// <param name="StreamSize">The total size of the current file stream, in bytes.</param>
	/// <param name="StreamBytesTransferred">
	/// The total number of bytes in the current stream that have been transferred from the source file to the destination file 
	/// since the copy operation began.
	/// </param>
	/// <param name="dwStreamNumber">A handle to the current stream. The first time CopyProgressRoutine is called, the stream number is 1.</param>
	/// <param name="dwCallbackReason">
	/// The reason why the callback routine was called. Can be any of the CALLBACK_REASON_Constants values.
	/// </param>
	/// <param name="hSourceFile">A handle to the source file.</param>
	/// <param name="hDestinationFile">A handle to the destination file</param>
	/// <param name="lpData">Argument passed to CopyProgressRoutine by CopyFileEx, MoveFileTransacted, or MoveFileWithProgress.</param>
	/// <returns>
	/// The CopyProgressRoutine function should return one of the PROGRESS_Constants values.
	/// </returns>
	/// <remarks>
	/// An application can use this information to display a progress bar that shows the total number of bytes copied as a percent of the total file size.
	/// </remarks>
	public delegate PROGRESS_Constants  PROGRESS_ROUTINE ( 
						 long				TotalFileSize, 
						 long				TotalBytesTransferred,
						 long				StreamSize   , 
						 long				StreamBytesTransferred,
						 uint				dwStreamNumber,
						 CALLBACK_REASON_Constants	dwCallbackReason,
						 IntPtr				hSourceFile  , 
						 IntPtr				hDestinationFile,
						 IntPtr				lpData ) ;
	# endregion


	# region PROPENUMPROC - Callback for EnumProps()
	/// <summary>
	/// An application-defined callback function used with the EnumProps function. It receives the properties defined for a window. 
	/// </summary>
	/// <param name="hWnd">A handle to a top-level window. </param>
	/// <param name="lpString">The application-defined value given in EnumWindows.</param>
	/// <param name="hData">A handle to the data. This handle is the data component of a property list entry. </param>
	/// <returns>To continue enumeration, the callback function must return true; to stop enumeration, it must return false.</returns>
	public delegate bool	PROPENUMPROC	( IntPtr  hWnd, IntPtr  lpString, IntPtr  hData ) ;
	# endregion


	# region PROPENUMPROCEX - Callback for EnumPropsEx()
	/// <summary>
	/// An application-defined callback function used with the EnumPropsEx function. It receives the properties defined for a window. 
	/// </summary>
	/// <param name="hWnd">A handle to a top-level window. </param>
	/// <param name="lpString">The application-defined value given in EnumWindows.</param>
	/// <param name="hData">A handle to the data. This handle is the data component of a property list entry. </param>
	/// <param name="dwData">
	/// Application-defined data. This is the value that was specified as the lParam parameter of the call to EnumPropsEx that initiated the enumeration. 
	/// </param>
	/// <returns>To continue enumeration, the callback function must return true; to stop enumeration, it must return false.</returns>
	public delegate bool	PROPENUMPROCEX	( IntPtr  hWnd, IntPtr  lpString, IntPtr  hData, IntPtr  lParam ) ;
	# endregion


	# region TIMERPROC - Callback for timer events
	/// <summary>
	/// An application-defined callback function that processes WM_TIMER messages. 
	/// <para>
	/// The TIMERPROC type defines a pointer to this callback function. TimerProc is a placeholder for the application-defined function name. 
	/// </para>
	/// </summary>
	/// <param name="hWnd">A handle to the window associated with the timer. </param>
	/// <param name="uMsg">The WM_TIMER message. </param>
	/// <param name="nIDEvent">The timer's identifier. </param>
	/// <param name="dwTime">The number of milliseconds that have elapsed since the system was started. This is the value returned by the GetTickCount function.</param>
	public delegate void	TIMERPROC	( IntPtr  hWnd, uint  uMsg,  IntPtr  nIDEvent, uint  dwTime ) ;
	# endregion

	
	# region WNDPROC - Callback function for Window procedure
	/// <summary>
	/// Window procedure.
	/// </summary>
	/// <param name="hWnd">Destination window.</param>
	/// <param name="uMsg">Message sent to the window.</param>
	/// <param name="wParam">Additional WPARAM information.</param>
	/// <param name="lParam">Additional LPARAM information.</param>
	/// <returns>The return value depends on the <paramref name="uMsg"/> value.</returns>
	public delegate IntPtr	WNDPROC ( IntPtr  hWnd, uint  uMsg, IntPtr  wParam, IntPtr  lParam ) ;
	# endregion
     }