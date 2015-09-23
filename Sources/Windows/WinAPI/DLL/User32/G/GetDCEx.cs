/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetDCEx.cs

    DESCRIPTION
        GetDCEx() Windows function.

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
		/// The GetDCEx function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen. 
		/// You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, 
		/// whose values are used internally by GDI.
		/// <br/>
		/// <para>
		/// This function is an extension to the GetDC function, which gives an application more control over how and whether clipping occurs in the client area.
		/// </para>
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be retrieved. If this value is NULL, GetDCEx retrieves the DC for the entire screen.</param>
		/// <param name="hrgnClip">
		/// A clipping region that may be combined with the visible region of the DC. If the value of flags is DCX_INTERSECTRGN or DCX_EXCLUDERGN, 
		/// then the operating system assumes ownership of the region and will automatically delete it when it is no longer needed. 
		/// In this case, the application should not use or delete the region after a successful call to GetDCEx.
		/// </param>
		/// <param name="flags">Specifies how the DC is created. This parameter can be one or more of the DCX_Constants values.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to the DC for the specified window.
		/// <para>
		/// If the function fails, the return value is NULL. An invalid value for the hWnd parameter will cause the function to fail.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Unless the display DC belongs to a window class, the ReleaseDC function must be called to release the DC after painting. 
		/// Also, ReleaseDC must be called from the same thread that called GetDCEx. The number of DCs is limited only by available memory.
		/// <br/>
		/// <para>
		/// The function returns a handle to a DC that belongs to the window's class if CS_CLASSDC, CS_OWNDC or CS_PARENTDC was specified as 
		/// a style in the WNDCLASS structure when the class was registered.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetDCEx ( IntPtr  hWnd, IntPtr  hrgnClip, DCX_Constants  flags ) ;
		# endregion
	    }
    }