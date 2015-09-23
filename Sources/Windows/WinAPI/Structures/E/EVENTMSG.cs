/**************************************************************************************************************

    NAME
        WinAPI/Structure/E/EVENTMSG.cs

    DESCRIPTION
        EVENTMSG structure.

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
	/// Contains information about a hardware message sent to the system message queue. 
	/// This structure is used to store message information for the JournalPlaybackProc callback function. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  EVENTMSG
	   {
		/// <summary>
		/// The message.
		/// </summary>
		public uint		message ;

		/// <summary>
		/// Additional information about the message. The exact meaning depends on the message value. 
		/// </summary>
		public uint		paramL ;

		/// <summary>
		/// Additional information about the message. The exact meaning depends on the message value. 
		/// </summary>
		public uint		paramH ;

		/// <summary>
		/// The time at which the message was posted. 
		/// </summary>
		public UInt32		time ;

		/// <summary>
		/// A handle to the window to which the message was posted. 
		/// </summary>
		public IntPtr		hwnd ;

		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized EVENTMSG structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized EVENTMSG structure.</returns>
		public static implicit operator  EVENTMSG ( Thrak. WinAPI. Structures. Structure  value )
		   {
			EVENTMSG		Result ;

			Result. hwnd		=  IntPtr. Zero ;
			Result. message		=  0 ;
			Result. paramH		=  0 ;
			Result. paramL		=  0 ;
			Result. time		=  0 ;

			return ( Result ) ;
		    }
	    }
    }