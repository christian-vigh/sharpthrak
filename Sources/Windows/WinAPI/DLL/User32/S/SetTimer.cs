/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetTimer.cs

    DESCRIPTION
        SetTimer() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Callbacks ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Creates a timer with the specified time-out value.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window to be associated with the timer. 
		/// <para>
		/// This window must be owned by the calling thread. If a NULL value for hWnd is passed in along with an nIDEvent of an existing timer, 
		/// that timer will be replaced in the same way that an existing non-NULL hWnd timer will be.</param>
		/// </para>
		/// <param name="nIDEvent">
		/// A nonzero timer identifier. If the hWnd parameter is NULL, and the nIDEvent does not match an existing timer then it is ignored and a new timer ID is generated. 
		/// If the hWnd parameter is not NULL and the window specified by hWnd already has a timer with the value nIDEvent, then the existing timer is replaced by 
		/// the new timer. When SetTimer replaces a timer, the timer is reset. Therefore, a message will be sent after the current time-out value elapses, 
		/// but the previously set time-out value is ignored. If the call is not intended to replace an existing timer, nIDEvent should be 0 if the hWnd is NULL. 
		/// </param>
		/// <param name="uElapse">
		/// If uElapse is less than USER_TIMER_MINIMUM (0x0000000A), the timeout is set to USER_TIMER_MINIMUM. 
		/// <para>
		/// If uElapse is greater than USER_TIMER_MAXIMUM (0x7FFFFFFF), the timeout is set to USER_TIMER_MAXIMUM.
		/// </para>
		/// </param>
		/// <param name="lpTimerFunc">
		/// A pointer to the function to be notified when the time-out value elapses. For more information about the function, see TimerProc. 
		/// <para>
		/// If lpTimerFunc is NULL, the system posts a WM_TIMER message to the application queue. 
		/// </para>
		/// <para>
		/// The hwnd member of the message's MSG structure contains the value of the hWnd parameter. 
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds and the hWnd parameter is NULL, the return value is an integer identifying the new timer. 
		/// <para>
		/// An application can pass this value to the KillTimer function to destroy the timer.
		/// </para>
		/// <para>
		/// If the function succeeds and the hWnd parameter is not NULL, then the return value is a nonzero integer. 
		/// </para>
		/// <para>
		/// An application can pass the value of the nIDEvent parameter to the KillTimer function to destroy the timer.
		/// </para>
		/// <para>
		/// If the function fails to create a timer, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// An application can process WM_TIMER messages by including a WM_TIMER case statement in the window procedure or by specifying a TimerProc callback function 
		/// when creating the timer. When you specify a TimerProc callback function, the default window procedure calls the callback function when it processes WM_TIMER. 
		/// Therefore, you need to dispatch messages in the calling thread, even when you use TimerProc instead of processing WM_TIMER.
		/// <para>
		/// The wParam parameter of the WM_TIMER message contains the value of the nIDEvent parameter. 
		/// </para>
		/// <para>
		/// The timer identifier, nIDEvent, is specific to the associated window. Another window can have its own timer which has the same identifier as a timer 
		/// owned by another window. The timers are distinct. 
		/// </para>
		/// <para>
		/// SetTimer can reuse timer IDs in the case where hWnd is NULL. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32 )]
		public static extern uint SetTimer ( IntPtr  hWnd, uint  nIDEvent, uint uElapse, IntPtr  lpTimerFunc ) ;
		# endregion


		# region Version with callback function (delegate).
		/// <summary>
		/// Creates a timer with the specified time-out value.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window to be associated with the timer. 
		/// <para>
		/// This window must be owned by the calling thread. If a NULL value for hWnd is passed in along with an nIDEvent of an existing timer, 
		/// that timer will be replaced in the same way that an existing non-NULL hWnd timer will be.</param>
		/// </para>
		/// <param name="nIDEvent">
		/// A nonzero timer identifier. If the hWnd parameter is NULL, and the nIDEvent does not match an existing timer then it is ignored and a new timer ID is generated. 
		/// If the hWnd parameter is not NULL and the window specified by hWnd already has a timer with the value nIDEvent, then the existing timer is replaced by 
		/// the new timer. When SetTimer replaces a timer, the timer is reset. Therefore, a message will be sent after the current time-out value elapses, 
		/// but the previously set time-out value is ignored. If the call is not intended to replace an existing timer, nIDEvent should be 0 if the hWnd is NULL. 
		/// </param>
		/// <param name="uElapse">
		/// If uElapse is less than USER_TIMER_MINIMUM (0x0000000A), the timeout is set to USER_TIMER_MINIMUM. 
		/// <para>
		/// If uElapse is greater than USER_TIMER_MAXIMUM (0x7FFFFFFF), the timeout is set to USER_TIMER_MAXIMUM.
		/// </para>
		/// </param>
		/// <param name="lpTimerFunc">
		/// A pointer to the function to be notified when the time-out value elapses. This function is a TIMERPROC delegate.
		/// <para>
		/// If lpTimerFunc is NULL, the system posts a WM_TIMER message to the application queue. 
		/// </para>
		/// <para>
		/// The hwnd member of the message's MSG structure contains the value of the hWnd parameter. 
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds and the hWnd parameter is NULL, the return value is an integer identifying the new timer. 
		/// <para>
		/// An application can pass this value to the KillTimer function to destroy the timer.
		/// </para>
		/// <para>
		/// If the function succeeds and the hWnd parameter is not NULL, then the return value is a nonzero integer. 
		/// </para>
		/// <para>
		/// An application can pass the value of the nIDEvent parameter to the KillTimer function to destroy the timer.
		/// </para>
		/// <para>
		/// If the function fails to create a timer, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// An application can process WM_TIMER messages by including a WM_TIMER case statement in the window procedure or by specifying a TimerProc callback function 
		/// when creating the timer. When you specify a TimerProc callback function, the default window procedure calls the callback function when it processes WM_TIMER. 
		/// Therefore, you need to dispatch messages in the calling thread, even when you use TimerProc instead of processing WM_TIMER.
		/// <para>
		/// The wParam parameter of the WM_TIMER message contains the value of the nIDEvent parameter. 
		/// </para>
		/// <para>
		/// The timer identifier, nIDEvent, is specific to the associated window. Another window can have its own timer which has the same identifier as a timer 
		/// owned by another window. The timers are distinct. 
		/// </para>
		/// <para>
		/// SetTimer can reuse timer IDs in the case where hWnd is NULL. 
		/// </para>
		/// </remarks>
		public static uint SetTimer ( uint  nIDEvent, uint uElapse, TIMERPROC  lpTimerFunc )
		   {
			return ( SetTimer ( IntPtr.Zero, nIDEvent, uElapse, Marshal. GetFunctionPointerForDelegate ( lpTimerFunc ) ) ) ;
		    }
		# endregion


		# region Version that processes WM_TIMER messages instead of specifying a callback function.
		/// <summary>
		/// Creates a timer with the specified time-out value.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window to be associated with the timer. 
		/// <para>
		/// This window must be owned by the calling thread. If a NULL value for hWnd is passed in along with an nIDEvent of an existing timer, 
		/// that timer will be replaced in the same way that an existing non-NULL hWnd timer will be.</param>
		/// </para>
		/// <param name="nIDEvent">
		/// A nonzero timer identifier. If the hWnd parameter is NULL, and the nIDEvent does not match an existing timer then it is ignored and a new timer ID is generated. 
		/// If the hWnd parameter is not NULL and the window specified by hWnd already has a timer with the value nIDEvent, then the existing timer is replaced by 
		/// the new timer. When SetTimer replaces a timer, the timer is reset. Therefore, a message will be sent after the current time-out value elapses, 
		/// but the previously set time-out value is ignored. If the call is not intended to replace an existing timer, nIDEvent should be 0 if the hWnd is NULL. 
		/// </param>
		/// <param name="uElapse">
		/// If uElapse is less than USER_TIMER_MINIMUM (0x0000000A), the timeout is set to USER_TIMER_MINIMUM. 
		/// <para>
		/// If uElapse is greater than USER_TIMER_MAXIMUM (0x7FFFFFFF), the timeout is set to USER_TIMER_MAXIMUM.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds and the hWnd parameter is NULL, the return value is an integer identifying the new timer. 
		/// <para>
		/// An application can pass this value to the KillTimer function to destroy the timer.
		/// </para>
		/// <para>
		/// If the function succeeds and the hWnd parameter is not NULL, then the return value is a nonzero integer. 
		/// </para>
		/// <para>
		/// An application can pass the value of the nIDEvent parameter to the KillTimer function to destroy the timer.
		/// </para>
		/// <para>
		/// If the function fails to create a timer, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// An application can process WM_TIMER messages by including a WM_TIMER case statement in the window procedure or by specifying a TimerProc callback function 
		/// when creating the timer. When you specify a TimerProc callback function, the default window procedure calls the callback function when it processes WM_TIMER. 
		/// Therefore, you need to dispatch messages in the calling thread, even when you use TimerProc instead of processing WM_TIMER.
		/// <para>
		/// The wParam parameter of the WM_TIMER message contains the value of the nIDEvent parameter. 
		/// </para>
		/// <para>
		/// The timer identifier, nIDEvent, is specific to the associated window. Another window can have its own timer which has the same identifier as a timer 
		/// owned by another window. The timers are distinct. 
		/// </para>
		/// <para>
		/// SetTimer can reuse timer IDs in the case where hWnd is NULL. 
		/// </para>
		/// </remarks>
		public static uint  SetTimer ( IntPtr  hWnd, uint  nIDEvent, uint  uElapse )
		   {
			return ( SetTimer ( hWnd, nIDEvent, uElapse, IntPtr. Zero ) ) ;
		    }
		# endregion
	    }
    }