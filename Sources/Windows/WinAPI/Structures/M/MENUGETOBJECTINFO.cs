/**************************************************************************************************************

    NAME
        WinAPI/Structures/M/MENUGETOBJECTINFO.cs

    DESCRIPTION
        MENUGETOBJECTINFO structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
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
	/// Contains information about the menu that the mouse cursor is on.
	/// </summary>
	/// <remarks>
	/// The MENUGETOBJECTINFO structure is used only in drag-and-drop menus. When the WM_MENUGETOBJECT message is sent, 
	/// lParam is a pointer to this structure. 
	/// <br/>
	/// <para>
	/// To create a drag-and-drop menu, call SetMenuInfo with MNS_DRAGDROP set.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  MENUGETOBJECTINFO
	   {
		/// <summary>
		/// The position of the mouse cursor with respect to the item indicated by uPos. It is a bitmask of the MNGOF_Constants values.
		/// </summary>
		public MNGOF_Constants		dwFlags ;

		/// <summary>
		/// The position of the item the mouse cursor is on. 
		/// </summary>
		uint				uPos ;

		/// <summary>
		/// A handle to the menu the mouse cursor is on. 
		/// </summary>
		IntPtr				hMenu ;

		/// <summary>
		/// The identifier of the requested interface. Currently it can only be IDropTarget. 
		/// </summary>
		IntPtr				riid ;

		/// <summary>
		/// A pointer to the interface corresponding to the riid member. 
		/// This pointer is to be returned by the application when processing the message. 
		/// </summary>
		IntPtr				pvObj ;

		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MENUGETOBJECTINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MENUGETOBJECTINFO structure.</returns>
		public static implicit operator  MENUGETOBJECTINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MENUGETOBJECTINFO		Result ;

			Result. dwFlags		=  MNGOF_Constants. MNGOF_ZERO ;
			Result. hMenu		=  IntPtr. Zero ;
			Result. pvObj		=  IntPtr. Zero ;
			Result. riid		=  IntPtr. Zero ;
			Result. uPos		=  0 ;

			return ( Result ) ;
		    }
	    }
    }