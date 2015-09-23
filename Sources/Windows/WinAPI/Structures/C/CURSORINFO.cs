/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/CURSORINFO.cs

    DESCRIPTION
        CURSORINFO structure, send through the CB_GETCURSORINFO Windows message.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains global cursor information.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct CURSORINFO
	   {
		/// <summary>
		/// The size of the structure, in bytes. The caller must set this to sizeof(CURSORINFO).
		/// </summary>
		public uint			cbSize ;

		/// <summary>
		/// The cursor state. 
		/// </summary>
		public CURSOR_Constants		flags ;

		/// <summary>
		/// A handle to the cursor. 
		/// </summary>
		public IntPtr			hCursor ;

		/// <summary>
		/// A structure that receives the screen coordinates of the cursor.
		/// </summary>
		public POINT			ptScreenPos ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized CURSORINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized CURSORINFO structure.</returns>
		public static implicit operator  CURSORINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			CURSORINFO		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( CURSORINFO ) ) ;
			Result. flags		=  CURSOR_Constants. CURSOR_NONE ;
			Result. hCursor		=  IntPtr. Zero ;
			Result. ptScreenPos	=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }
