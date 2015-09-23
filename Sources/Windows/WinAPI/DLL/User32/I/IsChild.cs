/**************************************************************************************************************

    NAME
        IsChild.cs

    DESCRIPTION
        IsChild() API.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Determines whether a window is a child window or descendant window of a specified parent window. 
		/// <para>
		/// A child window is the direct descendant of a specified parent window if that parent window is in the chain of parent windows; 
		/// the chain of parent windows leads from the original overlapped or pop-up window to the child window. 
		/// </para>
		/// </summary>
		/// <param name="hWndParent">A handle to the parent window. </param>
		/// <param name="hWnd">A handle to the window to be tested. </param>
		/// <returns>
		/// If the window is a child or descendant window of the specified parent window, the return value is nonzero.
		/// <para>
		/// If the window is not a child or descendant window of the specified parent window, the return value is zero.
		/// </para>
		/// </returns>
		[DllImport ( USER32 )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	IsChild ( IntPtr  hWndParent, IntPtr  hWnd ) ;
		# endregion
	    }
    }
