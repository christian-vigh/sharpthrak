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
	# region Font _PRECIS constants
	/// <summary>
	/// Indicates a font precision.
	/// </summary>
	public enum  FONTPRECIS_Constants	:  byte
	   {
		/// <summary>
		/// Not used.
		/// </summary>
		OUT_CHARACTER_PRECIS        =  2,

		/// <summary>
		/// Specifies the default font mapper behavior.
		/// </summary>
		OUT_DEFAULT_PRECIS          =  0,

		/// <summary>
		/// Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.
		/// </summary>
		OUT_DEVICE_PRECIS           =  5,

		/// <summary>
		/// This value instructs the font mapper to choose from TrueType and other outline-based fonts.
		/// </summary>
		OUT_OUTLINE_PRECIS          =  8,

		/// <summary>
		/// Instructs the font mapper to choose from only PostScript fonts. 
		/// <para>
		/// If there are no PostScript fonts installed in the system, the font mapper returns to default behavior.
		/// </para>
		/// </summary>
		OUT_PS_ONLY_PRECIS          =  10,

		/// <summary>
		/// Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.
		/// </summary>
		OUT_RASTER_PRECIS           =  6,

		/// <summary>
		/// Instructs the font mapper to choose a screen font when possible.
		/// </summary>
		OUT_SCREEN_OUTLINE_PRECIS   =  9,

		/// <summary>
		/// This value is not used by the font mapper, but it is returned when raster fonts are enumerated.
		/// </summary>
		OUT_STRING_PRECIS           =  1,

		/// <summary>
		/// This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are enumerated.
		/// </summary>
		OUT_STROKE_PRECIS           =  3,

		/// <summary>
		/// Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper returns to default behavior.
		/// </summary>
		OUT_TT_ONLY_PRECIS          =  7,

		/// <summary>
		/// Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.
		/// </summary>
		OUT_TT_PRECIS               =  4
	    }
	# endregion
     }
