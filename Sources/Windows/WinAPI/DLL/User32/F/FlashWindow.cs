/**************************************************************************************************************

    NAME
        WinAPI/User32/F/FlashWindow.cs

    DESCRIPTION
        FlashWindow() Windows function.

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
		/// Flashes the specified window one time. It does not change the active state of the window.
		/// <para>
		/// To flash the window a specified number of times, use the FlashWindowEx function.
		/// </para> 
		/// </summary>
		/// <param name="hwnd">A handle to the window to be flashed. The window can be either open or minimized.</param>
		/// <param name="bInvert">
		/// If this parameter is TRUE, the window is flashed from one state to the other. If it is FALSE, the window is returned to its original state 
		/// (either active or inactive). 
		/// <para>
		/// When an application is minimized and this parameter is TRUE, the taskbar window button flashes active/inactive. 
		/// If it is FALSE, the taskbar window button flashes inactive, meaning that it does not change colors. It flashes, as if it were being redrawn, 
		/// but it does not provide the visual invert clue to the user.
		/// </para>
		/// </param>
		/// <returns>
		/// The return value specifies the window's state before the call to the FlashWindow function. 
		/// If the window caption was drawn as active before the call, the return value is nonzero. Otherwise, the return value is zero.
		/// </returns>
		/// <remarks>
		/// Flashing a window means changing the appearance of its caption bar as if the window were changing from inactive to active status, or vice versa. 
		/// (An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.)
		/// <br/>
		/// <para>
		/// Typically, a window is flashed to inform the user that the window requires attention but that it does not currently have the keyboard focus.
		/// </para>
		/// <br/>
		/// <para>
		/// The FlashWindow function flashes the window only once; for repeated flashing, the application should create a system timer.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	FlashWindow ( IntPtr  hwnd, bool  bInvert ) ;
		# endregion
	    }
    }