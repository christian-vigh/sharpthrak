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
	# region FAPPCOMMAND_ input device constants
	/// <summary>
	/// Upon receiving a WM_APPCOMMAND message, indicates the input device that generated the input event.
	/// </summary>
	public enum  FAPPCOMMAND		:  ushort
	   {
		/// <summary>
		/// User clicked a mouse button.
		/// </summary>
		FAPPCOMMAND_MOUSE		=  0x8000,

		/// <summary>
		/// User pressed a key.
		/// </summary>
		FAPPCOMMAND_KEY			=  0,

		/// <summary>
		/// An unidentified hardware source generated the event. It could be a mouse or a keyboard event.
		/// </summary>
		FAPPCOMMAND_OEM			=  0x1000,

		/// <summary>
		/// Mask used to extract the FAPPCOMMAND part of the LPARAM parameter of the WM_APPCOMMAND Windows messasge.
		/// </summary>
		FAPPCOMMAND_MASK		=  0xF000
	    }
	# endregion


	# region FAPPCOMMAND_ normalized input device constants
	/// <summary>
	/// Upon receiving a WM_APPCOMMAND message, indicates the input device that generated the input event.
	/// </summary>
	public enum  FAPPCOMMAND_Constants	:  ushort
	   {
		/// <summary>
		/// User clicked a mouse button.
		/// </summary>
		FAPPCOMMAND_MOUSE		=  8,

		/// <summary>
		/// User pressed a key.
		/// </summary>
		FAPPCOMMAND_KEY			=  0,

		/// <summary>
		/// An unidentified hardware source generated the event. It could be a mouse or a keyboard event.
		/// </summary>
		FAPPCOMMAND_OEM			=  1
	    }
	# endregion
    }