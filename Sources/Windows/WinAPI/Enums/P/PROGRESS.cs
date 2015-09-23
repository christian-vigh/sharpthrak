/**************************************************************************************************************

    NAME
        WinAPI/Enums/P/PROGRESS.cs

    DESCRIPTION
        PROGRESS constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/11]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region PROGRESS_ constants
	/// <summary>
	/// Possible return values for PROGRESS_ROUTINE.
	/// </summary>
	public enum PROGRESS_Constants : int
	   {
		/// <summary>
		/// Cancel the copy operation and delete the destination file.
		/// </summary>
		PROGRESS_CANCEL			=  1,

		/// <summary>
		/// Continue the copy operation.
		/// </summary>
		PROGRESS_CONTINUE		=  0,

		/// <summary>
		/// Continue the copy operation, but stop invoking CopyProgressRoutine to report progress.
		/// </summary>
		PROGRESS_QUIET			=  3,

		/// <summary>
		/// Stop the copy operation. It can be restarted at a later time.
		/// </summary>
		PROGRESS_STOP			=  2
	    }
	# endregion
    }