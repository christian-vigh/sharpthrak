/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetFocus.cs

    DESCRIPTION
        GetFocus() Windows function.

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
		/// Retrieves the handle to the window that has the keyboard focus, if the window is attached to the calling thread's message queue.
		/// </summary>
		/// <returns>
		/// The return value is the handle to the window with the keyboard focus. If the calling thread's message queue does not have 
		/// an associated window with the keyboard focus, the return value is NULL. 
		/// </returns>
		/// <remarks>
		/// GetFocus returns the window with the keyboard focus for the current thread's message queue. If GetFocus returns NULL, 
		/// another thread's queue may be attached to a window that has the keyboard focus.
		/// <br/>
		/// <para>
		/// Use the GetForegroundWindow function to retrieve the handle to the window with which the user is currently working. 
		/// You can associate your thread's message queue with the windows owned by another thread by using the AttachThreadInput function. 
		/// </para>
		/// <br/>
		/// <para>
		/// To get the window with the keyboard focus on the foreground queue or the queue of another thread, use the GetGUIThreadInfo function.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetFocus ( ) ;
		# endregion
	    }
    }