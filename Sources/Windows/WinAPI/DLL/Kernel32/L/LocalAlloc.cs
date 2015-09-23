/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LocalAlloc.cs

    DESCRIPTION
        LocalAlloc() Windows function.

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
		/// Allocates the specified number of bytes from the heap.
		/// <br/>
		/// <para>
		/// Note  The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used.
		/// </para>
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the LMEM_FIXED value. 
		/// This parameter can be one or more of the LMEM_Constants values, except for the incompatible combinations that are specifically noted. 
		/// </param>
		/// <param name="uBytes">
		/// The number of bytes to allocate. If this parameter is zero and the uFlags parameter specifies LMEM_MOVEABLE, the function returns a handle 
		/// to a memory object that is marked as discarded.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Windows memory management does not provide a separate local heap and global heap. Therefore, the LocalAlloc and GlobalAlloc functions are essentially the same. 
		/// <br/>
		/// <para>
		/// The movable-memory flags LHND, LMEM_MOVABLE, and NONZEROLHND add unnecessary overhead and require locking to be used safely. 
		/// They should be avoided unless documentation specifically states that they should be used.
		/// </para>
		/// <br/>
		/// <para>
		/// New applications should use the heap functions unless the documentation specifically states that a local function should be used. 
		/// For example, some Windows functions allocate memory that must be freed with LocalFree.
		/// </para>
		/// <br/>
		/// <para>
		/// If the LocalAlloc function succeeds, it allocates at least the amount requested. If the amount allocated is greater than the amount requested, 
		/// the process can use the entire amount. To determine the actual number of bytes allocated, use the LocalSize function.
		/// </para>
		/// <br/>
		/// <para>
		/// To free the memory, use the LocalFree function. It is not safe to free memory allocated with LocalAlloc using GlobalFree.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	LocalAlloc ( LMEM_Constants  uFlags, uint  uBytes ) ;
		# endregion
	    }
    }