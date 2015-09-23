/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetMessageExtraInfo.cs

    DESCRIPTION
        SetMessageExtraInfo() Windows function.

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
		/// Sets the extra message information for the current thread. Extra message information is an application- or driver-defined value associated with 
		/// the current thread's message queue. An application can use the GetMessageExtraInfo function to retrieve a thread's extra message information.
		/// </summary>
		/// <param name="lParam">The value to be associated with the current thread.</param>
		/// <returns>The return value is the previous value associated with the current thread.</returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	SetMessageExtraInfo ( IntPtr  lParam ) ;
		# endregion
	    }
    }