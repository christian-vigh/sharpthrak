/**************************************************************************************************************

    NAME
        WinAPI/User32/S/ScreenToClient.cs

    DESCRIPTION
        ScreenToClient() Windows function.

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
		/// The ScreenToClient function converts the screen coordinates of a specified point on the screen to client-area coordinates.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose client area will be used for the conversion.</param>
		/// <param name="lpPoint">A pointer to a POINT structure that specifies the screen coordinates to be converted.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The function uses the window identified by the hWnd parameter and the screen coordinates given in the POINT structure to compute 
		/// client coordinates. It then replaces the screen coordinates with the client coordinates. 
		/// The new coordinates are relative to the upper-left corner of the specified window's client area.
		/// <br/>
		/// <para>
		/// The ScreenToClient function assumes the specified point is in screen coordinates.
		/// </para>
		/// <br/>
		/// <para>
		/// All coordinates are in device units.
		/// </para>
		/// <br/>
		/// <para>
		/// Do not use ScreenToClient when in a mirroring situation, that is, when changing from left-to-right layout to right-to-left layout. 
		/// Instead, use MapWindowPoints. For more information, see "Window Layout and Mirroring" in Window Features.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ScreenToClient ( IntPtr  hWnd, ref POINT  lpPoint ) ;
		# endregion
	    }
    }