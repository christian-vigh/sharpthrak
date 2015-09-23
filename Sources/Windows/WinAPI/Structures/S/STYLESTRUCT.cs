/**************************************************************************************************************

    NAME
        WinAPI/Structure/S/STYLESTRUCT.cs

    DESCRIPTION
        STYLESTRUCT structure.

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
	/// Contains the styles for a window. 
	/// </summary>
	/// <remarks>
	/// The styles in styleOld and styleNew can be either the window styles (WS_*) or the extended window styles (WS_EX_*), depending on the wParam of the message 
	/// that includes STYLESTRUCT.
	/// <para>
	/// The styleOld and styleNew members indicate the styles through their bit pattern. Note that several styles are equal to zero; to detect these styles, 
	/// test for the negation of their inverse style. For example, to see if WS_EX_LEFT is set, you test for ~WS_EX_RIGHT.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  STYLESTRUCT<T>
	   {
		/// <summary>
		/// The previous styles for a window
		/// </summary>
		T		styleOld ;

		/// <summary>
		/// The new styles for a window. 
		/// </summary>
		T		styleNew ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized STYLESTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized STYLESTRUCT structure.</returns>
		public static implicit operator  STYLESTRUCT<T> ( Thrak. WinAPI. Structures. Structure  value )
		   {
			STYLESTRUCT<T>		Result ;

			Result. styleOld		=  default ( T ) ;
			Result. styleNew		=  default ( T ) ;

			return ( Result ) ;
		    }
	    }
    }