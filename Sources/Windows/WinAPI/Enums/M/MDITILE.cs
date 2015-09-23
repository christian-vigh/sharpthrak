/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MDITILE.cs

    DESCRIPTION
        MDITILE constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region MDITILE_ constants
	/// <summary>
	/// MDI windows tiling constants.
	/// </summary>
	public enum MDITILE_Constants : int
	   {
		/// <summary>
		/// Tile Windows vertically.
		/// </summary>
		MDITILE_VERTICAL       =  0x0000,

		/// <summary>
		/// Tile windows horizontally.
		/// </summary>
		MDITILE_HORIZONTAL     =  0x0001,

		/// <summary>
		/// Prevents disabled MDI child windows from being cascaded. 
		/// </summary>
		MDITILE_SKIPDISABLED   =  0x0002,

		/// <summary>
		/// Arranges the windows in Z order.
		/// </summary>
		MDITILE_ZORDER         =  0x0004,

		/// <summary>
		/// Zero value.
		/// </summary>
		MDITILE_NONE		=  0x0000,
	    }
	# endregion
    }