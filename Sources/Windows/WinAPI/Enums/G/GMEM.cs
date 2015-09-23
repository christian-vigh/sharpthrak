/**************************************************************************************************************

    NAME
        WinAPI/Enums/G/GMEM.cs

    DESCRIPTION
        GMEM constants.

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
	# region GMEM_ constants
	/// <summary>
	/// Flags for the Globalxxx() functions.
	/// </summary>
	public enum GMEM_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		GMEM_NONE		=  0x0000,

		/// <summary>
		/// Combines GMEM_MOVEABLE and GMEM_ZEROINIT.
		/// </summary>
		GHND			=  GMEM_MOVEABLE | GMEM_ZEROINIT,

		/// <summary>
		/// Allocates fixed memory. The return value is a pointer.
		/// </summary>
		GMEM_FIXED		=  0x0000,

		/// <summary>
		/// Allocates movable memory. Memory blocks are never moved in physical memory, but they can be moved within the default heap.
		/// <para>
		/// The return value is a handle to the memory object. To translate the handle into a pointer, use the GlobalLock function.
		/// </para>
		/// <para>
		/// This value cannot be combined with GMEM_FIXED.
		/// </para>
		/// </summary>
		GMEM_MOVEABLE		=  0x0002,

		/// <summary>
		/// Initializes memory contents to zero.
		/// </summary>
		GMEM_ZEROINIT		=  0x0040,

		/// <summary>
		/// Combines GMEM_FIXED and GMEM_ZEROINIT.
		/// </summary>
		GPTR			=  GMEM_FIXED | GMEM_ZEROINIT,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_DDESHARE		=  0x2000,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_DISCARDABLE	=  0x0100,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_LOWER		=  GMEM_NOT_BANKED,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_NOCOMPACT		=  0x0010,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_NODISCARD		=  0x0020,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_NOT_BANKED		=  0x1000,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_NOTIFY		=  0x0080,

		/// <summary>
		/// Provided for compatibility with 16-bits Windows. This flag is ignored.
		/// </summary>
		GMEM_SHARE		=  0x2000,

		/// <summary>
		/// Used by LoaclRealloc to modify only the attributes of the memory segment instead of reallocating it.
		/// </summary>
		GMEM_MODIFY		=  0x0080,

		/// <summary>
		/// Valid GMEM flags mask.
		/// </summary>
		GMEM_VALID_FLAGS	=  0x7F72,

		/// <summary>
		/// Value returned by Globalxxx() functions when an invalid memory handle has been specified.
		/// </summary>
		GMEM_INVALID_HANDLE	=  0x8000,

		/// <summary>
		/// The memory segment has been discarded.
		/// <para>
		/// This flag is returned by the LocalFlags function.
		/// </para>
		/// </summary>
		GMEM_DISCARDED		=  0x4000,

		/// <summary>
		/// Used by the LocalFlags function. Returns the lock count for a memory segment.
		/// </summary>
		GMEM_LOCKCOUNT		=  0x00FF
	    }
	# endregion
    }