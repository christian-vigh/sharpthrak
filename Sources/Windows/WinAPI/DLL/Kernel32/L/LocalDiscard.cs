/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LocalDiscard.cs

    DESCRIPTION
        LocalDiscard() Windows function.

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
		/// Discards the specified local memory object. The lock count of the memory object must be zero.
		/// <br/>
		/// <para>
		/// Note  The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used.
		/// </para>
		/// </summary>
		/// <param name="hlocMem">
		/// A handle to the local memory object. This handle is returned by either the LocalAlloc or LocalReAlloc function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the local memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Although LocalDiscard discards the object's memory block, the handle to the object remains valid. 
		/// A process can subsequently pass the handle to the LocalReAlloc function to allocate another local memory object identified by the same handle.
		/// </remarks>
		public static IntPtr 	LocalDiscard ( IntPtr  hlocMem ) 
		   { return ( LocalReAlloc ( hlocMem, 0, LMEM_Constants. LMEM_MOVEABLE ) ) ; }
		# endregion
	    }
    }