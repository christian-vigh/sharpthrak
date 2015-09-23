/**************************************************************************************************************

    NAME
        WinAPI/User32/P/PrintWindow.cs

    DESCRIPTION
        PrintWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
		/// The PrintWindow function copies a visual window into the specified device context (DC), typically a printer DC.
		/// </summary>
		/// <param name="hwnd">A handle to the window that will be copied.</param>
		/// <param name="hdcBlt">A handle to the device context.</param>
		/// <param name="nFlags">The drawing options.</param>
		/// <returns>
		/// If the function succeeds, it returns a nonzero value.
		/// <para>
		/// If the function fails, it returns zero.
		/// </para> 
		/// </returns>
		/// <remarks>
		/// Note  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time factors 
		/// such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when writing an application. 
		/// Calling this function from a thread that manages interaction with the user interface could make the application appear to be unresponsive.
		/// <br/>
		/// <para>
		/// The application that owns the window referenced by hWnd processes the PrintWindow call and renders the image in the device context that is referenced by hdcBlt. 
		/// The application receives a WM_PRINT message or, if the PW_PRINTCLIENT flag is specified, a WM_PRINTCLIENT message. 
		/// For more information, see WM_PRINT and WM_PRINTCLIENT. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	PrintWindow ( IntPtr  hwnd, int  hdcBlt, PW_Constants  nFlags ) ;
		# endregion
	    }
    }