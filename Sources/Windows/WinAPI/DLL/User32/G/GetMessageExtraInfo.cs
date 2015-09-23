/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetMessageExtraInfo.cs

    DESCRIPTION
        GetMessageExtraInfo() Windows function.

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
		/// Retrieves the extra message information for the current thread. Extra message information is an application- or driver-defined value associated 
		/// with the current thread's message queue. 
 		/// </summary>
		/// <returns>
		/// The return value specifies the extra information. The meaning of the extra information is device specific.
		/// </returns>
		/// <remarks>
		/// To set a thread's extra message information, use the SetMessageExtraInfo function. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetMessageExtraInfo ( ) ;
		# endregion
	    }
    }