/**************************************************************************************************************

    NAME
        WinAPI/User32/P/PaintDesktop.cs

    DESCRIPTION
        PaintDesktop() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
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
		/// The PaintDesktop function fills the clipping region in the specified device context with the desktop pattern or wallpaper. 
		/// The function is provided primarily for shell desktops.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	PaintDesktop ( IntPtr  hdc ) ;
		# endregion
	    }
    }