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
	# region Font _CHARSET constants
	/// <summary>
	/// Indicates a font character set.
	/// </summary>
	public enum  FONTCHARSET_Constants	:  byte
	   {
		 ANSI_CHARSET			=    0,
		 ARABIC_CHARSET			=  178,
		 BALTIC_CHARSET			=  186,
		 CHINESEBIG5_CHARSET		=  136,
		 DEFAULT_CHARSET		=    1,
		 EASTEUROPE_CHARSET		=  238,
		 GB2312_CHARSET			=  134,
		 GREEK_CHARSET			=  161,
		 HANGEUL_CHARSET		=  129,
		 HANGUL_CHARSET			=  129,
		 HEBREW_CHARSET			=  177,
		 JOHAB_CHARSET			=  130,
		 MAC_CHARSET			=   77,
		 OEM_CHARSET			=  255,
		 RUSSIAN_CHARSET		=  204,
		 SHIFTJIS_CHARSET		=  128,
		 SYMBOL_CHARSET			=    2,
		 THAI_CHARSET			=  222,
		 TURKISH_CHARSET		=  162,
		 VIETNAMESE_CHARSET		=  163
	    }
	# endregion
     }
