/**************************************************************************************************************

    NAME
        WinAPI/User32/E/EnableWindow.cs

    DESCRIPTION
        EnableWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
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
		/// Enables or disables mouse and keyboard input to the specified window or control. 
		/// <para>
		/// When input is disabled, the window does not receive input such as mouse clicks and key presses. 
		/// </para>
		/// <para>
		/// When input is enabled, the window receives all input.
		/// </para>
		/// </summary>
		/// <param name="hWnd">A handle to the window to be enabled or disabled.</param>
		/// <param name="bEnable">
		/// Indicates whether to enable or disable the window. If this parameter is TRUE, the window is enabled. If the parameter is FALSE, the window is disabled. 
		/// </param>
		/// <returns>
		/// If the window was previously disabled, the return value is nonzero.
		/// <para>
		/// If the window was not previously disabled, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the window is being disabled, the system sends a WM_CANCELMODE message. If the enabled state of a window is changing, the system sends a WM_ENABLE message 
		/// after the WM_CANCELMODE message. (These messages are sent before EnableWindow returns.) If a window is already disabled, its child windows are implicitly 
		/// disabled, although they are not sent a WM_ENABLE message. 
		/// <para>
		/// A window must be enabled before it can be activated. For example, if an application is displaying a modeless dialog box and has disabled its main window, 
		/// the application must enable the main window before destroying the dialog box. Otherwise, another window will receive the keyboard focus and be activated. 
		/// </para>
		/// <para>
		/// If a child window is disabled, it is ignored when the system tries to determine which window should receive mouse messages. 
		/// </para>
		/// <para>
		/// By default, a window is enabled when it is created. To create a window that is initially disabled, an application can specify the WS_DISABLED style in 
		/// the CreateWindow or CreateWindowEx function. After a window has been created, an application can use EnableWindow to enable or disable the window. 
		/// </para>
		/// <para>
		/// An application can use this function to enable or disable a control in a dialog box. A disabled control cannot receive the keyboard focus, 
		/// nor can a user gain access to it. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	EnableWindow ( IntPtr  hWnd, bool  bEnable ) ;
		# endregion
	    }
    }