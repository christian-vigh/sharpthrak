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

	# region SORT_ constants
	/// <summary>
	/// Sorting IDs. Note that the named locale APIs (eg CompareStringExEx) are recommended.
	/// </summary>
	public enum  SORT_Constants	:  ushort
	   {
		/// <summary>
		/// Sorting default.
		/// </summary>
		SORT_DEFAULT                     =  0x0,
		/// <summary>
		/// Invariant (Mathematical Symbols).
		/// </summary>
		SORT_INVARIANT_MATH              =  0x1,
		/// <summary>
		/// Japanese XJIS order.
		/// </summary>
		SORT_JAPANESE_XJIS               =  0x0,
		/// <summary>
		/// Japanese Unicode order (no longer supported).
		/// </summary>
		SORT_JAPANESE_UNICODE            =  0x1,
		/// <summary>
		/// Japanese radical/stroke order.
		/// </summary>
		SORT_JAPANESE_RADICALSTROKE      =  0x4,
		/// <summary>
		/// Chinese BIG5 order.
		/// </summary>
		SORT_CHINESE_BIG5                =  0x0,
		/// <summary>
		/// PRC Chinese Phonetic order.
		/// </summary>
		SORT_CHINESE_PRCP                =  0x0,
		/// <summary>
		/// Chinese Unicode order (no longer supported).
		/// </summary>
		SORT_CHINESE_UNICODE             =  0x1,
		/// <summary>
		/// PRC Chinese Stroke Count order.
		/// </summary>
		SORT_CHINESE_PRC                 =  0x2,
		/// <summary>
		/// Traditional Chinese Bopomofo order.
		/// </summary>
		SORT_CHINESE_BOPOMOFO            =  0x3,
		/// <summary>
		/// Traditional Chinese radical/stroke order.
		/// </summary>
		SORT_CHINESE_RADICALSTROKE       =  0x4,
		/// <summary>
		/// Korean KSC order.
		/// </summary>
		SORT_KOREAN_KSC                  =  0x0,
		/// <summary>
		/// Korean Unicode order (no longer supported).
		/// </summary>
		SORT_KOREAN_UNICODE              =  0x1,
		/// <summary>
		/// German Phone Book order.
		/// </summary>
		SORT_GERMAN_PHONE_BOOK           =  0x1,
		/// <summary>
		/// Hungarian Default order.
		/// </summary>
		SORT_HUNGARIAN_DEFAULT           =  0x0,
		/// <summary>
		/// Hungarian Technical order.
		/// </summary>
		SORT_HUNGARIAN_TECHNICAL         =  0x1,
		/// <summary>
		/// Georgian Traditional order.
		/// </summary>
		SORT_GEORGIAN_TRADITIONAL        =  0x0,
		/// <summary>
		/// Georgian Modern order.
		/// </summary>
		SORT_GEORGIAN_MODERN             =  0x1
	    }
	# endregion
    }