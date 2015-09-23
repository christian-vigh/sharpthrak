/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetCaretPos.cs

    DESCRIPTION
        GetCaretPos() Windows function.

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
		/// Copies the caret's position to the specified POINT structure. 
		/// </summary>
		/// <param name="lpPoint">A pointer to the POINT structure that is to receive the client coordinates of the caret. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. 
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// The caret position is always given in the client coordinates of the window that contains the caret. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetCaretPos ( out POINT  lpPoint ) ;
		# endregion
	    }
    }