/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CharPrev.cs

    DESCRIPTION
        CharPrev() Windows function.

    AUTHOR
        Christian Vigh, 09/2012.

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
		/// Retrieves a pointer to the preceding character in a string. 
		/// This function can handle strings consisting of either single- or multi-byte characters.
		/// </summary>
		/// <param name="lpsz">A character in a null-terminated string.</param>
		/// <returns>
		/// The return value is a pointer to the next character in the string, or to the terminating null character if at the end of the string.
		/// <br/>
		/// <para>
		/// If lpsz points to the terminating null character, the return value is equal to lpsz.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If lpsz points to the terminating null character, the return value is equal to lpsz.
		/// <br/>
		/// <para>
		/// This function works with default "user" expectations of characters when dealing with diacritics. 
		/// For example: A string that contains U+0061 U+030a "LATIN SMALL LETTER A" + COMBINING RING ABOVE" — which looks like "å", 
		/// will advance two code points, not one. A string that contains U+0061 U+0301 U+0302 U+0303 U+0304 — which looks like "a´^~¯", 
		/// will advance five code points, not one, and so on. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CharPrev ( IntPtr  lpsz ) ;
		# endregion
	    }
    }