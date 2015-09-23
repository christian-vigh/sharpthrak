/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalAlloc.cs

    DESCRIPTION
        GlobalAlloc() Windows function.

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
		/// Note  The global functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a global function should be used. 
		/// </para>
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. If zero is specified, the default is GMEM_FIXED. 
		/// This parameter can be one or more of the GMEM_Constants values, except for the incompatible combinations that are specifically noted. 
		/// </param>
		/// <param name="dwBytes">
		/// The number of bytes to allocate. If this parameter is zero and the uFlags parameter specifies GMEM_MOVEABLE, 
		/// the function returns a handle to a memory object that is marked as discarded.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Windows memory management does not provide a separate local heap and global heap. Therefore, the GlobalAlloc and LocalAlloc functions are essentially the same. 
		/// <br/>
		/// <para>
		/// The movable-memory flags GHND and GMEM_MOVABLE add unnecessary overhead and require locking to be used safely. 
		/// They should be avoided unless documentation specifically states that they should be used.
		/// </para>
		/// <br/>
		/// <para>
		/// New applications should use the heap functions to allocate and manage memory unless the documentation specifically states that a global function should be used. 
		/// For example, the global functions are still used with Dynamic Data Exchange (DDE), the clipboard functions, and OLE data objects. 
		/// </para>
		/// <br/>
		/// <para>
		/// If the GlobalAlloc function succeeds, it allocates at least the amount of memory requested. If the actual amount allocated is greater than 
		/// the amount requested, the process can use the entire amount. To determine the actual number of bytes allocated, use the GlobalSize function.
		/// </para>
		/// <br/>
		/// <para>
		/// If the heap does not contain sufficient free space to satisfy the request, GlobalAlloc returns NULL. 
		/// Because NULL is used to indicate an error, virtual address zero is never allocated. It is, therefore, easy to detect the use of a NULL pointer.
		/// </para>
		/// <br/>
		/// <para>
		/// Memory allocated with this function is guaranteed to be aligned on an 8-byte boundary. To execute dynamically generated code, 
		/// use the VirtualAlloc function to allocate memory and the VirtualProtect function to grant PAGE_EXECUTE access.
		/// </para>
		/// <br/>
		/// <para>
		/// To free the memory, use the GlobalFree function. It is not safe to free memory allocated with GlobalAlloc using LocalFree.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GlobalAlloc ( GMEM_Constants  uFlags, uint  dwBytes ) ;
		# endregion
	    }
    }