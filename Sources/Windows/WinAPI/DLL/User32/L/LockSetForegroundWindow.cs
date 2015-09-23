/**************************************************************************************************************

    NAME
        WinAPI/User32/L/LockSetForegroundWindow.cs

    DESCRIPTION
        LockSetForegroundWindow() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
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
		# region Generic version.
		/// <summary>
		/// The foreground process can call the LockSetForegroundWindow function to disable calls to the SetForegroundWindow function. 
		/// </summary>
		/// <param name="uLockCode">Specifies whether to enable or disable calls to SetForegroundWindow. This parameter can be one of the LSFW_Constants values.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The system automatically enables calls to SetForegroundWindow if the user presses the ALT key or takes some action that causes the system itself 
		/// to change the foreground window (for example, clicking a background window).
		/// <br/>
		/// <para>
		/// This function is provided so applications can prevent other applications from making a foreground change that can interrupt its interaction with the user.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	LockSetForegroundWindow ( LSFW_Constants  uLockCode ) ;
		# endregion
	    }
    }