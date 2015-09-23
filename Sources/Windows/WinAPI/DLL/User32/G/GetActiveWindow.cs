/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetActiveWindow.cs

    DESCRIPTION
        GetActiveWindow() Windows function.

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
		/// Retrieves the window handle to the active window attached to the calling thread's message queue. 
		/// </summary>
		/// <returns>
		/// The return value is the handle to the active window attached to the calling thread's message queue. 
		/// Otherwise, the return value is NULL. 
		/// </returns>
		/// <remarks>
		/// To get the handle to the foreground window, you can use GetForegroundWindow. 
		/// <para>
		/// To get the window handle to the active window in the message queue for another thread, use GetGUIThreadInfo.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetActiveWindow ( ) ;
		# endregion
	    }
    }