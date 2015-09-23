/**************************************************************************************************************

    NAME
        WinAPI/Functions/O/OemToChar.cs

    DESCRIPTION
        OemToChar() Windows function.

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
		# region Generic version.
		/// <summary>
		/// Translates a string from the OEM-defined character set into either an ANSI or a wide-character string.
		/// </summary>
		/// <param name="pSrc">A null-terminated string of characters from the OEM-defined character set. </param>
		/// <param name="pDst">
		/// The destination buffer, which receives the translated string. If the OemToChar function is being used as an ANSI function, 
		/// the string can be translated in place by setting the lpszDst parameter to the same address as the lpszSrc parameter. 
		/// This cannot be done if OemToChar is being used as a wide-character function.
		/// </param>
		/// <returns>
		/// The return value is always nonzero except when you pass the same address to lpszSrc and lpszDst in the wide-character version 
		/// of the function. In this case the function returns zero and GetLastError returns ERROR_INVALID_ADDRESS.
		/// </returns>
		/// <remarks>
		/// Using this function incorrectly can compromise the security of your application.
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	OemToChar ( String  pSrc, [Out] StringBuilder  pDst ) ;
		# endregion
	    }
    }