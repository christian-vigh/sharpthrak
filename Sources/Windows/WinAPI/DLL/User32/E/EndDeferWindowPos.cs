/**************************************************************************************************************

    NAME
        WinAPI/User32/E/EndDeferWindowPos.cs

    DESCRIPTION
        EndDeferWindowPos() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
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
		/// Simultaneously updates the position and size of one or more windows in a single screen-refreshing cycle. 
		/// </summary>
		/// <param name="hWinPosInfo">
		/// A handle to a multiple-window – position structure that contains size and position information for one or more windows. 
		/// This internal structure is returned by the BeginDeferWindowPos function or by the most recent call to the DeferWindowPos function. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The EndDeferWindowPos function sends the WM_WINDOWPOSCHANGING and WM_WINDOWPOSCHANGED messages to each window identified in the internal structure. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	EndDeferWindowPos ( IntPtr  hWinPosInfo ) ;
		# endregion
	    }
    }