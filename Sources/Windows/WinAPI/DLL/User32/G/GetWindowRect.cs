/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowRect.cs

    DESCRIPTION
        GetWindowRect() Windows function.

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
		/// Retrieves the dimensions of the bounding rectangle of the specified window. The dimensions are given in screen coordinates that are relative to 
		/// the upper-left corner of the screen.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose client coordinates are to be retrieved. </param>
		/// <param name="lpRect">
		/// A pointer to a RECT structure that receives the screen coordinates of the upper-left and lower-right corners of the window. 
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
		public static extern bool 	GetWindowRect ( IntPtr  hWnd, out RECT  lpRect ) ;
		# endregion
	    }
    }