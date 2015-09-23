/**************************************************************************************************************

    NAME
        WinAPI/Constants/M/MSGF.cs

    DESCRIPTION
        MSGF constants.

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
	# region MSGF_ constants
	/// <summary>
	/// WH_MSGFILTER Filter Proc Codes
	/// </summary>
	public enum MSGF_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		MSGF_NONE		=  0,

		/// <summary>
		/// The input event occurred in a message box or dialog box.
		/// </summary>
		MSGF_DIALOGBOX		=  0,

		/// <summary>
		/// The input event occurred in a message box.
		/// </summary>
		MSGF_MESSAGEBOX		=  1,

		/// <summary>
		/// The input event occurred in a menu.
		/// </summary>
		MSGF_MENU		=  2,

		/// <summary>
		/// The input event occurred in a scrollbar.
		/// </summary>
		MSGF_SCROLLBAR		=  5,

		/// <summary>
		/// Pass the message to the next window in the filter loop.
		/// </summary>
		MSGF_NEXTWINDOW		=  6,

		/// <summary>
		/// User-defined filter messages start at this value.
		/// </summary>
		MSGF_USER		=  4096
	    }
	# endregion
    }