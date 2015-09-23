/**************************************************************************************************************

    NAME
        WinAPI/Structures/TITLEBARINFOEX.cs

    DESCRIPTION
        TITLEBARINFOEX structure, returned by the GetTitleBarInfoEx() function.

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
	/// </summary>
	/// <remarks>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct TITLEBARINFOEX
	   {
		/// <summary>
		/// The size, in bytes, of the structure. The caller must set this member to sizeof(TITLEBARINFO). 
		/// </summary>
		public uint				cbSize ;

		/// <summary>
		/// The coordinates of the title bar. These coordinates include all title-bar elements except the window menu. 
		/// </summary>
		public RECT				rcTitleBar ;

		/// <summary>
		/// An array indexed by CCHILDREN_TITLEBAR values for each element of the title bar.
		/// <para>
		/// Each array element is a combination of one or more of the following values :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Value                         Meaning
		/// <para>-----                         -------
		/// <para>STATE_SYSTEM_FOCUSABLE        The element can accept the focus.
		/// <para>STATE_SYSTEM_INVISIBLE        The element is invisible.
		/// <para>STATE_SYSTEM_OFFSCREEN        The element has no visible representation.
		/// <para>STATE_SYSTEM_UNAVAILABLE      The element is unavailable.
		/// <para>STATE_SYSTEM_PRESSED          The element is in the pressed state.
		/// </code>
 		/// </summary>
		[MarshalAs ( UnmanagedType. ByValArray, SizeConst = ( int ) CCHILDREN_TITLEBAR_Constants. CCHILDREN_TITLEBAR_MAX + 1)]
		public STATE_SYSTEM_Constants[]		rgstate ;

		/// <summary>
		/// Coordinates of each element in the rgstate field.
		/// </summary>
		[MarshalAs ( UnmanagedType. ByValArray, SizeConst = ( int ) CCHILDREN_TITLEBAR_Constants. CCHILDREN_TITLEBAR_MAX + 1)]
		public RECT []				rgrect ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized TITLEBARINFOEX structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized TITLEBARINFOEX structure.</returns>
		public static implicit operator  TITLEBARINFOEX ( Thrak. WinAPI. Structures. Structure  value )		   {
			TITLEBARINFOEX		Result ;

			Result. cbSize			=  Macros. GETSTRUCTSIZE ( typeof( TITLEBARINFOEX ) ) ;
			Result. rcTitleBar		=  Structure. Empty ;
			Result. rgrect			=  new RECT [ ( int ) CCHILDREN_TITLEBAR_Constants. CCHILDREN_TITLEBAR_MAX + 1 ] ;
			Result. rgstate			=  new STATE_SYSTEM_Constants [ ( int ) CCHILDREN_TITLEBAR_Constants. CCHILDREN_TITLEBAR_MAX + 1 ] ;

			for  ( int  i = 0 ; i <=  ( int ) CCHILDREN_TITLEBAR_Constants. CCHILDREN_TITLEBAR_MAX ; i ++ )
			   {
				Result. rgrect [i]	=  Structure. Empty ;
				Result. rgstate [i]	=  STATE_SYSTEM_Constants. STATE_SYSTEM_NONE ;
			    }

			return ( Result ) ;
		    }
	    }
    }
