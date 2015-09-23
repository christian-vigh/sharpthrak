/**************************************************************************************************************

    NAME
        WinAPI/Enums/U/UWL.cs

    DESCRIPTION
        UWL constants.

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
	# region ULW_ constants
	/// <summary>
	/// </summary>
	public enum ULW_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		ULW_NONE		=  0x00000000,

		/// <summary>
		/// Use pblend as the blend function. If the display mode is 256 colors or less, the effect of this value is the same as the effect of ULW_OPAQUE.
		/// </summary>
		ULW_ALPHA		=  0x00000002,

		/// <summary>
		/// Use crKey as the transparency color. 
		/// </summary>
		ULW_COLORKEY		=  0x00000001,

		/// <summary>
		/// Draw an opaque layered window. 
		/// </summary>
		ULW_OPAQUE		=  0x00000004,

		/// <summary>
		/// Force the UpdateLayeredWindowIndirect function to fail if the current window size does not match the size specified in the psize.
		/// </summary>
		ULW_EX_NORESIZE         =  0x00000008
	    }
	# endregion
    }