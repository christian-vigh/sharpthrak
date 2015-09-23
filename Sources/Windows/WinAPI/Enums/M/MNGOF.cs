/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MNGOF.cs

    DESCRIPTION
        MNGOF constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region MNGOF_ constants
	/// <summary>
	/// MENUGETOBJECTINFO dwFlags values.
	/// </summary>
	public enum MNGOF_Constants : uint
	   {
		/// <summary>
		/// The mouse is on the top of the item indicated by uPos.
		/// </summary>
		MNGOF_TOPGAP			=  0x00000001,

		/// <summary>
		/// The mouse is on the bottom of the item indicated by uPos.
		/// </summary>
		MNGOF_BOTTOMGAP			=  0x00000002,

		/// <summary>
		/// Zero value.
		/// </summary>
		MNGOF_ZERO			=  0x00000000
	    }
	# endregion
    }