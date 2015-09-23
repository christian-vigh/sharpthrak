/**************************************************************************************************************

    NAME
        WinAPI/Constants/M/MA.cs

    DESCRIPTION
        MA constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region MA_ constants
	/// <summary>
	/// WM_MOUSEACTIVATE constants.
	/// </summary>
	public enum MA_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		MA_NONE			=  0,

		/// <summary>
		/// Activates the window, and does not discard the mouse message.
		/// </summary>
		MA_ACTIVATE		=  1,

		/// <summary>
		/// Activates the window, and discards the mouse message.
		/// </summary>
		MA_ACTIVATEANDEAT	=  2,

		/// <summary>
		/// Does not activate the window, and does not discard the mouse message.
		/// </summary>
		MA_NOACTIVATE		=  3,

		/// <summary>
		/// Does not activate the window, but discards the mouse message.
		/// </summary>
		MA_NOACTIVATEANDEAT	=  4
	    }
	# endregion
    }