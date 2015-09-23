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

	# region  SPIF_ flags used for the fWinIni parameter of the SystemParametersInfo() function
	/// <summary>
	/// Flags used for the fWinIni parameter of the SystemParametersInfo() function.
	/// <para>
	/// When a system parameter is being set, specifies whether the user profile is to be updated, and if so, 
	/// whether the WM_SETTINGCHANGE message is to be broadcast to all top-level windows to notify them of the change. 
	/// </para>
	/// </summary>
	public enum  SPIF_Constants	: uint
	   {
		/// <summary>
		/// Neither user profile will be updated, nor a WM_SETTINGCHANGE message will be sent.
		/// </summary>
		SPIF_NONE				=  0x0000,

		/// <summary>
		/// Writes the new system-wide parameter setting to the user profile.
		/// </summary>
		SPIF_UPDATEINIFILE			=  0x0001,

		/// <summary>
		/// Broadcasts the WM_SETTINGCHANGE message after updating the user profile.
		/// </summary>
		SPIF_SENDWININICHANGE			=  0x0002,

		/// <summary>
		/// Broadcasts the WM_SETTINGCHANGE message after updating the user profile. Same as SPIF_SENDWININICHANGE.
		/// </summary>
		SPIF_SENDCHANGE				=  SPIF_SENDWININICHANGE
	    }
	# endregion
    }