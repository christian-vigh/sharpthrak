/**************************************************************************************************************

    NAME
        WinAPI/User32/C/ChildWindowFromPoint.cs

    DESCRIPTION
        ChildWindowFromPoint() Windows function.

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
		/// Determines which, if any, of the child windows belonging to a parent window contains the specified point. 
		/// The search is restricted to immediate child windows. Grandchildren, and deeper descendant windows are not searched.
		/// <br/>
		/// <para>To skip certain child windows, use the ChildWindowFromPointEx function.</para>
		/// </summary>
		/// <param name="hwndParent">A handle to the parent window. </param>
		/// <param name="Point">A structure that defines the client coordinates, relative to hWndParent, of the point to be checked.</param>
		/// <returns>
		/// The return value is a handle to the child window that contains the point, even if the child window is hidden or disabled. 
		/// If the point lies outside the parent window, the return value is NULL. If the point is within the parent window but not within 
		/// any child window, the return value is a handle to the parent window. 
		/// </returns>
		/// <remarks>
		/// The system maintains an internal list, containing the handles of the child windows associated with a parent window. 
		/// The order of the handles in the list depends on the Z order of the child windows.
		/// If more than one child window contains the specified point, the system returns a handle to the first window in the list that contains 
		/// the point. 
		/// <br/>
		/// <para>
		/// ChildWindowFromPoint treats an HTTRANSPARENT area of a standard control the same as other parts of the control. 
		/// In contrast, RealChildWindowFromPoint treats an HTTRANSPARENT area differently; it returns the child window behind a transparent area 
		/// of a control. For example, if the point is in a transparent area of a groupbox, ChildWindowFromPoint returns the groupbox while 
		/// RealChildWindowFromPoint returns the child window behind the groupbox. However, both APIs return a static field, even though it, too, 
		/// returns HTTRANSPARENT.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	ChildWindowFromPoint ( IntPtr  hwndParent, POINT  Point ) ;
		# endregion
	    }
    }