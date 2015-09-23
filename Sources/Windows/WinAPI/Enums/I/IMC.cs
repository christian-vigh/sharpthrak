/**************************************************************************************************************

    NAME
        WinAPI/Enums/I/IMC.cs

    DESCRIPTION
        IMC constants.

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
	# region IMC_ constants
	/// <summary>
	/// </summary>
	public enum IMC_Constants : int
	   {
		/// <summary>
		/// Instructs the IME window to hide the status window.
		/// </summary>
		IMC_CLOSESTATUSWINDOW           	=  0x0021,

		/// <summary>
		/// Instructs an IME window to get the position of the candidate window. 
		/// </summary>
		IMC_GETCANDIDATEPOS             	=  0x0007,

		/// <summary>
		/// Instructs an IME window to retrieve the logical font used for displaying intermediate characters in the composition window.
		/// </summary>
		IMC_GETCOMPOSITIONFONT          	=  0x0009,

		/// <summary>
		/// Instructs an IME window to get the position of the composition window. 
		/// </summary>
		IMC_GETCOMPOSITIONWINDOW        	=  0x000B,

		/// <summary>
		/// Instructs an IME window to get the position of the status window.
		/// </summary>
		IMC_GETSTATUSWINDOWPOS          	=  0x000F,

		/// <summary>
		/// Instructs the IME window to show the status window. 
		/// </summary>
		IMC_OPENSTATUSWINDOW            	=  0x0022,

		/// <summary>
		/// Instructs an IME window to set the position of the candidates window. 
		/// </summary>
		IMC_SETCANDIDATEPOS             	=  0x0008,

		/// <summary>
		/// Instructs an IME window to specify the logical font to use for displaying intermediate characters in the composition window.
		/// </summary>
		IMC_SETCOMPOSITIONFONT          	=  0x000A,

		/// <summary>
		/// Instructs an IME window to set the style of the composition window.
		/// </summary>
		IMC_SETCOMPOSITIONWINDOW        	=  0x000C,

		/// <summary>
		/// Instructs an IME window to set the position of the status window.
		/// </summary>
		IMC_SETSTATUSWINDOWPOS          	=  0x0010
	    }
	# endregion
    }