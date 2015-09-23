/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetClipCursor.cs

    DESCRIPTION
        GetClipCursor() Windows function.

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
		/// Retrieves the screen coordinates of the rectangular area to which the cursor is confined. 
		/// </summary>
		/// <param name="lpRect">
		/// A pointer to a RECT structure that receives the screen coordinates of the confining rectangle. 
		/// The structure receives the dimensions of the screen if the cursor is not confined to a rectangle. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The cursor is a shared resource. If an application confines the cursor with the ClipCursor function, it must later release 
		/// the cursor by using ClipCursor before relinquishing control to another application. 
		/// <br/>
		/// <para>
		/// The calling process must have WINSTA_READATTRIBUTES access to the window station. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetClipCursor ( out RECT  lpRect ) ;
		# endregion
	    }
    }