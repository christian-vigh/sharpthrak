/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowDC.cs

    DESCRIPTION
        GetWindowDC() Windows function.

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
		/// The GetWindowDC function retrieves the device context (DC) for the entire window, including title bar, menus, and scroll bars. 
		/// A window device context permits painting anywhere in a window, because the origin of the device context is the upper-left corner of the window 
		/// instead of the client area.
		/// <br/>
		/// <para>
		/// GetWindowDC assigns default attributes to the window device context each time it retrieves the device context. Previous attributes are lost.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window with a device context that is to be retrieved. If this value is NULL, GetWindowDC retrieves the device context for the entire screen.
		/// <br/>
		/// <para>
		/// If this parameter is NULL, GetWindowDC retrieves the device context for the primary display monitor. 
		/// To get the device context for other display monitors, use the EnumDisplayMonitors and CreateDC functions.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to a device context for the specified window.
		/// <para>
		/// If the function fails, the return value is NULL, indicating an error or an invalid hWnd parameter.
		/// </para>
		/// </returns>
		/// <remarks>
		/// GetWindowDC is intended for special painting effects within a window's nonclient area. Painting in nonclient areas of any window is not recommended.
		/// <br/>
		/// <para>
		/// The GetSystemMetrics function can be used to retrieve the dimensions of various parts of the nonclient area, such as the title bar, menu, and scroll bars.
		/// </para>
		/// <br/>
		/// <para>
		/// The GetDC function can be used to retrieve a device context for the entire screen.
		/// </para>
		/// <br/>
		/// <para>
		/// After painting is complete, the ReleaseDC function must be called to release the device context. 
		/// Not releasing the window device context has serious effects on painting requested by applications.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetWindowDC ( IntPtr  hWnd ) ;
		# endregion
	    }
    }