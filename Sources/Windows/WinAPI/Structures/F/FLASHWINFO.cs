/**************************************************************************************************************

    NAME
        WinAPI/Structures/F/FLASHWINFO.cs

    DESCRIPTION
        FLASHWINFO structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/30]     [Author : CV]
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
	/// Contains the flash status for a window and the number of times the system should flash the window.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  FLASHWINFO
	   {
		/// <summary>
		/// The size of the structure, in bytes.
		/// </summary>
		public uint			cbSize ;

		/// <summary>
		/// A handle to the window to be flashed. The window can be either opened or minimized.
		/// </summary>
		public IntPtr			hwnd ;

		/// <summary>
		/// The flash status. This parameter can be one or more of the FLASHW_Constants.
		/// </summary>
		public FLASHW_Constants		dwFlags ;

		/// <summary>
		/// The number of times to flash the window.
		/// </summary>
		public uint			uCount ;

		/// <summary>
		/// The rate at which the window is to be flashed, in milliseconds. If dwTimeout is zero, the function uses the default cursor blink rate.
		/// </summary>
		public uint			dwTimeout ;

		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized FLASHWINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized FLASHWINFO structure.</returns>
		public static implicit operator  FLASHWINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			FLASHWINFO		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( FLASHWINFO ) ) ;
			Result. dwFlags		=  FLASHW_Constants. FLASHW_NONE ;
			Result. dwTimeout	=  0 ;
			Result. hwnd		=  IntPtr. Zero ;
			Result. uCount		=  0 ;

			return ( Result ) ;
		    }
	    }
    }