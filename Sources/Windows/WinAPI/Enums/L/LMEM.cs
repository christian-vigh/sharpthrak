/**************************************************************************************************************

    NAME
        WinAPI/Enums/L/LMEM.cs

    DESCRIPTION
        LMEM constants.

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
	# region LMEM_ constants
	/// <summary>
	/// Flags for local memory allocation functions.
	/// </summary>
	public enum LMEM_Constants : int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		LMEM_NONE		=  0x0000,

		/// <summary>
		/// Combines LMEM_MOVEABLE and LMEM_ZEROINIT.
		/// </summary>
		LHND			=  LMEM_MOVEABLE | LMEM_ZEROINIT,

		/// <summary>
		/// Allocates fixed memory. The return value is a pointer to the memory object.
		/// </summary>
		LMEM_FIXED		=  0x0000,

		/// <summary>
		/// Allocates movable memory. Memory blocks are never moved in physical memory, but they can be moved within the default heap. 
		/// <para>
		/// The return value is a handle to the memory object. To translate the handle to a pointer, use the LocalLock function.
		/// </para>
		/// <para>
		/// This value cannot be combined with LMEM_FIXED.
		/// </para>
		/// </summary>
		LMEM_MOVEABLE		=  0x0002,

		/// <summary>
		/// Initializes memory contents to zero.
		/// </summary>
		LMEM_ZEROINIT		=  0x0040,

		/// <summary>
		/// Combines LMEM_FIXED and LMEM_ZEROINIT.
		/// </summary>
		LPTR			=  LMEM_FIXED | LMEM_ZEROINIT,

		/// <summary>
		/// Same as LMEM_MOVEABLE.
		/// </summary>
		NONZEROLHND		=  LMEM_MOVEABLE,

		/// <summary>
		/// Same as LMEM_FIXED.
		/// </summary>
		NONZEROLPTR		=  LMEM_FIXED,

		/// <summary>
		/// Ignored. Preserved for backward compatibility.
		/// </summary>
		LMEM_DISCARDABLE	=  0x0F00,

		/// <summary>
		/// Ignored. Preserved for backward compatibility.
		/// </summary>
		LMEM_NOCOMPACT		=  0x0010,

		/// <summary>
		/// Ignored. Preserved for backward compatibility.
		/// </summary>
		LMEM_NODISCARD		=  0x0020,

		/// <summary>
		/// Used by LoaclRealloc to modify only the attributes of the memory segment instead of reallocating it.
		/// </summary>
		LMEM_MODIFY		=  0x0080,

		/// <summary>
		/// Valid LMEM flags mask.
		/// </summary>
		LMEM_VALID_FLAGS	=  0x0F72,

		/// <summary>
		/// Value returned by Localxxx() functions when an invalid memory handle has been specified.
		/// </summary>
		LMEM_INVALID_HANDLE	=  0x8000,

		/// <summary>
		/// The memory segment has been discarded.
		/// <para>
		/// This flag is returned by the LocalFlags function.
		/// </para>
		/// </summary>
		LMEM_DISCARDED		=  0x4000,

		/// <summary>
		/// Used by the LocalFlags function. Returns the lock count for a memory segment.
		/// </summary>
		LMEM_LOCKCOUNT		=  0x00FF
	    }
	# endregion
    }