/**************************************************************************************************************

    NAME
        WinAPI/User32/C/ChildWindowFromPointEx.cs

    DESCRIPTION
        ChildWindowFromPointEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
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
		/// Determines which, if any, of the child windows belonging to the specified parent window contains the specified point. 
		/// The function can ignore invisible, disabled, and transparent child windows. The search is restricted to immediate child windows. 
		/// Grandchildren and deeper descendants are not searched. 
		/// </summary>
		/// <param name="hWnd">A handle to the parent window. </param>
		/// <param name="Point">A structure that defines the client coordinates (relative to hwndParent) of the point to be checked. </param>
		/// <param name="uFlags">The child windows to be skipped. This parameter can be one or more of the CWP_Constants values.</param>
		/// <returns>
		/// The return value is a handle to the first child window that contains the point and meets the criteria specified by uFlags. 
		/// If the point is within the parent window but not within any child window that meets the criteria, the return value is a handle 
		/// to the parent window. If the point lies outside the parent window or if the function fails, the return value is NULL.
		/// </returns>
		/// <remarks>
		/// The system maintains an internal list that contains the handles of the child windows associated with a parent window. 
		/// The order of the handles in the list depends on the Z order of the child windows. If more than one child window contains 
		/// the specified point, the system returns a handle to the first window in the list that contains the point and meets the criteria 
		/// specified by uFlags.
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	ChildWindowFromPointEx ( IntPtr  hWnd, POINT  Point, CWP_Constants  uFlags ) ;
		# endregion
	    }
    }