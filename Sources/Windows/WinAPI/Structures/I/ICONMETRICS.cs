/**************************************************************************************************************

    NAME
        WinAPI/Structures/ICONMETRICS.cs

    DESCRIPTION
        ICONMETRICS structure, used with the SPI_GETICONMETRICS/SPI_SETICONMETRICS actions of the
	SystemParametersInfo() function.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct ICONMETRICS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// The horizontal space, in pixels, for each arranged icon. 
		/// </summary>
		public  int			iHorzSpacing ;

		/// <summary>
		/// The vertical space, in pixels, for each arranged icon. 
		/// </summary>
		public  int			iVertSpacing ;

		/// <summary>
		/// If this member is nonzero, icon titles wrap to a new line. If this member is zero, titles do not wrap. 
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool )]
		public  Boolean			iTitleWrap ;

		/// <summary>
		/// The font used for icon titles.
		/// </summary>
		public LOGFONT			lfFont ;			


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized ICONMETRICS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized ICONMETRICS structure.</returns>
		public static implicit operator  ICONMETRICS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			ICONMETRICS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( ICONMETRICS ) ) ;
			Result. iHorzSpacing	=  0 ;
			Result. iVertSpacing	=  0 ;
			Result. iTitleWrap	=  false ;
			Result. lfFont		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }
