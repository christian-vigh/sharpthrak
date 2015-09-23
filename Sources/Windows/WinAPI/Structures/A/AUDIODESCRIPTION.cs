/**************************************************************************************************************

    NAME
        WinAPI/Structures/AUDIODESCRIPTION.cs

    DESCRIPTION
        ANIMATIONINFO structure, used with the SPI_GETAUDIODESCRIPTION/SPI_SETAUDIODESCRIPTION actions of the
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
	/// Contains information associated with audio descriptions. 
	/// <para>
	/// This structure is used with the SystemParametersInfo function when the SPI_GETAUDIODESCRIPTION or SPI_SETAUDIODESCRIPTION action value is specified.
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct AUDIODESCRIPTION
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// If this member is TRUE, audio descriptions are enabled; Otherwise, this member is FALSE.
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool )]
		public Boolean			Enabled ;

		/// <summary>
		/// The locale identifier (LCID) of the language for the audio description
		/// </summary>
		public UInt32			Locale ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized AUDIODESCRIPTION structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized AUDIODESCRIPTION structure.</returns>
		public static implicit operator  AUDIODESCRIPTION ( Thrak. WinAPI. Structures. Structure  value )
		   {
			AUDIODESCRIPTION		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( AUDIODESCRIPTION ) ) ;
			Result. Enabled		=  false ;
			Result. Locale		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
