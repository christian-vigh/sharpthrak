/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GlobalMemoryStatus.cs

    DESCRIPTION
        GlobalMemoryStatus() Windows function.

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
		/// Retrieves information about the system's current usage of both physical and virtual memory.
		/// </summary>
		/// <param name="lpBuffer">
		/// A pointer to a MEMORYSTATUS structure. The GlobalMemoryStatus function stores information about current memory availability into this structure.
		/// </param>
		/// <remarks>
		/// On computers with more than 4 GB of memory, the GlobalMemoryStatus function can return incorrect information, reporting a value of –1 
		/// to indicate an overflow. For this reason, applications should use the GlobalMemoryStatusEx function instead.
		/// <br/>
		/// <para>
		/// On Intel x86 computers with more than 2 GB and less than 4 GB of memory, the GlobalMemoryStatus function will always return 2 GB in the dwTotalPhys member 
		/// of the MEMORYSTATUS structure. Similarly, if the total available memory is between 2 and 4 GB, the dwAvailPhys member of the MEMORYSTATUS structure will be 
		/// rounded down to 2 GB. If the executable is linked using the /LARGEADDRESSAWARE linker option, then the GlobalMemoryStatus function will return 
		/// the correct amount of physical memory in both members.
		/// </para>
		/// <br/>
		/// <para>
		/// The information returned by the GlobalMemoryStatus function is volatile. There is no guarantee that two sequential calls to this function will return 
		/// the same information.
		/// </para>
		/// </remarks>
		[DllImport ( KERNEL32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern void 	GlobalMemoryStatus ( out MEMORYSTATUS  lpBuffer ) ;
		# endregion
	    }
    }