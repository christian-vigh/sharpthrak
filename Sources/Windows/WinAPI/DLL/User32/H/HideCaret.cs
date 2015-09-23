/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HideCaret.cs

    DESCRIPTION
        HideCaret() Windows function.

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
		/// Removes the caret from the screen. Hiding a caret does not destroy its current shape or invalidate the insertion point. 
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window that owns the caret. If this parameter is NULL, HideCaret searches the current task 
		/// for the window that owns the caret. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// HideCaret hides the caret only if the specified window owns the caret. If the specified window does not own the caret, 
		/// HideCaret does nothing and returns FALSE. 
		/// <br/>
		/// <para>
		/// Hiding is cumulative. If your application calls HideCaret five times in a row, it must also call ShowCaret five times before the caret 
		/// is displayed. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	HideCaret ( IntPtr  hWnd ) ;
		# endregion
	    }
    }