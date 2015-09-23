/**************************************************************************************************************

    NAME
        WinAPI/User32/F/FrameRect.cs

    DESCRIPTION
        FrameRect() Windows function.

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
		/// The FrameRect function draws a border around the specified rectangle by using the specified brush. 
		/// The width and height of the border are always one logical unit.
		/// </summary>
		/// <param name="hDC">A handle to the device context in which the border is drawn.</param>
		/// <param name="lprc">
		/// A pointer to a RECT structure that contains the logical coordinates of the upper-left and lower-right corners of the rectangle.
		/// </param>
		/// <param name="hbr">A handle to the brush used to draw the border.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The brush identified by the hbr parameter must have been created by using the CreateHatchBrush, CreatePatternBrush, 
		/// or CreateSolidBrush function, or retrieved by using the GetStockObject function.
		/// <br/>
		/// <para>
		/// If the bottom member of the RECT structure is less than the top member, or if the right member is less than the left member, 
		/// the function does not draw the rectangle.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	FrameRect ( IntPtr  hDC, RECT  lprc, IntPtr  hbr ) ;
		# endregion
	    }
    }