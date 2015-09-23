/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MOD.cs

    DESCRIPTION
        MOD constants.

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
	# region MOD_ constants
	/// <summary>
	/// Modifier constants used in the lParam value of the WM_HOTKEY message.
	/// </summary>
	public enum MOD_Constants : ushort
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		MOD_NONE			=  0x0000,

		/// <summary>
		/// Either ALT key was held down.
		/// </summary>
		MOD_ALT				=  0x0001,

		/// <summary>
		/// Either CTRL key was held down.
		/// </summary>
		MOD_CONTROL			=  0x0002,

		/// <summary>
		/// This flag avoids multiple hotkey notifications.
		/// </summary>
		MOD_NOREPEAT			=  0x4000,

		/// <summary>
		/// Either SHIFT key was held down.
		/// </summary>
		MOD_SHIFT			=  0x0004,

		/// <summary>
		/// Either WINDOWS key was held down. These keys are labeled with the Windows logo. Hotkeys that involve the Windows key are reserved for use by the operating system.
		/// </summary>
		MOD_WIN				=  0x0008
	    }
	# endregion
    }