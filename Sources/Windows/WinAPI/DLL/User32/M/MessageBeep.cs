/**************************************************************************************************************

    NAME
        WinAPI/User32/M/MessageBeep.cs

    DESCRIPTION
        MessageBeep() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
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
		/// Plays a waveform sound. The waveform sound for each sound type is identified by an entry in the registry.
		/// </summary>
		/// <param name="uType">
		/// The sound to be played. The sounds are set by the user through the Sound control panel application, and then stored in the registry.
		/// <br/>
		/// <para>
		/// This parameter can be either 0xFFFFFFFF (A simple beep. If the sound card is not available, the sound is generated using the speaker),
		/// or any of the MB_ICONxxx constants.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <br/>
		/// <para>
		/// After queuing the sound, the MessageBeep function returns control to the calling function and plays the sound asynchronously.
		/// </para>
		/// <br/>
		/// <para>
		/// If it cannot play the specified alert sound, MessageBeep attempts to play the system default sound. 
		/// If it cannot play the system default sound, the function produces a standard beep sound through the computer speaker.
		/// </para>
		/// <br/>
		/// <para>
		/// The user can disable the warning beep by using the Sound control panel application.
		/// </para>
		/// <br/>
		/// <para>
		/// Note  To send a beep to a remote client, use the Beep function. The Beep function is redirected to the client, whereas MessageBeep is not.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	MessageBeep ( uint  uType ) ;
		# endregion
	    }
    }