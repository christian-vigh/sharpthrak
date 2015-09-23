/**************************************************************************************************************

    NAME
        WinAPI/User32/W/WindowFromDC.cs

    DESCRIPTION
        WindowFromDC() Windows function.

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
		/// The WindowFromDC function returns a handle to the window associated with the specified display device context (DC). 
		/// Output functions that use the specified device context draw into this window.
 		/// </summary>
		/// <param name="hDC">
		/// Handle to the device context from which a handle to the associated window is to be retrieved.
		/// The return value is a handle to the window associated with the specified DC. If no window is associated with the specified DC, the return value is NULL.
		/// </param>
		/// <returns></returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	WindowFromDC ( IntPtr  hDC ) ;
		# endregion
	    }
    }