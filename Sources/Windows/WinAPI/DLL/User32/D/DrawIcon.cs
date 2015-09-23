/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DrawIcon.cs

    DESCRIPTION
        DrawIcon() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
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
		/// Draws an icon or cursor into the specified device context.
		/// <para>To specify additional drawing options, use the DrawIconEx function.</para>
		/// </summary>
		/// <param name="hDC">A handle to the device context into which the icon or cursor will be drawn. </param>
		/// <param name="X">The logical x-coordinate of the upper-left corner of the icon. </param>
		/// <param name="Y">The logical y-coordinate of the upper-left corner of the icon. </param>
		/// <param name="hIcon">A handle to the icon to be drawn. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// DrawIcon places the icon's upper-left corner at the location specified by the X and Y parameters. 
		/// The location is subject to the current mapping mode of the device context. 
		/// <br/>
		/// <para>
		/// DrawIcon draws the icon or cursor using the width and height specified by the system metric values for icons; for more information, see GetSystemMetrics.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	DrawIcon ( IntPtr  hDC, int  X, int  Y, IntPtr  hIcon ) ;
		# endregion
	    }
    }