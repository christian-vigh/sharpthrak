/**************************************************************************************************************

    NAME
        LB_ITEMFROMPOINT.cs

    DESCRIPTION
        LB_ITEMFROMPOINT message helper classes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/21]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. Structures ;
using   Thrak. WinAPI. WAPI ;
using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Messages 
   {
	# region LB_ITEMFROMPOINT_LPARAM layout structure
	/// <summary>
	/// Maps the LPARAM parameter of the LB_ITEMFROMPOINT window message to a BitLayout structure.
	/// </summary>
	public class	LB_ITEMFROMPOINT_WPARAM	:  BitLayout
	   {
		public  LB_ITEMFROMPOINT_WPARAM ( )  : base ( 32 )
		   { }


		/// <summary>
		/// Specifies the x-coordinate of a point, relative to the upper-left corner of the client area of the list box. 
		/// </summary>
		[LOWORD ( )]
		public BitField<ushort>		X ;


		/// <summary>
		/// Specifies the y-coordinate of a point, relative to the upper-left corner of the client area of the list box.
		/// </summary>
		[HIWORD ( )]
		public BitField<ushort>		Y ;
	    }
	# endregion
    }
