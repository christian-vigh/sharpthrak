/**************************************************************************************************************

    NAME
        WinAPI/User32/F/FillRect.cs

    DESCRIPTION
        FillRect() Windows function.

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
		/// The FillRect function fills a rectangle by using the specified brush. This function includes the left and top borders, 
		/// but excludes the right and bottom borders of the rectangle.
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lprc">A pointer to a RECT structure that contains the logical coordinates of the rectangle to be filled.</param>
		/// <param name="hbr">A handle to the brush used to fill the rectangle.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The brush identified by the hbr parameter may be either a handle to a logical brush or a color value. 
		/// If specifying a handle to a logical brush, call one of the following functions to obtain the handle : CreateHatchBrush, 
		/// CreatePatternBrush, or CreateSolidBrush. 
		/// Additionally, you may retrieve a handle to one of the stock brushes by using the GetStockObject function. 
		/// If specifying a color value for the hbr parameter, it must be one of the standard system colors 
		/// (the value 1 must be added to the chosen color). 
		/// <br/>
		/// <para>
		/// When filling the specified rectangle, FillRect does not include the rectangle's right and bottom sides. 
		/// GDI fills a rectangle up to, but not including, the right column and bottom row, regardless of the current mapping mode.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	FillRect ( IntPtr  hDC, RECT  lprc, IntPtr  hbr ) ;
		# endregion
	    }
    }