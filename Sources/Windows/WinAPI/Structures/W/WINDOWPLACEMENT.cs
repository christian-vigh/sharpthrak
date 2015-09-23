/**************************************************************************************************************

    NAME
        WinAPI/Structure/W/WINDOWPLACEMENT.cs

    DESCRIPTION
        WINDOWPLACEMENT structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information about the placement of a window on the screen. 
	/// </summary>
	/// 
	/// <remarks>
	/// If the window is a top-level window that does not have the WS_EX_TOOLWINDOW window style, then the coordinates represented by the following members are 
	/// in workspace coordinates: ptMinPosition, ptMaxPosition, and rcNormalPosition. Otherwise, these members are in screen coordinates.
	/// <para>
	/// Workspace coordinates differ from screen coordinates in that they take the locations and sizes of application toolbars (including the taskbar) into account. 
	/// Workspace coordinate (0,0) is the upper-left corner of the workspace area, the area of the screen not being used by application toolbars.
	/// </para>
	/// <para>
	/// The coordinates used in a WINDOWPLACEMENT structure should be used only by the GetWindowPlacement and SetWindowPlacement functions. 
	/// </para>
	/// <para>
	/// Passing workspace coordinates to functions which expect screen coordinates (such as SetWindowPos) will result in the window appearing in the wrong location. 
	/// For example, if the taskbar is at the top of the screen, saving window coordinates using GetWindowPlacement and restoring them using SetWindowPos causes 
	/// the window to appear to "creep" up the screen. 
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  WINDOWPLACEMENT
	   {
		/// <summary>
		/// The length of the structure, in bytes. Before calling the GetWindowPlacement or SetWindowPlacement functions, set this member to sizeof(WINDOWPLACEMENT). 
		/// <para>
		/// GetWindowPlacement and SetWindowPlacement fail if this member is not set correctly.
		/// </para>
		/// </summary>
		public uint		length ;

		/// <summary>
		/// The flags that control the position of the minimized window and the method by which the window is restored.
		/// </summary>
		public WPF_Constants	flags ;

		/// <summary>
		/// The current show state of the window.
		/// </summary>
		public SW_Constants	showCmd ;

		/// <summary>
		/// The coordinates of the window's upper-left corner when the window is minimized. 
		/// </summary>
		public POINT		ptMinPosition ;

		/// <summary>
		/// The coordinates of the window's upper-left corner when the window is maximized. 
		/// </summary>
		public POINT		ptMaxPosition ;

		/// <summary>
		/// The window's coordinates when the window is in the restored position. 
		/// </summary>
		public RECT		rcNormalPosition ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized WINDOWPLACEMENT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized WINDOWPLACEMENT structure.</returns>
		public static implicit operator  WINDOWPLACEMENT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			WINDOWPLACEMENT		Result ;

			Result. flags			=  WPF_Constants. WPF_NONE ;
			Result. length			=  Macros. GETSTRUCTSIZE ( typeof ( WINDOWPLACEMENT ) ) ;
			Result. ptMaxPosition		=  Structure. Empty ;
			Result. ptMinPosition		=  Structure. Empty ;
			Result. rcNormalPosition	=  Structure. Empty ;
			Result. showCmd			=  SW_Constants. SW_NONE ;

			return ( Result ) ;
		    }
	    }
    }