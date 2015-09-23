/**************************************************************************************************************

    NAME
        WinAPI/Structure/H/HELPINFO.cs

    DESCRIPTION
        HELPINFO structure.

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


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information about an item for which context-sensitive Help has been requested.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  HELPINFO
	   {
		/// <summary>
		/// The structure size, in bytes.
		/// </summary>
		public uint				cbSize ;

		/// <summary>
		/// The type of context for which Help is requested. 
		/// </summary>
		public HELPINFO_Constants		iContextType ;

		/// <summary>
		/// The identifier of the window or control if iContextType is HELPINFO_WINDOW, or identifier of the menu item if iContextType is HELPINFO_MENUITEM.
		/// </summary>
		public int				iCtrlId ;

		/// <summary>
		/// The identifier of the child window or control if iContextType is HELPINFO_WINDOW, or identifier of the associated menu if iContextType is HELPINFO_MENUITEM.
		/// </summary>
		public IntPtr				hItemHandle ;

		/// <summary>
		/// The help context identifier of the window or control.
		/// </summary>
		public uint				dwContextId ;

		/// <summary>
		/// The POINT structure that contains the screen coordinates of the mouse cursor. This is useful for providing Help based on the position of the mouse cursor.
		/// </summary>
		public POINT				MousePos ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized HELPINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized HELPINFO structure.</returns>
		public static implicit operator  HELPINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			HELPINFO		Result ;

			Result. cbSize			=  Macros. GETSTRUCTSIZE ( typeof ( HELPINFO ) ) ;
			Result. dwContextId		=  0 ;
			Result. hItemHandle		=  IntPtr. Zero ;
			Result. iContextType		=  0 ;
			Result. iCtrlId			=  0 ;
			Result. MousePos		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }