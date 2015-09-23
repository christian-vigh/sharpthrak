/**************************************************************************************************************

    NAME
        WinAPI/Constants/S/SIZE.cs

    DESCRIPTION
        SIZE constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region SIZE_ constants from WM_SIZE messages
	/// <summary>
	/// WM_SIZE message wParam values.
	/// </summary>
	public enum SIZE_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		SIZE_NONE		=  0,

		/// <summary>
		/// Message is sent to all pop-up windows when some other window is maximized.
		/// </summary>
		SIZE_MAXHIDE		=  4,

		/// <summary>
		/// The window has been maximized.
		/// </summary>
		SIZE_MAXIMIZED		=  2,

		/// <summary>
		/// Message is sent to all pop-up windows when some other window has been restored to its former size.
		/// </summary>
		SIZE_MAXSHOW		=  3,

		/// <summary>
		/// The window has been minimized.
		/// </summary>
		SIZE_MINIMIZED		=  1,

		/// <summary>
		/// The window has been resized, but neither the SIZE_MINIMIZED nor SIZE_MAXIMIZED value applies.
		/// </summary>
		SIZE_RESTORED		=  0,
		
		/// <summary>
		/// The window has been resized, but neither the SIZE_MINIMIZED nor SIZE_MAXIMIZED value applies. 
		/// <para>
		/// Obsolete value, same as SIZE_RESTORED.
		/// </para>
		/// </summary>
		SIZENORMAL		=  SIZE_RESTORED,

		/// <summary>
		/// The window has been minimized.
		/// <para>
		/// Obsolete value, same as SIZE_MINIMIZED.
		/// </para>
		/// </summary>
		SIZEICONIC		=  SIZE_MINIMIZED,

		/// <summary>
		/// The window has been minimized.
		/// <para>
		/// Obsolete value, same as SIZE_MAXIMIZED.
		/// </para>
		/// </summary>
		SIZEFULLSCREEN		=  SIZE_MAXIMIZED,

		/// <summary>
		/// Message is sent to all pop-up windows when some other window has been restored to its former size.
		/// <para>
		/// Obsolete value, same as SIZE_MAXSHOW.
		/// </para>
		/// </summary>
		SIZEZOOMSHOW		=  SIZE_MAXSHOW,

		/// <summary>
		/// Message is sent to all pop-up windows when some other window is maximized.
		/// <para>
		/// Obsolete value, same as SIZE_MAXHIDE.
		/// </para>
		/// </summary>
		SIZEZOOMHIDE		=  SIZE_MAXHIDE	    
	    }
	# endregion
    }