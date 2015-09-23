/**************************************************************************************************************

    NAME
        WinAPI/Constants/W/WMSZ.cs

    DESCRIPTION
        WPARAM value for WM_SIZING message.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	# region WMSZ_ constants for the WPARAM of the WM_SIZING message
	/// <summary>
	/// Specifies the edge of the window that is being sized. 
	/// </summary>
	public enum WMSZ_Constants : short
	   { 
		/// <summary>
		/// Bottom edge.
		/// </summary>
		WMSZ_BOTTOM			=  6,

		/// <summary>
		/// Bottom-left corner.
		/// </summary>
		WMSZ_BOTTOMLEFT			=  7,

		/// <summary>
		/// Bottom-right corner.
		/// </summary>
		WMSZ_BOTTOMRIGHT		=  8,

		/// <summary>
		/// Left edge.
		/// </summary>
		WMSZ_LEFT			=  1,

		/// <summary>
		/// Right edge.
		/// </summary>
		WMSZ_RIGHT			=  2,

		/// <summary>
		/// Top edge.
		/// </summary>
		WMSZ_TOP			=  3,

		/// <summary>
		/// Top-left corner.
		/// </summary>
		WMSZ_TOPLEFT			=  4,

		/// <summary>
		/// Top-right corner.
		/// </summary>
		WMSZ_TOPRIGHT			=  5
	    }
	# endregion
    }