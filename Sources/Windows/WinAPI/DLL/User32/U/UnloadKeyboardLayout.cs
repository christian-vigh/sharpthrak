/**************************************************************************************************************

    NAME
        WinAPI/Functions/U/UnloadKeyboardLayout.cs

    DESCRIPTION
        UnloadKeyboardLayout() Windows function.

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
		/// Unloads an input locale identifier (formerly called a keyboard layout). 
		/// </summary>
		/// <param name="hKl">The input locale identifier to be unloaded. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. The function can fail for the following reasons: 
		/// </para>
		/// <para>• An invalid input locale identifier was passed.</para>
		/// <para>• The input locale identifier was preloaded.</para>
		/// <para>• The input locale identifier is in use.</para>
		/// <br/>
		/// <para>
		/// To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The input locale identifier is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter,  
		/// an Input Method Editor (IME), or any other form of input. 
		/// <br/>
		/// <para>
		/// UnloadKeyboardLayout cannot unload the system default input locale identifier if it is the only keyboard layout loaded. 
		/// You must first load another input locale identifier before unloading the default input locale identifier.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	UnloadKeyboardLayout ( uint  hKl ) ;
		# endregion
	    }
    }