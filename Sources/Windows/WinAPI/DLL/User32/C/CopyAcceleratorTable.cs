/**************************************************************************************************************

    NAME
        WinAPI/User32/C/CopyAcceleratorTable.cs

    DESCRIPTION
        CopyAcceleratorTable() Windows function.

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
		/// Copies the specified accelerator table. This function is used to obtain the accelerator-table data that corresponds to an accelerator-table handle, 
		/// or to determine the size of the accelerator-table data. 
		/// </summary>
		/// <param name="hAccelSrc">A handle to the accelerator table to copy. </param>
		/// <param name="lpAccelDst">An array of ACCEL structures that receives the accelerator-table information. </param>
		/// <param name="cAccelEntries">The number of ACCEL structures to copy to the buffer pointed to by the lpAccelDst parameter.</param>
		/// <returns>
		/// If lpAccelDst is NULL, the return value specifies the number of accelerator-table entries in the original table. Otherwise, it specifies the number 
		/// of accelerator-table entries that were copied.
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	CopyAcceleratorTable ( IntPtr  hAccelSrc, [Out] ACCEL []  lpAccelDst, int  cAccelEntries ) ;
		# endregion


		# region Version that retrieves the accelerator table entry count.
		/// <summary>
		/// Copies the specified accelerator table. This function is used to obtain the accelerator-table data that corresponds to an accelerator-table handle, 
		/// or to determine the size of the accelerator-table data. 
		/// </summary>
		/// <param name="hAccelSrc">A handle to the accelerator table to copy. </param>
		/// <param name="lpAccelDst">An array of ACCEL structures that receives the accelerator-table information. </param>
		/// <param name="cAccelEntries">The number of ACCEL structures to copy to the buffer pointed to by the lpAccelDst parameter.</param>
		/// <returns>
		/// If lpAccelDst is NULL, the return value specifies the number of accelerator-table entries in the original table. Otherwise, it specifies the number 
		/// of accelerator-table entries that were copied.
		/// </returns>
		public static int 	CopyAcceleratorTable ( IntPtr  hAccelSrc )
		   {
			return ( CopyAcceleratorTable ( hAccelSrc, null, 0 ) ) ;
		    }
		# endregion
	    }
    }