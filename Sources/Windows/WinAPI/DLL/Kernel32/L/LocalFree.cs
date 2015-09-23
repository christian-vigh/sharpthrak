/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LocalFree.cs

    DESCRIPTION
        LocalFree() Windows function.

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
		/// Frees the specified local memory object and invalidates its handle.
		/// <br/>
		/// <para>
		/// Note : The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used.
		/// </para>
		/// </summary>
		/// <param name="hlocMem">
		/// A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function. 
		/// It is not safe to free memory allocated with GlobalAlloc.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is NULL.
		/// <para>
		/// If the function fails, the return value is equal to a handle to the local memory object. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If the process tries to examine or modify the memory after it has been freed, 
		/// heap corruption may occur or an access violation exception (EXCEPTION_ACCESS_VIOLATION) may be generated.
		/// <br/>
		/// <para>
		/// If the hMem parameter is NULL, LocalFree ignores the parameter and returns NULL.
		/// </para>
		/// <br/>
		/// <para>
		/// The LocalFree function will free a locked memory object. A locked memory object has a lock count greater than zero. 
		/// The LocalLock function locks a local memory object and increments the lock count by one. 
		/// The LocalUnlock function unlocks it and decrements the lock count by one. 
		/// To get the lock count of a local memory object, use the LocalFlags function.
		/// </para>
		/// <br/>
		/// <para>
		/// If an application is running under a debug version of the system, LocalFree will issue a message that tells you that a locked object is being freed. 
		/// If you are debugging the application, LocalFree will enter a breakpoint just before freeing a locked object. 
		/// This allows you to verify the intended behavior, then continue execution.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	LocalFree ( IntPtr  hlocMem ) ;
		# endregion
	    }
    }