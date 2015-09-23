/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetProcessHeap.cs

    DESCRIPTION
        GetProcessHeap() Windows function.

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
		/// Retrieves a handle to the default heap of the calling process. This handle can then be used in subsequent calls to the heap functions.
		/// </summary>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the calling process's heap.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The GetProcessHeap function obtains a handle to the default heap for the calling process. 
		/// A process can use this handle to allocate memory from the process heap without having to first create a private heap using the HeapCreate function.
		/// <br/>
		/// <para>
		/// Windows Server 2003 and Windows XP : To enable the low-fragmentation heap for the default heap of the process, call the HeapSetInformation function 
		/// with the handle returned by GetProcessHeap.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetProcessHeap ( ) ;
		# endregion
	    }
    }