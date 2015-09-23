/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetMessageQueue.cs

    DESCRIPTION
        SetMessageQueue() Windows function.

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
		/// <summary>The SetMessageQueue function is obsolete. This function is provided only for compatibility for 16-bit versions of Windows. 
		/// This function does nothing on Win32 platforms, because message queues are expanded dynamically as necessary.  		
		/// </summary>
		/// <param name="cMessagesMax">
		/// Maximum size of the message queue.
		/// </param>
		/// <returns>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetMessageQueue ( int  cMessagesMax ) ;
		# endregion
	    }
    }