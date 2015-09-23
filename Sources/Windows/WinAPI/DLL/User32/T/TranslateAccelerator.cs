/**************************************************************************************************************

    NAME
        WinAPI/User32/T/TranslateAccelerator.cs

    DESCRIPTION
        TranslateAccelerator() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
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
		/// Processes accelerator keys for menu commands. The function translates a WM_KEYDOWN or WM_SYSKEYDOWN message to a WM_COMMAND or WM_SYSCOMMAND message 
		/// (if there is an entry for the key in the specified accelerator table) and then sends the WM_COMMAND or WM_SYSCOMMAND message directly to the specified 
		/// window procedure. TranslateAccelerator does not return until the window procedure has processed the message. 
		/// </summary>
		/// <param name="hWnd">A handle to the window whose messages are to be translated. </param>
		/// <param name="hAccTable">
		/// A handle to the accelerator table.
		/// <para>
		/// The accelerator table must have been loaded by a call to the LoadAccelerators function or created by a call to the CreateAcceleratorTable function. 
		/// </para>
		/// </param>
		/// <param name="lpMsg">
		/// A pointer to an MSG structure that contains message information retrieved from the calling thread's message queue using the GetMessage or PeekMessage function. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// To differentiate the message that this function sends from messages sent by menus or controls, the high-order word of the wParam parameter of 
		/// the WM_COMMAND or WM_SYSCOMMAND message contains the value 1. 
		/// <para>
		/// Accelerator key combinations used to select items from the window menu are translated into WM_SYSCOMMAND messages; all other accelerator key combinations 
		/// are translated into WM_COMMAND messages. 
		/// </para>
		/// <para>
		/// When TranslateAccelerator returns a nonzero value and the message is translated, the application should not use the TranslateMessage function to process 
		/// the message again. 
		/// </para>
		/// <para>
		/// An accelerator need not correspond to a menu command. 
		/// </para>
		/// <para>
		/// If the accelerator command corresponds to a menu item, the application is sent WM_INITMENU and WM_INITMENUPOPUP messages, as if the user were trying to 
		/// display the menu. However, these messages are not sent if any of the following conditions exist : 
		/// </para>
		/// <para>• The window is disabled.</para>
		/// <para>• The accelerator key combination does not correspond to an item on the window menu and the window is minimized.</para>
		/// <para>• A mouse capture is in effect. For information about mouse capture, see the SetCapture function.</para>
		/// <br/>
		/// <para>
		/// If the specified window is the active window and no window has the keyboard focus (which is generally the case if the window is minimized), 
		/// TranslateAccelerator translates WM_SYSKEYUP and WM_SYSKEYDOWN messages instead of WM_KEYUP and WM_KEYDOWN messages. 
		/// </para>
		/// <para>
		/// If an accelerator keystroke occurs that corresponds to a menu item when the window that owns the menu is minimized, TranslateAccelerator does not send 
		/// a WM_COMMAND message. However, if an accelerator keystroke occurs that does not match any of the items in the window's menu or in the window menu, 
		/// the function sends a WM_COMMAND message, even if the window is minimized. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	TranslateAccelerator ( IntPtr  hWnd, IntPtr  hAccTable, [In] ref MSG  lpMsg) ;
		# endregion
	    }
    }