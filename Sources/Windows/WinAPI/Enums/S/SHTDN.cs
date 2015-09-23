/**************************************************************************************************************

    NAME
        WinAPI/Enums/S/SHTDN.cs

    DESCRIPTION
        SHTDN constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region SHTDN_ constants
	/// <summary>
	/// The shutdown reason codes are used by the ExitWindowsEx and InitiateSystemShutdownEx functions in the dwReason parameter. 
	/// </summary>
	public enum SHTDN_Constants : uint
	   {

		# region Major shutdown reasons
		/// <summary>
		/// Application issue.
		/// </summary>
		SHTDN_REASON_MAJOR_APPLICATION          	=  0x00040000,

		/// <summary>
		/// No specific reason was provided.
		/// </summary>
		SHTDN_REASON_MAJOR_NONE                 	=  0x00000000,

		/// <summary>
		/// Hardware issue.
		/// </summary>
		SHTDN_REASON_MAJOR_HARDWARE             	=  0x00010000,

		/// <summary>
		/// The InitiateSystemShutdown function was used instead of InitiateSystemShutdownEx.
		/// </summary>
		SHTDN_REASON_MAJOR_LEGACY_API           	=  0x00070000,

		/// <summary>
		/// Operating system issue.
		/// </summary>
		SHTDN_REASON_MAJOR_OPERATINGSYSTEM      	=  0x00020000,

		/// <summary>
		/// Other issue.
		/// </summary>
		SHTDN_REASON_MAJOR_OTHER                	=  0x00000000,

		/// <summary>
		/// Power failure.
		/// </summary>
		SHTDN_REASON_MAJOR_POWER                	=  0x00060000,

		/// <summary>
		/// Software issue.
		/// </summary>
		SHTDN_REASON_MAJOR_SOFTWARE             	=  0x00030000,

		/// <summary>
		/// System failure.
		/// </summary>
		SHTDN_REASON_MAJOR_SYSTEM               	=  0x00050000,

		# endregion

		# region Minor shutdown reasons
		/// <summary>
		/// Blue screen crash event.
		/// </summary>
		SHTDN_REASON_MINOR_BLUESCREEN           	=  0x0000000F,

		/// <summary>
		/// Unplugged.
		/// </summary>
		SHTDN_REASON_MINOR_CORDUNPLUGGED        	=  0x0000000b,

		/// <summary>
		/// Undocumented.
		/// </summary>
		SHTDN_REASON_MINOR_DC_DEMOTION          	=  0x00000022,

		/// <summary>
		/// Undocumented.
		/// </summary>
		SHTDN_REASON_MINOR_DC_PROMOTION         	=  0x00000021,

		/// <summary>
		/// Disk.
		/// </summary>
		SHTDN_REASON_MINOR_DISK                 	=  0x00000007,

		/// <summary>
		/// Environment.
		/// </summary>
		SHTDN_REASON_MINOR_ENVIRONMENT          	=  0x0000000c,

		/// <summary>
		/// Driver.
		/// </summary>
		SHTDN_REASON_MINOR_HARDWARE_DRIVER      	=  0x0000000d,

		/// <summary>
		/// Hot fix.
		/// </summary>
		SHTDN_REASON_MINOR_HOTFIX               	=  0x00000011,

		/// <summary>
		/// Hot fix uninstallation.
		/// </summary>
		SHTDN_REASON_MINOR_HOTFIX_UNINSTALL     	=  0x00000017,

		/// <summary>
		/// Unresponsive.
		/// </summary>
		SHTDN_REASON_MINOR_HUNG                 	=  0x00000005,

		/// <summary>
		/// Installation.
		/// </summary>
		SHTDN_REASON_MINOR_INSTALLATION         	=  0x00000002,

		/// <summary>
		/// Maintenance.
		/// </summary>
		SHTDN_REASON_MINOR_MAINTENANCE          	=  0x00000001,

		/// <summary>
		/// MMC issue.
		/// </summary>
		SHTDN_REASON_MINOR_MMC                  	=  0x00000019,

		/// <summary>
		/// Network card.
		/// </summary>
		SHTDN_REASON_MINOR_NETWORKCARD          	=  0x00000009,

		/// <summary>
		/// Network connectivity.
		/// </summary>
		SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY 	=  0x00000014,

		/// <summary>
		/// Minor reason unspecified.
		/// </summary>
		SHTDN_REASON_MINOR_NONE                 	=  0x000000ff,

		/// <summary>
		/// Other issue.
		/// </summary>
		SHTDN_REASON_MINOR_OTHER                	=  0x00000000,

		/// <summary>
		/// Other driver event.
		/// </summary>
		SHTDN_REASON_MINOR_OTHERDRIVER          	=  0x0000000e,

		/// <summary>
		/// Power supply.
		/// </summary>
		SHTDN_REASON_MINOR_POWER_SUPPLY         	=  0x0000000a,

		/// <summary>
		/// Processor.
		/// </summary>
		SHTDN_REASON_MINOR_PROCESSOR            	=  0x00000008,

		/// <summary>
		/// Reconfigure.
		/// </summary>
		SHTDN_REASON_MINOR_RECONFIG             	=  0x00000004,

		/// <summary>
		/// Security issue.
		/// </summary>
		SHTDN_REASON_MINOR_SECURITY             	=  0x00000013,

		/// <summary>
		/// Security patch.
		/// </summary>
		SHTDN_REASON_MINOR_SECURITYFIX          	=  0x00000012,

		/// <summary>
		/// Security patch uninstallation.
		/// </summary>
		SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL 	=  0x00000018,

		/// <summary>
		/// Service pack.
		/// </summary>
		SHTDN_REASON_MINOR_SERVICEPACK          	=  0x00000010,

		/// <summary>
		/// Service pack uninstallation.
		/// </summary>
		SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL 	=  0x00000016,

		/// <summary>
		/// System restore.
		/// </summary>
		SHTDN_REASON_MINOR_SYSTEMRESTORE        	=  0x0000001a,

		/// <summary>
		/// Terminal Services.
		/// </summary>
		SHTDN_REASON_MINOR_TERMSRV              	=  0x00000020,

		/// <summary>
		/// Unstable.
		/// </summary>
		SHTDN_REASON_MINOR_UNSTABLE             	=  0x00000006,

		/// <summary>
		/// Upgrade.
		/// </summary>
		SHTDN_REASON_MINOR_UPGRADE              	=  0x00000003,

		/// <summary>
		/// WMI issue.
		/// </summary>
		SHTDN_REASON_MINOR_WMI                  	=  0x00000015,

		/// <summary>
		/// Unknown reason (same as SHTDN_REASON_MINO_NONE).
		/// </summary>
		SHTDN_REASON_UNKNOWN                    	=  SHTDN_REASON_MINOR_NONE,
		# endregion

		# region Optional flags 
		/// <summary>
		/// The reason code is defined by the user.
		/// <para>
		/// If this flag is not present, the reason code is defined by the system.
		/// </para>
		/// </summary>
		SHTDN_REASON_FLAG_USER_DEFINED			=  0x40000000,

		/// <summary>
		/// The shutdown was planned. The system generates a System State Data (SSD) file. This file contains system state information such as the processes, 
		/// threads, memory usage, and configuration. 
		/// <para>
		/// If this flag is not present, the shutdown was unplanned. Notification and reporting options are controlled by a set of policies. 
		/// For example, after logging in, the system displays a dialog box reporting the unplanned shutdown if the policy has been enabled. 
		/// An SSD file is created only if the SSD policy is enabled on the system. The administrator can use Windows Error Reporting to send the SSD data 
		/// to a central location, or to Microsoft.
		/// </para>
		/// </summary>
		SHTDN_REASON_FLAG_PLANNED			=  0x80000000,
		# endregion

		# region Valid Major/minor combination recognized by the system and correctly logged
		/// <summary>
		/// An unplanned restart or shutdown to troubleshoot an unresponsive application.
		/// </summary>
		SHTDN_REASON_UNRESPONSIVE_APPLICATION		=  SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_HUNG,

		/// <summary>
		/// A planned restart or shutdown to perform application installation.
		/// </summary>
		SHTD_REASON_APPLICATION_PLANNED_RESTART		=  SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_INSTALLATION | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned restart or shutdown to service an application.
		/// </summary>
		SHTDN_REASON_APPLICATION_UNPLANNED_RESTART	=  SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_MAINTENANCE,

		/// <summary>
		/// A planned restart or shutdown to perform planned maintenance on an application.
		/// </summary>
		SHTDN_REASON_APPLICATION_PLANNED_MAINTENANCE	=  SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_MAINTENANCE | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// A planned restart or shutdown to perform planned maintenance on an application.
		/// </summary>
		SHTDN_REASON_APPLICATION_PLANNED_TROUBLESHOOT	=  SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_MAINTENANCE | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned restart or shutdown to troubleshoot an unstable application.
		/// </summary>
		SHTDN_REASON_APPLICATION_UNPLANNED_TROUBLESHOOT	=  SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_UNSTABLE,

		/// <summary>
		/// An unplanned restart or shutdown to begin or complete hardware installation.
		/// </summary>
		SHTDN_REASON_HARDWARE_UNPLANNED_RESTART		=  SHTDN_REASON_MAJOR_HARDWARE | SHTDN_REASON_MINOR_INSTALLATION,

		/// <summary>
		/// A planned restart or shutdown to begin or complete hardware installation.
		/// </summary>
		SHTDN_REASON_HARDWARE_PLANNED_RESTART		=  SHTDN_REASON_MAJOR_HARDWARE | SHTDN_REASON_MINOR_INSTALLATION | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned restart or shutdown to service hardware on the system.
		/// </summary>
		SHTDN_REASON_HARDWARE_UNPLANNED_MAINTENANCE	=  SHTDN_REASON_MAJOR_HARDWARE | SHTDN_REASON_MINOR_MAINTENANCE,

		/// <summary>
		/// A planned restart or shutdown to service hardware on the system.
		/// </summary>
		SHTDN_REASON_HARDWARE_PLANNED_MAINTENANCE	=  SHTDN_REASON_MAJOR_HARDWARE | SHTDN_REASON_MINOR_MAINTENANCE | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned restart or shutdown to install a hot fix.
		/// </summary>
		SHTDN_REASON_OS_UNPLANNED_HOTFIX		=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_HOTFIX,

		/// <summary>
		/// A planned restart or shutdown to install a hot fix.
		/// </summary>
		SHTDN_REASON_OS_PLANNED_HOTFIX			=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_HOTFIX | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned restart or shutdown to change the operating system configuration.
		/// </summary>
		SHTDN_REASON_OS_UNPLANNED_RECONFIGURATION	=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_RECONFIG,

		/// <summary>
		/// A planned restart or shutdown to change the operating system configuration.
		/// </summary>
		SHTDN_REASON_OS_PLANNED_RECONFIGURATION		=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_RECONFIG | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned restart or shutdown to install a security patch.
		/// </summary>
		SHTDN_REASON_OS_UNPLANNED_SECURITY_FIX		=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_SECURITYFIX,

		/// <summary>
		/// A planned restart or shutdown to install a security patch.
		/// </summary>
		SHTDN_REASON_OS_PLANNED_SECURITY_FIX		=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_SECURITYFIX | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// A planned restart or shutdown to install a service pack.
		/// </summary>
		SHTDN_REASON_OS_PLANNED_SERVICE_PACK		=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_SERVICEPACK | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// A planned restart or shutdown to upgrade the operating system configuration.
		/// </summary>
		SHTDN_REASON_OS_PLANNED_MINOR_UPGRADE		=  SHTDN_REASON_MAJOR_OPERATINGSYSTEM | SHTDN_REASON_MINOR_UPGRADE | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// An unplanned shutdown or restart.
		/// </summary>
		SHTDN_REASON_OTHER_UNPLANNED			=  SHTDN_REASON_MAJOR_OTHER | SHTDN_REASON_MINOR_OTHER,

		/// <summary>
		/// A planned shutdown or restart.
		/// </summary>
		SHTDN_REASON_OTHER_PLANNED			=  SHTDN_REASON_MAJOR_OTHER | SHTDN_REASON_MINOR_OTHER | SHTDN_REASON_FLAG_PLANNED,

		/// <summary>
		/// The system became unresponsive.
		/// </summary>
		SHTDN_REASON_OS_UNRESPONSIVE			=  SHTDN_REASON_MAJOR_OTHER | SHTDN_REASON_MINOR_HUNG,

		/// <summary>
		/// The computer was unplugged.
		/// </summary>
		SHTDN_REASON_COMPUTER_UNPLUGGED			=  SHTDN_REASON_MAJOR_POWER | SHTDN_REASON_MINOR_CORDUNPLUGGED,

		/// <summary>
		/// There was a power outage.
		/// </summary>
		SHTDN_REASON_POWER_OUTAGE			=  SHTDN_REASON_MAJOR_POWER | SHTDN_REASON_MINOR_ENVIRONMENT,

		/// <summary>
		/// The computer displayed a blue screen crash event.
		/// </summary>
		SHTDN_REASON_BLUESCREEN				=  SHTDN_REASON_MAJOR_SYSTEM | SHTDN_REASON_MINOR_BLUESCREEN,

		/// <summary>
		/// The computer needs to be shut down due to a network connectivity issue.
		/// </summary>
		SHTDN_REASON_NETWORK_CONNECTIVITY_LOSS		=  SHTDN_REASON_MAJOR_SYSTEM | SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY,

		/// <summary>
		/// The computer needs to be shut down due to a security issue.
		/// </summary>
		SHTDN_REASON_SECURITY_ISSUE			=  SHTDN_REASON_MAJOR_SYSTEM | SHTDN_REASON_MINOR_SECURITY,
		# endregion

		/// <summary>
		/// CallWindowsEx() has been called by the ExitWindows() function.
		/// </summary>
		SHTDN_REASON_EXITWINDOWS			=  0xFFFFFFFF
	    }
	# endregion
    }