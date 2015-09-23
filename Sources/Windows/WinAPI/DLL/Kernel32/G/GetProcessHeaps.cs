/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetProcessHeaps.cs

    DESCRIPTION
        GetProcessHeaps() Windows function.

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
		/// Returns the number of active heaps and retrieves handles to all of the active heaps for the calling process.
		/// </summary>
		/// <param name="NumberOfHeaps">
		/// The maximum number of heap handles that can be stored into the buffer pointed to by ProcessHeaps.
		/// </param>
		/// <param name="ProcessHeaps">
		/// A pointer to a buffer that receives an array of heap handles.
		/// </param>
		/// <returns>
		/// The return value is the number of handles to heaps that are active for the calling process.
		/// <br/>
		/// <para>
		/// If the return value is less than or equal to NumberOfHeaps, the function has stored that number of heap handles in the buffer pointed to by ProcessHeaps.
		/// </para>
		/// <br/>
		/// <para>
		/// If the return value is greater than NumberOfHeaps, the buffer pointed to by ProcessHeaps is too small to hold all the heap handles for the calling process, 
		/// and the function stores NumberOfHeaps handles in the buffer. Use the return value to allocate a buffer that is large enough to receive all of the handles, 
		/// and call the function again.
		/// </para>
		/// <br/>
		/// <para>
		/// If the return value is zero, the function has failed because every process has at least one active heap, the default heap for the process. 
		/// To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The GetProcessHeaps function obtains a handle to the default heap of the calling process, plus handles to any additional private heaps created by 
		/// calling the HeapCreate function on any thread in the process. 
		/// <br/>
		/// <para>
		/// The GetProcessHeaps function is primarily useful for debugging, because some of the private heaps retrieved by the function may have been created by 
		/// other code running in the process and may be destroyed after GetProcessHeaps returns. Destroying a heap invalidates the handle to the heap, 
		/// and continued use of such handles can cause undefined behavior in the application. Heap functions should be called only on the default heap of 
		/// the calling process and on private heaps that the process creates and manages. 
		/// </para>
		/// <br/>
		/// <para>
		/// To obtain a handle to the process heap of the calling process, use the GetProcessHeap function. 
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint	GetProcessHeaps ( uint  NumberOfHeaps, IntPtr[] ProcessHeaps ) ;
		# endregion

		# region Version to retrieve the number of process heaps
		/// <summary>
		/// Retrieves the number of process heaps.
		/// </summary>
		/// <returns>
		/// The number of process heaps.
		/// </returns>
		public static uint		GetProcessHeapCount ( )
		   { return ( GetProcessHeaps ( 0, null ) ) ; }
		# endregion
	    }
    }