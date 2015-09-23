/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalReAlloc.cs

    DESCRIPTION
        GlobalReAlloc() Windows function.

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
		/// Changes the size or attributes of a specified global memory object. The size can increase or decrease.
		/// <br/>
		/// <para>
		/// Note  The global functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a global function should be used. 
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object to be reallocated. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.
		/// </param>
		/// <param name="dwBytes">
		/// The new size of the memory block, in bytes. If uFlags specifies GMEM_MODIFY, this parameter is ignored.
		/// </param>
		/// <param name="uFlags">
		/// The reallocation options. If GMEM_MODIFY is specified, the function modifies the attributes of the memory object only 
		/// (the dwBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// <br/>
		/// <para>
		/// You can optionally combine GMEM_MODIFY with GMEM_MOVEABLE to allocates movable memory.
		/// </para>
		/// <para>
		/// If the memory is a locked GMEM_MOVEABLE memory block or a GMEM_FIXED memory block and this flag is not specified, the memory can only be reallocated in place.
		/// </para>
		/// <para>
		/// If this parameter does not specify GMEM_MODIFY, you can use the GMEM_ZEROINIT flag to causes the additional memory contents 
		/// to be initialized to zero if the memory object is growing in size.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If GlobalReAlloc reallocates a movable object, the return value is a handle to the memory object. To convert the handle to a pointer, use the GlobalLock function.
		/// <br/>
		/// <para>
		/// If GlobalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. 
		/// To access the memory, a process can simply cast the return value to a pointer.
		/// </para>
		/// <para>
		/// If GlobalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GlobalReAlloc ( IntPtr  hMem, uint  dwBytes, GMEM_Constants  uFlags ) ;
		# endregion
	    }
    }