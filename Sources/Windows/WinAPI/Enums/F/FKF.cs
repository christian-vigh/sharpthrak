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

	# region FKF_ FilterKeys flags
	/// <summary>
	/// A set of bit flags that specify properties of the FilterKeys feature.
	/// </summary>
	public enum  FKF_Constants	: uint
	   {
		/// <summary>
		/// No flag defined.
		/// </summary>
		FKF_NONE			=  0x00000000,

		/// <summary>
		/// The FilterKeys features are available.
		/// </summary>
		FKF_AVAILABLE			=  0x00000002,

		/// <summary>
		/// The computer makes a click sound when a key is pressed or accepted. 
		/// <para>
		/// If SlowKeys is on, a click is generated when the key is pressed and again when the keystroke is accepted.
		/// </para>
		/// </summary>
		FKF_CLICKON			=  0x00000040,

		/// <summary>
		/// Windows 95/98, Windows 2000: A confirmation dialog box appears when the FilterKeys features are activated by using the hot key.
		/// </summary>
		FKF_CONFIRMHOTKEY		=  0x00000008,

		/// <summary>
		/// The FilterKeys features are on.
		/// </summary>
		FKF_FILTERKEYSON		=  0x00000001,

		/// <summary>
		/// The user can turn the FilterKeys feature on and off by holding down the RIGHT SHIFT key for eight seconds.
		/// </summary>
		FKF_HOTKEYACTIVE		=  0x00000004,

		/// <summary>
		/// If this flag is set, the computer plays a siren sound when the user turns the FilterKeys feature on or off by using the hot key.
		/// </summary>
		FKF_HOTKEYSOUND			=  0x00000010,

		/// <summary>
		/// Windows 95, Windows 2000: A visual indicator is displayed when the FilterKeys features are on.
		/// </summary>
		FKF_INDICATOR			=  0x00000020
	    }
	# endregion
    }