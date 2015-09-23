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
	# region FW_ font weight constants
	/// <summary>
	/// Specifies a font weight.
	/// </summary>
	public enum  FW_Constants	:  int
	   {
		FW_BLACK			=  FW_HEAVY,
		FW_BOLD				=  700,
		FW_DEMIBOLD			=  FW_SEMIBOLD,
		FW_DONTCARE			=  0,
		FW_EXTRABOLD			=  800,
		FW_EXTRALIGHT			=  200,
		FW_HEAVY			=  900,
		FW_LIGHT			=  300,
		FW_MEDIUM			=  500,
		FW_NORMAL			=  400,
		FW_REGULAR			=  FW_NORMAL,
		FW_SEMIBOLD			=  600,
		FW_THIN				=  100,
		FW_ULTRABOLD			=  FW_EXTRABOLD,
		FW_ULTRALIGHT			=  FW_EXTRALIGHT
	    }
	# endregion
   }

