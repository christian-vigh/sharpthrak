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

	# region UIS_ constants found in the low word of the WM_CHANGEUISTATE message
	/// <summary>
	/// Specifies the action to be taken when sending a WM_CHANGEUISTATE message.
	/// </summary>
	public enum UIS_Constants : short
	   { 
		/// <summary>
		/// Zero value.
		/// </summary>
		UIS_NONE			=  0,

		/// <summary>
		/// The UI state flags specified by the high-order word should be cleared.
		/// </summary>
		UIS_CLEAR			=  2,

		/// <summary>
		/// The UI state flags specified by the high-order word should be changed based on the last input event.
		/// </summary>
		UIS_INITIALIZE			=  3,

		/// <summary>
		/// The UI state flags specified by the high-order word should be set.
		/// </summary>
		UIS_SET				=  1
	    }
	# endregion
    }