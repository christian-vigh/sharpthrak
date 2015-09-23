/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region CF_ Clipboard format constants
	/// <summary>
	/// Clipboard format constants.
	/// </summary>
	public enum CF_Constants : int
	   {
		/// <summary>
		/// A handle to a bitmap (HBITMAP).
		/// </summary>
		CF_BITMAP		=       2,

		/// <summary>
		/// A memory object containing a BITMAPINFO structure followed by the bitmap bits.
		/// </summary>
		CF_DIB			=       8,

		/// <summary>
		/// A memory object containing a BITMAPV5HEADER structure followed by the bitmap color space information and the bitmap bits.
		/// </summary>
		CF_DIBV5		=      17,

		/// <summary>
		/// Software Arts' Data Interchange Format.
		/// </summary>
		CF_DIF			=       5,

		/// <summary>
		/// Bitmap display format associated with a private format. 
		/// <para>
		/// The hMem parameter must be a handle to data that can be displayed in bitmap format in lieu of the privately formatted data.
		/// </para>
		/// </summary>
		CF_DSPBITMAP		=  0x0082,

		/// <summary>
		/// Enhanced metafile display format associated with a private format. 
		/// <para>
		/// The hMem parameter must be a handle to data that can be displayed in enhanced metafile format in lieu of the privately formatted data.
		/// </para>
		/// </summary>
		CF_DSPENHMETAFILE	=  0x008E,

		/// <summary>
		/// Metafile-picture display format associated with a private format. 
		/// <para>
		/// The hMem parameter must be a handle to data that can be displayed in metafile-picture format in lieu of the privately formatted data.
		/// </para>
		/// </summary>
		CF_DSPMETAFILEPICT	=  0x0083,

		/// <summary>
		/// Text display format associated with a private format. 
		/// <para>
		/// The hMem parameter must be a handle to data that can be displayed in text format in lieu of the privately formatted data.
		/// </para>
		/// </summary>
		CF_DSPTEXT		=  0x0081,

		/// <summary>
		/// A handle to an enhanced metafile (HENHMETAFILE).
		/// </summary>
		CF_ENHMETAFILE		=      14,

		/// <summary>
		/// Start of a range of integer values for application-defined GDI object clipboard formats. The end of the range is CF_GDIOBJLAST.
		/// <para>
		/// Handles associated with clipboard formats in this range are not automatically deleted using the GlobalFree function when the clipboard is emptied. 
		/// </para>
		/// <para>
		/// Also, when using values in this range, the hMem parameter is not a handle to a GDI object, but is a handle allocated by the GlobalAlloc function 
		/// with the GMEM_MOVEABLE flag.
		/// </para>
		/// </summary>
		CF_GDIOBJFIRST		=  0x0300,

		/// <summary>
		/// See CF_GDIOBJFIRST.
		/// </summary>
		CF_GDIOBJLAST		=  0x03FF,

		/// <summary>
		/// A handle to type HDROP that identifies a list of files. 
		/// <para>
		/// An application can retrieve information about the files by passing the handle to the DragQueryFile function.
		/// </para>
		/// </summary>
		CF_HDROP		=      15,

		/// <summary>
		/// Data is a handle to the locale identifier associated with text in the clipboard. 
		/// <para>
		/// When you close the clipboard, if it contains CF_TEXT data but no CF_LOCALE data, the system automatically sets the CF_LOCALE format 
		/// to the current input language. You can use the CF_LOCALE format to associate a different locale with the clipboard text. 
		/// </para>
		/// <para>
		/// An application that pastes text from the clipboard can retrieve this format to determine which character set was used to generate the text.
		/// </para>
		/// <para>
		/// Note that the clipboard does not support plain text in multiple character sets. To achieve this, use a formatted text data type such as RTF instead.
		/// The system uses the code page associated with CF_LOCALE to implicitly convert from CF_TEXT to CF_UNICODETEXT. Therefore, the correct code page table 
		/// is used for the conversion.
		/// </para>
		/// </summary>
		CF_LOCALE		=      16,

		/// <summary>
		/// Handle to a metafile picture format as defined by the METAFILEPICT structure. 
		/// <para>
		/// When passing a CF_METAFILEPICT handle by means of DDE, the application responsible for deleting hMem should also free the metafile referred to 
		/// by the CF_METAFILEPICT handle.
		/// </para>
		/// </summary>
		CF_METAFILEPICT		=       3,

		/// <summary>
		/// Text format containing characters in the OEM character set. 
		/// <para>
		/// Each line ends with a carriage return/linefeed (CR-LF) combination. A null character signals the end of the data.
		/// </para>
		/// </summary>
		CF_OEMTEXT		=	7,

		/// <summary>
		/// Owner-display format. The clipboard owner must display and update the clipboard viewer window, and receive the 
		/// WM_ASKCBFORMATNAME, WM_HSCROLLCLIPBOARD, WM_PAINTCLIPBOARD, WM_SIZECLIPBOARD, and WM_VSCROLLCLIPBOARD messages. 
		/// <para>
		/// The hMem parameter must be NULL.
		/// </para>
		/// </summary>
		CF_OWNERDISPLAY		=  0x0080,

		/// <summary>
		/// Handle to a color palette. Whenever an application places data in the clipboard that depends on or assumes a color palette, 
		/// it should place the palette on the clipboard as well.
		/// <para>
		/// If the clipboard contains data in the CF_PALETTE (logical color palette) format, the application should use the SelectPalette 
		/// and RealizePalette functions to realize (compare) any other data in the clipboard against that logical palette.
		/// </para>
		/// <para>
		/// When displaying clipboard data, the clipboard always uses as its current palette any object on the clipboard that is in the CF_PALETTE format.
		/// </para>
		/// </summary>
		CF_PALETTE		=       9,

		/// <summary>
		/// Data for the pen extensions to the Microsoft Windows for Pen Computing.
		/// </summary>
		CF_PENDATA		=      10,

		/// <summary>
		/// Start of a range of integer values for private clipboard formats. 
		/// <para>
		/// The range ends with CF_PRIVATELAST. Handles associated with private clipboard formats are not freed automatically ; 
		/// the clipboard owner must free such handles, typically in response to the WM_DESTROYCLIPBOARD message.
		/// </para>
		/// </summary>
		CF_PRIVATEFIRST		=  0x0200,

		/// <summary>
		/// See CF_PRIVATEFIRST.
		/// </summary>
		CF_PRIVATELAST		=  0x02FF,

		/// <summary>
		/// Represents audio data more complex than can be represented in a CF_WAVE standard wave format.
		/// </summary>
		CF_RIFF			=      11,

		/// <summary>
		/// Microsoft Symbolic Link (SYLK) format.
		/// </summary>
		CF_SYLK			=       4,

		/// <summary>
		/// Text format. Each line ends with a carriage return/linefeed (CR-LF) combination. 
		/// A null character signals the end of the data. Use this format for ANSI text.
		/// </summary>
		CF_TEXT			=	1,

		/// <summary>
		/// Tagged-image file format.
		/// </summary>
		CF_TIFF			=	6,

		/// <summary>
		/// Unicode text format. Each line ends with a carriage return/linefeed (CR-LF) combination. 
		/// A null character signals the end of the data.
		/// </summary>
		CF_UNICODETEXT		=      13,

		/// <summary>
		/// Represents audio data in one of the standard wave formats, such as 11 kHz or 22 kHz PCM.
		/// </summary>
		CF_WAVE			=      12
	    }
	# endregion
    }