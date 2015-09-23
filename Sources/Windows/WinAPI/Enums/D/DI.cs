/**************************************************************************************************************

    NAME
        WinAPI/Enums/D/DI.cs

    DESCRIPTION
        DI constants.

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
	# region DI_ constants
	/// <summary>
	/// Icon drawing flags.
	/// </summary>
	public enum DI_Constants : int
	   {
		/// <summary>
		/// This flag is ignored.
		/// </summary>
		DI_COMPAT		=  0x0004,

		/// <summary>
		/// Draws the icon or cursor using the width and height specified by the system metric values for icons, 
		/// if the cxWidth and cyWidth parameters are set to zero. 
		/// If this flag is not specified and cxWidth and cyWidth are set to zero, the function uses the actual resource size. 
		/// </summary>
		DI_DEFAULTSIZE		=  0x0008,

		/// <summary>
		/// Draws the icon or cursor using the image.
		/// </summary>
		DI_IMAGE		=  0x0002,

		/// <summary>
		/// Draws the icon or cursor using the mask.
		/// </summary>
		DI_MASK			=  0x0001,

		/// <summary>
		/// Draws the icon as an unmirrored icon. By default, the icon is drawn as a mirrored icon if hdc is mirrored.
		/// </summary>
		DI_NOMIRROR		=  0x0010,

		/// <summary>
		/// Combination of DI_IMAGE and DI_MASK.
		/// </summary>
		DI_NORMAL		=  DI_IMAGE | DI_MASK,

		/// <summary>
		/// Zero value.
		/// </summary>
		DI_NONE
	    }
	# endregion
    }