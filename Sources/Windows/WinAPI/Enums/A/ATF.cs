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


	# region ATF_ constants used in the dwFlags field of the ACCESSTIMEOUT structure
	/// <summary>
	/// A set of bit flags that specify properties of the time-out behavior for accessibility features.
	/// <para>
	/// Used in the dwFlags member of the ACCESSTIMEOUT structure.
	/// </para>
	/// </summary>
	public enum ATF_Constants		: uint
	   {
		/// <summary>
		/// Empty value.
		/// </summary>
		ATF_NONE			=  0x00000000,

		/// <summary>
		/// If this flag is set, a time-out period has been set for accessibility features. 
		/// <para>
		/// If this flag is not set, the features will not time out even though a time-out period is specified.
		/// </para>
		/// </summary>
		ATF_TIMEOUTON			=  0x00000001,

		/// <summary>
		/// If this flag is set, the operating system plays a descending siren sound when the time-out period elapses 
		/// and the accessibility features are turned off.
		/// </summary>
		ATF_ONOFFFEEDBACK		=  0x00000002
	    }
	# endregion
    }
