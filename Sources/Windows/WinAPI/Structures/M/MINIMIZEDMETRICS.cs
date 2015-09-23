/**************************************************************************************************************

    NAME
        WinAPI/Structures/MINIMIZEDMETRICS.cs

    DESCRIPTION
        ICONMETRICS structure, used with the SPI_GETMINIMIZEDMETRICS/SPI_SETMINIMIZEDMETRICS actions of the
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
	public struct MINIMIZEDMETRICS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// The width of minimized windows, in pixels.
		/// </summary>
		public  int			iWidth ;

		/// <summary>
		/// The horizontal space between arranged minimized windows, in pixels.
		/// </summary>
		public  int			iHorzGap ;

		/// <summary>
		/// The vertical space between arranged minimized windows, in pixels.
		/// </summary>
		public  int			iVertGap ;

		/// <summary>
		/// The starting position and direction used when arranging minimized windows. 
		/// </summary>
		public  ARW_Constants		iArrange ; 


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MINIMIZEDMETRICS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MINIMIZEDMETRICS structure.</returns>
		public static implicit operator  MINIMIZEDMETRICS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MINIMIZEDMETRICS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( MINIMIZEDMETRICS ) ) ;
			Result. iWidth		=  0 ;
			Result. iHorzGap	=  0 ;
			Result. iVertGap	=  0 ;
			Result. iArrange	=  ARW_Constants. ARW_DEFAULT ;

			return ( Result ) ;
		    }
	    }
    }
