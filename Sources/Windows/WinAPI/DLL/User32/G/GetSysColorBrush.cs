/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetSysColorBrush.cs

    DESCRIPTION
        GetSysColorBrush() Windows function.

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
		/// The GetSysColorBrush function retrieves a handle identifying a logical brush that corresponds to the specified color index.
		/// </summary>
		/// <param name="nIndex">
		/// A color index. This value corresponds to the color used to paint one of the window elements. See GetSysColor for system color index values.
		/// </param>
		/// <returns>
		/// The return value identifies a logical brush if the nIndex parameter is supported by the current platform. Otherwise, it returns NULL.
		/// </returns>
		/// <remarks>
		/// A brush is a bitmap that the system uses to paint the interiors of filled shapes. 
		/// An application can retrieve the current system colors by calling the GetSysColor function. 
		/// An application can set the current system colors by calling the SetSysColors function.
		/// <br/>
		/// <para>
		/// An application must not register a window class for a window using a system brush. To register a window class with a system color, 
		/// see the documentation of the hbrBackground member of the WNDCLASS or WNDCLASSEX structures.
		/// </para>
		/// <br/>
		/// <para>
		/// System color brushes track changes in system colors. In other words, when the user changes a system color, 
		/// the associated system color brush automatically changes to the new color.
		/// </para>
		/// <br/>
		/// <para>
		/// To paint with a system color brush, an application should use GetSysColorBrush (nIndex) instead of 
		/// CreateSolidBrush ( GetSysColor (nIndex)), because GetSysColorBrush returns a cached brush instead of allocating a new one.
		/// </para>
		/// <br/>
		/// <para>
		/// System color brushes are owned by the system so you don't need to destroy them. Although you don't need to delete the logical brush 
		/// that GetSysColorBrush returns, no harm occurs by calling DeleteObject.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetSysColorBrush ( COLOR_Constants  nIndex ) ;
		# endregion
	    }
    }