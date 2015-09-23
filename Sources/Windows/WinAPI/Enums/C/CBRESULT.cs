/**************************************************************************************************************

    NAME
        WinAPI/Constants/C/CBRESULT.cs

    DESCRIPTION
        Combobox messages return values.

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
	# region CBRESULT_ status values
	/// <summary>
	/// Possible return values for CB_ messages.
	/// </summary>
	public enum CBRESULT_Constants		:  int
	   {
		/// <summary>
		/// The message was successfully processed. Same as CB_OKAY.
		/// </summary>
		CB_OK			=  0,

		/// <summary>
		/// The message was successfully processed. Same as CB_OK.
		/// </summary>
		CB_OKAY			=  0,

		/// <summary>
		/// An errror occurred while processing the message.
		/// </summary>
		CB_ERR			=  (-1),

		/// <summary>
		/// A memory allocation error occurred while processing the message.
		/// </summary>
		CB_ERRSPACE		=  (-2)
	    }
	# endregion
    }
