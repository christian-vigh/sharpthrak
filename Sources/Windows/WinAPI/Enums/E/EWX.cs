/**************************************************************************************************************

    NAME
        WinAPI/Enums/E/EWX.cs

    DESCRIPTION
        EWX constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region EWX_ constants
	/// <summary>
	/// Possible shutdown types for ExitWindows() and ExitWindowsEx() functions.
	/// </summary>
	public enum EWX_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		EWX_NONE			=  0x00000000,

		/// <summary>
		/// Beginning with Windows 8:  You can prepare the system for a faster startup by combining the EWX_HYBRID_SHUTDOWN flag with the EWX_SHUTDOWN flag. 
		/// </summary>
		EWX_HYBRID_SHUTDOWN		=  0x00400000,

		/// <summary>
		/// Shuts down all processes running in the logon session of the process that called the ExitWindowsEx function. Then it logs the user off.
		/// <para>
		/// This flag can be used only by processes running in an interactive user's logon session.
		/// </para>
		/// </summary>
		EWX_LOGOFF			=  0x00000000,

		/// <summary>
		/// Shuts down the system and turns off the power. The system must support the power-off feature.
		/// <para>
		/// The calling process must have the SE_SHUTDOWN_NAME privilege. For more information, see the following Remarks section.
		/// </para>
		/// </summary>
		EWX_POWEROFF			=  0x00000008,

		/// <summary>
		/// Shuts down the system and then restarts the system. 
		/// <para>
		/// The calling process must have the SE_SHUTDOWN_NAME privilege. For more information, see the following Remarks section.
		/// </para>
		/// </summary>
		EWX_REBOOT			=  0x00000002,

		/// <summary>
		/// Shuts down the system and then restarts it, as well as any applications that have been registered for restart using the 
		/// RegisterApplicationRestart function. These application receive the WM_QUERYENDSESSION message with lParam set to the ENDSESSION_CLOSEAPP value. 
		/// </summary>
		EWX_RESTARTAPPS			=  0x00000040,

		/// <summary>
		/// Shuts down the system to a point at which it is safe to turn off the power. All file buffers have been flushed to disk, and all running processes have stopped. 
		/// <para>
		/// The calling process must have the SE_SHUTDOWN_NAME privilege.
		/// </para>
		/// <para>
		/// Specifying this flag will not turn off the power even if the system supports the power-off feature. You must specify EWX_POWEROFF to do this.
		/// </para>
		/// <para>
		/// Windows XP with SP1 : If the system supports the power-off feature, specifying this flag turns off the power.
		/// </para>
		/// </summary>
		EWX_SHUTDOWN			=  0x00000001,

		/// <summary>
		/// This flag has no effect if terminal services is enabled. Otherwise, the system does not send the WM_QUERYENDSESSION message. 
		/// This can cause applications to lose data. Therefore, you should only use this flag in an emergency.
		/// </summary>
		EWX_FORCE			=  0x00000004,

		/// <summary>
		/// Forces processes to terminate if they do not respond to the WM_QUERYENDSESSION or WM_ENDSESSION message within the timeout interval. 
		/// </summary>
		EWX_FORCEIFHUNG			=  0x00000010,

		/// <summary>
		/// Undocumented.
		/// </summary>
		EWX_QUICKRESOLVE		=  0x00000020
	    }
	# endregion
    }