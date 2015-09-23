/**************************************************************************************************************

    NAME
        WinAPI/User32/U/UpdateLayeredWindow.cs

    DESCRIPTION
        UpdateLayeredWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
		/// Updates the position, size, shape, content, and translucency of a layered window. 
		/// </summary>
		/// <param name="hwnd">
		/// handle to a layered window. A layered window is created by specifying WS_EX_LAYERED when creating the window with the CreateWindowEx function. 
		/// <br/>
		/// <para>
		/// Windows 8:  The WS_EX_LAYERED style is supported for top-level windows and child windows. Previous Windows versions support WS_EX_LAYERED only 
		/// for top-level windows.
		/// </para>
		/// </param>
		/// <param name="hdcDst">
		/// handle to a DC for the screen. This handle is obtained by specifying NULL when calling the function. 
		/// It is used for palette color matching when the window contents are updated. If hdcDst isNULL, the default palette will be used.
		/// <br/>
		/// <para>
		/// If hdcSrc is NULL, hdcDst must be NULL.
		/// </para>
		/// </param>
		/// <param name="pptDst">
		/// pointer to a structure that specifies the new screen position of the layered window. If the current position is not changing, pptDst can be NULL.
		/// </param>
		/// <param name="pSize">
		/// A pointer to a structure that specifies the new size of the layered window. If the size of the window is not changing, psize can be NULL. 
		/// If hdcSrc is NULL, psize must be NULL. 
		/// </param>
		/// <param name="hdcSrc">
		/// A handle to a DC for the surface that defines the layered window. This handle can be obtained by calling the CreateCompatibleDC function. 
		/// If the shape and visual context of the window are not changing, hdcSrc can be NULL. 
		/// </param>
		/// <param name="pptSrc">
		/// A pointer to a structure that specifies the location of the layer in the device context. If hdcSrc is NULL, pptSrc should be NULL. 
		/// </param>
		/// <param name="crKey">
		/// A structure that specifies the color key to be used when composing the layered window. To generate a COLORREF, use the RGB macro. 
		/// </param>
		/// <param name="pBlend">A pointer to a structure that specifies the transparency value to be used when composing the layered window. </param>
		/// <param name="dwFlags">This parameter can be one of the ULW_Constants values.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The source DC should contain the surface that defines the visible contents of the layered window. 
		/// For example, you can select a bitmap into a device context obtained by calling the CreateCompatibleDC function. 
		/// <br/>
		/// <para>
		/// An application should call SetLayout on the hdcSrc device context to properly set the mirroring mode. 
		/// SetLayout will properly mirror all drawing into an HDC while properly preserving text glyph and (optionally) bitmap direction order. 
		/// It cannot modify drawing directly into the bits of a device-independent bitmap (DIB). For more information, see Window Layout and Mirroring.
		/// </para>
		/// <br/>
		/// <para>
		/// The UpdateLayeredWindow function maintains the window's appearance on the screen. The windows underneath a layered window do not need to be repainted 
		/// when they are uncovered due to a call to UpdateLayeredWindow, because the system will automatically repaint them. 
		/// This permits seamless animation of the layered window. 
		/// </para>
		/// <br/>
		/// <para>
		/// UpdateLayeredWindow always updates the entire window. 
		/// To update part of a window, use the traditional WM_PAINT and set the blend value using SetLayeredWindowAttributes.
		/// </para>
		/// <br/>
		/// <para>
		/// For best drawing performance by the layered window and any underlying windows, the layered window should be as small as possible. 
		/// An application should also process the message and re-create its layered windows when the display's color depth changes.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern IntPtr 	UpdateLayeredWindow ( IntPtr			hwnd,
								      IntPtr			hdcDst,
								      ref POINT			pptDst,
								      ref SIZE			pSize,
								      IntPtr			hdcSrc,
								      ref POINT			pptSrc,
								      uint			crKey,
								      [In] ref BLENDFUNCTION	pBlend,
								      ULW_Constants		dwFlags ) ;
		# endregion
	    }
    }