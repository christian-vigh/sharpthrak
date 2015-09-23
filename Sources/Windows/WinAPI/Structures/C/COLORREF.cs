/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/COLORREF.cs

    DESCRIPTION
        COLORREF structure.

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
	/// Structure describing a RGB color.
	/// </summary>
 	[StructLayout ( LayoutKind. Explicit, Size = 4 )]
	public struct  COLORREF
	   {
		# region Data members
		/// <summary>
		/// Red component of the RGB value.
		/// </summary>
		[FieldOffset (0)] public byte		R ;

		/// <summary>
		/// Green component of the RGB value.
		/// </summary>
		[FieldOffset (1)] public byte		G ;

		/// <summary>
		/// Blue component of the RGB value.
		/// </summary>
		[FieldOffset (2)] public byte		B ;

		/// <summary>
		/// Whole RGB value.
		/// </summary>
		[FieldOffset (0)] private uint		RGB ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a COLORREF object with an unsigned integer value.
		/// </summary>
		/// <param name="value">RGV value.</param>
		public  COLORREF ( uint  value )
		   {
			this. R		=  0 ;
			this. G		=  0 ;
			this. B		=  0 ;
			this. RGB	=  value ;
		    }


		/// <summary>
		/// Builds a COLORREF object with an integer value.
		/// </summary>
		/// <param name="value">RGV value.</param>
		public  COLORREF ( int  value )
		   {
			this. R		=  0 ;
			this. G		=  0 ;
			this. B		=  0 ;
			this. RGB	=  ( uint ) value ;
		    }

	
		/// <summary>
		/// Builds a COLORREF object with individual color component values.
		/// </summary>
		/// <param name="r">Red component value.</param>
		/// <param name="g">Green component value.</param>
		/// <param name="b">Blue component value.</param>
		public COLORREF ( byte  r, byte  g, byte  b )
		   {
			this. RGB		=  0 ;
			this. R			=  r ;
			this. G			=  g ;
			this. B			=  b ;
		    }


		/// <summary>
		/// Builds a COLORREF object with individual color components specified as a byte array of three elements.
		/// </summary>
		/// <param name="cs">Byte array specifying the red, green and blue color components, respectively.</param>
		public COLORREF  ( byte []  cs )
		   {
			if  ( cs. Length  !=  3 )
				throw new ArgumentException ( Resources. Localization. Classes. WinAPI. InvalidRGBByteArray ) ;

			this. RGB		=  0 ;
			this. R			=  cs [0] ;
			this. G			=  cs [1] ;
			this. B			=  cs [2] ;
		    }


		/// <summary>
		/// Builds a COLORREF structure from a System.Drawing.Color object.
		/// </summary>
		/// <param name="color">Color object.</param>
		public COLORREF  ( System. Drawing. Color  color )
		   {
			this. RGB		=  0 ;
			this. R			=  color. R ;
			this. G			=  color. G ;
			this. B			=  color. B ;
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized COLORREF structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized COLORREF structure.</returns>
		public static implicit operator  COLORREF ( Thrak. WinAPI. Structures. Structure  value )
		   {
			COLORREF		Result ;

			Result. RGB		=  0 ;
			Result. R		=  0 ;
			Result. G		=  0 ;
			Result. B		=  0 ;

			return ( Result ) ;
		    }


		/// <summary>
		/// Implicitly converts an unsigned integer value into a COLORREF structure.
		/// </summary>
		/// <param name="value">RGB value.</param>
		/// <returns>A COLORREF structure.</returns>
		public static implicit operator  COLORREF ( uint  value )
		   { return ( new COLORREF ( value ) ) ; }


		/// <summary>
		/// Implicitly converts a signed value into a COLORREF structure.
		/// </summary>
		/// <param name="value">RGB value.</param>
		/// <returns>A COLORREF structure.</returns>
		public static implicit operator  COLORREF ( int  value )
		   { return ( new COLORREF ( ( uint ) value ) ) ; }


		/// <summary>
		/// Implicitly converts a 3-bytes array to a COLORREF structure.
		/// </summary>
		/// <param name="values">3-bytes array containing the RGB values.</param>
		/// <returns>A COLORREF structure.</returns>
		public static implicit operator  COLORREF ( byte []  values )
		   { return ( new  COLORREF ( values ) ) ; }


		/// <summary>
		/// Converts a COLORREF structure to an unsigned integer value.
		/// </summary>
		/// <param name="value">COLORREF value.</param>
		/// <returns>The RGB value as an unsigned integer.</returns>
		public static implicit operator uint ( COLORREF  value )
		   { return ( value. RGB ) ; }


		/// <summary>
		/// Converts a COLORREF structure to an integer value.
		/// </summary>
		/// <param name="value">COLORREF value.</param>
		/// <returns>The RGB value as an unsigned integer.</returns>
		public static implicit operator int ( COLORREF  value )
		   { return ( ( int ) value. RGB ) ; }


		/// <summary>
		/// Converts a System.Drawing.Color object into a COLORREF structure.
		/// </summary>
		/// <param name="color">Color object.</param>
		/// <returns>A COLORREF structure.</returns>
		public static implicit operator COLORREF ( System. Drawing. Color  color )
		   { return ( new  COLORREF ( color ) ) ; }

		
		/// <summary>
		/// Converts a COLORREF structure to a System.Drawing.Color object.
		/// </summary>
		/// <param name="value">COLORREF structure.</param>
		/// <returns>A Color object.</returns>
		public static implicit operator System. Drawing. Color ( COLORREF  value )
		   {  return ( System. Drawing. Color. FromArgb ( value. R, value. G, value. B ) ) ; }
		# endregion


		# region Other functions
		/// <summary>
		/// Provides a string representation of the RGB color value.
		/// </summary>
		/// <returns></returns>
		public override String ToString ( )
		  {
			return ( "#" + String. Format ( "{0:X2}", this. R ) +
				       String. Format ( "{0:X2}", this. G ) + 
				       String. Format ( "{0:X2}", this. B ) ) ;
		   }
		# endregion
	    }
    }