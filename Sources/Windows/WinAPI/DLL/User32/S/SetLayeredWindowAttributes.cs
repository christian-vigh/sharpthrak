/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetLayeredWindowAttributes.cs

    DESCRIPTION
        SetLayeredWindowAttributes() Windows function.

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
		/// Sets the opacity and transparency color key of a layered window.
		/// </summary>
		/// <param name="hwnd">
		/// A handle to the layered window. A layered window is created by specifying WS_EX_LAYERED when creating the window with the CreateWindowEx function or 
		/// by setting WS_EX_LAYERED via SetWindowLong after the window has been created.
		/// <br/>
		/// <para>
		/// Windows 8:  The WS_EX_LAYERED style is supported for top-level windows and child windows. Previous Windows versions support WS_EX_LAYERED only for 
		/// top-level windows.
		/// </para>
		/// </param>
		/// <param name="crKey">
		/// A COLORREF structure that specifies the transparency color key to be used when composing the layered window. 
		/// All pixels painted by the window in this color will be transparent. To generate a COLORREF, use the RGB macro.
		/// </param>
		/// <param name="bAlpha">
		/// Alpha value used to describe the opacity of the layered window. Similar to the SourceConstantAlpha member of the BLENDFUNCTION structure. 
		/// When bAlpha is 0, the window is completely transparent. When bAlpha is 255, the window is opaque.
		/// </param>
		/// <param name="dwFlags">
		/// When set to LWA_ALPHA, use bAlpha to determine the opacity of the layered window.
		/// <para>
		/// >When set to LWA_COLORKEY, use crKey as the transparency color.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. 
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Note that once SetLayeredWindowAttributes has been called for a layered window, subsequent UpdateLayeredWindow calls will fail until 
		/// the layering style bit is cleared and set again.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetLayeredWindowAttributes ( IntPtr  hwnd, COLORREF  crKey, byte  bAlpha, LWA_Constants  dwFlags ) ;
		# endregion
	    }
    }