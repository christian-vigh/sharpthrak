/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetAsyncKeyState.cs

    DESCRIPTION
        GetAsyncKeyState() Windows function.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
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
		/// Determines whether a key is up or down at the time the function is called, and whether the key was pressed after a previous call to 
		/// GetAsyncKeyState. 
		/// </summary>
		/// <param name="nVirtKey">
		/// The virtual-key code.
		/// <br/>
		/// <para>
		/// You can use left- and right-distinguishing constants to specify certain keys. 
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value specifies whether the key was pressed since the last call to GetAsyncKeyState, 
		/// and whether the key is currently up or down. If the most significant bit is set, the key is down, and if the least significant bit is set, 
		/// the key was pressed after the previous call to GetAsyncKeyState. However, you should not rely on this last behavior.
		/// <br/>
		/// <para>
		/// The return value is zero for the following cases : 
		/// </para>
		/// <para>
		/// • The current desktop is not the active desktop
		/// </para>
		/// <para>
		/// • The foreground thread belongs to another process and the desktop does not allow the hook or the journal record.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The GetAsyncKeyState function works with mouse buttons. However, it checks on the state of the physical mouse buttons, 
		/// not on the logical mouse buttons that the physical buttons are mapped to. For example, the call GetAsyncKeyState(VK_LBUTTON) 
		/// always returns the state of the left physical mouse button, regardless of whether it is mapped to the left or right logical mouse button. 
		/// You can determine the system's current mapping of physical mouse buttons to logical mouse buttons by calling GetSystemMetrics(SM_SWAPBUTTON),
		/// which returns TRUE if the mouse buttons have been swapped.
		/// <br/>
		/// <para>
		/// Although the least significant bit of the return value indicates whether the key has been pressed since the last query, 
		/// due to the pre-emptive multitasking nature of Windows, another application can call GetAsyncKeyState and receive the "recently pressed" 
		/// bit instead of your application. The behavior of the least significant bit of the return value is retained strictly for compatibility
		/// with 16-bit Windows applications (which are non-preemptive) and should not be relied upon.
		/// </para>
		/// <br/>
		/// <para>
		/// You can use the virtual-key code constants VK_SHIFT, VK_CONTROL, and VK_MENU as values for the vKey parameter. 
		/// This gives the state of the SHIFT, CTRL, or ALT keys without distinguishing between left and right. 
		/// </para>
		/// <br/>
		/// <para>
		/// You can use the following virtual-key code constants as values for vKey to distinguish between the left and right instances of those keys :
		/// VK_LSHIFT, VK_RSHIFT, VK_LCONTROL, VK_RCONTROL, VK_LMENU and VK_RMENU.
		/// </para>
		/// <br/>
		/// <para>
		/// These left- and right-distinguishing constants are only available when you call the GetKeyboardState, SetKeyboardState, 
		/// GetAsyncKeyState, GetKeyState, and MapVirtualKey functions. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern short 	GetAsyncKeyState ( int  nVirtKey ) ;
		# endregion
	    }
    }