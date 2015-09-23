/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CheckNameLegalDOS8Dot3.cs

    DESCRIPTION
        CheckNameLegalDOS8Dot3() Windows function.

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
		/// Determines whether the specified name can be used to create a file on a FAT file system.
		/// </summary>
		/// <param name="lpName">The file name, in 8.3 format.</param>
		/// <param name="lpOemName">A pointer to a buffer that receives the OEM string that corresponds to Name. This parameter can be NULL.</param>
		/// <param name="OemNameSize">The size of the lpOemName buffer, in characters. If lpOemName is NULL, this parameter must be 0 (zero).</param>
		/// <param name="pbNameContainsSpaces">
		/// Indicates whether or not a name contains spaces. This parameter can be NULL. If the name is not a valid 8.3 FAT file system name, 
		/// this parameter is undefined.
		/// </param>
		/// <param name="pbNameLegal">
		/// If the function succeeds, this parameter indicates whether a file name is a valid 8.3 FAT file name when the current OEM code page 
		/// is applied to the file name.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		/// This function can be used to determine whether or not a file name can be passed to a 16-bit Windows-based application or 
		/// an MS-DOS-based application.
		/// </remarks>
		[DllImport ( "Kernel32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CheckNameLegalDOS8Dot3 ( String  lpName, out StringBuilder  lpOemName,
							uint  OemNameSize, out bool  pbNameContainsSpaces, out bool  pbNameLegal ) ;
		# endregion

		# region Version with an out String for lpOemName
		/// <summary>
		/// Determines whether the specified name can be used to create a file on a FAT file system.
		/// </summary>
		/// <param name="lpName">The file name, in 8.3 format.</param>
		/// <param name="lpOemName">A String that receives the OEM string that corresponds to Name. This parameter can be NULL.</param>
		/// <param name="pbNameContainsSpaces">
		/// Indicates whether or not a name contains spaces. This parameter can be NULL. If the name is not a valid 8.3 FAT file system name, 
		/// this parameter is undefined.
		/// </param>
		/// <param name="pbNameLegal">
		/// If the function succeeds, this parameter indicates whether a file name is a valid 8.3 FAT file name when the current OEM code page 
		/// is applied to the file name.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		/// This function can be used to determine whether or not a file name can be passed to a 16-bit Windows-based application or 
		/// an MS-DOS-based application.
		/// </remarks>
		public static bool		CheckNameLegalDOS8Dot3 ( String  lpName, out String  lpOemName,
										out bool  pbNameContainsSpaces, out bool  pbNameLegal )
		   {
			StringBuilder		Result		=  new StringBuilder ( Defines. DEFAULT_OUT_STRING_LENGTH ) ;
			bool			Status ;

			Status = CheckNameLegalDOS8Dot3 ( lpName, out Result, ( uint ) Result. Capacity, out pbNameContainsSpaces, out pbNameLegal ) ;
			lpOemName	=  Result. ToString ( ) ;

			return ( Status ) ;
		    }
		# endregion
	    }
    }