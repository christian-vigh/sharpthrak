/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/COMPAREITEMSTRUCT.cs

    DESCRIPTION
        COMPAREITEMSTRUCT structure, send through the WM_COMPAREITEM Windows message.

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
	/// Supplies the identifiers and application-supplied data for two items in a sorted, owner-drawn list box or combo box.
	/// <para>
	/// Whenever an application adds a new item to an owner-drawn list box or combo box created with the CBS_SORT or LBS_SORT style, 
	/// the system sends the owner a WM_COMPAREITEM message. The lParam parameter of the message contains a long pointer to a COMPAREITEMSTRUCT structure. 
	/// </para>
	/// <para>
	/// Upon receiving the message, the owner compares the two items and returns a value indicating which item sorts before the other. 
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct COMPAREITEMSTRUCT
	   {
		/// <summary>
		/// An ODT_LISTBOX (owner-drawn list box) or ODT_COMBOBOX (an owner-drawn combo box). 
		/// </summary>
		public ODT_Constants		CtlType ;

		/// <summary>
		/// The identifier of the list box or combo box. 
		/// </summary>
		public uint			CtlID ;

		/// <summary>
		/// A handle to the control. 
		/// </summary>
		public uint			hwndItem ;

		/// <summary>
		/// The index of the first item in the list box or combo box being compared. 
		/// <para>
		/// This member will be –1 if the item has not been inserted or when searching for a potential item in the list box or combo box. 
		/// </para>
		/// </summary>
		public uint			itemID1 ;

		/// <summary>
		/// Application-supplied data for the first item being compared. 
		/// <para>
		/// (This value was passed as the lParam parameter of the message that added the item to the list box or combo box.) 
		/// </para>
		/// </summary>
		public IntPtr			itemData1 ;

		/// <summary>
		/// The index of the second item in the list box or combo box being compared. 
		/// </summary>
		public uint			itemID2 ;

		/// <summary>
		/// Application-supplied data for the second item being compared. This value was passed as the lParam parameter of the message that added the item to the list box 
		/// or combo box. 
		/// <para>
		/// This member will be –1 if the item has not been inserted or when searching for a potential item in the list box or combo box. 
		/// </para>
		/// </summary>
		public IntPtr			itemData2 ;

		/// <summary>
		/// The locale identifier. To create a locale identifier, use the MAKELCID macro. 
		/// </summary>
		public uint			dwLocaleId ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized COMPAREITEMSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized COMPAREITEMSTRUCT structure.</returns>
		public static implicit operator  COMPAREITEMSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			COMPAREITEMSTRUCT		Result ;

			Result. CtlType		=  ODT_Constants. ODT_NONE ;
			Result. CtlID		=  0 ;
			Result. dwLocaleId	=  0 ;
			Result. hwndItem	=  0 ;
			Result. itemData1	=  IntPtr. Zero ;
			Result. itemData2	=  IntPtr. Zero ;
			Result. itemID1		=  0 ;
			Result. itemID2		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
