/**************************************************************************************************************

    NAME
        WinAPI/Functions/C/CancelIoEx.cs

    DESCRIPTION
        CancelIoEx() Windows function.

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
		/// Marks any outstanding I/O operations for the specified file handle. 
		/// The function only cancels I/O operations in the current process, regardless of which thread created the I/O operation.
		/// </summary>
		/// <param name="Handle">A handle to the file.</param>
		/// <param name="lpOverlapped">
		/// A pointer to an OVERLAPPED data structure that contains the data used for asynchronous I/O.
		/// <br/>
		/// <para>
		/// If this parameter is NULL, all I/O requests for the hFile parameter are canceled.
		/// </para>
		/// <br/>
		/// <para>
		/// If this parameter is not NULL, only those specific I/O requests that were issued for the file with the specified 
		/// lpOverlapped overlapped structure are marked as canceled, meaning that you can cancel one or more requests, 
		/// while the CancelIo function cancels all outstanding requests on a file handle.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. The cancel operation for all pending I/O operations issued by the calling thread 
		/// for the specified file handle was successfully requested. The application must not free or reuse the OVERLAPPED structure associated 
		/// with the canceled I/O operations until they have completed. The thread can use the GetOverlappedResult function to determine
		/// when the I/O operations themselves have been completed.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is 0 (zero). To get extended error information, call the GetLastError function.
		/// </para>
		/// <br/>
		/// <para>
		/// If this function cannot find a request to cancel, the return value is 0 (zero), and GetLastError returns ERROR_NOT_FOUND.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The CancelIoEx function allows you to cancel requests in threads other than the calling thread. 
		/// The CancelIo function only cancels requests in the same thread that called the CancelIo function. 
		/// CancelIoEx cancels only outstanding I/O on the handle, it does not change the state of the handle; 
		/// this means that you cannot rely on the state of the handle because you cannot know whether the operation was completed successfully 
		/// or canceled.
		/// <br/>
		/// <para>
		/// If the file handle is associated with a completion port, an I/O completion packet is not queued to the port if a synchronous operation 
		/// is successfully canceled. For asynchronous operations still pending, the cancel operation will queue an I/O completion packet.
		/// </para>
		/// <br/>
		/// <para>
		/// The operation being canceled is completed with one of three statuses; you must check the completion status to determine 
		/// the completion state. The three statuses are : 
		/// </para>
		/// <para>
		/// • The operation completed normally. This can occur even if the operation was canceled, because the cancel request might not have been 
		/// submitted in time to cancel the operation.
		/// </para>
		/// <para>• The operation was canceled. The GetLastError function returns ERROR_OPERATION_ABORTED.</para>
		/// <para>• The operation failed with another error. The GetLastError function returns the relevant error code.</para>
		/// </remarks>
		[DllImport ( "Kernel32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	CancelIoEx ( IntPtr  Handle, OVERLAPPED  lpOverlapped ) ;
		# endregion
	    }
    }