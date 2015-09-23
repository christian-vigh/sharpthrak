/**************************************************************************************************************

    NAME
        WinAPI/User32/K/KillTimer.cs

    DESCRIPTION
        KillTimer() Windows function.

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
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Destroys the specified timer. 
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window associated with the specified timer. This value must be the same as the hWnd value passed to the SetTimer function that created the timer. 
		/// </param>
		/// <param name="uIDEvent">
		/// The timer to be destroyed. If the window handle passed to SetTimer is valid, this parameter must be the same as the nIDEvent value passed to SetTimer. 
		/// <para>
		/// If the application calls SetTimer with hWnd set to NULL, this parameter must be the timer identifier returned by SetTimer. 
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The KillTimer function does not remove WM_TIMER messages already posted to the message queue.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	KillTimer ( IntPtr  hWnd, uint  uIDEvent ) ;
		# endregion
	    }
    }