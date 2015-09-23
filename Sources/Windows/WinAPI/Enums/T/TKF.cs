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

	# region  TKF_ flags used for the dwFlags of the TOGGLEKEYS structure
	/// <summary>
	/// A set of bit-flags that specify properties of the ToggleKeys feature.
	/// </summary>
	public enum  TKF_Constants	: uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		TKF_NONE			=  0x00000000,

		/// <summary>
		/// If this flag is set, the ToggleKeys feature is available.
		/// </summary>
		TKF_AVAILABLE			=  0x00000002,

		/// <summary>
		/// Windows 95/98, Windows 2000: A confirmation dialog box appears when the ToggleKeys feature is activated by using the hot key.
		/// </summary>
		TKF_CONFIRMHOTKEY		=  0x00000008,

		/// <summary>
		/// If this flag is set, the user can turn the ToggleKeys feature on and off by holding down the NUM LOCK key for eight seconds.
		/// </summary>
		TKF_HOTKEYACTIVE		=  0x00000004,

		/// <summary>
		/// If this flag is set, the system plays a siren sound when the user turns the ToggleKeys feature on or off by using the hot key.
		/// </summary>
		TKF_HOTKEYSOUND			=  0x00000010,

		/// <summary>
		/// This flag is not implemented.
		/// </summary>
		TKF_INDICATOR			=  0x00000020,

		/// <summary>
		/// If this flag is set, the ToggleKeys feature is on.
		/// </summary>
		TKF_TOGGLEKEYSON		=  0x00000001
	    }
	# endregion
    }