/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CancelSynchronousIo.cs

    DESCRIPTION
        CancelSynchronousIo() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/11]     [Author : CV]
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
		/// Marks pending synchronous I/O operations that are issued by the specified thread as canceled.
		/// </summary>
		/// <param name="Handle">A handle to the thread.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is 0 (zero). To get extended error information, call the GetLastError function.</para>
		/// <para>If this function cannot find a request to cancel, the return value is 0 (zero), and GetLastError returns ERROR_NOT_FOUND.</para>
		/// </returns>
		/// <remarks>
		/// The caller must have the THREAD_TERMINATE access right.
		/// <br/>
		/// <para>
		/// If there are any pending I/O operations in progress for the specified thread, the CancelSynchronousIo function marks them for cancellation.
		/// Most types of operations can be canceled immediately; other operations can continue toward completion before they are actually canceled 
		/// and the caller is notified. The CancelSynchronousIo function does not wait for all canceled operations to complete. 
		/// </para>
		/// <br/>
		/// <para>
		/// • The operation completed normally. This can occur even if the operation was canceled, because the cancel request might not have been 
		/// submitted in time to cancel the operation.
		/// </para>
		/// <para>• The operation was canceled. The GetLastError function returns ERROR_OPERATION_ABORTED.</para>
		/// <para>• The operation failed with another error. The GetLastError function returns the relevant error code.</para>
		/// </remarks>
		[DllImport ( "Kernel32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CancelSynchronousIo ( IntPtr  hThread ) ;
		# endregion
	    }
    }