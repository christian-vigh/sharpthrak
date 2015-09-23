/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalDiscard.cs

    DESCRIPTION
        GlobalDiscard() Windows function.

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
		/// Discards the specified global memory block. The lock count of the memory object must be zero.
		/// <br/>
		/// <para>
		/// Note  The global functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a global function should be used.
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Although GlobalDiscard discards the object's memory block, the handle to the object remains valid. 
		/// The process can subsequently pass the handle to the GlobalReAlloc function to allocate another global memory block identified by the same handle.
		/// </remarks>
		public static  IntPtr 	GlobalDiscard ( IntPtr  hMem )
		   { return ( GlobalReAlloc ( hMem, 0, GMEM_Constants. GMEM_MOVEABLE ) ) ; }
		# endregion
	    }
    }