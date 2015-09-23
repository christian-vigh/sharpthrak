/**************************************************************************************************************

    NAME
        WinAPI/User32/C/CreateCaret.cs

    DESCRIPTION
        CreateCaret() Windows function.

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
		/// Creates a new shape for the system caret and assigns ownership of the caret to the specified window. 
		/// The caret shape can be a line, a block, or a bitmap.
		/// </summary>
		/// <param name="hWnd">A handle to the window that owns the caret. </param>
		/// <param name="hBitmap">
		/// handle to the bitmap that defines the caret shape. If this parameter is NULL, the caret is solid. If this parameter is (HBITMAP) 1, 
		/// the caret is gray. If this parameter is a bitmap handle, the caret is the specified bitmap. The bitmap handle must have been created by 
		/// the CreateBitmap, CreateDIBitmap, or LoadBitmap function.
		/// <br/>
		/// <para>
		/// If hBitmap is a bitmap handle, CreateCaret ignores the nWidth and nHeight parameters; the bitmap defines its own width and height.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// The width of the caret, in logical units. If this parameter is zero, the width is set to the system-defined window border width. 
		/// If hBitmap is a bitmap handle, CreateCaret ignores this parameter.
		/// </param>
		/// <param name="nHeight">
		/// The height of the caret, in logical units. If this parameter is zero, the height is set to the system-defined window border height. 
		/// If hBitmap is a bitmap handle, CreateCaret ignores this parameter. 
		/// </param>
		/// <returns>
		/// the function succeeds, the return value is nonzero. 
		/// <br/>
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		/// The nWidth and nHeight parameters specify the caret's width and height, in logical units; the exact width and height, in pixels, 
		/// depend on the window's mapping mode. 
		/// <br/>
		/// <para>
		/// CreateCaret automatically destroys the previous caret shape, if any, regardless of the window that owns the caret. 
		/// The caret is hidden until the application calls the ShowCaret function to make the caret visible. 
		/// </para>
		/// <br/>
		/// <para>
		/// The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. 
		/// The window should destroy the caret before losing the keyboard focus or becoming inactive. 
		/// </para>
		/// <br/>
		/// <para>
		/// You can retrieve the width or height of the system's window border by using the GetSystemMetrics function, 
		/// specifying the SM_CXBORDER and SM_CYBORDER values. Using the window border width or height guarantees that the caret will be visible 
		/// on a high-resolution screen. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CreateCaret ( IntPtr  hWnd, IntPtr  hBitmap, int  nWidth, int  nHeight ) ;
		# endregion
	    }
    }