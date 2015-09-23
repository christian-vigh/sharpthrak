/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapFree.cs

    DESCRIPTION
        HeapFree() Windows function.

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
		/// Frees a memory block allocated from a heap by the HeapAlloc or HeapReAlloc function.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap whose memory block is to be freed. This handle is returned by either the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">
		/// The heap free options. Specifying the following value overrides the corresponding value specified in the flOptions parameter 
		/// when the heap was created by using the HeapCreate function : HEAP_NO_SERIALIZE.
		/// </param>
		/// <param name="lpMem">
		/// A pointer to the memory block to be freed. This pointer is returned by the HeapAlloc or HeapReAlloc function. 
		/// If this pointer is NULL, the behavior is undefined.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. An application can call GetLastError for extended error information.
		/// </para>
		/// </returns>
		/// <remarks>
		/// You should not refer in any way to memory that has been freed by HeapFree. After that memory is freed, any information that 
		/// may have been in it is gone forever. If you require information, do not free memory containing the information. 
		/// Function calls that return information about memory (such as HeapSize) may not be used with freed memory, 
		/// as they may return bogus data. Calling HeapFree twice with the same pointer can cause heap corruption, resulting in subsequent calls 
		/// to HeapAlloc returning the same pointer twice.
		/// <br/>
		/// <para>
		/// Serialization ensures mutual exclusion when two or more threads attempt to simultaneously allocate or free blocks from the same heap. 
		/// There is a small performance cost to serialization, but it must be used whenever multiple threads allocate and free memory from the same 
		/// heap. Setting the HEAP_NO_SERIALIZE value eliminates mutual exclusion on the heap. 
		/// Without serialization, two or more threads that use the same heap handle might attempt to allocate or free memory simultaneously, 
		/// likely causing corruption in the heap. The HEAP_NO_SERIALIZE value can, therefore, be safely used only in the following situations :
		/// </para>
		/// <para>• The process has only one thread.</para>
		/// <para>• The process has multiple threads, but only one thread calls the heap functions for a specific heap.</para>
		/// <para>•The process has multiple threads, and the application provides its own mechanism for mutual exclusion to a specific heap.</para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	HeapFree ( IntPtr  hHeap, HEAP_Constants  dwFlags, IntPtr  lpMem ) ;
		# endregion
	    }
    }