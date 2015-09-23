/**************************************************************************************************************

    NAME
        WinAPI/Structure/G/GESTURENOTIFYSTRUCT.cs

    DESCRIPTION
        GESTURENOTIFYSTRUCT structure.

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
	/// When transmitted with WM_GESTURENOTIFY messages, passes information about a gesture. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  GESTURENOTIFYSTRUCT
	   {
		/// <summary>
		/// When transmitted with WM_GESTURENOTIFY messages, passes information about a gesture. 
		/// </summary>
		public uint		cbSize ;

		/// <summary>
		/// Reserved for future use.
		/// </summary>
		public uint		dwFlags ;

		/// <summary>
		/// The target window for the gesture notification.
		/// </summary>
		public IntPtr		hwndTarget ;

		/// <summary>
		/// The location of the gesture in physical screen coordinates.
		/// </summary>
		public POINTS		ptsLocation ;

		/// <summary>
		/// A specific gesture instance with gesture messages starting with GID_START and ending with GID_END.
		/// </summary>
		public uint		dwInstanceID ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized GESTURENOTIFYSTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized GESTURENOTIFYSTRUCT structure.</returns>
		public static implicit operator  GESTURENOTIFYSTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			GESTURENOTIFYSTRUCT		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( GESTURENOTIFYSTRUCT ) ) ;
			Result. dwFlags		=  0 ;
			Result. dwInstanceID	=  0 ;
			Result. hwndTarget	=  IntPtr. Zero ;
			Result. ptsLocation	=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }