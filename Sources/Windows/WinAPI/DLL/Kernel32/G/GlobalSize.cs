﻿/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalSize.cs

    DESCRIPTION
        GlobalSize() Windows function.

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
		/// Retrieves the current size of the specified global memory object, in bytes.
		/// <br/>
		/// <para>
		/// Note : The global functions have greater overhead and provide fewer features than other memory management functions. 
		/// New applications should use the heap functions unless documentation states that a global function should be used.
		/// </para>
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object. This handle is returned by either the GlobalAlloc or GlobalReAlloc function.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the size of the specified global memory object, in bytes.
		/// <para>
		/// If the specified handle is not valid or if the object has been discarded, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The size of a memory block may be larger than the size requested when the memory was allocated.
		/// <para>
		/// To verify that the specified object's memory block has not been discarded, use the GlobalFlags function before calling GlobalSize.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	GlobalSize ( IntPtr  hMem ) ;
		# endregion
	    }
    }