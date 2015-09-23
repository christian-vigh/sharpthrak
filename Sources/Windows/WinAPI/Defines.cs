/**************************************************************************************************************

    NAME
        WinAPI/Defines.cs

    DESCRIPTION
        Windows defines.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Runtime. InteropServices ;


using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI
   {
	# region Constant defines
	/// <summary>
	/// Windows constants normally defined by a #define directive.
	/// </summary>
	public static class  Defines
	   {
		/// <summary>
		/// AllowSetForegroundWindow : if the process id is ASFW_ANY, then all processes will be allowed to set the foreground window.
		/// </summary>
		public const uint			ASFW_ANY			=  unchecked ( ( uint ) ( -1 ) ) ;

		/// <summary>
		/// Return this value to deny a query in a WM_DEVICECHANGE message.
		/// </summary>
		public const uint			BROADCAST_QUERY_DENY		=  0x424D5144 ;

		/// <summary>
		/// When creating a window, this value can be used to specified a default value for the left, top, height and width values.
		/// </summary>
		public const uint			CW_USEDEFAULT			=  0x80000000 ;

		/// <summary>
		/// Extra window bytes needed by Dialog window class.
		/// </summary>
		public const uint			DLGWINDOWEXTRA			=  48 ;

		/// <summary>
		/// For Windows API functions that fill a String or StringBuilder object, specifies the default size to be used for the output string
		/// if not specified.
		/// </summary>
		public const int			DEFAULT_OUT_STRING_LENGTH	=  1024 ;

		/// <summary>
		/// FALSE boolean value.
		/// </summary>
		public const int			FALSE				=  0 ;

		/// <summary>
		/// When the HWND parameter of the SendMessage function is set to this value, the message is sent to all top-level windows in the system, 
		/// including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// </summary>
		public const int			HWND_BROADCAST			=  0xFFFF ;

		/// <summary>
		/// For CreateWindow, specifies that the parent window will be the desktop window. Used for top-level application windows.
		/// </summary>
		public static readonly IntPtr		HWND_DESKTOP			=  IntPtr. Zero ;

		/// <summary>
		/// For the CreateWindow function, specifies that the window will be a message-only window. This value must be specified for the hWndParent parameter.
		/// A message-only window enables you to send and receive messages. It is not visible, has no z-order, cannot be enumerated, and does not receive broadcast messages. 
		/// The window simply dispatches messages.
		/// <para>
		/// To create a message-only window, specify the HWND_MESSAGE constant or a handle to an existing message-only window in the hWndParent parameter of the 
		/// CreateWindowEx function. You can also change an existing window to a message-only window by specifying HWND_MESSAGE in the hWndNewParent parameter of 
		/// the SetParent function.
		/// </para>
		/// <para>
		/// To find message-only windows, specify HWND_MESSAGE in the hwndParent parameter of the FindWindowEx function. In addition, FindWindowEx searches message-only 
		/// windows as well as top-level windows if both the hwndParent and hwndChildAfter parameters are NULL.
		/// </para>
		/// </summary>
		public static readonly IntPtr		HWND_MESSAGE			=  new IntPtr ( -3 ) ;

		/// <summary>
		/// Special hot key identifier for the WM_HOTKEY message : corresponds to the PrintScreen key.
		/// </summary>
		public const int			IDHOT_SNAPDESKTOP		=  -2 ;

		/// <summary>
		/// Special hot key identifier for the WM_HOTKEY message : corresponds to the Shift-PrintScreen key combination.
		/// </summary>
		public const int			IDHOT_SNAPWINDOW		=  -1 ;

		/// <summary>
		/// Infinite value for timeouts.
		/// </summary>
		public const uint			INFINITE			=  0xFFFFFFFF ;

		/// <summary>
		/// Size of KeyboardLayoutName (number of characters), including nul terminator.
		/// </summary>
		public const int			KL_NAMELENGTH			=  9 ;

		/// <summary>
		/// Max size for a path.
		/// </summary>
		public const int			MAX_PATH			=  260 ;

		/// <summary>
		///  SPI_SETDESKWALLPAPER defined constant for default wallpaper.
		/// </summary>
		public const int			SETWALLPAPER_DEFAULT		=  -1 ;

		/// <summary>
		/// TRUE boolean value.
		/// </summary>
		public const int			TRUE				=  1 ;

		/// <summary>
		/// Possible value of the wParam parameter of the WM_UNICHAR message.
		/// </summary>
		public const int			UNICODE_NOCHAR			=  0xFFFF ;

		/// <summary>
		/// Maximum value for a mouse event timer.
		/// </summary>
		public const int			USER_TIMER_MAXIMUM		=  0x7FFFFFFF ;

		/// <summary>
		/// Minimum value for a mouse event timer.
		/// </summary>
		public const int			USER_TIMER_MINIMUM		=  0x0000000A ;
	    }
	# endregion
    }

