/**************************************************************************************************************

    NAME
        WinAPI/Enums/K/KLF.cs

    DESCRIPTION
        KLF constants.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region KLF_ constants
	/// <summary>
	/// KeyboardLayout constants : Specifies how the input locale identifier is to be activated.
	/// </summary>
	public enum KLF_Constants : uint
	   {
		/// <summary>
		/// If this bit is set, the system's circular list of loaded locale identifiers is reordered by moving the locale identifier to the head 
		/// of the list. If this bit is not set, the list is rotated without a change of order.
		/// For example, if a user had an English locale identifier active, as well as having French, German, and Spanish locale identifiers 
		/// loaded (in that order), then activating the German locale identifier with the KLF_REORDER bit set would produce the following order: 
		/// German, English, French, Spanish. Activating the German locale identifier without the KLF_REORDER bit set would produce 
		/// the following order: German, Spanish, English, French.
		/// </summary>
		KLF_REORDER		=  0x00000008,

		/// <summary>
		/// If set but KLF_SHIFTLOCK is not set, the Caps Lock state is turned off by pressing the Caps Lock key again. 
		/// If set and KLF_SHIFTLOCK is also set, the Caps Lock state is turned off by pressing either SHIFT key.
		/// <br/>
		/// <para>
		/// These two methods are mutually exclusive, and the setting persists as part of the User's profile in the registry.
		/// </para>
		/// </summary>
		KLF_RESET		=  0x40000000,

		/// <summary>
		/// Activates the specified locale identifier for the entire process and sends the WM_INPUTLANGCHANGE message to the current thread's focus 
		/// or active window. 
		/// </summary>
		KLF_SETFORPROCESS	=  0x00000100,

		/// <summary>
		/// This is used with KLF_RESET. See KLF_RESET for an explanation.
		/// </summary>
		KLF_SHIFTLOCK		=  0x00010000
	    }
	# endregion
    }