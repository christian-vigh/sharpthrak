/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/21]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {


	# region AW_ constants for the AnimateWindow() function
	/// <summary>
	/// The type of animation. This parameter can be one or more of the following values. 
	/// <para>
	/// Note that, by default, these flags take effect when showing a window. 
	/// </para>
	/// <para>
	/// To take effect when hiding a window, use AW_HIDE and a logical OR operator with the appropriate flags. 
	/// </para>
	/// </summary>
	public enum AW_Constants		: uint
	   {
		/// <summary>
		/// Zero-value.
		/// </summary>
		AW_NONE				=  0x00000000,

		/// <summary>
		/// Activates the window. Do not use this value with AW_HIDE. 
		/// </summary>
		AW_ACTIVATE			=  0x00020000,

		/// <summary>
		/// Uses a fade effect. This flag can be used only if hwnd is a top-level window. 
		/// </summary>
		AW_BLEND			=  0x00080000,

		/// <summary>
		/// Makes the window appear to collapse inward if AW_HIDE is used or expand outward if the AW_HIDE is not used. 
		/// The various direction flags have no effect. 
		/// </summary>
		AW_CENTER			=  0x00000010,

		/// <summary>
		/// Hides the window. By default, the window is shown. 
		/// </summary>
		AW_HIDE				=  0x00010000,

		/// <summary>
		/// Animates the window from right to left. This flag can be used with roll or slide animation. It is ignored when used with AW_CENTER or AW_BLEND.
		/// </summary>
		AW_HOR_NEGATIVE			=  0x00000002,

		/// <summary>
		/// Animates the window from left to right. This flag can be used with roll or slide animation. It is ignored when used with AW_CENTER or AW_BLEND.
		/// </summary>
		AW_HOR_POSITIVE			=  0x00000001,

		/// <summary>
		/// 
		/// </summary>
		AW_VER_NEGATIVE			=  0x00000008,

		/// <summary>
		/// Animates the window from top to bottom. This flag can be used with roll or slide animation. It is ignored when used with AW_CENTER or AW_BLEND. 
		/// </summary>
		AW_VER_POSITIVE			=  0x00000004,

		/// <summary>
		/// Uses slide animation. By default, roll animation is used. This flag is ignored when used with AW_CENTER. 
		/// </summary>
		AW_SLIDE			=  0x00040000
	    }
	# endregion
    }
