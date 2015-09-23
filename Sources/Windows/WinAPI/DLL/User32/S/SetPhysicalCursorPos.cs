/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetPhysicalCursorPos.cs

    DESCRIPTION
        SetPhysicalCursorPos() Windows function.

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
		/// Sets the position of the cursor in physical coordinates.
		/// </summary>
		/// <param name="X">The new x-coordinate of the cursor, in physical coordinates. </param>
		/// <param name="Y">The new y-coordinate of the cursor, in physical coordinates. </param>
		/// <returns>TRUE if successful; otherwise FALSE.</returns>
		/// <remarks>
		/// For a description of the difference between logicial coordinates and physical coordinates, see PhysicalToLogicalPoint.
		/// <para>
		/// GetLastError can be called to get more information about any error that is generated.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetPhysicalCursorPos ( int  X, int  Y ) ;
		# endregion
	    }
    }