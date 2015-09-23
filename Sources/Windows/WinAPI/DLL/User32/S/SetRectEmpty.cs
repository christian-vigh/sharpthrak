/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetRectEmpty.cs

    DESCRIPTION
        SetRectEmpty() Windows function.

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
		/// The SetRectEmpty function creates an empty rectangle in which all coordinates are set to zero.
		/// </summary>
		/// <param name="lprc">Pointer to the RECT structure that contains the coordinates of the rectangle.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// Because applications can use rectangles for different purposes, the rectangle functions do not use an explicit unit of measure. 
		/// Instead, all rectangle coordinates and dimensions are given in signed, logical values. The mapping mode and the function 
		/// in which the rectangle is used determine the units of measure.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetRectEmpty ( out RECT  lprc ) ;
		# endregion
	    }
    }