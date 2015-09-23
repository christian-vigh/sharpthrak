/**************************************************************************************************************

    NAME
        WinAPI/Constants/I/IDC.cs

    DESCRIPTION
        Stocked cursors resource identifiers.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region IDC_ cursor ids
	/// <summary>
	/// Stocked cursors resource identifiers.
	/// </summary>
	public enum IDC_Constants		:  int
	   {
		/// <summary>
		/// Standard arrow and small hourglass cursor.
		/// </summary>
		IDC_APPSTARTING     		=  32650,

		/// <summary>
		/// Standard arrow cursor.
		/// </summary>
		IDC_ARROW           		=  32512,

		/// <summary>
		/// Crosshair cursor.
		/// </summary>
		IDC_CROSS           		=  32515,

		/// <summary>
		/// Hand cursor.
		/// </summary>
		IDC_HAND            		=  32649,

		/// <summary>
		/// Arrow and question mark cursor.
		/// </summary>
		IDC_HELP            		=  32651,

		/// <summary>
		/// I-beam cursor.
		/// </summary>
		IDC_IBEAM           		=  32513,

		/// <summary>
		/// Standard arrow cursor. Obsolete : use IDC_ARROW instead.
		/// </summary>
		IDC_ICON            		=  32641,

		/// <summary>
		/// Slashed circle cursor.
		/// </summary>
		IDC_NO              		=  32648,

		/// <summary>
		/// Four-pointed arrow cursor pointing north, south, east, and west. Obsolete : use IDC_SIZEALL instead.
		/// </summary>
		IDC_SIZE            		=  32640,

		/// <summary>
		/// Four-pointed arrow cursor pointing north, south, east, and west.
		/// </summary>
		IDC_SIZEALL         		=  32646,

		/// <summary>
		/// Double-pointed arrow cursor pointing northeast and southwest.
		/// </summary>
		IDC_SIZENESW        		=  32643,

		/// <summary>
		/// Double-pointed arrow cursor pointing north and south.
		/// </summary>
		IDC_SIZENS          		=  32645,

		/// <summary>
		/// Double-pointed arrow cursor pointing northwest and southeast.
		/// </summary>
		IDC_SIZENWSE        		=  32642,

		/// <summary>
		/// Double-pointed arrow cursor pointing west and east.
		/// </summary>
		IDC_SIZEWE          		=  32644,

		/// <summary>
		/// Vertical arrow cursor.
		/// </summary>
		IDC_UPARROW         		=  32516,

		/// <summary>
		/// Hourglass cursor.
		/// </summary>
		IDC_WAIT            		=  32514
	    }
	# endregion
    }
