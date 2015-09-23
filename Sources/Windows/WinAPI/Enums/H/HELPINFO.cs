/**************************************************************************************************************

    NAME
        WinAPI/Enums/H/HELPINFO.cs

    DESCRIPTION
        HELPINFO constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region HELPINFO_ constants
	/// <summary>
	/// Possible values for the iContextType field of the HELPINFO structure passed through the WM_HELPINFO message.
	/// </summary>
	public enum HELPINFO_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		HELPINFO_NONE			=  0x0000,

		/// <summary>
		/// Help requested for a menu item.
		/// </summary>
		HELPINFO_MENUITEM		=  0x0002,

		/// <summary>
		/// Help requested for a control or window.
		/// </summary>
		HELPINFO_WINDOW			=  0x0001
	    }
	# endregion
    }