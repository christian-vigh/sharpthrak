/**************************************************************************************************************

    NAME
        WinAPI/Enums/P/PW.cs

    DESCRIPTION
        PW constants.

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
	# region PW_ constants
	/// <summary>
	/// Flags for the PrintWindow() function.
	/// </summary>
	public enum PW_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		PW_NONE				=  0x00000000,

		/// <summary>
		/// Copies the whole window to the destination hDC.
		/// </summary>
		PW_ENTIREWINDOW			=  0x00000000,

		/// <summary>
		/// Copies only the client part of the window to the destination hDC.
		/// </summary>
		PW_CLIENTONLY			=  0x00000001,
	    }
	# endregion
    }