/**************************************************************************************************************

    NAME
        WinAPI/Constants/F/FACILITY.cs

    DESCRIPTION
        Facility code constants for Windows error codes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	#  region FACILITY_ code constants
	/// <summary>
	/// Facility code constants for Windows error codes.
	/// </summary>
	public enum  FACILITY_Constants	: uint
	   {
		FACILITY_AAF                     	=  18,
		FACILITY_ACS                     	=  20,
		FACILITY_BACKGROUNDCOPY          	=  32,
		FACILITY_BCD                     	=  57,
		FACILITY_CERT                    	=  11,
		FACILITY_CMI                     	=  54,
		FACILITY_COMPLUS                 	=  17,
		FACILITY_CONFIGURATION           	=  33,
		FACILITY_CONTROL                 	=  10,
		FACILITY_DIRECTORYSERVICE        	=  37,
		FACILITY_DISPATCH                	=   2,
		FACILITY_DPLAY                   	=  21,
		FACILITY_FVE                     	=  49,
		FACILITY_FWP                     	=  50,
		FACILITY_GRAPHICS                	=  38,
		FACILITY_HTTP                    	=  25,
		FACILITY_INTERNET                	=  12,
		FACILITY_ITF                     	=   4,
		FACILITY_MBN                     	=  84,
		FACILITY_MEDIASERVER             	=  13,
		FACILITY_METADIRECTORY           	=  35,
		FACILITY_MSMQ                    	=  14,
		FACILITY_NDIS                    	=  52,
		FACILITY_NULL                    	=   0,
		FACILITY_OPC                     	=  81,
		FACILITY_PLA                     	=  48,
		FACILITY_RAS                     	=  83,
		FACILITY_RPC                     	=   1,
		FACILITY_SCARD                   	=  16,
		FACILITY_SDIAG                   	=  60,
		FACILITY_SECURITY                	=   9,
		FACILITY_SETUPAPI                	=  15,
		FACILITY_SHELL                   	=  39,
		FACILITY_SSPI                    	=   9,
		FACILITY_STATE_MANAGEMENT        	=  34,
		FACILITY_STORAGE                 	=   3,
		FACILITY_SXS                     	=  23,
		FACILITY_TPM_SERVICES            	=  40,
		FACILITY_TPM_SOFTWARE            	=  41,
		FACILITY_UI                      	=  42,
		FACILITY_UMI                     	=  22,
		FACILITY_URT                     	=  19,
		FACILITY_USERMODE_COMMONLOG      	=  26,
		FACILITY_USERMODE_FILTER_MANAGER 	=  31,
		FACILITY_USERMODE_HYPERVISOR     	=  53,
		FACILITY_USERMODE_VHD            	=  58,
		FACILITY_USERMODE_VIRTUALIZATION 	=  55,
		FACILITY_USERMODE_VOLMGR         	=  56,
		FACILITY_WEBSERVICES             	=  61,
		FACILITY_WIN32                   	=   7,
		FACILITY_WINDOWS                 	=   8,
		FACILITY_WINDOWSUPDATE           	=  36,
		FACILITY_WINDOWS_CE              	=  24,
		FACILITY_WINDOWS_DEFENDER        	=  80,
		FACILITY_WINRM                   	=  51,
		FACILITY_XPS                     	=  82
	    }
	# endregion
    }