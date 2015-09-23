/**************************************************************************************************************

    NAME
        WM_ACTIVATE_WPARAM.cs

    DESCRIPTION
        WM_ACTIVATE message helper classes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. Structures ;
using   Thrak. WinAPI. WAPI ;
using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Messages 
   {
	# region WM_ACTIVATE_WPARAM layout structure
	/// <summary>
	/// Maps the WPARAM parameter of the WM_ACTIVATE window message to a BitLayout structure.
	/// </summary>
	public class	WM_ACTIVATE_WPARAM	:  BitLayout
	   {
		public  WM_ACTIVATE_WPARAM ( )  : base ( 32 )
		   { }

		/// <summary>
		/// Activation/deactivation reason.
		/// </summary>
		[LOWORD ( )]
		public BitField<WA_Constants>		Reason ;

		
		/// <summary>
		/// Minimized state of the window.
		/// </summary>
		[HIWORD ( )]
		public BitField<int>			MinimizedState ;
	    }
	# endregion
    }
