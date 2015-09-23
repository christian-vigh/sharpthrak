/**************************************************************************************************************

    NAME
        IsWindow.cs

    DESCRIPTION
        IsWindow() API.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Determines whether the specified window handle identifies an existing window. 
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested. </param>
		/// <returns>
		/// If the window handle identifies an existing window, the return value is nonzero.
		/// <para>
		/// If the window handle does not identify an existing window, the return value is zero. 
		/// </para>
		/// </returns>
		[DllImport ( USER32 )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	IsWindow ( IntPtr  hWnd ) ;
		# endregion
	    }
    }
