/**************************************************************************************************************

    NAME
        WinAPI/Functions/I/IsCharAlphaNumeric.cs

    DESCRIPTION
        IsCharAlphaNumeric() Windows function.

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
		/// Determines whether a character is either an alphabetical or a numeric character. This determination is based on the semantics 
		/// of the language selected by the user during setup or through Control Panel. 
		/// </summary>
		/// <param name="ch">The character to be tested.</param>
		/// <returns>
		/// If the character is alphanumeric, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the character is not alphanumeric, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsCharAlphaNumeric ( char  ch ) ;
		# endregion
	    }
    }