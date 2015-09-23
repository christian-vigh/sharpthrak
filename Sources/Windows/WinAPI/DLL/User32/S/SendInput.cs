/**************************************************************************************************************

    NAME
        WinAPI/Functions/S/SendInput.cs

    DESCRIPTION
        SendInput() Windows function.

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
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="nInputs">The number of structures in the pInputs array.</param>
		/// <param name="pInputs">
		/// An array of INPUT structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.
		/// </param>
		/// <param name="cbSize">
		/// The size, in bytes, of an INPUT structure. If cbSize is not the size of an INPUT structure, the function fails.
		/// </param>
		/// <returns>
		/// The function returns the number of events that it successfully inserted into the keyboard or mouse input stream. 
		/// If the function returns zero, the input was already blocked by another thread. To get extended error information, call GetLastError.
		/// <br/>
		/// <para>
		/// This function fails when it is blocked by UIPI. Note that neither GetLastError nor the return value will indicate the failure 
		/// was caused by UIPI blocking.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function is subject to UIPI. Applications are permitted to inject input only into applications that are at an equal or 
		/// lesser integrity level.
		/// <br/>
		/// <para>
		/// The SendInput function inserts the events in the INPUT structures serially into the keyboard or mouse input stream. 
		/// These events are not interspersed with other keyboard or mouse input events inserted either by the user (with the keyboard or mouse) 
		/// or by calls to keybd_event, mouse_event, or other calls to SendInput.
		/// </para>
		/// <br/>
		/// <para>
		/// This function does not reset the keyboard's current state. Any keys that are already pressed when the function is called 
		/// might interfere with the events that this function generates. To avoid this problem, check the keyboard's state with the 
		/// GetAsyncKeyState function and correct as necessary.
		/// </para>
		/// <br/>
		/// <para>
		/// Because the touch keyboard uses the surrogate macros defined in winnls.h to send input to the system, a listener 
		/// on the keyboard event hook must decode input originating from the touch keyboard. 
		/// </para>
		/// <br/>
		/// <para>
		/// An accessibility application can use SendInput to inject keystrokes corresponding to application launch shortcut keys 
		/// that are handled by the shell. This functionality is not guaranteed to work for other types of applications. 
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	SendInput ( uint  nInputs, INPUT []  pInputs, int  cbSize ) ;
		# endregion
	    }
    }