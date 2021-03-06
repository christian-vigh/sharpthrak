﻿/**************************************************************************************************************

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
	# region SSWF_ constants used for the iWindowsEffect member of the SOUNDSENTRY structure
	/// <summary>
	/// Specifies the visual signal to display when a sound is generated by a Windows-based application or an MS-DOS application running in a window.
	/// </summary>
	public enum SSWF_Constants		: uint
	   {
		/// <summary>
		/// Use a custom visual signal.
		/// </summary>
		SSWF_CUSTOM		=  4,

		/// <summary>
		/// Flash the entire display.
		/// </summary>
		SSWF_DISPLAY		=  3,

		/// <summary>
		/// No visual signal.
		/// </summary>
		SSWF_NONE		=  0,

		/// <summary>
		/// Flash the title bar of the active window.
		/// </summary>
		SSWF_TITLE		=  1,

		/// <summary>
		/// Flash the active window.
		/// </summary>
		SSWF_WINDOW		=  2
	    }
	# endregion
    }
