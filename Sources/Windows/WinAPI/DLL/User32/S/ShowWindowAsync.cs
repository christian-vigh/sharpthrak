/**************************************************************************************************************

    NAME
        WinAPI/User32/S/ShowWindowAsync.cs

    DESCRIPTION
        ShowWindowAsync() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
		/// Sets the show state of a window created by a different thread. 
		/// </summary>
		/// <param name="hwnd">A handle to the window. </param>
		/// <param name="nCmdShow">Controls how the window is to be shown. For a list of possible values, see the description of the ShowWindow function. </param>
		/// <returns>
		/// If the window was previously visible, the return value is nonzero. 
		/// <para>
		/// If the window was previously hidden, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function posts a show-window event to the message queue of the given window. An application can use this function to avoid becoming nonresponsive 
		/// while waiting for a nonresponsive application to finish processing a show-window event.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern IntPtr 	ShowWindowAsync ( IntPtr  hwnd, SW_Constants  nCmdShow ) ;
		# endregion
	    }
    }