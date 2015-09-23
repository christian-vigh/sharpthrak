/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SystemParametersInfo.cs

    DESCRIPTION
        SystemParametersInfo() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
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
	public static partial class User32
	   {
		# region Generic signature
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool ) ]
		public static extern bool  SystemParametersInfo  ( uint  uiAction, uint  uiParam, IntPtr  pvParam, uint  fWinIni ) ;
		# endregion


		# region Specialized signatures with SPI_Constants for the uiAction parameter, and SPIF_COnstants for fWinIni.

		# region Signature with an IntPtr for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool ) ]
		public static extern bool  SystemParametersInfo  ( SPI_Constants  uiAction, uint  uiParam, IntPtr  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an UInt32 for pvParam
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An unsigned integer parameter depending on the value of the <paramref name="uiAction"/> parameter.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, UInt32  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT UInt32 for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an unsigned integer whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, out UInt32  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an int[] array for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An array of integers whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, int []  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT UInt64 for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an unsigned long integer whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, out UInt64  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with a String for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A string parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, String  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with a StringBuilder for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A StringBuilder parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, [Out] StringBuilder  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT String
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Output string to receive the parameter value.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		public static bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, out  String  pvParam, SPIF_Constants  fWinIni )
		   {
			if  ( uiParam  ==  0 )
				uiParam		=  1024 ;

			StringBuilder		sb		=  new StringBuilder ( ( int ) uiParam ) ; 
			bool			status		=  SystemParametersInfo ( uiAction, uiParam, sb, fWinIni ) ;

			pvParam		=  sb. ToString ( ) ;

			return ( status ) ;
		    }
		# endregion

		# region Signature with an IN ACCESSTIMEOUT structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An ACCESSTIMEOUT structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ACCESSTIMEOUT  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT ACCESSTIMEOUT structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an ACCESSTIMEOUT structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref ACCESSTIMEOUT  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN ANIMATIONINFO structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An ANIMATIONINFO structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ANIMATIONINFO  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT ANIMATIONINFO structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an ANIMATIONINFO structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref ANIMATIONINFO  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN AUDIODESCRIPTION structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An AUDIODESCRIPTION structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, AUDIODESCRIPTION  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT AUDIODESCRIPTION structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an AUDIODESCRIPTION structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref AUDIODESCRIPTION  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN FILTERKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A FILTERKEYS whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, FILTERKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT FILTERKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a FILTERKEYS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref FILTERKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN HIGHCONTRAST structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A HIGHCONTRAST structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, HIGHCONTRAST  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT HIGHCONTRAST structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a HIGHCONTRAST structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, out HIGHCONTRAST  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		#  region Signature with an IN ICONMETRICS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An ICONMETRICS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ICONMETRICS  pvParam, SPIF_Constants  fWinIni ) ;
		#  endregion

		# region Signature with an OUT ICONMETRICS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an ICONMETRICS whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref ICONMETRICS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN LOGFONT structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A LOGFONT structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, LOGFONT  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT LOGFONT structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a LOGFONT structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref LOGFONT  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN MINIMIZEDMETRICS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A MINIMIZEDMETRICS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, MINIMIZEDMETRICS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT MINIMIZEDMETRICS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a MINIMIZEDMETRICS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref MINIMIZEDMETRICS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN NONCLIENTMETRICS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A NONCLIENTMETRICS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, NONCLIENTMETRICS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT NONCLIENTMETRICS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a NONCLIENTMETRICS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref NONCLIENTMETRICS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN MOUSEKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A MOUSEKEYS structure whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, MOUSEKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT MOUSEKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a MOUSEKEYS structure. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref MOUSEKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN SOUNDSENTRY structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Input SOUNDSENTRY structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, SOUNDSENTRY  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT SOUNDSENTRY structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Output SOUNDSENTRY structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref SOUNDSENTRY  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN STICKYKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Input STICKYKEYS structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, STICKYKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT STICKYKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Output STICKEYKEYS structures.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref STICKYKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN TOGGLEKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Input TOGGLEKEYS structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, TOGGLEKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT TOGGLEKEYS structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Output TOGGLEKEYS structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, ref TOGGLEKEYS  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN RECT structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Input RECT structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, RECT  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT RECT structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// Output RECT structure.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, out RECT  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an IN FE_Constants structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// An FE_Constants value.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, FE_Constants  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT FE_Constants structure for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to an FE_Constants value.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, out FE_Constants  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with a Boolean value for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// An SPI_Constants value indicating the desired action.
		/// </param>
		/// <param name="uiParam">
		/// A boolean value whose usage and format depends on the system parameter being queried or set. 
		/// </param>
		/// <param name="pvParam">
		/// OInput boolean value.
		/// </param>
		/// <param name="fWinIni">
		/// An SPIF_Constants value indicating if the new value setting should be broadcast.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, [MarshalAs ( UnmanagedType. Bool )] Boolean  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# region Signature with an OUT Boolean value for pvParam.
		/// <summary>
		/// Retrieves or sets the value of one of the system-wide parameters. This function can also update the user profile while setting a parameter.
		/// </summary>
		/// <param name="uiAction">
		/// The system-wide parameter to be retrieved or set.
		/// </param>
		/// <param name="uiParam">
		/// A parameter whose usage and format depends on the system parameter being queried or set. 
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify zero for this parameter.</param>
		/// </para>
		/// <param name="pvParam">
		/// A pointer to a boolean value.
		/// <para>
		/// For more information about system-wide parameters, see the uiAction parameter. 
		/// </para>
		/// <para>
		/// If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// </para>
		/// <param name="fWinIni">
		/// If a system parameter is being set, specifies whether the user profile is to be updated, and if so, whether the WM_SETTINGCHANGE message 
		/// is to be broadcast to all top-level windows to notify them of the change. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError().
		/// </para>
		/// </returns>
		[DllImport ( USER32, CharSet = CharSet. Auto, SetLastError = true )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool SystemParametersInfo ( SPI_Constants  uiAction, uint  uiParam, [MarshalAs ( UnmanagedType. Bool )] out Boolean  pvParam, SPIF_Constants  fWinIni ) ;
		# endregion

		# endregion
	    }
    }
