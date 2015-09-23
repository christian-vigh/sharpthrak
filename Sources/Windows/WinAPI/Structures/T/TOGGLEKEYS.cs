/**************************************************************************************************************

    NAME
        WinAPI/Structures/TOGGLEKEYS.cs

    DESCRIPTION
        ACCESSTIMEOUT structure, used with the SPI_GETTOGGLEKEYS/SPI_SETTOGGLEKEYS actions of the
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
	/// <remarks>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct TOGGLEKEYS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// A set of bit-flags that specify properties of the StickyKeys feature.
		/// </summary>
		public  TKF_Constants		dwFlags ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized TOGGLEKEYS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized TOGGLEKEYS structure.</returns>
		public static implicit operator  TOGGLEKEYS ( Thrak. WinAPI. Structures. Structure  value )		   {
			TOGGLEKEYS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( TOGGLEKEYS ) ) ;
			Result. dwFlags		=  TKF_Constants. TKF_NONE ;

			return ( Result ) ;
		    }
	    }
    }
