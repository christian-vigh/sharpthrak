/**************************************************************************************************************

    NAME
        WM_COMMAND.cs

    DESCRIPTION
        WM_COMMAND message helper classes.

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
	# region WM_COMMAND_WPARAM layout structure
	/// <summary>
	/// Maps the WPARAM parameter of the WM_COMMAND window message to a BitLayout structure.
	/// </summary>
	public class	WM_COMMAND_WPARAM	:  BitLayout
	   {
		public  WM_COMMAND_WPARAM ( )  : base ( 32 )
		   { }

		/// <summary>
		/// Command identifier.
		/// </summary>
		[LOWORD ( )]
		public BitField<ushort>			CommandId ;

		
		/// <summary>
		/// Command origin :0 if the command comes from a menu, 1 for an accelerator key sequence.
		/// <para>
		/// For control notification messages, indicates the notification value. In this case, the LPARAM parameter contains the handle
		/// of the originating control.
		/// </para>
		/// </summary>
		[HIWORD ( )]
		public BitField<int>			CommandOrigin ;
	    }
	# endregion
    }
