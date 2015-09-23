/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CopyFileEx.cs

    DESCRIPTION
        CopyFileEx() Windows function.

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
using	Thrak. WinAPI. Callbacks ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class Kernel32
	   {
		# region Generic version.
		/// <summary>
		/// Copies an existing file to a new file, notifying the application of its progress through a callback function.
		/// </summary>
		/// <param name="lpExistingFileName">
		/// The name of an existing file. 
		/// <br/>
		/// <para>
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, 
		/// call the Unicode version of the function and prepend "\\?\" to the path.
		/// </para>
		/// </param>
		/// <param name="lpNewFileName">
		/// The name of the new file. 
		/// <br/>
		/// <para>
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, 
		/// call the Unicode version of the function and prepend "\\?\" to the path.
		/// </para>
		/// </param>
		/// <param name="lpProgressRoutine">
		/// The address of a callback function of type LPPROGRESS_ROUTINE that is called each time another portion of the file has been copied.
		/// This parameter can be NULL.
		/// </param>
		/// <param name="lpData">The argument to be passed to the callback function. This parameter can be NULL.</param>
		/// <param name="pbCancel">
		/// If this flag is set to TRUE during the copy operation, the operation is canceled. Otherwise, the copy operation will continue to completion.
		/// </param>
		/// <param name="dwCopyFlags">
		/// Flags that specify how the file is to be copied. This parameter can be a combination of the COPY_FILE_Constants values.
		/// </param>
		/// <returns></returns>
		[DllImport ( "Kernel.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CopyFileEx ( String  lpExistingFileName, String lpNewFileName, 
							PROGRESS_ROUTINE  lpProgressRoutine, IntPtr  lpData,
							ref uint  pbCancel, COPY_FILE_Constants  dwCopyFlags ) ;
		# endregion
	    }
    }