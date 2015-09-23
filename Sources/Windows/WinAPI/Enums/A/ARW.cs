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


	# region ARW_ constants used for minimized window arrangement
	/// <summary>
	/// The starting position and direction used when arranging minimized windows. 
	/// </summary>
	public enum ARW_Constants		: uint
	   {
		/// <summary>
		/// Default position (bottom left).
		/// </summary>
		ARW_DEFAULT		    =  ARW_BOTTOMLEFT,

		/// <summary>
		/// Start at the lower-left corner of the work area.
		/// </summary>
		ARW_BOTTOMLEFT              =  0x0000,

		/// <summary>
		/// Start at the lower-right corner of the work area.
		/// </summary>
		ARW_BOTTOMRIGHT             =  0x0001,

		/// <summary>
		/// Start at the upper-left corner of the work area.
		/// </summary>
		ARW_TOPLEFT                 =  0x0002,

		/// <summary>
		/// Start at the upper-right corner of the work area.
		/// </summary>
		ARW_TOPRIGHT                =  0x0003,

		/// <summary>
		/// Arrange left (valid with ARW_BOTTOMRIGHT and ARW_TOPRIGHT only).
		/// </summary>
		ARW_LEFT		    =  0x0000,

		/// <summary>
		/// Arrange right (valid with ARW_BOTTOMLEFT and ARW_TOPLEFT only).
		/// </summary>
		ARW_RIGHT		    =  0x0000,

		/// <summary>
		/// Arrange up (valid with ARW_BOTTOMLEFT and ARW_BOTTOMRIGHT only).
		/// </summary>
		ARW_UP                      =  0x0004,

		/// <summary>
		/// Arrange down (valid with ARW_TOPLEFT and ARW_TOPRIGHT only).
		/// </summary>
		ARW_DOWN                    =  0x0004,

		/// <summary>
		/// Hide minimized windows by moving them off the visible area of the screen.
		/// </summary>
		ARW_HIDE                    =  0x0008,

		/// <summary>
		/// Mask used to isolate start position.
		/// </summary>
		ARW_STARTMASK               =  0x0003,

		/// <summary>
		/// Mask used to isolate the start-right position.
		/// </summary>
		ARW_STARTRIGHT              =  0x0001,

		/// <summary>
		/// Mask used to isolate the start-top position.
		/// </summary>
		ARW_STARTTOP                =  0x0002
	    }
	# endregion
    }
