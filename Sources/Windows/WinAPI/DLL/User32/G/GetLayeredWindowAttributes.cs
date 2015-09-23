/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetLayeredWindowAttributes.cs

    DESCRIPTION
        GetLayeredWindowAttributes() Windows function.

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
		/// Retrieves the opacity and transparency color key of a layered window.
		/// </summary>
		/// <param name="hwnd">
		/// handle to the layered window. A layered window is created by specifying WS_EX_LAYERED when creating the window with the CreateWindowEx function or 
		/// by setting WS_EX_LAYERED using SetWindowLong after the window has been created. 
		/// </param>
		/// <param name="pcrKey">
		/// A pointer to a COLORREF value that receives the transparency color key to be used when composing the layered window. 
		/// All pixels painted by the window in this color will be transparent. This can be NULL if the argument is not needed. 
		/// </param>
		/// <param name="pbAlpha">
		/// The Alpha value used to describe the opacity of the layered window. Similar to the SourceConstantAlpha member of the BLENDFUNCTION structure. 
		/// When the variable referred to by pbAlpha is 0, the window is completely transparent. When the variable referred to by pbAlpha is 255, the window is opaque. 
		/// This can be NULL if the argument is not needed. 
		/// </param>
		/// <param name="pdwFlags">
		/// A layering flag. This parameter can be NULL if the value is not needed. The layering flag can be one or more of LWA_Constants values.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para> 
		/// </returns>
		/// <remarks>
		/// GetLayeredWindowAttributes can be called only if the application has previously called SetLayeredWindowAttributes on the window. 
		/// The function will fail if the layered window was setup with UpdateLayeredWindow.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetLayeredWindowAttributes ( IntPtr  hwnd, out uint  pcrKey, out byte  pbAlpha, out  LWA_Constants  pdwFlags ) ;
		# endregion
	    }
    }