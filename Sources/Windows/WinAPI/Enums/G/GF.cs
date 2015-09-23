/**************************************************************************************************************

    NAME
        WinAPI/Constants/G/GF.cs

    DESCRIPTION
        GF constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region GF_ constants
	/// <summary>
	/// Indicate the various states of the gestures 
	/// </summary>
	public enum GF_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		GF_NONE			=  0x00000000,

		/// <summary>
		/// A gesture is starting.
		/// </summary>
		GF_BEGIN		=  0x00000001,

		/// <summary>
		/// A gesture has triggered inertia.
		/// </summary>
		GF_INERTIA		=  0x00000002,

		/// <summary>
		/// A gesture has finished.
		/// </summary>
		GF_END			=  0x00000004
	    }
	# endregion
    }