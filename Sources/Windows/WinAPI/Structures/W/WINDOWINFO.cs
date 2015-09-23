/**************************************************************************************************************

    NAME
        WinAPI/Structures/WINDOWINFO.cs

    DESCRIPTION
        WINDOWINFO structure, returned by the GetWindowInfo() function.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

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
	/// Contains window information.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct WINDOWINFO
	   {
		/// <summary>
		/// The size of the structure, in bytes. The caller must set this member to sizeof(WINDOWINFO). 
		/// </summary>
		uint			cbSize ;

		/// <summary>
		/// The coordinates of the window. 
		/// </summary>
		RECT			rcWindow ;

		/// <summary>
		/// The coordinates of the client area. 
		/// </summary>
		RECT			rcClient ;

		/// <summary>
		/// The window styles.
		/// </summary>
		WS_Constants		dwStyle ;

		/// <summary>
		/// The extended window styles. 
		/// </summary>
		WS_EX_Constants		dwExStyle ;

		/// <summary>
		/// The window status. If this member is true, the window is active. Otherwise, this member is zero. 
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool )]
		bool			dwWindowStatus ;

		/// <summary>
		/// The width of the window border, in pixels. 
		/// </summary>
		uint			cxWindowBorders ;

		/// <summary>
		/// The height of the window border, in pixels. 
		/// </summary>
		uint			cyWindowBorders ;

		/// <summary>
		/// The window class atom (see RegisterClass). 
		/// </summary>
		IntPtr			atomWindowtype ;

		/// <summary>
		/// The Windows version of the application that created the window. 
		/// </summary>
		ushort			wCreatorVersion ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized WINDOWINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized WINDOWINFO structure.</returns>
		public static implicit operator  WINDOWINFO ( Thrak. WinAPI. Structures. Structure  value )		   {
			WINDOWINFO		Result ;

			Result.cbSize			=  Macros. GETSTRUCTSIZE ( typeof( WINDOWINFO ) ) ;
			Result. atomWindowtype		=  IntPtr. Zero ;
			Result. cxWindowBorders		=  0 ;
			Result. cyWindowBorders		=  0 ;
			Result. dwExStyle		=  WS_EX_Constants. WS_EX_NONE ;
			Result. dwStyle			=  WS_Constants. WS_NONE ;
			Result. dwWindowStatus		=  false ;
			Result. rcClient		=  Structure. Empty ;
			Result. rcWindow		=  Structure. Empty ;
			Result. wCreatorVersion		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
