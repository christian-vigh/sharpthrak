/**************************************************************************************************************

    NAME
        WinAPI/Enums/L/LWA.cs

    DESCRIPTION
        LWA constants.

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
	# region LWA_ constants
	/// <summary>
	/// Layering flags. 
	/// </summary>
	public enum LWA_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		LWA_NONE		=  0x00000000,

		/// <summary>
		/// Use pbAlpha to determine the opacity of the layered window.
		/// </summary>
		LWA_ALPHA		=  0x00000002,

		/// <summary>
		/// Use pcrKey as the transparency color. 
		/// </summary>
		LWA_COLORKEY		=  0x00000001
	    }
	# endregion
    }