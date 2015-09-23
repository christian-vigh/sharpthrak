/**************************************************************************************************************

    NAME
        WinAPI/Structures/I/INPUT.cs

    DESCRIPTION
        INPUT structure.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
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
	/// </summary>
 	[StructLayout ( LayoutKind. Explicit ) ]
	public struct  INPUT
	   {
		/// <summary>
		/// The type of the input event. This member can be one of the INPUT_Constants values.
		/// </summary>
		[FieldOffset (0)]
		public INPUT_Constants		type ;

		/// <summary>
		/// The information about a simulated mouse event. 
		/// </summary>
		[FieldOffset (4)]
		public MOUSEINPUT		mi ;

		/// <summary>
		/// The information about a simulated keyboard event. 
		/// </summary>
		[FieldOffset (4)]
		public KEYBDINPUT		ki ;

		/// <summary>
		/// The information about a simulated hardware event. 
		/// </summary>
		[FieldOffset (4)]
		public HARDWAREINPUT		hi ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized INPUT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized INPUT structure.</returns>
		public static implicit operator  INPUT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			INPUT		Result ;

			Result. type		=  INPUT_Constants. INPUT_NONE ;
			Result. hi		=  Structure. Empty ;
			Result. ki		=  Structure. Empty ;
			Result. mi		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }