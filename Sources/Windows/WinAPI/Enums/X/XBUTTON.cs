/**************************************************************************************************************

    NAME
        WinAPI/Enums/X/XBUTTON.cs

    DESCRIPTION
        XBUTTON constants.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region XBUTTON_ constants
	/// <summary>
	/// Specifies X button indexes.
	/// </summary>
	public enum XBUTTON_Constants : int
	   {
		/// <summary>
		/// First X button.
		/// </summary>
		XBUTTON1	=  1,

		/// <summary>
		/// Second X button.
		/// </summary>
		XBUTTON2	=  2
	    }
	# endregion
    }