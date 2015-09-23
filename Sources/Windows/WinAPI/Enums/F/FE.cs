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

	#  region FE_ constants used as parameters to certain SystemParametersInfo() action values
	/// <summary>
	/// Constants for the SPI_GETFONTSMOOTHINGTYPE, SPI_SETFONTSMOOTHINGTYPE, SPI_GETFONTSMOOTHINGORIENTATION and 
	/// SPI_SETFONTSMOOTHINGORIENTATION action values of the SystemParametersInfo() function.
	/// </summary>
	public enum  FE_Constants	: uint
	   {
		FE_FONTSMOOTHINGSTANDARD		=  0x0001,
		FE_FONTSMOOTHINGCLEARTYPE		=  0x0002,
		FE_FONTSMOOTHINGORIENTATIONBGR		=  0x0000,
		FE_FONTSMOOTHINGORIENTATIONRGB		=  0x0001
	    }
	# endregion
    }