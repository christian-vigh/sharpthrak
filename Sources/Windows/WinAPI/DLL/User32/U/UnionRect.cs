/**************************************************************************************************************

    NAME
        WinAPI/User32/U/UnionRect.cs

    DESCRIPTION
        UnionRect() Windows function.

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
		/// The UnionRect function creates the union of two rectangles. The union is the smallest rectangle that contains both source rectangles.
		/// </summary>
		/// <param name="lprcDst">
		/// A pointer to the RECT structure that will receive a rectangle containing the rectangles pointed to by the lprcSrc1 and lprcSrc2 parameters.
		/// </param>
		/// <param name="lprcSrc1">A pointer to the RECT structure that contains the first source rectangle.</param>
		/// <param name="lprcSrc2">A pointer to the RECT structure that contains the second source rectangle.</param>
		/// <returns>
		/// If the specified structure contains a nonempty rectangle, the return value is nonzero.
		/// <para>If the specified structure does not contain a nonempty rectangle, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The system ignores the dimensions of an empty rectangle that is, a rectangle in which all coordinates are set to zero, 
		/// so that it has no height or no width.
		/// <br/>
		/// <para>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. 
		/// The mapping mode and the function in which the rectangle is used determine the units of measure.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	UnionRect ( out RECT  lprcDst, RECT  lprcSrc1, RECT  lprcSrc2 ) ;
		# endregion
	    }
    }