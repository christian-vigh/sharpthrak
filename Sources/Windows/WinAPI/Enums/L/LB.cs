/**************************************************************************************************************

    NAME
        WinAPI/Enums/L/LB.cs

    DESCRIPTION
        LB constants.

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
	# region LB_ constants
	/// <summary>
	/// Listbox message constants.
	/// </summary>
	public enum LB_Constants : int
	   {
		# region LB_ADDFILE
		/// <summary>
		/// Adds the specified filename to a list box that contains a directory listing. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM>A pointer to a buffer that specifies the name of the file to add. </LPARAM>
		/// <LRESULT>The return value is the zero-based index of the file that was added, or LB_ERR if an error occurs. </LRESULT>
		/// 
		/// <remarks>
		/// The list box to which lParam is added must have been filled by the DlgDirList function. 
		/// The LB_INITSTORAGE message helps speed up the initialization of list boxes that have a large number of items (more than 100). 
		/// It reserves the specified amount of memory so that subsequent LB_ADDFILE messages take the shortest possible time. 
		/// You can use estimates for the wParam and lParam parameters. If you overestimate, the extra memory is allocated; if you underestimate, 
		/// the normal allocation is used for items that exceed the requested amount. 
		/// Microsoft Windows NT/Windows 2000/Windows XP : For an ANSI application, the system converts the text in a list box to Unicode using CP_ACP. 
		/// This can cause problems. For example, accented Roman characters in a non-Unicode list box in Japanese Windows will come out garbled. 
		/// To fix this, either compile the application as Unicode or use an owner-drawn list box.
		/// </remarks>
		LB_ADDFILE              	=  0x0196,
		# endregion

		# region LB_ADDSTRING
		/// <summary>
		/// Adds a string to a list box. If the list box does not have the LBS_SORT style, the string is added to the end of the list.
		/// Otherwise, the string is inserted into the list and the list is sorted. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used. </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string that is to be added. 
		/// If the list box has an owner-drawn style but not the LBS_HASSTRINGS style, this parameter is stored as item data instead of a string. 
		/// You can send the LB_GETITEMDATA and LB_SETITEMDATA messages to retrieve or modify the item data.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the zero-based index of the string in the list box. If an error occurs, the return value is LB_ERR. 
		/// If there is insufficient space to store the new string, the return value is LB_ERRSPACE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the list box has an owner-drawn style and the LBS_SORT style, but not the LBS_HASSTRINGS style, the system sends the WM_COMPAREITEM message 
		/// one or more times to the owner of the list box to place the new item properly in the list box. 
		/// The LB_INITSTORAGE message helps speed up the initialization of list boxes that have a large number of items (more than 100). 
		/// It reserves the specified amount of memory so that subsequent LB_ADDSTRING messages take the shortest possible time. You can use estimates 
		/// for the wParam and lParam parameters. If you overestimate, the extra memory is allocated; if you underestimate, the normal allocation is used 
		/// for items that exceed the requested amount. 
		/// If the list box has the WS_HSCROLL style and you add a string wider than the list box, send an LB_SETHORIZONTALEXTENT message to ensure 
		/// the horizontal scroll bar appears.
		/// Microsoft Windows NT/Windows 2000/Windows XP : For an ANSI application, the system converts the text in a list box to Unicode using CP_ACP. 
		/// This can cause problems. For example, accented Roman characters in a non-Unicode list box in Japanese Windows will come out garbled. 
		/// To fix this, either compile the application as Unicode or use an owner-drawn list box.
		/// </remarks>
		LB_ADDSTRING            	=  0x0180,
		# endregion

		# region LB_DELETESTRING
		/// <summary>
		/// Deletes a string in a list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the string to be deleted. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, 
		/// the total size in bytes of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is a count of the strings remaining in the list. 
		/// The return value is LB_ERR if the wParam parameter specifies an index greater than the number of items in the list. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If an application creates the list box with an owner-drawn style but without the LBS_HASSTRINGS style, the system sends a WM_DELETEITEM message 
		/// to the owner of the list box so the application can free any additional data associated with the item. 
		/// </remarks>
		LB_DELETESTRING         	=  0x0182,
		# endregion

		# region LB_DIR
		/// <summary>
		/// Adds names to the list displayed by a list box. The message adds the names of directories and files that match a specified string and set of file attributes. 
		/// LB_DIR can also add mapped drive letters to the list box.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The attributes of the files or directories to be added to the list box. This parameter can be one or more of the DDL_Constants values. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string that specifies an absolute path, relative path, or filename. 
		/// An absolute path can begin with a drive letter (for example, d:\) or a UNC name (for example, \\ machinename\ sharename). 
		/// If the string specifies a filename or directory that has the attributes specified by the wParam parameter, the filename or directory 
		/// is added to the list. If the filename or directory name contains wildcard characters (? or *), all files or directories that match 
		/// the wildcard expression and have the attributes specified by the wParam parameter are added to the list.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is the zero-based index of the last name added to the list. 
		/// If an error occurs, the return value is LB_ERR. If there is insufficient space to store the new strings, the return value is LB_ERRSPACE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The LB_INITSTORAGE message helps speed up the initialization of list boxes that have a large number of items (more than 100). 
		/// It reserves the specified amount of memory so that subsequent LB_DIR messages take the shortest possible time. 
		/// You can use estimates for the wParam and lParam parameters. If you overestimate, the extra memory is allocated; if you underestimate, 
		/// the normal allocation is used for items that exceed the requested amount. 
		/// 
		/// Microsoft Windows NT 4.0 and later: 
		///	If wParam includes the DDL_DIRECTORY flag and lParam specifies all the subdirectories of a first-level directory, such as C:\TEMP\*, 
		///	the list box will always include a ".." entry for the root directory. 
		///	This is true even if the root directory has hidden or system attributes and the DDL_HIDDEN and DDL_SYSTEM flags are not specified. 
		///	The root directory of an NTFS volume has hidden and system attributes. 
		/// Microsoft Windows NT/Windows 2000/Windows XP : 
		///	The list displays long filenames, if any.
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) :
		///	The list displays short filenames (the 8.3 form). You can use the SHGetFileInfo or GetFullPathName functions to get the corresponding long filename.
		/// Windows NT/Windows 2000/Windows XP : 
		///	For an ANSI application, the system converts the text in a list box to Unicode using CP_ACP. This can cause problems. 
		///	For example, accented Roman characters in a non-Unicode list box in Japanese Windows will come out garbled. 
		///	To fix this, either compile the application as Unicode or use an owner-drawn list box.
		/// </remarks>
		LB_DIR                  	=  0x018D,
		# endregion

		# region LB_FINDSTRING
		/// <summary>
		/// Finds the first string in a list box that begins with the specified string. 
		/// </summary>
		///
		/// <WPARAM>
		/// The zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues searching 
		/// from the top of the list box back to the item specified by the wParam parameter. If wParam is –1, the entire list box is searched from the beginning. 
		/// 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. This means list boxes cannot contain 
		/// more than 32,767 items. Although the number of items is restricted, the total size in bytes of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string that contains the string for which to search. 
		/// The search is case independent, so this string can contain any combination of uppercase and lowercase letters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the index of the matching item, or LB_ERR if the search was unsuccessful. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the list box has the owner-drawn style but not the LBS_HASSTRINGS style, the action taken by LB_FINDSTRING depends on whether the LBS_SORT style is used. 
		/// If LBS_SORT is used, the system sends WM_COMPAREITEM messages to the list box owner to determine which item matches the specified string. 
		/// Otherwise, LB_FINDSTRING attempts to find an item that has a long value (supplied as the lParam parameter of the LB_ADDSTRING or LB_INSERTSTRING message) 
		/// that matches the lParam parameter. 
		/// </remarks>
		LB_FINDSTRING           	=  0x018F,
		# endregion

		# region LB_FINDSTRINGEXACT
		/// <summary>
		/// Finds the first list box string that exactly matches the specified string, except that the search is not case sensitive. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues searching 
		/// from the top of the list box back to the item specified by the wParam parameter. If wParam is – 1, the entire list box is searched from the beginning. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. This means list boxes cannot contain 
		/// more than 32,767 items. Although the number of items is restricted, the total size in bytes of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string for which to search. T
		/// he search is not case sensitive, so this string can contain any combination of uppercase and lowercase letters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the zero-based index of the matching item, or LB_ERR if the search was unsuccessful. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This function is only successful if the specified string and a list box item have the same length (except for the null at the end of the specified string) 
		/// and have exactly the same characters.
		/// If the list box has the owner-drawn style but not the LBS_HASSTRINGS style, the action taken by LB_FINDSTRINGEXACT depends on whether the LBS_SORT style 
		/// is used. If LBS_SORT is used, the system sends WM_COMPAREITEM messages to the list box owner to determine which item matches the specified string. 
		/// Otherwise, LB_FINDSTRINGEXACT attempts to find an item that has a long value (supplied as the lParam parameter of the LB_ADDSTRING or LB_INSERTSTRING message) 
		/// that matches the lParam parameter. 
		/// </remarks>
		LB_FINDSTRINGEXACT      	=  0x01A2,
		# endregion

		# region LB_GETANCHORINDEX
		/// <summary>
		/// Gets the index of the anchor item—that is, the item from which a multiple selection starts. 
		/// A multiple selection spans all items from the anchor item to the caret item.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>The return value is the index of the anchor item.</LRESULT>
		LB_GETANCHORINDEX       	=  0x019D,
		# endregion

		# region LB_GETCARETINDEX
		/// <summary>
		/// Retrieves the index of the item that has the focus in a multiple-selection list box. The item may or may not be selected. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>The return value is the zero-based index of the focused list box item, or 0 if no item has the focus.</LRESULT>
		/// 
		/// <remarks>This message can also be used to get the index of the item that is currently selected in a single-selection list box.</remarks>
		LB_GETCARETINDEX        	=  0x019F,
		# endregion

		# region LB_GETCOUNT
		/// <summary>
		/// Gets the number of items in a list box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>The return value is the number of items in the list box, or LB_ERR if an error occurs.</LRESULT>
		/// 
		/// <remarks>The returned count is one greater than the index value of the last item (the index is zero-based). </remarks>
		LB_GETCOUNT             	=  0x018B,
		# endregion

		# region LB_GETCURSEL
		/// <summary>
		/// Gets the index of the currently selected item, if any, in a single-selection list box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// In a single-selection list box, the return value is the zero-based index of the currently selected item. 
		/// If there is no selection, the return value is LB_ERR.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// To retrieve the indexes of the selected items in a multiple-selection list box, use the LB_GETSELITEMS message. 
		/// To determine whether the item that has the focus rectangle in a multiple selection list box is selected, use the LB_GETSEL message. 
		/// If sent to a multiple-selection list box, LB_GETCURSEL returns the index of the item that has the focus rectangle. If no items are selected, it returns zero.
		/// </remarks>
		LB_GETCURSEL            	=  0x0188,
		# endregion

		# region LB_GETHORIZONTALEXTENT
		/// <summary>
		/// Gets the width, in pixels, that a list box can be scrolled horizontally (the scrollable width) if the list box has a horizontal scroll bar. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>The return value is the number of items in the list box, or LB_ERR if an error occurs.</LRESULT>
		/// 
		/// <remarks>
		/// To respond to the LB_GETHORIZONTALEXTENT message, the list box must have been defined with the WS_HSCROLL style. 
		/// If the application does not set the horizontal extent of the list box (using LB_SETHORIZONTALEXTENT), the default horizontal extent is zero. 
		/// Note that the list box does not update its horizontal extent dynamically.
		/// </remarks>
		LB_GETHORIZONTALEXTENT  	=  0x0193,
		# endregion

		# region LB_GETITEMDATA
		/// <summary>
		/// Gets the application-defined value associated with the specified list box item. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The index of the item. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes of the items 
		/// in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the value associated with the item, or LB_ERR if an error occurs. If the item is in an owner-drawn list box 
		/// and was created without the LBS_HASSTRINGS style, this value was in the lParam parameter of the LB_ADDSTRING or LB_INSERTSTRING message
		/// that added the item to the list box. Otherwise, it is the value in the lParam of the LB_SETITEMDATA message. 
		/// </LRESULT>
		LB_GETITEMDATA          	=  0x0199,
		# endregion

		# region LB_GETITEMHEIGHT
		/// <summary>
		/// Gets the height of items in a list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the list box item. This index is used only if the list box has the LBS_OWNERDRAWVARIABLE style; otherwise, it must be zero. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me): The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes of the items 
		/// in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LRESULT>The return value is the number of items in the list box, or LB_ERR if an error occurs.</LRESULT>
		LB_GETITEMHEIGHT        	=  0x01A1,
		# endregion

		# region LB_GETITEMRECT
		/// <summary>
		/// Gets the dimensions of the rectangle that bounds a list box item as it is currently displayed in the list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>A pointer to a RECT structure that will receive the client coordinates for the item in the list box. </LPARAM>
		/// 
		/// <LRESULT>If an error occurs, the return value is LB_ERR. </LRESULT>
		LB_GETITEMRECT          	=  0x0198,
		# endregion

		# region LB_GETLISTBOXINFO
		/// <summary>
		/// Gets the number of items per column in a specified list box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used; it must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used; it must be zero. </LPARAM>
		///
		/// <LRESULT>The return value is the number of items per column. </LRESULT>
		/// 
		/// <remarks>This message is equivalent to GetListBoxInfo().</remarks>
		LB_GETLISTBOXINFO       	=  0x01B2,
		# endregion

		# region LB_GETLOCALE
		/// <summary>
		/// Gets the current locale of the list box. You can use the locale to determine the correct sorting order of displayed text 
		/// (for list boxes with the LBS_SORT style) and of text added by the LB_ADDSTRING message. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used; it must be zero.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used; it must be zero. </LPARAM>
		///
		/// <LRESULT>
		/// The return value specifies the current locale of the list box. The HIWORD contains the country/region code and the LOWORD contains the language identifier. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The language identifier consists of a sublanguage identifier and a primary language identifier. 
		/// Use the PRIMARYLANGID macro to extract the primary language identifier from the LOWORD of the return value, and the SUBLANGID macro 
		/// to extract the sublanguage identifier. 
		/// </remarks>
		LB_GETLOCALE            	=  0x01A6,
		# endregion

		# region LB_GETSEL
		/// <summary>
		/// Gets the selection state of an item. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		LB_GETSEL               	=  0x0187,
		# endregion

		# region LB_GETSELCOUNT
		/// <summary>
		/// Gets the total number of selected items in a multiple-selection list box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>The return value is the count of selected items in the list box. If the list box is a single-selection list box, the return value is LB_ERR. </LRESULT>
		LB_GETSELCOUNT          	=  0x0190,
		# endregion

		# region LB_GETSELITEMS
		/// <summary>
		/// Fills a buffer with an array of integers that specify the item numbers of selected items in a multiple-selection list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The maximum number of selected items whose item numbers are to be placed in the buffer. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a buffer large enough for the number of integers specified by the wParam parameter. 
		/// </LPARAM>
		/// 
		/// <LRESULT>The return value is the number of items placed in the buffer. If the list box is a single-selection list box, the return value is LB_ERR. </LRESULT>
		LB_GETSELITEMS          	=  0x0191,
		# endregion

		# region LB_GETTEXT
		/// <summary>
		/// Gets a string from a list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the string to retrieve. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the buffer that will receive the string; it is type LPTSTR which is subsequently cast to an LPARAM. 
		/// The buffer must have sufficient space for the string and a terminating null character. 
		/// An LB_GETTEXTLEN message can be sent before the LB_GETTEXT message to retrieve the length, in TCHARs, of the string. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the length of the string, in TCHARs, excluding the terminating null character. 
		/// If wParam does not specify a valid index, the return value is LB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the list box has an owner-drawn style but not the LBS_HASSTRINGS style, the buffer pointed to by the lParam parameter receives 
		/// the value associated with the item (the item data). 
		/// </remarks>
		LB_GETTEXT              	=  0x0189,
		# endregion

		# region LB_GETTEXTLEN
		/// <summary>
		/// Gets the length of a string in a list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the string. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the length of the string, in TCHARs, excluding the terminating null character. 
		/// Under certain conditions, this value may actually be greater than the length of the text.
		/// If the wParam parameter does not specify a valid index, the return value is LB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Under certain conditions, the return value is larger than the actual length of the text. This occurs with certain mixtures of ANSI and Unicode, 
		/// and is due to the operating system allowing for the possible existence of double-byte character set (DBCS) characters within the text. 
		/// The return value, however, will always be at least as large as the actual length of the text; you can thus always use it to guide buffer allocation. 
		/// This behavior can occur when an application uses both ANSI functions and common dialogs, which use Unicode. 
		/// To obtain the exact length of the text, use the WM_GETTEXT, LB_GETTEXT, or CB_GETLBTEXT messages, or the GetWindowText function.
		/// If the list box has an owner-drawn style, but not the LBS_HASSTRINGS style, the return value is always the size, in bytes, of a DWORD.
		/// </remarks>
		LB_GETTEXTLEN           	=  0x018A,
		# endregion

		# region LB_GETTOPINDEX
		/// <summary>
		/// Gets the index of the first visible item in a list box. Initially the item with index 0 is at the top of the list box, but if the list box contents 
		/// have been scrolled another item may be at the top. The first visible item in a multiple-column list box is the top-left item. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero. </WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>The return value is the index of the first visible item in the list box. </LRESULT>
		LB_GETTOPINDEX          	=  0x018E,
		# endregion

		# region LB_INITSTORAGE
		/// <summary>
		/// Allocates memory for storing list box items. This message is used before an application adds a large number of items to a list box.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The number of items to add. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>The amount of memory, in bytes, to allocate for item strings. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, the return value is the total number of items for which memory has been pre-allocated, that is, 
		/// the total number of items added by all successful LB_INITSTORAGE messages.
		/// If the message fails, the return value is LB_ERRSPACE. 
		/// Microsoft Windows NT 4.0 : This message does not allocate the specified amount of memory; however, it always returns the value specified in the wParam parameter.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The LB_INITSTORAGE message helps speed up the initialization of list boxes that have a large number of items (more than 100). 
		/// It reserves the specified amount of memory so that subsequent LB_ADDSTRING, LB_INSERTSTRING, LB_DIR, and LB_ADDFILE messages take the shortest possible time. 
		/// You can use estimates for the wParam and lParam parameters. If you overestimate, the extra memory is allocated; 
		/// if you underestimate, the normal allocation is used for items that exceed the requested amount. 
		/// </remarks>
		LB_INITSTORAGE          	=  0x01A8,
		# endregion

		# region LB_INSERTSTRING
		/// <summary>
		/// Inserts a string or item data into a list box. Unlike the LB_ADDSTRING message, the LB_INSERTSTRING message does not cause a list with the LBS_SORT style 
		/// to be sorted. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the position at which to insert the string. If this parameter is –1, the string is added to the end of the list. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. This means list boxes 
		/// cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes of the items in a list box is 
		/// limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string to be inserted. If the list box has an owner-drawn style but not the LBS_HASSTRINGS style, 
		/// this parameter is stored as item data instead of a string. You can send the LB_GETITEMDATA and LB_SETITEMDATA messages to retrieve or modify the item data. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the index of the position at which the string was inserted. If an error occurs, the return value is LB_ERR. 
		/// If there is insufficient space to store the new string, the return value is LB_ERRSPACE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The LB_INITSTORAGE message helps speed up the initialization of list boxes that have a large number of items (more than 100). 
		/// It reserves the specified amount of memory so that subsequent LB_INSERTSTRING messages take the shortest possible time. 
		/// You can use estimates for the wParam and lParam parameters. If you overestimate, the extra memory is allocated; 
		/// if you underestimate, the normal allocation is used for items that exceed the requested amount. 
		/// If the list box has WS_HSCROLL style and you insert a string wider than the list box, send an LB_SETHORIZONTALEXTENT message to ensure 
		/// the horizontal scroll bar appears.
		/// Microsoft Windows NT/Windows 2000/Windows XP : For an ANSI application, the system converts the text in a list box to Unicode using CP_ACP. 
		/// This can cause problems. For example, accented Roman characters in a non-Unicode list box in Japanese Windows will come out garbled. 
		/// To fix this, either compile the application as Unicode or use an owner-drawn list box.
		/// </remarks>
		LB_INSERTSTRING         	=  0x0181,
		# endregion

		# region LB_ITEMFROMPOINT
		/// <summary>
		/// Gets the zero-based index of the item nearest the specified point in a list box.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM class="LB_ITEMFROMPOINT_WPARAM">
		/// The LOWORD specifies the x-coordinate of a point, relative to the upper-left corner of the client area of the list box. 
		/// The HIWORD specifies the y-coordinate of a point, relative to the upper-left corner of the client area of the list box.
		/// </LPARAM>
		LB_ITEMFROMPOINT        	=  0x01A9,
		# endregion

		# region LB_MULTIPLEADDSTRING
		/// <summary>
		/// Undocumented. Seems to be a fast way to add strings in a listbox.
		/// </summary>
		LB_MULTIPLEADDSTRING    	=  0x01B1,
		# endregion

		# region LB_RESETCONTENT
		/// <summary>
		/// Removes all items from a list box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero.</LPARAM>
		/// <LRESULT>This message does not return a value.</LRESULT>
		/// 
		/// <remarks>
		/// If the list box has an owner-drawn style but not the LBS_HASSTRINGS style, the owner of the list box receives a WM_DELETEITEM message 
		/// for each item in the list box. 
		/// </remarks>
		LB_RESETCONTENT         	=  0x0184,
		# endregion

		# region LB_SELECTSTRING
		/// <summary>
		/// Searches a list box for an item that begins with the characters in a specified string. If a matching item is found, the item is selected. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top 
		/// of the list box back to the item specified by the wParam parameter. If wParam is –1, the entire list box is searched from the beginning. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes of the items in a list box 
		/// is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string that contains the prefix for which to search. 
		/// The search is case independent, so this string can contain any combination of uppercase and lowercase letters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the search is successful, the return value is the index of the selected item. 
		/// If the search is unsuccessful, the return value is LB_ERR and the current selection is not changed. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The list box is scrolled, if necessary, to bring the selected item into view. 
		/// Do not use this message with a list box that has the LBS_MULTIPLESEL or the LBS_EXTENDEDSEL styles. 
		/// An item is selected only if its initial characters from the starting point match the characters in the string specified by the lParam parameter. 
		/// If the list box has the owner-drawn style but not the LBS_HASSTRINGS style, the action taken by LB_SELECTSTRING depends on whether the LBS_SORT style
		/// is used. If LBS_SORT is used, the system sends WM_COMPAREITEM messages to the list box owner to determine which item matches the specified string. 
		/// Otherwise, LB_SELECTSTRING attempts to find an item that has a long value (supplied as the lParam parameter of the LB_ADDSTRING or LB_INSERTSTRING message) 
		/// that matches the lParam parameter. 
		/// </remarks>
		LB_SELECTSTRING         	=  0x018C,
		# endregion

		# region LB_SELITEMRANGE
		/// <summary>
		/// Selects or deselects one or more consecutive items in a multiple-selection list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// TRUE to select the range of items, or FALSE to deselect it.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The LOWORD specifies the zero-based index of the first item to select. The HIWORD specifies the zero-based index of the last item to select. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an error occurs, the return value is LB_ERR. </LRESULT>
		/// 
		/// <remarks>
		/// Use this message only with multiple-selection list boxes. 
		/// This message can select a range only within the first 65,536 items. 
		/// </remarks>
		LB_SELITEMRANGE         	=  0x019B,
		# endregion

		# region LB_SELITEMRANGEEX
		/// <summary>
		/// Selects one or more consecutive items in a multiple-selection list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the first item to select. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Specifies the zero-based index of the last item to select. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an error occurs, the return value is LB_ERR. </LRESULT>
		/// 
		/// <remarks>
		/// If the wParam parameter is less than the lParam parameter, the specified range of items is selected. 
		/// If wParam is greater than or equal to lParam, the range is removed from the specified range of items. 
		/// To select only one item, select two items and then deselect the unwanted item.
		/// Use this message only with multiple-selection list boxes. 
		/// This message can select a range only within the first 65,536 items. 
		/// </remarks>
		LB_SELITEMRANGEEX       	=  0x0183,
		# endregion

		# region LB_SETANCHORINDEX
		/// <summary>
		/// Sets the anchor item—that is, the item from which a multiple selection starts. A multiple selection spans all items from the anchor item to the caret item.
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the index of the new anchor item. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is zero.
		/// If the message fails, the return value is LB_ERR.
		/// </LRESULT>
		LB_SETANCHORINDEX       	=  0x019C,
		# endregion

		# region LB_SETCARETINDEX
		/// <summary>
		/// Sets the focus rectangle to the item at the specified index in a multiple-selection list box. If the item is not visible, it is scrolled into view. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the list box item that is to receive the focus rectangle. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// If this value is FALSE, the item is scrolled until it is fully visible; if it is TRUE, the item is scrolled until it is at least partially visible. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an error occurs, the return value is LB_ERR (-1). Otherwise, LB_OKAY (0) is returned.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If this message is sent to a single-selection list box that does not contain a selected item, the caret index is set to the item specified by the wParam parameter. 
		/// If the single-selection list box does contain a selected item, the list box returns LB_ERR.
		/// </remarks>
		LB_SETCARETINDEX        	=  0x019E,
		# endregion

		# region LB_SETCOLUMNWIDTH
		/// <summary>
		/// Sets the width, in pixels, of all columns in a multiple-column list box. 
		/// </summary>
		/// 
		/// <WPARAM>Specifies the width, in pixels, of all columns.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>This message does not return a value. </LRESULT>
		LB_SETCOLUMNWIDTH       	=  0x0195,
		# endregion

		# region LB_SETCOUNT
		/// <summary>
		/// Sets the count of items in a list box created with the LBS_NODATA style and not created with the LBS_HASSTRINGS style. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the new count of items in the list box. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>If an error occurs, the return value is LB_ERR. If there is insufficient memory to store the items, the return value is LB_ERRSPACE. </LRESULT>
		/// 
		/// <remarks>
		/// The LB_SETCOUNT message is supported only by list boxes created with the LBS_NODATA style and not created with the LBS_HASSTRINGS style. 
		/// All other list boxes return LB_ERR. 
		/// </remarks>
		LB_SETCOUNT             	=  0x01A7,
		# endregion

		# region LB_SETCURSEL
		/// <summary>
		/// Selects a string and scrolls it into view, if necessary. 
		/// When the new string is selected, the list box removes the highlight from the previously selected string. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the string that is selected. If this parameter is -1, the list box is set to have no selection. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// If an error occurs, the return value is LB_ERR. If the wParam parameter is –1, the return value is LB_ERR even though no error occurred. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Use this message only with single-selection list boxes. You cannot use it to set or remove a selection in a multiple-selection list box. 
		/// </remarks>
		LB_SETCURSEL            	=  0x0186,
		# endregion

		# region LB_SETHORIZONTALEXTENT
		/// <summary>
		/// Sets the width, in pixels, by which a list box can be scrolled horizontally (the scrollable width). 
		/// If the width of the list box is smaller than this value, the horizontal scroll bar horizontally scrolls items in the list box. 
		/// If the width of the list box is equal to or greater than this value, the horizontal scroll bar is hidden. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the number of pixels by which the list box can be scrolled. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// <LRESULT>This message does not return a value.</LRESULT>
		/// 
		/// <remarks>
		/// To respond to the LB_SETHORIZONTALEXTENT message, the list box must have been defined with the WS_HSCROLL style. 
		/// Note that a list box does not update its horizontal extent dynamically.
		/// This message has no effect on a multiple-column list box.
		/// </remarks>
		LB_SETHORIZONTALEXTENT  	=  0x0194,
		# endregion

		# region LB_SETITEMDATA
		/// <summary>
		/// Sets a value associated with the specified item in a list box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the item. If this value is -1, the lParam value applies to all items in the list box. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me): The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Specifies the value to be associated with the item. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an error occurs, the return value is LB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the item is in an owner-drawn list box created without the LBS_HASSTRINGS style, this message replaces 
		/// the value contained in the lParam parameter of the LB_ADDSTRING or LB_INSERTSTRING message that added the item to the list box. 
		/// </remarks>
		LB_SETITEMDATA          	=  0x019A,
		# endregion

		# region LB_SETITEMHEIGHT
		/// <summary>
		/// Sets the height, in pixels, of items in a list box. If the list box has the LBS_OWNERDRAWVARIABLE style, this message 
		/// sets the height of the item specified by the wParam parameter. Otherwise, this message sets the height of all items in the list box.
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the item in the list box. Use this parameter only if the list box has the LBS_OWNERDRAWVARIABLE style; 
		/// otherwise, set it to zero. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Specifies the height, in pixels, of the item. The maximum height is 255 pixels.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the index or height is invalid, the return value is LB_ERR. 
		/// </LRESULT>
		LB_SETITEMHEIGHT        	=  0x01A0,
		# endregion

		# region LB_SETLOCALE
		/// <summary>
		/// Sets the current locale of the list box. You can use the locale to determine the correct sorting order of displayed text 
		/// (for list boxes with the LBS_SORT style) and of text added by the LB_ADDSTRING message. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the locale identifier that the list box will use for sorting when adding text. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the previous locale identifier. If the wParam parameter specifies a locale that is not installed on the system, 
		/// the return value is LB_ERR and the current list box locale is not changed. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Use the MAKELCID macro to construct a locale identifier.
		/// </remarks>
		LB_SETLOCALE            	=  0x01A5,
		# endregion

		# region LB_SETSEL
		/// <summary>
		/// Selects an item in a multiple-selection list box and, if necessary, scrolls the item into view. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies how to set the selection. If this parameter is TRUE, the item is selected and highlighted; 
		/// if it is FALSE, the highlight is removed and the item is no longer selected. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Specifies the zero-based index of the item to set. 
		/// If this parameter is –1, the selection is added to or removed from all items, depending on the value of wParam, and no scrolling occurs. 
		/// </LPARAM>
		/// 
		/// <LRESULT>If an error occurs, the return value is LB_ERR.</LRESULT>
		/// 
		/// <remarks>Use this message only with multiple-selection list boxes. </remarks>
		LB_SETSEL               	=  0x0185,
		# endregion

		# region LB_SETTABSTOPS
		/// <summary>
		/// Sets the tab-stop positions in a list box. 
		/// </summary>
		/// 
		/// <WPARAM>Specifies the number of tab stops. </WPARAM>
		/// 
		/// <LPARAM>
		/// Pointer to the first member of an array of integers containing the tab stops. 
		/// The integers represent the number of quarters of the average character width for the font that is selected into the list box. 
		/// For example, a tab stop of 4 is placed at 1.0 character units, and a tab stop of 6 is placed at 1.5 average character units. 
		/// However, if the list box is part of a dialog box, the integers are in dialog template units. 
		/// The tab stops must be sorted in ascending order; backward tabs are not allowed. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If all the specified tabs are set, the return value is TRUE; otherwise, it is FALSE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// To respond to the LB_SETTABSTOPS message, the list box must have been created with the LBS_USETABSTOPS style. 
		/// If wParam is 0 and lParam is NULL, the default tab stop is two dialog template units. 
		/// If wParam is 1, the list box will have tab stops separated by the distance specified by lParam. 
		/// If lParam points to more than a single value, a tab stop will be set for each value in lParam, up to the number specified by wParam. 
		/// The values specified by lParam are in dialog template units, which are the device-independent units used in dialog box templates. 
		/// To convert measurements from dialog template units to screen units (pixels), use the MapDialogRect function. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The buffer pointed to by lParam must reside in writable memory, 
		/// even though the message does not modify the array.
		/// </remarks>
		LB_SETTABSTOPS          	=  0x0192,
		# endregion

		# region LB_SETTOPINDEX
		/// <summary>
		/// Ensures that the specified item in a list box is visible. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item in the list box. 
		/// Windows 95/Windows 98/Windows Millennium Edition (Windows Me) : The wParam parameter is limited to 16-bit values. 
		/// This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size in bytes 
		/// of the items in a list box is limited only by available memory.
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>If an error occurs, the return value is LB_ERR.</LRESULT>
		/// 
		///
		/// <remarks>
		/// The system scrolls the list box contents so that either the specified item appears at the top of the list box or the maximum scroll range has been reached. 
		/// </remarks>
		LB_SETTOPINDEX          	=  0x0197,
		# endregion
	    }
	# endregion
    }