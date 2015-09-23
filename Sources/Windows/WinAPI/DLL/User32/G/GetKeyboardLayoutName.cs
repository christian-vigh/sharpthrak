/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKeyboardLayoutName.cs

    DESCRIPTION
        GetKeyboardLayoutName() Windows function.

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
		/// Retrieves the name of the active input locale identifier (formerly called the keyboard layout) for the system. 
		/// </summary>
		/// <param name="pwszKLID">
		/// The buffer (of at least KL_NAMELENGTH characters in length) that receives the name of the input locale identifier, 
		/// including the terminating null character. This will be a copy of the string provided to the LoadKeyboardLayout function, 
		/// unless layout substitution took place. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The input locale identifier is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter, 
		/// an Input Method Editor (IME), or any other form of input. 
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	GetKeyboardLayoutName ( StringBuilder  pwszKLID ) ;
		# endregion
	    }
    }