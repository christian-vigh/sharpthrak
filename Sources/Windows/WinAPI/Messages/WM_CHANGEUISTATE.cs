/**************************************************************************************************************

    NAME
        WM_CHANGEUISTATE.cs

    DESCRIPTION
        WM_CHANGEUISTATE message helper classes.

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
	# region WM_CHANGEUISTATE_WPARAM layout structure
	/// <summary>
	/// Maps the WPARAM parameter of the WM_CHANGEUISTATE_WPARAM window message to a BitLayout structure.
	/// </summary>
	public class	WM_CHANGEUISTATE_WPARAM	:  BitLayout
	   {
		public  WM_CHANGEUISTATE_WPARAM ( )  : base ( 32 )
		   { }

		/// <summary>
		/// Type of action to be taken.
		/// </summary>
		[LOWORD ( )]
		public BitField<UIS_Constants>		Action ;

		
		/// <summary>
		/// Specifies which UI state elements are affected or the style of the control.
		/// </summary>
		[HIWORD ( )]
		public BitField<UISF_Constants>		AffectedUIElements ;
	    }
	# endregion
    }
