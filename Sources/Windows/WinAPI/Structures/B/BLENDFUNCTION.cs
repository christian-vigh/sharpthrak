/**************************************************************************************************************

    NAME
        WinAPI/Structure/B/BLENDFUNCTION.cs

    DESCRIPTION
        BLENDFUNCTION structure.

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
	/// The BLENDFUNCTION structure controls blending by specifying the blending functions for source and destination bitmaps.
	/// </summary>
	/// <remarks>
	/// When the AlphaFormat member is AC_SRC_ALPHA, the source bitmap must be 32 bpp. If it is not, the AlphaBlend function will fail.
	/// <br/>
	/// <para>
	/// When the BlendOp member is AC_SRC_OVER, the source bitmap is placed over the destination bitmap based on the alpha values of the source pixels.
	/// </para>
	/// <br/>
	/// <para>
	/// If the source bitmap has no per-pixel alpha value (that is, AC_SRC_ALPHA is not set), the SourceConstantAlpha value determines the blend of the source 
	/// and destination bitmaps, as shown in the following table. Note that SCA is used for SourceConstantAlpha here. Also, SCA is divided by 255 because it has a value 
	/// that ranges from 0 to 255.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  BLENDFUNCTION
	   {
		/// <summary>
		/// The source blend operation. 
		/// Currently, the only source and destination blend operation that has been defined is AC_SRC_OVER.
		/// </summary>
		public AC_SRC_Constants		BlendOp ;

		/// <summary>
		/// Must be zero.
		/// </summary>
		public byte			BlendFlags ;

		/// <summary>
		/// Specifies an alpha transparency value to be used on the entire source bitmap. The SourceConstantAlpha value is combined with any per-pixel alpha values 
		/// in the source bitmap. If you set SourceConstantAlpha to 0, it is assumed that your image is transparent. Set the SourceConstantAlpha value to 255 (opaque) 
		/// when you only want to use per-pixel alpha values.
		/// </summary>
		public byte			SourceConstantAlpha ;

		/// <summary>
		/// This member controls the way the source and destination bitmaps are interpreted. 
		/// </summary>
		public AC_SRC_Constants		AlphaFormat ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized BLENDFUNCTION structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized BLENDFUNCTION structure.</returns>
		public static implicit operator  BLENDFUNCTION ( Thrak. WinAPI. Structures. Structure  value )
		   {
			BLENDFUNCTION		Result ;

			Result. AlphaFormat		=  AC_SRC_Constants. AC_SRC_ALPHA ;
			Result. BlendFlags		=  0 ;
			Result. BlendOp			=  AC_SRC_Constants. AC_SRC_OVER ;
			Result. SourceConstantAlpha	=  0 ;

			return ( Result ) ;
		    }
	    }
    }