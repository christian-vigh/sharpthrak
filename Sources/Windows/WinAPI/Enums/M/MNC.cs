/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MNC.cs

    DESCRIPTION
        MNC constants.

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
	# region MNC_ constants
	/// <summary>
	/// Return codes for WM_MENUCHAR.
	/// </summary>
	public enum MNC_Constants : int
	   {
		/// <summary>
		/// Informs the system that it should close the active menu.
		/// </summary>
		MNC_CLOSE		=  1,

		/// <summary>
		/// Informs the system that it should choose the item specified in the low-order word of the return value. 
		/// The owner window receives a WM_COMMAND message.
		/// </summary>
		MNC_EXECUTE		=  2,

		/// <summary>
		/// Informs the system that it should discard the character the user pressed and create a short beep on the system speaker.
		/// </summary>
		MNC_IGNORE		=  0,

		/// <summary>
		/// Informs the system that it should select the item specified in the low-order word of the return value. 
		/// </summary>
		MNC_SELECT		=  3
	    }
	# endregion
    }