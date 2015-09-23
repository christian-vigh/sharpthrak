/**************************************************************************************************************

    NAME
        WinAPI/Enums/L/LSFW.cs

    DESCRIPTION
        LSFW constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region LSFW_ constants
	/// <summary>
	/// Lock codes for the LockSetForegroundWindow function.
	/// </summary>
	public enum LSFW_Constants : int
	   {
		/// <summary>
		/// Disables calls to SetForegroundWindow.
		/// </summary>
		LSFW_LOCK		=  1,

		/// <summary>
		/// Enables calls to SetForegroundWindow.
		/// </summary>
		LSFW_UNLOCK		=  2
	    }
	# endregion
    }