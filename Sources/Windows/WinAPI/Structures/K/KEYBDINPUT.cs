/**************************************************************************************************************

    NAME
        WinAPI/Structures/K/KEYBDINPUT.cs

    DESCRIPTION
        KEYBDINPUT structure.

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


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information about a simulated keyboard event. 
	/// </summary>
	/// <remarks>
	/// INPUT_KEYBOARD supports nonkeyboard-input methods—such as handwriting recognition or voice recognition—as if it were text input 
	/// by using the KEYEVENTF_UNICODE flag. If KEYEVENTF_UNICODE is specified, SendInput sends a WM_KEYDOWN or WM_KEYUP message 
	/// to the foreground thread's message queue with wParam equal to VK_PACKET. Once GetMessage or PeekMessage obtains this message, 
	/// passing the message to TranslateMessage posts a WM_CHAR message with the Unicode character originally specified by wScan.
	/// This Unicode character will automatically be converted to the appropriate ANSI value if it is posted to an ANSI window.
	/// <br/>
	/// <para>
	/// Set the KEYEVENTF_SCANCODE flag to define keyboard input in terms of the scan code. This is useful to simulate a physical keystroke 
	/// regardless of which keyboard is currently being used. The virtual key value of a key may alter depending on the current keyboard layout 
	/// or what other keys were pressed, but the scan code will always be the same.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  KEYBDINPUT
	   {
		/// <summary>
		/// A virtual-key code. The code must be a value in the range 1 to 254. If the dwFlags member specifies KEYEVENTF_UNICODE, wVk must be 0. 
		/// </summary>
		public ushort			wVk ;

		/// <summary>
		/// A hardware scan code for the key. If dwFlags specifies KEYEVENTF_UNICODE, wScan specifies a Unicode character which is to be sent 
		/// to the foreground application. 
		/// </summary>
		public ushort			wScan ;

		/// <summary>
		/// Specifies various aspects of a keystroke. This member can be certain combinations of the KEYEVENTF_Constants values.
		/// </summary>
		public KEYEVENTF_Constants	dwFlags ;

		/// <summary>
		/// The time stamp for the event, in milliseconds. If this parameter is zero, the system will provide its own time stamp. 
		/// </summary>
		public uint			time ;

		/// <summary>
		/// An additional value associated with the keystroke. Use the GetMessageExtraInfo function to obtain this information. 
		/// </summary>
		public IntPtr			dwExtraInfo ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized KEYBDINPUT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized KEYBDINPUT structure.</returns>
		public static implicit operator  KEYBDINPUT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			KEYBDINPUT		Result ;

			Result. dwExtraInfo		=  IntPtr. Zero ;
			Result. dwFlags			=  KEYEVENTF_Constants. KEYEVENTF_NONE ;
			Result. time			=  0 ;
			Result. wScan			=  0 ;
			Result. wVk			=  0 ;

			return ( Result ) ;
		    }
	    }
    }