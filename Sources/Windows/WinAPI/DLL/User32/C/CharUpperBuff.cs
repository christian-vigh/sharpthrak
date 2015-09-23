/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CharUpperBuff.cs

    DESCRIPTION
        CharUpperBuff() Windows function.

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
		/// Converts lowercase characters in a buffer to uppercase characters. The function converts the characters in place. 
		/// </summary>
		/// <param name="lpsz">A buffer containing one or more characters to be processed.</param>
		/// <param name="cchLength">
		/// The size, in characters, of the buffer pointed to by lpsz.
		/// <br/>
		/// <para>
		/// The function examines each character, and converts lowercase characters to uppercase characters. The function examines the number 
		/// of characters indicated by cchLength, even if one or more characters are null characters. 
		/// </para>
		/// </param>
		/// <returns>
		/// The return value is the number of characters processed.
		/// <para>
		/// For example, if CharUpperBuff("Zenith of API Sets", 10) succeeds, the return value is 10.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Note that CharUpperBuff always maps lowercase I ("i") to uppercase I, even when the current language is Turkish or Azeri. 
		/// If you need a function that is linguistically sensitive in this respect, call LCMapString.
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	CharUpperBuff ( ref String  lpsz, uint  cchLength ) ;
		# endregion
	    }
    }