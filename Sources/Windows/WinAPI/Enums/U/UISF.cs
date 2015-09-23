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

	# region UISF_ constants found in the high word of the WM_CHANGEUISTATE message
	/// <summary>
	/// Specifies which UI state elements are affected or the style of the control in a WM_CHANGEUISTATE message.
	/// </summary>
	public enum UISF_Constants : short
	   { 
		/// <summary>
		/// Zero value.
		/// </summary>
		UISF_NONE		=  0x00,

		/// <summary>
		/// A control should be drawn in the style used for active controls.
		/// </summary>
		UISF_ACTIVE		=  0x04,

		/// <summary>
		/// Keyboard accelerators are hidden.
		/// </summary>
		UISF_HIDEACCEL		=  0x02,

		/// <summary>
		/// Focus indicators are hidden.
		/// </summary>
		UISF_HIDEFOCUS		=  0x01,
	    }
	# endregion
    }