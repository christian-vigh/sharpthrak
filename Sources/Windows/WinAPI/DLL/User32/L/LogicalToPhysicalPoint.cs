/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LogicalToPhysicalPoint.cs

    DESCRIPTION
        LogicalToPhysicalPoint() Windows function.

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
		/// Converts the logical coordinates of a point in a window to physical coordinates.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose transform is used for the conversion. Top level windows are fully supported. 
		/// In the case of child windows, only the area of overlap between the parent and the child window is converted.
		/// </param>
		/// <param name="lpPoint">
		/// A pointer to a POINT structure that specifies the logical coordinates to be converted. 
		/// The new physical coordinates are copied into this structure if the function succeeds.
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
		/// LogicalToPhysicalPoint is a transformation API that can be called by a process that declares itself as dpi aware. 
		/// The function uses the window identified by the hWnd parameter and the logical coordinates given in the POINT structure to compute 
		/// the physical coordinates.
		/// </para>
		/// <br/>
		/// <para>
		/// The LogicalToPhysicalPoint function replaces the logical coordinates in the POINT structure with the physical coordinates. 
		/// The physical coordinates are relative to the upper-left corner of the screen. The coordinates have to be inside the client area of hWnd.
		/// </para>
		/// <br/>
		/// <para>
		/// On all platforms, LogicalToPhysicalPoint will fail on a window that has either 0 width or height; an application must first 
		/// establish a non-0 width and height by calling, for example, MoveWindow. On some versions of Windows (including Windows 7), 
		/// LogicalToPhysicalPoint will still fail if MoveWindow has been called after a call to ShowWindow with SH_HIDE has hidden the window.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	LogicalToPhysicalPoint ( IntPtr  hWnd, ref POINT  lpPoint ) ;
		# endregion
	    }
    }