/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsWindowEnabled.cs

    DESCRIPTION
        IsWindowEnabled() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/27]     [Author : CV]
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
		/// Determines whether the specified window is enabled for mouse and keyboard input. 
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested. </param>
		/// <returns>
		/// If the window is enabled, the return value is nonzero.
		/// <para>
		/// If the window is not enabled, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>A child window receives input only if it is both enabled and visible. </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	IsWindowEnabled ( IntPtr  hWnd ) ;
		# endregion
	    }
    }