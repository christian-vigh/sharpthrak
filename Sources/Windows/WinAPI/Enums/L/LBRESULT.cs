/**************************************************************************************************************

    NAME
        WinAPI/Constants/L/LBRESULT.cs

    DESCRIPTION
        Listbox messages return values.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region LBRESULT_ status values
	/// <summary>
	/// Possible return values for LB_ messages.
	/// </summary>
	public enum LBRESULT_Constants		:  int
	   {
		/// <summary>
		/// The message was successfully processed. Same as LB_OKAY.
		/// </summary>
		LB_OK			=  0,

		/// <summary>
		/// The message was successfully processed. Same as LB_OK.
		/// </summary>
		LB_OKAY			=  0,

		/// <summary>
		/// An errror occurred while processing the message.
		/// </summary>
		LB_ERR			=  (-1),

		/// <summary>
		/// A memory allocation error occurred while processing the message.
		/// </summary>
		LB_ERRSPACE		=  (-2)
	    }
	# endregion
    }
