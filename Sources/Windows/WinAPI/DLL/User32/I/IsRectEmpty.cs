/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsRectEmpty.cs

    DESCRIPTION
        IsRectEmpty() Windows function.

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
		/// The IsRectEmpty function determines whether the specified rectangle is empty. 
		/// An empty rectangle is one that has no area; that is, the coordinate of the right side is less than or equal to the coordinate of 
		/// the left side, or the coordinate of the bottom side is less than or equal to the coordinate of the top side.
		/// </summary>
		/// <param name="lprc">Pointer to a RECT structure that contains the logical coordinates of the rectangle.</param>
		/// <returns>
		/// If the rectangle is empty, the return value is nonzero.
		/// <para>If the rectangle is not empty, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure.
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. The mapping mode and the function in which 
		/// the rectangle is used determine the units of measure.
 		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsRectEmpty ( RECT  lprc ) ;
		# endregion
	    }
    }