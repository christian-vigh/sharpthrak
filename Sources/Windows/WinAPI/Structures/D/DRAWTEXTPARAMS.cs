/**************************************************************************************************************

    NAME
        WinAPI/Structures/D/DRAWTEXTPARAMS.cs

    DESCRIPTION
        DRAWTEXTPARAMS structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
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
	/// The DRAWTEXTPARAMS structure contains extended formatting options for the DrawTextEx function.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  DRAWTEXTPARAMS
	   {
		/// <summary>
		/// The structure size, in bytes.
		/// </summary>
		public uint		cbSize ;

		/// <summary>
		/// The size of each tab stop, in units equal to the average character width.
		/// </summary>
		public int		iTabLength ;

		/// <summary>
		/// The left margin, in units equal to the average character width.
		/// </summary>
		public int		iLeftMargin ;

		/// <summary>
		/// The right margin, in units equal to the average character width.
		/// </summary>
		public int		iRightMargin ;

		/// <summary>
		/// Receives the number of characters processed by DrawTextEx, including white-space characters. 
		/// The number can be the length of the string or the index of the first line that falls below the drawing area. 
		/// Note that DrawTextEx always processes the entire string if the DT_NOCLIP formatting flag is specified.
		/// </summary>
		public uint		uiLengthDrawn ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized DRAWTEXTPARAMS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized DRAWTEXTPARAMS structure.</returns>
		public static implicit operator  DRAWTEXTPARAMS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			DRAWTEXTPARAMS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( DRAWTEXTPARAMS ) ) ;
			Result. iLeftMargin	=  0 ;
			Result. iRightMargin	=  0 ;
			Result. iTabLength	=  0 ;
			Result. uiLengthDrawn	=  0 ;

			return ( Result ) ;
		    }
	    }
    }