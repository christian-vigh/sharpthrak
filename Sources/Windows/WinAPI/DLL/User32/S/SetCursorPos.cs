/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetCursorPos.cs

    DESCRIPTION
        SetCursorPos() Windows function.

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
		/// Moves the cursor to the specified screen coordinates. If the new coordinates are not within the screen rectangle set by 
		/// the most recent ClipCursor function call, the system automatically adjusts the coordinates so that the cursor stays within the rectangle. 
		/// </summary>
		/// <param name="X">The new x-coordinate of the cursor, in screen coordinates. </param>
		/// <param name="Y">The new y-coordinate of the cursor, in screen coordinates. </param>
		/// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
		/// <remarks>
		/// The cursor is a shared resource. A window should move the cursor only when the cursor is in the window's client area.
		/// <br/>
		/// <para>
		/// The calling process must have WINSTA_WRITEATTRIBUTES access to the window station.
		/// </para>
		/// <br/>
		/// <para>
		/// The input desktop must be the current desktop when you call SetCursorPos. Call OpenInputDesktop to determine whether the current desktop
		/// is the input desktop. 
		/// If it is not, call SetThreadDesktop with the HDESK returned by OpenInputDesktop to switch to that desktop.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetCursorPos ( int  X, int  Y ) ;
		# endregion
	    }
    }