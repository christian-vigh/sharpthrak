/**************************************************************************************************************

    NAME
        WinAPI/Enums/C/CB.cs

    DESCRIPTION
        CB constants.

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
	# region CB_ constants
	/// <summary>
	/// Combobox message constantes.
	/// </summary>
	public enum CB_Constants : uint
	   {
		# region CB_ADDSTRING
		/// <summary>
		/// Adds a string to the list box of a combo box. If the combo box does not have the CBS_SORT style, the string is added to the end of the list. 
		/// Otherwise, the string is inserted into the list, and the list is sorted. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used. </WPARAM>
		/// 
		/// <LPARAM>
		/// An LPCTSTR pointer to the null-terminated string to be added. If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, 
		/// the value of the lParam parameter is stored as item data rather than the string it would otherwise point to. 
		/// The item data can be retrieved or modified by sending the CB_GETITEMDATA or CB_SETITEMDATA message. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the zero-based index to the string in the list box of the combo box. 
		/// If an error occurs, the return value is CB_ERR. If insufficient space is available to store the new string, it is CB_ERRSPACE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If you create an owner-drawn combo box with the CBS_SORT style but without the CBS_HASSTRINGS style, the WM_COMPAREITEM message is sent 
		/// one or more times to the owner of the combo box so the new item can be properly placed in the list. 
		/// To insert a string at a specific location within the list, use the CB_INSERTSTRING message. 
		/// If the combo box has WS_HSCROLL style and you add a string wider than the combo box, send a LB_SETHORIZONTALEXTENT message to ensure 
		/// the horizontal scroll bar appears.
		/// Comclt32.dll version 5.0 or later: If CBS_LOWERCASE or CBS_UPPERCASE is set, the Unicode version of CB_ADDSTRING alters the string. 
		/// If using read-only global memory, this causes the application to fail.
		/// </remarks>
		CB_ADDSTRING                		=  0x0143,
		# endregion

		# region CB_DELETESTRING
		/// <summary>
		/// Deletes a string in the list box of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the string to delete. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is a count of the strings remaining in the list. 
		/// If the wParam parameter specifies an index greater than the number of items in the list, the return value is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, the system sends a WM_DELETEITEM message 
		/// to the owner of the combo box so the application can free any additional data associated with the item. 
		/// </remarks>
		CB_DELETESTRING             		=  0x0144,
		# endregion

		# region CB_DIR
		/// <summary>
		/// Adds names to the list displayed by the combo box. The message adds the names of directories and files that match a specified string and set of file attributes. 
		/// CB_DIR can also add mapped drive letters to the list.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The attributes of the files or directories to be added to the combo box (type DDL_Constants).
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// An LPCTSTR pointer to a null-terminated string that specifies an absolute path, relative path, or file name. 
		/// An absolute path can begin with a drive letter (for example, d:\) or a UNC name (for example, \\machinename\sharename). 
		/// If the string specifies a file name or directory that has the attributes specified by the wParam parameter, the file name or directory is added to the list. 
		/// If the file name or directory name contains wildcard characters (? or *), all files or directories that match the wildcard expression and have 
		/// the attributes specified by the wParam parameter are added to the list displayed in the combo box.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is the zero-based index of the last name added to the list.
		/// If an error occurs, the return value is CB_ERR. If there is insufficient space to store the new strings, the return value is CB_ERRSPACE.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Windows NT 4.0 and later: If wParam includes the DDL_DIRECTORY flag and lParam specifies all the subdirectories of a first-level directory, 
		/// such as C:\TEMP\*, the list box will always include a ".." entry for the root directory. This is true even if the root directory has hidden or system 
		/// attributes and the DDL_HIDDEN and DDL_SYSTEM flags are not specified. The root directory of an NTFS volume has hidden and system attributes.
		///
		/// Windows NT/2000/XP: The list displays long file names, if any.
		///
		/// Windows 95/98/Me: The list displays short file names (the 8.3 form). You can use the SHGetFileInfo or GetFullPathName function to get the 
		/// corresponding long file name.
		/// </remarks>
		CB_DIR                      		=  0x0145,
		# endregion

		#  region CB_FINDSTRING
		/// <summary>
		/// Searches the list box of a combo box for an item beginning with the characters in a specified string. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item preceding the first item to be searched. When the search reaches the bottom of the list box, *
		/// it continues from the top of the list box back to the item specified by the wParam parameter. 
		/// If wParam is –1, the entire list box is searched from the beginning. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string that contains the characters for which to search. The search is not case sensitive, so this string 
		/// can contain any combination of uppercase and lowercase letters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the zero-based index of the matching item. If the search is unsuccessful, it is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, what the CB_FINDSTRING message does depends on 
		/// whether your application uses the CBS_SORT style. 
		/// If you use the CBS_SORT style, WM_COMPAREITEM messages are sent to the owner of the combo box to determine which item matches the specified string. 
		/// If you do not use the CBS_SORT style, the CB_FINDSTRING message searches for a list item that matches the value of the lParam parameter. 
		/// </remarks>
		CB_FINDSTRING               		=  0x014C,
		# endregion

		# region CB_FINDSTRINGEXACT
		/// <summary>
		/// Finds the first list box string in a combo box that matches the string specified in the lParam parameter. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item preceding the first item to be searched. When the search reaches the bottom of the list box, it continues 
		/// from the top of the list box back to the item specified by the wParam parameter. If wParam is –1, the entire list box is searched from the beginning. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string for which to search. 
		/// The search is not case sensitive, so this string can contain any combination of uppercase and lowercase letters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the zero-based index of the matching item. If the search is unsuccessful, it is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This function is successful only if the specified string and a combo box item have the same length (except for the terminating null character) 
		/// and the same characters.
		/// If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, the functionality of CB_FINDSTRINGEXACT message 
		/// depends on whether your application uses the CBS_SORT style. If you use the CBS_SORT style, WM_COMPAREITEM messages are sent to the owner of 
		/// the combo box to determine which item matches the specified string. 
		/// If you do not use the CBS_SORT style, the CB_FINDSTRINGEXACT message searches for a list item that matches the value of the lParam parameter. 
		/// </remarks>
		CB_FINDSTRINGEXACT          		=  0x0158,
		# endregion

		# region CB_GETCOMBOBOXINFO
		/// <summary>
		/// Gets information about the specified combo box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a COMBOBOXINFO structure that receives the information. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This message is equivalent to GetComboBoxInfo().
		/// </remarks>
		CB_GETCOMBOBOXINFO          		=  0x0164,
		#  endregion

		#  region CB_GETCOUNT
		/// <summary>
		/// Gets the number of items in the list box of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the number of items in the list box. If an error occurs, it is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The index is zero-based, so the returned count is one greater than the index value of the last item. 
		/// </remarks>
		CB_GETCOUNT                 		=  0x0146,
		# endregion

		# region CB_GETCUEBANNER
		/// <summary>
		/// Gets the cue banner text displayed in the edit control of a combo box. Send this message explicitly or by using the ComboBox_GetCueBannerText macro.
		/// </summary>
		/// 
		/// <WPARAM>
		/// A pointer to a Unicode string buffer that receives the cue banner text. The calling application is responsible for allocating the memory for the buffer. 
		/// The buffer size must be equal to the length of the cue banner string in WCHARs, plus 1—for the terminating NULL WCHAR.
 		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The size of the buffer pointed to by lpcwText in WCHARs.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// Returns 1 if successful, or an error value otherwise.
		/// If there is no cue banner text to get, the return value is 0. If the calling application fails to allocate a buffer, or set lParam before sending this message, 
		/// undefined behavior may result and the return value may not be reliable.
		/// </LRESULT>
		CB_GETCUEBANNER				=  0x1704,
		# endregion

		# region CB_GETCURSEL
		/// <summary>
		/// An application sends a CB_GETCURSEL message to retrieve the index of the currently selected item, if any, in the list box of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The return value is the zero-based index of the currently selected item. If no item is selected, it is CB_ERR. 
		/// </remarks>
		CB_GETCURSEL                		=  0x0147,
		#  endregion

		# region CB_GETDROPPEDCONTROLRECT
		/// <summary>
		/// An application sends a CB_GETDROPPEDCONTROLRECT message to retrieve the screen coordinates of a combo box in its dropped-down state. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the RECT structure that receives the coordinates of the combo box in its dropped-down state. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is nonzero.
		/// If the message fails, the return value is zero.
		/// </LRESULT>
		CB_GETDROPPEDCONTROLRECT    		=  0x0152,
		# endregion

		# region CB_GETDROPPEDSTATE
		/// <summary>
		/// Determines whether the list box of a combo box is dropped down. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the list box is visible, the return value is TRUE; otherwise, it is FALSE. 
		/// </LRESULT>
		CB_GETDROPPEDSTATE          		=  0x0157,
		# endregion

		# region CB_GETDROPPEDWIDTH
		/// <summary>
		/// Gets the minimum allowable width, in pixels, of the list box of a combo box with the CBS_DROPDOWN or CBS_DROPDOWNLIST style.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is the width, in pixels. 
		/// If the message fails, the return value is CB_ERR.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// By default, the minimum allowable width of the drop-down list box is zero. 
		/// The width of the list box is either the minimum allowable width or the combo box width, whichever is larger.
		/// </remarks>
		CB_GETDROPPEDWIDTH          		=  0x015f,
		# endregion

		# region CB_GETEDITSEL
		/// <summary>
		/// Gets the starting and ending character positions of the current selection in the edit control of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// A pointer to a DWORD value that receives the starting position of the selection. This parameter can be NULL. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a DWORD value that receives the ending position of the selection. This parameter can be NULL. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is a zero-based DWORD value with the starting position of the selection in the LOWORD and with the ending position of 
		/// the first character after the last selected character in the HIWORD. 
		/// </LRESULT>
		CB_GETEDITSEL               		=  0x0140,
		# endregion

		# region CB_GETEXTENDEDUI
		/// <summary>
		/// Determines whether a combo box has the default user interface or the extended user interface. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the combo box has the extended user interface, the return value is TRUE; otherwise, it is FALSE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// By default, the F4 key opens or closes the list and the DOWN ARROW changes the current selection. 
		/// In a combo box with the extended user interface, the F4 key is disabled and pressing the DOWN ARROW key opens the drop-down list. 
		/// </remarks>
		CB_GETEXTENDEDUI            		=  0x0156,
		#  endregion

		# region CB_GETHORIZONTALEXTENT
		/// <summary>
		/// Gets the width, in pixels, that the list box can be scrolled horizontally (the scrollable width). 
		/// This is applicable only if the list box has a horizontal scroll bar.
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the scrollable width, in pixels.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// </remarks>
		CB_GETHORIZONTALEXTENT      		=  0x015d,
		# endregion

		# region CB_GETITEMDATA
		/// <summary>
		/// An application sends a CB_GETITEMDATA message to a combo box to retrieve the application-supplied value associated with the specified item in the combo box. 
 		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the value associated with the item. If an error occurs, it is CB_ERR. 
		/// If the item is in an owner-drawn combo box created without the CBS_HASSTRINGS style, the return value is the value contained in the 
		/// lParam parameter of the CB_ADDSTRING or CB_INSERTSTRING message, that added the item to the combo box. If the CBS_HASSTRINGS style was not used, 
		/// the return value is the lParam parameter contained in a CB_SETITEMDATA message. 
		/// </LRESULT>
		CB_GETITEMDATA              		=  0x0150,
		# endregion

		# region CB_GETITEMHEIGHT
		/// <summary>
		/// Determines the height of list items or the selection field in a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The combo box component whose height is to be retrieved. This parameter must be –1 to retrieve the height of the selection field. 
		/// It must be zero to retrieve the height of list items, unless the combo box has the CBS_OWNERDRAWVARIABLE style. 
		/// In that case, the wParam parameter is the zero-based index of a specific list item. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the height, in pixels, of the list items in a combo box. If the combo box has the CBS_OWNERDRAWVARIABLE style, 
		/// it is the height of the item specified by the wParam parameter. If wParam is –1, the return value is the height of the edit control (or static-text) portion 
		/// of the combo box. If an error occurs, the return value is CB_ERR. 
		/// </LRESULT>
		CB_GETITEMHEIGHT            		=  0x0154,
		# endregion

		# region CB_GETLBTEXT
		/// <summary>
		/// Gets a string from the list of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the string to retrieve. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the buffer that receives the string. The buffer must have sufficient space for the string and a terminating null character. 
		/// You can send a CB_GETLBTEXTLEN message prior to the CB_GETLBTEXT message to retrieve the length, in TCHARs, of the string. 
		/// If it is an ANSI string this is the number of bytes, but if it is a Unicode string this is the number of characters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the length of the string, in TCHARs, excluding the terminating null character. If wParam does not specify a valid index, 
		/// the return value is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Security Warning :  Using this message incorrectly can compromise the security of your program. This message does not provide a way for you to know 
		/// the size of the buffer. If you use this message, first call CB_GETLBTEXTLEN to get the number of characters that are required and then call the message 
		/// to retrieve the string. You should review the Security Considerations: Microsoft Windows Controls before continuing.
		/// If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, the buffer pointed to by lParam receives the data associated 
		/// with the item. 
		/// </remarks>
		CB_GETLBTEXT                		=  0x0148,
		# endregion

		# region CB_GETLBTEXTLEN
		/// <summary>
		/// Gets the length, in characters, of a string in the list of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the string. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the length of the string, in TCHARs, excluding the terminating null character. 
		/// If an ANSI string this is the number of bytes, and if it is a Unicode string this is the number of characters. 
		/// Under certain conditions, this value may actually be greater than the length of the text.
		/// If the wParam parameter does not specify a valid index, the return value is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Under certain conditions, the return value is larger than the actual length of the text. This occurs with certain mixtures of ANSI and Unicode, 
		/// and is due to the operating system allowing for the possible existence of double-byte character set (DBCS) characters within the text. 
		/// The return value, however, will always be at least as large as the actual length of the text; so you can always use it to guide buffer allocation. 
		/// This behavior can occur when an application uses both ANSI functions and common dialogs, which use Unicode. 
		/// To obtain the exact length of the text, use the WM_GETTEXT, LB_GETTEXT, or CB_GETLBTEXT messages, or the GetWindowText function.
		/// </remarks>
		CB_GETLBTEXTLEN             		=  0x0149,
		# endregion

		# region CB_GETLOCALE
		/// <summary>
		/// Gets the current locale of the combo box. The locale is used to determine the correct sorting order of displayed text for combo boxes with 
		/// the CBS_SORT style and text added by using the CB_ADDSTRING message. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value specifies the current locale of the combo box. The HIWORD contains the country/region code and the LOWORD contains the language identifier. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The language identifier is made up of a sublanguage identifier and a primary language identifier. 
		/// The PRIMARYLANGID macro obtains the primary language identifier and the SUBLANGID macro obtains the sublanguage identifier. 
		/// </remarks>
		CB_GETLOCALE                		=  0x015A,
		# endregion

		# region CB_GETMINVISIBLE
		/// <summary>
		/// Gets the minimum number of visible items in the drop-down list of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the minimum number of visible items.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the number of items in the drop-down list is greater than the minimum, the combo box uses a scroll bar. 
		/// This message is ignored if the combo box control has style CBS_NOINTEGRALHEIGHT.
		/// To use CB_GETMINVISIBLE, the application must specify comctl32.dll version 6 in the manifest. 
		/// </remarks>
		CB_GETMINVISIBLE              		=  0x1702,
		# endregion

		# region CB_GETTOPINDEX
		/// <summary>
		/// An application sends the CB_GETTOPINDEX message to retrieve the zero-based index of the first visible item in the list box portion of a combo box. 
		/// Initially, the item with index 0 is at the top of the list box, but if the list box contents have been scrolled, another item may be at the top. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">Not used; must be zero.</WPARAM>
		/// <LPARAM unused="true">Not used; must be zero. </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, the return value is the index of the first visible item in the list box of the combo box. 
		/// If the message fails, the return value is CB_ERR.
		/// </LRESULT>
		CB_GETTOPINDEX              		=  0x015b,
		# endregion

		# region CB_INITSTORAGE
		/// <summary>
		/// An application sends the CB_INITSTORAGE message before adding a large number of items to the list box portion of a combo box. 
		/// This message allocates memory for storing list box items.
		/// </summary>
		/// 
		/// <WPARAM>
		/// The number of items to add. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// The amount of memory to allocate for item strings, in bytes. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, the return value is the total number of items for which memory has been pre-allocated, that is, 
		/// the total number of items added by all successful CB_INITSTORAGE messages.
		/// If the message fails, the return value is CB_ERRSPACE. 
		/// Windows NT 4.0: This message does not allocate the specified amount of memory; however, it always returns the value specified in the wParam parameter. 
		/// Windows 2000/XP: The message allocates memory and returns the success and error values described above. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The CB_INITSTORAGE message helps speed up the initialization of combo boxes that have a large number of items (over 100). 
		/// It reserves the specified amount of memory so that subsequent CB_ADDSTRING, CB_INSERTSTRING, and CB_DIR messages take the shortest possible time. 
		/// You can use estimates for the wParam and lParam parameters. If you overestimate, the extra memory is allocated, if you underestimate, 
		/// the normal allocation is used for items that exceed the requested amount. 
		/// </remarks>
		CB_INITSTORAGE              		=  0x0161,
		# endregion

		# region CB_INSERTSTRING
		/// <summary>
		/// Inserts a string or item data into the list of a combo box. 
		/// Unlike the CB_ADDSTRING message, the CB_INSERTSTRING message does not cause a list with the CBS_SORT style to be sorted. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the position at which to insert the string. If this parameter is –1, the string is added to the end of the list. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string to be inserted. If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, 
		/// the value of the lParam parameter is stored rather than the string to which it would otherwise point. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the index of the position at which the string was inserted. If an error occurs, the return value is CB_ERR. 
		/// If there is insufficient space available to store the new string, it is CB_ERRSPACE. 
		/// If the combo box has WS_HSCROLL style and you insert a string wider than the combo box, you should send a LB_SETHORIZONTALEXTENT message 
		/// to ensure the horizontal scroll bar appears.
		/// </LRESULT>
		
		CB_INSERTSTRING             		=  0x014A,
		# endregion

		# region CB_LIMITTEXT
		/// <summary>
		/// Limits the length of the text the user may type into the edit control of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The maximum number of TCHARs the user can enter, not including the terminating null character. 
		/// If this parameter is zero, the text length is limited to 0x7FFFFFFE characters. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is always TRUE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the combo box does not have the CBS_AUTOHSCROLL style, setting the text limit to be larger than the size of the edit control has no effect. 
		/// The CB_LIMITTEXT message limits only the text the user can enter. It has no effect on any text already in the edit control when the message is sent, 
		/// nor does it affect the length of the text copied to the edit control when a string in the list box is selected. 
		/// The default limit to the text a user can enter in the edit control is 30,000 TCHARs. 
		/// </remarks>
		CB_LIMITTEXT                		=  0x0141,
		# endregion

		# region CB_MULTIPLEADDSTRING
		/// <summary>
		/// Undocumented.
		/// </summary>
		CB_MULTIPLEADDSTRING        		=  0x0163,
		# endregion

		# region CB_RESETCONTENT
		/// <summary>
		/// Removes all items from the list box and edit control of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// This message always returns CB_OKAY. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, the owner of the combo box receives 
		/// a WM_DELETEITEM message for each item in the combo box. 
		/// </remarks>
		CB_RESETCONTENT             		=  0x014B,
		# endregion

		# region CB_SELECTSTRING
		/// <summary>
		/// Searches the list of a combo box for an item that begins with the characters in a specified string. 
		/// If a matching item is found, it is selected and copied to the edit control. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The zero-based index of the item preceding the first item to be searched. When the search reaches the bottom of the list, it continues from the top 
		/// of the list back to the item specified by the wParam parameter. If wParam is –1, the entire list is searched from the beginning. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to the null-terminated string that contains the characters for which to search. 
		/// The search is not case sensitive, so this string can contain any combination of uppercase and lowercase letters. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the string is found, the return value is the index of the selected item. 
		/// If the search is unsuccessful, the return value is CB_ERR and the current selection is not changed. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// A string is selected only if the characters from the starting point match the characters in the prefix string. 
		/// If you create the combo box with an owner-drawn style but without the CBS_HASSTRINGS style, what the CB_SELECTSTRING message does 
		/// depends on whether you use the CBS_SORT style. If the CBS_SORT style is used, the system sends WM_COMPAREITEM messages to the owner 
		/// of the combo box to determine which item matches the specified string. 
		/// If you do not use the CBS_SORT style, CB_SELECTSTRING attempts to match the DWORD value against the value of the lParam parameter. 
		/// </remarks>
		CB_SELECTSTRING             		=  0x014D,
		# endregion

		# region CB_SETCUEBANNER
		/// <summary>
		/// Sets the cue banner text that is displayed for the edit control of a combo box.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used and must be zero.</WPARAM>
		/// 
		/// <LPARAM>
		/// A pointer to a null-terminated Unicode string buffer that contains the text.
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// Returns 1 if successful, or an error value otherwise.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The cue banner is text that is displayed in the edit control of a combo box when there is no selection.
		/// </remarks>
		CB_SETCUEBANNER                		=  0x1703,
		# endregion

		# region CB_SETCURSEL
		/// <summary>
		/// An application sends a CB_SETCURSEL message to select a string in the list of a combo box. If necessary, the list scrolls the string into view. 
		/// The text in the edit control of the combo box changes to reflect the new selection, and any previous selection in the list is removed. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the string to select. If this parameter is –1, any current selection in the list is removed and the edit control is cleared. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, the return value is the index of the item selected. 
		/// If wParam is greater than the number of items in the list or if wParam is –1, the return value is CB_ERR and the selection is cleared. 
		/// </LRESULT>
		CB_SETCURSEL                		=  0x014E,
		# endregion

		# region CB_SETDROPPEDWIDTH
		/// <summary>
		/// An application sends the CB_SETDROPPEDWIDTH message to set the minimum allowable width, in pixels, of the list box of a combo box 
		/// with the CBS_DROPDOWN or CBS_DROPDOWNLIST style. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// The minimum allowable width of the list box, in pixels. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, The return value is the new width of the list box. 
		/// If the message fails, the return value is CB_ERR.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// By default, the minimum allowable width of the drop-down list box is zero. 
		/// The width of the list box is either the minimum allowable width or the combo box width, whichever is larger.
		/// </remarks>
		CB_SETDROPPEDWIDTH          		=  0x0160,
		# endregion

		# region CB_SETEDITSEL
		/// <summary>
		/// By default, the minimum allowable width of the drop-down list box is zero. 
		/// The width of the list box is either the minimum allowable width or the combo box width, whichever is larger.
		/// </summary>
		/// 
		/// <WPARAM unused="true">This parameter is not used.</WPARAM>
		/// 
		/// <LPARAM>
		/// The LOWORD of lParam specifies the starting position. If the LOWORD is –1, the selection, if any, is removed. 
		/// The HIWORD of lParam specifies the ending position. 
		/// If the HIWORD is –1, all text from the starting position to the last character in the edit control is selected. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the message succeeds, the return value is TRUE. If the message is sent to a combo box with the CBS_DROPDOWNLIST style, it is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The positions are zero-based. The first character of the edit control is in the zero position. 
		/// The first character after the last selected character is in the ending position. 
		/// For example, to select the first four characters of the edit control, use a starting position of 0 and an ending position of 4. 
		/// </remarks>
		CB_SETEDITSEL               		=  0x0142,
		# endregion

		# region CB_SETEXTENDEDUI
		/// <summary>
		/// An application sends a CB_SETEXTENDEDUI message to select either the default UI or the extended UI for a combo box that has 
		/// the CBS_DROPDOWN or CBS_DROPDOWNLIST style. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// A BOOL that specifies whether the combo box uses the extended UI (TRUE) or the default UI (FALSE).
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// If the operation succeeds, the return value is CB_OKAY. If an error occurs, it is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// By default, the F4 key opens or closes the list and the DOWN ARROW changes the current selection. 
		/// In the extended UI, the F4 key is disabled and the DOWN ARROW key opens the drop-down list. 
		/// The mouse wheel, which normally scrolls through the items in the list, has no effect when the extended UI is set.
		/// </remarks>
		CB_SETEXTENDEDUI            		=  0x0155,
		# endregion

		# region CB_SETHORIZONTALEXTENT
		/// <summary>
		/// An application sends the CB_SETHORIZONTALEXTENT message to set the width, in pixels, by which a list box can be scrolled horizontally (the scrollable width). 
		/// If the width of the list box is smaller than this value, the horizontal scroll bar horizontally scrolls items in the list box. 
		/// If the width of the list box is equal to or greater than this value, the horizontal scroll bar is hidden or, 
		/// if the combo box has the CBS_DISABLENOSCROLL style, disabled.
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the scrollable width of the list box, in pixels. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		CB_SETHORIZONTALEXTENT      		=  0x015e,
		# endregion

		# region CB_SETITEMDATA
		/// <summary>
		/// An application sends a CB_SETITEMDATA message to set the value associated with the specified item in a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the item's zero-based index. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Specifies the new value to be associated with the item. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If an error occurs, the return value is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// If the specified item is in an owner-drawn combo box created without the CBS_HASSTRINGS style, this message replaces the value 
		/// in the lParam parameter of the CB_ADDSTRING or CB_INSERTSTRING message that added the item to the combo box. 
		/// </remarks>
		CB_SETITEMDATA              		=  0x0151,
		# endregion

		# region CB_SETITEMHEIGHT
		/// <summary>
		/// An application sends a CB_SETITEMHEIGHT message to set the height of list items or the selection field in a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the component of the combo box for which to set the height. 
		/// This parameter must be –1 to set the height of the selection field. It must be zero to set the height of list items, unless the combo box 
		/// has the CBS_OWNERDRAWVARIABLE style. In that case, the wParam parameter is the zero-based index of a specific list item. 
		/// </WPARAM>
		/// 
		/// <LPARAM>
		/// Specifies the height, in pixels, of the combo box component identified by wParam. 
		/// </LPARAM>
		/// 
		/// <LRESULT>
		/// If the index or height is invalid, the return value is CB_ERR. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// The selection field height in a combo box is set independently of the height of the list items. 
		/// An application must ensure that the height of the selection field is not smaller than the height of a particular list item. 
		/// </remarks>
		CB_SETITEMHEIGHT            		=  0x0153,
		# endregion

		# region CB_SETLOCALE
		/// <summary>
		/// An application sends a CB_SETLOCALE message to set the current locale of the combo box. 
		/// If the combo box has the CBS_SORT style and strings are added using CB_ADDSTRING, the locale of a combo box affects how list items are sorted. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the locale identifier for the combo box to use for sorting when adding text. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is the previous locale identifier. 
		/// If wParam specifies a locale not installed on the system, the return value is CB_ERR and the current combo box locale is not changed. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// Use the MAKELCID macro to construct a locale identifier and the MAKELANGID macro to construct a language identifier. 
		/// The language identifier is made up of a primary language identifier and a sublanguage identifier. 
		/// </remarks>
		CB_SETLOCALE                		=  0x0159,
		# endregion

		#  region CB_SETMINVISIBLE
		/// <summary>
		/// An application sends a CB_SETMINVISIBLE message to set the minimum number of visible items in the drop-down list of a combo box. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the minimum number of visible items. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used; it must be zero.</LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, the return value is TRUE. Otherwise the return value is FALSE.
		/// </LRESULT>
		/// 
		/// <remarks>
		/// When the number of items in the drop-down list is greater than the minimum, the combo box uses a scroll bar. 
		/// By default, 30 is the minimum number of visible items.
		/// This message is ignored if the combo box control has style CBS_NOINTEGRALHEIGHT.
		/// To use CB_SETMINVISIBLE, the application must specify comctl32.dll version 6 in the manifest.
		/// </remarks>
		CB_SETMINVISIBLE              		=  0x1701,
		# endregion

		# region CB_SETTOPINDEX
		/// <summary>
		/// An application sends the CB_SETTOPINDEX message to ensure that a particular item is visible in the list box of a combo box. 
		/// The system scrolls the list box contents so that either the specified item appears at the top of the list box or the maximum scroll range has been reached.
		/// </summary>
		/// 
		/// <WPARAM>
		/// Specifies the zero-based index of the list item. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used; it must be zero.</LPARAM>
		/// 
		/// <LRESULT>
		/// If the message is successful, the return value is zero. 
		/// If the message fails, the return value is CB_ERR.
		/// </LRESULT>
		CB_SETTOPINDEX              		=  0x015c,
		# endregion

		# region CB_SHOWDROPDOWN
		/// <summary>
		/// An application sends a CB_SHOWDROPDOWN message to show or hide the list box of a combo box that has the CBS_DROPDOWN or CBS_DROPDOWNLIST style. 
		/// </summary>
		/// 
		/// <WPARAM>
		/// A BOOL that specifies whether the drop-down list box is to be shown or hidden. A value of TRUE shows the list box; a value of FALSE hides it. 
		/// </WPARAM>
		/// 
		/// <LPARAM unused="true">This parameter is not used; it must be zero.</LPARAM>
		/// 
		/// <LRESULT>
		/// The return value is always TRUE. 
		/// </LRESULT>
		/// 
		/// <remarks>
		/// This message has no effect on a combo box created with the CBS_SIMPLE style. 
		/// </remarks>
		CB_SHOWDROPDOWN             		=  0x014F,
		# endregion
	    }
	# endregion
    }