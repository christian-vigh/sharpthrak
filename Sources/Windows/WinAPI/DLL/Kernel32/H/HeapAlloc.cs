/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapAlloc.cs

    DESCRIPTION
        HeapAlloc() Windows function.

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
		/// Allocates a block of memory from a heap. The allocated memory is not movable.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap from which the memory will be allocated. This handle is returned by the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">
		/// The heap allocation options. Specifying any of these values will override the corresponding value specified when the heap was created with HeapCreate. 
		/// This parameter can be one or more of the HEAP_Constants values.
		/// </param>
		/// <param name="dwBytes">
		/// The number of bytes to be allocated.
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
		/// If the HeapAlloc function succeeds, it allocates at least the amount of memory requested. 
		/// <br/>
		/// <para>
		/// To allocate memory from the process's default heap, use HeapAlloc with the handle returned by the GetProcessHeap function.
		/// </para>
		/// <br/>
		/// <para>
		/// To free a block of memory allocated by HeapAlloc, use the HeapFree function.
		/// </para>
		/// <br/>
		/// <para>
		/// Memory allocated by HeapAlloc is not movable. The address returned by HeapAlloc is valid until the memory block is freed or reallocated; 
		/// the memory block does not need to be locked. Because the system cannot compact a private heap, it can become fragmented.
		/// </para>
		/// <br/>
		/// <para>
		/// Applications that allocate large amounts of memory in various allocation sizes can use the low-fragmentation heap to reduce heap fragmentation.
		/// </para>
		/// <br/>
		/// <para>
		/// Serialization ensures mutual exclusion when two or more threads attempt to simultaneously allocate or free blocks from the same heap. 
		/// There is a small performance cost to serialization, but it must be used whenever multiple threads allocate and free memory from the same heap. 
		/// Setting the HEAP_NO_SERIALIZE value eliminates mutual exclusion on the heap. Without serialization, two or more threads that use the same heap handle 
		/// might attempt to allocate or free memory simultaneously, likely causing corruption in the heap. 
		/// The HEAP_NO_SERIALIZE value can, therefore, be safely used only in the following situations :
		/// </para>
		/// <para>• The process has only one thread.</para>
		/// <para>• The process has multiple threads, but only one thread calls the heap functions for a specific heap.</para>
		/// <para>• The process has multiple threads, and the application provides its own mechanism for mutual exclusion to a specific heap.</para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = false, CharSet = CharSet. Auto )]
		public static extern IntPtr 	HeapAlloc ( IntPtr  hHeap, HEAP_Constants  dwFlags, uint  dwBytes ) ;
		# endregion
	    }
    }