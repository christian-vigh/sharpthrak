/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapSize.cs

    DESCRIPTION
        HeapSize() Windows function.

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
		/// Retrieves the size of a memory block allocated from a heap by the HeapAlloc or HeapReAlloc function.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap in which the memory block resides. This handle is returned by either the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">
		/// The heap size options. Specifying the following value overrides the corresponding value specified in the flOptions parameter when the heap 
		/// was created by using the HeapCreate function : HEAP_NO_SERIALIZE.
		/// </param>
		/// <param name="lpMem">
		/// A pointer to the memory block whose size the function will obtain. This is a pointer returned by the HeapAlloc or HeapReAlloc function. 
		/// The memory block must be from the heap specified by the hHeap parameter.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the requested size of the allocated memory block, in bytes.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is (SIZE_T)-1. 
		/// The function does not call SetLastError. An application cannot call GetLastError for extended error information.
		/// </para>
		/// <br/>
		/// <para>
		/// If the lpMem parameter refers to a heap allocation that is not in the heap specified by the hHeap parameter, the behavior of the HeapSize function is undefined.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Serialization ensures mutual exclusion when two or more threads attempt to simultaneously allocate or free blocks from the same heap. 
		/// There is a small performance cost to serialization, but it must be used whenever multiple threads allocate and free memory from the same heap. 
		/// Setting the HEAP_NO_SERIALIZE value eliminates mutual exclusion on the heap. Without serialization, two or more threads that use the same heap handle 
		/// might attempt to allocate or free memory simultaneously, likely causing corruption in the heap. The HEAP_NO_SERIALIZE value can, therefore, 
		/// be safely used only in the following situations :
		/// <para>• The process has only one thread.</para>
		/// <para>• The process has multiple threads, but only one thread calls the heap functions for a specific heap.</para>
		/// <para>• The process has multiple threads, and the application provides its own mechanism for mutual exclusion to a specific heap.</para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	HeapSize ( IntPtr  hHeap, HEAP_Constants  dwFlags, IntPtr  lpMem ) ;
		# endregion
	    }
    }