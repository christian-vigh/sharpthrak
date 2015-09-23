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
	# region Font _PITCH constants
	/// <summary>
	/// Indicates font pitch and quality.
	/// </summary>
	public enum  FONTPITCH_Constants	:  byte
	   {
		/// <summary>
		/// Use default font pitch.
		/// </summary>
		DEFAULT_PITCH		=  0,

		/// <summary>
		/// Use fixed-width pitch.
		/// </summary>
		FIXED_PITCH		=  1,

		/// <summary>
		/// Use variable-width font pitch.
		/// </summary>
		VARIABLE_PITCH		=  2,

		/// <summary>
		/// Novelty fonts. Old English is an example.
		/// </summary>
		FF_DECORATIVE		=  ( 5 << 4 ),

		/// <summary>
		/// Use default font.
		/// </summary>
		FF_DONTCARE		=  ( 0 << 4 ),

		/// <summary>
		/// Fonts with constant stroke width (monospace), with or without serifs. Monospace fonts are usually modern. 
		/// Pica, Elite, and Courier New are examples.
		/// </summary>
		FF_MODERN		=  ( 3 << 4 ),

		/// <summary>
		/// Fonts with variable stroke width (proportional) and with serifs. MS Serif is an example.
		/// </summary>
		FF_ROMAN		=  ( 1 << 4 ),

		/// <summary>
		/// Fonts designed to look like handwriting. Script and Cursive are examples.
		/// </summary>
		FF_SCRIPT		=  ( 4 << 4 ),

		/// <summary>
		/// Fonts with variable stroke width (proportional) and without serifs. MS Sans Serif is an example.
		/// </summary>
		FF_SWISS		=  ( 2 << 4 )
	    }
	# endregion
     }
