/**************************************************************************************************************

    NAME
        WinAPI/User32/C/CreateAcceleratorTable.cs

    DESCRIPTION
        CreateAcceleratorTable() Windows function.

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
		/// Creates an accelerator table.
		/// </summary>
		/// <param name="lpaccl">An array of ACCEL structures that describes the accelerator table. </param>
		/// <param name="cEntries">The number of ACCEL structures in the array. This must be within the range 1 to 32767 or the function will fail.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to the created accelerator table; otherwise, it is NULL. 
		/// To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// Before an application closes, it can use the DestroyAcceleratorTable function to destroy any accelerator tables that it created by using 
		/// the CreateAcceleratorTable function.
 		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	CreateAcceleratorTable ( ACCEL  lpaccl, int  cEntries ) ;
		# endregion
	    }
    }