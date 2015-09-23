/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetActiveWindow.cs

    DESCRIPTION
        SetActiveWindow() Windows function.

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
		/// Activates a window. The window must be attached to the calling thread's message queue. 
		/// </summary>
		/// <param name="hWnd">A handle to the top-level window to be activated. </param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to the window that was previously active. 
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The SetActiveWindow function activates a window, but not if the application is in the background. 
		/// The window will be brought into the foreground (top of Z-Order) if its application is in the foreground when the system activates the window. 
		/// <br/>
		/// <para>
		/// If the window identified by the hWnd parameter was created by the calling thread, the active window status of the calling thread is set to hWnd. 
		/// Otherwise, the active window status of the calling thread is set to NULL.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	SetActiveWindow ( IntPtr  hWnd ) ;
		# endregion
	    }
    }