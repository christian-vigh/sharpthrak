/**************************************************************************************************************

    NAME
        WinAPI/User32/R/RegisterWindowMessage.cs

    DESCRIPTION
        RegisterWindowMessage() Windows function.

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
		/// Defines a new window message that is guaranteed to be unique throughout the system. The message value can be used when sending or posting messages.
 		/// </summary>
		/// <param name="lpString">The message to be registered.</param>
		/// <returns>
		/// If the message is successfully registered, the return value is a message identifier in the range 0xC000 through 0xFFFF.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	RegisterWindowMessage ( String  lpString ) ;
		# endregion
	    }
    }