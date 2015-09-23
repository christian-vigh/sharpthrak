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
	# region NID_ constants for the GetSystemMetrics ( SM_DIGITIZER ) return value
	/// <summary>
	/// Specifies the touch capabilities of the input digitizer. 
	/// </summary>
	public enum NID_Constants : int
	   {
		/// <summary>
		/// The input digitizer does not have touch capabilities.
		/// </summary>
		NID_TABLET_CONFIG_NONE		=  0x00000000,

		/// <summary>
		/// An integrated touch digitizer is used for input.
		/// </summary>
		NID_INTEGRATED_TOUCH		=  0x00000001,

		/// <summary>
		/// An external touch digitizer is used for input.
		/// </summary>
		NID_EXTERNAL_TOUCH		=  0x00000002,

		/// <summary>
		/// An integrated pen digitizer is used for input.
		/// </summary>
		NID_INTEGRATED_PEN		=  0x00000004,

		/// <summary>
		/// An external pen digitizer is used for input.
		/// </summary>
		NID_EXTERNAL_PEN		=  0x00000008,

		/// <summary>
		/// An input digitizer with support for multiple inputs is used for input.
		/// </summary>
		NID_MULTI_INPUT			=  0x00000040,

		/// <summary>
		/// The input digitizer is ready for input. If this value is unset, it may mean that the tablet service is stopped, 
		/// the digitizer is not supported, or digitizer drivers have not been installed.
		/// </summary>
		NID_READY			=  0x00000080
	    }
	# endregion
    }