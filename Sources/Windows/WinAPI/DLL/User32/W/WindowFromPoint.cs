/**************************************************************************************************************

    NAME
        WinAPI/User32/W/WindowFromPoint.cs

    DESCRIPTION
        WindowFromPoint() Windows function.

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
		/// Retrieves a handle to the window that contains the specified point. 
		/// </summary>
		/// <param name="point">The point to be checked. </param>
		/// <returns>
		/// The return value is a handle to the window that contains the point. If no window exists at the given point, the return value is NULL. 
		/// If the point is over a static text control, the return value is a handle to the window under the static text control. 
		/// </returns>
		/// <remarks>
		/// The WindowFromPoint function does not retrieve a handle to a hidden or disabled window, even if the point is within the window. 
		/// An application should use the ChildWindowFromPoint function for a nonrestrictive search. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	WindowFromPoint ( POINT  point ) ;
		# endregion
	    }
    }