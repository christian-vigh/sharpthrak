/**************************************************************************************************************

    NAME
        WinAPI/Constants/P/PM.cs

    DESCRIPTION
        PM constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region PM_ constants
	/// <summary>
	/// Specifies how messages are to be handled by the PeekMessage function.
	/// <para>
	/// By default, all message types are processed. To specify that only certain message should be processed, specify one or more of the PM_QS_* options.
	/// </para>
	/// </summary>
	public enum PM_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		PM_NONE			=  0x0000,

		/// <summary>
		/// Messages are not removed from the queue after processing by PeekMessage.
		/// </summary>
		PM_NOREMOVE		=  0x0000,

		/// <summary>
		/// Messages are removed from the queue after processing by PeekMessage.
		/// </summary>
		PM_REMOVE		=  0x0001,

		/// <summary>
		/// Prevents the system from releasing any thread that is waiting for the caller to go idle (see WaitForInputIdle).
		/// <para>
		/// Combine this value with either PM_NOREMOVE or PM_REMOVE.
		/// </para>
		/// </summary>
		PM_NOYIELD		=  0x0002,

		/// <summary>
		/// Process mouse and keyboard messages.
		/// </summary>
		PM_QS_INPUT		=  ( QS_Constants. QS_INPUT  <<  16 ),

		/// <summary>
		/// Process paint messages.
		/// </summary>
		PM_QS_PAINT		=  ( QS_Constants. QS_PAINT  <<  16 ),

		/// <summary>
		/// Process all posted messages, including timers and hotkeys. 
		/// </summary>
		PM_QS_POSTMESSAGE	=  ( ( QS_Constants. QS_POSTMESSAGE | QS_Constants. QS_HOTKEY | QS_Constants. QS_TIMER )  <<  16 ), 

		/// <summary>
		/// Process all sent messages.
		/// </summary>
		PM_QS_SENDMESSAGE	=  ( QS_Constants. QS_SENDMESSAGE  <<  16 )
	    }
	# endregion
    }