/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetWindowText.cs

    DESCRIPTION
        SetWindowText() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
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
		/// Changes the text of the specified window's title bar (if it has one). If the specified window is a control, the text of the control is changed. 
		/// However, SetWindowText cannot change the text of a control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control whose text is to be changed. </param>
		/// <param name="lpString">The new title or control text. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the target window is owned by the current process, SetWindowText causes a WM_SETTEXT message to be sent to the specified window or control. 
		/// If the control is a list box control created with the WS_CAPTION style, however, SetWindowText sets the text for the control, not for the list box entries. 
		/// <br/>
		/// <para>
		/// To set the text of a control in another process, send the WM_SETTEXT message directly instead of calling SetWindowText. 
		/// </para>
		/// <br/>
		/// <para>
		/// The SetWindowText function does not expand tab characters (ASCII code 0x09). Tab characters are displayed as vertical bar (|) characters. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetWindowText ( IntPtr  hWnd, String  lpString ) ;
		# endregion
	    }
    }