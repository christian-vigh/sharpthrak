/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetDC.cs

    DESCRIPTION
        GetDC() Windows function.

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
		/// The GetDC function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen. 
		/// You can use the returned handle in subsequent GDI functions to draw in the DC. 
		/// The device context is an opaque data structure, whose values are used internally by GDI.
		/// <br/>
		/// <para>
		/// The GetDCEx function is an extension to GetDC, which gives an application more control over how and whether clipping occurs in the client area.
		/// </para>
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be retrieved. If this value is NULL, GetDC retrieves the DC for the entire screen.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the DC for the specified window's client area.
		/// <para>
		/// If the function fails, the return value is NULL.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The GetDC function retrieves a common, class, or private DC depending on the class style of the specified window. 
		/// For class and private DCs, GetDC leaves the previously assigned attributes unchanged. However, for common DCs, GetDC assigns default attributes 
		/// to the DC each time it is retrieved. For example, the default font is System, which is a bitmap font. 
		/// Because of this, the handle to a common DC returned by GetDC does not tell you what font, color, or brush was used when the window was drawn. 
		/// To determine the font, call GetTextFace.
		/// <br/>
		/// <para>
		/// Note that the handle to the DC can only be used by a single thread at any one time.
		/// </para>
		/// <br/>
		/// <para>
		/// After painting with a common DC, the ReleaseDC function must be called to release the DC. Class and private DCs do not have to be released. 
		/// ReleaseDC must be called from the same thread that called GetDC. The number of DCs is limited only by available memory.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetDC ( IntPtr  hWnd ) ;
		# endregion
	    }
    }