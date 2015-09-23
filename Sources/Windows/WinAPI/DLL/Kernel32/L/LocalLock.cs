/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LocalLock.cs

    DESCRIPTION
        LocalLock() Windows function.

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
		/// Locks a local memory object and returns a pointer to the first byte of the object's memory block.
		/// <br/>
		/// <para>
		/// Note : The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used.
		/// </para>
		/// <param name="hMem">
		/// A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function.
		/// </param>
		/// </summary>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the first byte of the memory block.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The internal data structures for each memory object include a lock count that is initially zero. For movable memory objects, LocalLock increments 
		/// the count by one, and the LocalUnlock function decrements the count by one. Each successful call that a process makes to LocalLock for an object 
		/// must be matched by a corresponding call to LocalUnlock. Locked memory will not be moved or discarded unless the memory object is reallocated by using 
		/// the LocalReAlloc function. The memory block of a locked memory object remains locked in memory until its lock count is decremented to zero, at which time 
		/// it can be moved or discarded.
		/// <br/>
		/// <para>
		/// If the specified memory block has been discarded or if the memory block has a zero-byte size, this function returns NULL.
		/// </para>
		/// <br/>
		/// <para>
		/// Discarded objects always have a lock count of zero.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	LocalLock ( IntPtr  hMem ) ;
		# endregion
	    }
    }