/**************************************************************************************************************

    NAME
        WinAPI/User32/A/AllowSetForegroundWindow.cs

    DESCRIPTION
        AllowSetForegroundWindow() Windows function.

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
		/// Enables the specified process to set the foreground window using the SetForegroundWindow function. 
		/// The calling process must already be able to set the foreground window. For more information, see Remarks later in this topic.
		/// </summary>
		/// <param name="dwProcessId">
		/// The identifier of the process that will be enabled to set the foreground window. 
		/// If this parameter is ASFW_ANY, all processes will be enabled to set the foreground window. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. The function will fail if the calling process cannot set the foreground window. 
		/// To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The system restricts which processes can set the foreground window. A process can set the foreground window only if one of the following conditions is true :
		/// <para>• The process is the foreground process. </para>
		/// <para>• The process was started by the foreground process. </para>
		/// <para>• The process received the last input event. </para>
		/// <para>• There is no foreground process.</para>
		/// <para>• The foreground process is being debugged.</para>
		/// <para>• The foreground is not locked (see LockSetForegroundWindow).</para>
		/// <para>• The foreground lock time-out has expired (see SPI_GETFOREGROUNDLOCKTIMEOUT in SystemParametersInfo).</para>
		/// <para>No menus are active.</para>
		/// <br/>
		/// <para>
		/// A process that can set the foreground window can enable another process to set the foreground window by calling AllowSetForegroundWindow. 
		/// The process specified by dwProcessId loses the ability to set the foreground window the next time the user generates input, 
		/// unless the input is directed at that process, or the next time a process calls AllowSetForegroundWindow, unless that process is specified. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	AllowSetForegroundWindow ( uint  dwProcessId ) ;
		# endregion
	    }
    }