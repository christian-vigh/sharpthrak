/**************************************************************************************************************

    NAME
        WinAPI/Constants/W/WPF.cs

    DESCRIPTION
        WPF constants.

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
	# region WPF_ constants
	/// <summary>
	/// The flags that control the position of the minimized window and the method by which the window is restored.ues. 
	/// </summary>
	public enum WPF_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		WPF_NONE				=  0x0000,

		/// <summary>
		/// If the calling thread and the thread that owns the window are attached to different input queues, the system posts the request to the thread that owns the window. 
		/// This prevents the calling thread from blocking its execution while other threads process the request.
		/// </summary>
		WPF_ASYNCWINDOWPLACEMENT		=  0x0004,

		/// <summary>
		/// The restored window will be maximized, regardless of whether it was maximized before it was minimized. 
		/// <para>
		/// This setting is only valid the next time the window is restored. It does not change the default restoration behavior. 
		/// </para>
		/// <para>
		/// This flag is only valid when the SW_SHOWMINIMIZED value is specified for the showCmd member.
		/// </para>
		/// </summary>
		WPF_RESTORETOMAXIMIZED			=  0x0002,

		/// <summary>
		/// The coordinates of the minimized window may be specified. 
		/// <para>
		/// This flag must be specified if the coordinates are set in the ptMinPosition member.
		/// </para>
		/// </summary>
		WPF_SETMINPOSITION			=  0x0001,
	    }
	# endregion
    }