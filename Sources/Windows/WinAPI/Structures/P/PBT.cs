/**************************************************************************************************************

    NAME
        WinAPI/Enums/P/PBT.cs

    DESCRIPTION
        PBT constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region PBT_ constants
	/// <summary>
	/// WM_POWERBROADCAST flags.
	/// </summary>
	public enum PBT_Constants : int
	   {
		/// <summary>
		/// indicates that a suspend operation failed after the PBT_APMSUSPEND event was broadcast.
		/// </summary>
		PBTF_APMRESUMEFROMFAILURE       	=  0x0001,

		/// <summary>
		/// Battery power is low. In Windows Server 2008 and Windows Vista, use PBT_APMPOWERSTATUSCHANGE instead.
		/// </summary>
		PBT_APMBATTERYLOW               	=  0x0009,

		/// <summary>
		/// OEM-defined event occurred. In Windows Server 2008 and Windows Vista, this event is not available because these operating systems support 
		/// only ACPI; APM BIOS events are not supported.
		/// </summary>
		PBT_APMOEMEVENT                 	=  0x000B,

		/// <summary>
		/// Power status has changed.
		/// </summary>
		PBT_APMPOWERSTATUSCHANGE        	=  0x000A,

		/// <summary>
		/// Not supported.
		/// </summary>
		PBT_APMQUERYSTANDBY             	=  0x0001,

		/// <summary>
		/// Not supported.
		/// </summary>
		PBT_APMQUERYSTANDBYFAILED       	=  0x0003,

		/// <summary>
		/// Request for permission to suspend. In Windows Server 2008 and Windows Vista, use the SetThreadExecutionState function instead.
		/// </summary>
		PBT_APMQUERYSUSPEND             	=  0x0000,

		/// <summary>
		/// Suspension request denied. In Windows Server 2008 and Windows Vista, use SetThreadExecutionState instead.
		/// </summary>
		PBT_APMQUERYSUSPENDFAILED       	=  0x0002,

		/// <summary>
		/// Operation is resuming automatically from a low-power state. This message is sent every time the system resumes.
		/// </summary>
		PBT_APMRESUMEAUTOMATIC          	=  0x0012,

		/// <summary>
		/// Operation resuming after critical suspension. In Windows Server 2008 and Windows Vista, use PBT_APMRESUMEAUTOMATIC instead. 
		/// </summary>
		PBT_APMRESUMECRITICAL           	=  0x0006,

		/// <summary>
		/// Not supported.
		/// </summary>
		PBT_APMRESUMESTANDBY            	=  0x0008,

		/// <summary>
		/// Operation is resuming from a low-power state. This message is sent after PBT_APMRESUMEAUTOMATIC if the resume is triggered by user input, 
		/// such as pressing a key.
		/// </summary>
		PBT_APMRESUMESUSPEND            	=  0x0007,

		/// <summary>
		/// Not supported.
		/// </summary>
		PBT_APMSTANDBY                  	=  0x0005,

		/// <summary>
		/// System is suspending operation.
		/// </summary>
		PBT_APMSUSPEND                  	=  0x0004,

		/// <summary>
		/// A power setting change event has been received. 
		/// </summary>
		PBT_POWERSETTINGCHANGE          	=  0x8013,

		/// <summary>
		/// Zero value.
		/// </summary>
		PBT_POWERSETTINGNONE			=  0x0000
	    }
	# endregion
    }