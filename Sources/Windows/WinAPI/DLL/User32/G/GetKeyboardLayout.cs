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
		/// Retrieves the active input locale identifier (formerly called the keyboard layout) for the specified thread. 
		/// If the idThread parameter is zero, the input locale identifier for the active thread is returned.
		/// </summary>
		/// <param name="idThread">The identifier of the thread to query, or 0 for the current thread. </param>
		/// <returns>
		/// The return value is the input locale identifier for the thread. The low word contains a Language Identifier for the input language 
		/// and the high word contains a device handle to the physical layout of the keyboard.
		/// </returns>
		/// <remarks>
		/// The input locale identifier is a broader concept than a keyboard layout, since it can also encompass a speech-to-text converter,
		/// an Input Method Editor (IME), or any other form of input. 
		/// <br/>
		/// <para>
		/// Since the keyboard layout can be dynamically changed, applications that cache information about the current keyboard layout 
		/// should process the WM_INPUTLANGCHANGE message to be informed of changes in the input language.
		/// </para>
		/// <br/>
		/// <para>
		/// To get the KLID (keyboard layout ID) of the currently active HKL, call the GetKeyboardLayoutName.
		/// To find out if a particular KLID is loaded, call GetKeyboardLayoutList, load the keyboard with LoadKeyboardLayout, 
		/// and then check to see if the HKL is the same as the one already loaded. If not, unload it after. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	GetKeyboardLayout ( uint  idThread ) ;
		# endregion
	    }
    }