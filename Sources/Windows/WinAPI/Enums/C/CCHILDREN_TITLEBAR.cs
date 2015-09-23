/**************************************************************************************************************

    NAME
        WinAPI/Constants/C/CCHILDREN_TITLEBAR.cs

    DESCRIPTION
        Title bar item index, as returned in the rgstate field of the TITLEBARINFO structure.

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
	# region CCHILDREN_TITLEBAR_ constants
	/// <summary>
	/// Title bar item index, as returned in the rgstate field of the TITLEBARINFO structure.
	/// </summary>
	public enum CCHILDREN_TITLEBAR_Constants	: int
	   {
		/// <summary>
		/// The title bar itself.
		/// </summary>
		CCHILDREN_TITLEBAR_BAR			=  0,

		/// <summary>
		/// Reserved.
		/// </summary>
		CCHILDREN_TITLEBAR_RESERVED		=  1,

		/// <summary>
		/// Minimize button.
		/// </summary>
		CCHILDREN_TITLEBAR_MINIMIZE_BUTTON	=  2,

		/// <summary>
		/// Maximize button.
		/// </summary>
		CCHILDREN_TITLEBAR_MAXIMIZE_BUTTON	=  3,

		/// <summary>
		/// Help button.
		/// </summary>
		CCHILDREN_TITLEBAR_HELP_BUTTON		=  4,

		/// <summary>
		/// Close button.
		/// </summary>
		CCHILDREN_TITLEBAR_CLOSE_BUTTON		=  5,

		/// <summary>
		/// Highest CCHILDREN_TITLEBAR value.
		/// </summary>
		CCHILDREN_TITLEBAR_MAX			=  CCHILDREN_TITLEBAR_CLOSE_BUTTON
	    }
	# endregion
    }