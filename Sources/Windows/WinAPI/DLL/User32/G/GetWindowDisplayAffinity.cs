/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowDisplayAffinity.cs

    DESCRIPTION
        GetWindowDisplayAffinity() Windows function.

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
		/// Retrieves the current display affinity setting, from any process, for a given window.
		/// </summary>
		/// <param name="hwnd">A handle to the window. </param>
		/// <param name="dwAffinity">The display affinity setting. </param>
		/// <returns>
		/// This function succeeds only when the window is layered and Desktop Windows Manager is composing the desktop. If this function succeeds, it returns TRUE; 
		/// otherwise, it returns FALSE. To get extended error information, call GetLastError. 
		/// </returns>
		/// <remarks>
		/// This function currently only supports one flag, WDA_MONITOR (0x01). This flag enables a window's contents to be displayed only on the monitor. 
		/// <br/>
		/// <para>
		/// This function and SetWindowDisplayAffinity are designed to support the window content protection feature unique to Windows 7. 
		/// This feature enables applications to protect their own onscreen window content from being captured or copied via a specific set of public 
		/// operating system features and APIs. However, it works only when the Desktop Window Manager (DWM) is composing the desktop. 
		/// </para>
		/// <br/>
		/// <para>
		/// It is important to note that unlike a security feature or an implementation of Digital Rights Management (DRM), there is no guarantee that using 
		/// SetWindowDisplayAffinity and GetWindowDisplayAffinity, and other necessary functions such as DwmIsCompositionEnabled, will strictly protect windowed content, 
		/// as in the case where someone takes a photograph of the screen. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	GetWindowDisplayAffinity ( IntPtr  hwnd, out uint  dwAffinity ) ;
		# endregion
	    }
    }