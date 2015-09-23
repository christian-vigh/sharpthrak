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

 	# region ODS_ Owner-draw control style constants
	/// <summary>
	/// Owner-draw control control style constants.
	/// </summary>
	public enum ODS_Constants : ushort
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		ODS_NONE		=  0x0000,

		/// <summary>
		/// The menu item is to be checked. This bit is used only in a menu.
		/// </summary>
		 ODS_CHECKED		=  0x0008,

		 /// <summary>
		 /// The drawing takes place in the selection field (edit control) of an owner-drawn combo box.
		 /// </summary>
		 ODS_COMBOBOXEDIT	=  0x1000,

		 /// <summary>
		 /// The item is the default item.
		 /// </summary>
		 ODS_DEFAULT		=  0x0020,

		 /// <summary>
		 /// The item is to be drawn as disabled.
		 /// </summary>
		 ODS_DISABLED		=  0x0004,

		 /// <summary>
		 /// The item has the keyboard focus.
		 /// </summary>
		 ODS_FOCUS		=  0x0010,

		 /// <summary>
		 /// The item is to be grayed. This bit is used only in a menu.
		 /// </summary>
		 ODS_GRAYED		=  0x0002,

		 /// <summary>
		 /// Windows 98/Me, Windows 2000/XP: The item is being hot-tracked, that is, the item will be highlighted when the mouse is on the item.
		 /// </summary>
		 ODS_HOTLIGHT		=  0x0040,

		 /// <summary>
		 /// Windows 98/Me, Windows 2000/XP: The item is inactive and the window associated with the menu is inactive.
		 /// </summary>
		 ODS_INACTIVE		=  0x0080,

		 /// <summary>
		 /// Windows 2000/XP: The control is drawn without the keyboard accelerator cues.
		 /// </summary>
		 ODS_NOACCEL		=  0x0100,

		 /// <summary>
		 /// Windows 2000/XP: The control is drawn without focus indicator cues.
		 /// </summary>
		 ODS_NOFOCUSRECT	=  0x0200,

		 /// <summary>
		 /// The menu item's status is selected.
		 /// </summary>
		 ODS_SELECTED		=  0x0001
	    }
	# endregion
    }