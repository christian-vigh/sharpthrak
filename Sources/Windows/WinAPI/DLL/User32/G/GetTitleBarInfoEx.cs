/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetTitleBarInfoEx.cs

    DESCRIPTION
        GetTitleBarInfoEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
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
		/// Retrieves information about the specified title bar.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose information is to be retrieved.</param>
		/// <param name="pwi">
		/// A pointer to a TITLEBARINFOEX structure to receive the information. 
		/// <para>
		/// Note that you must set the cbSize member to sizeof(TITLEBARINFOEX) before calling this function. 
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		public static bool GetTitleBarInfoEx ( IntPtr  hWnd, ref TITLEBARINFOEX  pwi )
		   {
			IntPtr		result		=   SendMessage ( hWnd, ( uint ) WM_Constants. WM_GETTITLEBARINFOEX, 0, ref pwi ) ;

			return ( ( result. ToInt32 ( )  ==  0 ) ?  false : true ) ;
		    }
	    }
    }