/**************************************************************************************************************

    NAME
        WinAPI/Constants/F/FACCEL.cs

    DESCRIPTION
        FACCEL constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region FACCEL_ constants
	/// <summary>
	/// fVirt field values for ACCEL structure.
	/// </summary>
	public enum FACCEL_Constants : byte
	   {
		/// <summary>
		/// Zero-value.
		/// </summary>
		FNONE			=  0x00,

		/// <summary>
		/// The ALT key must be held down when the accelerator key is pressed.
		/// </summary>
		FALT			=  0x10,

		/// <summary>
		/// The CTRL key must be held down when the accelerator key is pressed.
		/// </summary>
		FCONTROL		=  0x08,

		/// <summary>
		/// No top-level menu item is highlighted when the accelerator is used. If this flag is not specified, a top-level menu item will be highlighted, if possible, 
		/// when the accelerator is used. 
		/// <para>
		/// This attribute is obsolete and retained only for backward compatibility with resource files designed for 16-bit Windows. 
		/// </para>
		/// </summary>
		FNOINVERT		=  0x02,

		/// <summary>
		/// The SHIFT key must be held down when the accelerator key is pressed.
		/// </summary>
		FSHIFT			=  0x04,

		/// <summary>
		/// The key member specifies a virtual-key code. If this flag is not specified, key is assumed to specify a character code.
		/// </summary>
		FVIRTKEY		=  1
	    }
	# endregion
    }