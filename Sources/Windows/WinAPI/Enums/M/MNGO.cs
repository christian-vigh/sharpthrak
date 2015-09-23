/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MNGO.cs

    DESCRIPTION
        MNGO constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region MNGO_ constants
	/// <summary>
	/// WM_MENUGETOBJECT return values.
	/// </summary>
	public enum MNGO_Constants : int
	   {
		/// <summary>
		/// The interface is not supported.
		/// </summary>
		MNGO_NOINTERFACE     =  0x00000000,

		/// <summary>
		/// An interface pointer was returned in the pvObj member of MENUGETOBJECTINFO 
		/// </summary>
		MNGO_NOERROR         =  0x00000001
	    }
	# endregion
    }