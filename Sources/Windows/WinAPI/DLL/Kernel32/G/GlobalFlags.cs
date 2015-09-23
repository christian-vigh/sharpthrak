/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalFlags.cs

    DESCRIPTION
        GlobalFlags() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/31]     [Author : CV]
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
	public static partial class Kernel32
	   {
		# region Generic version.
		/// <summary>
		/// Retrieves information about the specified global memory object.
		/// <br/>
		/// <para>
		/// Note  This function is provided only for compatibility with 16-bit versions of Windows. 
		/// New applications should use the heap functions.
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value specifies the allocation values and the lock count for the memory object.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is GMEM_INVALID_HANDLE, indicating that the global handle is not valid. 
		/// To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The low-order byte of the low-order word of the return value contains the lock count of the object. 
		/// To retrieve the lock count from the return value, use the GMEM_LOCKCOUNT mask with the bitwise AND (&) operator. 
		/// The lock count of memory objects allocated with GMEM_FIXED is always zero.
		/// <br/>
		/// <para>
		/// The high-order byte of the low-order word of the return value indicates the allocation values of the memory object. It can be zero or GMEM_DISCARDED.
		/// </para>
		/// <br/>
		/// <para>
		/// The global functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a global function should be used.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern GMEM_Constants 	GlobalFlags ( IntPtr  hMem ) ;
		# endregion
	    }
    }