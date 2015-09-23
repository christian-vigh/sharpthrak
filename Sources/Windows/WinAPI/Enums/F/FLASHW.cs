/**************************************************************************************************************

    NAME
        WinAPI/Enums/F/FLASHW.cs

    DESCRIPTION
        FLASHW constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region FLASHW_ constants
	/// <summary>
	/// FlashWindowEx flags for the dwFlags field of the FLASHWINFO structure.
	/// </summary>
	public enum FLASHW_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		FLASHW_NONE		=  0,

		/// <summary>
		/// Flash both the window caption and taskbar button. This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
		/// </summary>
		FLASHW_ALL		=  FLASHW_CAPTION | FLASHW_TRAY,

		/// <summary>
		/// Flash the window caption.
		/// </summary>
		FLASHW_CAPTION		=  0x00000001,

		/// <summary>
		/// Stop flashing. The system restores the window to its original state.
		/// </summary>
		FLASHW_STOP		=  0x00000000,

		/// <summary>
		/// Flash continuously, until the FLASHW_STOP flag is set.
		/// </summary>
		FLASHW_TIMER		=  0x00000004,

		/// <summary>
		/// Flash continuously until the window comes to the foreground.
		/// </summary>
		FLASHW_TIMERNOFG	=  0x0000000C,

		/// <summary>
		/// Flash the taskbar button.
		/// </summary>
		FLASHW_TRAY		=  0x00000002
	    }
	# endregion
    }