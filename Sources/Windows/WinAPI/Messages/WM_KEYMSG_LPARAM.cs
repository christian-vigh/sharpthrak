/**************************************************************************************************************

    NAME
        WM_KEY.cs

    DESCRIPTION
        WM_KEYxxx message helper classes.

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
	# region WM_KEYMSG_LPARAM layout structure
	/// <summary>
	/// Maps the LPARAM parameter of the WM_KEYxxx & WM_CHAR window messages to a BitLayout structure.
	/// </summary>
	public class	WM_KEYMSG_LPARAM	:  BitLayout
	   {
		public  WM_KEYMSG_LPARAM ( )  : base ( 32 )
		   { }


		/// <summary>
		/// The repeat count for the current message. The value is the number of times the keystroke is autorepeated as a result of the user holding down the key. 
		/// <para>
		/// If the keystroke is held long enough, multiple messages are sent. However, the repeat count is not cumulative. 
		/// </para>
		/// </summary>
		[Bits ( 0, 15 )]
		public BitField<int>			RepeatCount ;	
		
		
		/// <summary>
		/// The scan code. The value depends on the OEM.
		/// </summary>
		[Bits ( 16, 23 )]
		public BitField<int>			ScanCode ;	


		/// <summary>
		/// Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. 
		/// <para>
		/// The value is 1 if it is an extended key; otherwise, it is 0.
		/// </para>
		/// </summary>
		[Bit ( 24 )]
		public BitField<Boolean>		ExtendedKey ;

		/// <summary>
		/// The context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.
		/// </summary>
		[Bit ( 29 )]
		public BitField<Boolean>		AltKeyPressed ;


		/// <summary>
		/// The previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.
		/// </summary>
		[Bit ( 30 )]
		public BitField<Boolean>		WasKeyUp ;


		/// <summary>
		/// The transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.
		/// </summary>
		[Bit ( 31 )]
		public BitField<Boolean>		IsKeyBeingReleased ;
	    }
	# endregion
    }
