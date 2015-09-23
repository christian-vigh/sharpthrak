/**************************************************************************************************************

    NAME
        WinAPI/Enums/P/PRF.cs

    DESCRIPTION
        PRF constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region PRF_ constants
	/// <summary>
	/// Flags for the WM_PRINT message.
	/// </summary>
	public enum PRF_Constants : ulong
	   {
		/// <summary>
		/// Draws the window only if it is visible.
		/// </summary>
		PRF_CHECKVISIBLE		=  0x00000001L,

		/// <summary>
		/// Draws all visible children windows.
		/// </summary>
		PRF_CHILDREN			=  0x00000010L,

		/// <summary>
		/// Draws the client area of the window.
		/// </summary>
		PRF_CLIENT			=  0x00000004L,

		/// <summary>
		/// Erases the background before drawing the window.
		/// </summary>
		PRF_ERASEBKGND			=  0x00000008L,

		/// <summary>
		/// Draws the nonclient area of the window.
		/// </summary>
		PRF_NONCLIENT			=  0x00000002L,

		/// <summary>
		/// Draws all owned windows.
		/// </summary>
		PRF_OWNED			=  0x00000020L
	    }
	# endregion
    }