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
	# region MK_ Mouse key state constants
	/// <summary>
	/// Mouse button state constants.
	/// </summary>
	public enum MK_Constants : ushort
	   {
		/// <summary>
		/// Left mouse button has been pressed.
		/// </summary>
		MK_LBUTTON		=  0x0001,

		/// <summary>
		/// Right mouse button has been pressed.
		/// </summary>
		MK_RBUTTON		=  0x0002,

		/// <summary>
		/// The SHIFT key is down.
		/// </summary>
		MK_SHIFT		=  0x0004,

		/// <summary>
		/// The CTRL key is down.
		/// </summary>
		MK_CONTROL		=  0x0008,

		/// <summary>
		/// The middle mouse button has been pressed.
		/// </summary>
		MK_MBUTTON		=  0x0010,

		/// <summary>
		/// The X-Button 1 has been clicked.
		/// </summary>
		MK_XBUTTON1		=  0x0020,

		/// <summary>
		/// The X-button 2 has been clicked.
		/// </summary>
		MK_XBUTTON2		=  0x0040
	    }
	# endregion
    }