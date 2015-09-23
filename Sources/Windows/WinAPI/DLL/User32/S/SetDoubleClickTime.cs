/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetDoubleClickTime.cs

    DESCRIPTION
        SetDoubleClickTime() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
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
		/// Sets the double-click time for the mouse. A double-click is a series of two clicks of a mouse button, the second occurring within a specified time after the first.
		/// <para>
		/// The double-click time is the maximum number of milliseconds that may occur between the first and second clicks of a double-click. 
		/// </para>
 		/// </summary>
		/// <param name="uInterval">
		/// The number of milliseconds that may occur between the first and second clicks of a double-click. 
		/// <para>
		/// If this parameter is set to 0, the system uses the default double-click time of 500 milliseconds. 
		/// </para>
		/// <para>
		/// If this parameter value is greater than 5000 milliseconds, the system sets the value to 5000 milliseconds.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The SetDoubleClickTime function alters the double-click time for all windows in the system. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetDoubleClickTime ( uint  uInterval ) ;
		# endregion
	    }
    }