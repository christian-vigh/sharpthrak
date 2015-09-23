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
	# region SSF_ constants used for the dwFlags field of the SOUNDSENTRY structure
	/// <summary>
	/// A set of bit flags that specify properties of the SoundSentry feature.
	/// </summary>
	public enum SSF_Constants		: uint
	   {
		/// <summary>
		/// Unintialized SSF flag.
		/// </summary>
		SSF_NONE			=  0x00000000,

		/// <summary>
		/// If this flag is set, the SoundSentry feature is available.
		/// </summary>
		SSF_AVAILABLE			=  0x00000002,

		/// <summary>
		/// This flag is not implemented.
		/// </summary>
		SSF_INDICATOR			=  0x00000004,

		/// <summary>
		/// If this flag is set, the SoundSentry feature is on.
		/// </summary>
		SSF_SOUNDSENTRYON		=  0x00000001
	    }
	# endregion
    }
