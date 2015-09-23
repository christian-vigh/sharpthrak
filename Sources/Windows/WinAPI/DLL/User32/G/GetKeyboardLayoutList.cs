/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKeyboardLayout.cs

    DESCRIPTION
        GetKeyboardLayout() Windows function.

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
 		/// Retrieves the input locale identifiers (formerly called keyboard layout handles) corresponding to the current set of input locales 
		/// in the system. The function copies the identifiers to the specified buffer.
		/// </summary>
		/// <param name="nBuff">The maximum number of handles that the buffer can hold. </param>
		/// <param name="lpList">A pointer to the buffer that receives the array of input locale identifiers. </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of input locale identifiers copied to the buffer or, if nBuff is zero,
		/// the return value is the size, in array elements, of the buffer needed to receive all current input locale identifiers.
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
		public static extern uint 	GetKeyboardLayoutList ( int  nBuff, uint []  lpList ) ;
		# endregion
	    }
    }