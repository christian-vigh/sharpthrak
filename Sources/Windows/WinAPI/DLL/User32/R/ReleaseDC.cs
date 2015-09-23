/**************************************************************************************************************

    NAME
        WinAPI/User32/R/ReleaseDC.cs

    DESCRIPTION
        ReleaseDC() Windows function.

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
		/// The ReleaseDC function releases a device context (DC), freeing it for use by other applications. 
		/// The effect of the ReleaseDC function depends on the type of DC. It frees only common and window DCs. It has no effect on class or private DCs.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be released.</param>
		/// <param name="hDC">A handle to the DC to be released.</param>
		/// <returns>
		/// The return value indicates whether the DC was released. If the DC was released, the return value is 1.
		/// <para>
		/// If the DC was not released, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The application must call the ReleaseDC function for each call to the GetWindowDC function and for each call to the GetDC function that retrieves a common DC.
		/// <br/>
		/// <para>
		/// An application cannot use the ReleaseDC function to release a DC that was created by calling the CreateDC function; instead, it must use the DeleteDC function. 
		/// ReleaseDC must be called from the same thread that called GetDC.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	ReleaseDC ( IntPtr  hWnd, IntPtr  hDC ) ;
		# endregion
	    }
    }