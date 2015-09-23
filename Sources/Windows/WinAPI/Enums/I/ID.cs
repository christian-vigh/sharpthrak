/**************************************************************************************************************

    NAME
        WinAPI/Enums/I/ID.cs

    DESCRIPTION
        ID constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region ID_ constants
	/// <summary>
	/// Dialog box command IDs.
	/// </summary>
	public enum ID_Constants : int
	   {
		/// <summary>
		/// The Abort button was selected.
		/// </summary>
		IDABORT             	=  3,

		/// <summary>
		/// The Cancel button was selected.
		/// </summary>
		IDCANCEL            	=  2,

		/// <summary>
		/// The Close button was selected.
		/// </summary>
		IDCLOSE         	=  8,

		/// <summary>
		/// The Continue button was selected.
		/// </summary>
		IDCONTINUE      	=  11,

		/// <summary>
		/// The Help button was selected.
		/// </summary>
		IDHELP          	=  9,

		/// <summary>
		/// The Ignore button was selected.
		/// </summary>
		IDIGNORE            	=  5,

		/// <summary>
		/// The No button was selected.
		/// </summary>
		IDNO                	=  7,

		/// <summary>
		/// The Ok button was selected.
		/// </summary>
		IDOK                	=  1,

		/// <summary>
		/// The Retry button was selected.
		/// </summary>
		IDRETRY             	=  4,

		/// <summary>
		/// The user did not respond within the required interval.
		/// </summary>
		IDTIMEOUT 		=  32000,

		/// <summary>
		/// The Try Again button was selected.
		/// </summary>
		IDTRYAGAIN      	=  10,

		/// <summary>
		/// The Yes button was selected.
		/// </summary>
		IDYES               	=  6
	    }
	# endregion
    }