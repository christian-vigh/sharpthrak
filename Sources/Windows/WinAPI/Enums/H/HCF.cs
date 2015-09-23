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
	# region HCF_ High contrast constants
	/// <summary>
	/// High-contrast option flags.
	/// </summary>
	public enum  HCF_Constants	:  uint
	   {
		/// <summary>
		/// No high-contrast flag specified.
		/// </summary>
		HCF_NONE			=  0x00000000,

		/// <summary>
		/// The high contrast feature is available.
		/// </summary>
		HCF_AVAILABLE			=  0x00000002,

		/// <summary>
		/// A confirmation dialog appears when the high contrast feature is activated by using the hot key.
		/// </summary>
		HCF_CONFIRMHOTKEY		=  0x00000008,

		/// <summary>
		/// The desktop to be affected is the default one.
		/// </summary>
		HCF_DEFAULTDESKTOP		=  0x00000200,

		/// <summary>
		/// The high contrast feature is on.
		/// </summary>
		HCF_HIGHCONTRASTON		=  0x00000001,

		/// <summary>
		/// The user can turn the high contrast feature on and off by simultaneously pressing the left ALT, left SHIFT, and PRINT SCREEN keys.
		/// </summary>
		HCF_HOTKEYACTIVE		=  0x00000004,

		/// <summary>
		/// The hot key associated with the high contrast feature can be enabled. An application can retrieve this value, but cannot set it.
		/// </summary>
		HCF_HOTKEYAVAILABLE		=  0x00000040,

		/// <summary>
		/// A siren is played when the user turns the high contrast feature on or off by using the hot key.
		/// </summary>
		HCF_HOTKEYSOUND			=  0x00000010,

		/// <summary>
		/// A visual indicator is displayed when the high contrast feature is on. This value is not currently used and is ignored.
 		/// </summary>
		HCF_INDICATOR			=  0x00000020,

		/// <summary>
		/// The desktop to be affected is the logon desktop.
		/// </summary>
		HCF_LOGONDESKTOP		=  0x00000100
	    }
	# endregion
   }