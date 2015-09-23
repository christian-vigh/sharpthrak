/**************************************************************************************************************

    NAME
        WinAPI/Structure/C/CWPRETSTRUCT.cs

    DESCRIPTION
        CWPRETSTRUCT structure.

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
	/// Defines the message parameters passed to a WH_CALLWNDPROCRET hook procedure, CallWndRetProc. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  CWPRETSTRUCT
	   {
		/// <summary>
		/// The return value of the window procedure that processed the message specified by the message value. 
		/// </summary>
		public IntPtr		lResult ;

		/// <summary>
		/// Additional information about the message. The exact meaning depends on the message value. 
		/// </summary>
		public IntPtr		lParam ;

		/// <summary>
		/// Additional information about the message. The exact meaning depends on the message value. 
		/// </summary>
		public IntPtr		wParam ;

		/// <summary>
		/// The message. 
		/// </summary>
		public uint		message ;

		/// <summary>
		/// A handle to the window to receive the message. 
		/// </summary>
		public IntPtr		hwnd ;


    		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized CWPRETSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized CWPRETSTRUCT structure.</returns>
		public static implicit operator  CWPRETSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			CWPRETSTRUCT		Result ;

			Result. hwnd		=  IntPtr. Zero ;
			Result. lParam		=  IntPtr. Zero ;
			Result. lResult		=  IntPtr. Zero ;
			Result. message		=  0 ;
			Result. wParam		=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }