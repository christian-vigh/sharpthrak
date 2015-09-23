/**************************************************************************************************************

    NAME
        WinAPI/Enums/A/AC_SRC.cs

    DESCRIPTION
        AC_SRC constants.

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
	# region AC_SRC_ constants
	/// <summary>
	/// Controls the way the source and destination bitmaps are interpreted.
	/// </summary>
	public enum AC_SRC_Constants : byte
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		AC_SRC_NONE			=  0x00,

		/// <summary>
		/// The source bitmap is placed over the destination bitmap based on the alpha values of the source pixels.
		/// </summary>
		AC_SRC_OVER			=  0x00,

		/// <summary>
		/// This flag is set when the bitmap has an Alpha channel (that is, per-pixel alpha). Note that the APIs use premultiplied alpha, which means that the 
		/// red, green and blue channel values in the bitmap must be premultiplied with the alpha channel value. 
		/// For example, if the alpha channel value is x, the red, green and blue channels must be multiplied by x and divided by 0xff prior to the call.
		/// </summary>
		AC_SRC_ALPHA			=  0x01,
	    }
	# endregion
    }