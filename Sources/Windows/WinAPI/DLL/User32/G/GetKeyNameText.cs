/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKeyNameText.cs

    DESCRIPTION
        GetKeyNameText() Windows function.

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
		/// Retrieves a string that represents the name of a key. 
		/// </summary>
		/// <param name="lParam">The second parameter of the keyboard message (such as WM_KEYDOWN) to be processed.</param>
		/// <param name="lpString">The buffer that will receive the key name. </param>
		/// <param name="nSize">
		/// The maximum length, in characters, of the key name, including the terminating null character. 
		/// (This parameter should be equal to the size of the buffer pointed to by the lpString parameter.) 
		/// </param>
		/// <returns>
		/// If the function succeeds, a null-terminated string is copied into the specified buffer, and the return value is the length of the string,
		/// in characters, not counting the terminating null character. 
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The format of the key-name string depends on the current keyboard layout. The keyboard driver maintains a list of names in the form 
		/// of character strings for keys with names longer than a single character. The key name is translated according to the layout of 
		/// the currently installed keyboard, thus the function may give different results for different input locales. 
		/// The name of a character key is the character itself. The names of dead keys are spelled out in full. 
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int  GetKeyNameText ( int  lParam, [Out] StringBuilder lpString, int  nSize ) ;
		# endregion


		# region Version with an OUT String
		/// <summary>
		/// Retrieves a string that represents the name of a key. 
		/// </summary>
		/// <param name="lParam">The second parameter of the keyboard message (such as WM_KEYDOWN) to be processed.</param>
		/// <param name="lpString">The buffer that will receive the key name. </param>
		/// <param name="nSize">
		/// The maximum length, in characters, of the key name, including the terminating null character. 
		/// (This parameter should be equal to the size of the buffer pointed to by the lpString parameter.) 
		/// </param>
		/// <returns>
		/// If the function succeeds, a null-terminated string is copied into the specified buffer, and the return value is the length of the string,
		/// in characters, not counting the terminating null character. 
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The format of the key-name string depends on the current keyboard layout. The keyboard driver maintains a list of names in the form 
		/// of character strings for keys with names longer than a single character. The key name is translated according to the layout of 
		/// the currently installed keyboard, thus the function may give different results for different input locales. 
		/// The name of a character key is the character itself. The names of dead keys are spelled out in full. 
		/// </remarks>
		public static int  GetKeyNameText ( int  lParam, out String  lpString )
		   {
			StringBuilder		Result		=  new StringBuilder ( Defines. DEFAULT_OUT_STRING_LENGTH ) ;
			int			Status ;

			Status		=  GetKeyNameText ( lParam, Result, Result. Capacity ) ;
			lpString	=  Result. ToString ( ) ;

			return ( Status ) ;
		    }
		# endregion
	    }
    }