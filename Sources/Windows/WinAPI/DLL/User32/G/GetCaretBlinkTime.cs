/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetCaretBlinkTime.cs

    DESCRIPTION
        GetCaretBlinkTime() Windows function.

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
		/// Retrieves the time required to invert the caret's pixels. The user can set this value. 
		/// </summary>
		/// <returns>
		/// If the function succeeds, the return value is the blink time, in milliseconds. 
		/// <para>A return value of INFINITE indicates that the caret does not blink.</para>
		/// <para>A return value is zero indicates that the function has failed. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	GetCaretBlinkTime ( ) ;
		# endregion
	    }
    }