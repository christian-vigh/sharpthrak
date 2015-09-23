/**************************************************************************************************************

    NAME
        WinAPI/Structure/P/POINTS.cs

    DESCRIPTION
        POINTS structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
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
	/// Point coordinates used for gesture handling.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  POINTS
	   {
		/// <summary>
		/// x-coordinate of the gesture, relative to the origin of the screen.
		/// </summary>
		public short		x ;

		/// <summary>
		/// y-coordinate of the gesture, relative to the origin of the screen.
		/// </summary>
		public short		y ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized POINTS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized POINTS structure.</returns>
		public static implicit operator  POINTS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			POINTS		Result ;

			Result. x	=  0 ;
			Result. y	=  0 ;

			return ( Result ) ;
		    }


		/// <summary>
		/// Converts a DWORD value into a POINTS structure.
		/// <para>
		/// This operator is used to implicitly convert DWORD values from the GetMessagePos() or GetCursorPos(), for example, into a POINTS structure.
		/// </para>
		/// </summary>
		/// <param name="value">DWORD value to be converted.</param>
		/// <returns>The POINTS structure containing the last cursor coordinates when the last message was sent.</returns>
		public static implicit operator  POINTS ( uint  value )
		   {
			POINTS		Result		=  Macros. MAKEPOINTS ( value ) ;

			return ( Result ) ;
		    }
	    }
    }