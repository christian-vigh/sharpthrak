/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetCursorPos.cs

    DESCRIPTION
        GetCursorPos() Windows function.

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
		/// Retrieves the cursor's position, in screen coordinates.
		/// </summary>
		/// <param name="lpPoint">A pointer to a POINT structure that receives the screen coordinates of the cursor.</param>
		/// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
		/// <remarks>
		/// The cursor position is always specified in screen coordinates and is not affected by the mapping mode of the window that contains the cursor.
		/// <br/>
		/// <para>
		/// The calling process must have WINSTA_READATTRIBUTES access to the window station.
		/// </para>
		/// <br/>
		/// <para>
		/// The input desktop must be the current desktop when you call GetCursorPos. Call OpenInputDesktop to determine whether 
		/// the current desktop is the input desktop. If it is not, call SetThreadDesktop with the HDESK returned by OpenInputDesktop 
		/// to switch to that desktop.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetCursorPos ( out POINT  lpPoint ) ;
		# endregion
	    }
    }