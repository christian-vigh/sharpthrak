/**************************************************************************************************************

    NAME
        WinAPI/Constants/H/HOTKEYF.cs

    DESCRIPTION
        HOTKEYF constants.

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
	# region HOTKEYF_ constants
	/// <summary>
	/// Hotkey modifiers for the WM_GETHOTKEY and WM_SETHOTKEY messages.
	/// </summary>
	public enum HOTKEYF_Constants : byte
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		HOTKEYF_NONE		=  0x00,

		/// <summary>
		/// ALT key.
		/// </summary>
		HOTKEYF_ALT		=  0x04,

		/// <summary>
		/// CONTROL key.
		/// </summary>
		HOTKEYF_CONTROL		=  0x02,

		/// <summary>
		/// EXTENDED key.
		/// </summary>
		HOTKEYF_EXT		=  0x08,

		/// <summary>
		/// SHIFT key.
		/// </summary>
		HOTKEYF_SHIFT		=  0x01
	    }
	# endregion
    }