/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	# region VK_ virtual key codes
	public enum  VK_Constants	:  byte
	   {
		/// <summary>Keyboard digit 0.</summary>
		VK_0				=  0x30,
		/// <summary>Keyboard digit 1.</summary>
		VK_1				=  0x31,
		/// <summary>Keyboard digit 2.</summary>
		VK_2				=  0x32,
		/// <summary>Keyboard digit 3.</summary>
		VK_3				=  0x33,
		/// <summary>Keyboard digit 4.</summary>
		VK_4				=  0x34,
		/// <summary>Keyboard digit 5.</summary>
		VK_5				=  0x35,
		/// <summary>Keyboard digit 6.</summary>
		VK_6				=  0x36,
		/// <summary>Keyboard digit 7.</summary>
		VK_7				=  0x37,
		/// <summary>Keyboard digit 8.</summary>
		VK_8				=  0x38,
		/// <summary>Keyboard digit 9.</summary>
		VK_9				=  0x39,
		/// <summary>Keyboard letter 'A'.</summary>
		VK_A				=  0x41,
		/// <summary>IME Accept command.</summary>
		VK_ACCEPT         		=  0x1E,
		/// <summary>Add key.</summary>
		VK_ADD            		=  0x6B,
		/// <summary>Windows key.</summary>
		VK_APPS           		=  0x5D,
		/// <summary>Attn key.</summary>
		VK_ATTN           		=  0xF6,
		/// <summary>Keyboard letter 'B'.</summary>
		VK_B				=  0x42,
		/// <summary>Backspace key.</summary>
		VK_BACK           		=  0x08,
		/// <summary>Browser back key.</summary>
		VK_BROWSER_BACK        		=  0xA6,
		/// <summary>Open browser favorites key.</summary>
		VK_BROWSER_FAVORITES   		=  0xAB,
		/// <summary>Browser forward key.</summary>
		VK_BROWSER_FORWARD     		=  0xA7,
		/// <summary>Browser home key.</summary>
		VK_BROWSER_HOME        		=  0xAC,
		/// <summary>Browser refresh page key.</summary>
		VK_BROWSER_REFRESH     		=  0xA8,
		/// <summary>Browser start search key.</summary>
		VK_BROWSER_SEARCH      		=  0xAA,
		/// <summary>Browser stop key.</summary>
		VK_BROWSER_STOP        		=  0xA9,
		/// <summary>Keyboard letter 'C'.</summary>
		VK_C				=  0x43,
		/// <summary>Control+Break processing.</summary>
		VK_CANCEL         		=  0x03,
		/// <summary>CapsLock key.</summary>
		VK_CAPITAL        		=  0x14,
		/// <summary>Clear key.</summary>
		VK_CLEAR          		=  0x0C,
		/// <summary>CTRL key.</summary>
		VK_CONTROL        		=  0x11,
		/// <summary>IME convert key.</summary>
		VK_CONVERT        		=  0x1C,
		/// <summary>CrSel key (Nokia/Ericsson definitions).</summary>
		VK_CRSEL          		=  0xF7,
		/// <summary>Keyboard letter 'D'.</summary>
		VK_D				=  0x44,
		/// <summary>Decimal key (decimal point).</summary>
		VK_DECIMAL       		=  0x6E,
		/// <summary>DEL key.</summary>
		VK_DELETE         		=  0x2E,
		/// <summary>Divide (/) key.</summary>
		VK_DIVIDE         		=  0x6F,
		/// <summary>Down arrow key.</summary>
		VK_DOWN           		=  0x28,
		/// <summary>Keyboard letter 'E'.</summary>
		VK_E				=  0x45,
		/// <summary>END key.</summary>
		VK_END            		=  0x23,
		/// <summary>Erase EOF key (Nokia/Ericsson definition).</summary>
		VK_EREOF          		=  0xF9,
		/// <summary>ESC key.</summary>
		VK_ESCAPE         		=  0x1B,
		/// <summary>EXECUTE key.</summary>
		VK_EXECUTE        		=  0x2B,
		/// <summary>ExSel key (Nokia/Ericsson definitions).</summary>
		VK_EXSEL          		=  0xF8,
		/// <summary>Keyboard letter 'F'.</summary>
		VK_F				=  0x46,
		/// <summary>F1 key.</summary>
		VK_F1             		=  0x70,
		/// <summary>F10 key.</summary>
		VK_F10            		=  0x79,
		/// <summary>F11 key.</summary>
		VK_F11            		=  0x7A,
		/// <summary>F12 key.</summary>
		VK_F12            		=  0x7B,
		/// <summary>F13 key.</summary>
		VK_F13            		=  0x7C,
		/// <summary>F14 key.</summary>
		VK_F14            		=  0x7D,
		/// <summary>F15 key.</summary>
		VK_F15            		=  0x7E,
		/// <summary>F16 key.</summary>
		VK_F16            		=  0x7F,
		/// <summary>F17 key.</summary>
		VK_F17            		=  0x80,
		/// <summary>F18 key.</summary>
		VK_F18            		=  0x81,
		/// <summary>F19 key.</summary>
		VK_F19            		=  0x82,
		/// <summary>F2 key.</summary>
		VK_F2             		=  0x71,
		/// <summary>F20 key.</summary>
		VK_F20            		=  0x83,
		/// <summary>F21 key.</summary>
		VK_F21            		=  0x84,
		/// <summary>F22 key.</summary>
		VK_F22            		=  0x85,
		/// <summary>F23 key.</summary>
		VK_F23            		=  0x86,
		/// <summary>F24 key.</summary>
		VK_F24            		=  0x87,
		/// <summary>F3 key.</summary>
		VK_F3             		=  0x72,
		/// <summary>F4 key.</summary>
		VK_F4             		=  0x73,
		/// <summary>F5 key.</summary>
		VK_F5             		=  0x74,
		/// <summary>F6 key.</summary>
		VK_F6             		=  0x75,
		/// <summary>F7 key.</summary>
		VK_F7             		=  0x76,
		/// <summary>F8 key.</summary>
		VK_F8             		=  0x77,
		/// <summary>F9 key.</summary>
		VK_F9             		=  0x78,
		/// <summary>IME final mode.</summary>
		VK_FINAL          		=  0x18,
		/// <summary>Keyboard letter 'G'.</summary>
		VK_G				=  0x47,
		/// <summary>Keyboard letter 'H'.</summary>
		VK_H				=  0x48,
		/// <summary>IME Hangeul mode (maintained for compatibility ; use VK_HANGUL instead).</summary>
		VK_HANGEUL        		=  0x15,
		/// <summary>IME Hangul mode.</summary>
		VK_HANGUL         		=  0x15,
		/// <summary>IME Hanja mode.</summary>
		VK_HANJA          		=  0x19,
		/// <summary>HELP key.</summary>
		VK_HELP           		=  0x2F,
		/// <summary>HOME key.</summary>
		VK_HOME           		=  0x24,
		/// <summary>Keyboard letter 'I'.</summary>
		VK_I				=  0x49,
		/// <summary>00 key on ICO.</summary>
		VK_ICO_00         		=  0xE4,
		/// <summary>CLEAR key.</summary>
		VK_ICO_CLEAR      		=  0xE6,
		/// <summary>HELP key on ICO.</summary>
		VK_ICO_HELP       		=  0xE3,
		/// <summary>INS key.</summary>
		VK_INSERT         		=  0x2D,
		/// <summary>Keyboard letter 'J'.</summary>
		VK_J				=  0x4A,
		/// <summary>IME Junja mode.</summary>
		VK_JUNJA          		=  0x17,
		/// <summary>Keyboard letter 'K'.</summary>
		VK_K				=  0x4B,
		/// <summary>IME Kana mode.</summary>
		VK_KANA           		=  0x15,
		/// <summary>IME Kanji mode.</summary>
		VK_KANJI          		=  0x19,
		/// <summary>Keyboard letter 'L'.</summary>
		VK_L				=  0x4C,
		/// <summary>Start application 1 key.</summary>
		VK_LAUNCH_APP1         		=  0xB6,
		/// <summary>Start application 2 key.</summary>
		VK_LAUNCH_APP2         		=  0xB7,
		/// <summary>Start mail key.</summary>
		VK_LAUNCH_MAIL         		=  0xB4,
		/// <summary>Select media key.</summary>
		VK_LAUNCH_MEDIA_SELECT 		=  0xB5,
		/// <summary>Left mouse button.</summary>
		VK_LBUTTON        		=  0x01,
		/// <summary>Left CTRL key (Used only as parameters to GetAsyncKeyState() and GetKeyState(). No other API or message will distinguish left and right keys in this way.).</summary>
		VK_LCONTROL       		=  0xA2,
		/// <summary>LEFT direction key.</summary>
		VK_LEFT           		=  0x25,
		/// <summary>Left menu key (Used only as parameters to GetAsyncKeyState() and GetKeyState(). No other API or message will distinguish left and right keys in this way.).</summary>
		VK_LMENU          		=  0xA4,
		/// <summary>Left SHIFT key (Used only as parameters to GetAsyncKeyState() and GetKeyState(). No other API or message will distinguish left and right keys in this way.).</summary>
		VK_LSHIFT         		=  0xA0,
		/// <summary>Left WINDOWS key.</summary>
		VK_LWIN           		=  0x5B,
		/// <summary>Keyboard letter 'M'.</summary>
		VK_M				=  0x4D,
		/// <summary>Middle mouse button.</summary>
		VK_MBUTTON        		=  0x04,
		/// <summary>Media next track key.</summary>
		VK_MEDIA_NEXT_TRACK    		=  0xB0,
		/// <summary>Media play or pause key.</summary>
		VK_MEDIA_PLAY_PAUSE    		=  0xB3,
		/// <summary>Media previous track key.</summary>
		VK_MEDIA_PREV_TRACK    		=  0xB1,
		/// <summary>Media stop key.</summary>
		VK_MEDIA_STOP          		=  0xB2,
		/// <summary>ALT key.</summary>
		VK_MENU           		=  0x12,
		/// <summary>IME mode change request key.</summary>
		VK_MODECHANGE     		=  0x1F,
		/// <summary>Multiply (*) key.</summary>
		VK_MULTIPLY       		=  0x6A,
		/// <summary>Keyboard letter 'N'.</summary>
		VK_N				=  0x4E,
		/// <summary>PAGE DOWN key.</summary>
		VK_NEXT           		=  0x22,
		/// <summary>Reserved (Nokia/Ericsson definitions).</summary>
		VK_NONAME         		=  0xFC,
		/// <summary>IME nonconvert key.</summary>
		VK_NONCONVERT     		=  0x1D,
		/// <summary>NUMLOCK key.</summary>
		VK_NUMLOCK        		=  0x90,
		/// <summary>Keypad digit 0 key.</summary>
		VK_NUMPAD0        		=  0x60,
		/// <summary>Keypad digit 1 key.</summary>
		VK_NUMPAD1        		=  0x61,
		/// <summary>Keypad digit 2 key.</summary>
		VK_NUMPAD2        		=  0x62,
		/// <summary>Keypad digit 3 key.</summary>
		VK_NUMPAD3        		=  0x63,
		/// <summary>Keypad digit 4 key.</summary>
		VK_NUMPAD4        		=  0x64,
		/// <summary>Keypad digit 5 key.</summary>
		VK_NUMPAD5        		=  0x65,
		/// <summary>Keypad digit 6 key.</summary>
		VK_NUMPAD6        		=  0x66,
		/// <summary>Keypad digit 7 key.</summary>
		VK_NUMPAD7        		=  0x67,
		/// <summary>Keypad digit 8 key.</summary>
		VK_NUMPAD8        		=  0x68,
		/// <summary>Keypad digit 9 key.</summary>
		VK_NUMPAD9        		=  0x69,
		/// <summary>Keyboard letter 'O'.</summary>
		VK_O				=  0x4F,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ';:' key.</summary>
		VK_OEM_1          		=  0xBA,
		/// <summary>Either the angle bracket key or the backslash key on the RT 102-key keyboard.</summary>
		VK_OEM_102        		=  0xE2,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '/?' key.</summary>
		VK_OEM_2          		=  0xBF,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '`~' key.</summary>
		VK_OEM_3          		=  0xC0,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '[{' key.</summary>
		VK_OEM_4          		=  0xDB,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '\|' key.</summary>
		VK_OEM_5          		=  0xDC,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ']}' key.</summary>
		VK_OEM_6          		=  0xDD,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key.</summary>
		VK_OEM_7          		=  0xDE,
		/// <summary>Used for miscellaneous characters; it can vary by keyboard.</summary>
		VK_OEM_8          		=  0xDF,
		/// <summary>ATTN key (Nokia/Ericsson definitions).</summary>
		VK_OEM_ATTN       		=  0xF0,
		/// <summary>AUTO key (Nokia/Ericsson definitions).</summary>
		VK_OEM_AUTO       		=  0xF3,
		/// <summary>'AX' key on Japanese AX keyboard.</summary>
		VK_OEM_AX         		=  0xE1,
		/// <summary>BACKTAB key (Nokia/Ericsson definitions).</summary>
		VK_OEM_BACKTAB    		=  0xF5,
		/// <summary>CLEAR key (Nokia/Ericsson definitions).</summary>
		VK_OEM_CLEAR      		=  0xFE,
		/// <summary>For any country/region, the ',' key.</summary>
		VK_OEM_COMMA      		=  0xBC,
		/// <summary>COPY key (Nokia/Ericsson definitions).</summary>
		VK_OEM_COPY       		=  0xF2,
		/// <summary>CUSEL key (Nokia/Ericsson definitions).</summary>
		VK_OEM_CUSEL      		=  0xEF,
		/// <summary>ENLW key (Nokia/Ericsson definitions).</summary>
		VK_OEM_ENLW       		=  0xF4,
		/// <summary>FINISH key (Nokia/Ericsson definitions).</summary>
		VK_OEM_FINISH     		=  0xF1,
		/// <summary>Fujitsu/OASYS kbd definitions : 'Dictionary' key.</summary>
		VK_OEM_FJ_JISHO   		=  0x92,
		/// <summary>Fujitsu/OASYS kbd definitions : 'Left OYAYUBI' key.</summary>
		VK_OEM_FJ_LOYA    		=  0x95,
		/// <summary>Fujitsu/OASYS kbd definitions : 'Unregister word' key.</summary>
		VK_OEM_FJ_MASSHOU 		=  0x93,
		/// <summary>Fujitsu/OASYS kbd definitions : 'Right OYAYUBI' key.</summary>
		VK_OEM_FJ_ROYA    		=  0x96,
		/// <summary>Fujitsu/OASYS kbd definitions : 'Register word' key.</summary>
		VK_OEM_FJ_TOUROKU 		=  0x94,
		/// <summary>JUMP key (Nokia/Ericsson definitions).</summary>
		VK_OEM_JUMP       		=  0xEA,
		/// <summary>Minus sign ('-') for any country/region.</summary>
		VK_OEM_MINUS      		=  0xBD,
		/// <summary>NEC PC9000 definitions : '=' key on numeric pad.</summary>
		VK_OEM_NEC_EQUAL  		=  0x92,
		/// <summary>PA1 key (Nokia/Ericsson definitions).</summary>
		VK_OEM_PA1        		=  0xEB,
		/// <summary>PA2 key (Nokia/Ericsson definitions).</summary>
		VK_OEM_PA2        		=  0xEC,
		/// <summary>PA3 key (Nokia/Ericsson definitions).</summary>
		VK_OEM_PA3        		=  0xED,
		/// <summary>Dot sign ('.') for any country/region.</summary>
		VK_OEM_PERIOD     		=  0xBE,
		/// <summary>Plus sign ('+' for any country/region.</summary>
		VK_OEM_PLUS       		=  0xBB,
		/// <summary>RESET key (Nokia/Ericsson definitions).</summary>
		VK_OEM_RESET      		=  0xE9,
		/// <summary>WSCTRL key (Nokia/Ericsson definitions).</summary>
		VK_OEM_WSCTRL     		=  0xEE,
		/// <summary>Keyboard letter 'P'.</summary>
		VK_P				=  0x50,
		/// <summary>PA1 key (Nokia/Ericsson definitions).</summary>
		VK_PA1            		=  0xFD,
		/// <summary>Used to pass Unicode characters as if they were keystrokes. 
		/// The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods</summary>
		VK_PACKET         		=  0xE7,
		/// <summary>PAUSE key.</summary>
		VK_PAUSE          		=  0x13,
		/// <summary>PLAY key (Nokia/Ericsson definitions).</summary>
		VK_PLAY           		=  0xFA,
		/// <summary>PRINT key.</summary>
		VK_PRINT          		=  0x2A,
		/// <summary>PAGE UP key.</summary>
		VK_PRIOR          		=  0x21,
		/// <summary>IME PROCESS key.</summary>
		VK_PROCESSKEY     		=  0xE5,
		/// <summary>Keyboard letter 'Q'.</summary>
		VK_Q				=  0x51,
		/// <summary>Keyboard letter 'R'.</summary>
		VK_R				=  0x52,
		/// <summary>Right mouse button.</summary>
		VK_RBUTTON        		=  0x02,
		/// <summary>Right CTRL key (Used only as parameters to GetAsyncKeyState() and GetKeyState(). No other API or message will distinguish left and right keys in this way.).</summary>
		VK_RCONTROL       		=  0xA3,
		/// <summary>ENTER key.</summary>
		VK_RETURN         		=  0x0D,
		/// <summary>Right direction key.</summary>
		VK_RIGHT          		=  0x27,
		/// <summary>Right menu key (Used only as parameters to GetAsyncKeyState() and GetKeyState(). No other API or message will distinguish left and right keys in this way.).</summary>
		VK_RMENU          		=  0xA5,
		/// <summary>Right SHIFT key (Used only as parameters to GetAsyncKeyState() and GetKeyState(). No other API or message will distinguish left and right keys in this way.).</summary>
		VK_RSHIFT         		=  0xA1,
		/// <summary>Right WINDOWS key.</summary>
		VK_RWIN           		=  0x5C,
		/// <summary>Keyboard letter 'S'.</summary>
		VK_S				=  0x53,
		/// <summary>SCROLL key.</summary>
		VK_SCROLL         		=  0x91,
		/// <summary>SELECT key.</summary>
		VK_SELECT         		=  0x29,
		/// <summary>SEPARATOR key.</summary>
		VK_SEPARATOR      		=  0x6C,
		/// <summary>SHIFT key, either left or right.</summary>
		VK_SHIFT          		=  0x10,
		/// <summary>Computer sleep key.</summary>
		VK_SLEEP          		=  0x5F,
		/// <summary>PRINT SCREEN key.</summary>
		VK_SNAPSHOT       		=  0x2C,
		/// <summary>Space key.</summary>
		VK_SPACE          		=  0x20,
		/// <summary>Subtract key.</summary>
		VK_SUBTRACT       		=  0x6D,
		/// <summary>Keyboard letter 'T'.</summary>
		VK_T				=  0x54,
		/// <summary>TAB key.</summary>
		VK_TAB            		=  0x09,
		/// <summary>Keyboard letter 'U'.</summary>
		VK_U				=  0x55,
		/// <summary>UP direction key.</summary>
		VK_UP             		=  0x26,
		/// <summary>Keyboard letter 'V'.</summary>
		VK_V				=  0x56,
		/// <summary>Volume down key.</summary>
		VK_VOLUME_DOWN         		=  0xAE,
		/// <summary>Volume mute key.</summary>
		VK_VOLUME_MUTE         		=  0xAD,
		/// <summary>Volume up key.</summary>
		VK_VOLUME_UP           		=  0xAF,
		/// <summary>Keyboard letter 'W'.</summary>
		VK_W				=  0x57,
		/// <summary>Keyboard letter 'X'.</summary>
		VK_X				=  0x58,
		/// <summary>X1 mouse button.</summary>
		VK_XBUTTON1       		=  0x05,
		/// <summary>X2 mouse button.</summary>
		VK_XBUTTON2       		=  0x06,
		/// <summary>Keyboard letter 'Y'.</summary>
		VK_Y				=  0x59,
		/// <summary>Keyboard letter 'Z'.</summary>
		VK_Z				=  0x5A,
		/// <summary>ZOOM key (Nokia/Ericsson definitions).</summary>
		VK_ZOOM          	 	=  0xFB,

		/// <summary>Virtual key code for min digit value.</summary>
		VK_DIGIT_MIN			=  0x30,
		/// <summary>Virtual key code for max digit value.</summary>
		VK_DIGIT_MAX			=  0x39,
		/// <summary>Virtual key code for min letter value.</summary>
		VK_LETTER_MIN			=  0x41,
		/// <summary>Virtual key code for max letter value.</summary>
		VK_LETTER_MAX			=  0x5A
	    }
	# endregion
    }
