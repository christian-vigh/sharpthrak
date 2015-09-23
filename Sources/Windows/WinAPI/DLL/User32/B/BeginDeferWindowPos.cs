/**************************************************************************************************************

    NAME
        WinAPI/User32/B/BeginDeferWindowPos.cs

    DESCRIPTION
        BeginDeferWindowPos() Windows function.

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
		/// Allocates memory for a multiple-window- position structure and returns the handle to the structure. 
		/// </summary>
		/// <param name="nNumWindows">
		/// The initial number of windows for which to store position information. 
		/// The DeferWindowPos function increases the size of the structure, if necessary.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value identifies the multiple-window-position structure. If insufficient system resources are available to allocate 
		/// the structure, the return value is NULL. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// The multiple-window-position structure is an internal structure; an application cannot access it directly. 
		/// <br/>
		/// <para>
		/// DeferWindowPos fills the multiple-window-position structure with information about the target position for one or more windows about to be moved. 
		/// The EndDeferWindowPos function accepts the handle to this structure and repositions the windows by using the information stored in the structure. 
		/// </para>
		/// <br/>
		/// <para>
		/// If any of the windows in the multiple-window- position structure have the SWP_HIDEWINDOW or SWP_SHOWWINDOW flag set, none of the windows are repositioned.
		/// </para>
		/// <br/>
		/// <para>
		/// If the system must increase the size of the multiple-window- position structure beyond the initial size specified by the nNumWindows parameter but 
		/// cannot allocate enough memory to do so, the system fails the entire window positioning sequence (BeginDeferWindowPos, DeferWindowPos, and EndDeferWindowPos). 
		/// By specifying the maximum size needed, an application can detect and process failure early in the process. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	BeginDeferWindowPos ( int  nNumWindows ) ;
		# endregion
	    }
    }