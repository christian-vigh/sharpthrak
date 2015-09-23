/**************************************************************************************************************

    NAME
        WinAPI/User32/C/CreateWindowEx.cs

    DESCRIPTION
        CreateWindowEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
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
		/// Creates an overlapped, pop-up, or child window with an extended window style; otherwise, this function is identical to the CreateWindow function. 
		/// For more information about creating a window and for full descriptions of the other parameters of CreateWindowEx, see CreateWindow. 
 		/// </summary>
		/// <param name="dwExStyle">
		/// The extended window style of the window being created. For a list of possible values,see Extended Window Styles.
		/// </param>
		/// <param name="lpClassName">
		/// A null-terminated string or a class atom created by a previous call to the RegisterClass or RegisterClassEx function. 
		/// <para>
		/// The atom must be in the low-order word of lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies the window class name. 
		/// </para>
		/// <para>
		/// The class name can be any name registered with RegisterClass or RegisterClassEx, provided that the module that registers the class is also the module 
		/// that creates the window. The class name can also be any of the predefined system class names. 
		/// </para>
		/// </param>
		/// <param name="lpWindowName">
		/// The window name. If the window style specifies a title bar, the window title pointed to by lpWindowName is displayed in the title bar. 
		/// <para>
		/// When using CreateWindow to create controls, such as buttons, check boxes, and static controls, use lpWindowName to specify the text of the control. 
		/// </para>
		/// When creating a static control with the SS_ICON style, use lpWindowName to specify the icon name or identifier. To specify an identifier, use the syntax "#num". 
		/// <para></para>
		/// </param>
		/// <param name="dwStyle">
		/// The style of the window being created. This parameter can be a combination of the window style values. 
		/// </param>
		/// <param name="x">
		/// The initial horizontal position of the window. For an overlapped or pop-up window, the x parameter is the initial x-coordinate of the window's 
		/// upper-left corner, in screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of the window relative to the upper-left 
		/// corner of the parent window's client area. 
		/// <para>
		/// If x is set to CW_USEDEFAULT, the system selects the default position for the window's upper-left corner and ignores the y parameter. 
		/// CW_USEDEFAULT is valid only for overlapped windows; if it is specified for a pop-up or child window, the x and y parameters are set to zero. 
		/// </para>
		/// </param>
		/// <param name="y">
		/// The initial vertical position of the window. For an overlapped or pop-up window, the y parameter is the initial y-coordinate of the window's upper-left corner, 
		/// in screen coordinates. For a child window, y is the initial y-coordinate of the upper-left corner of the child window relative to the upper-left corner 
		/// of the parent window's client area. For a list box y is the initial y-coordinate of the upper-left corner of the list box's client area relative to 
		/// the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter is set to CW_USEDEFAULT, then the y parameter determines how 
		/// the window is shown. If the y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW flag after the window has been created. 
		/// If the y parameter is some other value, then the window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in screen coordinates, or CW_USEDEFAULT. 
		/// If nWidth is CW_USEDEFAULT, the system selects a default width and height for the window; the default width extends from the initial x-coordinates 
		/// to the right edge of the screen; the default height extends from the initial y-coordinate to the top of the icon area. 
		/// <para>
		/// CW_USEDEFAULT is valid only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window, the nWidth and nHeight parameter are set to zero. 
		/// </para>
		/// </param>
		/// <param name="nHeight">
		/// The height, in device units, of the window. For overlapped windows, nHeight is the window's height, in screen coordinates. 
		/// <para>
		/// If the nWidth parameter is set to CW_USEDEFAULT, the system ignores nHeight. 
		/// </para>
		/// </param>
		/// <param name="hWndParent">
		/// A handle to the parent or owner window of the window being created. To create a child window or an owned window, supply a valid window handle. 
		/// <para>
		/// This parameter is optional for pop-up windows.
		/// </para>
		/// <para>
		/// To create a message-only window, supply HWND_MESSAGE or a handle to an existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// A handle to a menu, or specifies a child-window identifier, depending on the window style. For an overlapped or pop-up window, hMenu identifies 
		/// the menu to be used with the window; it can be NULL if the class menu is to be used. 
		/// <para>
		/// For a child window, hMenu specifies the child-window identifier, an integer value used by a dialog box control to notify its parent about events. 
		/// </para>
		/// <para>
		/// The application determines the child-window identifier; it must be unique for all child windows with the same parent window. 
		/// </para>
		/// </param>
		/// <param name="hInstance">
		/// A handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. 
		/// <para>
		/// This message is sent to the created window by this function before it returns.
		/// </para>
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point to a CLIENTCREATESTRUCT structure. 
		/// </para>
		/// <para>
		/// If an MDI client window calls CreateWindow to create an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be NULL 
		/// if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>
		/// This function typically fails for one of the following reasons: 
		/// </para>
		/// <para>• an invalid parameter value</para>
		/// <para>• the system class was registered by a different module</para>
		/// <para>• The WH_CBT hook is installed and returns a failure code</para>
		/// <para>• if one of the controls in the dialog template is not registered, or its window window procedure fails WM_CREATE or WM_NCCREATE</para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CreateWindowEx (   
							WS_EX_Constants			dwExStyle, 
							string				lpClassName,
							string				lpWindowName, 
							WS_Constants			dwStyle, 
							int				x, 
							int				y, 
							int				nWidth, 
							int				nHeight,
							IntPtr				hWndParent, 
							IntPtr				hMenu, 
							IntPtr				hInstance, 
							IntPtr				lpParam ) ;
		# endregion


		# region Version with CREATESTRUCT value for lParam
		/// Creates an overlapped, pop-up, or child window with an extended window style; otherwise, this function is identical to the CreateWindow function. 
		/// For more information about creating a window and for full descriptions of the other parameters of CreateWindowEx, see CreateWindow. 
 		/// </summary>
		/// <param name="dwExStyle">
		/// The extended window style of the window being created. For a list of possible values,see Extended Window Styles.
		/// </param>
		/// <param name="lpClassName">
		/// A null-terminated string or a class atom created by a previous call to the RegisterClass or RegisterClassEx function. 
		/// <para>
		/// The atom must be in the low-order word of lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies the window class name. 
		/// </para>
		/// <para>
		/// The class name can be any name registered with RegisterClass or RegisterClassEx, provided that the module that registers the class is also the module 
		/// that creates the window. The class name can also be any of the predefined system class names. 
		/// </para>
		/// </param>
		/// <param name="lpWindowName">
		/// The window name. If the window style specifies a title bar, the window title pointed to by lpWindowName is displayed in the title bar. 
		/// <para>
		/// When using CreateWindow to create controls, such as buttons, check boxes, and static controls, use lpWindowName to specify the text of the control. 
		/// </para>
		/// When creating a static control with the SS_ICON style, use lpWindowName to specify the icon name or identifier. To specify an identifier, use the syntax "#num". 
		/// <para></para>
		/// </param>
		/// <param name="dwStyle">
		/// The style of the window being created. This parameter can be a combination of the window style values. 
		/// </param>
		/// <param name="x">
		/// The initial horizontal position of the window. For an overlapped or pop-up window, the x parameter is the initial x-coordinate of the window's 
		/// upper-left corner, in screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of the window relative to the upper-left 
		/// corner of the parent window's client area. 
		/// <para>
		/// If x is set to CW_USEDEFAULT, the system selects the default position for the window's upper-left corner and ignores the y parameter. 
		/// CW_USEDEFAULT is valid only for overlapped windows; if it is specified for a pop-up or child window, the x and y parameters are set to zero. 
		/// </para>
		/// </param>
		/// <param name="y">
		/// The initial vertical position of the window. For an overlapped or pop-up window, the y parameter is the initial y-coordinate of the window's upper-left corner, 
		/// in screen coordinates. For a child window, y is the initial y-coordinate of the upper-left corner of the child window relative to the upper-left corner 
		/// of the parent window's client area. For a list box y is the initial y-coordinate of the upper-left corner of the list box's client area relative to 
		/// the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter is set to CW_USEDEFAULT, then the y parameter determines how 
		/// the window is shown. If the y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW flag after the window has been created. 
		/// If the y parameter is some other value, then the window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in screen coordinates, or CW_USEDEFAULT. 
		/// If nWidth is CW_USEDEFAULT, the system selects a default width and height for the window; the default width extends from the initial x-coordinates 
		/// to the right edge of the screen; the default height extends from the initial y-coordinate to the top of the icon area. 
		/// <para>
		/// CW_USEDEFAULT is valid only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window, the nWidth and nHeight parameter are set to zero. 
		/// </para>
		/// </param>
		/// <param name="nHeight">
		/// The height, in device units, of the window. For overlapped windows, nHeight is the window's height, in screen coordinates. 
		/// <para>
		/// If the nWidth parameter is set to CW_USEDEFAULT, the system ignores nHeight. 
		/// </para>
		/// </param>
		/// <param name="hWndParent">
		/// A handle to the parent or owner window of the window being created. To create a child window or an owned window, supply a valid window handle. 
		/// <para>
		/// This parameter is optional for pop-up windows.
		/// </para>
		/// <para>
		/// To create a message-only window, supply HWND_MESSAGE or a handle to an existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// A handle to a menu, or specifies a child-window identifier, depending on the window style. For an overlapped or pop-up window, hMenu identifies 
		/// the menu to be used with the window; it can be NULL if the class menu is to be used. 
		/// <para>
		/// For a child window, hMenu specifies the child-window identifier, an integer value used by a dialog box control to notify its parent about events. 
		/// </para>
		/// <para>
		/// The application determines the child-window identifier; it must be unique for all child windows with the same parent window. 
		/// </para>
		/// </param>
		/// <param name="hInstance">
		/// A handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. 
		/// <para>
		/// This message is sent to the created window by this function before it returns.
		/// </para>
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point to a CLIENTCREATESTRUCT structure. 
		/// </para>
		/// <para>
		/// If an MDI client window calls CreateWindow to create an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be NULL 
		/// if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>
		/// This function typically fails for one of the following reasons: 
		/// </para>
		/// <para>• an invalid parameter value</para>
		/// <para>• the system class was registered by a different module</para>
		/// <para>• The WH_CBT hook is installed and returns a failure code</para>
		/// <para>• if one of the controls in the dialog template is not registered, or its window window procedure fails WM_CREATE or WM_NCCREATE</para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CreateWindowEx (   
							WS_EX_Constants			dwExStyle, 
							string				lpClassName,
							string				lpWindowName, 
							WS_Constants			dwStyle, 
							int				x, 
							int				y, 
							int				nWidth, 
							int				nHeight,
							IntPtr				hWndParent, 
							IntPtr				hMenu, 
							IntPtr				hInstance, 
							ref CREATESTRUCT		lpParam ) ;
		# endregion


		# region Version with CLIENTCREATESTRUCT value for lParam
		/// Creates an overlapped, pop-up, or child window with an extended window style; otherwise, this function is identical to the CreateWindow function. 
		/// For more information about creating a window and for full descriptions of the other parameters of CreateWindowEx, see CreateWindow. 
 		/// </summary>
		/// <param name="dwExStyle">
		/// The extended window style of the window being created. For a list of possible values,see Extended Window Styles.
		/// </param>
		/// <param name="lpClassName">
		/// A null-terminated string or a class atom created by a previous call to the RegisterClass or RegisterClassEx function. 
		/// <para>
		/// The atom must be in the low-order word of lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies the window class name. 
		/// </para>
		/// <para>
		/// The class name can be any name registered with RegisterClass or RegisterClassEx, provided that the module that registers the class is also the module 
		/// that creates the window. The class name can also be any of the predefined system class names. 
		/// </para>
		/// </param>
		/// <param name="lpWindowName">
		/// The window name. If the window style specifies a title bar, the window title pointed to by lpWindowName is displayed in the title bar. 
		/// <para>
		/// When using CreateWindow to create controls, such as buttons, check boxes, and static controls, use lpWindowName to specify the text of the control. 
		/// </para>
		/// When creating a static control with the SS_ICON style, use lpWindowName to specify the icon name or identifier. To specify an identifier, use the syntax "#num". 
		/// <para></para>
		/// </param>
		/// <param name="dwStyle">
		/// The style of the window being created. This parameter can be a combination of the window style values. 
		/// </param>
		/// <param name="x">
		/// The initial horizontal position of the window. For an overlapped or pop-up window, the x parameter is the initial x-coordinate of the window's 
		/// upper-left corner, in screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of the window relative to the upper-left 
		/// corner of the parent window's client area. 
		/// <para>
		/// If x is set to CW_USEDEFAULT, the system selects the default position for the window's upper-left corner and ignores the y parameter. 
		/// CW_USEDEFAULT is valid only for overlapped windows; if it is specified for a pop-up or child window, the x and y parameters are set to zero. 
		/// </para>
		/// </param>
		/// <param name="y">
		/// The initial vertical position of the window. For an overlapped or pop-up window, the y parameter is the initial y-coordinate of the window's upper-left corner, 
		/// in screen coordinates. For a child window, y is the initial y-coordinate of the upper-left corner of the child window relative to the upper-left corner 
		/// of the parent window's client area. For a list box y is the initial y-coordinate of the upper-left corner of the list box's client area relative to 
		/// the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter is set to CW_USEDEFAULT, then the y parameter determines how 
		/// the window is shown. If the y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW flag after the window has been created. 
		/// If the y parameter is some other value, then the window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in screen coordinates, or CW_USEDEFAULT. 
		/// If nWidth is CW_USEDEFAULT, the system selects a default width and height for the window; the default width extends from the initial x-coordinates 
		/// to the right edge of the screen; the default height extends from the initial y-coordinate to the top of the icon area. 
		/// <para>
		/// CW_USEDEFAULT is valid only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window, the nWidth and nHeight parameter are set to zero. 
		/// </para>
		/// </param>
		/// <param name="nHeight">
		/// The height, in device units, of the window. For overlapped windows, nHeight is the window's height, in screen coordinates. 
		/// <para>
		/// If the nWidth parameter is set to CW_USEDEFAULT, the system ignores nHeight. 
		/// </para>
		/// </param>
		/// <param name="hWndParent">
		/// A handle to the parent or owner window of the window being created. To create a child window or an owned window, supply a valid window handle. 
		/// <para>
		/// This parameter is optional for pop-up windows.
		/// </para>
		/// <para>
		/// To create a message-only window, supply HWND_MESSAGE or a handle to an existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// A handle to a menu, or specifies a child-window identifier, depending on the window style. For an overlapped or pop-up window, hMenu identifies 
		/// the menu to be used with the window; it can be NULL if the class menu is to be used. 
		/// <para>
		/// For a child window, hMenu specifies the child-window identifier, an integer value used by a dialog box control to notify its parent about events. 
		/// </para>
		/// <para>
		/// The application determines the child-window identifier; it must be unique for all child windows with the same parent window. 
		/// </para>
		/// </param>
		/// <param name="hInstance">
		/// A handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. 
		/// <para>
		/// This message is sent to the created window by this function before it returns.
		/// </para>
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point to a CLIENTCREATESTRUCT structure. 
		/// </para>
		/// <para>
		/// If an MDI client window calls CreateWindow to create an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be NULL 
		/// if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>
		/// This function typically fails for one of the following reasons: 
		/// </para>
		/// <para>• an invalid parameter value</para>
		/// <para>• the system class was registered by a different module</para>
		/// <para>• The WH_CBT hook is installed and returns a failure code</para>
		/// <para>• if one of the controls in the dialog template is not registered, or its window window procedure fails WM_CREATE or WM_NCCREATE</para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CreateWindowEx (   
							WS_EX_Constants			dwExStyle, 
							string				lpClassName,
							string				lpWindowName, 
							WS_Constants			dwStyle, 
							int				x, 
							int				y, 
							int				nWidth, 
							int				nHeight,
							IntPtr				hWndParent, 
							IntPtr				hMenu, 
							IntPtr				hInstance, 
							ref CLIENTCREATESTRUCT		lpParam ) ;
		# endregion


		# region Version with an MDICREATESTRUCT value for lParam
		/// Creates an overlapped, pop-up, or child window with an extended window style; otherwise, this function is identical to the CreateWindow function. 
		/// For more information about creating a window and for full descriptions of the other parameters of CreateWindowEx, see CreateWindow. 
 		/// </summary>
		/// <param name="dwExStyle">
		/// The extended window style of the window being created. For a list of possible values,see Extended Window Styles.
		/// </param>
		/// <param name="lpClassName">
		/// A null-terminated string or a class atom created by a previous call to the RegisterClass or RegisterClassEx function. 
		/// <para>
		/// The atom must be in the low-order word of lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies the window class name. 
		/// </para>
		/// <para>
		/// The class name can be any name registered with RegisterClass or RegisterClassEx, provided that the module that registers the class is also the module 
		/// that creates the window. The class name can also be any of the predefined system class names. 
		/// </para>
		/// </param>
		/// <param name="lpWindowName">
		/// The window name. If the window style specifies a title bar, the window title pointed to by lpWindowName is displayed in the title bar. 
		/// <para>
		/// When using CreateWindow to create controls, such as buttons, check boxes, and static controls, use lpWindowName to specify the text of the control. 
		/// </para>
		/// When creating a static control with the SS_ICON style, use lpWindowName to specify the icon name or identifier. To specify an identifier, use the syntax "#num". 
		/// <para></para>
		/// </param>
		/// <param name="dwStyle">
		/// The style of the window being created. This parameter can be a combination of the window style values. 
		/// </param>
		/// <param name="x">
		/// The initial horizontal position of the window. For an overlapped or pop-up window, the x parameter is the initial x-coordinate of the window's 
		/// upper-left corner, in screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of the window relative to the upper-left 
		/// corner of the parent window's client area. 
		/// <para>
		/// If x is set to CW_USEDEFAULT, the system selects the default position for the window's upper-left corner and ignores the y parameter. 
		/// CW_USEDEFAULT is valid only for overlapped windows; if it is specified for a pop-up or child window, the x and y parameters are set to zero. 
		/// </para>
		/// </param>
		/// <param name="y">
		/// The initial vertical position of the window. For an overlapped or pop-up window, the y parameter is the initial y-coordinate of the window's upper-left corner, 
		/// in screen coordinates. For a child window, y is the initial y-coordinate of the upper-left corner of the child window relative to the upper-left corner 
		/// of the parent window's client area. For a list box y is the initial y-coordinate of the upper-left corner of the list box's client area relative to 
		/// the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter is set to CW_USEDEFAULT, then the y parameter determines how 
		/// the window is shown. If the y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW flag after the window has been created. 
		/// If the y parameter is some other value, then the window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in screen coordinates, or CW_USEDEFAULT. 
		/// If nWidth is CW_USEDEFAULT, the system selects a default width and height for the window; the default width extends from the initial x-coordinates 
		/// to the right edge of the screen; the default height extends from the initial y-coordinate to the top of the icon area. 
		/// <para>
		/// CW_USEDEFAULT is valid only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window, the nWidth and nHeight parameter are set to zero. 
		/// </para>
		/// </param>
		/// <param name="nHeight">
		/// The height, in device units, of the window. For overlapped windows, nHeight is the window's height, in screen coordinates. 
		/// <para>
		/// If the nWidth parameter is set to CW_USEDEFAULT, the system ignores nHeight. 
		/// </para>
		/// </param>
		/// <param name="hWndParent">
		/// A handle to the parent or owner window of the window being created. To create a child window or an owned window, supply a valid window handle. 
		/// <para>
		/// This parameter is optional for pop-up windows.
		/// </para>
		/// <para>
		/// To create a message-only window, supply HWND_MESSAGE or a handle to an existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// A handle to a menu, or specifies a child-window identifier, depending on the window style. For an overlapped or pop-up window, hMenu identifies 
		/// the menu to be used with the window; it can be NULL if the class menu is to be used. 
		/// <para>
		/// For a child window, hMenu specifies the child-window identifier, an integer value used by a dialog box control to notify its parent about events. 
		/// </para>
		/// <para>
		/// The application determines the child-window identifier; it must be unique for all child windows with the same parent window. 
		/// </para>
		/// </param>
		/// <param name="hInstance">
		/// A handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. 
		/// <para>
		/// This message is sent to the created window by this function before it returns.
		/// </para>
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point to a CLIENTCREATESTRUCT structure. 
		/// </para>
		/// <para>
		/// If an MDI client window calls CreateWindow to create an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be NULL 
		/// if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>
		/// This function typically fails for one of the following reasons: 
		/// </para>
		/// <para>• an invalid parameter value</para>
		/// <para>• the system class was registered by a different module</para>
		/// <para>• The WH_CBT hook is installed and returns a failure code</para>
		/// <para>• if one of the controls in the dialog template is not registered, or its window window procedure fails WM_CREATE or WM_NCCREATE</para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CreateWindowEx (   
							WS_EX_Constants			dwExStyle, 
							string				lpClassName,
							string				lpWindowName, 
							WS_Constants			dwStyle, 
							int				x, 
							int				y, 
							int				nWidth, 
							int				nHeight,
							IntPtr				hWndParent, 
							IntPtr				hMenu, 
							IntPtr				hInstance, 
							ref MDICREATESTRUCT		lpParam ) ;
		# endregion
	    }
    }