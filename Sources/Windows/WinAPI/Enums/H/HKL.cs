/**************************************************************************************************************

    NAME
        WinAPI/Enums/H/HKL.cs

    DESCRIPTION
        HKL constants.

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
	# region HKL_ constants
	/// <summary>
	/// Constants for the KeyboardLayout functions.
	/// </summary>
	public enum HKL_Constants : int
	   {
		/// <summary>
		/// Selects the next locale identifier in the circular list of loaded locale identifiers maintained by the system.
		/// </summary>
		HKL_NEXT		=  1,

		/// <summary>
		/// Selects the previous locale identifier in the circular list of loaded locale identifiers maintained by the system.
		/// </summary>
		HKL_PREV		=  0
	    }
	# endregion
    }