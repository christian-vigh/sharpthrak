/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MND.cs

    DESCRIPTION
        MND constants.

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
	# region MND_ constants
	/// <summary>
	/// WM_MENUDRAG return values.
	/// </summary>
	public enum MND_Constants : int
	   {
		/// <summary>
		/// Menu should remain active. If the mouse is released, it should be ignored.
		/// </summary>
		MND_CONTINUE		=  0,

		/// <summary>
		/// Menu should be ended.
		/// </summary>
		MND_ENDMENU		=  1
	    }
	# endregion
    }