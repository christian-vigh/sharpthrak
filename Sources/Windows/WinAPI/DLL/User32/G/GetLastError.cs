/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetLastError.cs

    DESCRIPTION
        GetLastError() Windows function.

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
		/// <summary>
		/// Retrieves the calling thread's last-error code value. 
		/// <para>
		/// The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
		/// </para>
		/// </summary>
		/// <returns>
		/// The return value is the calling thread's last-error code.
		/// <para>
		/// The Return Value section of the documentation for each function that sets the last-error code notes the conditions under which the function 
		/// sets the last-error code. 
		/// </para>
		/// <para>
		/// Most functions that set the thread's last-error code set it when they fail. However, some functions also set the last-error code when they succeed. 
		/// </para>
		/// <para>
		/// If the function is not documented to set the last-error code, the value returned by this function is simply the most recent last-error code to have been set; 
		/// some functions set the last-error code to 0 on success and others do not.
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		public static extern ERROR_Constants	GetLastError ( ) ;
	    }
    }