/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DispatchMessage.cs

    DESCRIPTION
        DispatchMessage() Windows function.

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
using   Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Dispatches a message to a window procedure. It is typically used to dispatch a message retrieved by the GetMessage function.
 		/// </summary>
		/// <param name="lpMsg">A pointer to a structure that contains the message.</param>
		/// <returns>
		/// The return value specifies the value returned by the window procedure. Although its meaning depends on the message being dispatched, 
		/// the return value generally is ignored.
		/// </returns>
		/// <remarks>
		/// The MSG structure must contain valid message values. If the lpmsg parameter points to a WM_TIMER message and the lParam parameter of the WM_TIMER message 
		/// is not NULL, lParam points to a function that is called instead of the window procedure. 
		/// <para>
		/// Note that the application is responsible for retrieving and dispatching input messages to the dialog box. Most applications use the main message loop for this. 
		/// </para>
		/// <para>
		/// However, to permit the user to move to and to select controls by using the keyboard, the application must call IsDialogMessage. 
		/// </para>
		/// <para>
		/// For more information, see Dialog Box Keyboard Interface.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern IntPtr 	DispatchMessage ( ref MSG  lpMsg ) ;
		# endregion
	    }
    }