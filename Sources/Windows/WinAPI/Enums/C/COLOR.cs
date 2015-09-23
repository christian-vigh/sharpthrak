/**************************************************************************************************************

    NAME
        WinAPI/Constants/C/CS.cs

    DESCRIPTION
        Window class styles.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region COLOR_ constants.
	/// <summary>
	/// Index to system color constants.
	/// </summary>
	public enum COLOR_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		COLOR_NONE				=  0,

		/// <summary>
		/// Dark shadow for three-dimensional display elements.
		/// </summary>
		COLOR_3DDKSHADOW        		=  21,

		/// <summary>
		/// Face color for three-dimensional display elements and for dialog box backgrounds.
		/// </summary>
		COLOR_3DFACE            		=  COLOR_BTNFACE,

		/// <summary>
		/// Highlight color for three-dimensional display elements (for edges facing the light source.)
		/// </summary>
		COLOR_3DHIGHLIGHT       		=  COLOR_BTNHIGHLIGHT,

		/// <summary>
		/// Highlight color for three-dimensional display elements (for edges facing the light source.)
		/// </summary>
		COLOR_3DHILIGHT         		=  COLOR_BTNHIGHLIGHT,

		/// <summary>
		/// color for three-dimensional display elements (for edges facing the light source.)
		/// </summary>
		COLOR_3DLIGHT           		=  22,

		/// <summary>
		/// Shadow color for three-dimensional display elements (for edges facing away from the light source).
		/// </summary>
		COLOR_3DSHADOW          		=  COLOR_BTNSHADOW,

		/// <summary>
		/// Active window border.
		/// </summary>
		COLOR_ACTIVEBORDER      		=  10,

		/// <summary>
		/// Active window title bar. 
		/// <para>
		/// Specifies the left side color in the color gradient of an active window's title bar if the gradient effect is enabled.
		/// </para>
		/// </summary>
		COLOR_ACTIVECAPTION     		=  2,

		/// <summary>
		/// Background color of multiple document interface (MDI) applications.
		/// </summary>
		COLOR_APPWORKSPACE      		=  12,

		/// <summary>
		/// Desktop.
		/// </summary>
		COLOR_BACKGROUND        		=  1,

		/// <summary>
		/// Face color for three-dimensional display elements and for dialog box backgrounds.
		/// </summary>
		COLOR_BTNFACE           		=  15,

		/// <summary>
		/// Highlight color for three-dimensional display elements (for edges facing the light source.)
		/// </summary>
		COLOR_BTNHIGHLIGHT      		=  20,

		/// <summary>
		/// Highlight color for three-dimensional display elements (for edges facing the light source.)
		/// </summary>
		COLOR_BTNHILIGHT        		=  COLOR_BTNHIGHLIGHT,

		/// <summary>
		/// Shadow color for three-dimensional display elements (for edges facing away from the light source).
		/// </summary>
		COLOR_BTNSHADOW         		=  16,

		/// <summary>
		/// Text on push buttons.
		/// </summary>
		COLOR_BTNTEXT           		=  18,

		/// <summary>
		/// Text in caption, size box, and scroll bar arrow box.
		/// </summary>
		COLOR_CAPTIONTEXT       		=  9,

		/// <summary>
		/// Desktop.
		/// </summary>
		COLOR_DESKTOP           		=  COLOR_BACKGROUND,

		/// <summary>
		/// Right side color in the color gradient of an active window's title bar. 
		/// <para>
		/// COLOR_ACTIVECAPTION specifies the left side color. Use SPI_GETGRADIENTCAPTIONS with the SystemParametersInfo function
		/// to determine whether the gradient effect is enabled.
		/// </para>
		/// </summary>
		COLOR_GRADIENTACTIVECAPTION 		=  27,

		/// <summary>
		/// Right side color in the color gradient of an inactive window's title bar. 
		/// <para>
		/// COLOR_INACTIVECAPTION specifies the left side color.
		/// </para>
		/// </summary>
		COLOR_GRADIENTINACTIVECAPTION 		=  28,

		/// <summary>
		/// Grayed (disabled) text. This color is set to 0 if the current display driver does not support a solid gray color.
		/// </summary>
		COLOR_GRAYTEXT          		=  17,

		/// <summary>
		/// Item(s) selected in a control.
		/// </summary>
		COLOR_HIGHLIGHT         		=  13,

		/// <summary>
		/// Text of item(s) selected in a control.
		/// </summary>
		COLOR_HIGHLIGHTTEXT     		=  14,

		/// <summary>
		/// Color for a hyperlink or hot-tracked item.
		/// </summary>
		COLOR_HOTLIGHT          		=  26,

		/// <summary>
		/// Inactive window border.
		/// </summary>
		COLOR_INACTIVEBORDER    		=  11,

		/// <summary>
		/// Inactive window caption. 
		/// <para>
		/// Specifies the left side color in the color gradient of an inactive window's title bar if the gradient effect is enabled.
		/// </para>
		/// </summary>
		COLOR_INACTIVECAPTION   		=  3,

		/// <summary>
		/// Color of text in an inactive caption.
		/// </summary>
		COLOR_INACTIVECAPTIONTEXT 		=  19,

		/// <summary>
		/// Background color for tooltip controls.
		/// </summary>
		COLOR_INFOBK            		=  24,

		/// <summary>
		/// Text color for tooltip controls.
		/// </summary>
		COLOR_INFOTEXT          		=  23,

		/// <summary>
		/// Menu background.
		/// </summary>
		COLOR_MENU              		=  4,

		/// <summary>
		/// The background color for the menu bar when menus appear as flat menus (see SystemParametersInfo). 
		/// However, COLOR_MENU continues to specify the background color of the menu popup.
		/// </summary>
		COLOR_MENUBAR           		=  30,

		/// <summary>
		/// The color used to highlight menu items when the menu appears as a flat menu (see SystemParametersInfo). 
		/// The highlighted menu item is outlined with COLOR_HIGHLIGHT
		/// </summary>
		COLOR_MENUHILIGHT       		=  29,

		/// <summary>
		/// Text in menus.
		/// </summary>
		COLOR_MENUTEXT          		=  7,

		/// <summary>
		/// Scroll bar gray area.
		/// </summary>
		COLOR_SCROLLBAR         		=  0,

		/// <summary>
		/// Window background.
		/// </summary>
		COLOR_WINDOW            		=  5,

		/// <summary>
		/// Window frame.
		/// </summary>
		COLOR_WINDOWFRAME       		=  6,

		/// <summary>
		/// Text in windows.
		/// </summary>
		COLOR_WINDOWTEXT        		=  8
	    }
	# endregion
    }