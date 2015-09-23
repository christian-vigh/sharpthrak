/**************************************************************************************************************

    NAME
        WinAPI/User32/P/PhysicalToLogicalPoint.cs

    DESCRIPTION
        PhysicalToLogicalPoint() Windows function.

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
		/// Converts the physical coordinates of a point in a window to logical coordinates.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose transform is used for the conversion. Top level windows are fully supported. 
		/// In the case of child windows, only the area of overlap between the parent and the child window is converted.
		/// </param>
		/// <param name="lpPoint">
		/// A pointer to a POINT structure that specifies the physical/screen coordinates to be converted. 
		/// The new logical coordinates are copied into this structure if the function succeeds.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. 
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// Windows Vista introduces the concept of physical coordinates. Desktop Window Manager (DWM) scales non-dots per inch (dpi) 
		/// aware windows when the display is high dpi. The window seen on the screen corresponds to the physical coordinates. 
		/// The application continues to work in logical space. Therefore, the application's view of the window is different from that 
		/// which appears on the screen. For scaled windows, logical and physical coordinates are different.
		/// <br/>
		/// <para>
		/// The function uses the window identified by the hWnd parameter and the physical coordinates given in the POINT structure 
		/// to compute the logical coordinates. The logical coordinates are the unscaled coordinates that appear to the application 
		/// in a programmatic way. In other words, the logical coordinates are the coordinates the application recognizes, 
		/// which can be different from the physical coordinates. The API then replaces the physical coordinates with the logical coordinates. 
		/// The new coordinates are in the world coordinates whose origin is (0, 0) on the desktop. The coordinates passed to the API have to be 
		/// on the hWnd.
		/// </para>
		/// <br/>
		/// <para>
		/// The source coordinates are in device units.
		/// </para>
		/// <br/>
		/// <para>
		/// On all platforms, PhysicalToLogicalPoint will fail on a window that has either 0 width or height; an application must first establish 
		/// a non-0 width and height by calling, for example, MoveWindow. On some versions of Windows (including Windows 7), 
		/// PhysicalToLogicalPoint will still fail if MoveWindow has been called after a call to ShowWindow with SH_HIDE has hidden the window.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	PhysicalToLogicalPoint ( IntPtr  hWnd, ref POINT  lpPoint ) ;
		# endregion
	    }
    }