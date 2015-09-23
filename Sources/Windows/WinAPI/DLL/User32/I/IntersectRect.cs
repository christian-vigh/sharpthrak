/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IntersectRect.cs

    DESCRIPTION
        IntersectRect() Windows function.

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
		/// The IntersectRect function calculates the intersection of two source rectangles and places the coordinates of 
		/// the intersection rectangle into the destination rectangle. If the source rectangles do not intersect, an empty rectangle 
		/// (in which all coordinates are set to zero) is placed into the destination rectangle.
		/// </summary>
		/// <param name="lprcDst">
		/// A pointer to the RECT structure that is to receive the intersection of the rectangles pointed to by the lprcSrc1 and lprcSrc2 parameters.
		/// This parameter cannot be NULL.
		/// </param>
		/// <param name="lprcSrc1">A pointer to the RECT structure that contains the first source rectangle.</param>
		/// <param name="lprcSrc2">A pointer to the RECT structure that contains the second source rectangle.</param>
		/// <returns>
		/// If the rectangles intersect, the return value is nonzero.
		/// <para>If the rectangles do not intersect, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. 
		/// The mapping mode and the function in which the rectangle is used determine the units of measure.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IntersectRect ( out RECT  lprcDst, RECT  lprcSrc1, RECT  lprcSrc2 ) ;
		# endregion
	    }
    }