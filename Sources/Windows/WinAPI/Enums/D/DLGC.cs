/**************************************************************************************************************

    NAME
        WinAPI/Constants/D/DLGC.cs

    DESCRIPTION
        DLGC constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region DLGC_ constants
	/// <summary>
	/// Indicate which type of input the application processes within a dialog box. 
	/// </summary>
	public enum DLGC_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		DLGC_NONE			=  0x0000,

		/// <summary>
		/// Button.
		/// </summary>
		DLGC_BUTTON			=  0x2000,

		/// <summary>
		/// Default push button.
		/// </summary>
		DLGC_DEFPUSHBUTTON		=  0x0010,

		/// <summary>
		/// EM_SETSEL messages.
		/// </summary>
		DLGC_HASSETSEL			=  0x0008,

		/// <summary>
		/// Radio button.
		/// </summary>
		DLGC_RADIOBUTTON		=  0x0040,

		/// <summary>
		/// Static control.
		/// </summary>
		DLGC_STATIC			=  0x0100,

		/// <summary>
		/// Non-default push button.
		/// </summary>
		DLGC_UNDEFPUSHBUTTON		=  0x0020,

		/// <summary>
		/// All keyboard input.
		/// </summary>
		DLGC_WANTALLKEYS		=  0x0004,

		/// <summary>
		/// Direction keys.
		/// </summary>
		DLGC_WANTARROWS			=  0x0001,

		/// <summary>
		/// WM_CHAR messages.
		/// </summary>
		DLGC_WANTCHARS			=  0x0080,

		/// <summary>
		/// All keyboard input (the application passes this message in the MSG structure to the control).
		/// </summary>
		DLGC_WANTMESSAGE		=  0x0004,

		/// <summary>
		/// TAB key.
		/// </summary>
		DLGC_WANTTAB			=  0x0002,
	    }
	# endregion
    }