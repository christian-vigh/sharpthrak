/**************************************************************************************************************

    NAME
        WinAPI/Constants/I/ICON.cs

    DESCRIPTION
        ICON constants.

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
	# region ICON_ constants
	/// <summary>
	/// WM_SETICON / WM_GETICON Type Codes.
	/// </summary>
	public enum ICON_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		ICON_NONE		=  0,

		/// <summary>
		/// Small icon for the window.
		/// </summary>
		ICON_SMALL		=  0,

		/// <summary>
		/// Big icon for the window.
		/// </summary>
		ICON_BIG		=  1,

		/// <summary>
		/// Small icon provided by the application. If the application does not provide one, the system uses the system-generated icon for that window.
		/// </summary>
		ICON_SMALL2		=  2
	    }
	# endregion
    }