/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetSystemMetrics.cs

    DESCRIPTION
        GetSystemMetrics() function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Retrieves the specified system metric or system configuration setting.
		/// <para>
		/// Note that all dimensions retrieved by GetSystemMetrics are in pixels.
		/// </para>
		/// </summary>
		/// <param name="smIndex">
		/// The system metric or configuration setting to be retrieved.
		/// <para>
		/// Note that all SM_CX* values are widths and all SM_CY* values are heights. 
		/// </para>
		/// <para>
		/// Also note that all settings designed to return Boolean data represent TRUE as any nonzero value, and FALSE as a zero value.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the requested system metric or configuration setting.	
		/// <para>
		/// If the function fails, the return value is 0. GetLastError does not provide extended error information.
		/// </para>
		/// </returns>
		[DllImport ( USER32 )]
		static extern int GetSystemMetrics(SM_Constants  smIndex ) ;
		# endregion
	    }
    }
