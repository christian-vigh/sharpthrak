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
	# region NF_ constants
	/// <summary>
	/// Specifies the nature of the WM_NOTIFYFORMAT message
	/// </summary>
	public enum NF_Constants : int
	   {
		/// <summary>
		/// The message is a query to determine whether ANSI or Unicode structures should be used in WM_NOTIFY messages. 
		/// This command is sent from a control to its parent window during the creation of a control and in response to an NF_REQUERY command.
		/// </summary>
		NF_QUERY                =  3,

		/// <summary>
		/// The message is a request for a control to send an NF_QUERY form of this message to its parent window. 
		/// This command is sent from the parent window. The parent window is asking the control to requery it about the type of structures to use 
		/// in WM_NOTIFY messages. If lParam is NF_REQUERY, the return value is the result of the requery operation.
		/// </summary>
		NF_REQUERY              =  4
	    }
	# endregion
    }