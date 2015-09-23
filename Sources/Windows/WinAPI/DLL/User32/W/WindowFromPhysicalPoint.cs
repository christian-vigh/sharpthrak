/**************************************************************************************************************

    NAME
        WinAPI/User32/W/WindowFromPhysicalPoint.cs

    DESCRIPTION
        WindowFromPhysicalPoint() Windows function.

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
		/// Retrieves a handle to the window that contains the specified physical point.
		/// </summary>
		/// <param name="point">The physical coordinates of the point.</param>
		/// <returns>A handle to the window that contains the given physical point. If no window exists at the point, this value is NULL.</returns>
		/// <remarks>
		/// The WindowFromPhysicalPoint function does not retrieve a handle to a hidden or disabled window, even if the point is within the window.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	WindowFromPhysicalPoint ( POINT  point ) ;
		# endregion
	    }
    }