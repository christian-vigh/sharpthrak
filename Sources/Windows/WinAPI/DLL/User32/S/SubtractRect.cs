/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SubtractRect.cs

    DESCRIPTION
        SubtractRect() Windows function.

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
		/// The SubtractRect function determines the coordinates of a rectangle formed by subtracting one rectangle from another.
		/// </summary>
		/// <param name="lprcDst">
		/// A pointer to a RECT structure that receives the coordinates of the rectangle determined by subtracting the rectangle 
		/// pointed to by lprcSrc2 from the rectangle pointed to by lprcSrc1.
		/// </param>
		/// <param name="lprcSrc1">A pointer to a RECT structure from which the function subtracts the rectangle pointed to by lprcSrc2.</param>
		/// <param name="lprcSrc2">A pointer to a RECT structure that the function subtracts from the rectangle pointed to by lprcSrc1.</param>
		/// <returns>
		/// If the resulting rectangle is empty, the return value is zero.
		/// <para>
		/// If the resulting rectangle is not empty, the return value is nonzero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The function only subtracts the rectangle specified by lprcSrc2 from the rectangle specified by lprcSrc1 when the rectangles 
		/// intersect completely in either the x- or y-direction. For example, if *lprcSrc1 has the coordinates (10,10,100,100) and *lprcSrc2 
		/// has the coordinates (50,50,150,150), the function sets the coordinates of the rectangle pointed to by lprcDst to (10,10,100,100). 
		/// If *lprcSrc1 has the coordinates (10,10,100,100) and *lprcSrc2 has the coordinates (50,10,150,150), however, 
		/// the function sets the coordinates of the rectangle pointed to by lprcDst to (10,10,50,100). 
		/// In other words, the resulting rectangle is the bounding box of the geometric difference.
		/// <br/>
		/// <para>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. 
		/// The mapping mode and the function in which the rectangle is used determine the units of measure.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SubtractRect ( out RECT  lprcDst, RECT  lprcSrc1, RECT  lprcSrc2 ) ;
		# endregion
	    }
    }