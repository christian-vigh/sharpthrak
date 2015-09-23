/**************************************************************************************************************

    NAME
        WinAPI/Enums/C/COPY_FILE.cs

    DESCRIPTION
        COPY_FILE constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/11]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region COPY_FILE_ constants
	/// <summary>
	/// Combination of flags that specify how the file is to be copied.
	/// </summary>
	public enum COPY_FILE_Constants : int
	   {
		/// <summary>
		/// An attempt to copy an encrypted file will succeed even if the destination copy cannot be encrypted.
		/// </summary>
		COPY_FILE_ALLOW_DECRYPTED_DESTINATION	=  0x00000008,

		/// <summary>
		/// If the source file is a symbolic link, the destination file is also a symbolic link pointing to 
		/// the same file that the source symbolic link is pointing to. 
		/// <br/>
		/// <para>
		/// Windows Server 2003 and Windows XP:  This value is not supported.
		/// </para>
		/// </summary>
		COPY_FILE_COPY_SYMLINK			=  0x00000800,

		/// <summary>
		/// The copy operation fails immediately if the target file already exists.
		/// </summary>
		COPY_FILE_FAIL_IF_EXISTS		=  0x00000001,

		/// <summary>
		/// The copy operation is performed using unbuffered I/O, bypassing system I/O cache resources. Recommended for very large file transfers. 
		/// <br/>
		/// <para>
		/// Windows Server 2003 and Windows XP:  This value is not supported.
		/// </para>
		/// </summary>
		COPY_FILE_NO_BUFFERING			=  0x00001000,

		/// <summary>
		/// The file is copied and the original file is opened for write access.
		/// </summary>
		COPY_FILE_OPEN_SOURCE_FOR_WRITE		=  0x00000004,

		/// <summary>
		/// Progress of the copy is tracked in the target file in case the copy fails. The failed copy can be restarted at a later time 
		/// by specifying the same values for lpExistingFileName and lpNewFileName as those used in the call that failed. 
		/// This can significantly slow down the copy operation as the new file may be flushed multiple times during the copy operation.
		/// </summary>
		COPY_FILE_RESTARTABLE			=  0x00000002
	    }
	# endregion
    }