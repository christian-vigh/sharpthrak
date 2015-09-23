/**************************************************************************************************************

    NAME
        WinAPI/Structures/MINIMIZEDMETRICS.cs

    DESCRIPTION
        NONCLIENTMETRICS structure, used with the SPI_GETNONCLIENTMETRICS/SPI_SETNONCLIENTMETRICS actions of the
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
	/// Contains the scalable metrics associated with the nonclient area of a nonminimized window. 
	/// <para>
	/// This structure is used by the SPI_GETNONCLIENTMETRICS and SPI_SETNONCLIENTMETRICS actions of the SystemParametersInfo function.
	/// </para>
	/// </summary>
	/// <remarks>
	/// If the iPaddedBorderWidth member of the NONCLIENTMETRICS structure is present, this structure is 4 bytes larger than for an application 
	/// that is compiled with _WIN32_WINNT less than or equal to 0x0502.
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct NONCLIENTMETRICS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// The thickness of the sizing border, in pixels. The default is 1 pixel.
		/// </summary>
		public int			iBorderWidth ;

		/// <summary>
		/// The width of a standard vertical scroll bar, in pixels.
		/// </summary>
		public int			iScrollWidth ;

		/// <summary>
		/// The height of a standard horizontal scroll bar, in pixels.
		/// </summary>
		public int			iScrollHeight ;

		/// <summary>
		/// The width of caption buttons, in pixels.
		/// </summary>
		public int			iCaptionWidth ;

		/// <summary>
		/// The height of caption buttons, in pixels.
		/// </summary>
		public int			iCaptionHeight ;

		/// <summary>
		/// A LOGFONT structure that contains information about the caption font.
		/// </summary>
		public LOGFONT			lfCaptionFont ;

		/// <summary>
		/// The width of small caption buttons, in pixels.
		/// </summary>
		public int			iSmCaptionWidth ;

		/// <summary>
		/// The height of small captions, in pixels.
		/// </summary>
		public int			iSmCaptionHeight ;

		/// <summary>
		/// A LOGFONT structure that contains information about the small caption font.
		/// </summary>
		public LOGFONT			lfSmCaptionFont ;

		/// <summary>
		/// The width of menu-bar buttons, in pixels.
		/// </summary>
		public int			iMenuWidth ;

		/// <summary>
		/// The height of a menu bar, in pixels.
		/// </summary>
		public int			iMenuHeight ;

		/// <summary>
		/// A LOGFONT structure that contains information about the font used in menu bars.
		/// </summary>
		public LOGFONT			lfMenuFont ;

		/// <summary>
		/// A LOGFONT structure that contains information about the font used in status bars and tooltips.
		/// </summary>
		public LOGFONT			lfStatusFont ;

		/// <summary>
		/// A LOGFONT structure that contains information about the font used in message boxes.
		/// </summary>
		public LOGFONT			lfMessageFont ;

		/// <summary>
		/// The thickness of the padded border, in pixels. The default value is 4 pixels. 
		/// <para>
		/// The iPaddedBorderWidth and iBorderWidth members are combined for both resizable and nonresizable windows in the Windows Aero desktop experience. 
		/// </para>
		/// <para>
		/// To compile an application that uses this member, define _WIN32_WINNT as 0x0600 or later.
		/// </para>
		/// </summary>
		//public int			iPaddedBorderWidth ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized NONCLIENTMETRICS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized NONCLIENTMETRICS structure.</returns>
		public static implicit operator  NONCLIENTMETRICS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			NONCLIENTMETRICS		Result ;

			Result. cbSize			=  Macros. GETSTRUCTSIZE ( typeof ( NONCLIENTMETRICS ) ) ;
			Result. iBorderWidth		=  0 ;
			Result. iCaptionHeight		=  0 ;
			Result. iCaptionWidth		=  0 ;
			Result. iMenuHeight		=  0 ;
			Result. iMenuWidth		=  0 ;
			//Result. iPaddedBorderWidth	=  0 ;
			Result. iScrollHeight		=  0 ;
			Result. iScrollWidth		=  0 ;
			Result. iSmCaptionHeight	=  0 ;
			Result. iSmCaptionWidth		=  0 ;
			Result. lfCaptionFont		=  Structure. Empty ;
			Result. lfMenuFont		=  Structure. Empty ;
			Result. lfMessageFont		=  Structure. Empty ;
			Result. lfSmCaptionFont		=  Structure. Empty ;
			Result. lfStatusFont		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }
