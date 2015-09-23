/**************************************************************************************************************

    NAME
        WinAPI/Function/G/GetDoubleClickTime.cs

    DESCRIPTION
        GetDoubleClickTime API.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Retrieves the current double-click time for the mouse.
		/// <para>
		/// A double-click is a series of two clicks of the mouse button, the second occurring within a specified time after the first. 
		/// </para>
		/// <para>
		/// The double-click time is the maximum number of milliseconds that may occur between the first and second click of a double-click. 
		/// </para>
		/// <para>
		/// The maximum double-click time is 5000 milliseconds.
		/// </para>
 		/// </summary>
		/// <returns>
		/// The return value specifies the current double-click time, in milliseconds. The maximum return value is 5000 milliseconds.
		/// </returns>
		[DllImport ( USER32 )]
		public static extern uint	GetDoubleClickTime ( ) ;
		# endregion
	    }
    }
