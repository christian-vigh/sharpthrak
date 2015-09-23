/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DrawIconEx.cs

    DESCRIPTION
        DrawIconEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
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
		/// Draws an icon or cursor into the specified device context, performing the specified raster operations, and stretching or compressing 
		/// the icon or cursor as specified. 
		/// </summary>
		/// <param name="hDC">A handle to the device context into which the icon or cursor will be drawn. </param>
		/// <param name="x">The logical x-coordinate of the upper-left corner of the icon or cursor. </param>
		/// <param name="y">The logical y-coordinate of the upper-left corner of the icon or cursor. </param>
		/// <param name="hIcon">A handle to the icon or cursor to be drawn. This parameter can identify an animated cursor. </param>
		/// <param name="cx">
		/// The logical width of the icon or cursor. If this parameter is zero and the diFlags parameter is DI_DEFAULTSIZE, 
		/// the function uses the SM_CXICON system metric value to set the width. If this parameter is zero and DI_DEFAULTSIZE is not used, the function uses the actual resource width.
		/// </param>
		/// <param name="cy">
		/// The logical height of the icon or cursor. If this parameter is zero and the diFlags parameter is DI_DEFAULTSIZE, 
		/// the function uses the SM_CYICON system metric value to set the width. 
		/// If this parameter is zero and DI_DEFAULTSIZE is not used, the function uses the actual resource height. 
		/// </param>
		/// <param name="istepIfAniCur">
		/// The index of the frame to draw, if hIcon identifies an animated cursor. This parameter is ignored if hIcon does not identify an animated cursor. 
		/// </param>
		/// <param name="hbrFlickerFreeDraw">
		/// handle to a brush that the system uses for flicker-free drawing. If hbrFlickerFreeDraw is a valid brush handle, the system creates an offscreen bitmap 
		/// using the specified brush for the background color, draws the icon or cursor into the bitmap, and then copies the bitmap into the device context identified by hdc. 
		/// If hbrFlickerFreeDraw is NULL, the system draws the icon or cursor directly into the device context. 
		/// </param>
		/// <param name="diFlags">The drawing flags. This parameter can be one of the DI_Constants values.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	DrawIconEx ( IntPtr  hDC, int  x, int  y, IntPtr  hIcon, int  cx, int  cy, uint  istepIfAniCur, 
								IntPtr  hbrFlickerFreeDraw, DI_Constants  diFlags ) ;
		# endregion
	    }
    }