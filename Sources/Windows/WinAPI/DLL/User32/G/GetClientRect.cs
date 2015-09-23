/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetClientRect.cs

    DESCRIPTION
        GetClientRect() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
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
		/// Retrieves the coordinates of a window's client area. The client coordinates specify the upper-left and lower-right corners of the client area. 
		/// Because client coordinates are relative to the upper-left corner of a window's client area, the coordinates of the upper-left corner are (0,0). 
		/// </summary>
		/// <param name="hWnd">A handle to the window whose client coordinates are to be retrieved. </param>
		/// <param name="lpRect">
		/// A pointer to a RECT structure that receives the client coordinates. The left and top members are zero. 
		/// The right and bottom members contain the width and height of the window. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle are exclusive. 
		/// In other words, the pixel at (right, bottom) lies immediately outside the rectangle.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetClientRect ( IntPtr  hWnd, out RECT  lpRect ) ;
		# endregion
	    }
    }