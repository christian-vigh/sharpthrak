/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SwapMouseButton.cs

    DESCRIPTION
        SwapMouseButton() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
		/// Reverses or restores the meaning of the left and right mouse buttons. 
 		/// </summary>
		/// <param name="fSwap">
		/// If this parameter is TRUE, the left button generates right-button messages and the right button generates left-button messages. 
		/// If this parameter is FALSE, the buttons are restored to their original meanings. 
		/// </param>
		/// <returns>
		/// If the meaning of the mouse buttons was reversed previously, before the function was called, the return value is nonzero.
		/// <para>
		/// If the meaning of the mouse buttons was not reversed, the return value is zero. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// Button swapping is provided as a convenience to people who use the mouse with their left hands. 
		/// The SwapMouseButton function is usually called by Control Panel only. Although an application is free to call the function, 
		/// the mouse is a shared resource and reversing the meaning of its buttons affects all applications. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SwapMouseButton ( [MarshalAs ( UnmanagedType. Bool )] bool  fSwap ) ;
		# endregion
	    }
    }