/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CopyFile.cs

    DESCRIPTION
        CopyFile() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/11]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class Kernel32
	   {
		# region Generic version.
		/// <summary>
		/// Copies an existing file to a new file.
		/// <br/>
		/// <para>
		/// The CopyFileEx function provides two additional capabilities. CopyFileEx can call a specified callback function each time 
		/// a portion of the copy operation is completed, and CopyFileEx can be canceled during the copy operation.
		/// </para>
		/// <br/>
		/// <para>
		/// To perform this operation as a transacted operation, use the CopyFileTransacted function.
		/// </para>
		/// </summary>
		/// <param name="lpExistingFileName">
		/// The name of an existing file.
		/// <br/>
		/// <para>
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, 
		/// call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming a File.
		/// </para>
		/// <br/>
		/// <para>
		/// If lpExistingFileName does not exist, CopyFile fails, and GetLastError returns ERROR_FILE_NOT_FOUND.
		/// </para>
		/// </param>
		/// <param name="lpNewFileName">
		/// The name of the new file.
		/// <br/>
		/// <para>
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, 
		/// call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming a File.
		/// </para>
		/// </param>
		/// <param name="bFailIfExists">
		/// If this parameter is TRUE and the new file specified by lpNewFileName already exists, the function fails. 
		/// If this parameter is FALSE and the new file already exists, the function overwrites the existing file and succeeds.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// Security attributes for the existing file are copied to the new file.
		/// <br/>
		/// <para>
		/// Windows 7, Windows Server 2008 R2, Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:  
		/// Security attributes for the existing file are not copied to the new file until Windows 8 and Windows Server 2012. 
		/// To copy security attributes, use the SHFileOperation function.
		/// </para>
		/// <br/>
		/// <para>
		/// File attributes for the existing file are copied to the new file. For example, if an existing file has the FILE_ATTRIBUTE_READONLY 
		/// file attribute, a copy created through a call to CopyFile will also have the FILE_ATTRIBUTE_READONLY file attribute. 
		/// </para>
		/// <br/>
		/// <para>
		/// This function fails with ERROR_ACCESS_DENIED if the destination file already exists and has the FILE_ATTRIBUTE_HIDDEN or 
		/// FILE_ATTRIBUTE_READONLY attribute set.
		/// </para>
		/// <br/>
		/// <para>
		/// When CopyFile is used to copy an encrypted file, it attempts to encrypt the destination file with the keys used in the encryption 
		/// of the source file. If this cannot be done, this function attempts to encrypt the destination file with default keys. 
		/// If neither of these methods can be done, CopyFile fails with an ERROR_ENCRYPTION_FAILED error code.
		/// </para>
		/// <br/>
		/// <para>
		/// Symbolic link behavior—If the source file is a symbolic link, the actual file copied is the target of the symbolic link.
		/// </para>
		/// <br/>
		/// <para>
		/// If the destination file already exists and is a symbolic link, the target of the symbolic link is overwritten by the source file.
		/// </para>
		/// </remarks>
		[DllImport ( "Kernel.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CopyFile ( String  lpExistingFileName, String  lpNewFileName, bool  bFailIfExists ) ;
		# endregion
	    }
    }