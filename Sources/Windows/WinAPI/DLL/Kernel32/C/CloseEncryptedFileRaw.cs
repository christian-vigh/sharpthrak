/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CloseEncryptedFileRaw.cs

    DESCRIPTION
        CloseEncryptedFileRaw() Windows function.

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
		/// Closes an encrypted file after a backup or restore operation, and frees associated system resources. 
		/// This is one of a group of Encrypted File System (EFS) functions that is intended to implement backup and restore functionality, 
		/// while maintaining files in their encrypted state.
		/// </summary>
		/// <param name="pvContext">A pointer to a system-defined context block. The OpenEncryptedFileRaw function returns the context block.</param>
		/// <remarks>
		/// The CloseEncryptedFileRaw function frees allocated system resources such as the system-defined context block and closes the file.
		/// <para>The BackupRead and BackupWrite functions handle backup and restore of unencrypted files.</para>
		/// </remarks>
		[DllImport ( "Kernel32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern void 	CloseEncryptedFileRaw ( IntPtr  pvContext ) ;
		# endregion
	    }
    }