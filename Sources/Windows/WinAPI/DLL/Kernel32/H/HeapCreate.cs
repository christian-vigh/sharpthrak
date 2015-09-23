/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapCreate.cs

    DESCRIPTION
        HeapCreate() Windows function.

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
		/// Creates a private heap object that can be used by the calling process. 
		/// The function reserves space in the virtual address space of the process and allocates physical storage for a specified initial portion of this block.
		/// </summary>
		/// <param name="flOptions">
		/// The heap allocation options. These options affect subsequent access to the new heap through calls to the heap functions. 
		/// This parameter can be 0 or one or more of the following HEAP_Constants values : HEAP_CREATE_ENABLE_EXECUTE, HEAP_GENERATE_EXCEPTIONS, HEAP_NO_SERIALIZE.
		/// </param>
		/// <param name="dwInitialSize">
		/// The initial size of the heap, in bytes. This value determines the initial amount of memory that is committed for the heap. 
		/// The value is rounded up to a multiple of the system page size. The value must be smaller than dwMaximumSize.
		/// <br/>
		/// <para>
		/// If this parameter is 0, the function commits one page. To determine the size of a page on the host computer, use the GetSystemInfo function.
		/// </para>
		/// </param>
		/// <param name="dwMaximumSize">
		/// The maximum size of the heap, in bytes. The HeapCreate function rounds dwMaximumSize up to a multiple of the system page size and then reserves 
		/// a block of that size in the process's virtual address space for the heap. If allocation requests made by the HeapAlloc or HeapReAlloc functions 
		/// exceed the size specified by dwInitialSize, the system commits additional pages of memory for the heap, up to the heap's maximum size. 
		/// <br/>
		/// <para>
		/// If dwMaximumSize is not zero, the heap size is fixed and cannot grow beyond the maximum size. 
		/// Also, the largest memory block that can be allocated from the heap is slightly less than 512 KB for a 32-bit process and slightly less 
		/// than 1,024 KB for a 64-bit process. Requests to allocate larger blocks fail, even if the maximum size of the heap is large enough to contain the block. 
		/// </para>
		/// <br/>
		/// <para>
		/// If dwMaximumSize is 0, the heap can grow in size. The heap's size is limited only by the available memory. Requests to allocate memory blocks larger than 
		/// the limit for a fixed-size heap do not automatically fail; instead, the system calls the VirtualAlloc function to obtain the memory that is needed 
		/// for large blocks. Applications that need to allocate large memory blocks should set dwMaximumSize to 0.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly created heap.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The HeapCreate function creates a private heap object from which the calling process can allocate memory blocks by using the HeapAlloc function. 
		/// The initial size determines the number of committed pages that are allocated initially for the heap. 
		/// The maximum size determines the total number of reserved pages. 
		/// These pages create a block in the process's virtual address space into which the heap can grow. 
		/// If requests by HeapAlloc exceed the current size of committed pages, additional pages are automatically committed from this reserved space, 
		/// if the physical storage is available.
		/// <br/>
		/// <para>
		/// Windows Server 2003 and Windows XP :  By default, the newly created private heap is a standard heap. 
		/// To enable the low-fragmentation heap, call the HeapSetInformation function with a handle to the private heap.
		/// </para>
		/// <br/>
		/// <para>
		/// The memory of a private heap object is accessible only to the process that created it. If a dynamic-link library (User32) creates a private heap, 
		/// the heap is created in the address space of the process that calls the User32, and it is accessible only to that process.
		/// </para>
		/// <br/>
		/// <para>
		/// The system uses memory from the private heap to store heap support structures, so not all of the specified heap size is available to the process. For example, if the HeapAlloc function requests 64 kilobytes (K) from a heap with a maximum size of 64K, the request may fail because of system overhead.
		/// </para>
		/// <br/>
		/// <para>
		/// If HEAP_NO_SERIALIZE is not specified (the simple default), the heap serializes access within the calling process. 
		/// Serialization ensures mutual exclusion when two or more threads attempt simultaneously to allocate or free blocks from the same heap. 
		/// There is a small performance cost to serialization, but it must be used whenever multiple threads allocate and free memory from the same heap. 
		/// The HeapLock and HeapUnlock functions can be used to block and permit access to a serialized heap.
		/// </para>
		/// <br/>
		/// <para>
		/// Setting HEAP_NO_SERIALIZE eliminates mutual exclusion on the heap. 
		/// Without serialization, two or more threads that use the same heap handle might attempt to allocate or free memory simultaneously, 
		/// which may cause corruption in the heap. Therefore, HEAP_NO_SERIALIZE can safely be used only in the following situations :
		/// </para>
		/// <para>• The process has only one thread.</para>
		/// <para>• The process has multiple threads, but only one thread calls the heap functions for a specific heap.</para>
		/// <para>• The process has multiple threads, and the application provides its own mechanism for mutual exclusion to a specific heap.</para>
		/// <br/>
		/// <para>
		/// If the HeapLock and HeapUnlock functions are called on a heap created with the HEAP_NO_SERIALIZE flag, the results are undefined.
		/// </para>
		/// <br/>
		/// <para>
		/// To obtain a handle to the default heap for a process, use the GetProcessHeap function. To obtain handles to the default heap and private heaps that are active 
		/// for the calling process, use the GetProcessHeaps function.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	HeapCreate ( HEAP_Constants  flOptions, uint  dwInitialSize, uint  dwMaximumSize ) ;
		# endregion
	    }
    }