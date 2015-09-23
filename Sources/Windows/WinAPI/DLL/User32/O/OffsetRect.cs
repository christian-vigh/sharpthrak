/**************************************************************************************************************

    NAME
        WinAPI/User32/O/OffsetRect.cs

    DESCRIPTION
        OffsetRect() Windows function.

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
		/// The OffsetRect function moves the specified rectangle by the specified offsets.
		/// </summary>
		/// <param name="lprc">Pointer to a RECT structure that contains the logical coordinates of the rectangle to be moved.</param>
		/// <param name="dx">
		/// Specifies the amount to move the rectangle left or right. This parameter must be a negative value to move the rectangle to the left.
		/// </param>
		/// <param name="dy">
		/// Specifies the amount to move the rectangle up or down. This parameter must be a negative value to move the rectangle up.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. The mapping mode and the function in which 
		/// the rectangle is used determine the units of measure.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	OffsetRect ( ref RECT  lprc, int  dx, int  dy ) ;
		# endregion
	    }
    }