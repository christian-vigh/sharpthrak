/**************************************************************************************************************

    NAME
        WinAPI/Structure/S/SHELLHOOKINFO.cs

    DESCRIPTION
        SHELLHOOKINFO structure.

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
	/// Hook information structure sent with some shell notification messages.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  SHELLHOOKINFO
	   {
		/// <summary>
		/// Window concerned by the notification message.
		/// </summary>
		public IntPtr		hwnd ;

		/// <summary>
		/// Additional rectangle information. Meaning depends on the shell notification message.
		/// </summary>
		public RECT		rc ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized SHELLHOOKINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized SHELLHOOKINFO structure.</returns>
		public static implicit operator  SHELLHOOKINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			SHELLHOOKINFO		Result ;

			Result. hwnd		=  IntPtr. Zero ;
			Result. rc		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }