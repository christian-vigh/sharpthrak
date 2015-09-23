/**************************************************************************************************************

    NAME
        WinAPI/Enums/C/CWP.cs

    DESCRIPTION
        CWP constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region CWP_ constants
	/// <summary>
	/// Flags for the ChildWindowFromPointEx function.
	/// </summary>
	public enum CWP_Constants : int
	   {
		/// <summary>
		/// Does not skip any child windows
		/// </summary>
		CWP_ALL			=  0x0000,

		/// <summary>
		/// Skips disabled child windows
		/// </summary>
		CWP_SKIPDISABLED	=  0x0002,

		/// <summary>
		/// Skips invisible child windows
		/// </summary>
		CWP_SKIPINVISIBLE	=  0x0001,

		/// <summary>
		/// Skips transparent child windows
		/// </summary>
		CWP_SKIPTRANSPARENT	=  0x0004
	    }
	# endregion
    }