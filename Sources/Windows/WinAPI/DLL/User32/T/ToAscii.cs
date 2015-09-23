/**************************************************************************************************************

    NAME
        WinAPI/Functions/T/ToAscii.cs

    DESCRIPTION
        ToAscii() Windows function.

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
		/// Translates the specified virtual-key code and keyboard state to the corresponding character or characters. The function translates
		/// the code using the input language and physical keyboard layout identified by the keyboard layout handle.
		/// <br/>
		/// <para>
		/// To specify a handle to the keyboard layout to use to translate the specified code, use the ToAsciiEx function.
		/// </para>
		/// </summary>
		/// <param name="uVirtKey">The virtual-key code to be translated.</param>
		/// <param name="uScanCode">
		/// The hardware scan code of the key to be translated. The high-order bit of this value is set if the key is up (not pressed).
		/// </param>
		/// <param name="lpKeyState">
		/// A pointer to a 256-byte array that contains the current keyboard state. Each element (byte) in the array contains the state of one key. 
		/// If the high-order bit of a byte is set, the key is down (pressed). 
		/// </param>
		/// <param name="lpChar">The buffer that receives the translated character or characters. </param>
		/// <param name="uFlags">This parameter must be 1 if a menu is active, or 0 otherwise. </param>
		/// <returns>
		/// If the specified key is a dead key, the return value is negative. Otherwise, it is one of the following values :
		/// <para>. 0 : The specified virtual key has no translation for the current state of the keyboard.</para>
		/// <para>. 1 : One character was copied to the buffer.</para>
		/// <para>. 2 : Two characters were copied to the buffer. This usually happens when a dead-key character (accent or diacritic) stored 
		/// in the keyboard layout cannot be composed with the specified virtual key to form a single character.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The parameters supplied to the ToAscii function might not be sufficient to translate the virtual-key code, because 
		/// a previous dead key is stored in the keyboard layout. 
		/// <br/>
		/// <para>
		/// Typically, ToAscii performs the translation based on the virtual-key code. In some cases, however, bit 15 of the uScanCode parameter 
		/// may be used to distinguish between a key press and a key release. The scan code is used for translating ALT+ number key combinations.
		/// </para>
		/// <br/>
		/// <para>
		/// Although NUM LOCK is a toggle key that affects keyboard behavior, ToAscii ignores the toggle setting (the low bit) of 
		/// lpKeyState (VK_NUMLOCK) because the uVirtKey parameter alone is sufficient to distinguish the cursor movement keys 
		/// (VK_HOME, VK_INSERT, and so on) from the numeric keys (VK_DECIMAL, VK_NUMPAD0 - VK_NUMPAD9).
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int	ToAscii ( uint  uVirtKey, uint  uScanCode, byte []  lpKeyState,
								[Out] StringBuilder  lpChar,  uint uFlags ) ;
		# endregion


		# region Version with an OUT String
		/// <summary>
		/// Translates the specified virtual-key code and keyboard state to the corresponding character or characters. The function translates
		/// the code using the input language and physical keyboard layout identified by the keyboard layout handle.
		/// <br/>
		/// <para>
		/// To specify a handle to the keyboard layout to use to translate the specified code, use the ToAsciiEx function.
		/// </para>
		/// </summary>
		/// <param name="uVirtKey">The virtual-key code to be translated.</param>
		/// <param name="uScanCode">
		/// The hardware scan code of the key to be translated. The high-order bit of this value is set if the key is up (not pressed).
		/// </param>
		/// <param name="lpKeyState">
		/// A pointer to a 256-byte array that contains the current keyboard state. Each element (byte) in the array contains the state of one key. 
		/// If the high-order bit of a byte is set, the key is down (pressed). 
		/// </param>
		/// <param name="lpChar">The buffer that receives the translated character or characters. </param>
		/// <param name="uFlags">This parameter must be 1 if a menu is active, or 0 otherwise. </param>
		/// <returns>
		/// If the specified key is a dead key, the return value is negative. Otherwise, it is one of the following values :
		/// <para>. 0 : The specified virtual key has no translation for the current state of the keyboard.</para>
		/// <para>. 1 : One character was copied to the buffer.</para>
		/// <para>. 2 : Two characters were copied to the buffer. This usually happens when a dead-key character (accent or diacritic) stored 
		/// in the keyboard layout cannot be composed with the specified virtual key to form a single character.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The parameters supplied to the ToAscii function might not be sufficient to translate the virtual-key code, because 
		/// a previous dead key is stored in the keyboard layout. 
		/// <br/>
		/// <para>
		/// Typically, ToAscii performs the translation based on the virtual-key code. In some cases, however, bit 15 of the uScanCode parameter 
		/// may be used to distinguish between a key press and a key release. The scan code is used for translating ALT+ number key combinations.
		/// </para>
		/// <br/>
		/// <para>
		/// Although NUM LOCK is a toggle key that affects keyboard behavior, ToAscii ignores the toggle setting (the low bit) of 
		/// lpKeyState (VK_NUMLOCK) because the uVirtKey parameter alone is sufficient to distinguish the cursor movement keys 
		/// (VK_HOME, VK_INSERT, and so on) from the numeric keys (VK_DECIMAL, VK_NUMPAD0 - VK_NUMPAD9).
		/// </para>
		/// </remarks>
		public static int	ToAscii ( uint  uVirtKey, uint  uScanCode, byte []  lpKeyState, out String  lpChar,  uint uFlags )
		   {
			StringBuilder		SB		= new StringBuilder ( Defines. DEFAULT_OUT_STRING_LENGTH ) ;
			int			Status ;


			Status	=  ToAscii ( uVirtKey, uScanCode, lpKeyState, SB, uFlags ) ;
			lpChar  =  SB. ToString ( ) ;

			return ( Status ) ;
		    }
		# endregion
	    }
    }