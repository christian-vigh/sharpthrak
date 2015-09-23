/**************************************************************************************************************

    NAME
        WinAPI/User32/I/IsWindowUnicode.cs

    DESCRIPTION
        IsWindowUnicode() Windows function.

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
		/// Determines whether the specified window is a native Unicode window. 
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested. </param>
		/// <returns>
		/// If the window is a native Unicode window, the return value is nonzero.
		/// <para>
		/// If the window is not a native Unicode window, the return value is zero. The window is a native ANSI window.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The character set of a window is determined by the use of the RegisterClass function. If the window class was registered with the ANSI version 
		/// of RegisterClass (RegisterClassA), the character set of the window is ANSI. If the window class was registered with the Unicode version of RegisterClass 
		/// (RegisterClassW), the character set of the window is Unicode. 
		/// <para>
		/// The system does automatic two-way translation (Unicode to ANSI) for window messages. For example, if an ANSI window message is sent to a window that uses 
		/// the Unicode character set, the system translates that message into a Unicode message before calling the window procedure. 
		/// </para>
		/// <para>
		/// The system calls IsWindowUnicode to determine whether to translate the message. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType.Bool )]
		public static extern bool 	IsWindowUnicode ( IntPtr  hWnd ) ;
		# endregion
	    }
    }