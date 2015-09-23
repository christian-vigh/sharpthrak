/**************************************************************************************************************

    NAME
        WinAPI/Functions/V/VkKeyScan.cs

    DESCRIPTION
        VkKeyScan() Windows function.

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
		/// This function has been superseded by the VkKeyScanEx function. You can still use VkKeyScan, however, 
		/// if you do not need to specify a keyboard layout.]
		/// <br/>
		/// <para>
		/// Translates a character to the corresponding virtual-key code and shift state for the current keyboard.
		/// </para>
		/// </summary>
		/// <param name="ch">The character to be translated into a virtual-key code. </param>
		/// <returns>
		/// If the function succeeds, the low-order byte of the return value contains the virtual-key code and the high-order byte contains
		/// the shift state, which can be a combination of the following flag bits :
		/// <para>1 : Either SHIFT key is pressed.</para>
		/// <para>2 : Either CTRL key is pressed.</para>
		/// <para>4 : Either ALT key is pressed.</para>
		/// <para>8 : The Hankaku key is pressed.</para>
		/// <para>16, 32 : Reserved (defined by the keyboard layout driver).</para>
		/// <br/>
		/// <para>
		/// If the function finds no key that translates to the passed character code, both the low-order and high-order bytes contain –1. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// For keyboard layouts that use the right-hand ALT key as a shift key (for example, the French keyboard layout), the shift state 
		/// is represented by the value 6, because the right-hand ALT key is converted internally into CTRL+ALT. 
		/// <br/>
		/// <para>
		/// Translations for the numeric keypad (VK_NUMPAD0 through VK_DIVIDE) are ignored. This function is intended to translate characters
		/// into keystrokes from the main keyboard section only. For example, the character "7" is translated into VK_7, not VK_NUMPAD7. 
		/// </para>
		/// <br/>
		/// <para>
		/// VkKeyScan is used by applications that send characters by using the WM_KEYUP and WM_KEYDOWN messages. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern short 	VkKeyScan ( char  ch ) ;
		# endregion
	    }
    }