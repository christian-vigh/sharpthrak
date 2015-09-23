/**************************************************************************************************************

    NAME
        WinAPI/User32/S/ShowCaret.cs

    DESCRIPTION
        ShowCaret() Windows function.

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
		/// Makes the caret visible on the screen at the caret's current position. When the caret becomes visible, it begins flashing automatically. 
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window that owns the caret. If this parameter is NULL, ShowCaret searches the current task for the window 
		/// that owns the caret. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// ShowCaret shows the caret only if the specified window owns the caret, the caret has a shape, and the caret has not been hidden 
		/// two or more times in a row. If one or more of these conditions is not met, ShowCaret does nothing and returns FALSE. 
		/// <br/>
		/// <para>
		/// Hiding is cumulative. If your application calls HideCaret five times in a row, it must also call ShowCaret 
		/// five times before the caret reappears. 
		/// </para>
		/// <br/>
		/// <para>
		/// The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. 
		/// The window should destroy the caret before losing the keyboard focus or becoming inactive. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ShowCaret ( IntPtr  hWnd ) ;
		# endregion
	    }
    }