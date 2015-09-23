/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapValidate.cs

    DESCRIPTION
        HeapValidate() Windows function.

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
		/// Validates the specified heap. The function scans all the memory blocks in the heap and verifies that the heap control structures maintained 
		/// by the heap manager are in a consistent state. You can also use the HeapValidate function to validate a single memory block within a specified heap 
		/// without checking the validity of the entire heap.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap to be validated. This handle is returned by either the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">
		/// The heap access options. This parameter can be the following values : HEAP_NO_SERIALIZE. 
		/// </param>
		/// <param name="lpMem">
		/// A pointer to a memory block within the specified heap. This parameter may be NULL. 
		/// <br/>
		/// <para>
		/// If this parameter is NULL, the function attempts to validate the entire heap specified by hHeap.
		/// </para>
		/// <para>
		/// If this parameter is not NULL, the function attempts to validate the memory block pointed to by lpMem. It does not attempt to validate the rest of the heap.
		/// </para>
		/// </param>
		/// <returns>
		/// If the specified heap or memory block is valid, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the specified heap or memory block is invalid, the return value is zero. On a system set up for debugging, the HeapValidate function 
		/// then displays debugging messages that describe the part of the heap or memory block that is invalid, and stops at a hard-coded breakpoint 
		/// so that you can examine the system to determine the source of the invalidity. The HeapValidate function does not set the thread's last error value. 
		/// There is no extended error information for this function; do not call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The HeapValidate function is primarily useful for debugging because validation is potentially time-consuming. Validating a heap can block other threads 
		/// from accessing the heap and can degrade performance, especially on symmetric multiprocessing (SMP) computers. 
		/// These side effects can last until HeapValidate returns. 
		/// <br/>
		/// <para>
		/// There are heap control structures for each memory block in a heap, and for the heap as a whole. 
		/// When you use the HeapValidate function to validate a complete heap, it checks all of these control structures for consistency.
		/// </para>
		/// <br/>
		/// <para>
		/// When you use HeapValidate to validate a single memory block within a heap, it checks only the control structures pertaining to that element. 
		/// HeapValidate can only validate allocated memory blocks. Calling HeapValidate on a freed memory block will return FALSE because there are 
		/// no control structures to validate.
		/// </para>
		/// <br/>
		/// <para>
		/// If you want to validate the heap elements enumerated by the HeapWalk function, you should only call HeapValidate on the elements that have 
		/// PROCESS_HEAP_ENTRY_BUSY in the wFlags member of the PROCESS_HEAP_ENTRY structure. HeapValidate returns FALSE for all heap elements that do not have this bit set.
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
		[DllImport ( KERNEL32, SetLastError = false, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	HeapValidate ( IntPtr  hHeap, HEAP_Constants  dwFlags, IntPtr  lpMem ) ;
		# endregion
	    }
    }