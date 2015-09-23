/**************************************************************************************************************

    NAME
        WinAPI/User32/I/InflateRect.cs

    DESCRIPTION
        InflateRect() Windows function.

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
		/// The InflateRect function increases or decreases the width and height of the specified rectangle. 
		/// The InflateRect function adds dx units to the left and right ends of the rectangle and dy units to the top and bottom. 
		/// The dx and dy parameters are signed values; positive values increase the width and height, and negative values decrease them.
		/// </summary>
		/// <param name="lprc">A pointer to the RECT structure that increases or decreases in size.</param>
		/// <param name="dx">The amount to increase or decrease the rectangle width. This parameter must be negative to decrease the width.</param>
		/// <param name="dy">The amount to increase or decrease the rectangle height. This parameter must be negative to decrease the height.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. 
		/// The mapping mode and the function in which the rectangle is used determine the units of measure.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	InflateRect ( ref RECT  lprc, int  dx, int  dy ) ;
		# endregion
	    }
    }