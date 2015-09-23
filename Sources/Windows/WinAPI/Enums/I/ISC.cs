/**************************************************************************************************************

    NAME
        WinAPI/Enums/I/ISC.cs

    DESCRIPTION
        ISC constants.

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
	# region ISC_ constants
	/// <summary>
	/// Display options specified with the WM_IME_SETCONTEXT message.
	/// </summary>
	public enum ISC_Constants : uint
	   {
		ISC_SHOWUIALLCANDIDATEWINDOW    	=  0x0000000F,

		ISC_SHOWUIALL                   	=  0xC000000F,

		/// <summary>
		/// Show the candidate window of index 0 by user interface window.
		/// <para>
		/// To show the candidate window of index 1, specify (ISC_SHOWUICANDIDATEWINDOW << 1).
		/// </para>
		/// <para>
		/// To show the candidate window of index 2, specify (ISC_SHOWUICANDIDATEWINDOW << 2), etc.
		/// </para>
		/// </summary>
		ISC_SHOWUICANDIDATEWINDOW       	=  0x00000001,

		/// <summary>
		/// Show the composition window by user interface window.
		/// </summary>
		ISC_SHOWUICOMPOSITIONWINDOW     	=  0x80000000,

		/// <summary>
		/// Show the guide window by user interface window.
		/// </summary>
		ISC_SHOWUIGUIDELINE             	=  0x40000000
	    }
	# endregion
    }