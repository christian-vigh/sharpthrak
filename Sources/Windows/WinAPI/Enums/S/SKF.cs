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

	# region  SKF_ flags used for the dwFlags of the STICKYKEYS structure
	/// <summary>
	/// A set of bit-flags that specify properties of the StickyKeys feature.
	/// </summary>
	public enum  SKF_Constants	: uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		SKF_NONE			=  0x00000000,

		/// <summary>
		/// If this flag is set, the system plays a sound when the user latches, locks, or releases modifier keys using the StickyKeys feature.
		/// </summary>
		SKF_AUDIBLEFEEDBACK 		=  0x00000040,

		/// <summary>
		/// If this flag is set, the StickyKeys feature is available.
		/// </summary>
		SKF_AVAILABLE       		=  0x00000002,

		/// <summary>
		/// Windows 95/98, Windows 2000: A confirmation dialog appears when the StickyKeys feature is activated by using the hot key.
		/// </summary>
		SKF_CONFIRMHOTKEY   		=  0x00000008,

		/// <summary>
		/// If this flag is set, the user can turn the StickyKeys feature on and off by pressing the SHIFT key five times.
		/// </summary>
		SKF_HOTKEYACTIVE    		=  0x00000004,

		/// <summary>
		/// If this flag is set, the system plays a siren sound when the user turns the StickyKeys feature on or off by using the hot key.
		/// </summary>
		SKF_HOTKEYSOUND     		=  0x00000010,

		/// <summary>
		/// Windows 95/98, Windows 2000: A visual indicator should be displayed when the StickyKeys feature is on.
		/// </summary>
		SKF_INDICATOR       		=  0x00000020,

		/// <summary>
		/// Windows 98, Windows 2000: The left ALT key is latched.
		/// </summary>
		SKF_LALTLATCHED       		=  0x10000000,

		/// <summary>
		/// Windows 98, Windows 2000: The left ALT key is locked.
		/// </summary>
		SKF_LALTLOCKED        		=  0x00100000,

		/// <summary>
		/// Windows 98, Windows 2000: The left CTRL key is latched.
		/// </summary>
		SKF_LCTLLATCHED       		=  0x04000000,

		/// <summary>
		/// Windows 98, Windows 2000: The left CTRL key is locked.
		/// </summary>
		SKF_LCTLLOCKED        		=  0x00040000,

		/// <summary>
		/// Windows 98, Windows 2000: The left SHIFT key is latched.
		/// </summary>
		SKF_LSHIFTLATCHED     		=  0x01000000,

		/// <summary>
		/// Windows 98, Windows 2000: The left SHIFT key is locked.
		/// </summary>
		SKF_LSHIFTLOCKED      		=  0x00010000,

		/// <summary>
		/// Windows 98, Windows 2000: The left WIN key is latched.
		/// </summary>
		SKF_LWINLATCHED       		=  0x40000000,

		/// <summary>
		/// Windows 98, Windows 2000: The left WIN key is locked.
		/// </summary>
		SKF_LWINLOCKED        		=  0x00400000,

		/// <summary>
		/// Windows 98, Windows 2000: The right ALT key is latched.
		/// </summary>
		SKF_RALTLATCHED       		=  0x20000000,

		/// <summary>
		/// Windows 98, Windows 2000: The right ALT key is locked.
		/// </summary>
		SKF_RALTLOCKED        		=  0x00200000,

		/// <summary>
		/// Windows 98, Windows 2000: The right CTRL key is latched.
		/// </summary>
		SKF_RCTLLATCHED       		=  0x08000000,

		/// <summary>
		/// Windows 98, Windows 2000: The right CTRL key is locked.
		/// </summary>
		SKF_RCTLLOCKED        		=  0x00080000,

		/// <summary>
		/// Windows 98, Windows 2000: The right SHIFT key is latched.
		/// </summary>
		SKF_RSHIFTLATCHED     		=  0x02000000,

		/// <summary>
		/// Windows 98, Windows 2000: The right SHIFT key is locked.
		/// </summary>
		SKF_RSHIFTLOCKED      		=  0x00020000,

		/// <summary>
		/// Windows 98, Windows 2000: The right WIN key is latched.
		/// </summary>
		SKF_RWINLATCHED       		=  0x80000000,

		/// <summary>
		/// Windows 98, Windows 2000: The right WIN key is locked.
		/// </summary>
		SKF_RWINLOCKED        		=  0x00800000,

		/// <summary>
		/// If this flag is set, the StickyKeys feature is on.
		/// </summary>
		SKF_STICKYKEYSON    		=  0x00000001,

		/// <summary>
		/// If this flag is set, pressing a modifier key twice in a row locks down the key until the user presses it a third time.
		/// </summary>
		SKF_TRISTATE        		=  0x00000080,

		/// <summary>
		/// If this flag is set, releasing a modifier key that has been pressed in combination with any other key turns off the StickyKeys feature.
		/// </summary>
		SKF_TWOKEYSOFF      		=  0x00000100,
	    }
	# endregion
    }