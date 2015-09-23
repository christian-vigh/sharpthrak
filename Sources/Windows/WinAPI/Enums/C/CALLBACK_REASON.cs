/**************************************************************************************************************

    NAME
        WinAPI/Enums/C/CALLBACK_REASON.cs

    DESCRIPTION
        CALLBACK_REASON constants.

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
	# region CALLBACK_REASON_ constants
	/// <summary>
	/// Possible values for the dwCallbackReason parameter of a PROGRESS_ROUTINE callback.
	/// </summary>
	public enum CALLBACK_REASON_Constants : int
	   {
		/// <summary>
		/// Another part of the data file was copied.
		/// </summary>
		CALLBACK_CHUNK_FINISHED		=  0x00000000,

		/// <summary>
		/// Another stream was created and is about to be copied. This is the callback reason given when the callback routine is first invoked.
		/// </summary>
		CALLBACK_STREAM_SWITCH		=  0x00000001
	    }
	# endregion
    }