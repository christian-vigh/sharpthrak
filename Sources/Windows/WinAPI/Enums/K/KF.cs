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


	# region KF_ constants for WM_CHAR/KEYUP/KEYDOWN messages.
	/// <summary>
	/// </summary>
	public enum KF_Constants		: ushort
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		KF_ZERO			=  0x0000,

		/// <summary>
		/// Manipulates the ALT key flag, which indicates whether the ALT key is pressed.
		/// </summary>
		KF_ALTDOWN        	=  0x2000,

		/// <summary>
		/// Manipulates the dialog mode flag, which indicates whether a dialog box is active.
		/// </summary>
		KF_DLGMODE        	=  0x0800,

		/// <summary>
		/// Manipulates the extended key flag.
		/// </summary>
		KF_EXTENDED       	=  0x0100,

		/// <summary>
		/// Manipulates the menu mode flag, which indicates whether a menu is active.
		/// </summary>
		KF_MENUMODE       	=  0x1000,

		/// <summary>
		/// Manipulates the repeat count.
		/// </summary>
		KF_REPEAT         	=  0x4000,

		/// <summary>
		/// Manipulates the transition state flag.
		/// </summary>
		KF_UP             	=  0x8000
	    }
	# endregion
    }
