/**************************************************************************************************************

    NAME
        WinAPI/Enums/I/IMR.cs

    DESCRIPTION
        IMR constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/31]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region IMR_ constants
	/// <summary>
	/// Commmands sent through the WM_IME_REQUEST message.
	/// </summary>
	public enum IMR_Constants : int
	   {
		/// <summary>
		/// Notfies an application when a selected IME needs information about the candidate window. 
		/// </summary>
		IMR_CANDIDATEWINDOW             		=  0x0002,

		/// <summary>
		/// Notifies an application when a selected IME needs information about the font used by the composition window. 
		/// </summary>
		IMR_COMPOSITIONFONT             		=  0x0003,

		/// <summary>
		/// Notifies an application when a selected IME needs information about the composition window. 
		/// </summary>
		IMR_COMPOSITIONWINDOW           		=  0x0001,

		/// <summary>
		/// Notifies an application when the IME needs to change the RECONVERTSTRING structure. 
		/// </summary>
		IMR_CONFIRMRECONVERTSTRING      		=  0x0005,

		/// <summary>
		/// Notifies an application when the selected IME needs the converted string from the application.
		/// </summary>
		IMR_DOCUMENTFEED                		=  0x0007,

		/// <summary>
		/// Notifies an application when the selected IME needs information about the coordinates of a character in the composition string.
		/// </summary>
		IMR_QUERYCHARPOSITION           		=  0x0006,

		/// <summary>
		/// Notifies an application when a selected IME needs a string for reconversion. 
		/// </summary>
		IMR_RECONVERTSTRING             		=  0x0004
	    }
	# endregion
    }