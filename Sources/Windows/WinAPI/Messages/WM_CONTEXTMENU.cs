/**************************************************************************************************************

    NAME
        WM_CONTEXTMENU.cs

    DESCRIPTION
        WM_CONTEXTMENU message helper classes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. Structures ;
using   Thrak. WinAPI. WAPI ;
using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Messages 
   {
	# region WM_CONTEXTMENU_LPARAM layout structure
	/// <summary>
	/// Maps the LPARAM parameter of the WM_CONTEXTMENU window message to a BitLayout structure.
	/// </summary>
	public class	WM_CONTEXTMENU_LPARAM	:  BitLayout
	   {
		public  WM_CONTEXTMENU_LPARAM ( )  : base ( 32 )
		   { }

		/// <summary>
		/// Horizontal position of the cursor, in screen coordinates, at the time of the mouse click. 
		/// </summary>
		[LOWORD ( )]
		public BitField<ushort>			MouseX ;

		
		/// <summary>
		/// Vertical position of the cursor, in screen coordinates, at the time of the mouse click. 
		/// </summary>
		[HIWORD ( )]
		public BitField<int>			MouseY ;
	    }
	# endregion
    }
