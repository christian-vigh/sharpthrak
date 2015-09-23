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
	# region SSTF_ constants used for the iFSTextEffect member of the SOUNDSENTRY structure
	/// <summary>
	/// Specifies the visual signal to present when a text-mode application generates a sound while running in a full-screen virtual machine. 
	/// </summary>
	public enum SSTF_Constants		: uint
	   {
		/// <summary>
		/// No visual signal
		/// </summary>
		SSTF_NONE			=  0,

		/// <summary>
		/// Flash characters in the corner of the screen.
		/// </summary>
		SSTF_CHARS			=  1,

		/// <summary>
		/// Flash the screen border (that is, the overscan area), which is unavailable on some displays.
		/// </summary>
		SSTF_BORDER			=  2,

		/// <summary>
		/// Flash the entire display.
		/// </summary>
		SSTF_DISPLAY			=  3
	    }
	# endregion
    }
