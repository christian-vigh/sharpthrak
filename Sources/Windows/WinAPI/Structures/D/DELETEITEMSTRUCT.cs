/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/DELETEITEMSTRUCT.cs

    DESCRIPTION
        DELETEITEMSTRUCT structure, send through the WM_DELETEITEM Windows message.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Describes a deleted list box or combo box item. The lParam parameter of a WM_DELETEITEM message contains a pointer to this structure. 
	/// <para>
	/// When an item is removed from a list box or combo box or when a list box or combo box is destroyed, the system sends the WM_DELETEITEM message 
	/// to the owner for each deleted item.
	/// </para>
	/// <br/>
	/// <para>
	/// Windows NT/2000/XP: The system sends a WM_DELETEITEM message only for items deleted from an owner-drawn list box 
	/// (with the LBS_OWNERDRAWFIXED or LBS_OWNERDRAWVARIABLE style) or owner-drawn combo box (with the CBS_OWNERDRAWFIXED or CBS_OWNERDRAWVARIABLE style).
	/// </para>
	/// <para>
	/// Windows 95/98/Me: The system sends the WM_DELETEITEM message for any deleted list box or combo box item with nonzero item data.
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential, CharSet = CharSet. Auto )]
	public struct DELETEITEMSTRUCT
	   {
		/// <summary>
		/// Specifies whether the item was deleted from a list box or a combo box. One of the following values :
		/// <br/>
		/// <code>
		/// <para>Value         Meaning</para>
		/// <para>-----         -------</para>
		/// <para>ODT_LISTBOX   A list box.</para>
		/// <para>ODT_COMBOBOX  A combo box.</para>
		/// </code>
 		/// </summary>
		ODT_Constants		CtlType ;

		/// <summary>
		/// The identifier of the list box or combo box. 
		/// </summary>
		uint			CtlID ;

		/// <summary>
		/// The index of the item in the list box or combo box being removed. 
		/// </summary>
		uint			itemID ;

		/// <summary>
		/// A handle to the control. 
		/// </summary>
		IntPtr			hwndItem ;

		/// <summary>
		/// Application-defined data for the item. This value is passed to the control in the lParam parameter of the message that adds the item to the list box or combo box. 
		/// </summary>
		IntPtr			itemData ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized DELETEITEMSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized DELETEITEMSTRUCT structure.</returns>
		public static implicit operator  DELETEITEMSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			DELETEITEMSTRUCT		Result ;


			Result. CtlID		=  0 ;
			Result. CtlType		=  ODT_Constants. ODT_NONE ;
			Result. hwndItem	=  IntPtr. Zero ;
			Result. itemData	=  IntPtr. Zero ;
			Result. itemID		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
