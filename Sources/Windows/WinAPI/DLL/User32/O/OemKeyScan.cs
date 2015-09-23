/**************************************************************************************************************

    NAME
        WinAPI/Functions/O/OemKeyScan.cs

    DESCRIPTION
        OemKeyScan() Windows function.

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
		/// Maps OEMASCII codes 0 through 0x0FF into the OEM scan codes and shift states. The function provides information that allows 
		/// a program to send OEM text to another program by simulating keyboard input. 
		/// </summary>
		/// <param name="wOemChar">The ASCII value of the OEM character. </param>
		/// <returns>
		/// The low-order word of the return value contains the scan code of the OEM character, and the high-order word contains the shift state,
		/// which can be a combination of the following bits :
		/// <para>1 : Either SHIFT key is pressed.</para>
		/// <para>2 : Either CTRL key is pressed.</para>
		/// <para>4 : Either ALT key is pressed.</para>
		/// <para>8 : The Hankaku key is pressed.</para>
		/// <para>16, 32 : Reserved (defined by the keyboard layout driver).</para>
		/// <br/>
		/// <para>
		/// If the character cannot be produced by a single keystroke using the current keyboard layout, the return value is –1. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function does not provide translations for characters that require CTRL+ALT or dead keys.
		/// Characters not translated by this function must be copied by simulating input using the ALT+ keypad mechanism. The NUMLOCK key must be off. 
		/// <br/>
		/// <para>
		/// This function does not provide translations for characters that cannot be typed with one keystroke using the current keyboard layout, 
		/// such as characters with diacritics requiring dead keys. Characters not translated by this function may be simulated using 
		/// the ALT+ keypad mechanism. The NUMLOCK key must be on. 
		/// </para>
		/// <br/>
		/// <para>This function is implemented using the VkKeyScan function. </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	OemKeyScan ( ushort  wOemChar ) ;
		# endregion
	    }
    }