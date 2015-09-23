/**************************************************************************************************************

    NAME
        WinAPI/User32/S/ShowCursor.cs

    DESCRIPTION
        ShowCursor() Windows function.

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
		/// Displays or hides the cursor. 
		/// </summary>
		/// <param name="bShow">
		/// If bShow is TRUE, the display count is incremented by one. If bShow is FALSE, the display count is decremented by one. 
		/// </param>
		/// <returns>The return value specifies the new display counter.</returns>
		/// <remarks>
		/// This function sets an internal display counter that determines whether the cursor should be displayed. 
		/// The cursor is displayed only if the display count is greater than or equal to 0. If a mouse is installed, the initial display count is 0.
		/// If no mouse is installed, the display count is –1. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	ShowCursor ( bool  bShow ) ;
		# endregion
	    }
    }