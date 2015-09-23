/**************************************************************************************************************

    NAME
        WinAPI/Constants/S/SLE.cs

    DESCRIPTION
        SetLastErrorEx() error flags.

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

	# region  SLE_ flags used for SetLastErrorEx()
	/// <summary>
	/// SetLastErrorEx() error flags.
	/// </summary>
	public enum  SLE_Constants	: uint
	   {
		/// <summary>
		/// Error condition.
		/// </summary>
		SLE_ERROR			=  0x00000001,

		/// <summary>
		/// Minor error condition.
		/// </summary>
		SLE_MINORERROR			=  0x00000002,

		/// <summary>
		/// Warning.
		/// </summary>
		SLE_WARNING			=  0x00000003
	    }
	# endregion
    }