/**************************************************************************************************************

    NAME
        WinAPI/User32/P/PtInRect.cs

    DESCRIPTION
        PtInRect() Windows function.

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
		/// The PtInRect function determines whether the specified point lies within the specified rectangle.
		/// A point is within a rectangle if it lies on the left or top side or is within all four sides. 
		/// A point on the right or bottom side is considered outside the rectangle.
		/// </summary>
		/// <param name="lprc">A pointer to a RECT structure that contains the specified rectangle.</param>
		/// <param name="pt">A POINT structure that contains the specified point.</param>
		/// <returns>
		/// If the specified point lies within the rectangle, the return value is nonzero.
		/// <para>If the specified point does not lie within the rectangle, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The rectangle must be normalized before PtInRect is called. That is, lprc.right must be greater than lprc.left and lprc.bottom 
		/// must be greater than lprc.top. If the rectangle is not normalized, a point is never considered inside of the rectangle.
		/// <br/>
		/// <para>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. The mapping mode and the function in which 
		/// the rectangle is used determine the units of measure.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	PtInRect ( RECT  lprc, POINT  pt ) ;
		# endregion
	    }
    }