/**************************************************************************************************************

    NAME
        WinAPI/User32/C/ClipCursor.cs

    DESCRIPTION
        ClipCursor() Windows function.

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
		/// Confines the cursor to a rectangular area on the screen. If a subsequent cursor position (set by the SetCursorPos function or the mouse) 
		/// lies outside the rectangle, the system automatically adjusts the position to keep the cursor inside the rectangular area. 
		/// </summary>
		/// <param name="lpRect">
		/// A pointer to the structure that contains the screen coordinates of the upper-left and lower-right corners of the confining rectangle.
		/// If this parameter is NULL, the cursor is free to move anywhere on the screen. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The cursor is a shared resource. If an application confines the cursor, it must release the cursor by using ClipCursor before 
		/// relinquishing control to another application. 
		/// <br/>
		/// <para>
		/// The calling process must have WINSTA_WRITEATTRIBUTES access to the window station. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ClipCursor ( RECT  lpRect ) ;
		# endregion
	    }
    }