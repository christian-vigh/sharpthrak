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
	# region Font _QUALITY constants
	/// <summary>
	/// Indicates output quality for a font.
	/// </summary>
	public enum  FONTQUALITY_Constants	:  byte
	   {
		/// <summary>
		/// Font is always antialiased if the font supports it and the size of the font is not too small or too large.
		/// </summary>
		ANTIALIASED_QUALITY		=  4,

		/// <summary>
		/// If set, text is rendered (when possible) using ClearType antialiasing method.
		/// </summary>
		CLEARTYPE_QUALITY		=  5,

		/// <summary>
		/// If set, text is rendered using ClearType natural quality.
		/// </summary>
		CLEARTYPE_NATURAL_QUALITY	=  6,

		/// <summary>
		/// Appearance of the font does not matter.
		/// </summary>
		DEFAULT_QUALITY			=  0,

		/// <summary>
		/// Appearance of the font is less important than when PROOF_QUALITY is used. 
		/// <para>
		/// For GDI raster fonts, scaling is enabled, which means that more font sizes are available, but the quality may be lower. 
		/// Bold, italic, underline, and strikeout fonts are synthesized if necessary.
		/// </para>
		/// </summary>
		DRAFT_QUALITY			=  1,

		/// <summary>
		/// Font is never antialiased.
		/// </summary>
		NONANTIALIASED_QUALITY		=  3,

		/// <summary>
		/// Character quality of the font is more important than exact matching of the logical-font attributes. 
		/// <para>
		/// For GDI raster fonts, scaling is disabled and the font closest in size is chosen. 
		/// </para>
		/// <para>
		/// Although the chosen font size may not be mapped exactly when PROOF_QUALITY is used, the quality of the font is high 
		/// and there is no distortion of appearance. 
		/// </para>
		/// <para>
		/// Bold, italic, underline, and strikeout fonts are synthesized if necessary.
		/// </para>
		/// </summary>
		PROOF_QUALITY			=  2
	    }
	# endregion
     }
