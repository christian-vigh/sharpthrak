/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalHandle.cs

    DESCRIPTION
        GlobalHandle() Windows function.

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
		/// Retrieves the handle associated with the specified pointer to a global memory block.
		/// <br/>
		/// <para>
		/// Note : The global functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a global function should be used.
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A pointer to the first byte of the global memory block. This pointer is returned by the GlobalLock function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the specified global memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// When the GlobalAlloc function allocates a memory object with GMEM_MOVEABLE, it returns a handle to the object. 
		/// The GlobalLock function converts this handle into a pointer to the memory block, and GlobalHandle converts the pointer back into a handle.
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GlobalHandle ( IntPtr  hMem ) ;
		# endregion
	    }
    }