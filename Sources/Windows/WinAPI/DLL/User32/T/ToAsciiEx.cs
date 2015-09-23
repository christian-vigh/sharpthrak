/**************************************************************************************************************

    NAME
        WinAPI/Functions/T/ToAsciiEx.cs

    DESCRIPTION
        ToAsciiEx() Windows function.

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
		/// Translates the specified virtual-key code and keyboard state to the corresponding character or characters. 
		/// The function translates the code using the input language and physical keyboard layout identified by the input locale identifier.
		/// </summary>
		/// <param name="uVirtKey">The virtual-key code to be translated.</param>
		/// <param name="uScanCode">
		/// The hardware scan code of the key to be translated. The high-order bit of this value is set if the key is up (not pressed). 
		/// </param>
		/// <param name="lpKeyState">
		/// A pointer to a 256-byte array that contains the current keyboard state. Each element (byte) in the array contains the state of one key. 
		/// If the high-order bit of a byte is set, the key is down (pressed).
		/// <br/>
		/// <para>
		/// The low bit, if set, indicates that the key is toggled on. In this function, only the toggle bit of the CAPS LOCK key is relevant.
		/// The toggle state of the NUM LOCK and SCOLL LOCK keys is ignored.
		/// </para>
		/// </param>
		/// <param name="lpChar">
		/// A pointer to the buffer that receives the translated character or characters. 
		/// </param>
		/// <param name="uFlags">This parameter must be 1 if a menu is active, zero otherwise. </param>
		/// <param name="hkl">
		/// Input locale identifier to use to translate the code. This parameter can be any input locale identifier previously returned by
		/// the LoadKeyboardLayout function. 
		/// </param>
		/// <returns>
		/// If the specified key is a dead key, the return value is negative. Otherwise, it is one of the following values :
		/// <para>0 : The specified virtual key has no translation for the current state of the keyboard.</para>
		/// <para>1 : One character was copied to the buffer.</para>
		/// <para>2 : 
		/// Two characters were copied to the buffer. This usually happens when a dead-key character (accent or diacritic) stored 
		/// in the keyboard layout cannot be composed with the specified virtual key to form a single character.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The input locale identifier is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter, 
		/// an Input Method Editor (IME), or any other form of input. 
		/// <br/>
		/// <para>
		/// The parameters supplied to the ToAsciiEx function might not be sufficient to translate the virtual-key code, 
		/// because a previous dead key is stored in the keyboard layout. 
		/// </para>
		/// <br/>
		/// <para>
		/// Typically, ToAsciiEx performs the translation based on the virtual-key code. In some cases, however, bit 15 of the uScanCode parameter 
		/// may be used to distinguish between a key press and a key release. The scan code is used for translating ALT+number key combinations. 
		/// </para>
		/// <br/>
		/// <para>
		/// Although NUM LOCK is a toggle key that affects keyboard behavior, ToAsciiEx ignores the toggle setting (the low bit) of lpKeyState 
		/// (VK_NUMLOCK) because the uVirtKey parameter alone is sufficient to distinguish the cursor movement keys (VK_HOME, VK_INSERT, and so on)
		/// from the numeric keys (VK_DECIMAL, VK_NUMPAD0 - VK_NUMPAD9).
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		static extern int  ToAsciiEx ( uint  uVirtKey, uint  uScanCode, byte [] lpKeyState, [Out] StringBuilder  lpChar, uint  uFlags, IntPtr  hkl ) ;
		# endregion


		# region Version with an Out String for the lpChar parameter
		/// <summary>
		/// Translates the specified virtual-key code and keyboard state to the corresponding character or characters. 
		/// The function translates the code using the input language and physical keyboard layout identified by the input locale identifier.
		/// </summary>
		/// <param name="uVirtKey">The virtual-key code to be translated.</param>
		/// <param name="uScanCode">
		/// The hardware scan code of the key to be translated. The high-order bit of this value is set if the key is up (not pressed). 
		/// </param>
		/// <param name="lpKeyState">
		/// A pointer to a 256-byte array that contains the current keyboard state. Each element (byte) in the array contains the state of one key. 
		/// If the high-order bit of a byte is set, the key is down (pressed).
		/// <br/>
		/// <para>
		/// The low bit, if set, indicates that the key is toggled on. In this function, only the toggle bit of the CAPS LOCK key is relevant.
		/// The toggle state of the NUM LOCK and SCOLL LOCK keys is ignored.
		/// </para>
		/// </param>
		/// <param name="lpChar">
		/// A pointer to the buffer that receives the translated character or characters. 
		/// </param>
		/// <param name="uFlags">This parameter must be 1 if a menu is active, zero otherwise. </param>
		/// <param name="hkl">
		/// Input locale identifier to use to translate the code. This parameter can be any input locale identifier previously returned by
		/// the LoadKeyboardLayout function. 
		/// </param>
		/// <returns>
		/// If the specified key is a dead key, the return value is negative. Otherwise, it is one of the following values :
		/// <para>0 : The specified virtual key has no translation for the current state of the keyboard.</para>
		/// <para>1 : One character was copied to the buffer.</para>
		/// <para>2 : 
		/// Two characters were copied to the buffer. This usually happens when a dead-key character (accent or diacritic) stored 
		/// in the keyboard layout cannot be composed with the specified virtual key to form a single character.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The input locale identifier is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter, 
		/// an Input Method Editor (IME), or any other form of input. 
		/// <br/>
		/// <para>
		/// The parameters supplied to the ToAsciiEx function might not be sufficient to translate the virtual-key code, 
		/// because a previous dead key is stored in the keyboard layout. 
		/// </para>
		/// <br/>
		/// <para>
		/// Typically, ToAsciiEx performs the translation based on the virtual-key code. In some cases, however, bit 15 of the uScanCode parameter 
		/// may be used to distinguish between a key press and a key release. The scan code is used for translating ALT+number key combinations. 
		/// </para>
		/// <br/>
		/// <para>
		/// Although NUM LOCK is a toggle key that affects keyboard behavior, ToAsciiEx ignores the toggle setting (the low bit) of lpKeyState 
		/// (VK_NUMLOCK) because the uVirtKey parameter alone is sufficient to distinguish the cursor movement keys (VK_HOME, VK_INSERT, and so on)
		/// from the numeric keys (VK_DECIMAL, VK_NUMPAD0 - VK_NUMPAD9).
		/// </para>
		/// </remarks>
		static int  ToAsciiEx ( uint  uVirtKey, uint  uScanCode, byte [] lpKeyState, out String  lpChar, uint  uFlags, IntPtr  hkl )
		   {
			StringBuilder		SB		=  new StringBuilder ( 10 ) ;
			int			Status ;


			Status	=  ToAsciiEx ( uVirtKey, uScanCode, lpKeyState, SB, uFlags, hkl ) ;
			lpChar	=  SB. ToString ( ) ;

			return ( Status ) ;
		    }
		# endregion
	    }
    }