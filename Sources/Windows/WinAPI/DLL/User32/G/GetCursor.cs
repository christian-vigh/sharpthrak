/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetCursor.cs

    DESCRIPTION
        GetCursor() Windows function.

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
		/// Retrieves a handle to the current cursor.
		/// <br/>
		/// <para>
		/// To get information on the global cursor, even if it is not owned by the current thread, use GetCursorInfo.
		/// </para>
		/// </summary>
		/// <returns>The return value is the handle to the current cursor. If there is no cursor, the return value is NULL. </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern IntPtr 	GetCursor ( ) ;
		# endregion
	    }
    }