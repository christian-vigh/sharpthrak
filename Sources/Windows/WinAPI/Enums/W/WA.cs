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

	# region WA_ Window activation constants
	/// <summary>
	/// Activation reason sent in the low-order word of the WPARAM parameter of the WM_ACTIVATE message.
	/// </summary>
	public enum WA_Constants : short
	   { 
		/// <summary>
		/// Activated by some method other than a mouse click (for example, by a call to the SetActiveWindow function 
		/// or by use of the keyboard interface to select the window).
		/// </summary>
		WA_ACTIVE		=  1,

		/// <summary>
		/// Activated by a mouse click.
		/// </summary>
		WA_CLICKACTIVE		=  2,

		/// <summary>
		/// Window has been deactivated.
		/// </summary>
		WA_INACTIVE		=  0
	    }
	# endregion
    }