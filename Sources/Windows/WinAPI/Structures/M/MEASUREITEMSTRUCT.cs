/**************************************************************************************************************

    NAME
        WinAPI/Structure/M/MEASUREITEMSTRUCT.cs

    DESCRIPTION
        MEASUREITEMSTRUCT structure.

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
	/// Informs the system of the dimensions of an owner-drawn control or menu item. This allows the system to process user interaction with the control correctly. 
	/// </summary>
	/// 
	/// <remarks>
	/// The owner window of an owner-drawn control receives a pointer to the MEASUREITEMSTRUCT structure as the lParam parameter of a WM_MEASUREITEM message. 
	/// <para>
	/// The owner-drawn control sends this message to its owner window when the control is created. The owner then fills in the appropriate members in the structure 
	/// for the control and returns. This structure is common to all owner-drawn controls except the owner-drawn button control whose size is predetermined by its window. 
	/// </para>
	/// <para>
	/// If an application does not fill the appropriate members of MEASUREITEMSTRUCT, the control or menu item may not be drawn properly. 
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  MEASUREITEMSTRUCT
	   {
		/// <summary>
		/// The control type.
		/// </summary>
		public ODT_Constants		CtlType ;

		/// <summary>
		/// The identifier of the combo box or list box. This member is not used for a menu. 
		/// </summary>
		public uint			CtlID ;

		/// <summary>
		/// The identifier for a menu item or the position of a list box or combo box item. This value is specified for a list box only if it has 
		/// the LBS_OWNERDRAWVARIABLE style; this value is specified for a combo box only if it has the CBS_OWNERDRAWVARIABLE style. 		
		/// </summary>
		public uint			itemID ;

		/// <summary>
		/// The width, in pixels, of a menu item. Before returning from the message, the owner of the owner-drawn menu item must fill this member. 
		/// </summary>
		public uint			itemWidth ;

		/// <summary>
		/// The height, in pixels, of an individual item in a list box or a menu. Before returning from the message, the owner of the owner-drawn combo box, list box, 
		/// or menu item must fill out this member. 
		/// </summary>
		public uint			itemHeight ;

		/// <summary>
		/// The application-defined value associated with the menu item. For a control, this member specifies the value last assigned to the list box or combo box 
		/// by the LB_SETITEMDATA or CB_SETITEMDATA message. If the list box or combo box has the LB_HASSTRINGS or CB_HASSTRINGS style, this value is initially zero. 
		/// <para>
		/// Otherwise, this value is initially the value passed to the list box or combo box in the lParam parameter of one of the following messages :
		/// </para>
		/// <para>• CB_ADDSTRING</para>
		/// <para>• CB_INSERTSTRING</para>
		/// <para>• LB_ADDSTRING</para>
		/// <para>• LB_INSERTSTRING</para>
		/// </summary>
		public IntPtr			itemData ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MEASUREITEMSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MEASUREITEMSTRUCT structure.</returns>
		public static implicit operator  MEASUREITEMSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MEASUREITEMSTRUCT		Result ;

			Result. CtlID		=  0 ;
			Result. CtlType		=  ODT_Constants. ODT_NONE ;
			Result. itemData	=  IntPtr. Zero ;
			Result. itemHeight	=  0 ;
			Result. itemID		=  0 ;
			Result. itemWidth	=  0 ;

			return ( Result ) ;
		    }
	    }
    }