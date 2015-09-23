/**************************************************************************************************************

    NAME
        WinAPI/Structures/O/OVERLAPPED.cs

    DESCRIPTION
        OVERLAPPED structure.

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


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information used in asynchronous (or overlapped) input and output (I/O).
	/// </summary>
	/// <remarks>
	/// Any unused members of this structure should always be initialized to zero before the structure is used in a function call. 
	/// Otherwise, the function may fail and return ERROR_INVALID_PARAMETER.
	/// <br/>
	/// <para>
	/// The Offset and OffsetHigh members together represent a 64-bit file position. It is a byte offset from the start of the file or file-like device,
	/// and it is specified by the user; the system will not modify these values. The calling process must set this member before passing the 
	/// OVERLAPPED structure to functions that use an offset, such as the ReadFile or WriteFile (and related) functions. 
	/// </para>
	/// <br/>
	/// <para>
	/// You can use the HasOverlappedIoCompleted macro to check whether an asynchronous I/O operation has completed if GetOverlappedResult 
	/// is too cumbersome for your application. 
	/// </para>
	/// <br/>
	/// <para>
	/// You can use the CancelIo function to cancel an asynchronous I/O operation.
	/// </para>
	/// <br/>
	/// <para>
	/// A common mistake is to reuse an OVERLAPPED structure before the previous asynchronous operation has been completed. 
	/// You should use a separate structure for each request. You should also create an event object for each thread that processes data. 
	/// If you store the event handles in an array, you could easily wait for all events to be signaled using the WaitForMultipleObjects function.
	/// </para>
	/// <br/>
	/// <para>
	/// For additional information and potential pitfalls of asynchronous I/O usage, see CreateFile, ReadFile, WriteFile, and related functions.
	/// </para>
	/// <br/>
	/// <para>
	/// For a general synchronization overview and conceptual OVERLAPPED usage information, see Synchronization and Overlapped Input and Output 
	/// and related topics.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Explicit ) ]
	public struct  OVERLAPPED
	   {
		/// <summary>
		/// The error code for the I/O request. When the request is issued, the system sets this member to STATUS_PENDING to indicate that 
		/// the operation has not yet started. When the request is completed, the system sets this member to the error code for the completed request. 
		/// <br/>
		/// <para>
		/// The Internal member was originally reserved for system use and its behavior may change. 
		/// </para>
		/// </summary>
		[FieldOffset ( 0 )]
		public ulong		Internal ;

		/// <summary>
		/// The number of bytes transferred for the I/O request. The system sets this member if the request is completed without errors. 
		/// <br/>
		/// <para>
		/// The InternalHigh member was originally reserved for system use and its behavior may change. 
		/// </para>
		/// </summary>
		[FieldOffset ( 8 )]
		public ulong		InternalHigh ;

		/// <summary>
		/// Reserved for system use; do not use after initialization to zero.
		/// </summary>
		[FieldOffset ( 16 )]
		public ulong		Pointer ;

		/// <summary>
		/// The low-order portion of the file position at which to start the I/O request, as specified by the user. 
		/// <br/>
		/// <para>
		/// This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset 
		/// (also referred to as a file pointer mechanism), such as a file. Otherwise, this member must be zero.
		/// </para>
		/// </summary>
		[FieldOffset ( 16 )]
		public uint		Offset ;

		/// <summary>
		/// The high-order portion of the file position at which to start the I/O request, as specified by the user. 
		/// <br/>
		/// <para>
		/// This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset 
		/// (also referred to as a file pointer mechanism), such as a file. Otherwise, this member must be zero.
		/// </para>
		/// </summary>
		[FieldOffset ( 20 )]
		public uint		OffsetHigh ;

		/// <summary>
		/// A handle to the event that will be set to a signaled state by the system when the operation has completed. 
		/// The user must initialize this member either to zero or a valid event handle using the CreateEvent function before passing 
		/// this structure to any overlapped functions. This event can then be used to synchronize simultaneous I/O requests for a device. 
		/// For additional information, see Remarks.
		/// <br/>
		/// <para>
		/// Functions such as ReadFile and WriteFile set this handle to the nonsignaled state before they begin an I/O operation. 
		/// When the operation has completed, the handle is set to the signaled state.
		/// </para>
		/// <br/>
		/// <para>
		/// Functions such as GetOverlappedResult and the synchronization wait functions reset auto-reset events to the nonsignaled state. 
		/// Therefore, you should use a manual reset event; if you use an auto-reset event, your application can stop responding if you wait 
		/// for the operation to complete and then call GetOverlappedResult with the bWait parameter set to TRUE.
		/// </para>
		/// </summary>
		[FieldOffset ( 24 )]
		public IntPtr		hEvent ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized OVERLAPPED structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized OVERLAPPED structure.</returns>
		public static implicit operator  OVERLAPPED ( Thrak. WinAPI. Structures. Structure  value )
		   {
			OVERLAPPED		Result ;

			Result. hEvent		=  IntPtr. Zero ;
			Result. Internal	=  0 ;
			Result. InternalHigh	=  0 ;
			Result. Pointer		=  0 ;
			Result. Offset		=  0 ;
			Result. OffsetHigh	=  0 ;

			return ( Result ) ;
		    }
	    }
    }