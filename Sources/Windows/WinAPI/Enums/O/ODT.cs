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

	# region ODT_ Owner-draw control type constants
	/// <summary>
	/// Owner-draw control type constants.
	/// </summary>
	public enum ODT_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		ODT_NONE		=  0,

		/// <summary>
		/// Owner-drawn menu.
		/// </summary>
		ODT_MENU		=  1,

		/// <summary>
		/// Owner-drawn listbox.
		/// </summary>
		ODT_LISTBOX		=  2,

		/// <summary>
		/// Owner-drawn combobox.
		/// </summary>
		ODT_COMBOBOX		=  3,

		/// <summary>
		/// Owner-drawn button.
		/// </summary>
		ODT_BUTTON		=  4,

		/// <summary>
		/// Owner-drawn static.
		/// </summary>
		ODT_STATIC		=  5,

		/// <summary>
		/// Owner-drawn header control.
		/// </summary>
		ODT_HEADER              =  100,

		/// <summary>
		/// Owner-drawn tab control.
		/// </summary>
		ODT_TAB                 =  101,

		/// <summary>
		/// Owner-drawn listview control.
		/// </summary>
		ODT_LISTVIEW            =  102
	    }
	# endregion
   }