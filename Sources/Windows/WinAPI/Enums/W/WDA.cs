/**************************************************************************************************************

    NAME
        WinAPI/Enums/W/WDA.cs

    DESCRIPTION
        WDA constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region WDA_ constants
	/// <summary>
	/// Window display affinity constants.
	/// </summary>
	public enum WDA_Constants : int
	   {
		/// <summary>
		/// Non affinity.
		/// </summary>
		WDA_NONE			=  0x00000000,

		/// <summary>
		/// Enable window contents to be displayed on a monitor.
		/// </summary>
		WDA_MONITOR			=  0x00000001
	    }
	# endregion
    }