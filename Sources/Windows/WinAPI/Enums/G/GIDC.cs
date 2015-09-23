/**************************************************************************************************************

    NAME
        WinAPI/Enums/G/GIDC.cs

    DESCRIPTION
        GIDC constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region GIDC_ constants
	/// <summary>
	/// Possible values for the wParam parameter of the WM_INPUT_DEVICE_CHANGE message.
	/// </summary>
	public enum GIDC_Constants : int
	   {
		/// <summary>
		/// A new device has been added to the system. 
		/// </summary>
		GIDC_ARRIVAL		=  1,

		/// <summary>
		/// A device has been removed from the system. 
		/// </summary>
		GIDC_REMOVAL		=  2
	    }
	# endregion
    }