/**************************************************************************************************************

    NAME
        WinAPI/Structures/WTSSESSION_NOTIFICATION.cs

    DESCRIPTION
        Provides information about the session change notification. A service receives this structure in its 
 	HandlerEx function in response to a session change event.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Provides information about the session change notification. A service receives this structure in its HandlerEx function in response to a session change event.
	/// </summary>
	/// <remarks>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct WTSSESSION_NOTIFICATION
	   {
		/// <summary>
		/// The size of the structure, in bytes. The caller must set this member to sizeof(WTSSESSION_NOTIFICATION). 
		/// </summary>
		uint			cbSize ;

		/// <summary>
		/// Session identifier that triggered the session change event.
		/// </summary>
		uint			dwSessionId ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized WTSSESSION_NOTIFICATION structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized WTSSESSION_NOTIFICATION structure.</returns>
		public static implicit operator  WTSSESSION_NOTIFICATION ( Thrak. WinAPI. Structures. Structure  value )
		   {
			WTSSESSION_NOTIFICATION		Result ;

			Result.cbSize			=  Macros. GETSTRUCTSIZE ( typeof( WTSSESSION_NOTIFICATION ) ) ;
			Result. dwSessionId		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
