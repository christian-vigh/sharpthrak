/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKBCodePage.cs

    DESCRIPTION
        GetKBCodePage() Windows function.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
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
		/// Retrieves the current code page.
		/// <br/>
		/// <para>
		/// Note  This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the GetOEMCP function 
		/// to retrieve the OEM code-page identifier for the system.
		/// </para>
		/// </summary>
		/// <returns>
		/// The return value is an OEM code-page identifier, or it is the default identifier if the registry value is not readable.
		/// </returns>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	GetKBCodePage ( ) ;
		# endregion
	    }
    }