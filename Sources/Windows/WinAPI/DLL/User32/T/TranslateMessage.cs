/**************************************************************************************************************

    NAME
        WinAPI/User32/T/TranslateMessage.cs

    DESCRIPTION
        TranslateMessage() Windows function.

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
		/// Translates virtual-key messages into character messages. 
		/// <para>
		/// The character messages are posted to the calling thread's message queue, to be read the next time the thread calls the GetMessage or PeekMessage function.
		/// </para>
 		/// </summary>
		/// <param name="lpMsg">
		/// A pointer to an MSG structure that contains message information retrieved from the calling thread's message queue by using the GetMessage or PeekMessage function.
		/// </param>
		/// <returns>
		/// If the message is translated (that is, a character message is posted to the thread's message queue), the return value is nonzero.
		/// <para>
		/// If the message is WM_KEYDOWN, WM_KEYUP, WM_SYSKEYDOWN, or WM_SYSKEYUP, the return value is nonzero, regardless of the translation. 
		/// </para>
		/// <para>
		/// If the message is not translated (that is, a character message is not posted to the thread's message queue), the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The TranslateMessage function does not modify the message pointed to by the lpMsg parameter. 
		/// <para>
		/// WM_KEYDOWN and WM_KEYUP combinations produce a WM_CHAR or WM_DEADCHAR message. WM_SYSKEYDOWN and WM_SYSKEYUP combinations produce a WM_SYSCHAR or 
		/// WM_SYSDEADCHAR message. 
		/// </para>
		/// <para>
		/// TranslateMessage produces WM_CHAR messages only for keys that are mapped to ASCII characters by the keyboard driver. 
		/// </para>
		/// <para>
		/// If applications process virtual-key messages for some other purpose, they should not call TranslateMessage. For instance, an application should not call 
		/// TranslateMessage if the TranslateAccelerator function returns a nonzero value. Note that the application is responsible for retrieving and dispatching 
		/// input messages to the dialog box. Most applications use the main message loop for this. However, to permit the user to move to and to select controls by using 
		/// the keyboard, the application must call IsDialogMessage. For more information, see Dialog Box Keyboard Interface.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	TranslateMessage ( ref MSG  lpMsg  ) ;
		# endregion
	    }
    }