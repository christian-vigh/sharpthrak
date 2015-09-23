/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {


	# region MKF_ constants used for mouse key flags
	/// <summary>
	/// The starting position and direction used when arranging minimized windows. 
	/// </summary>
	public enum MKF_Constants		: uint
	   {
		/// <summary>
		/// Uninitialized value for MKF flags.
		/// </summary>
		MKF_NONE			=  0x00000000,

		/// <summary>
		/// If this flag is set, the MouseKeys feature is available.
		/// </summary>
		MKF_AVAILABLE       		=  0x00000002,

		/// <summary>
		/// Windows 95/98, Windows 2000: A confirmation dialog box appears when the MouseKeys feature is activated by using the hot key.
		/// </summary>
		MKF_CONFIRMHOTKEY   		=  0x00000008,

		/// <summary>
		/// If this flag is set, the user can turn the MouseKeys feature on and off by using the hot key, which is LEFT ALT+LEFT SHIFT+NUM LOCK.
		/// </summary>
		MKF_HOTKEYACTIVE    		=  0x00000004,

		/// <summary>
		/// If this flag is set, the system plays a siren sound when the user turns the MouseKeys feature on or off by using the hot key.
		/// </summary>
		MKF_HOTKEYSOUND     		=  0x00000010,

		/// <summary>
		/// Windows 95/98, Windows 2000: A visual indicator is displayed when the MouseKeys feature is on.
		/// </summary>
		MKF_INDICATOR       		=  0x00000020,

		/// <summary>
		/// Windows 95/98, Windows 2000: The left button is in the "down" state.
		/// </summary>
		MKF_LEFTBUTTONDOWN  		=  0x01000000,

		/// <summary>
		/// Windows 95/98, Windows 2000: The user has selected the left button for mouse-button actions.
		/// </summary>
		MKF_LEFTBUTTONSEL   		=  0x10000000,

		/// <summary>
		/// Windows 95/98, Windows 2000: The CTRL key increases cursor speed by the value specified by the iCtrlSpeed member, and the SHIFT key 
		/// causes the cursor to delay briefly after moving a single pixel, allowing fine positioning of the cursor. 
		/// <para>
		/// If this value is not specified, the CTRL and SHIFT keys are ignored while the user moves the mouse cursor using the arrow keys.
		/// </para>
		/// </summary>
		MKF_MODIFIERS       		=  0x00000040,

		/// <summary>
		/// If this flag is set, the MouseKeys feature is on.
		/// </summary>
		MKF_MOUSEKEYSON     		=  0x00000001,

		/// <summary>
		/// Windows 95/98, Windows 2000: The system is processing numeric keypad input as mouse commands.
		/// </summary>
		MKF_MOUSEMODE       		=  0x80000000,

		/// <summary>
		/// Windows 95/98, Windows 2000: The numeric keypad moves the mouse when the NUM LOCK key is on. 
		/// <para>
		/// If this flag is not specified, the numeric keypad moves the mouse cursor when the NUM LOCK key is off.
		/// </para>
		/// </summary>
		MKF_REPLACENUMBERS  		=  0x00000080,

		/// <summary>
		/// Windows 95/98, Windows 2000: The right button is in the "down" state.
		/// </summary>
		MKF_RIGHTBUTTONDOWN 		=  0x02000000,

		/// <summary>
		/// Windows 95/98, Windows 2000: The user has selected the right button for mouse-button actions.
		/// </summary>
		MKF_RIGHTBUTTONSEL  		=  0x20000000

	    }
	# endregion
    }
