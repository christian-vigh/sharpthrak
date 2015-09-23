/**************************************************************************************************************

    NAME
        WinAPI/Functions/A/AreFileApisANSI.cs

    DESCRIPTION
        AreFileApisANSI() Windows function.

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
		/// Determines whether the file I/O functions are using the ANSI or OEM character set code page. 
		/// This function is useful for 8-bit console input and output operations.
		/// </summary>
		/// <returns>
		/// If the set of file I/O functions is using the ANSI code page, the return value is nonzero.
		/// <para>If the set of file I/O functions is using the OEM code page, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The SetFileApisToOEM function causes a set of file I/O functions to use the OEM code page. The SetFileApisToANSI function causes 
		/// the same set of file I/O functions to use the ANSI code page. Use the AreFileApisANSI function to determine which code page 
		/// the set of file I/O functions is currently using.
		/// <br/>
		/// <para>
		/// The file I/O functions whose code page is ascertained by AreFileApisANSI are those functions exported by KERNEL32.DLL 
		/// that accept or return a file name.
		/// </para>
		/// <br/>
		/// <para>
		/// The functions SetFileApisToOEM and SetFileApisToANSI set the code page for a process, so AreFileApisANSI returns a value 
		/// indicating the code page of an entire process.
		/// </para>
		/// </remarks>
		[DllImport ( "Kernel32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	AreFileApisANSI ( ) ;
		# endregion
	    }
    }