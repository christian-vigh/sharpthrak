/**************************************************************************************************************

    NAME
        WinAPI/Structures/N/NMHDR.cs

    DESCRIPTION
        NMHDR structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
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
	/// Contains information about a notification message.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  NMHDR
	   {
		/// <summary>
		/// A window handle to the control sending the message.
		/// </summary>
		public IntPtr		hwndFrom ;

		/// <summary>
		/// An identifier of the control sending the message.
		/// </summary>
		public IntPtr		idFrom ;

		/// <summary>
		/// A notification code. This member can be one of the common notification codes (see Notifications under General Control Reference), 
		/// or it can be a control-specific notification code. 
		/// </summary>
		public uint		code ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized NMHDR structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized NMHDR structure.</returns>
		public static implicit operator  NMHDR ( Thrak. WinAPI. Structures. Structure  value )
		   {
			NMHDR		Result ;

			Result. code		=  0 ;
			Result. hwndFrom	=  IntPtr. Zero ;
			Result. idFrom		=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }