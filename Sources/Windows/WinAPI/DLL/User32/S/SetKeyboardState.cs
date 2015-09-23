/**************************************************************************************************************

    NAME
        WinAPI/Functions/S/SetKeyboardState.cs

    DESCRIPTION
        SetKeyboardState() Windows function.

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
		/// Copies an array of keyboard key states into the calling thread's keyboard input-state table. 
		/// This is the same table accessed by the GetKeyboardState and GetKeyState functions. Changes made to this table do not affect 
		/// keyboard input to any other thread. 
		/// </summary>
		/// <param name="lpKeyState">A pointer to a 256-byte array that contains keyboard key states. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// Because the SetKeyboardState function alters the input state of the calling thread and not the global input state of the system,
		/// an application cannot use SetKeyboardState to set the NUM LOCK, CAPS LOCK, or SCROLL LOCK (or the Japanese KANA) indicator lights 
		/// on the keyboard. These can be set or cleared using SendInput to simulate keystrokes.
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetKeyboardState ( byte []  lpKeyState ) ;
		# endregion
	    }
    }