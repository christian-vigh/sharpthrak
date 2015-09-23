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
	# region ODA_ Owner-draw control action constants
	/// <summary>
	/// Owner-draw control action constants (specified to the WindowProc for repainting the control).
	/// </summary>
	public enum ODA_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		ODA_NONE		=  0x0000,

		/// <summary>
		/// The entire control needs to be drawn.
		/// </summary>
		ODA_DRAWENTIRE		=  0x0001,

		/// <summary>
		/// The control has lost or gained the keyboard focus. The itemState member should be checked to determine whether the control has the focus.
		/// </summary>
		ODA_FOCUS		=  0x0004,

		/// <summary>
		/// The selection status has changed. The itemState member should be checked to determine the new selection state.
		/// </summary>
		ODA_SELECT		=  0x0002
	    }
	# endregion
     }
