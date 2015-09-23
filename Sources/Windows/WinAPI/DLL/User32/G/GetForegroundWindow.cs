/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetForegroundWindow.cs

    DESCRIPTION
        GetForegroundWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
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
		/// Retrieves a handle to the foreground window (the window with which the user is currently working). 
		/// The system assigns a slightly higher priority to the thread that creates the foreground window than it does to other threads. 
		/// </summary>
		/// <returns>
		/// The return value is a handle to the foreground window. The foreground window can be NULL in certain circumstances, such as when a window is losing activation. 
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetForegroundWindow ( ) ;
		# endregion
	    }
    }