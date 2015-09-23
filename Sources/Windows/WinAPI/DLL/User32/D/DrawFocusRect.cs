/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DrawFocusRect.cs

    DESCRIPTION
        DrawFocusRect() Windows function.

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
		/// The DrawFocusRect function draws a rectangle in the style used to indicate that the rectangle has the focus.
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lprc">A pointer to a RECT structure that specifies the logical coordinates of the rectangle.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// DrawFocusRect works only in MM_TEXT mode.
		/// <br/>
		/// <para>
		/// Because DrawFocusRect is an XOR function, calling it a second time with the same rectangle removes the rectangle from the screen.
		/// </para>
		/// <br/>
		/// <para>
		/// This function draws a rectangle that cannot be scrolled. To scroll an area containing a rectangle drawn by this function, 
		/// call DrawFocusRect to remove the rectangle from the screen, scroll the area, and then call DrawFocusRect again to draw 
		/// the rectangle in the new position.
		/// </para>
		/// <br/>
		/// <para>
		/// Windows XP: The focus rectangle can now be thicker than 1 pixel, so it is more visible for high-resolution, high-density displays 
		/// and accessibility needs. This is handled by the SPI_SETFOCUSBORDERWIDTH and SPI_SETFOCUSBORDERHEIGHT in SystemParametersInfo.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	DrawFocusRect ( IntPtr  hDC, RECT  lprc ) ;
		# endregion
	    }
    }