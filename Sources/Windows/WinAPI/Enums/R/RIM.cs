/**************************************************************************************************************

    NAME
        WinAPI/Enums/R/RIM.cs

    DESCRIPTION
        RIM constants.

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
	# region RIM_ constants
	/// <summary>
	/// Constants for the wparam parameter of the WM_INPUT message.
	/// </summary>
	public enum RIM_Constants : int
	   {
		/// <summary>
		/// Input occurred while the application was in the foreground. The application must call DefWindowProc so the system can perform cleanup.
		/// </summary>
		RIM_INPUT		=  0,

		/// <summary>
		/// Input occurred while the application was not in the foreground. The application must call DefWindowProc so the system can perform the cleanup.
		/// </summary>
		RIM_INPUTSINK		=  1
	    }
	# endregion
    }