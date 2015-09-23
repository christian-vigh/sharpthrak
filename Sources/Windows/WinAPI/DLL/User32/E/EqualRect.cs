/**************************************************************************************************************

    NAME
        WinAPI/User32/E/EqualRect.cs

    DESCRIPTION
        EqualRect() Windows function.

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
		/// The EqualRect function determines whether the two specified rectangles are equal by comparing the coordinates of 
		/// their upper-left and lower-right corners.
		/// </summary>
		/// <param name="lprc1">Pointer to a RECT structure that contains the logical coordinates of the first rectangle.</param>
		/// <param name="lprc2">Pointer to a RECT structure that contains the logical coordinates of the second rectangle.</param>
		/// <returns>
		/// If the two rectangles are identical, the return value is nonzero.
		/// <para>If the two rectangles are not identical, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The EqualRect function does not treat empty rectangles as equal if their coordinates are different.
		/// <br/>
		/// <para>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. The mapping mode and the function in which 
		/// the rectangle is used determine the units of measure.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	EqualRect ( RECT  lprc1, RECT  lprc2 ) ;
		# endregion
	    }
    }