/**************************************************************************************************************

    NAME
        WinAPI/Enums/M/MF.cs

    DESCRIPTION
        MF, MFS and MFT constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region MF_ constants
	/// <summary>
	/// Menu flag constants.
	/// </summary>
	public enum MF_Constants : ulong
	   {
		/// <summary>
		/// Places a check mark next to the item. If your application provides check-mark bitmaps (see the SetMenuItemBitmaps function), 
		/// this flag displays a selected bitmap next to the menu item. 
		/// </summary>
		MFS_CHECKED         		=  MF_CHECKED,

		/// <summary>
		/// Specifies that the menu item is the default. A menu can contain only one default menu item, which is displayed in bold.
		/// </summary>
		MFS_DEFAULT         		=  MF_DEFAULT,

		/// <summary>
		/// Disables the menu item so that it cannot be selected, but this flag does not gray it. 
		/// </summary>
		MFS_DISABLED        		=  MFS_GRAYED,

		/// <summary>
		/// Enables the menu item so that it can be selected and restores it from its grayed state. 
		/// </summary>
		MFS_ENABLED         		=  MF_ENABLED,

		/// <summary>
		/// Disables the menu item and grays it so that it cannot be selected. 
		/// </summary>
		MFS_GRAYED          		=  0x00000003L,

		/// <summary>
		/// Highlights the menu item.
		/// </summary>
		MFS_HILITE          		=  MF_HILITE,

		/// <summary>
		/// Does not place a check mark next to the item (the default). If your application supplies check-mark bitmaps 
		/// (see the SetMenuItemBitmaps function), this flag displays a clear bitmap next to the menu item. 		
		/// </summary>
		MFS_UNCHECKED       		=  MF_UNCHECKED,

		/// <summary>
		/// Removes the highlight from the menu item. This is the default state.
		/// </summary>
		MFS_UNHILITE        		=  MF_UNHILITE,

		/// <summary>
		/// Uses a bitmap as the menu item. The lpNewItem parameter contains a handle to the bitmap. 
		/// </summary>
		MFT_BITMAP          		=  MF_BITMAP,

		/// <summary>
		/// User32 the same as the MF_MENUBREAK flag for a menu bar. For a drop-down menu, submenu, or shortcut menu, 
		/// the new column is separated from the old column by a vertical line. 
		/// </summary>
		MFT_MENUBARBREAK    		=  MF_MENUBARBREAK,

		/// <summary>
		/// Places the item on a new line (for menu bars) or in a new column (for a drop-down menu, submenu, or shortcut menu) 
		/// without separating columns. 
		/// </summary>
		MFT_MENUBREAK       		=  MF_MENUBREAK,

		/// <summary>
		/// Specifies that the item is an owner-drawn item. Before the menu is displayed for the first time, the window that owns the menu 
		/// receives a WM_MEASUREITEM message to retrieve the width and height of the menu item. 
		/// The WM_DRAWITEM message is then sent to the window procedure of the owner window whenever the appearance of the menu item must be updated. 
		/// </summary>
		MFT_OWNERDRAW       		=  MF_OWNERDRAW,

		/// <summary>
		/// Displays selected menu items using a radio-button mark instead of a check mark if the hbmpChecked member is NULL.
		/// </summary>
		MFT_RADIOCHECK      		=  0x00000200L,

		/// <summary>
		/// Right-justifies the menu item and any subsequent items. This value is valid only if the menu item is in a menu bar.
		/// </summary>
		MFT_RIGHTJUSTIFY    		=  MF_RIGHTJUSTIFY,

		/// <summary>
		/// Specifies that menus cascade right-to-left (the default is left-to-right). 
		/// This is used to support right-to-left languages, such as Arabic and Hebrew.
		/// </summary>
		MFT_RIGHTORDER      		=  0x00002000L,

		/// <summary>
		/// Draws a horizontal dividing line. This flag is used only in a drop-down menu, submenu, or shortcut menu. 
		/// The line cannot be grayed, disabled, or highlighted. The lpNewItem and uIDNewItem parameters are ignored. 
		/// </summary>
		MFT_SEPARATOR       		=  MF_SEPARATOR,

		/// <summary>
		/// Specifies that the menu item is a text string; the lpNewItem parameter is a pointer to the string. 
		/// </summary>
		MFT_STRING          		=  MF_STRING,

		/// <summary>
		/// Appends a menu item to a menu.
		/// </summary>
		MF_APPEND           		=  0x00000100L,

		/// <summary>
		/// Uses a bitmap as the menu item. The lpNewItem parameter contains a handle to the bitmap. 
		/// </summary>
		MF_BITMAP           		=  0x00000004L,

		/// <summary>
		/// (for functions such as ModifyMenu).
		/// Indicates that the uPosition parameter gives the identifier of the menu item. 
		/// The MF_BYCOMMAND flag is the default if neither the MF_BYCOMMAND nor MF_BYPOSITION flag is specified.
		/// </summary>
		MF_BYCOMMAND        		=  0x00000000L,

		/// <summary>
		/// (for functions such as ModifyMenu).
		/// Indicates that the uPosition parameter gives the zero-based relative position of the menu item. 
		/// </summary>
		MF_BYPOSITION       		=  0x00000400L,

		/// <summary>
		/// Change an existing menu item in a menu.
		/// </summary>
		MF_CHANGE           		=  0x00000080L,

		/// <summary>
		/// Places a check mark next to the item. If your application provides check-mark bitmaps (see the SetMenuItemBitmaps function), 
		/// this flag displays a selected bitmap next to the menu item. 
		/// </summary>
		MF_CHECKED          		=  0x00000008L,

		/// <summary>
		/// Specifies that the menu item is the default. A menu can contain only one default menu item, which is displayed in bold.
		/// </summary>
		MF_DEFAULT          		=  0x00001000L,

		/// <summary>
		/// Delete a menu item from a menu.
		/// </summary>
		MF_DELETE           		=  0x00000200L,

		/// <summary>
		/// Disables the menu item so that it cannot be selected, but this flag does not gray it. 
		/// </summary>
		MF_DISABLED         		=  0x00000002L,

		/// <summary>
		/// Enables the menu item so that it can be selected and restores it from its grayed state. 
		/// </summary>
		MF_ENABLED          		=  0x00000000L,

		/// <summary>
		/// Obsolete -- only used by old RES files
		/// </summary>
		MF_END              		=  0x00000080L, 

		/// <summary>
		/// Disables the menu item and grays it so that it cannot be selected. 
		/// </summary>
		MF_GRAYED           		=  0x00000001L,

		/// <summary>
		/// Indicates that the menu item has a vertical separator to its left.
		/// </summary>
		MF_HELP             		=  0x00004000L,

		/// <summary>
		/// Highlights the menu item.
		/// </summary>
		MF_HILITE           		=  0x00000080L,

		/// <summary>
		/// Inserts a menu item in a menu.
		/// </summary>
		MF_INSERT           		=  0x00000000L,

		/// <summary>
		/// User32 the same as the MF_MENUBREAK flag for a menu bar. For a drop-down menu, submenu, or shortcut menu, 
		/// the new column is separated from the old column by a vertical line. 
		/// </summary>
		MF_MENUBARBREAK     		=  0x00000020L,

		/// <summary>
		/// Places the item on a new line (for menu bars) or in a new column (for a drop-down menu, submenu, or shortcut menu) 
		/// without separating columns. 
		/// </summary>
		MF_MENUBREAK        		=  0x00000040L,

		/// <summary>
		/// : Item is selected with the mouse
		/// </summary>
		MF_MOUSESELECT      		=  0x00008000L,

		/// <summary>
		/// Specifies that the item is an owner-drawn item. Before the menu is displayed for the first time, the window that owns the menu 
		/// receives a WM_MEASUREITEM message to retrieve the width and height of the menu item. 
		/// The WM_DRAWITEM message is then sent to the window procedure of the owner window whenever the appearance of the menu item must be updated. 
		/// </summary>
		MF_OWNERDRAW        		=  0x00000100L,

		/// <summary>
		/// Specifies that the menu item opens a drop-down menu or submenu. The uIDNewItem parameter specifies a handle to 
		/// the drop-down menu or submenu. 
		/// This flag is used to add a menu name to a menu bar or a menu item that opens a submenu to a drop-down menu, submenu, or shortcut menu. 
		/// </summary>
		MF_POPUP            		=  0x00000010L,

		/// <summary>
		/// Removes a menu item.
		/// </summary>
		MF_REMOVE           		=  0x00001000L,

		/// <summary>
		/// Right-justifies the menu item and any subsequent items. This value is valid only if the menu item is in a menu bar.
		/// </summary>
		MF_RIGHTJUSTIFY     		=  0x00004000L,

		/// <summary>
		/// Draws a horizontal dividing line. This flag is used only in a drop-down menu, submenu, or shortcut menu. 
		/// The line cannot be grayed, disabled, or highlighted. The lpNewItem and uIDNewItem parameters are ignored. 
		/// </summary>
		MF_SEPARATOR        		=  0x00000800L,

		/// <summary>
		/// Specifies that the menu item is a text string; the lpNewItem parameter is a pointer to the string. 
		/// </summary>
		MF_STRING           		=  0x00000000L,

		/// <summary>
		/// Item is contained in the window menu.
		/// </summary>
		MF_SYSMENU          		=  0x00002000L,

		/// <summary>
		/// Does not place a check mark next to the item (the default). If your application supplies check-mark bitmaps 
		/// (see the SetMenuItemBitmaps function), this flag displays a clear bitmap next to the menu item. 
		/// </summary>
		MF_UNCHECKED        		=  0x00000000L,

		/// <summary>
		/// Removes the highlight from the menu item. This is the default state.
		/// </summary>
		MF_UNHILITE         		=  0x00000000L,

		/// <summary>
		/// Undocumented.
		/// </summary>
		MF_USECHECKBITMAPS  		=  0x00000200L,

		/// <summary>
		/// Zero value.
		/// </summary>
		MF_NONE				=  0x00000000L
	    }
	# endregion
    }