/**************************************************************************************************************

    NAME
        WinAPI/Enums/D/DCX.cs

    DESCRIPTION
        DCX constants.

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
	# region DCX_ constants
	/// <summary>
	/// GetDCEx flags.
	/// </summary>
	public enum DCX_Constants : ulong
	   {
		/// <summary>
		/// Returns a DC that corresponds to the window rectangle rather than the client rectangle.
		/// </summary>
		DCX_WINDOW           	=  0x00000001L,

		/// <summary>
		/// Returns a DC from the cache, rather than the OWNDC or CLASSDC window. Essentially overrides CS_OWNDC and CS_CLASSDC.
		/// </summary>
		DCX_CACHE            	=  0x00000002L,

		/// <summary>
		/// Does not reset the attributes of this DC to the default attributes when this DC is released.
		/// </summary>
		DCX_NORESETATTRS     	=  0x00000004L,

		/// <summary>
		/// Excludes the visible regions of all child windows below the window identified by hWnd.
		/// </summary>
		DCX_CLIPCHILDREN     	=  0x00000008L,

		/// <summary>
		/// Excludes the visible regions of all sibling windows above the window identified by hWnd.
		/// </summary>
		DCX_CLIPSIBLINGS     	=  0x00000010L,

		/// <summary>
		/// Uses the visible region of the parent window. The parent's WS_CLIPCHILDREN and CS_PARENTDC style bits are ignored. 
		/// The origin is set to the upper-left corner of the window identified by hWnd.
		/// </summary>
		DCX_PARENTCLIP       	=  0x00000020L,

		/// <summary>
		/// The clipping region identified by hrgnClip is excluded from the visible region of the returned DC.
		/// </summary>
		DCX_EXCLUDERGN       	=  0x00000040L,

		/// <summary>
		/// The clipping region identified by hrgnClip is intersected with the visible region of the returned DC.
		/// </summary>
		DCX_INTERSECTRGN     	=  0x00000080L,

		/// <summary>
		/// Reserved; do not use.
		/// </summary>
		DCX_EXCLUDEUPDATE    	=  0x00000100L,

		/// <summary>
		/// Reserved; do not use.
		/// </summary>
		DCX_INTERSECTUPDATE  	=  0x00000200L,

		/// <summary>
		/// Allows drawing even if there is a LockWindowUpdate call in effect that would otherwise exclude this window. Used for drawing during tracking.
		/// </summary>
		DCX_LOCKWINDOWUPDATE 	=  0x00000400L,

		/// <summary>
		/// Reserved; do not use.
		/// </summary>
		DCX_VALIDATE         	=  0x00200000L
	    }
	# endregion
    }