/**************************************************************************************************************

    NAME
        WinAPI/Functions/A/ActivateKeyboardLayout.cs

    DESCRIPTION
        ActivateKeyboardLayout() Windows function.

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
		/// Sets the input locale identifier (formerly called the keyboard layout handle) for the calling thread or the current process. 
		/// The input locale identifier specifies a locale as well as the physical layout of the keyboard.
		/// </summary>
		/// <param name="hKl">
		/// Input locale identifier to be activated.
		/// <br/>
		/// <para>
		/// The input locale identifier must have been loaded by a previous call to the LoadKeyboardLayout function. 
		/// This parameter must be either the handle to a keyboard layout or one of the HKL_Constants values.
		/// </para>
		/// </param>
		/// <param name="Flags">
		/// Specifies how the input locale identifier is to be activated. This parameter can be one of the KLF_Constants values.
		/// </param>
		/// <returns>
		/// The return value is of type HKL. If the function succeeds, the return value is the previous input locale identifier. Otherwise, it is zero. 
		/// <br/>
		/// <para>
		/// To get extended error information, use the GetLastError function.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function only affects the layout for the current process or thread. 
		/// <br/>
		/// <para>
		/// This function is not restricted to keyboard layouts. The hkl parameter is actually an input locale identifier. 
		/// This is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter, an Input Method Editor (IME),
		/// or any other form of input. Several input locale identifiers can be loaded at any one time, but only one is active at a time.
		/// Loading multiple input locale identifiers makes it possible to rapidly switch between them. 
		/// </para>
		/// <br/>
		/// <para>
		/// When multiple IMEs are allowed for each locale, passing an input locale identifier in which the high word (the device handle) is zero 
		/// activates the first IME in the list belonging to the locale.
		/// </para>
		/// <br/>
		/// <para>
		/// The KLF_RESET and KLF_SHIFTLOCK flags alter the method by which the Caps Lock state is turned off. By default, the Caps Lock state 
		/// is turned off by hitting the Caps Lock key again. If only KLF_RESET is set, the default state is reestablished. 
		/// If KLF_RESET and KLF_SHIFTLOCK are set, the Caps Lock state is turned off by pressing either Caps Lock key.
		/// This feature is used to conform to local keyboard behavior standards as well as for personal preferences.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ActivateKeyboardLayout ( uint  hKl, KLF_Constants  Flags ) ;
		# endregion
	    }
    }