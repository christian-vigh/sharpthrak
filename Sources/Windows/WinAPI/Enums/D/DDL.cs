/**************************************************************************************************************

    NAME
        WinAPI/Constants/D/DDL.cs

    DESCRIPTION
        DDL directory list options.

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
	# region DDL_ values
	/// <summary>
	/// Attributes of the files or directories to be added to a combo or list box.
	/// </summary>
	public enum DDL_Constants		:  int
	   {
		/// <summary>
		/// Includes archived files.
		/// </summary>
		DDL_ARCHIVE			=  0x0020,

		/// <summary>
		/// Includes subdirectories, which are enclosed in square brackets ([ ]).
		/// </summary>
		DDL_DIRECTORY			=  0x0010,

		/// <summary>
		/// All mapped drives are added to the list. Drives are listed in the form [-x-], where x is the drive letter.
		/// </summary>
		DDL_DRIVES			=  0x4000,

		/// <summary>
		/// Includes only files with the specified attributes. By default, read/write files are listed even if DDL_READWRITE is not specified.
		/// </summary>
		DDL_EXCLUSIVE			=  0x8000,

		/// <summary>
		/// Includes hidden files.
		/// </summary>
		DDL_HIDDEN			=  0x0002,

		/// <summary>
		/// If set, DlgDirList uses the PostMessage function to send messages to the list box. If not set, DlgDirList uses the SendMessage function.
		/// </summary>
		DDL_POSTMSGS			=  0x2000,

		/// <summary>
		/// Includes read-only files.
		/// </summary>
		DDL_READONLY			=  0x0001,

		/// <summary>
		/// Includes read/write files with no additional attributes. This is the default.
		/// </summary>
		DDL_READWRITE			=  0x0000,

		/// <summary>
		/// Includes system files.
		/// </summary>
		DDL_SYSTEM			=  0x0004
	    }
	# endregion
    }
