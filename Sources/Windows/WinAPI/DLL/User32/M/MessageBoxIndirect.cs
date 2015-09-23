/**************************************************************************************************************

    NAME
        WinAPI/User32/M/MessageBoxIndirect.cs

    DESCRIPTION
        MessageBoxIndirect() Windows function.

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
		/// Creates, displays, and operates a message box. The message box contains application-defined message text and title, any icon, 
		/// and any combination of predefined push buttons.
		/// </summary>
		/// <param name="lpMsgBoxParams">A pointer to a MSGBOXPARAMS structure that contains information used to display the message box. </param>
		/// <returns>
		/// If the function succeeds, the return value is one of the ID_Constants values.
		/// <br/>
		/// <para>
		/// If a message box has a Cancel button, the function returns the IDCANCEL value if either the ESC key is pressed or the Cancel button 
		/// is selected. If the message box has no Cancel button, pressing ESC has no effect. 
		/// </para>
		/// <br/>
		/// <para>If there is not enough memory to create the message box, the return value is zero. </para>
		/// </returns>
		/// <remarks>
		/// When you use a system-modal message box to indicate that the system is low on memory, the strings pointed to by the lpszText and 
		/// lpszCaption members of the MSGBOXPARAMS structure should not be taken from a resource file, 
		/// because an attempt to load the resource may fail. 
		/// <br/>
		/// <para>
		/// If you create a message box while a dialog box is present, use a handle to the dialog box as the hWnd parameter. 
		/// The hWnd parameter should not identify a child window, such as a control in a dialog box. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	MessageBoxIndirect ( ref  MSGBOXPARAMS  lpMsgBoxParams ) ;
		# endregion
	    }
    }