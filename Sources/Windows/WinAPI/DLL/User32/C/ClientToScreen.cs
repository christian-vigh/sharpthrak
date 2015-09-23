/**************************************************************************************************************

    NAME
        WinAPI/User32/C/ClientToScreen.cs

    DESCRIPTION
        ClientToScreen() Windows function.

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
		/// The ClientToScreen function converts the client-area coordinates of a specified point to screen coordinates.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose client area is used for the conversion.</param>
		/// <param name="lpPoint">
		/// A pointer to a POINT structure that contains the client coordinates to be converted. 
		/// The new screen coordinates are copied into this structure if the function succeeds.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The ClientToScreen function replaces the client-area coordinates in the POINT structure with the screen coordinates. 
		/// The screen coordinates are relative to the upper-left corner of the screen. Note, a screen-coordinate point that is above 
		/// the window's client area has a negative y-coordinate. Similarly, a screen coordinate to the left of a client area has 
		/// a negative x-coordinate.
		/// <br/>
		/// <para>
		/// All coordinates are device coordinates.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ClientToScreen ( IntPtr  hWnd, ref POINT  lpPoint ) ;
		# endregion
	    }
    }