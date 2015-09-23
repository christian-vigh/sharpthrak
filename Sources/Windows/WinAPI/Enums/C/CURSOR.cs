/**************************************************************************************************************

    NAME
        WinAPI/Constants/C/CURSOR.cs

    DESCRIPTION
        Cursor information constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region CURSOR_ constants
	/// <summary>
	/// Cursor information constants.
	/// </summary>
	public enum CURSOR_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		CURSOR_NONE			=  0,

		/// <summary>
		/// The cursor is hidden.
		/// </summary>
		CURSOR_HIDDEN			=  0,

		/// <summary>
		/// The cursor is showing.
		/// </summary>
		CURSOR_SHOWING			=  1,

		/// <summary>
		/// Windows 8: The cursor is suppressed. 
		/// <para>
		/// This flag indicates that the system is not drawing the cursor because the user is providing input through touch or pen instead of the mouse.
		/// </para>
		/// </summary>
		CURSOR_SUPPRESSED		=  2
	    }
	# endregion
    }