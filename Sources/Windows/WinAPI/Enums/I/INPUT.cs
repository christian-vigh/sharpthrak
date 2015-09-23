/**************************************************************************************************************

    NAME
        WinAPI/Enums/I/INPUT.cs

    DESCRIPTION
        INPUT constants.

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
	# region INPUT_ constants
	/// <summary>
	/// Possible values for the "type" member of the INPUT structure.
	/// </summary>
	public enum INPUT_Constants : int
	   {
		/// <summary>
		/// The event is a mouse event. Use the mi structure of the union.
		/// </summary>
		INPUT_MOUSE		=  0,

		/// <summary>
		/// The event is a keyboard event. Use the ki structure of the union.
		/// </summary>
		INPUT_KEYBOARD		=  1,

		/// <summary>
		/// The event is a hardware event. Use the hi structure of the union.
		/// </summary>
		INPUT_HARDWARE		=  2,

		/// <summary>
		/// Zero value.
		/// </summary>
		INPUT_NONE		=  0
	    }
	# endregion
    }