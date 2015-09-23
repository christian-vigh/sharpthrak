/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetRect.cs

    DESCRIPTION
        SetRect() Windows function.

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
		/// The SetRect function sets the coordinates of the specified rectangle. This is equivalent to assigning the left, top, right,
		/// and bottom arguments to the appropriate members of the RECT structure.
		/// </summary>
		/// <param name="lprc">Pointer to the RECT structure that contains the rectangle to be set.</param>
		/// <param name="xLeft">Specifies the x-coordinate of the rectangle's upper-left corner.</param>
		/// <param name="yTop">Specifies the y-coordinate of the rectangle's upper-left corner.</param>
		/// <param name="xRight">Specifies the x-coordinate of the rectangle's lower-right corner.</param>
		/// <param name="yBottom">Specifies the y-coordinate of the rectangle's lower-right corner.</param>
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
		public static extern bool 	SetRect ( out RECT  lprc, int  xLeft, int  yTop, int  xRight, int  yBottom ) ;
		# endregion
	    }
    }