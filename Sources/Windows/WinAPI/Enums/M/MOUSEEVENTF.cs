/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MOUSEEVENTF.cs

    DESCRIPTION
        MOUSEEVENTF constants.

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
	# region MOUSEEVENTF_ constants
	/// <summary>
	/// Flags for the dwFlags member of the MOUSEINPUT structure.
	/// </summary>
	public enum MOUSEEVENTF_Constants : uint
	   {
		/// <summary>
		/// Absolute move.
		/// </summary>
		MOUSEEVENTF_ABSOLUTE    		=  0x8000,

		/// <summary>
		/// Horizontal wheel button moved.
		/// </summary>
		MOUSEEVENTF_HWHEEL      		=  0x1000,

		/// <summary>
		/// Left button down.
		/// </summary>
		MOUSEEVENTF_LEFTDOWN    		=  0x0002,

		/// <summary>
		/// Left button up.
		/// </summary>
		MOUSEEVENTF_LEFTUP      		=  0x0004,

		/// <summary>
		/// Middle button down.
		/// </summary>
		MOUSEEVENTF_MIDDLEDOWN  		=  0x0020,

		/// <summary>
		/// Middle button up.
		/// </summary>
		MOUSEEVENTF_MIDDLEUP    		=  0x0040,

		/// <summary>
		/// Mouse move.
		/// </summary>
		MOUSEEVENTF_MOVE        		=  0x0001,

		/// <summary>
		/// Do not coalesce mouse moves.
		/// </summary>
		MOUSEEVENTF_MOVE_NOCOALESCE 		=  0x2000,

		/// <summary>
		/// Right button down.
		/// </summary>
		MOUSEEVENTF_RIGHTDOWN   		=  0x0008,

		/// <summary>
		/// Right button up.
		/// </summary>
		MOUSEEVENTF_RIGHTUP     		=  0x0010,

		/// <summary>
		/// Map to entire virtual desktop.
		/// </summary>
		MOUSEEVENTF_VIRTUALDESK 		=  0x4000,

		/// <summary>
		/// Wheel button rolled.
		/// </summary>
		MOUSEEVENTF_WHEEL       		=  0x0800,

		/// <summary>
		/// X button down.
		/// </summary>
		MOUSEEVENTF_XDOWN       		=  0x0080,

		/// <summary>
		/// X button up.
		/// </summary>
		MOUSEEVENTF_XUP         		=  0x0100,

		/// <summary>
		/// Zero value.
		/// </summary>
		MOUSEEVENTF_NONE			=  0x0000,
	    }
	# endregion
    }