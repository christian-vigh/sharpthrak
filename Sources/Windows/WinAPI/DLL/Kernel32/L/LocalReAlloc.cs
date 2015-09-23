/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LocalReAlloc.cs

    DESCRIPTION
        LocalReAlloc() Windows function.

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
		/// Changes the size or the attributes of a specified local memory object. The size can increase or decrease.
		/// <br/>
		/// <para>
		/// Note  The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used.
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A handle to the local memory object to be reallocated. This handle is returned by either the LocalAlloc or LocalReAlloc function.
		/// </param>
		/// <param name="uBytes">
		/// The new size of the memory block, in bytes. If uFlags specifies LMEM_MODIFY, this parameter is ignored.
		/// </param>
		/// <param name="uFlags">
		/// The reallocation options. If LMEM_MODIFY is specified, the function modifies the attributes of the memory object only (the uBytes parameter is ignored.) 
		/// Otherwise, the function reallocates the memory object.
		/// <para>
		/// You can optionally combine LMEM_MODIFY with the LMEM_MOVEABLE flag to allocate moveable memory.
		/// </para>
		/// <para>
		/// If the memory is a locked LMEM_MOVEABLE memory block or a LMEM_FIXED memory block and this flag is not specified, the memory can only be reallocated in place.
		/// </para>
		/// <para>
		/// If this parameter does not specify LMEM_MODIFY, you can use the LMEM_ZEROINIT flag, which causes the additional memory contents to be initialized to zero 
		/// if the memory object is growing in size.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If LocalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// <br/>
		/// <para>
		/// If LocalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. 
		/// To access the memory, a process can simply cast the return value to a pointer.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	LocalReAlloc ( IntPtr  hMem, uint  uBytes, LMEM_Constants  uFlags ) ;
		# endregion
	    }
    }