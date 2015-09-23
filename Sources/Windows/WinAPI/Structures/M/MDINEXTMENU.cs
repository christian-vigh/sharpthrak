/**************************************************************************************************************

    NAME
        WinAPI/Structures/M/MDINEXTMENU.cs

    DESCRIPTION
        MDINEXTMENU structure.

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


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information about the menu to be activated. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  MDINEXTMENU
	   {
		/// <summary>
		/// A handle to the current menu. 
		/// </summary>
		public IntPtr		hmenuIn ;

		/// <summary>
		/// A handle to the menu to be activated. 
		/// </summary>
		public IntPtr		hmenuNext ;

		/// <summary>
		/// A handle to the window to receive the menu notification messages. 
		/// </summary>
		public IntPtr		hwndNext ;

		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MDINEXTMENU structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MDINEXTMENU structure.</returns>
		public static implicit operator  MDINEXTMENU ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MDINEXTMENU		Result ;

			Result. hmenuIn		=  IntPtr. Zero ;
			Result. hmenuNext	=  IntPtr. Zero ;
			Result. hwndNext	=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }