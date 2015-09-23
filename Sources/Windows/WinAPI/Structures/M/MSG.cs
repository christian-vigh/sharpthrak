/**************************************************************************************************************

    NAME
        WinAPI/Structure/M/MSG.cs

    DESCRIPTION
        MSG structure.

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
	/// Contains message information from a thread's message queue. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  MSG
	   {
		/// <summary>
		/// A handle to the window whose window procedure receives the message. This member is NULL when the message is a thread message.
		/// </summary>
		public IntPtr			hwnd ;

		/// <summary>
		/// The message identifier. Applications can only use the low word; the high word is reserved by the system. 
		/// </summary>
		public WM_Constants		message ;

		/// <summary>
		/// Additional information about the message. The exact meaning depends on the value of the message member. 
		/// </summary>
		public IntPtr			wParam ;

		/// <summary>
		/// Additional information about the message. The exact meaning depends on the value of the message member. 
		/// </summary>
		public IntPtr			lParam ;

		/// <summary>
		/// The time at which the message was posted. 
		/// </summary>
		public uint			time ;
		
		/// <summary>
		/// The cursor position, in screen coordinates, when the message was posted. 
		/// </summary>
		public POINT			pt ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MSG structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MSG structure.</returns>
		public static implicit operator  MSG ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MSG		Result ;

			Result. hwnd		=  IntPtr. Zero ;
			Result. lParam		=  IntPtr. Zero ;
			Result. message		=  WM_Constants. WM_NULL ;
			Result. pt		=  Structure. Empty ;
			Result. time		=  0 ;
			Result. wParam		=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }