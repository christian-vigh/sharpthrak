/**************************************************************************************************************

    NAME
        WinAPI/User32/F/ExitWindowsEx.cs

    DESCRIPTION
        ExitWindowsEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Logs off the interactive user, shuts down the system, or shuts down and restarts the system. 
		/// It sends the WM_QUERYENDSESSION message to all applications to determine if they can be terminated.
		/// </summary>
		/// <param name="dwFlags">The shutdown type. This parameter must include one of the EWX_Constants values.</param>
		/// <param name="dwReason">
		/// The reason for initiating the shutdown. This parameter must be one of the system shutdown reason codes.
		/// <br/>
		/// <para>
		/// If this parameter is zero, the SHTDN_REASON_FLAG_PLANNED reason code will not be set and therefore the default action is an undefined shutdown 
		/// that is logged as "No title for this reason could be found". By default, it is also an unplanned shutdown. 
		/// Depending on how the system is configured, an unplanned shutdown triggers the creation of a file that contains the system state information, 
		/// which can delay shutdown. Therefore, do not use zero for this parameter.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. Because the function executes asynchronously, a nonzero return value indicates that the shutdown 
		/// has been initiated. It does not indicate whether the shutdown will succeed. It is possible that the system, the user, or another application will abort 
		/// the shutdown.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The ExitWindowsEx function returns as soon as it has initiated the shutdown process. The shutdown or logoff then proceeds asynchronously. 
		/// The function is designed to stop all processes in the caller's logon session. Therefore, if you are not the interactive user, the function can succeed 
		/// without actually shutting down the computer. If you are not the interactive user, use the InitiateSystemShutdown or InitiateSystemShutdownEx function.
		/// <br/>
		/// <para>
		/// A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call 
		/// has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services, or even the system. 
		/// The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.
		/// </para>
		/// <br/>
		/// <para>
		/// When this function is called, the caller must specify whether or not applications with unsaved changes should be forcibly closed. 
		/// If the caller chooses not to force these applications to close and an application with unsaved changes is running on the console session, 
		/// the shutdown will remain in progress until the user logged into the console session aborts the shutdown, saves changes, closes the application, 
		/// or forces the application to close. During this period, the shutdown may not be aborted except by the console user, and another shutdown may not be initiated.
		/// </para>
		/// <br/>
		/// <para>
		/// Calling this function with the value of the uFlags parameter set to EWX_FORCE avoids this situation. Remember that doing this may result in loss of data.
		/// </para>
		/// <br/>
		/// <para>
		/// To set a shutdown priority for an application relative to other applications in the system, use the SetProcessShutdownParameters function.
		/// </para>
		/// <br/>
		/// <para>
		/// During a shutdown or log-off operation, running applications are allowed a specific amount of time to respond to the shutdown request. 
		/// If this time expires before all applications have stopped, the system displays a user interface that allows the user to forcibly shut down the system or 
		/// to cancel the shutdown request. If the EWX_FORCE value is specified, the system forces running applications to stop when the time expires.
		/// </para>
		/// <br/>
		/// <para>
		/// If the EWX_FORCEIFHUNG value is specified, the system forces hung applications to close and does not display the dialog box.
		/// </para>
		/// <br/>
		/// <para>
		/// Console processes receive a separate notification message, CTRL_SHUTDOWN_EVENT or CTRL_LOGOFF_EVENT, as the situation warrants. 
		/// A console process routes these messages to its HandlerRoutine function. ExitWindowsEx sends these notification messages asynchronously; 
		/// thus, an application cannot assume that the console notification messages have been handled when a call to ExitWindowsEx returns.
		/// </para>
		/// <br/>
		/// <para>
		/// To shut down or restart the system, the calling process must use the AdjustTokenPrivileges function to enable the SE_SHUTDOWN_NAME privilege. 
		/// For more information, see Running with Special Privileges.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ExitWindowsEx ( uint  dwFlags, uint  dwReason ) ;
		# endregion

		# region Version with EWX and SHTDN constants
		/// <summary>
		/// Logs off the interactive user, shuts down the system, or shuts down and restarts the system. 
		/// It sends the WM_QUERYENDSESSION message to all applications to determine if they can be terminated.
		/// </summary>
		/// <param name="dwFlags">The shutdown type. This parameter must include one of the EWX_Constants values.</param>
		/// <param name="dwReason">
		/// The reason for initiating the shutdown. This parameter must be one of the system shutdown reason codes.
		/// <br/>
		/// <para>
		/// If this parameter is zero, the SHTDN_REASON_FLAG_PLANNED reason code will not be set and therefore the default action is an undefined shutdown 
		/// that is logged as "No title for this reason could be found". By default, it is also an unplanned shutdown. 
		/// Depending on how the system is configured, an unplanned shutdown triggers the creation of a file that contains the system state information, 
		/// which can delay shutdown. Therefore, do not use zero for this parameter.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. Because the function executes asynchronously, a nonzero return value indicates that the shutdown 
		/// has been initiated. It does not indicate whether the shutdown will succeed. It is possible that the system, the user, or another application will abort 
		/// the shutdown.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The ExitWindowsEx function returns as soon as it has initiated the shutdown process. The shutdown or logoff then proceeds asynchronously. 
		/// The function is designed to stop all processes in the caller's logon session. Therefore, if you are not the interactive user, the function can succeed 
		/// without actually shutting down the computer. If you are not the interactive user, use the InitiateSystemShutdown or InitiateSystemShutdownEx function.
		/// <br/>
		/// <para>
		/// A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call 
		/// has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services, or even the system. 
		/// The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.
		/// </para>
		/// <br/>
		/// <para>
		/// When this function is called, the caller must specify whether or not applications with unsaved changes should be forcibly closed. 
		/// If the caller chooses not to force these applications to close and an application with unsaved changes is running on the console session, 
		/// the shutdown will remain in progress until the user logged into the console session aborts the shutdown, saves changes, closes the application, 
		/// or forces the application to close. During this period, the shutdown may not be aborted except by the console user, and another shutdown may not be initiated.
		/// </para>
		/// <br/>
		/// <para>
		/// Calling this function with the value of the uFlags parameter set to EWX_FORCE avoids this situation. Remember that doing this may result in loss of data.
		/// </para>
		/// <br/>
		/// <para>
		/// To set a shutdown priority for an application relative to other applications in the system, use the SetProcessShutdownParameters function.
		/// </para>
		/// <br/>
		/// <para>
		/// During a shutdown or log-off operation, running applications are allowed a specific amount of time to respond to the shutdown request. 
		/// If this time expires before all applications have stopped, the system displays a user interface that allows the user to forcibly shut down the system or 
		/// to cancel the shutdown request. If the EWX_FORCE value is specified, the system forces running applications to stop when the time expires.
		/// </para>
		/// <br/>
		/// <para>
		/// If the EWX_FORCEIFHUNG value is specified, the system forces hung applications to close and does not display the dialog box.
		/// </para>
		/// <br/>
		/// <para>
		/// Console processes receive a separate notification message, CTRL_SHUTDOWN_EVENT or CTRL_LOGOFF_EVENT, as the situation warrants. 
		/// A console process routes these messages to its HandlerRoutine function. ExitWindowsEx sends these notification messages asynchronously; 
		/// thus, an application cannot assume that the console notification messages have been handled when a call to ExitWindowsEx returns.
		/// </para>
		/// <br/>
		/// <para>
		/// To shut down or restart the system, the calling process must use the AdjustTokenPrivileges function to enable the SE_SHUTDOWN_NAME privilege. 
		/// For more information, see Running with Special Privileges.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ExitWindowsEx ( EWX_Constants  dwFlags, SHTDN_Constants  dwReason ) ;
		# endregion
	    }
    }