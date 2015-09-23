/**************************************************************************************************************

    NAME
        WinAPI/Constants/W/WTS.cs

    DESCRIPTION
        Codes passed in WPARAM for WM_WTSSESSION_CHANGE.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Constants
   {
	# region WTS_ constants
	/// <summary>
	/// <para>
	/// Status code send through the WM_WTSSESSION_CHANGE message describing the reason the session state change notification was sent.
	/// </para>
	/// </summary>
	public enum WTS_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		WTS_NONE			=  0x0000,

		/// <summary>
		/// The session identified by lParam was connected to the console terminal or RemoteFX session.
		/// </summary>
		WTS_CONSOLE_CONNECT		=  0x0001,

		/// <summary>
		/// The session identified by lParam was disconnected from the console terminal or RemoteFX session.
		/// </summary>
		WTS_CONSOLE_DISCONNECT		=  0x0002,

		/// <summary>
		/// The session identified by lParam was connected to the remote terminal.
		/// </summary>
		WTS_REMOTE_CONNECT		=  0x0003,

		/// <summary>
		/// The session identified by lParam was disconnected from the remote terminal.
		/// </summary>
		WTS_REMOTE_DISCONNECT		=  0x0004,

		/// <summary>
		/// A user has logged on to the session identified by lParam.
		/// </summary>
		WTS_SESSION_LOGON		=  0x0005,

		/// <summary>
		/// A user has logged off the session identified by lParam.
		/// </summary>
		WTS_SESSION_LOGOFF		=  0x0006,

		/// <summary>
		/// The session identified by lParam has been locked.
		/// </summary>
		WTS_SESSION_LOCK		=  0x0007,

		/// <summary>
		/// The session identified by lParam has been unlocked.
		/// </summary>
		WTS_SESSION_UNLOCK		=  0x0008,

		/// <summary>
		/// The session identified by lParam has changed its remote controlled status. To determine the status, call GetSystemMetrics and check the SM_REMOTECONTROL metric.
		/// </summary>
		WTS_SESSION_REMOTE_CONTROL	=  0x0009,

		/// <summary>
		/// Reserved for future use.
		/// </summary>
		WTS_SESSION_CREATE		=  0x000A,

		/// <summary>
		/// Reserved for future use.
		/// </summary>
		WTS_SESSION_TERMINATE		=  0x000B,
	    }
	# endregion
    }