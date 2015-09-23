/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LoadAccelerators.cs

    DESCRIPTION
        LoadAccelerators() Windows function.

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
		/// Loads the specified accelerator table. 
		/// </summary>
		/// <param name="hInstance">A handle to the module whose executable file contains the accelerator table to be loaded. </param>
		/// <param name="lpTableName">
		/// The name of the accelerator table to be loaded. 
		/// <para>
		/// Alternatively, this parameter can specify the resource identifier of an accelerator-table resource in the low-order word and zero in the high-order word. 
		/// </para>
		/// <para>
		/// To create this value, use the MAKEINTRESOURCE macro. 
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the loaded accelerator table.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the accelerator table has not yet been loaded, the function loads it from the specified executable file. 
		/// <para>
		/// Accelerator tables loaded from resources are freed automatically when the application terminates. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	LoadAccelerators ( IntPtr  hInstance, String  lpTableName ) ;
		# endregion
	    }
    }