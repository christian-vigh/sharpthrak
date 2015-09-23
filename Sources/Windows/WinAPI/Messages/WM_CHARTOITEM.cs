/**************************************************************************************************************

    NAME
        WM_CHARTOITEM.cs

    DESCRIPTION
        WM_CHARTOITEM message helper classes.

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
	# region WM_CHARTOITEM_WPARAM layout structure
	/// <summary>
	/// Maps the WPARAM parameter of the WM_CHARTOITEM_WPARAM window message to a BitLayout structure.
	/// </summary>
	public class	WM_CHARTOITEM_WPARAM	:  BitLayout
	   {
		public  WM_CHARTOITEM_WPARAM ( )  : base ( 32 )
		   { }


		/// <summary>
		/// Character code of the pressed key.
		/// </summary>
		[LOWORD ( )]
		public BitField<int>			CharacterCode ;	
		
		
		/// <summary>
		/// The current position of the caret. 
		/// </summary>
		[HIWORD ( )]
		public BitField<int>			CaretPosition ;	
	    }
	# endregion
    }
