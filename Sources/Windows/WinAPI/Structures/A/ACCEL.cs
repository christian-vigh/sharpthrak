/**************************************************************************************************************

    NAME
        WinAPI/Structure/A/ACCEL.cs

    DESCRIPTION
        ACCEL structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Defines an accelerator key used in an accelerator table. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  ACCEL
	   {
		/// <summary>
		/// The accelerator behavior (virtual keys to be combined with key sequence).
		/// </summary>
		public FACCEL_Constants		fVirt ;

		/// <summary>
		/// The accelerator key. This member can be either a virtual-key code or a character code. 
		/// </summary>
		public ushort			key ;

		/// <summary>
		/// The accelerator identifier. This value is placed in the low-order word of the wParam parameter of the WM_COMMAND or WM_SYSCOMMAND message 
		/// when the accelerator is pressed. 
		/// </summary>
		public ushort			cmd ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized ACCEL structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized ACCEL structure.</returns>
		public static implicit operator  ACCEL ( Thrak. WinAPI. Structures. Structure  value )
		   {
			ACCEL		Result ;

			Result. cmd		=  0 ;
			Result. fVirt		=  FACCEL_Constants. FNONE ;
			Result. key		=  0 ;

			return ( Result ) ;
		    }
	    }
    }