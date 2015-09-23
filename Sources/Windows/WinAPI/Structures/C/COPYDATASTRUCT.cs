/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/COPYDATASTRUCT.cs

    DESCRIPTION
        COPYDATASTRUCT structure, send through the WM_COPYDATA Windows message.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains data to be passed to another application by the WM_COPYDATA message. 
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct COPYDATASTRUCT
	   {
		/// <summary>
		/// The data to be passed to the receiving application. 
		/// </summary>
		public IntPtr		dwData ;

		/// <summary>
		/// The size, in bytes, of the data pointed to by the lpData member. 
		/// </summary>
		public uint		cbData ;

		/// <summary>
		/// The data to be passed to the receiving application. This member can be NULL. 
		/// </summary>
		public IntPtr		lpData ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized COPYDATASTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized COPYDATASTRUCT structure.</returns>
		public static implicit operator  COPYDATASTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			COPYDATASTRUCT		Result ;

			Result. dwData		=  IntPtr. Zero ;
			Result. cbData		=  0 ;
			Result. lpData		=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }
