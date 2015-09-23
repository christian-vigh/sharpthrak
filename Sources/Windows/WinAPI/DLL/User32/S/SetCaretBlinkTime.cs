/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetCaretBlinkTime.cs

    DESCRIPTION
        SetCaretBlinkTime() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
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
		/// Sets the caret blink time to the specified number of milliseconds. 
		/// The blink time is the elapsed time, in milliseconds, required to invert the caret's pixels. 
		/// </summary>
		/// <param name="uMSeconds">The new blink time, in milliseconds. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// The user can set the blink time using the Control Panel. Applications should respect the setting that the user has chosen.
		/// The SetCaretBlinkTime function should only be used by application that allow the user to set the blink time, 
		/// such as a Control Panel applet.
		/// <br/>
		/// <para>
		/// If you change the blink time, subsequently activated applications will use the modified blink time, even if you restore 
		/// the previous blink time when you lose the keyboard focus or become inactive. This is due to the multithreaded environment, 
		/// where deactivation of your application is not synchronized with the activation of another application. 
		/// This feature allows the system to activate another application even if the current application is not responding. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetCaretBlinkTime ( uint  uMSeconds ) ;
		# endregion
	    }
    }