/**************************************************************************************************************

    NAME
        WinAPI/User32/F/FlashWindowEx.cs

    DESCRIPTION
        FlashWindowEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
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
		/// Flashes the specified window. It does not change the active state of the window.
		/// </summary>
		/// <param name="pwfi">A pointer to a FLASHWINFO structure.</param>
		/// <returns>
		/// The return value specifies the window's state before the call to the FlashWindowEx function. 
		/// If the window caption was drawn as active before the call, the return value is nonzero. Otherwise, the return value is zero.
		/// </returns>
		/// <remarks>
		/// Typically, you flash a window to inform the user that the window requires attention but does not currently have the keyboard focus. 
		/// When a window flashes, it appears to change from inactive to active status. An inactive caption bar changes to an active caption bar; 
		/// an active caption bar changes to an inactive caption bar.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	FlashWindowEx ( ref FLASHWINFO  pwfi ) ;
		# endregion
	    }
    }