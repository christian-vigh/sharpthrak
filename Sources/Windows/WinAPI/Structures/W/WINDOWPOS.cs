/**************************************************************************************************************

    NAME
        WinAPI/Structure/W/WINDOWPOS.cs

    DESCRIPTION
        WINDOWPOS structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
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
	/// Contains information about the size and position of a window. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  WINDOWPOS
	   {
		/// <summary>
		/// A handle to the window. 
		/// </summary>
		public IntPtr		hwnd ;

		/// <summary>
		/// The position of the window in Z order (front-to-back position). This member can be a handle to the window behind which this window is placed, 
		/// or can be one of the special values listed with the SetWindowPos function. 
		/// </summary>
		public IntPtr		hwndInsertAfter ;

		/// <summary>
		/// The position of the left edge of the window. 
		/// </summary>
		public int		x ;

		/// <summary>
		/// The position of the top edge of the window. 
		/// </summary>
		public int		y ;

		/// <summary>
		/// The window width, in pixels. 
		/// </summary>
		public int		cx ;

		/// <summary>
		/// The window height, in pixels. 
		/// </summary>
		public int		cy ;

		/// <summary>
		/// The window position. 
		/// </summary>
		public SWP_Constants	flags ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized WINDOWPOS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized WINDOWPOS structure.</returns>
		public static implicit operator  WINDOWPOS ( Thrak. WinAPI. Structures. Structure  value )		   {
			WINDOWPOS		Result ;

			Result. cx		=  0 ;
			Result. cy		=  0 ;
			Result. flags		=  SWP_Constants. SWP_NONE ;
			Result. hwnd		=  IntPtr. Zero ;
			Result. hwndInsertAfter	=  IntPtr. Zero ;
			Result. x		=  0 ;
			Result. y		=  0 ;

			return ( Result ) ;
		    }
	    }
    }