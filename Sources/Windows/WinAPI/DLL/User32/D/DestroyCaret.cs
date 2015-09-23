/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DestroyCaret.cs

    DESCRIPTION
        DestroyCaret() Windows function.

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
		/// Destroys the caret's current shape, frees the caret from the window, and removes the caret from the screen. 
		/// </summary>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// DestroyCaret destroys the caret only if a window in the current task owns the caret. 
		/// If a window that is not in the current task owns the caret, DestroyCaret does nothing and returns FALSE. 
		/// <br/>
		/// <para>
		/// The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. 
		/// The window should destroy the caret before losing the keyboard focus or becoming inactive. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	DestroyCaret ( ) ;
		# endregion
	    }
    }