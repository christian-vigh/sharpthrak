/**************************************************************************************************************

    NAME
        WinAPI/Enums/I/INPUTLANGCHANGE.cs

    DESCRIPTION
        INPUTLANGCHANGE constants.

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
	# region INPUTLANGCHANGE_ constants
	/// <summary>
	/// Possible values for the wParam parameter of the WM_INPUTLANGCHANGEREQUEST message.
	/// </summary>
	public enum INPUTLANGCHANGE_Constants : int
	   {
		/// <summary>
		/// A hot key was used to choose the previous input locale in the installed list of input locales. This flag cannot be used with the INPUTLANGCHANGE_FORWARD flag.
		/// </summary>
		INPUTLANGCHANGE_BACKWARD	=  0x0004,

		/// <summary>
		/// A hot key was used to choose the next input locale in the installed list of input locales. This flag cannot be used with the INPUTLANGCHANGE_BACKWARD flag.
		/// </summary>
		INPUTLANGCHANGE_FORWARD		=  0x0002,

		/// <summary>
		/// The new input locale's keyboard layout can be used with the system character set.
		/// </summary>
		INPUTLANGCHANGE_SYSCHARSET	=  0x0001
	    }
	# endregion
    }