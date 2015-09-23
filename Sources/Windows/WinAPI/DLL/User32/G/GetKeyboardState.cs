/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKeyboardState.cs

    DESCRIPTION
        GetKeyboardState() Windows function.

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
		/// Copies the status of the 256 virtual keys to the specified buffer. 
		/// </summary>
		/// <param name="lpKeyState">The 256-byte array that receives the status data for each virtual key. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// An application can call this function to retrieve the current status of all the virtual keys. The status changes as a thread 
		/// removes keyboard messages from its message queue. The status does not change as keyboard messages are posted to the thread's message queue,
		/// nor does it change as keyboard messages are posted to or retrieved from message queues of other threads. 
		/// (Exception: Threads that are connected through AttachThreadInput share the same keyboard state.)
		/// <br/>
		/// <para>
		/// When the function returns, each member of the array pointed to by the lpKeyState parameter contains status data for a virtual key. 
		/// If the high-order bit is 1, the key is down; otherwise, it is up. If the key is a toggle key, for example CAPS LOCK, 
		/// then the low-order bit is 1 when the key is toggled and is 0 if the key is untoggled. The low-order bit is meaningless for non-toggle keys.
		/// A toggle key is said to be toggled when it is turned on. A toggle key's indicator light (if any) on the keyboard will be on 
		/// when the key is toggled, and off when the key is untoggled. 
		/// </para>
		/// <br/>
		/// <para>
		/// To retrieve status information for an individual key, use the GetKeyState function. To retrieve the current state for an individual key 
		/// regardless of whether the corresponding keyboard message has been retrieved from the message queue, use the GetAsyncKeyState function.
		/// </para>
		/// <br/>
		/// <para>
		/// An application can use the virtual-key code constants VK_SHIFT, VK_CONTROL and VK_MENU as indices into the array pointed to by lpKeyState. 
		/// This gives the status of the SHIFT, CTRL, or ALT keys without distinguishing between left and right. An application can also use 
		/// the following virtual-key code constants as indices to distinguish between the left and right instances of those keys : 
		/// VK_LSHIFT, VK_RSHIFT, VK_LCONTROL, VK_RCONTROL, VK_LMENU and VK_RMENU.
		/// </para>
		/// <br/>
		/// <para>
		/// These left- and right-distinguishing constants are available to an application only through the GetKeyboardState, SetKeyboardState, 
		/// GetAsyncKeyState, GetKeyState, and MapVirtualKey functions. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetKeyboardState ( byte []  lpKeyState ) ;
		# endregion
	    }
    }