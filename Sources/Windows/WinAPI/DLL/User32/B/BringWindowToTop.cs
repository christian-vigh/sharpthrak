/**************************************************************************************************************

    NAME
        WinAPI/User32/B/BringWindowToTop.cs

    DESCRIPTION
        BringWindowToTop() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
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
		/// Brings the specified window to the top of the Z order. If the window is a top-level window, it is activated. 
		/// If the window is a child window, the top-level parent window associated with the child window is activated. 
		/// </summary>
		/// <param name="hwnd">A handle to the window to bring to the top of the Z order.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// Use the BringWindowToTop function to uncover any window that is partially or completely obscured by other windows. 
		/// <br/>
		/// <para>
		/// Calling this function is similar to calling the SetWindowPos function to change a window's position in the Z order. 
		/// BringWindowToTop does not make a window a top-level window. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	BringWindowToTop ( IntPtr  hwnd ) ;
		# endregion
	    }
    }