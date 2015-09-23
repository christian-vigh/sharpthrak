/**************************************************************************************************************

    NAME
        WinAPI/User32/I/InvertRect.cs

    DESCRIPTION
        InvertRect() Windows function.

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
		/// The InvertRect function inverts a rectangle in a window by performing a logical NOT operation on the color values for each pixel 
		/// in the rectangle's interior.
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lprc">A pointer to a RECT structure that contains the logical coordinates of the rectangle to be inverted.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// On monochrome screens, InvertRect makes white pixels black and black pixels white. 
		/// On color screens, the inversion depends on how colors are generated for the screen. 
		/// Calling InvertRect twice for the same rectangle restores the display to its previous colors.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	InvertRect ( IntPtr  hDC, RECT  lprc ) ;
		# endregion
	    }
    }