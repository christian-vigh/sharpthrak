/**************************************************************************************************************

    NAME
        WinAPI/Structures/LOGFONT.cs

    DESCRIPTION
        Logical fonct structure.

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
	/// The LOGFONT structure defines the attributes of a font.
	/// </summary>
	/// <remarks>
	/// The following situations do not support ClearType antialiasing :
	/// <para>• Text is rendered on a printer.</para>
	/// <para>• Display set for 256 colors or less.</para>
	/// <para>• Text is rendered to a terminal server client.</para>
	/// <para>• The font is not a TrueType font or an OpenType font with TrueType outlines. For example, the following do not support ClearType antialiasing : 
	///   Type 1 fonts, Postscript OpenType fonts without TrueType outlines, bitmap fonts, vector fonts, and device fonts.</para>
	/// <para>• The font has tuned embedded bitmaps, for any font sizes that contain the embedded bitmaps. For example, this occurs commonly in East Asian fonts.</para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential, CharSet = CharSet. Auto )]
        public struct  LOGFONT
           {
		/// <summary>
		/// The height, in logical units, of the font's character cell or character. 
		/// <para>
		/// The character height value (also known as the em height) is the character cell height value minus the internal-leading value. 
		/// </para>
		/// <para>
		/// The font mapper interprets the value specified in lfHeight in the following manner :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Value         Meaning</para>
		/// <para>-----         -------</para>
		/// <para>Positive      The font mapper transforms this value into device units and matches it against the cell height of the available fonts.</para>
		/// <para>Zero          The font mapper uses a default height value when it searches for a match.</para>
		/// <para>Negative      The font mapper transforms this value into device units and matches its absolute value against the character height of the available fonts.</para>
		/// </code>
		/// <br/>
		/// <para>
		/// For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size.
		/// </para>
		/// <para>
		/// This mapping occurs when the font is used for the first time.
		/// </para>
		/// <para>
		/// For the MM_TEXT mapping mode, you can use the following formula to specify a height for a font with a specified point size:
		/// </para>
		/// <br/>
		///	lfHeight = -MulDiv(PointSize, GetDeviceCaps(hDC, LOGPIXELSY), 72);
		/// </summary>
		public int			lfHeight ;

		/// <summary>
		/// The average width, in logical units, of characters in the font. 
		/// <para>
		/// If lfWidth is zero, the aspect ratio of the device is matched against the digitization aspect ratio of the available fonts 
		/// to find the closest match, determined by the absolute value of the difference.
		/// </para>
		/// </summary>
		public int			lfWidth	;

		/// <summary>
		/// The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. 
		/// The escapement vector is parallel to the base line of a row of text.
		/// <para>
		/// When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle 
		/// of the string's characters.
		/// </para>
		/// <para>
		/// When the graphics mode is set to GM_COMPATIBLE, lfEscapement specifies both the escapement and orientation. 
		/// You should set lfEscapement and lfOrientation to the same value.
		/// </para>
		/// </summary>
		public int			lfEscapement ;

		/// <summary>
		/// The angle, in tenths of degrees, between each character's base line and the x-axis of the device.
		/// </summary>
		public int			lfOrientation ;

		/// <summary>
		/// The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is used.
		/// </summary>
		public FW_Constants		lfWeight ;

		/// <summary>
		/// An italic font if set to TRUE.
		/// </summary>
		public byte			lfItalic ;

		/// <summary>
		/// An underlined font if set to TRUE.
		/// </summary>
		public byte			lfUnderline ;

		/// <summary>
		/// A strikeout font if set to TRUE.
		/// </summary>
		public byte			lfStrikeOut ;

		/// <summary>
		/// The character set. See the CHARSET_Constants enumeration.
		///  <br/>
		///  <para>
		/// The OEM_CHARSET value specifies a character set that is operating-system dependent.
		///  </para>
		///  <para>
		/// DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is set as ANSI_CHARSET.
		///  </para>
		///  <para>
		/// Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, 
		/// it should not attempt to translate or interpret strings that are rendered with that font.
		///  </para>
		///  <para>
		/// This parameter is important in the font mapping process. To ensure consistent results, specify a specific character set. 
		/// If you specify a typeface name in the lfFaceName member, make sure that the lfCharSet value matches the character set of the typeface specified in lfFaceName.
		///  </para>
		/// </summary>
		public FONTCHARSET_Constants	lfCharSet ;

		/// <summary>
		/// The output precision. 
		/// <para>
		/// The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, pitch, and font type.
		/// </para>
		/// <para>
		/// Applications can use the OUT_DEVICE_PRECIS, OUT_RASTER_PRECIS, OUT_TT_PRECIS, and OUT_PS_ONLY_PRECIS values to control how the font mapper chooses a font 
		/// when the operating system contains more than one font with a specified name. 
		/// </para>
		/// <para>
		/// For example, if an operating system contains a font named Symbol in raster and TrueType form, specifying OUT_TT_PRECIS forces the font mapper to choose 
		/// the TrueType version. 
		/// </para>
		/// <para>
		/// Specifying OUT_TT_ONLY_PRECIS forces the font mapper to choose a TrueType font, even if it must substitute a TrueType font of another name.
		/// </para>
		/// </summary>
		public FONTPRECIS_Constants	lfOutPrecision ;

		/// <summary>
		/// The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region.
		/// <para>
		/// For more information about the orientation of coordinate systems, see the description of the nOrientation parameter.
		/// </para>
		/// </summary>
		public FONTCLIP_Constants	lfClipPrecision ;

		/// <summary>
		/// The output quality. The output quality defines how carefully the graphics device interface (GDI) must attempt to match 
		/// the logical-font attributes to those of an actual physical font. 
		/// <para>
		/// If neither ANTIALIASED_QUALITY nor NONANTIALIASED_QUALITY is selected, the font is antialiased only if the user chooses smooth screen fonts in Control Panel.
		/// </para>
		/// </summary>
		public FONTQUALITY_Constants	lfQuality ;

		/// <summary>
		/// The pitch and family of the font. The two low-order bits specify the pitch of the font (DEFAULT_PITCH, FIXED_PITCH, VARIABLE_PITCH).
		/// <para>
		/// Bits 4 through 7 of the member specify the font family and can be one of the following values (FF_ values).
		/// </para>
		/// <para>
		/// The proper value can be obtained by using the Boolean OR operator to join one pitch constant with one family constant.
		/// </para>
		/// <para>
		/// Font families describe the look of a font in a general way. They are intended for specifying fonts when the exact typeface desired is not available. 
		/// </para>
		/// </summary>
		public FONTPITCH_Constants	lfPitchAndFamily ;

		/// <summary>
		/// A null-terminated string that specifies the typeface name of the font.
		/// <para>
		/// The length of this string must not exceed 32 TCHAR values, including the terminating NULL. 
		/// </para>
		/// <para>
		/// The EnumFontFamiliesEx function can be used to enumerate the typeface names of all currently available fonts. 
		/// </para>
		/// <para>
		/// If lfFaceName is an empty string, GDI uses the first font that matches the other specified attributes.
		/// </para>
		/// </summary>
		[MarshalAs(UnmanagedType. ByValTStr, SizeConst = 32)]
		public string			lfFaceName ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized LOGFONT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized LOGFONT structure.</returns>
		public static implicit operator  LOGFONT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			LOGFONT			lf ;


			lf.lfCharSet		=  FONTCHARSET_Constants. DEFAULT_CHARSET ;
			lf. lfClipPrecision	=  FONTCLIP_Constants. CLIP_DEFAULT_PRECIS ;
			lf. lfEscapement	=  0 ;
			lf. lfFaceName		=  "" ;
			lf. lfHeight		=  0 ;
			lf. lfItalic		=  0 ;
			lf. lfOrientation	=  0 ;
			lf. lfOutPrecision	=  FONTPRECIS_Constants. OUT_DEFAULT_PRECIS ;
			lf. lfPitchAndFamily	=  FONTPITCH_Constants. DEFAULT_PITCH ;
			lf. lfQuality		=  FONTQUALITY_Constants. DEFAULT_QUALITY ;
			lf. lfStrikeOut		=  0 ;
			lf. lfUnderline		=  0 ;
			lf. lfWeight		=  FW_Constants. FW_DONTCARE ;
			lf. lfWidth		=  0 ;

			return ( lf ) ;
		    }
	    }
    }