/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapLock.cs

    DESCRIPTION
        HeapLock() Windows function.

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
		/// Attempts to acquire the critical section object, or lock, that is associated with a specified heap.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap to be locked. This handle is returned by either the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the function succeeds, the calling thread owns the heap lock. Only the calling thread will be able to allocate or release memory 
		/// from the heap. The execution of any other thread of the calling process will be blocked if that thread attempts to allocate or 
		/// release memory from the heap. Such threads will remain blocked until the thread that owns the heap lock calls the HeapUnlock function.
		/// <br/>
		/// <para>
		/// The HeapLock function is primarily useful for preventing the allocation and release of heap memory by other threads while 
		/// the calling thread uses the HeapWalk function.
		/// </para>
		/// <br/>
		/// <para>
		/// If the HeapLock function is called on a heap created with the HEAP_NO_SERIALIZATION flag, the results are undefined.
		/// </para>
		/// <br/>
		/// <para>
		/// Each successful call to HeapLock must be matched by a corresponding call to HeapUnlock. Failure to call HeapUnlock will block 
		/// the execution of any other threads of the calling process that attempt to access the heap.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	HeapLock ( IntPtr  hHeap ) ;
		# endregion
	    }
    }