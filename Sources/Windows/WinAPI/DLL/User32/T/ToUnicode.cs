/**************************************************************************************************************

    NAME
        WinAPI/Functions/T/ToUnicode.cs

    DESCRIPTION
        ToUnicode() Windows function.

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
		/// Translates the specified virtual-key code and keyboard state to the corresponding Unicode character or characters.
		/// <br/>
		/// <para>
		/// To specify a handle to the keyboard layout to use to translate the specified code, use the ToUnicodeEx function.
		/// </para>
		/// </summary>
		/// <param name="uVirtKey">The virtual-key code to be translated.</param>
		/// <param name="uScanCode">
		/// The hardware scan code of the key to be translated. The high-order bit of this value is set if the key is up.
		/// </param>
		/// <param name="lpKeyState">
		/// A pointer to a 256-byte array that contains the current keyboard state. Each element (byte) in the array contains the state of one key. 
		/// If the high-order bit of a byte is set, the key is down.
		/// </param>
		/// <param name="pwszBuff">
		/// The buffer that receives the translated Unicode character or characters. However, this buffer may be returned without being 
		/// null-terminated even though the variable name suggests that it is null-terminated.
		/// </param>
		/// <param name="cchBuff">The size, in characters, of the buffer pointed to by the pwszBuff parameter.</param>
		/// <param name="wFlags">The behavior of the function. If bit 0 is set, a menu is active. Bits 1 through 31 are reserved.</param>
		/// <returns>
		/// The function returns one of the following values :
		/// <para>
		/// -1 : The specified virtual key is a dead-key character (accent or diacritic). This value is returned regardless of the keyboard layout, 
		/// even if several characters have been typed and are stored in the keyboard state. If possible, even with Unicode keyboard layouts, 
		/// the function has written a spacing version of the dead-key character to the buffer specified by pwszBuff. 
		/// For example, the function writes the character SPACING ACUTE (0x00B4), rather than the character NON_SPACING ACUTE (0x0301).
		/// </para>
		/// <para>
		/// 0 : The specified virtual key has no translation for the current state of the keyboard. Nothing was written to the buffer specified by pwszBuff.
		/// </para>
		/// <para>
		/// 1 : One character was written to the buffer specified by pwszBuff.
		/// </para>
		/// <para>
		/// >= 2 : Two or more characters were written to the buffer specified by pwszBuff. The most common cause for this is that 
		/// a dead-key character (accent or diacritic) stored in the keyboard layout could not be combined with the specified virtual key 
		/// to form a single character. However, the buffer may contain more characters than the return value specifies. 
		/// When this happens, any extra characters are invalid and should be ignored.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The parameters supplied to the ToUnicode function might not be sufficient to translate the virtual-key code because a previous dead key 
		/// is stored in the keyboard layout.
		/// <br/>
		/// <para>
		/// Typically, ToUnicode performs the translation based on the virtual-key code. In some cases, however, bit 15 of the wScanCode parameter
		/// can be used to distinguish between a key press and a key release.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		static extern int  ToUnicode ( uint  uVirtKey, uint  uScanCode, byte []  lpKeyState,
						[Out, MarshalAs (UnmanagedType. LPWStr, SizeConst = 64 )] StringBuilder  pwszBuff, 
						int  cchBuff, uint  wFlags ) ;
		# endregion


		# region Version with Out String for the pwszBuff parameter
		/// <summary>
		/// Translates the specified virtual-key code and keyboard state to the corresponding Unicode character or characters.
		/// <br/>
		/// <para>
		/// To specify a handle to the keyboard layout to use to translate the specified code, use the ToUnicodeEx function.
		/// </para>
		/// </summary>
		/// <param name="uVirtKey">The virtual-key code to be translated.</param>
		/// <param name="uScanCode">
		/// The hardware scan code of the key to be translated. The high-order bit of this value is set if the key is up.
		/// </param>
		/// <param name="lpKeyState">
		/// A pointer to a 256-byte array that contains the current keyboard state. Each element (byte) in the array contains the state of one key. 
		/// If the high-order bit of a byte is set, the key is down.
		/// </param>
		/// <param name="pwszBuff">
		/// The buffer that receives the translated Unicode character or characters. However, this buffer may be returned without being 
		/// null-terminated even though the variable name suggests that it is null-terminated.
		/// </param>
		/// <param name="cchBuff">The size, in characters, of the buffer pointed to by the pwszBuff parameter.</param>
		/// <param name="wFlags">The behavior of the function. If bit 0 is set, a menu is active. Bits 1 through 31 are reserved.</param>
		/// <returns>
		/// The function returns one of the following values :
		/// <para>
		/// -1 : The specified virtual key is a dead-key character (accent or diacritic). This value is returned regardless of the keyboard layout, 
		/// even if several characters have been typed and are stored in the keyboard state. If possible, even with Unicode keyboard layouts, 
		/// the function has written a spacing version of the dead-key character to the buffer specified by pwszBuff. 
		/// For example, the function writes the character SPACING ACUTE (0x00B4), rather than the character NON_SPACING ACUTE (0x0301).
		/// </para>
		/// <para>
		/// 0 : The specified virtual key has no translation for the current state of the keyboard. Nothing was written to the buffer specified by pwszBuff.
		/// </para>
		/// <para>
		/// 1 : One character was written to the buffer specified by pwszBuff.
		/// </para>
		/// <para>
		/// >= 2 : Two or more characters were written to the buffer specified by pwszBuff. The most common cause for this is that 
		/// a dead-key character (accent or diacritic) stored in the keyboard layout could not be combined with the specified virtual key 
		/// to form a single character. However, the buffer may contain more characters than the return value specifies. 
		/// When this happens, any extra characters are invalid and should be ignored.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The parameters supplied to the ToUnicode function might not be sufficient to translate the virtual-key code because a previous dead key 
		/// is stored in the keyboard layout.
		/// <br/>
		/// <para>
		/// Typically, ToUnicode performs the translation based on the virtual-key code. In some cases, however, bit 15 of the wScanCode parameter
		/// can be used to distinguish between a key press and a key release.
		/// </para>
		/// </remarks>
		static int  ToUnicode ( uint  uVirtKey, uint  uScanCode, byte []  lpKeyState,
						out String  pwszBuff, int  cchBuff, uint  wFlags )
		   {
			StringBuilder		SB		= new StringBuilder ( System. Math. Max ( cchBuff, 64 ) ) ;
			int			Status ;


			Status		=  ToUnicode ( uVirtKey, uScanCode, lpKeyState, SB, cchBuff, wFlags ) ;
			pwszBuff	=  SB. ToString ( ) ;

			return ( Status ) ;
		    }
		# endregion
	    }
    }