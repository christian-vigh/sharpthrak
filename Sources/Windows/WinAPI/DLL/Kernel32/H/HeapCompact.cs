/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapCompact.cs

    DESCRIPTION
        HeapCompact() Windows function.

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
		/// Returns the size of the largest committed free block in the specified heap. If the Disable heap coalesce on free global flag is set, 
		/// this function also coalesces adjacent free blocks of memory in the heap.
 		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap. This handle is returned by either the HeapCreate or GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">
		/// The heap access options. This parameter can be HEAP_NO_SERIALIZE to specify that serialized access will not be used.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the size of the largest committed free block in the heap, in bytes.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// <para>
		/// In the unlikely case that there is absolutely no space available in the heap, the function return value is zero, and GetLastError returns the value NO_ERROR.
 		/// </para>
		/// </returns>
		/// <remarks>
		/// The HeapCompact function is primarily useful for debugging. Ordinarily, the system compacts the heap whenever the HeapFree function is called, 
		/// and the HeapCompact function returns the size of the largest free block in the heap but does not compact the heap any further. 
		/// If the Disable heap coalesce on free global flag is set during debugging, the system does not compact the heap and calling the HeapCompact function 
		/// does compact the heap. For more information about global flags, see the GFlags documentation.
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	HeapCompact ( IntPtr  hHeap, HEAP_Constants  dwFlags ) ;
		# endregion
	    }
    }