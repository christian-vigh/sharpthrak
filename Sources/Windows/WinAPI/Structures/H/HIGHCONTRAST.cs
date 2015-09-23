/**************************************************************************************************************

    NAME
        WinAPI/Structures/HIGHCONTRAST.cs

    DESCRIPTION
        HIGHCONTRAST structure, used with the SPI_GETHIGHCONTRAST/SPI_SETHIGHCONTRAST actions of the
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
	/// Contains information about the high contrast accessibility feature. 
	/// <para>
	/// This feature sets the appearance scheme of the user interface for maximum visibility for a visually-impaired user, 
	/// and advises applications to comply with this appearance scheme. 
	/// </para>
	/// </summary>
	/// <remarks>
	/// An application uses this structure when calling the SystemParametersInfo function with the SPI_GETHIGHCONTRAST or SPI_SETHIGHCONTRAST value. 
	/// <para>
	/// When using SPI_GETHIGHCONTRAST, an application must specify the cbSize member of the HIGHCONTRAST structure; the SystemParametersInfo function 
	/// fills the remaining members. 
	/// </para>
	/// <para>
	/// An application must specify all structure members when using the SPI_SETHIGHCONTRAST value.
	/// </para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct HIGHCONTRAST
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// High-contrast flags.
		/// </summary>
		public  HCF_Constants		dwFlags ;

		/// <summary>
		/// Points to a string that contains the name of the color scheme that will be set to the default scheme.
		/// </summary>
		public  IntPtr			__lpszDefaultScheme ;


		/// <summary>
		/// Color scheme name.
		/// </summary>
		public String  lpszDefaultScheme 
		   {
			get { return ( Marshal. PtrToStringAnsi ( __lpszDefaultScheme ) ) ; }
			set { __lpszDefaultScheme  =  Marshal. StringToHGlobalAnsi ( value ) ; }
		    }


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized HIGHCONTRAST structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized HIGHCONTRAST structure.</returns>
		public static implicit operator  HIGHCONTRAST ( Thrak. WinAPI. Structures. Structure  value )
		   {
			HIGHCONTRAST		Result ;

			Result. cbSize			=  Macros. GETSTRUCTSIZE ( typeof ( HIGHCONTRAST ) ) ;
			Result. dwFlags			=  HCF_Constants. HCF_NONE ;
			Result. __lpszDefaultScheme	=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }
