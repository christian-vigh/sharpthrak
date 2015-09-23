/**************************************************************************************************************

    NAME
        WinAPI/Structures/ANIMATIONINFO.cs

    DESCRIPTION
        ANIMATIONINFO structure, used with the SPI_GETANIMATIONINFO/SPI_SETANIMATIONINFO actions of the
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
	/// Describes the animation effects associated with user actions. 
	/// <para>
	/// This structure is used with the SystemParametersInfo function when the SPI_GETANIMATIONINFO or SPI_SETANIMATIONINFO action value is specified.
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct ANIMATIONINFO
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;
		/// <summary>
		/// If this member is nonzero, minimize and restore animation is enabled; otherwise it is disabled.
		/// </summary>
		public Int32			iMinAnimate ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized ANIMATIONINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized ANIMATIONINFO structure.</returns>
		public static implicit operator  ANIMATIONINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			ANIMATIONINFO		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( ANIMATIONINFO ) ) ;
			Result. iMinAnimate	=  0 ;

			return ( Result ) ;
		    }
	    }
    }
