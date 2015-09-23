/**************************************************************************************************************

    NAME
        WinAPI/Enums/P/PWR.cs

    DESCRIPTION
        PWR constants.

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
	# region PWR_ constants
	/// <summary>
	/// wParam for WM_POWER window message and DRV_POWER driver notification.
	/// </summary>
	public enum PWR_Constants : int
	   {
		/// <summary>
		/// Accept entering the power state sent with WM_POWER.
		/// </summary>
		PWR_OK				=  1,

		/// <summary>
		/// Decline entering the power state sent with WM_POWER.
		/// </summary>
		PWR_FAIL			=  (-1),

		/// <summary>
		/// Indicates that the system is about to enter suspended mode.
		/// </summary>
		PWR_SUSPENDREQUEST		=  1,

		/// <summary>
		/// Indicates that the system is resuming operation after having entered suspended mode normally—that is, the system broadcast 
		/// a PWR_SUSPENDREQUEST notification message to the application before the system was suspended. 
		/// An application should perform any necessary recovery actions.
		/// </summary>
		PWR_SUSPENDRESUME		=  2,

		/// <summary>
		/// Indicates that the system is resuming operation after entering suspended mode without first broadcasting a 
		/// PWR_SUSPENDREQUEST notification message to the application. An application should perform any necessary recovery actions.
		/// </summary>
		PWR_CRITICALRESUME		=  3
	    }
	# endregion
    }