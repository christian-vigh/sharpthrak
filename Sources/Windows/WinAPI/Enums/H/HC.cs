/**************************************************************************************************************

    NAME
        WinAPI/Constants/H/HC.cs

    DESCRIPTION
        Hook codes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region HC_ constants for hook codes
	/// <summary>
	/// Hook codes.
	/// </summary>
	public enum  HC_Constants	:  int
	   {
		/// <summary>
		/// The wParam and lParam parameters contain information about the hook message.
		/// </summary>
		HC_ACTION			=  0,

		/// <summary>
		/// The hook procedure must copy the current mouse or keyboard message to the EVENTMSG structure pointed to by the lParam parameter. 
		/// </summary>
		HC_GETNEXT			=  1,

		/// <summary>
		/// An application has called the PeekMessage function with wRemoveMsg set to PM_NOREMOVE, indicating that the message is not removed 
		/// from the message queue after PeekMessage processing. 
		/// <para>
		/// Same as HC_NOREMOVE.
		/// </para>
		/// </summary>
		HC_NOREM			=  HC_NOREMOVE,

		/// <summary>
		/// An application has called the PeekMessage function with wRemoveMsg set to PM_NOREMOVE, indicating that the message is not removed 
		/// from the message queue after PeekMessage processing. 
		/// <para>
		/// Same as HC_NOREM.
		/// </para>
		/// </summary>
		HC_NOREMOVE			=  3,

		/// <summary>
		/// The hook procedure must prepare to copy the next mouse or keyboard message to the EVENTMSG structure pointed to by lParam. 
		/// <para>
		/// Upon receiving the HC_GETNEXT code, the hook procedure must copy the message to the structure. 
		/// </para>
		/// </summary>
		HC_SKIP				=  2,

		/// <summary>
		/// A system-modal dialog box has been destroyed. The hook procedure must resume playing back the messages.
		/// </summary>
		HC_SYSMODALOFF			=  5,

		/// <summary>
		/// A system-modal dialog box is being displayed. Until the dialog box is destroyed, the hook procedure must stop playing back messages.
		/// </summary>
		HC_SYSMODALON			=  4
	    }
	# endregion
   }