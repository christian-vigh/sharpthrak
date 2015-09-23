/**************************************************************************************************************

    NAME
        WinAPI/Enums/H/Heap.cs

    DESCRIPTION
        Heap constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/31]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region Heap_ constants
	/// <summary>
	/// Flags used by the Heapxxx() functions.
	/// </summary>
	public enum HEAP_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		HEAP_NONE			=  0x00000000,

		/// <summary>
		/// The system will raise an exception to indicate a function failure, such as an out-of-memory condition, instead of returning NULL.
		/// <para>
		/// To ensure that exceptions are generated for all calls to this function, specify HEAP_GENERATE_EXCEPTIONS in the call to HeapCreate. 
		/// In this case, it is not necessary to additionally specify HEAP_GENERATE_EXCEPTIONS in this function call.
		/// </para>
		/// </summary>
		HEAP_GENERATE_EXCEPTIONS	=  0x00000004,

		/// <summary>
		/// Serialized access will not be used for this allocation. For more information, see Remarks.
		/// To ensure that serialized access is disabled for all calls to this function, specify HEAP_NO_SERIALIZE in the call to HeapCreate. 
		/// In this case, it is not necessary to additionally specify HEAP_NO_SERIALIZE in this function call.
		/// <para>
		/// This value should not be specified when accessing the process's default heap. The system may create additional threads within the application's process, 
		/// such as a CTRL+C handler, that simultaneously access the process's default heap.
		/// </para>
		/// </summary>
		HEAP_NO_SERIALIZE		=  0x00000001,

		/// <summary>
		/// The allocated memory will be initialized to zero. Otherwise, the memory is not initialized to zero.
		/// </summary>
		HEAP_ZERO_MEMORY		=  0x00000008,

		/// <summary>
		/// There can be no movement when reallocating a memory block. If this value is not specified, the function may move the block to a new location. 
		/// If this value is specified and the block cannot be resized without moving, the function fails, leaving the original memory block unchanged.
		/// </summary>
		HEAP_REALLOC_IN_PLACE_ONLY	=  0x00000010,

		/// <summary>
		/// All memory blocks that are allocated from this heap allow code execution, if the hardware enforces data execution prevention. 
		/// Use this flag heap in applications that run code from the heap. If HEAP_CREATE_ENABLE_EXECUTE is not specified and an application attempts 
		/// to run code from a protected page, the application receives an exception with the status code STATUS_ACCESS_VIOLATION. 
		/// </summary>
		HEAP_CREATE_ENABLE_EXECUTE      =  0x00040000

		/*** NOT YET DOCUMENTED 
		#define HEAP_TAIL_CHECKING_ENABLED      0x00000020      
		#define HEAP_FREE_CHECKING_ENABLED      0x00000040      
		#define HEAP_DISABLE_COALESCE_ON_FREE   0x00000080      
		#define HEAP_CREATE_ALIGN_16            0x00010000      
		#define HEAP_CREATE_ENABLE_TRACING      0x00020000      
		#define HEAP_CREATE_ENABLE_EXECUTE      0x00040000      
		#define HEAP_MAXIMUM_TAG                0x0FFF              
		#define HEAP_PSEUDO_TAG_FLAG            0x8000              
		#define HEAP_TAG_SHIFT                  18                  
		 ***/
	    }
	# endregion
    }