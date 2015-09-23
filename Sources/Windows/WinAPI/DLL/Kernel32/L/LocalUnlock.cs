/**************************************************************************************************************

    NAME
        WinAPI/User32/X/LocalUnlock.cs

    DESCRIPTION
        LocalUnlock() Windows function.

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
		/// Decrements the lock count associated with a memory object that was allocated with LMEM_MOVEABLE. 
		/// This function has no effect on memory objects allocated with LMEM_FIXED.
		/// <br/>
		/// <para>
		/// Note  The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used.
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function.
		/// </param>
		/// <returns>
		/// If the memory object is still locked after decrementing the lock count, the return value is nonzero. 
		/// If the memory object is unlocked after decrementing the lock count, the function returns zero and GetLastError returns NO_ERROR.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero and GetLastError returns a value other than NO_ERROR.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The internal data structures for each memory object include a lock count that is initially zero. 
		/// For movable memory objects, the LocalLock function increments the count by one, and LocalUnlock decrements the count by one. 
		/// For each call that a process makes to LocalLock for an object, it must eventually call LocalUnlock. 
		/// Locked memory will not be moved or discarded unless the memory object is reallocated by using the LocalReAlloc function. 
		/// The memory block of a locked memory object remains locked until its lock count is decremented to zero, at which time it can be moved or discarded.
		/// <br/>
		/// <para>
		/// If the memory object is already unlocked, LocalUnlock returns FALSE and GetLastError reports ERROR_NOT_LOCKED. 
		/// Memory objects allocated with LMEM_FIXED always have a lock count of zero and cause the ERROR_NOT_LOCKED error.
		/// </para>
		/// <br/>
		/// <para>
		/// A process should not rely on the return value to determine the number of times it must subsequently call LocalUnlock for the memory block.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	LocalUnlock ( IntPtr  hMem ) ;
		# endregion
	    }
    }