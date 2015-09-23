/**************************************************************************************************************

    NAME
        WinAPI/Enums/K/KEYEVENTF.cs

    DESCRIPTION
        KEYEVENTF constants.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region KEYEVENTF_ constants
	/// <summary>
	/// Flags for keyboard input functions.
	/// </summary>
	public enum KEYEVENTF_Constants : uint
	   {
		/// <summary>
		/// If specified, the scan code was preceded by a prefix byte having the value 0xE0 (224).
		/// </summary>
		KEYEVENTF_EXTENDEDKEY		=  0x0001,

		/// <summary>
		/// If specified, the key is being released. If not specified, the key is being depressed.
		/// </summary>
		KEYEVENTF_KEYUP			=  0x0002,

		/// <summary>
		/// If specified, the system synthesizes a VK_PACKET keystroke. The wVk parameter must be zero. This flag can only be combined with 
		/// the KEYEVENTF_KEYUP flag.
		/// </summary>
		KEYEVENTF_UNICODE		=  0x0004,

		/// <summary>
		/// If specified, wScan identifies the key and wVk is ignored. 
		/// </summary>
		KEYEVENTF_SCANCODE		=  0x0008,

		/// <summary>
		/// Zero value.
		/// </summary>
		KEYEVENTF_NONE			=  0x0000
	    }
	# endregion
    }