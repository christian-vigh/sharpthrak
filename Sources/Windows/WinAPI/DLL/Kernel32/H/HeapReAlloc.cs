/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapReAlloc.cs

    DESCRIPTION
        HeapReAlloc() Windows function.

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
		/// Reallocates a block of memory from a heap. This function enables you to resize a memory block and change other memory block properties. 
		/// The allocated memory is not movable. 
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap from which the memory is to be reallocated. This handle is a returned by either the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">
		/// The heap reallocation options. Specifying a value overrides the corresponding value specified in the flOptions parameter when the heap was created 
		/// by using the HeapCreate function. This parameter can be one or more of the HEAP_Constants values.
		/// </param>
		/// <param name="lpMem">
		/// A pointer to the block of memory that the function reallocates. This pointer is returned by an earlier call to the HeapAlloc or HeapReAlloc function.
		/// </param>
		/// <param name="dwBytes">
		/// The new size of the memory block, in bytes. A memory block's size can be increased or decreased by using this function.
		/// <br/>
		/// <para>
		/// If the heap specified by the hHeap parameter is a "non-growable" heap, dwBytes must be less than 0x7FFF8. 
		/// You create a non-growable heap by calling the HeapCreate function with a nonzero value.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the allocated memory block.
		/// <br/>
		/// <para>
		/// If the function fails and you have not specified HEAP_GENERATE_EXCEPTIONS, the return value is NULL.
		/// </para>
		/// <br/>
		/// <para>
		/// If the function fails and you have specified HEAP_GENERATE_EXCEPTIONS, the function may generate either a STATUS_NO_MEMORY or STATUS_ACCESS_VIOLATION
		/// exception.
		/// The particular exception depends upon the nature of the heap corruption. For more information, see GetExceptionCode.
		/// </para>
		/// <br/>
		/// <para>
		/// If the function fails, it does not call SetLastError. An application cannot call GetLastError for extended error information.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If HeapReAlloc succeeds, it allocates at least the amount of memory requested. 
		/// <br/>
		/// <para>
		/// If HeapReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// </para>
		/// <br/>
		/// <para>
		/// HeapReAlloc is guaranteed to preserve the content of the memory being reallocated, even if the new memory is allocated at a different location. 
		/// The process of preserving the memory content involves a memory copy operation that is potentially very time-consuming. 
		/// </para>
		/// <br/>
		/// <para>
		/// To free a block of memory allocated by HeapReAlloc, use the HeapFree function.
		/// </para>
		/// <br/>
		/// <para>
		/// Serialization ensures mutual exclusion when two or more threads attempt to simultaneously allocate or free blocks from the same heap. 
		/// There is a small performance cost to serialization, but it must be used whenever multiple threads allocate and free memory from the same heap. 
		/// Setting the HEAP_NO_SERIALIZE value eliminates mutual exclusion on the heap. Without serialization, two or more threads that use the same heap handle 
		/// might attempt to allocate or free memory simultaneously, likely causing corruption in the heap. The HEAP_NO_SERIALIZE value can, therefore, 
		/// be safely used only in the following situations :
		/// </para>
		/// <para>• The process has only one thread.</para>
		/// <para>• The process has multiple threads, but only one thread calls the heap functions for a specific heap.</para>
		/// <para>• The process has multiple threads, and the application provides its own mechanism for mutual exclusion to a specific heap.</para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	HeapReAlloc ( IntPtr  hHeap, HEAP_Constants  dwFlags, IntPtr  lpMem, uint  dwBytes ) ;
		# endregion
	    }
    }