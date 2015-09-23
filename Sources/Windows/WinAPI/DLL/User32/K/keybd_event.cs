/**************************************************************************************************************

    NAME
        WinAPI/Functions/K/keybd_event.cs

    DESCRIPTION
        keybd_event() Windows function.

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
		/// Synthesizes a keystroke. The system can use such a synthesized keystroke to generate a WM_KEYUP or WM_KEYDOWN message.
		/// The keyboard driver's interrupt handler calls the keybd_event function.
		/// <br/>
		/// <para>
		/// Note : This function has been superseded. Use SendInput instead.
		/// </para>
		/// </summary>
		/// <param name="bVk">
		/// A virtual-key code. The code must be a value in the range 1 to 254. For a complete list, see Virtual Key Codes. 
		/// </param>
		/// <param name="bScan">A hardware scan code for the key.</param>
		/// <param name="dwFlags">
		/// Controls various aspects of function operation. This parameter can be one or more of the KEYEVENTF_Constants values.
		/// </param>
		/// <param name="dwExtraInfo">An additional value associated with the key stroke. </param>
		/// <remarks>
		/// An application can simulate a press of the PRINTSCRN key in order to obtain a screen snapshot and save it to the clipboard. 
		/// To do this, call keybd_event with the bVk parameter set to VK_SNAPSHOT. 
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern void 	keybd_event ( VK_Constants  bVk, byte  bScan, KEYEVENTF_Constants  dwFlags, IntPtr  dwExtraInfo ) ;
		# endregion
	    }
    }