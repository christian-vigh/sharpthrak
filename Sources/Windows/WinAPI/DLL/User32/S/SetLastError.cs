/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetLastError.cs

    DESCRIPTION
        SetLastError() Windows function.

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
		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// </summary>
		/// <param name="dwErrCode">The last-error code for the thread.</param>
		/// <remarks>
		/// The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.
		/// <para>
		/// Most functions call SetLastError or SetLastErrorEx only when they fail. However, some system functions call SetLastError or SetLastErrorEx 
		/// under conditions of success; those cases are noted in each function's documentation.
		/// </para>
		/// <para>
		/// Applications can optionally retrieve the value set by this function by using the GetLastError function immediately after a function fails.
		/// Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes ; 
		/// no system error code has this bit set. 
		/// </para>
		/// <para>
		/// If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and 
		/// to ensure that your error code does not conflict with any system-defined error codes.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true )]
		public static extern void	SetLastError ( UInt32  dwErrCode ) ;


		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// </summary>
		/// <param name="dwErrCode">The last-error code for the thread.</param>
		/// <remarks>
		/// The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.
		/// Most functions call SetLastError or SetLastErrorEx only when they fail. However, some system functions call SetLastError or SetLastErrorEx 
		/// under conditions of success; those cases are noted in each function's documentation.
		/// Applications can optionally retrieve the value set by this function by using the GetLastError function immediately after a function fails.
		/// Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes ; 
		/// no system error code has this bit set. 
		/// If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and 
		/// to ensure that your error code does not conflict with any system-defined error codes.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true )]
		public static extern void	SetLastError ( ERROR_Constants  dwErrCode ) ;


		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// </summary>
		/// <param name="dwErrCode">The last-error code for the thread.</param>
		/// <param name="dwType">Error type. This parameter is currently not used.</param>
		/// <remarks>
		/// The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.
		/// Most functions call SetLastError or SetLastErrorEx only when they fail. However, some system functions call SetLastError or SetLastErrorEx 
		/// under conditions of success; those cases are noted in each function's documentation.
		/// Applications can optionally retrieve the value set by this function by using the GetLastError function immediately after a function fails.
		/// Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes ; 
		/// no system error code has this bit set. 
		/// If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and 
		/// to ensure that your error code does not conflict with any system-defined error codes.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true )]
		public static extern void	SetLastError ( UInt32  dwErrCode, UInt32  dwType ) ;


		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// </summary>
		/// <param name="dwErrCode">The last-error code for the thread.</param>
		/// <param name="dwType">Error type. This parameter is currently not used.</param>
		/// <remarks>
		/// The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.
		/// Most functions call SetLastError or SetLastErrorEx only when they fail. However, some system functions call SetLastError or SetLastErrorEx 
		/// under conditions of success; those cases are noted in each function's documentation.
		/// Applications can optionally retrieve the value set by this function by using the GetLastError function immediately after a function fails.
		/// Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes ; 
		/// no system error code has this bit set. 
		/// If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and 
		/// to ensure that your error code does not conflict with any system-defined error codes.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true )]
		public static extern void	SetLastError ( ERROR_Constants  dwErrCode, SLE_Constants  dwType ) ;
	    }
    }