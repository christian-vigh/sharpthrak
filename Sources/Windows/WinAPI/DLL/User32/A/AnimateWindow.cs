/**************************************************************************************************************

    NAME
        WinAPI/User32/A/AnimateWindow.cs

    DESCRIPTION
        AnimateWindow() Windows function.

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
		/// Enables you to produce special effects when showing or hiding windows. There are four types of animation: roll, slide, collapse or expand, and alpha-blended fade. 
		/// </summary>
		/// <param name="hWnd">A handle to the window to animate. The calling thread must own this window. </param>
		/// <param name="dwTime">The time it takes to play the animation, in milliseconds. Typically, an animation takes 200 milliseconds to play. </param>
		/// <param name="dwFlags">The type of animation. This parameter can be one or more of the AW_Constants value.</param>
		/// <returns></returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	AnimateWindow ( IntPtr  hWnd, uint  dwTime, AW_Constants  dwFlags ) ;
		# endregion
	    }
    }