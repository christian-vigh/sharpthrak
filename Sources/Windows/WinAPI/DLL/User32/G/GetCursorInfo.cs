/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetCursorInfo.cs

    DESCRIPTION
        GetCursorInfo() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
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
		# region Generic version
		/// <summary>
		/// Retrieves information about the global cursor.
		/// </summary>
		/// <param name="pci">
		/// A pointer to a CURSORINFO structure that receives the information. 
		/// <para>
		/// Note that you must set the cbSize member to sizeof(CURSORINFO) before calling this function.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int	GetCursorInfo ( ref CURSORINFO  pci ) ;
		# endregion
	    }
    }