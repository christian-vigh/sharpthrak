/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CharUpper.cs

    DESCRIPTION
        CharUpper() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
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
	public static partial class User32
	   {
		# region Version with string
		/// <summary>
		/// Converts a character string or a single character to uppercase. If the operand is a character string, 
		/// the function converts the characters in place. 
		/// </summary>
		/// <param name="lpsz">
		/// A null-terminated string, or a single character. 
		/// If the high-order word of this parameter is zero, the low-order word must contain a single character to be converted.
		/// </param>
		/// <returns>
		/// If the operand is a character string, the function returns a pointer to the converted string. 
		/// Because the string is converted in place, the return value is equal to lpsz. 
		/// <br/>
		/// <para>
		/// If the operand is a single character, the return value is a 32-bit value whose high-order word is zero, 
		/// and low-order word contains the converted character. 
		/// </para>
		/// <br/>
		/// <para>
		/// There is no indication of success or failure. Failure is rare. There is no extended error information for this function; 
		/// do not call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Note that CharUpper always maps lowercase I ("i") to uppercase I, even when the current language is Turkish or Azeri. 
		/// If you need a function that is linguistically sensitive in this respect, call LCMapString.
		/// <br/>
		/// <para>
		/// Conversion to Unicode in the ANSI version of the function is done with the system default locale in all cases.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = false, CharSet = CharSet. Auto )]
		public static extern String 	CharUpper ( ref String  lpsz  ) ;
		# endregion


		# region Version with char
		/// <summary>
		/// Converts a character string or a single character to uppercase. If the operand is a character string, 
		/// the function converts the characters in place. 
		/// </summary>
		/// <param name="lpsz">
		/// A null-terminated string, or a single character. 
		/// If the high-order word of this parameter is zero, the low-order word must contain a single character to be converted.
		/// </param>
		/// <returns>
		/// If the operand is a character string, the function returns a pointer to the converted string. 
		/// Because the string is converted in place, the return value is equal to lpsz. 
		/// <br/>
		/// <para>
		/// If the operand is a single character, the return value is a 32-bit value whose high-order word is zero, 
		/// and low-order word contains the converted character. 
		/// </para>
		/// <br/>
		/// <para>
		/// There is no indication of success or failure. Failure is rare. There is no extended error information for this function; 
		/// do not call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Note that CharUpper always maps lowercase I ("i") to uppercase I, even when the current language is Turkish or Azeri. 
		/// If you need a function that is linguistically sensitive in this respect, call LCMapString.
		/// <br/>
		/// <para>
		/// Conversion to Unicode in the ANSI version of the function is done with the system default locale in all cases.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = false, CharSet = CharSet. Auto )]
		public static extern char 	CharUpper ( char  lpsz  ) ;
		# endregion
	    }
    }