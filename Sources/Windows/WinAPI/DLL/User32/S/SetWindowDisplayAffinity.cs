/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetWindowDisplayAffinity.cs

    DESCRIPTION
        SetWindowDisplayAffinity() Windows function.

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
		/// Stores the display affinity setting in kernel mode on the hWnd associated with the window. 
		/// </summary>
		/// <param name="hwnd">A handle to the window. </param>
		/// <param name="dwAffinity">
		/// The display affinity setting. This setting specifies where the window's contents are allowed to be displayed. 
		/// If the value is set to 0x0000001, the window's contents can only be displayed on a monitor. 
		/// </param>
		/// <returns>
		/// If the function succeeds, it returns TRUE; otherwise, it returns FALSE when, for example, the function call is made on a non top-level window. 
		/// To get extended error information, call GetLastError. 
		/// </returns>
		/// <remarks>
		/// This function and GetWindowDisplayAffinity are designed to support the window content protection feature that is new to Windows 7. 
		/// This feature enables applications to protect their own onscreen window content from being captured or copied through a specific set of 
		/// public operating system features and APIs. However, it works only when the Desktop Window Manager(DWM) is composing the desktop. 
		/// <br/>
		/// <para>
		/// It is important to note that unlike a security feature or an implementation of Digital Rights Management (DRM), there is no guarantee that 
		/// using SetWindowDisplayAffinity and GetWindowDisplayAffinity, and other necessary functions such as DwmIsCompositionEnabled, will strictly protect 
		/// windowed content, for example where someone takes a photograph of the screen.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetWindowDisplayAffinity ( IntPtr  hwnd, uint  dwAffinity ) ;
		# endregion
	    }
    }