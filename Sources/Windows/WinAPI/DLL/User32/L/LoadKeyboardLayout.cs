/**************************************************************************************************************

    NAME
        WinAPI/Functions/L/LoadKeyboardLayout.cs

    DESCRIPTION
        LoadKeyboardLayout() Windows function.

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
		/// Loads a new input locale identifier (formerly called the keyboard layout) into the system. Several input locale identifiers can be loaded
		/// at a time, but only one per process is active at a time. Loading multiple input locale identifiers makes it possible to rapidly switch 
		/// between them.
		/// </summary>
		/// <param name="pwszKLID">
		/// The name of the input locale identifier to load. This name is a string composed of the hexadecimal value of the Language Identifier 
		/// (low word) and a device identifier (high word). For example, U.S. English has a language identifier of 0x0409, 
		/// so the primary U.S. English layout is named "00000409". Variants of U.S. English layout (such as the Dvorak layout) are named
		/// "00010409", "00020409", and so on. 
		/// </param>
		/// <param name="Flags">
		/// Specifies how the input locale identifier is to be loaded. This parameter can be one of the KLF_Constants values.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the input locale identifier to the locale matched with the requested name. 
		/// If no matching locale is available, the return value is NULL. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// This function only affects the layout for the current process or thread. 
		/// <br/>
		/// <para>
		/// The input locale identifier is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter, 
		/// an Input Method Editor (IME), or any other form of input. 
		/// </para>
		/// <br/>
		/// <para>
		/// An application can and will typically load the default input locale identifier or IME for a language and can do so by specifying only 
		/// a string version of the language identifier. If an application wants to load a specific locale or IME, it should read the registry
		/// to determine the specific input locale identifier to pass to LoadKeyboardLayout. In this case, a request to activate 
		/// the default input locale identifier for a locale will activate the first matching one. A specific IME should be activated using
		/// an explicit input locale identifier returned from GetKeyboardLayout or LoadKeyboardLayout.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	LoadKeyboardLayout ( String  pwszKLID, KLF_Constants  Flags ) ;
		# endregion
	    }
    }