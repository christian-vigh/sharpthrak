/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	# region SPI_ system parameter info actions
	/// <summary>
	/// Values for the uiAction parameter of the SystemParametersInfo.
	/// </summary>
	public enum  SPI_Constants	:  uint
	   {
		/// <summary>
		/// Retrieves information about the time-out period associated with the accessibility features. 
		/// <para>
		/// The pvParam parameter must point to an ACCESSTIMEOUT structure that receives the information. 
		/// </para>
		/// <para>
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(ACCESSTIMEOUT).
		/// </para>
		/// </summary>
		SPI_GETACCESSTIMEOUT       		=  0x003C,

		/// <summary>
		/// Determines whether active window tracking (activating the window the mouse is on) is on or off. 
		/// <para>
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for on, or FALSE for off.
		/// </para>
		/// </summary>
		SPI_GETACTIVEWINDOWTRACKING         	=  0x1000,

		/// <summary>
		/// Retrieves the active window tracking delay, in milliseconds. 
		/// <para>
		/// The pvParam parameter must point to a DWORD variable that receives the time.
		/// </para>
		/// </summary>
		SPI_GETACTIVEWNDTRKTIMEOUT          	=  0x2002,

		/// <summary>
		/// Determines whether windows activated through active window tracking will be brought to the top. 
		/// <para>
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for on, or FALSE for off.
		/// </para>
		/// </summary>
		SPI_GETACTIVEWNDTRKZORDER           	=  0x100C,

		/// <summary>
		/// Retrieves the animation effects associated with user actions. 
		/// <para>
		/// The pvParam parameter must point to an ANIMATIONINFO structure that receives the information. 
		/// </para>
		/// <para>
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(ANIMATIONINFO).
		/// </para>
		/// </summary>
		SPI_GETANIMATION            		=  0x0048,

		/// <summary>
		/// Determines whether audio descriptions are enabled or disabled. 
		/// <para>
		/// The pvParam parameter is a pointer to an AUDIODESCRIPTION structure. 
		/// </para>
		/// <para>
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(AUDIODESCRIPTION). 
		/// </para>
		/// <para>
		/// While it is possible for users who have visual impairments to hear the audio in video content, there is a lot of action in video 
		/// that does not have corresponding audio. Specific audio description of what is happening in a video helps these users understand the content better. 
		/// </para>
		/// <para>
		/// This flag enables you to determine whether audio descriptions have been enabled and in which language.
		/// </para>
		/// </summary>
		/// <remarks>Not supported on Windows Server 2003 and Windows XP/2000.</remarks>
		SPI_GETAUDIODESCRIPTION   		=  0x0074,

		/// <summary>
		/// Determines whether the warning beeper is on. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the beeper is on, or FALSE if it is off.
		/// </summary>
		SPI_GETBEEP                 		=  0x0001,

		/// <summary>
		/// Retrieves a BOOL indicating whether an application can reset the screensaver's timer by calling the SendInput function to simulate 
		/// keyboard or mouse input. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the simulated input will be blocked, or FALSE otherwise.
		/// </summary>
		SPI_GETBLOCKSENDINPUTRESETS         	=  0x1026,

		/// <summary>
		/// Retrieves the border multiplier factor that determines the width of a window's sizing border. 
		/// The pvParam parameter must point to an integer variable that receives this value.
		/// </summary>
		SPI_GETBORDER               		=  0x0005,

		/// <summary>
		/// Retrieves the caret width in edit controls, in pixels. The pvParam parameter must point to a DWORD variable that receives this value.
		/// </summary>
		SPI_GETCARETWIDTH                   	=  0x2006,

		/// <summary>
		/// Determines whether ClearType is enabled. The pvParam parameter must point to a BOOL variable that receives TRUE if ClearType is enabled, or FALSE otherwise.
		/// ClearType is a software technology that improves the readability of text on liquid crystal display (LCD) monitors.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETCLEARTYPE                    	=  0x1048,

		/// <summary>
		/// Determines whether animations are enabled or disabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if animations are enabled, or FALSE otherwise. 
		/// Display features such as flashing, blinking, flickering, and moving content can cause seizures in users with photo-sensitive epilepsy. 
		/// This flag enables you to determine whether such animations have been disabled in the client area.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETCLIENTAREAANIMATION          	=  0x1042,

		/// <summary>
		/// Determines whether the slide-open effect for combo boxes is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for enabled, or FALSE for disabled.
		/// </summary>
		SPI_GETCOMBOBOXANIMATION            	=  0x1004,

		/// <summary>
		/// Determines whether the cursor has a shadow around it. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the shadow is enabled, FALSE if it is disabled. 
		/// This effect appears only if the system has a color depth of more than 256 colors.
		/// </summary>
		SPI_GETCURSORSHADOW                 	=  0x101A,

		/// <summary>
		/// Retrieves the input locale identifier for the system default input language. 
		/// The pvParam parameter must point to an HKL variable that receives this value.
		/// </summary>
		SPI_GETDEFAULTINPUTLANG     		=  0x0059,

		/// <summary>
		/// Retrieves the full path of the bitmap file for the desktop wallpaper. 
		/// The pvParam parameter must point to a buffer to receive the null-terminated path string. 
		/// Set the uiParam parameter to the size, in characters, of the pvParam buffer. 
		/// The returned string will not exceed MAX_PATH characters. If there is no desktop wallpaper, the returned string is empty.
		/// </summary>
		SPI_GETDESKWALLPAPER      		=  0x0073,

		/// <summary>
		/// Determines whether overlapped content is enabled or disabled. The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, 
		/// or FALSE otherwise. 
		/// Display features such as background images, textured backgrounds, water marks on documents, alpha blending, and transparency can reduce the contrast
		/// between the foreground and background, making it harder for users with low vision to see objects on the screen. 
		/// This flag enables you to determine whether such overlapped content has been disabled.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETDISABLEOVERLAPPEDCONTENT     	=  0x1040,

		/// <summary>
		/// Determines whether a window is docked when it is moved to the top, left, or right edges of a monitor or monitor array. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETDOCKMOVING               	=  0x0090,

		/// <summary>
		/// Determines whether a maximized window is restored when its caption bar is dragged. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETDRAGFROMMAXIMIZE         	=  0x008C,

		/// <summary>
		/// Determines whether dragging of full windows is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise.
		/// </summary>
		SPI_GETDRAGFULLWINDOWS      		=  0x0026,

		/// <summary>
		/// Determines whether the drop shadow effect is enabled. 
		/// The pvParam parameter must point to a BOOL variable that returns TRUE if enabled or FALSE if disabled. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETDROPSHADOW                   	=  0x1024,

		/// <summary>
		/// Gets a flag determining whether the Alt-Tab combination is enabled or not.
		/// The pvParam parameter must point to a BOOL variable that returns TRUE if enabled or FALSE if disabled. 
		/// </summary>
		/// <remarks>This parameter is superseded since Windows 95.</remarks>
		SPI_GETFASTTASKSWITCH       		=  0x0023,

		/// <summary>
		/// Retrieves information about the FilterKeys accessibility feature. 
		/// The pvParam parameter must point to a FILTERKEYS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(FILTERKEYS).
		/// </summary>
		SPI_GETFILTERKEYS          		=  0x0032,

		/// <summary>
		/// Determines whether native User menus have flat menu appearance. 
		/// The pvParam parameter must point to a BOOL variable that returns TRUE if the flat menu appearance is set, or FALSE otherwise. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETFLATMENU                     	=  0x1022,

		/// <summary>
		/// Retrieves the height, in pixels, of the top and bottom edges of the focus rectangle drawn with DrawFocusRect. 
		/// The pvParam parameter must point to a UINT value. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETFOCUSBORDERHEIGHT            	=  0x2010,

		/// <summary>
		/// Retrieves the width, in pixels, of the left and right edges of the focus rectangle drawn with DrawFocusRect. 
		/// The pvParam parameter must point to a UINT. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETFOCUSBORDERWIDTH             	=  0x200E,

		/// <summary>
		/// Determines whether the font smoothing feature is enabled. 
		/// This feature uses font antialiasing to make font curves appear smoother by painting pixels at different gray levels. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the feature is enabled, or FALSE if it is not.
		/// </summary>
		SPI_GETFONTSMOOTHING        		=  0x004A,

		/// <summary>
		/// Retrieves a contrast value that is used in ClearType smoothing. 
		/// The pvParam parameter must point to a UINT that receives the information. 
		/// Valid contrast values are from 1000 to 2200. The default value is 1400. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETFONTSMOOTHINGCONTRAST           	=  0x200C,

		/// <summary>
		/// Retrieves the font smoothing orientation. 
		/// The pvParam parameter must point to a UINT that receives the information. 
		/// The possible values are FE_FONTSMOOTHINGORIENTATIONBGR (blue-green-red) and FE_FONTSMOOTHINGORIENTATIONRGB (red-green-blue).
		/// </summary>
		/// <remarks>Windows XP/2000:  This parameter is not supported until Windows XP with SP2.</remarks>
		SPI_GETFONTSMOOTHINGORIENTATION         =  0x2012,

		/// <summary>
		/// Retrieves the type of font smoothing. 
		/// The pvParam parameter must point to a UINT that receives the information. The possible values are FE_FONTSMOOTHINGSTANDARD and FE_FONTSMOOTHINGCLEARTYPE. 
		/// </summary>
		/// <remarks>Windows XP/2000:  This parameter is not supported until Windows XP with SP2.</remarks>
		SPI_GETFONTSMOOTHINGTYPE            	=  0x200A,

		/// <summary>
		/// Retrieves the number of times SetForegroundWindow will flash the taskbar button when rejecting a foreground switch request. 
		/// The pvParam parameter must point to a DWORD variable that receives the value.
		/// </summary>
		SPI_GETFOREGROUNDFLASHCOUNT         	=  0x2004,

		/// <summary>
		/// Retrieves the amount of time following user input, in milliseconds, during which the system will not allow applications 
		/// to force themselves into the foreground. 
		/// The pvParam parameter must point to a DWORD variable that receives the time.
		/// </summary>
		SPI_GETFOREGROUNDLOCKTIMEOUT        	=  0x2000,

		/// <summary>
		/// Determines whether the gradient effect for window title bars is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for enabled, or FALSE for disabled. 
		/// For more information about the gradient effect, see the GetSysColor function.
		/// </summary>
		SPI_GETGRADIENTCAPTIONS             	=  0x1008,

		/// <summary>
		/// Retrieve the current granularity of the desktop sizing grid. 
		/// uiParam must be 0. pvParam is a variable which receives the current setting. 
		/// </summary>
		SPI_GETGRIDGRANULARITY      		=  0x0012,

		/// <summary>
		/// Retrieves information about the HighContrast accessibility feature. 
		/// The pvParam parameter must point to a HIGHCONTRAST structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(HIGHCONTRAST).
		/// </summary>
		SPI_GETHIGHCONTRAST         		=  0x0042,

		/// <summary>
		/// Determines whether hot tracking of user-interface elements, such as menu names on menu bars, is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for enabled, or FALSE for disabled.
		/// Hot tracking means that when the cursor moves over an item, it is highlighted but not selected. 
		/// You can query this value to decide whether to use hot tracking in the user interface of your application.
		/// </summary>
		SPI_GETHOTTRACKING                  	=  0x100E,

		/// <summary>
		/// Retrieves the number of milliseconds that a thread can go without dispatching a message before the system considers it unresponsive. 
		/// The pvParam parameter must point to an integer variable that receives the value.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETHUNGAPPTIMEOUT           	=  0x0078,

		/// <summary>
		/// Retrieves the metrics associated with icons. 
		/// The pvParam parameter must point to an ICONMETRICS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(ICONMETRICS).
		/// </summary>
		/// <remarks>
		/// As of current Thrak version, the SystemParametersInfo() function always return false. It does not seem to be linked with the actual
		/// structure size.
		/// </remarks>
		SPI_GETICONMETRICS          		=  0x002D,

		/// <summary>
		/// Retrieves the logical font information for the current icon-title font. 
		/// The uiParam parameter specifies the size of a LOGFONT structure, and the pvParam parameter must point to the LOGFONT structure to fill in.
		/// </summary>
		SPI_GETICONTITLELOGFONT     		=  0x001F,

		/// <summary>
		/// Determines whether icon-title wrapping is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise.
		/// </summary>
		SPI_GETICONTITLEWRAP        		=  0x0019,

		/// <summary>
		/// Determines whether menu access keys are always underlined. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if menu access keys are always underlined, 
		/// and FALSE if they are underlined only when the menu is activated by the keyboard.
		/// </summary>
		SPI_GETKEYBOARDCUES                 	=  0x100A,

		/// <summary>
		/// Retrieves the keyboard repeat-delay setting, which is a value in the range from 0 (approximately 250 ms delay) through 3 (approximately 1 second delay). 
		/// The actual delay associated with each value may vary depending on the hardware. 
		/// The pvParam parameter must point to an integer variable that receives the setting.
		/// </summary>
		SPI_GETKEYBOARDDELAY        		=  0x0016,

		/// <summary>
		/// Determines whether the user relies on the keyboard instead of the mouse, and wants applications to display keyboard interfaces 
		/// that would otherwise be hidden. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the user relies on the keyboard; or FALSE otherwise.
		/// </summary>
		SPI_GETKEYBOARDPREF         		=  0x0044,

		/// <summary>
		/// Retrieves the keyboard repeat-speed setting, which is a value in the range from 0 (approximately 2.5 repetitions per second) through 31 
		/// (approximately 30 repetitions per second). 
		/// The actual repeat rates are hardware-dependent and may vary from a linear scale by as much as 20%. 
		/// The pvParam parameter must point to a DWORD variable that receives the setting.
		/// </summary>
		SPI_GETKEYBOARDSPEED        		=  0x000A,

		/// <summary>
		/// Determines whether the smooth-scrolling effect for list boxes is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for enabled, or FALSE for disabled.
		/// </summary>
		SPI_GETLISTBOXSMOOTHSCROLLING       	=  0x1006,

		/// <summary>
		/// Determines whether the low-power phase of screen saving is enabled. 
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP/2000:  Determines whether the low-power phase of screen saving is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE if disabled. 
		/// This flag is supported for 32-bit applications only.
		/// </remarks>
		SPI_GETLOWPOWERACTIVE       		=  0x0053,

		/// <summary>
		/// Retrieves the time-out value for the low-power phase of screen saving. 
		/// The pvParam parameter must point to an integer variable that receives the value.
		/// </summary>
		/// <remarks>This flag is supported starting from Windows Server 2003 and Windows XP/2000, for 32-bit applications only.</remarks>
		SPI_GETLOWPOWERTIMEOUT      		=  0x004F,

		/// <summary>
		/// Determines whether the menu animation feature is enabled. This master switch must be on to enable menu animation effects. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if animation is enabled and FALSE if it is disabled. 
		/// If animation is enabled, SPI_GETMENUFADE indicates whether menus use fade or slide animation.
		/// </summary>
		SPI_GETMENUANIMATION                	=  0x1002,

		/// <summary>
		/// Determines whether pop-up menus are left-aligned or right-aligned, relative to the corresponding menu-bar item. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if right-aligned, or FALSE otherwise.
		/// </summary>
		SPI_GETMENUDROPALIGNMENT    		=  0x001B,

		/// <summary>
		/// Determines whether menu fade animation is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE when fade animation is enabled and FALSE when it is disabled. 
		/// If fade animation is disabled, menus use slide animation. 
		/// This flag is ignored unless menu animation is enabled, which you can do using the SPI_SETMENUANIMATION flag. For more information, see AnimateWindow.
		/// </summary>
		SPI_GETMENUFADE                     	=  0x1012,

		/// <summary>
		/// Retrieves the time, in milliseconds, that the system waits before displaying a shortcut menu when the mouse cursor is over a submenu item. 
		/// The pvParam parameter must point to a DWORD variable that receives the time of the delay.
		/// </summary>
		SPI_GETMENUSHOWDELAY       		=  0x006A,

		/// <summary>
		/// Same as SPI_GETKEYBOARDCUES.
		/// </summary>
		SPI_GETMENUUNDERLINES               	=  SPI_GETKEYBOARDCUES,

		/// <summary>
		/// Retrieves the time that notification pop-ups should be displayed, in seconds. 
		/// The pvParam parameter must point to an integer that receives the message duration. 
		/// Users with visual impairments or cognitive conditions such as ADHD and dyslexia might need a longer time to read the text in notification messages. 
		/// This flag enables you to retrieve the message duration.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETMESSAGEDURATION              	=  0x2016,

		/// <summary>
		/// Retrieves the metrics associated with minimized windows. 
		/// The pvParam parameter must point to a MINIMIZEDMETRICS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(MINIMIZEDMETRICS).
		/// </summary>
		SPI_GETMINIMIZEDMETRICS     		=  0x002B,

		/// <summary>
		/// Undocumented.
		/// </summary>
		SPI_GETMINIMUMHITRADIUS             	=  0x2014,

		/// <summary>
		/// Retrieves the two mouse threshold values and the mouse acceleration. 
		/// The pvParam parameter must point to an array of three integers that receives these values. See mouse_event for further information.
		/// </summary>
		SPI_GETMOUSE                		=  0x0003,

		/// <summary>
		/// Retrieves the state of the Mouse ClickLock feature. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise. For more information, see About Mouse Input. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETMOUSECLICKLOCK               	=  0x101E,

		/// <summary>
		/// Retrieves the time delay before the primary mouse button is locked. 
		/// The pvParam parameter must point to DWORD that receives the time delay, in milliseconds. This is only enabled if SPI_SETMOUSECLICKLOCK is set to TRUE. 
		/// For more information, see About Mouse Input. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_GETMOUSECLICKLOCKTIME           	=  0x2008,

		/// <summary>
		/// Retrieves the threshold in pixels where docking behavior is triggered by using a mouse to drag a window to the edge of a monitor or monitor array. 
		/// The default threshold is 1. The pvParam parameter must point to a DWORD variable that receives the value.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
 		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETMOUSEDOCKTHRESHOLD       	=  0x007E,

		/// <summary>
		/// Retrieves the threshold in pixels where undocking behavior is triggered by using a mouse to drag a window from the edge of a monitor 
		/// or a monitor array toward the center. The default threshold is 20.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETMOUSEDRAGOUTTHRESHOLD    	=  0x0084,

		/// <summary>
		/// Retrieves the height, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent to generate a WM_MOUSEHOVER message. 
		/// The pvParam parameter must point to a UINT variable that receives the height.
		/// </summary>
		SPI_GETMOUSEHOVERHEIGHT    		=  0x0064,

		/// <summary>
		/// Retrieves the time, in milliseconds, that the mouse pointer has to stay in the hover rectangle for TrackMouseEvent to generate a WM_MOUSEHOVER message. 
		/// The pvParam parameter must point to a UINT variable that receives the time.
		/// </summary>
		SPI_GETMOUSEHOVERTIME      		=  0x0066,

		/// <summary>
		/// Retrieves the width, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent to generate a WM_MOUSEHOVER message. 
		/// The pvParam parameter must point to a UINT variable that receives the width.
		/// </summary>
		SPI_GETMOUSEHOVERWIDTH     		=  0x0062,

		/// <summary>
		/// Retrieves information about the MouseKeys accessibility feature. 
		/// The pvParam parameter must point to a MOUSEKEYS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(MOUSEKEYS).
		/// </summary>
		SPI_GETMOUSEKEYS           		=  0x0036,

		/// <summary>
		/// Retrieves the threshold in pixels from the top of a monitor or a monitor array where a vertically maximized window is restored when dragged with the mouse. 
		/// The default threshold is 50.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETMOUSESIDEMOVETHRESHOLD   	=  0x0088,

		/// <summary>
		/// Retrieves the state of the Mouse Sonar feature. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled or FALSE otherwise. For more information, see About Mouse Input. 
		/// </summary>
		/// <remarks>Windows 2000 : this parameter is not supported.</remarks>
		SPI_GETMOUSESONAR                   	=  0x101C,

		/// <summary>
		/// Retrieves the current mouse speed. 
		/// The mouse speed determines how far the pointer will move based on the distance the mouse moves. 
		/// The pvParam parameter must point to an integer that receives a value which ranges between 1 (slowest) and 20 (fastest). 
		/// A value of 10 is the default. The value can be set by an end-user using the mouse control panel application or by an application using SPI_SETMOUSESPEED.
		/// </summary>
		SPI_GETMOUSESPEED         		=  0x0070,

		/// <summary>
		/// Determines whether the Mouse Trails feature is enabled. 
		/// This feature improves the visibility of mouse cursor movements by briefly showing a trail of cursors and quickly erasing them. 
		/// The pvParam parameter must point to an integer variable that receives a value. 
		/// If the value is zero or 1, the feature is disabled. If the value is greater than 1, the feature is enabled and the value indicates the number of cursors 
		/// drawn in the trail. The uiParam parameter is not used.
		/// </summary>
		/// <remarks>Windows 2000 : this parameter is not supported.</remarks>
		SPI_GETMOUSETRAILS          		=  0x005E,

		/// <summary>
		/// Retrieves the state of the Mouse Vanish feature. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled or FALSE otherwise. For more information, see About Mouse Input. 
		/// </summary>
		/// <remarks>Windows 2000 : this parameter is not supported.</remarks>
		SPI_GETMOUSEVANISH                  	=  0x1020,

		/// <summary>
		/// Retrieves the metrics associated with the nonclient area of nonminimized windows. 
		/// The pvParam parameter must point to a NONCLIENTMETRICS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(NONCLIENTMETRICS).
		/// </summary>
		SPI_GETNONCLIENTMETRICS     		=  0x0029,

		/// <summary>
		/// Retrieves the threshold in pixels where docking behavior is triggered by using a pen to drag a window to the edge of a monitor or monitor array. 
		/// The default is 30.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETPENDOCKTHRESHOLD         	=  0x0080,

		/// <summary>
		/// Retrieves the threshold in pixels where undocking behavior is triggered by using a pen to drag a window from the edge of a monitor or 
		/// monitor array toward its center. The default threshold is 30.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETPENDRAGOUTTHRESHOLD      	=  0x0086,

		/// <summary>
		/// Retrieves the threshold in pixels from the top of a monitor or monitor array where a vertically maximized window is restored when dragged with the mouse. 
		/// The default threshold is 50.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETPENSIDEMOVETHRESHOLD     	=  0x008A,

		/// <summary>
		/// This parameter is not supported. 
		/// When the power-off phase of screen saving is enabled, the GUID_VIDEO_POWERDOWN_TIMEOUT power setting is greater than zero.
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP/2000:  Determines whether the power-off phase of screen saving is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE if disabled. This flag is supported for 32-bit applications only.
		/// </remarks>
		SPI_GETPOWEROFFACTIVE       		=  0x0054,

		/// <summary>
		/// This parameter is not supported. Instead, check the GUID_VIDEO_POWERDOWN_TIMEOUT power setting.
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP/2000:  Retrieves the time-out value for the power-off phase of screen saving. 
		/// The pvParam parameter must point to an integer variable that receives the value. This flag is supported for 32-bit applications only.
		/// </remarks>
		SPI_GETPOWEROFFTIMEOUT      		=  0x0050,

		/// <summary>
		/// Determines whether a screen reviewer utility is running. 
		/// A screen reviewer utility directs textual information to an output device, such as a speech synthesizer or Braille display. 
		/// When this flag is set, an application should provide textual information in situations where it would otherwise present the information graphically. 
		/// The pvParam parameter is a pointer to a BOOL variable that receives TRUE if a screen reviewer utility is running, or FALSE otherwise.
		/// </summary>
		SPI_GETSCREENREADER         		=  0x0046,

		/// <summary>
		/// Determines whether screen saving is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if screen saving is enabled, or FALSE otherwise.
		/// </summary>
		/// <remarks>
		/// Windows 7, Windows Server 2008 R2, and Windows 2000:  The function returns TRUE even when screen saving is not enabled. 
		/// For more information and a workaround, see KB318781.
		/// </remarks>
		SPI_GETSCREENSAVEACTIVE     		=  0x0010,

		/// <summary>
		/// Determines whether a screen saver is currently running on the window station of the calling process. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if a screen saver is currently running, or FALSE otherwise. 
		/// Note that only the interactive window station, WinSta0, can have a screen saver running.
		/// </summary>
		SPI_GETSCREENSAVERRUNNING 		=  0x0072,

		/// <summary>
		/// Determines whether the screen saver requires a password to display the Windows desktop. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the screen saver requires a password, or FALSE otherwise. 
		/// The uiParam parameter is ignored.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETSCREENSAVESECURE   		=  0x0076,

		/// <summary>
		/// Retrieves the screen saver time-out value, in seconds. 
		/// The pvParam parameter must point to an integer variable that receives the value.
		/// </summary>
		SPI_GETSCREENSAVETIMEOUT    		=  0x000E,

		/// <summary>
		/// Determines whether the selection fade effect is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled or FALSE if disabled. 
		/// The selection fade effect causes the menu item selected by the user to remain on the screen briefly while fading out after the menu is dismissed.
		/// </summary>
		SPI_GETSELECTIONFADE                	=  0x1014,

		/// <summary>
		/// This parameter is not supported.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  The user should control this setting through the Control Panel.</remarks>
		SPI_GETSERIALKEYS          		=  0x003E,

		/// <summary>
		/// Determines whether the IME status window is visible (on a per-user basis). 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the status window is visible, or FALSE if it is not.
		/// </summary>
		SPI_GETSHOWIMEUI          		=  0x006E,

		/// <summary>
		/// Determines whether the Show Sounds accessibility flag is on or off. 
		/// If it is on, the user requires an application to present information visually in situations where it would otherwise present 
		/// the information only in audible form. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the feature is on, or FALSE if it is off. 
		/// Using this value is equivalent to calling GetSystemMetrics with SM_SHOWSOUNDS. That is the recommended call.
		/// </summary>
		SPI_GETSHOWSOUNDS          		=  0x0038,

		/// <summary>
		/// Determines whether a window is vertically maximized when it is sized to the top or bottom of a monitor or monitor array. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise.
		/// Use SPI_GETWINARRANGING to determine whether this behavior is enabled.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETSNAPSIZING               	=  0x008E,

		/// <summary>
		/// Determines whether the snap-to-default-button feature is enabled. 
		/// If enabled, the mouse cursor automatically moves to the default button, such as OK or Apply, of a dialog box. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the feature is on, or FALSE if it is off.
		/// </summary>
		SPI_GETSNAPTODEFBUTTON     		=  0x005F,

		/// <summary>
		/// Retrieves information about the SoundSentry accessibility feature. 
		/// The pvParam parameter must point to a SOUNDSENTRY structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(SOUNDSENTRY).
		/// </summary>
		SPI_GETSOUNDSENTRY         		=  0x0040,

		/// <summary>
		/// Determines whether speech recognition is on or off.
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if the feature is on, or FALSE if it is off. 
		/// </summary>
		SPI_GETSPEECHRECOGNITION            	=  0x104A,

		/// <summary>
		/// Retrieves information about the StickyKeys accessibility feature. 
		/// The pvParam parameter must point to a STICKYKEYS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(STICKYKEYS).
		/// </summary>
		SPI_GETSTICKYKEYS          		=  0x003A,

		/// <summary>
		/// Retrieves information about the ToggleKeys accessibility feature. 
		/// The pvParam parameter must point to a TOGGLEKEYS structure that receives the information. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(TOGGLEKEYS).
		/// </summary>
		SPI_GETTOGGLEKEYS          		=  0x0034,

		/// <summary>
		/// Determines whether ToolTip animation is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled or FALSE if disabled. 
		/// If ToolTip animation is enabled, SPI_GETTOOLTIPFADE indicates whether ToolTips use fade or slide animation.
		/// </summary>
		SPI_GETTOOLTIPANIMATION             	=  0x1016,

		/// <summary>
		/// If SPI_SETTOOLTIPANIMATION is enabled, SPI_GETTOOLTIPFADE indicates whether ToolTip animation uses a fade effect or a slide effect. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE for fade animation or FALSE for slide animation. 
		/// For more information on slide and fade effects, see AnimateWindow.
		/// </summary>
		SPI_GETTOOLTIPFADE                  	=  0x1018,

		/// <summary>
		/// Determines whether UI effects are enabled or disabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if all UI effects are enabled, or FALSE if they are disabled.
		/// </summary>
		SPI_GETUIEFFECTS                    	=  0x103E,

		/// <summary>
		/// Retrieves the number of milliseconds that the service control manager waits before terminating a service that does not respond to a shutdown request. 
		/// The pvParam parameter must point to an integer variable that receives the value.
 		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETWAITTOKILLSERVICETIMEOUT 	=  0x007C,

		/// <summary>
		/// Retrieves the number of milliseconds that a thread can go without dispatching a message before the system considers it unresponsive. 
		/// The pvParam parameter must point to an integer variable that receives the value.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_GETWAITTOKILLTIMEOUT        	=  0x007A,

		/// <summary>
		/// Retrieves the number of characters to scroll when the horizontal mouse wheel is moved. 
		/// The pvParam parameter must point to a UINT variable that receives the number of lines. The default value is 3.
		/// </summary>
		SPI_GETWHEELSCROLLCHARS   		=  0x006C,

		/// <summary>
		/// Retrieves the number of lines to scroll when the vertical mouse wheel is moved. 
		/// The pvParam parameter must point to a UINT variable that receives the number of lines. The default value is 3.
		/// </summary>
		SPI_GETWHEELSCROLLLINES    		=  0x0068,

		/// <summary>
		/// Determines whether window arrangement is enabled. The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE otherwise.
		/// Window arrangement reduces the number of mouse, pen, or touch interactions needed to move and size top-level windows by simplifying the default behavior 
		/// of a window when it is dragged or sized. 
		/// The following parameters retrieve individual window arrangement settings :
		///	SPI_GETDOCKMOVING
		///	SPI_GETMOUSEDOCKTHRESHOLD
		///	SPI_GETMOUSEDRAGOUTTHRESHOLD 
		///	SPI_GETMOUSESIDEMOVETHRESHOLD 
		///	SPI_GETPENDOCKTHRESHOLD 
		///	SPI_GETPENDRAGOUTTHRESHOLD 
		///	SPI_GETPENSIDEMOVETHRESHOLD 
		///	SPI_GETSNAPSIZING
		/// </summary>
		SPI_GETWINARRANGING             	=  0x0082,

		/// <summary>
		/// Indicates if Microsoft Plus! is installed.
		/// </summary>
		/// <remarks>This parameter is no longer supported.</remarks>
		SPI_GETWINDOWSEXTENSION     		=  0x005C,

		/// <summary>
		/// Retrieves the size of the work area on the primary display monitor. 
		/// The work area is the portion of the screen not obscured by the system taskbar or by application desktop toolbars. 
		/// The pvParam parameter must point to a RECT structure that receives the coordinates of the work area, expressed in virtual screen coordinates. 
		/// To get the work area of a monitor other than the primary display monitor, call the GetMonitorInfo function.
		/// </summary>
		SPI_GETWORKAREA             		=  0x0030,

		/// <summary>
		/// Sets or retrieves the width, in pixels, of an icon cell. The system uses this rectangle to arrange icons in large icon view.
		/// To set this value, set uiParam to the new value and set pvParam to NULL. You cannot set this value to less than SM_CXICON.
		/// To retrieve this value, pvParam must point to an integer that receives the current value.
		/// </summary>
		SPI_ICONHORIZONTALSPACING   		=  0x000D,

		/// <summary>
		/// Sets or retrieves the height, in pixels, of an icon cell. 
		/// To set this value, set uiParam to the new value and set pvParam to NULL. You cannot set this value to less than SM_CYICON.
		/// To retrieve this value, pvParam must point to an integer that receives the current value.
		/// </summary>
		SPI_ICONVERTICALSPACING     		=  0x0018,

		/// <summary>
		/// Sets the time-out period associated with the accessibility features. 
		/// The pvParam parameter must point to an ACCESSTIMEOUT structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(ACCESSTIMEOUT).
		/// </summary>
		SPI_SETACCESSTIMEOUT       		=  0x003D,

		/// <summary>
		/// Sets active window tracking (activating the window the mouse is on) either on or off. Set pvParam to TRUE for on or FALSE for off.
		/// </summary>
		SPI_SETACTIVEWINDOWTRACKING         	=  0x1001,

		/// <summary>
		/// Sets the active window tracking delay. Set pvParam to the number of milliseconds to delay before activating the window under the mouse pointer.
		/// </summary>
		SPI_SETACTIVEWNDTRKTIMEOUT          	=  0x2003,

		/// <summary>
		/// Determines whether or not windows activated through active window tracking should be brought to the top. Set pvParam to TRUE for on or FALSE for off.
		/// </summary>
		SPI_SETACTIVEWNDTRKZORDER           	=  0x100D,

		/// <summary>
		/// Sets the animation effects associated with user actions. 
		/// The pvParam parameter must point to an ANIMATIONINFO structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(ANIMATIONINFO).
		/// </summary>
		SPI_SETANIMATION            		=  0x0049,

		/// <summary>
		/// Turns the audio descriptions feature on or off. The pvParam parameter is a pointer to an AUDIODESCRIPTION structure. 
		/// While it is possible for users who are visually impaired to hear the audio in video content, there is a lot of action in video 
		/// that does not have corresponding audio. Specific audio description of what is happening in a video helps these users understand the content better. 
		/// This flag enables you to enable or disable audio descriptions in the languages they are provided in.
		/// </summary>
		/// <remarks>Not supported on Windows Server 2003 and Windows XP/2000.</remarks>
		SPI_SETAUDIODESCRIPTION   		=  0x0075,

		/// <summary>
		/// Turns the warning beeper on or off. The uiParam parameter specifies TRUE for on, or FALSE for off.
		/// </summary>
		SPI_SETBEEP                 		=  0x0002,

		/// <summary>
		/// Determines whether an application can reset the screensaver's timer by calling the SendInput function to simulate 
		/// keyboard or mouse input. 
		/// The uiParam parameter specifies TRUE if the screensaver will not be deactivated by simulated input, or FALSE if the screensaver 
		/// will be deactivated by simulated input.
		/// </summary>
		SPI_SETBLOCKSENDINPUTRESETS         	=  0x1027,

		/// <summary>
		/// Sets the border multiplier factor that determines the width of a window's sizing border. The uiParam parameter specifies the new value.
		/// </summary>
		SPI_SETBORDER               		=  0x0006,

		/// <summary>
		/// Sets the caret width in edit controls. Set pvParam to the desired width, in pixels. The default and minimum value is 1.
		/// </summary>
		SPI_SETCARETWIDTH                   	=  0x2007,

		/// <summary>
		/// Turns ClearType on or off. The pvParam parameter is a BOOL variable. Set pvParam to TRUE to enable ClearType, or FALSE to disable it. 
		/// ClearType is a software technology that improves the readability of text on LCD monitors.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETCLEARTYPE                    	=  0x1049,

		/// <summary>
		/// Turns client area animations on or off. The pvParam parameter is a BOOL variable. 
		/// Set pvParam to TRUE to enable animations and other transient effects in the client area, or FALSE to disable them. 
		/// Display features such as flashing, blinking, flickering, and moving content can cause seizures in users with photo-sensitive epilepsy. 
		/// This flag enables you to enable or disable all such animations.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETCLIENTAREAANIMATION          	=  0x1043,

		/// <summary>
		/// Enables or disables the slide-open effect for combo boxes. Set the pvParam parameter to TRUE to enable the gradient effect, or FALSE to disable it.
		/// </summary>
		SPI_SETCOMBOBOXANIMATION            	=  0x1005,

		/// <summary>
		/// Reloads the system cursors. Set the uiParam parameter to zero and the pvParam parameter to NULL.
		/// </summary>
		SPI_SETCURSORS              		=  0x0057,

		/// <summary>
		/// Enables or disables a shadow around the cursor. 
		/// The pvParam parameter is a BOOL variable. Set pvParam to TRUE to enable the shadow or FALSE to disable the shadow. 
		/// This effect appears only if the system has a color depth of more than 256 colors.
		/// </summary>
		SPI_SETCURSORSHADOW                 	=  0x101B,
		
		/// <summary>
		/// Sets the default input language for the system shell and applications. 
		/// The specified language must be displayable using the current system character set. 
		/// The pvParam parameter must point to an HKL variable that contains the input locale identifier for the default language. 
		/// </summary>
		SPI_SETDEFAULTINPUTLANG     		=  0x005A,

		/// <summary>
		/// Sets the current desktop pattern by causing Windows to read the Pattern= setting from the WIN.INI file.
		/// </summary>
		SPI_SETDESKPATTERN          		=  0x0015,

		/// <summary>
		/// When the SPI_SETDESKWALLPAPER flag is used, SystemParametersInfo always returns TRUE.
		/// </summary>
		SPI_SETDESKWALLPAPER        		=  0x0014,

		/// <summary>
		/// Turns overlapped content (such as background images and watermarks) on or off. 
		/// The pvParam parameter is a BOOL variable. Set pvParam to TRUE to disable overlapped content, or FALSE to enable overlapped content. 
		/// Display features such as background images, textured backgrounds, water marks on documents, alpha blending, and transparency can reduce 
		/// the contrast between the foreground and background, making it harder for users with low vision to see objects on the screen. 
		/// This flag enables you to enable or disable all such overlapped content.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETDISABLEOVERLAPPEDCONTENT     	=  0x1041,

		/// <summary>
		/// Sets whether a window is docked when it is moved to the top, left, or right docking targets on a monitor or monitor array. 
		/// Set pvParam to TRUE for on or FALSE for off.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETDOCKMOVING               	=  0x0091,

		/// <summary>
		/// Sets the double-click time for the mouse to the value of the uiParam parameter. 
		/// If the uiParam value is greater than 5000 milliseconds, the system sets the double-click time to 5000 milliseconds.
		/// The double-click time is the maximum number of milliseconds that can occur between the first and second clicks of a double-click. 
		/// You can also call the SetDoubleClickTime function to set the double-click time. To get the current double-click time, call the GetDoubleClickTime function.
		/// </summary>
		SPI_SETDOUBLECLICKTIME      		=  0x0020,

		/// <summary>
		/// Sets the height of the double-click rectangle to the value of the uiParam parameter.
		/// The double-click rectangle is the rectangle within which the second click of a double-click must fall for it to be registered as a double-click.
		/// To retrieve the height of the double-click rectangle, call GetSystemMetrics with the SM_CYDOUBLECLK flag.
		/// </summary>
		SPI_SETDOUBLECLKHEIGHT      		=  0x001E,

		/// <summary>
		/// Sets the width of the double-click rectangle to the value of the uiParam parameter. 
		/// The double-click rectangle is the rectangle within which the second click of a double-click must fall for it to be registered as a double-click.
		/// To retrieve the width of the double-click rectangle, call GetSystemMetrics with the SM_CXDOUBLECLK flag.
		/// </summary>
		SPI_SETDOUBLECLKWIDTH       		=  0x001D,

		/// <summary>
		/// Sets whether a maximized window is restored when its caption bar is dragged. Set pvParam to TRUE for on or FALSE for off.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETDRAGFROMMAXIMIZE         	=  0x008D,

		/// <summary>
		/// Sets dragging of full windows either on or off. The uiParam parameter specifies TRUE for on, or FALSE for off.
		/// </summary>
		SPI_SETDRAGFULLWINDOWS      		=  0x0025,

		/// <summary>
		/// Sets the height, in pixels, of the rectangle used to detect the start of a drag operation. 
		/// Set uiParam to the new value. 
		/// To retrieve the drag height, call GetSystemMetrics with the SM_CYDRAG flag.
		/// </summary>
		SPI_SETDRAGHEIGHT           		=  0x004D,

		/// <summary>
		/// Sets the width, in pixels, of the rectangle used to detect the start of a drag operation. 
		/// Set uiParam to the new value. 
		/// To retrieve the drag width, call GetSystemMetrics with the SM_CXDRAG flag.
		/// </summary>
		SPI_SETDRAGWIDTH            		=  0x004C,

		/// <summary>
		/// Enables or disables the drop shadow effect. 
		/// Set pvParam to TRUE to enable the drop shadow effect or FALSE to disable it. 
		/// You must also have CS_DROPSHADOW in the window class style. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETDROPSHADOW                   	=  0x1025,

		/// <summary>
		/// Sets the flag that determine whether the Alt+Tab combination is active for switching between windows.
		/// </summary>
		/// <remarks>This parameter is superseded since Windows 95.</remarks>
		SPI_SETFASTTASKSWITCH       		=  0x0024,

		/// <summary>
		/// Sets the parameters of the FilterKeys accessibility feature. 
		/// The pvParam parameter must point to a FILTERKEYS structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(FILTERKEYS).
		/// </summary>
		SPI_SETFILTERKEYS          		=  0x0033,

		/// <summary>
		/// Enables or disables flat menu appearance for native User menus. 
		/// Set pvParam to TRUE to enable flat menu appearance or FALSE to disable it. 
		/// When enabled, the menu bar uses COLOR_MENUBAR for the menubar background, COLOR_MENU for the menu-popup background, 
		/// COLOR_MENUHILIGHT for the fill of the current menu selection, and COLOR_HILIGHT for the outline of the current menu selection. 
		/// If disabled, menus are drawn using the same metrics and colors as in Windows 2000.
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETFLATMENU                     	=  0x1023,

		/// <summary>
		/// Sets the height of the top and bottom edges of the focus rectangle drawn with DrawFocusRect to the value of the pvParam parameter. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETFOCUSBORDERHEIGHT            	=  0x2011,

		/// <summary>
		/// Sets the height of the left and right edges of the focus rectangle drawn with DrawFocusRect to the value of the pvParam parameter.
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETFOCUSBORDERWIDTH             	=  0x200F,

		/// <summary>
		/// Enables or disables the font smoothing feature, which uses font antialiasing to make font curves appear smoother by painting pixels at different gray levels. 
		/// To enable the feature, set the uiParam parameter to TRUE. To disable the feature, set uiParam to FALSE.
		/// </summary>
		SPI_SETFONTSMOOTHING        		=  0x004B,

		/// <summary>
		/// Sets the contrast value used in ClearType smoothing. 
		/// The pvParam parameter is the contrast value. Valid contrast values are from 1000 to 2200. The default value is 1400. 
		/// SPI_SETFONTSMOOTHINGTYPE must also be set to FE_FONTSMOOTHINGCLEARTYPE.
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETFONTSMOOTHINGCONTRAST           	=  0x200D,

		/// <summary>
		/// Sets the font smoothing orientation. 
		/// The pvParam parameter is either FE_FONTSMOOTHINGORIENTATIONBGR (blue-green-red) or FE_FONTSMOOTHINGORIENTATIONRGB (red-green-blue). 
		/// </summary>
		/// <remarks>Windows XP/2000:  This parameter is not supported until Windows XP with SP2.</remarks>
		SPI_SETFONTSMOOTHINGORIENTATION         =  0x2013,

		/// <summary>
		/// Sets the font smoothing type. 
		/// The pvParam parameter is either FE_FONTSMOOTHINGSTANDARD, if standard anti-aliasing is used, or FE_FONTSMOOTHINGCLEARTYPE, if ClearType is used. 
		/// The default is FE_FONTSMOOTHINGSTANDARD. SPI_SETFONTSMOOTHING must also be set.
		/// </summary>
		/// <remarks>Windows XP/2000:  This parameter is not supported until Windows XP with SP2.</remarks>
		SPI_SETFONTSMOOTHINGTYPE            	=  0x200B,

		/// <summary>
		/// Sets the number of times SetForegroundWindow will flash the taskbar button when rejecting a foreground switch request. 
		/// Set pvParam to the number of times to flash.
		/// </summary>
		SPI_SETFOREGROUNDFLASHCOUNT         	=  0x2005,

		/// <summary>
		/// Sets the amount of time following user input, in milliseconds, during which the system does not allow applications 
		/// to force themselves into the foreground. Set pvParam to the new time-out value.
		/// The calling thread must be able to change the foreground window, otherwise the call fails.
		/// </summary>
		SPI_SETFOREGROUNDLOCKTIMEOUT        	=  0x2001,

		/// <summary>
		/// Enables or disables the gradient effect for window title bars. 
		/// Set the pvParam parameter to TRUE to enable it, or FALSE to disable it. 
		/// The gradient effect is possible only if the system has a color depth of more than 256 colors. 
		/// For more information about the gradient effect, see the GetSysColor function.
		/// </summary>
		SPI_SETGRADIENTCAPTIONS             	=  0x1009,

		/// <summary>
		/// Set the granularity of the desktop sizing grid. uiParam is the new setting. pvParam must be 0.
		/// </summary>
		SPI_SETGRIDGRANULARITY      		=  0x0013,


		SPI_SETHANDHELD             		=  0x004E,

		/// <summary>
		/// Sets the parameters of the HighContrast accessibility feature. 
		/// The pvParam parameter must point to a HIGHCONTRAST structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(HIGHCONTRAST).
		/// </summary>
		SPI_SETHIGHCONTRAST         		=  0x0043,

		/// <summary>
		/// Enables or disables hot tracking of user-interface elements such as menu names on menu bars. 
		/// Set the pvParam parameter to TRUE to enable it, or FALSE to disable it. 
		/// Hot-tracking means that when the cursor moves over an item, it is highlighted but not selected.
		/// </summary>
		SPI_SETHOTTRACKING                  	=  0x100F,

		/// <summary>
		/// Sets the hung application time-out to the value of the uiParam parameter. 
		/// This value is the number of milliseconds that a thread can go without dispatching a message before the system considers it unresponsive.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETHUNGAPPTIMEOUT           	=  0x0079,

		/// <summary>
		/// Sets the metrics associated with icons. 
		/// The pvParam parameter must point to an ICONMETRICS structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(ICONMETRICS).
		/// </summary>
		SPI_SETICONMETRICS          		=  0x002E,

		/// <summary>
		/// Reloads the system icons. Set the uiParam parameter to zero and the pvParam parameter to NULL.
		/// </summary>
		SPI_SETICONS                		=  0x0058,

		/// <summary>
		/// Sets the font that is used for icon titles. 
		/// The uiParam parameter specifies the size of a LOGFONT structure, and the pvParam parameter must point to a LOGFONT structure.
		/// </summary>
		SPI_SETICONTITLELOGFONT     		=  0x0022,

		/// <summary>
		/// Turns icon-title wrapping on or off. The uiParam parameter specifies TRUE for on, or FALSE for off.
		/// </summary>
		SPI_SETICONTITLEWRAP        		=  0x001A,

		/// <summary>
		/// Sets the underlining of menu access key letters. 
		/// The pvParam parameter is a BOOL variable. Set pvParam to TRUE to always underline menu access keys, 
		/// or FALSE to underline menu access keys only when the menu is activated from the keyboard.
		/// </summary>
		SPI_SETKEYBOARDCUES                 	=  0x100B,

		/// <summary>
		/// Sets the keyboard repeat-delay setting. The uiParam parameter must specify 0, 1, 2, or 3, where zero sets the shortest delay approximately 250 ms) 
		/// and 3 sets the longest delay (approximately 1 second). 
		/// The actual delay associated with each value may vary depending on the hardware.
		/// </summary>
		SPI_SETKEYBOARDDELAY        		=  0x0017,

		/// <summary>
		/// Sets the keyboard preference. 
		/// The uiParam parameter specifies TRUE if the user relies on the keyboard instead of the mouse, and wants applications to display keyboard interfaces 
		/// that would otherwise be hidden; uiParam is FALSE otherwise.
		/// </summary>
		SPI_SETKEYBOARDPREF         		=  0x0045,

		/// <summary>
		/// Sets the keyboard repeat-speed setting. 
		/// The uiParam parameter must specify a value in the range from 0 (approximately 2.5 repetitions per second) through 31 
		/// (approximately 30 repetitions per second). 
		/// The actual repeat rates are hardware-dependent and may vary from a linear scale by as much as 20%. 
		/// If uiParam is greater than 31, the parameter is set to 31.
		/// </summary>
		SPI_SETKEYBOARDSPEED        		=  0x000B,

		/// <summary>
		/// Sets the hot key set for switching between input languages. 
		/// The uiParam and pvParam parameters are not used. 
		/// The value sets the shortcut keys in the keyboard property sheets by reading the registry again. 
		/// The registry must be set before this flag is used. The path in the registry is :
		///
		///	HKEY_CURRENT_USER\Keyboard Layout\Toggle
		///	
		/// Valid values are "1" = ALT+SHIFT, "2" = CTRL+SHIFT, and "3" = none. 
		/// </summary>
		SPI_SETLANGTOGGLE           		=  0x005B,

		/// <summary>
		/// Enables or disables the smooth-scrolling effect for list boxes. 
		/// Set the pvParam parameter to TRUE to enable the smooth-scrolling effect, or FALSE to disable it.
		/// </summary>
		SPI_SETLISTBOXSMOOTHSCROLLING       	=  0x1007,

		/// <summary>
		/// Activates or deactivates the low-power phase of screen saving. 
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP/2000:  Activates or deactivates the low-power phase of screen saving. 
		/// Set uiParam to 1 to activate, or zero to deactivate. 
		/// The pvParam parameter must be NULL. This flag is supported for 32-bit applications only.
		/// </remarks>
		SPI_SETLOWPOWERACTIVE       		=  0x0055,

		/// <summary>
		///  Sets the time-out value, in seconds, for the low-power phase of screen saving. 
		///  The uiParam parameter specifies the new value. The pvParam parameter must be NULL. 
		/// </summary>
		/// <remarks>This flag is supported starting from Windows Server 2003 and Windows XP/2000, for 32-bit applications only.</remarks>
		SPI_SETLOWPOWERTIMEOUT      		=  0x0051,

		/// <summary>
		/// Enables or disables menu animation. This master switch must be on for any menu animation to occur. 
		/// The pvParam parameter is a BOOL variable; set pvParam to TRUE to enable animation and FALSE to disable animation. 
		/// If animation is enabled, SPI_GETMENUFADE indicates whether menus use fade or slide animation.
		/// </summary>
		SPI_SETMENUANIMATION                	=  0x1003,

		/// <summary>
		/// Sets the alignment value of pop-up menus. 
		/// The uiParam parameter specifies TRUE for right alignment, or FALSE for left alignment.
		/// </summary>
		SPI_SETMENUDROPALIGNMENT    		=  0x001C,

		/// <summary>
		/// Enables or disables menu fade animation. Set pvParam to TRUE to enable the menu fade effect or FALSE to disable it. 
		/// If fade animation is disabled, menus use slide animation. 
		/// The menu fade effect is possible only if the system has a color depth of more than 256 colors. 
		/// This flag is ignored unless SPI_MENUANIMATION is also set. For more information, see AnimateWindow
		/// </summary>
		SPI_SETMENUFADE                     	=  0x1013,

		/// <summary>
		/// Sets uiParam to the time, in milliseconds, that the system waits before displaying a shortcut menu when the mouse cursor is over a submenu item.
		/// </summary>
		SPI_SETMENUSHOWDELAY       		=  0x006B,

		/// <summary>
		/// Same as SPI_SETKEYBOARDCUES.
		/// </summary>
		SPI_SETMENUUNDERLINES               	=  SPI_SETKEYBOARDCUES,

		/// <summary>
		/// Sets the time that notification pop-ups should be displayed, in seconds. 
		/// The pvParam parameter specifies the message duration. 
		/// Users with visual impairments or cognitive conditions such as ADHD and dyslexia might need a longer time to read the text in notification messages. 
		/// This flag enables you to set the message duration.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETMESSAGEDURATION              	=  0x2017,

		/// <summary>
		/// Sets the metrics associated with minimized windows. 
		/// The pvParam parameter must point to a MINIMIZEDMETRICS structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(MINIMIZEDMETRICS).
		/// </summary>
		SPI_SETMINIMIZEDMETRICS     		=  0x002C,

		/// <summary>
		/// Undocumented.
		/// </summary>
		SPI_SETMINIMUMHITRADIUS             	=  0x2015,

		/// <summary>
		/// Sets the two mouse threshold values and the mouse acceleration. 
		/// The pvParam parameter must point to an array of three integers that specifies these values. See mouse_event for further information.
		/// </summary>
		SPI_SETMOUSE                		=  0x0004,

		/// <summary>
		/// Swaps or restores the meaning of the left and right mouse buttons. 
		/// The uiParam parameter specifies TRUE to swap the meanings of the buttons, or FALSE to restore their original meanings. 
		/// To retrieve the current setting, call GetSystemMetrics with the SM_SWAPBUTTON flag.
		/// </summary>
		SPI_SETMOUSEBUTTONSWAP      		=  0x0021,

		/// <summary>
		/// Turns the Mouse ClickLock accessibility feature on or off. 
		/// This feature temporarily locks down the primary mouse button when that button is clicked and held down for the time specified by SPI_SETMOUSECLICKLOCKTIME. 
		/// The pvParam parameter specifies TRUE for on, or FALSE for off. The default is off. For more information, see AboutMouse Input. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETMOUSECLICKLOCK               	=  0x101F,

		/// <summary>
		/// Turns the Mouse ClickLock accessibility feature on or off. 
		/// This feature temporarily locks down the primary mouse button when that button is clicked and held down for the time specified by SPI_SETMOUSECLICKLOCKTIME. 
		/// The pvParam parameter specifies TRUE for on, or FALSE for off. The default is off. For more information, see Remarks and AboutMouse Input. 
		/// </summary>
		/// <remarks>Windows 2000:  This parameter is not supported.</remarks>
		SPI_SETMOUSECLICKLOCKTIME           	=  0x2009,

		/// <summary>
		/// Sets the threshold in pixels where docking behavior is triggered by using a mouse to drag a window to the edge of a monitor or monitor array. 
		/// The default threshold is 1. The pvParam parameter must point to a DWORD variable that contains the new value.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETMOUSEDOCKTHRESHOLD       	=  0x007F,

		/// <summary>
		/// Sets the threshold in pixels where undocking behavior is triggered by using a mouse to drag a window from the edge of a monitor 
		/// or monitor array to its center. The default threshold is 20. The pvParam parameter must point to a DWORD variable that contains the new value.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETMOUSEDRAGOUTTHRESHOLD    	=  0x0085,

		/// <summary>
		/// Sets the height, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent to generate a WM_MOUSEHOVER message. 
		/// Set the uiParam parameter to the new height.
		/// </summary>
		SPI_SETMOUSEHOVERHEIGHT    		=  0x0065,

		/// <summary>
		/// Sets the time, in milliseconds, that the mouse pointer has to stay in the hover rectangle for TrackMouseEvent to generate a WM_MOUSEHOVER message. 
		/// This is used only if you pass HOVER_DEFAULT in the dwHoverTime parameter in the call to TrackMouseEvent. Set the uiParamparameter to the new time. 
		/// The time specified should be between USER_TIMER_MAXIMUM and USER_TIMER_MINIMUM. If uiParam is less than USER_TIMER_MINIMUM, the function will use 
		/// USER_TIMER_MINIMUM. If uiParam is greater than USER_TIMER_MAXIMUM, the function will be USER_TIMER_MAXIMUM. 
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP:  The operating system does not enforce the use of USER_TIMER_MAXIMUM and USER_TIMER_MINIMUM 
		/// until Windows Server 2003 with SP1 and Windows XP with SP2.
		///</remarks>
		SPI_SETMOUSEHOVERTIME      		=  0x0067,

		/// <summary>
		/// Sets the width, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent to generate a WM_MOUSEHOVER message. 
		/// Set the uiParam parameter to the new width.
		/// </summary>
		SPI_SETMOUSEHOVERWIDTH     		=  0x0063,

		/// <summary>
		/// Sets the parameters of the MouseKeys accessibility feature. 
		/// The pvParam parameter must point to a MOUSEKEYS structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(MOUSEKEYS).
		/// </summary>
		SPI_SETMOUSEKEYS           		=  0x0037,

		/// <summary>
		/// Sets the threshold in pixels from the top of the monitor where a vertically maximized window is restored when dragged with the mouse. 
		/// The default threshold is 50. The pvParam parameter must point to a DWORD variable that contains the new value.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETMOUSESIDEMOVETHRESHOLD   	=  0x0089,

		/// <summary>
		/// Turns the Sonar accessibility feature on or off. This feature briefly shows several concentric circles around the mouse pointer when the user 
		/// presses and releases the CTRL key. 
		/// The pvParam parameter specifies TRUE for on and FALSE for off. The default is off. For more information, see About Mouse Input. 
		/// </summary>
		/// <remarks>Windows 2000 : this parameter is not supported.</remarks>
		SPI_SETMOUSESONAR                   	=  0x101D,

		/// <summary>
		/// Sets the current mouse speed. The pvParam parameter is an integer between 1 (slowest) and 20 (fastest). 
		/// A value of 10 is the default. This value is typically set using the mouse control panel application.
		/// </summary>
		SPI_SETMOUSESPEED         		=  0x0071,

		/// <summary>
		/// Enables or disables the Mouse Trails feature, which improves the visibility of mouse cursor movements by briefly showing a trail of cursors 
		/// and quickly erasing them. 
		/// To disable the feature, set the uiParam parameter to zero or 1. 
		/// To enable the feature, set uiParam to a value greater than 1 to indicate the number of cursors drawn in the trail.
		/// </summary>
		/// <remarks>Windows 2000 : this parameter is not supported.</remarks>
		SPI_SETMOUSETRAILS          		=  0x005D,

		/// <summary>
		/// Turns the Vanish feature on or off. This feature hides the mouse pointer when the user types; the pointer reappears when the user moves the mouse. 
		/// The pvParam parameter specifies TRUE for on and FALSE for off. The default is off. For more information, see About Mouse Input. 
		/// </summary>
		/// <remarks>Windows 2000 : this parameter is not supported.</remarks>
		SPI_SETMOUSEVANISH                  	=  0x1021,

		/// <summary>
		/// Sets the metrics associated with the nonclient area of nonminimized windows. 
		/// The pvParam parameter must point to a NONCLIENTMETRICS structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(NONCLIENTMETRICS). 
		/// Also, the lfHeight member of the LOGFONT structure must be a negative value.
		/// </summary>
		SPI_SETNONCLIENTMETRICS     		=  0x002A,

		/// <summary>
		/// Sets the threshold in pixels where docking behavior is triggered by using a pen to drag a window to the edge of a monitor or monitor array. 
		/// The default threshold is 30. The pvParam parameter must point to a DWORD variable that contains the new value.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETPENDOCKTHRESHOLD         	=  0x0081,

		/// <summary>
		/// Sets the threshold in pixels where undocking behavior is triggered by using a pen to drag a window from the edge of a monitor or 
		/// monitor array to its center. The default threshold is 30. The pvParam parameter must point to a DWORD variable that contains the new value.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETPENDRAGOUTTHRESHOLD      	=  0x0087,

		/// <summary>
		/// Sets the threshold in pixels from the top of the monitor where a vertically maximized window is restored when dragged with a pen. 
		/// The default threshold is 50. The pvParam parameter must point to a DWORD variable that contains the new value.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETPENSIDEMOVETHRESHOLD     	=  0x008B,

		/// <summary>
		/// Undocumented.
		/// </summary>
		SPI_SETPENWINDOWS           		=  0x0031,

		/// <summary>
		/// This parameter is not supported. Instead, set the GUID_VIDEO_POWERDOWN_TIMEOUT power setting.
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP/2000:  Determines whether the power-off phase of screen saving is enabled. 
		/// The pvParam parameter must point to a BOOL variable that receives TRUE if enabled, or FALSE if disabled. This flag is supported for 32-bit applications only.
		/// </remarks>
		SPI_SETPOWEROFFACTIVE       		=  0x0056,

		/// <summary>
		/// This parameter is not supported. Instead, set the GUID_VIDEO_POWERDOWN_TIMEOUT power setting to a time-out value.
		/// </summary>
		/// <remarks>
		/// Windows Server 2003 and Windows XP/2000:  Sets the time-out value, in seconds, for the power-off phase of screen saving. 
		/// The uiParam parameter specifies the new value. The pvParam parameter must be NULL. This flag is supported for 32-bit applications only.
		/// </remarks>
		SPI_SETPOWEROFFTIMEOUT      		=  0x0052,

		/// <summary>
		/// Determines whether a screen review utility is running. The uiParam parameter specifies TRUE for on, or FALSE for off.
		/// </summary>
		SPI_SETSCREENREADER         		=  0x0047,

		/// <summary>
		/// Sets the state of the screen saver. The uiParam parameter specifies TRUE to activate screen saving, or FALSE to deactivate it.
		/// If the machine has entered power saving mode or system lock state, an ERROR_OPERATION_IN_PROGRESS exception occurs.
		/// </summary>
		SPI_SETSCREENSAVEACTIVE     		=  0x0011,

		/// <summary>
		/// Undocumented. Activates the screen saver when pvParam is TRUE ?
		/// </summary>
		SPI_SETSCREENSAVERRUNNING   		=  0x0061,

		/// <summary>
		/// Same as SPI_SETSCREENSAVERRUNNING.
		/// </summary>
		SPI_SCREENSAVERRUNNING     		=  SPI_SETSCREENSAVERRUNNING,

		/// <summary>
		/// Sets whether the screen saver requires the user to enter a password to display the Windows desktop. 
		/// The uiParam parameter is a BOOL variable. The pvParam parameter is ignored. Set uiParam to TRUE to require a password, or FALSE to not require a password. 
		/// If the machine has entered power saving mode or system lock state, an ERROR_OPERATION_IN_PROGRESS exception occurs.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETSCREENSAVESECURE   		=  0x0077,

		/// <summary>
		/// Sets the screen saver time-out value to the value of the uiParam parameter. 
		/// This value is the amount of time, in seconds, that the system must be idle before the screen saver activates.
		/// If the machine has entered power saving mode or system lock state, an ERROR_OPERATION_IN_PROGRESS exception occurs.
		/// </summary>
		SPI_SETSCREENSAVETIMEOUT    		=  0x000F,

		/// <summary>
		/// Set pvParam to TRUE to enable the selection fade effect or FALSE to disable it. 
		/// The selection fade effect causes the menu item selected by the user to remain on the screen briefly while fading out after the menu is dismissed. 
		/// The selection fade effect is possible only if the system has a color depth of more than 256 colors.
		/// </summary>
		SPI_SETSELECTIONFADE                	=  0x1015,
		
		/// <summary>
		/// This parameter is not supported.
		/// </summary>
		/// <remarks>Windows Server 2003 and Windows XP/2000:  The user should control this setting through the Control Panel.</remarks>
		SPI_SETSERIALKEYS          		=  0x003F,

		/// <summary>
		/// Sets whether the IME status window is visible or not on a per-user basis. The uiParam parameter specifies TRUE for on or FALSE for off.
		/// </summary>
		SPI_SETSHOWIMEUI          		=  0x006F,

		/// <summary>
		/// Turns the ShowSounds accessibility feature on or off. The uiParam parameter specifies TRUE for on, or FALSE for off.
		/// </summary>
		SPI_SETSHOWSOUNDS          		=  0x0039,

		/// <summary>
		/// Sets whether a window is vertically maximized when it is sized to the top or bottom of the monitor. 
		/// Set pvParam to TRUE for on or FALSE for off.
		/// SPI_GETWINARRANGING must be TRUE to enable this behavior.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETSNAPSIZING               	=  0x008F,

		/// <summary>
		/// Enables or disables the snap-to-default-button feature. 
		/// If enabled, the mouse cursor automatically moves to the default button, such as OK or Apply, of a dialog box. 
		/// Set the uiParam parameter to TRUE to enable the feature, or FALSE to disable it. 
		/// Applications should use the ShowWindow function when displaying a dialog box so the dialog manager can position the mouse cursor.
		/// </summary>
		SPI_SETSNAPTODEFBUTTON     		=  0x0060,

		/// <summary>
		/// Sets the parameters of the SoundSentry accessibility feature. 
		/// The pvParam parameter must point to a SOUNDSENTRY structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(SOUNDSENTRY).
		/// </summary>
		SPI_SETSOUNDSENTRY         		=  0x0041,

		/// <summary>
		/// Turns the speech recognition feature on or off. The uiParam parameter specifies TRUE for on, or FALSE for off.
		/// </summary>
		SPI_SETSPEECHRECOGNITION            	=  0x104B,

		/// <summary>
		/// Sets the parameters of the StickyKeys accessibility feature. 
		/// The pvParam parameter must point to a STICKYKEYS structure that contains the new parameters. S
		/// et the cbSize member of this structure and the uiParam parameter to sizeof(STICKYKEYS).
		/// </summary>
		SPI_SETSTICKYKEYS          		=  0x003B,

		/// <summary>
		/// Sets the parameters of the ToggleKeys accessibility feature. 
		/// The pvParam parameter must point to a TOGGLEKEYS structure that contains the new parameters. 
		/// Set the cbSize member of this structure and the uiParam parameter to sizeof(TOGGLEKEYS).
		/// </summary>
		SPI_SETTOGGLEKEYS          		=  0x0035,

		/// <summary>
		/// Set pvParam to TRUE to enable ToolTip animation or FALSE to disable it. If enabled, you can use SPI_SETTOOLTIPFADE to specify fade or slide animation.
		/// </summary>
		SPI_SETTOOLTIPANIMATION             	=  0x1017,

		/// <summary>
		/// If the SPI_SETTOOLTIPANIMATION flag is enabled, use SPI_SETTOOLTIPFADE to indicate whether ToolTip animation uses a fade effect or a slide effect. 
		/// Set pvParam to TRUE for fade animation or FALSE for slide animation. 
		/// The tooltip fade effect is possible only if the system has a color depth of more than 256 colors. 
		/// For more information on the slide and fade effects, see the AnimateWindowfunction.
		/// </summary>
		SPI_SETTOOLTIPFADE                  	=  0x1019,

		/// <summary>
		/// Enables or disables UI effects. Set the pvParam parameter to TRUE to enable all UI effects or FALSE to disable all UI effects.
		/// </summary>
		SPI_SETUIEFFECTS                    	=  0x103F,

		/// <summary>
		/// Sets the service shutdown request time-out to the value of the uiParam parameter. 
		/// This value is the number of milliseconds that the system waits before terminating a service that does not respond to a shutdown request.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETWAITTOKILLSERVICETIMEOUT 	=  0x007D,

		/// <summary>
		/// Sets the application shutdown request time-out to the value of the uiParam parameter. 
		/// This value is the number of milliseconds that the system waits before terminating an application that does not respond to a shutdown request.
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETWAITTOKILLTIMEOUT        	=  0x007B,

		/// <summary>
		/// Sets the number of characters to scroll when the horizontal mouse wheel is moved. The number of characters is set from the uiParam parameter.
		/// </summary>
		SPI_SETWHEELSCROLLCHARS   		=  0x006D,

		/// <summary>
		/// Sets the number of lines to scroll when the vertical mouse wheel is moved. The number of lines is set from the uiParam parameter. 
		/// The number of lines is the suggested number of lines to scroll when the mouse wheel is rolled without using modifier keys. 
		/// If the number is 0, then no scrolling should occur. If the number of lines to scroll is greater than the number of lines viewable, 
		/// and in particular if it is WHEEL_PAGESCROLL (#defined as UINT_MAX), the scroll operation should be interpreted as clicking once 
		/// in the page down or page up regions of the scroll bar.
		/// </summary>
		SPI_SETWHEELSCROLLLINES    		=  0x0069,

		/// <summary>
		/// Sets whether window arrangement is enabled. Set pvParam to TRUE for on or FALSE for off.
		/// Window arrangement reduces the number of mouse, pen, or touch interactions needed to move and size top-level windows by simplifying 
		/// the default behavior of a window when it is dragged or sized. 
		/// The following parameters set individual window arrangement settings :
		///	SPI_SETDOCKMOVING 
		///	SPI_SETMOUSEDOCKTHRESHOLD 
		///	SPI_SETMOUSEDRAGOUTTHRESHOLD 
		///	SPI_SETMOUSESIDEMOVETHRESHOLD 
		///	SPI_SETPENDOCKTHRESHOLD 
		///	SPI_SETPENDRAGOUTTHRESHOLD 
		///	SPI_SETPENSIDEMOVETHRESHOLD 
		///	SPI_SETSNAPSIZING
		/// </summary>
		/// <remarks>Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP/2000:  This parameter is not supported.</remarks>
		SPI_SETWINARRANGING             	=  0x0083,

		/// <summary>
		/// Sets the size of the work area. The work area is the portion of the screen not obscured by the system taskbar or by application desktop toolbars. 
		/// The pvParam parameter is a pointer to a RECT structure that specifies the new work area rectangle, expressed in virtual screen coordinates. 
		/// In a system with multiple display monitors, the function sets the work area of the monitor that contains the specified rectangle.
 		/// </summary>
		SPI_SETWORKAREA             		=  0x002F,
	    }
	# endregion
    }