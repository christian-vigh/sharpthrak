/**************************************************************************************************************

    NAME
        DestroyWindow.cs

    DESCRIPTION
        DestroyWindow() API.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Destroys the specified window. The function sends WM_DESTROY and WM_NCDESTROY messages to the window to deactivate it and remove the keyboard focus from it. 
		/// The function also destroys the window's menu, flushes the thread message queue, destroys timers, removes clipboard ownership, and breaks the 
		/// clipboard viewer chain (if the window is at the top of the viewer chain).
		/// <para>
		/// If the specified window is a parent or owner window, DestroyWindow automatically destroys the associated child or owned windows when it destroys 
		/// the parent or owner window. The function first destroys child or owned windows, and then it destroys the parent or owner window.
		/// </para>
		/// <para>
		/// DestroyWindow also destroys modeless dialog boxes created by the CreateDialog function.
		/// </para>
		/// </summary>
		/// <param name="hWnd">A handle to the window to be destroyed. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	DestroyWindow ( IntPtr  hWnd ) ;
		# endregion
	    }
    }
