/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKeyState.cs

    DESCRIPTION
        GetKeyState() Windows function.

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
		/// Retrieves the status of the specified virtual key. The status specifies whether the key is up, down, or toggled 
		/// (on, off—alternating each time the key is pressed). 
		/// </summary>
		/// <param name="nVirtKey">
		/// A virtual key. If the desired virtual key is a letter or digit (A through Z, a through z, or 0 through 9), nVirtKey must be set to 
		/// the ASCII value of that character. For other keys, it must be a virtual-key code. 
		/// <br/>
		/// <para>
		/// If a non-English keyboard layout is used, virtual keys with values in the range ASCII A through Z and 0 through 9 are used to specify 
		/// most of the character keys. For example, for the German keyboard layout, the virtual key of value ASCII O (0x4F) refers to the "o" key, 
		/// whereas VK_OEM_1 refers to the "o with umlaut" key.
		/// </para>
		/// </param>
		/// <returns>
		/// The return value specifies the status of the specified virtual key, as follows : 
		/// <para>
		/// • If the high-order bit is 1, the key is down; otherwise, it is up.
		/// </para>
		/// <para>
		/// •If the low-order bit is 1, the key is toggled. A key, such as the CAPS LOCK key, is toggled if it is turned on. 
		/// The key is off and untoggled if the low-order bit is 0. A toggle key's indicator light (if any) on the keyboard will be on 
		/// when the key is toggled, and off when the key is untoggled.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The key status returned from this function changes as a thread reads key messages from its message queue. 
		/// The status does not reflect the interrupt-level state associated with the hardware. Use the GetAsyncKeyState function to retrieve
		/// that information. 
		/// <br/>
		/// <para>
		/// An application calls GetKeyState in response to a keyboard-input message. This function retrieves the state of the key when 
		/// the input message was generated. 
		/// </para>
		/// <br/>
		/// <para>
		/// To retrieve state information for all the virtual keys, use the GetKeyboardState function. 
		/// </para>
		/// <br/>
		/// <para>
		/// An application can use the virtual key code constants VK_SHIFT, VK_CONTROL, and VK_MENU as values for the nVirtKey parameter. 
		/// This gives the status of the SHIFT, CTRL, or ALT keys without distinguishing between left and right. 
		/// An application can also use the following virtual-key code constants as values for nVirtKey to distinguish between the left and right 
		/// instances of those keys : VK_LSHIFT, VK_RSHIFT, VK_LCONTROL, VK_RCONTROL, VK_LMENU and VK_RMENU.
		/// </para>
		/// <br/>
		/// <para>
		/// These left- and right-distinguishing constants are available to an application only through the GetKeyboardState, SetKeyboardState, 
		/// GetAsyncKeyState, GetKeyState, and MapVirtualKey functions. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern short 	GetKeyState ( int  nVirtKey ) ;
		# endregion
	    }
    }