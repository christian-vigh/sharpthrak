/**************************************************************************************************************

    NAME
        WinAPI/Constants/I/ISMEX.cs

    DESCRIPTION
        InSendMessageEx() return values.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region ISMEX_ constants
	/// <summary>
	/// InSendMessageEx() return values.
	/// </summary>
	/// <remarks>
	/// To determine if the sender is blocked, use the following test:
	///
	/// fBlocked = ( InSendMessageEx(NULL) & (ISMEX_REPLIED|ISMEX_SEND) ) == ISMEX_SEND;
	///
	/// </remarks>
	public enum ISMEX_Constants		:  int
	   {
		/// <summary>
		/// The message was sent using the SendMessageCallback function. The thread that sent the message is not blocked.
		/// </summary>
		ISMEX_CALLBACK			=  0x00000004,

		/// <summary>
		/// The message was not sent.
		/// </summary>
		ISMEX_NOSEND			=  0x00000000,

		/// <summary>
		/// The message was sent using the SendNotifyMessage function. The thread that sent the message is not blocked.
		/// </summary>
		ISMEX_NOTIFY			=  0x00000002,

		/// <summary>
		/// The window procedure has processed the message. The thread that sent the message is no longer blocked.
		/// </summary>
		ISMEX_REPLIED			=  0x00000008,

		/// <summary>
		/// The message was sent using the SendMessage or SendMessageTimeout function. If ISMEX_REPLIED is not set, the thread that sent the message is blocked.
		/// </summary>
		ISMEX_SEND			=  0x00000001
	    }
	# endregion
    }
