/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsWindowVisible.cs

    DESCRIPTION
        IsWindowVisible() Windows function.

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
		/// Determines the visibility state of the specified window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window to be tested. </param>
		/// <returns>
		/// If the specified window, its parent window, its parent's parent window, and so forth, have the WS_VISIBLE style, the return value is nonzero. 
		/// Otherwise, the return value is zero. 
		/// <para>
		/// Because the return value specifies whether the window has the WS_VISIBLE style, it may be nonzero even if the window is totally obscured by other windows. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The visibility state of a window is indicated by the WS_VISIBLE style bit. 
		/// When WS_VISIBLE is set, the window is displayed and subsequent drawing into it is displayed as long as the window has the WS_VISIBLE style. 
		/// <br/>
		/// <para>
		/// Any drawing to a window with the WS_VISIBLE style will not be displayed if the window is obscured by other windows or is clipped by its parent window. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsWindowVisible ( IntPtr  hwnd ) ;
		# endregion
	    }
    }