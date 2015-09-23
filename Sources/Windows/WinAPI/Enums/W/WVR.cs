/**************************************************************************************************************

    NAME
        WinAPI/Enums/W/WVR.cs

    DESCRIPTION
        WVR constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region WVR_ constants
	/// <summary>
	/// WM_NCCALCSIZE "window valid rect" return values.
	/// </summary>
	public enum WVR_Constants : int
	   {
		/// <summary>
		/// Specifies that the client area of the window is to be preserved and aligned with the bottom of the new position of the window. 
		/// For example, to align the client area to the top-left corner, return the WVR_ALIGNTOP and WVR_ALIGNLEFT values.
		/// </summary>
		WVR_ALIGNBOTTOM     		=  0x0040,

		/// <summary>
		/// Specifies that the client area of the window is to be preserved and aligned with the left side of the new position of the window. 
		/// For example, to align the client area to the lower-left corner, return the WVR_ALIGNLEFT and WVR_ALIGNBOTTOM values.
		/// </summary>
		WVR_ALIGNLEFT       		=  0x0020,

		/// <summary>
		/// Specifies that the client area of the window is to be preserved and aligned with the right side of the new position of the window. 
		/// For example, to align the client area to the lower-right corner, return the WVR_ALIGNRIGHT and WVR_ALIGNBOTTOM values.
		/// </summary>
		WVR_ALIGNRIGHT      		=  0x0080,

		/// <summary>
		/// Specifies that the client area of the window is to be preserved and aligned with the top of the new position of the window. 
		/// For example, to align the client area to the upper-left corner, return the WVR_ALIGNTOP and WVR_ALIGNLEFT values.
		/// </summary>
		WVR_ALIGNTOP        		=  0x0010,

		/// <summary>
		/// Used in combination with any other values, except WVR_VALIDRECTS, causes the window to be completely redrawn 
		/// if the client rectangle changes size horizontally. This value is similar to CS_HREDRAW class style
		/// </summary>
		WVR_HREDRAW         		=  0x0100,

		/// <summary>
		/// This value causes the entire window to be redrawn. It is a combination of WVR_HREDRAW and WVR_VREDRAW values.
		/// </summary>
		WVR_REDRAW			=  WVR_HREDRAW | WVR_VREDRAW,

		/// <summary>
		/// This value indicates that, upon return from WM_NCCALCSIZE, the rectangles specified by the rgrc[1] and rgrc[2] members of the 
		/// NCCALCSIZE_PARAMS structure contain valid destination and source area rectangles, respectively. 
		/// The system combines these rectangles to calculate the area of the window to be preserved. 
		/// The system copies any part of the window image that is within the source rectangle and clips the image to the destination rectangle. 
		/// Both rectangles are in parent-relative or screen-relative coordinates. This flag cannot be combined with any other flags. 
		/// <para>
		/// This return value allows an application to implement more elaborate client-area preservation strategies, 
		/// such as centering or preserving a subset of the client area.
		/// </para>
		/// </summary>
		WVR_VALIDRECTS      		=  0x0400,

		/// <summary>
		/// Used in combination with any other values, except WVR_VALIDRECTS, causes the window to be completely redrawn if the client rectangle 
		/// changes size vertically. This value is similar to CS_VREDRAW class style
		/// </summary>
		WVR_VREDRAW         		=  0x0200,

		/// <summary>
		/// Zero value.
		/// </summary>
		WVR_NONE			=  0x0000
	    }
	# endregion
    }