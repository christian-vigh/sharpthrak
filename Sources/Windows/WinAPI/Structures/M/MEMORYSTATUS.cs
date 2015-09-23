/**************************************************************************************************************

    NAME
        WinAPI/Structures/M/MEMORYSTATUS.cs

    DESCRIPTION
        MEMORYSTATUS structure.

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


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information about the current state of both physical and virtual memory. The GlobalMemoryStatus function stores information in a MEMORYSTATUS structure.
 	/// </summary>
	/// <remarks>
	/// MEMORYSTATUS reflects the state of memory at the time of the call. It also reflects the size of the paging file at that time. 
	/// The operating system can enlarge the paging file up to the maximum size set by the administrator.
	/// <br/>
	/// <para>
	/// On computers with more than 4 GB of memory, the MEMORYSTATUS structure can return incorrect information, reporting a value of –1 to indicate an overflow. 
	/// If your application is at risk for this behavior, use the GlobalMemoryStatusEx function instead of the GlobalMemoryStatus function.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  MEMORYSTATUS
	   {
		/// <summary>
		/// The size of the MEMORYSTATUS data structure, in bytes. You do not need to set this member before calling the GlobalMemoryStatus function; the function sets it.
		/// </summary>
		public uint	dwLength ;

		/// <summary>
		/// A number between 0 and 100 that specifies the approximate percentage of physical memory that is in use 
		/// (0 indicates no memory use and 100 indicates full memory use). 
		/// </summary>
		public uint	dwMemoryLoad ;

		/// <summary>
		/// The amount of actual physical memory, in bytes.
		/// </summary>
		public uint	dwTotalPhys ;

		/// <summary>
		/// The amount of physical memory currently available, in bytes. This is the amount of physical memory that can be immediately reused without 
		/// having to write its contents to disk first. It is the sum of the size of the standby, free, and zero lists.
		/// </summary>
		public uint	dwAvailPhys ;

		/// <summary>
		/// The current size of the committed memory limit, in bytes. This is physical memory plus the size of the page file, minus a small overhead.
		/// </summary>
		public uint	dwTotalPageFile ;

		/// <summary>
		/// The maximum amount of memory the current process can commit, in bytes. This value should be smaller than the system-wide available commit. 
		/// To calculate this value, call GetPerformanceInfo and subtract the value of CommitTotal from CommitLimit.
		/// </summary>
		public uint	dwAvailPageFile ;

		/// <summary>
		/// The size of the user-mode portion of the virtual address space of the calling process, in bytes. This value depends on the type of process, 
		/// the type of processor, and the configuration of the operating system. 
		/// For example, this value is approximately 2 GB for most 32-bit processes on an x86 processor and approximately 3 GB for 32-bit processes that 
		/// are large address aware running on a system with 4 GT RAM Tuning enabled.
		/// </summary>
		public uint	dwTotalVirtual ;

		/// <summary>
		/// The amount of unreserved and uncommitted memory currently in the user-mode portion of the virtual address space of the calling process, in bytes.
		/// </summary>
		public uint	dwAvailVirtual ;
  

		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MEMORYSTATUS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MEMORYSTATUS structure.</returns>
		public static implicit operator  MEMORYSTATUS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MEMORYSTATUS		Result ;

			Result. dwAvailPageFile		=  0 ;
			Result. dwAvailPhys		=  0 ;
			Result. dwAvailVirtual		=  0 ;
			Result. dwLength		=  Macros. GETSTRUCTSIZE ( typeof ( MEMORYSTATUS ) ) ;
			Result. dwMemoryLoad		=  0 ;
			Result. dwTotalPageFile		=  0 ;
			Result. dwTotalPhys		=  0 ;
			Result. dwTotalVirtual		=  0 ;

			return ( Result ) ;
		    }
	    }
    }