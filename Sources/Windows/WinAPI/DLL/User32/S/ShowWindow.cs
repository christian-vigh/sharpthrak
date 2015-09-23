/**************************************************************************************************************

    NAME
        ShowWindow.cs

    DESCRIPTION
        ShowWindow() API.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Sets the specified window's show state. 
		/// </summary>
		/// <param name="hWnd">A handle to the window. </param>
		/// <param name="nCmdShow">
		/// Controls how the window is to be shown. This parameter is ignored the first time an application calls ShowWindow, 
		/// if the program that launched the application provides a STARTUPINFO structure. 
		/// <para>
		/// Otherwise, the first time ShowWindow is called, the value should be the value obtained by the WinMain function in its nCmdShow parameter. 
		/// In subsequent calls, this parameter can be one of the SW_Constants values.
		/// </para>
		/// </param>
		/// <returns>
		/// If the window was previously visible, the return value is nonzero. 
		/// <para>
		/// If the window was previously hidden, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// To perform certain special effects when showing or hiding a window, use AnimateWindow. 
		/// <para>
		/// The first time an application calls ShowWindow, it should use the WinMain function's nCmdShow parameter as its nCmdShow parameter. 
		/// Subsequent calls to ShowWindow must use one of the values in the given list, instead of the one specified by the WinMain function's nCmdShow parameter. 
		/// </para>
		/// <para>
		/// As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in the first call to ShowWindow if the program that launched 
		/// the application specifies startup information in the structure. In this case, ShowWindow uses the information specified in the STARTUPINFO structure 
		/// to show the window. On subsequent calls, the application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup information provided 
		/// by the program that launched the application. This behavior is designed for the following situations :  
		/// </para>
		/// <para>• Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set. </para>
		/// <para>• Applications create their main window by calling CreateWindow with the WS_VISIBLE flag cleared, and later call ShowWindow with the </para>
		/// <para>  SW_SHOW flag set to make it visible. </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	ShowWindow ( IntPtr  hWnd, int  nCmdShow ) ;
		# endregion


		# region Signature with an nCmdShowParameter as SW_Constants
		/// <summary>
		/// Sets the specified window's show state. 
		/// </summary>
		/// <param name="hWnd">A handle to the window. </param>
		/// <param name="nCmdShow">
		/// Controls how the window is to be shown. This parameter is ignored the first time an application calls ShowWindow, 
		/// if the program that launched the application provides a STARTUPINFO structure. 
		/// <para>
		/// Otherwise, the first time ShowWindow is called, the value should be the value obtained by the WinMain function in its nCmdShow parameter. 
		/// In subsequent calls, this parameter can be one of the SW_Constants values.
		/// </para>
		/// </param>
		/// <returns>
		/// If the window was previously visible, the return value is nonzero. 
		/// <para>
		/// If the window was previously hidden, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// To perform certain special effects when showing or hiding a window, use AnimateWindow. 
		/// <para>
		/// The first time an application calls ShowWindow, it should use the WinMain function's nCmdShow parameter as its nCmdShow parameter. 
		/// Subsequent calls to ShowWindow must use one of the values in the given list, instead of the one specified by the WinMain function's nCmdShow parameter. 
		/// </para>
		/// <para>
		/// As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in the first call to ShowWindow if the program that launched 
		/// the application specifies startup information in the structure. In this case, ShowWindow uses the information specified in the STARTUPINFO structure 
		/// to show the window. On subsequent calls, the application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup information provided 
		/// by the program that launched the application. This behavior is designed for the following situations :  
		/// </para>
		/// <para>• Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set. </para>
		/// <para>• Applications create their main window by calling CreateWindow with the WS_VISIBLE flag cleared, and later call ShowWindow with the </para>
		/// <para>  SW_SHOW flag set to make it visible. </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	ShowWindow ( IntPtr  hWnd, SW_Constants  nCmdShow ) ;
		# endregion
	    }
    }
