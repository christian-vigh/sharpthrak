/**************************************************************************************************************

    NAME
        WinAPI/User32/M/MessageBoxEx.cs

    DESCRIPTION
        MessageBoxEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
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
		///Creates, displays, and operates a message box. The message box contains an application-defined message and title, 
		///plus any combination of predefined icons and push buttons. The buttons are in the language of the system user interface. 
		///<br/>
		///<para>
		/// Currently MessageBoxEx and MessageBox work the same way.
		/// </para>
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the owner window of the message box to be created. If this parameter is NULL, the message box has no owner window.
		/// </param>
		/// <param name="lpText">
		/// The message to be displayed. If the string consists of more than one line, you can separate the lines using a carriage return 
		/// and/or linefeed character between each line.
		/// </param>
		/// <param name="lpCaption">The dialog box title. If this parameter is NULL, the default title is Error.</param>
		/// <param name="uType">
		/// The contents and behavior of the dialog box. This parameter can be a combination of flags from the MB_Constants flags.
		/// </param>
		/// <param name="wLanguageId">
		/// The language for the text displayed in the message box button(s). Specifying a value of zero (0) indicates to display the button text 
		/// in the default system language. If this parameter is MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), the current language associated 
		/// with the calling thread is used. 
		/// <br/>
		/// <para>
		/// To specify a language other than the current language, use the MAKELANGID macro to create this parameter. 
		/// For more information, see MAKELANGID.
		/// </para>
		/// </param>
		/// <returns>
		/// If a message box has a Cancel button, the function returns the IDCANCEL value if either the ESC key is pressed or the Cancel button 
		/// is selected. If the message box has no Cancel button, pressing ESC has no effect.
		/// <br/>
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// <para>If the function succeeds, the return value is one of the ID_Constants values.</para>
		/// </returns>
		/// <remarks>
		/// Adding two right-to-left marks (RLMs), represented by Unicode formatting character U+200F, in the beginning of a MessageBox display string 
		/// is interpreted by the MessageBox rendering engine so as to cause the reading order of the MessageBox to be rendered as right-to-left (RTL).
		/// <br/>
		/// <para>
		/// When you use a system-modal message box to indicate that the system is low on memory, the strings pointed to by the lpText and lpCaption 
		/// parameters should not be taken from a resource file because an attempt to load the resource may fail.
		/// </para>
		/// <br/>
		/// <para>
		/// If you create a message box while a dialog box is present, use a handle to the dialog box as the hWnd parameter. 
		/// The hWnd parameter should not identify a child window, such as a control in a dialog box.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern ID_Constants 	MessageBoxEx ( IntPtr  hWnd, String  lpText, String  lpCaption, MB_Constants  uType, 
									ushort  wLanguageId ) ;
		# endregion
	    }
    }