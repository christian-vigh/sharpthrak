/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetForegroundWindow.cs

    DESCRIPTION
        SetForegroundWindow() Windows function.

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
		/// Brings the thread that created the specified window into the foreground and activates the window. 
		/// Keyboard input is directed to the window, and various visual cues are changed for the user. 
		/// The system assigns a slightly higher priority to the thread that created the foreground window than it does to other threads. 
		/// </summary>
		/// <param name="hWnd">A handle to the window that should be activated and brought to the foreground. </param>
		/// <returns>
		/// If the window was brought to the foreground, the return value is nonzero. 
		/// <para>
		/// If the window was not brought to the foreground, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The system restricts which processes can set the foreground window. A process can set the foreground window only if one of the following conditions is true :
		/// <para>• The process is the foreground process. </para>
		/// <para>• The process was started by the foreground process. </para>
		/// <para>• The process received the last input event. </para>
		/// <para>• There is no foreground process.</para>
		/// <para>• The foreground process is being debugged.</para>
		/// <para>• The foreground is not locked (see LockSetForegroundWindow).</para>
		/// <para>• The foreground lock time-out has expired (see SPI_GETFOREGROUNDLOCKTIMEOUT in SystemParametersInfo).</para>
		/// <para>No menus are active.</para>
		/// <br/>
		/// <para>
		/// An application cannot force a window to the foreground while the user is working with another window. 
		/// Instead, Windows flashes the taskbar button of the window to notify the user.
		/// </para>
		/// <br/>
		/// <para>
		/// A process that can set the foreground window can enable another process to set the foreground window by calling the AllowSetForegroundWindow function. 
		/// The process specified by dwProcessId loses the ability to set the foreground window the next time the user generates input, 
		/// unless the input is directed at that process, or the next time a process calls AllowSetForegroundWindow, unless that process is specified. 
		/// </para>
		/// <br/>
		/// <para>
		/// The foreground process can disable calls to SetForegroundWindow by calling the LockSetForegroundWindow function. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetForegroundWindow ( IntPtr  hWnd ) ;
		# endregion
	    }
    }