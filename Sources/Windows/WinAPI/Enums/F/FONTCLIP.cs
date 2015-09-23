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
	# region Font _CLIP constants
	/// <summary>
	/// Indicates one or more font clipping options.
	/// </summary>
	public enum  FONTCLIP_Constants	:  byte
	   {
		/// <summary>
		/// Not used.
		/// </summary>
		CLIP_CHARACTER_PRECIS		=  1,

		/// <summary>
		/// Specifies default clipping behavior.
		/// </summary>
		CLIP_DEFAULT_PRECIS		=  0,

		/// <summary>
		/// Windows XP SP1: Turns off font association for the font. 
		/// <para>
		/// Note that this flag is not guaranteed to have any effect on any platform after Windows Server 2003.
		/// </para>
		/// </summary>
		CLIP_DFA_DISABLE		=  ( 4 << 4 ),

		/// <summary>
		/// You must specify this flag to use an embedded read-only font.
		/// </summary>
		CLIP_EMBEDDED			=  ( 8 << 4 ),

		/// <summary>
		/// When this value is used, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or right-handed.
		/// <para>
		/// If not used, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate system.
		/// </para>
		/// </summary>
		CLIP_LH_ANGLES			=  ( 1 << 4 ),

		/// <summary>
		/// Not used.
		/// </summary>
		CLIP_MASK			=  0x0F,

		/// <summary>
		/// Not used by the font mapper, but is returned when raster, vector, or TrueType fonts are enumerated.
		/// <para>
		/// For compatibility, this value is always returned when enumerating fonts.
		/// </para>
		/// </summary>
		CLIP_STROKE_PRECIS		=  2,

		/// <summary>
		/// Not used.
		/// </summary>
		CLIP_TT_ALWAYS			=  ( 2 << 4 )
	    }
	# endregion
     }
