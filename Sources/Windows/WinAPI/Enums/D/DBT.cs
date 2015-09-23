/**************************************************************************************************************

    NAME
        WinAPI/Constants/D/DBT.cs

    DESCRIPTION
        Device mode change options.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region DBT_ values
	/// <summary>
	/// Device mode change constants.
	/// </summary>
	public enum DBT_Constants		:  int
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		DBT_NONE				=  0x0000,

		/// <summary>
		/// A request to change the current configuration (dock or undock) has been canceled.
		/// </summary>
		/// <remarks>
		/// The lParam parameter of the WM_DEVICECHANGE message is set to 0.
		/// </remarks>
		DBT_CONFIGCHANGECANCELED		=  0x0019,

		/// <summary>
		/// The current configuration has changed, due to a dock or undock.
		/// </summary>
		/// <remarks>
		/// The lParam parameter of the WM_DEVICECHANGE message is set to 0.
		/// </remarks>
		DBT_CONFIGCHANGED			=  0x0018,

		/// <summary>
		/// A custom event has occurred.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_CUSTOMEVENT				=  0x8006,

		/// <summary>
		/// A device or piece of media has been inserted and is now available.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device inserted. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_DEVICEARRIVAL			=  0x8000,

		/// <summary>
		/// Permission is requested to remove a device or piece of media. Any application can deny this request and cancel the removal.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device inserted. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_DEVICEQUERYREMOVE			=  0x8001,

		/// <summary>
		/// A request to remove a device or piece of media has been canceled.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device inserted. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_DEVICEQUERYREMOVEFAILED		=  0x8002,

		/// <summary>
		/// A device or piece of media has been removed.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device inserted. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_DEVICEREMOVECOMPLETE		=  0x8004,

		/// <summary>
		/// A device or piece of media is about to be removed. Cannot be denied.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device inserted. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_DEVICEREMOVEPENDING			=  0x8003,

		/// <summary>
		/// A device-specific event has occurred.
		/// </summary>
		/// <remarks>
		/// A pointer to a structure identifying the device inserted. The structure consists of an event-independent header, followed by event-dependent members 
		/// that describe the device. To use this structure, treat the structure as a DEV_BROADCAST_HDR structure, then check its dbch_devicetype member 
		/// to determine the device type.
		/// </remarks>
		DBT_DEVICETYPESPECIFIC			=  0x8005,

		/// <summary>
		/// A device has been added to or removed from the system.
		/// </summary>
		/// <remarks>
		/// The lParam
		/// <remarks>
		/// The lParam parameter of the WM_DEVICECHANGE message is set to 0.
		/// </remarks>
		DBT_DEVNODES_CHANGED			=  0x0007,

		/// <summary>
		/// Permission is requested to change the current configuration (dock or undock).
		/// </summary>
		/// <remarks>
		/// The lParam parameter of the WM_DEVICECHANGE message is set to 0.
		/// </remarks>
		DBT_QUERYCHANGECONFIG			=  0x0017,

		/// <summary>
		/// The meaning of this message is user-defined.
		/// </summary>
		/// <remarks>
		/// A pointer to a _DEV_BROADCAST_USERDEFINED structure which describes the user-defined broadcast in progress. 
		/// The dbud_szName member contains the name of the user-defined message, followed by any user-defined data.
		/// </remarks>
		DBT_USERDEFINED				=  0xFFFF
	    }
	# endregion
    }
