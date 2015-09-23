/**************************************************************************************************************

    NAME
        WinAPI/Structure/P/PAINTSTRUCT.cs

    DESCRIPTION
        PAINTSTRUCT structure.

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
	/// The PAINTSTRUCT structure contains information for an application. This information can be used to paint the client area of a window owned by that application.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  PAINTSTRUCT
	   {
		/// <summary>
		/// A handle to the display DC to be used for painting.
		/// </summary>
		public IntPtr		hdc ;

		/// <summary>
		/// Indicates whether the background must be erased. This value is nonzero if the application should erase the background. 
		/// <para>
		/// The application is responsible for erasing the background if a window class is created without a background brush. 
		/// </para>
		/// <para>
		/// For more information, see the description of the hbrBackground member of the WNDCLASS structure.
		/// </para>
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool )]
		public bool		fErase ;

		/// <summary>
		/// A RECT structure that specifies the upper left and lower right corners of the rectangle in which the painting is requested, 
		/// in device units relative to the upper-left corner of the client area.
		/// </summary>
		public RECT		rcPaint ;

		/// <summary>
		/// Reserved; used internally by the system.
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool )]
		public bool		fRestore ;

		/// <summary>
		/// Reserved; used internally by the system.
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool )]
		public bool		fIncUpdate ;

		/// <summary>
		/// Reserved; used internally by the system.
		/// </summary>
		[ MarshalAs ( UnmanagedType. ByValArray, SizeConst = 32 )] 
		public byte []		rgbReserved ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized PAINTSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized PAINTSTRUCT structure.</returns>
		public static implicit operator  PAINTSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			PAINTSTRUCT		Result ;

			Result. fErase		=  false ;
			Result. fIncUpdate	=  false ;
			Result. fRestore	=  false ;
			Result. hdc		=  IntPtr. Zero ;
			Result. rcPaint		=  Structure. Empty ;
			Result. rgbReserved	=  new byte [32] ;

			return ( Result ) ;
		    }
	    }
    }