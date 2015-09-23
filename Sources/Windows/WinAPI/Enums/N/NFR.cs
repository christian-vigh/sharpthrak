/**************************************************************************************************************

    NAME
        WinAPI/Enums/N/NF.cs

    DESCRIPTION
        NF constants.

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
	# region NFR_ constants
	/// <summary>
	/// WM_NOTIFYFORMAT message return values.
	/// </summary>
	public enum NFR_Constants : int
	   {
		/// <summary>
		/// ANSI structures should be used in WM_NOTIFY messages sent by the control.
		/// </summary>
		NFR_ANSI		=  1,

		/// <summary>
		/// Unicode structures should be used in WM_NOTIFY messages sent by the control. 
		/// </summary>
		NFR_UNICODE             =  2,

		/// <summary>
		/// An error has occured.
		/// </summary>
		NFR_ERROR		=  0
	    }
	# endregion
    }