/**************************************************************************************************************

    NAME
        WinAPI/User32/H/HeapDestroy.cs

    DESCRIPTION
        HeapDestroy() Windows function.

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
		/// Destroys the specified heap object. It decommits and releases all the pages of a private heap object, and it invalidates the handle to the heap.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap to be destroyed. 
		/// This handle is returned by the HeapCreate function. Do not use the handle to the process heap returned by the GetProcessHeap function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// </returns>
		/// <remarks>
		/// Processes can call HeapDestroy without first calling the HeapFree function to free memory allocated from the heap.
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	HeapDestroy ( IntPtr  hHeap ) ;
		# endregion
	    }
    }