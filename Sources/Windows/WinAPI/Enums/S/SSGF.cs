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
	# region SSGF_ constants used for the iFSGrafEffect member of the SOUNDSENTRY structure
	/// <summary>
	/// Windows 95/98: Specifies the visual signal to present when a graphics-mode application generates a sound while running in a full-screen virtual machine.
	/// </summary>
	public enum SSGF_Constants		: uint
	   {
		/// <summary>
		/// No visual signal.
		/// </summary>
		SSGF_NONE			=  0,

		/// <summary>
		/// Flash the entire display.
		/// </summary>
		SSGF_DISPLAY			=  3
	    }
	# endregion
    }
