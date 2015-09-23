/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsWow64Message.cs

    DESCRIPTION
        IsWow64Message() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
		/// Determines whether the last message read from the current thread's queue originated from a WOW64 process.
 		/// </summary>
		/// <returns>
		/// The function returns TRUE if the last message read from the current thread's queue originated from a WOW64 process, and FALSE otherwise.
		/// </returns>
		/// <remarks>
		/// This function is useful to helping you develop 64-bit native applications that can receive private messages sent from 32-bit client applications, 
		/// if the messages are associated with data structures that contain pointer-dependent data. In these situations, you can call this function 
		/// in your 64-bit native application to determine if the message originated from a WOW64 process and then thunk the message appropriately.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsWow64Message ( ) ;
		# endregion
	    }
    }