/**************************************************************************************************************

    NAME
        WinAPI/Structure/D/DRAWITEMSTRUCT.cs

    DESCRIPTION
        DRAWITEMSTRUCT structure sent through the WM_DRAWITEM message.

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
	/// Provides information that the owner window uses to determine how to paint an owner-drawn control or menu item. 
	/// <para>
	/// The owner window of the owner-drawn control or menu item receives a pointer to this structure as the lParam parameter of the WM_DRAWITEM message.
	/// </para>
	/// </summary>
   	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  DRAWITEMSTRUCT
	   {
		/// <summary>
		/// The control type. 
		/// </summary>
		public ODT_Constants		CtlType ;

		/// <summary>
		/// The identifier of the combo box, list box, button, or static control. This member is not used for a menu item.
		/// </summary>
		public uint			CtlID ;

		/// <summary>
		/// The menu item identifier for a menu item or the index of the item in a list box or combo box. For an empty list box or combo box, this member can be -1. 
		/// <para>
		/// This allows the application to draw only the focus rectangle at the coordinates specified by the rcItem member even though there are no items in the control.
		/// </para>
		/// <para>
		/// This indicates to the user whether the list box or combo box has the focus. How the bits are set in the itemAction member determines whether the rectangle is 
		/// to be drawn as though the list box or combo box has the focus. 
		/// </para>
		/// </summary>
		public uint			itemID ;

		/// <summary>
		/// The required drawing action. 
		/// </summary>
		public ODA_Constants		itemActions ;

		/// <summary>
		/// The visual state of the item after the current drawing action takes place. This member can be a combination of ODS_Constants values.
		/// </summary>
		public ODS_Constants		itemState ;
  
		/// <summary>
		/// A handle to the control for combo boxes, list boxes, buttons, and static controls. For menus, this member is a handle to the menu that contains the item. 
		/// </summary>
		public IntPtr			hwndItem ;

		/// <summary>
		/// A handle to a device context; this device context must be used when performing drawing operations on the control. 
		/// </summary>
		public IntPtr			hDC ;

		/// <summary>
		/// A rectangle that defines the boundaries of the control to be drawn. This rectangle is in the device context specified by the hDC member. 
		/// <para>
		/// The system automatically clips anything that the owner window draws in the device context for combo boxes, list boxes, and buttons, but 
		/// does not clip menu items. When drawing menu items, the owner window must not draw outside the boundaries of the rectangle defined by the rcItem member. 
		/// </para>
		/// </summary>
		public RECT			rcItem ;

		/// <summary>
		/// The application-defined value associated with the menu item. For a control, this parameter specifies the value last assigned to the list box or combo box 
		/// by the LB_SETITEMDATA or CB_SETITEMDATA message. If the list box or combo box has the LBS_HASSTRINGS or CBS_HASSTRINGS style, this value is initially zero. 
		/// <br/>
		/// <para>
		/// Otherwise, this value is initially the value that was passed to the list box or combo box in the lParam parameter of one of the following messages: 
		/// </para>
		/// <para>• CB_ADDSTRING</para>
		/// <para>• CB_INSERTSTRING</para>
		/// <para>• LB_ADDSTRING</para>
		/// <para>• LB_INSERTSTRING</para>
		/// <br/>
		/// <para>
		/// If CtlType is ODT_BUTTON or ODT_STATIC, itemData is zero. 
		/// </para>
		/// </summary>
		public IntPtr			itemData ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized DRAWITEMSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized DRAWITEMSTRUCT structure.</returns>
		public static implicit operator  DRAWITEMSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			DRAWITEMSTRUCT		Result ;
	
			Result. CtlID		=  0 ;
			Result. CtlType		=  ODT_Constants. ODT_NONE ;
			Result. hDC		=  IntPtr. Zero ;
			Result. hwndItem	=  IntPtr. Zero ;
			Result. itemActions	=  ODA_Constants. ODA_NONE ;
			Result. itemData	=  IntPtr. Zero ;
			Result. itemID		=  0 ;
			Result. itemState	=  ODS_Constants. ODS_NONE ;
			Result. rcItem		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }