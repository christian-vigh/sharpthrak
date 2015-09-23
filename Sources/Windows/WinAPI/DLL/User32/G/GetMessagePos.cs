/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetMessagePos.cs

    DESCRIPTION
        GetMessagePos() Windows function.

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
		/// Retrieves the cursor position for the last message retrieved by the GetMessage function. 
		/// <para>
		/// To determine the current position of the cursor, use the GetCursorPos function.
		/// </para>
 		/// </summary>
		/// <returns>
		/// The return value specifies the x- and y-coordinates of the cursor position. The x-coordinate is the low order short and the y-coordinate is the high-order short.
		/// </returns>
		/// <remarks>
		/// As noted above, the x-coordinate is in the low-order short of the return value; the y-coordinate is in the high-order short 
		/// (both represent signed values because they can take negative values on systems with multiple monitors). 
		/// If the return value is assigned to a variable, you can use the MAKEPOINTS macro to obtain a POINTS structure from the return value. 
		/// You can also use the GET_X_LPARAM or GET_Y_LPARAM macro to extract the x- or y-coordinate. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	GetMessagePos ( ) ;
		# endregion
	    }
    }