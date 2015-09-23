/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DisableProcessWindowsGhosting.cs

    DESCRIPTION
        DisableProcessWindowsGhosting() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Disables the window ghosting feature for the calling GUI process. Window ghosting is a Windows Manager feature that lets the user minimize, move, 
		/// or close the main window of an application that is not responding.
 		/// </summary>
		/// <remarks>
		/// After calling DisableProcessWindowsGhosting, the ghosting feature is disabled for the duration of the process. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	DisableProcessWindowsGhosting ( ) ;
		# endregion
	    }
    }