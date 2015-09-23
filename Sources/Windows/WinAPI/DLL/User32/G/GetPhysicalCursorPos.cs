/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetPhysicalCursorPos.cs

    DESCRIPTION
        GetPhysicalCursorPos() Windows function.

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
		/// Retrieves the position of the cursor in physical coordinates.
		/// </summary>
		/// <param name="lpPoint">The position of the cursor, in physical coordinates.</param>
		/// <returns>
		/// TRUE if successful; otherwise FALSE.
		/// <br/>
		/// <para>
		/// For a description of the difference between logicial coordinates and physical coordinates, see PhysicalToLogicalPoint.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetPhysicalCursorPos ( out POINT  lpPoint ) ;
		# endregion
	    }
    }