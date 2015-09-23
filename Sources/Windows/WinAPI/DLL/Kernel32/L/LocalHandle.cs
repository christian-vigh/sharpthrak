/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LocalHandle.cs

    DESCRIPTION
        LocalHandle() Windows function.

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
		/// Retrieves the handle associated with the specified pointer to a local memory object.
		/// <br/>
		/// <para>
		/// Note : The local functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a local function should be used. 
		/// </para>
		/// </summary>
		/// <param name="pMem">
		/// A pointer to the first byte of the local memory object. This pointer is returned by the LocalLock function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the specified local memory object.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// When the LocalAlloc function allocates a local memory object with LMEM_MOVEABLE, it returns a handle to the object. 
		/// The LocalLock function converts this handle into a pointer to the object's memory block, and LocalHandle converts the pointer back into a handle.
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	LocalHandle ( IntPtr  pMem ) ;
		# endregion
	    }
    }