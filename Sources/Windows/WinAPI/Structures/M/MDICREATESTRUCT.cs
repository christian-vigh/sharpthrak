/**************************************************************************************************************

    NAME
        WinAPI/Structures/M/MDICREATESTRUCT.cs

    DESCRIPTION
        MDICREATESTRUCT structure, send in the lpCreateParams field of the WM_CREATE Windows message.

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
	/// Contains information about the class, title, owner, location, and size of a multiple-document interface (MDI) child window. 
	/// </summary>
	/// <remarks>
	/// When the MDI client window creates an MDI child window by calling CreateWindow, the system sends a WM_CREATE message to the created window. 
	/// <para>
	/// The lParam member of the WM_CREATE message contains a pointer to a CREATESTRUCT structure. 
	/// </para>
	/// <para>
	/// The lpCreateParams member of this structure contains a pointer to the MDICREATESTRUCT structure passed with the WM_MDICREATE message that created the MDI child window.
	/// </para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential, CharSet = CharSet. Auto )]
	public struct MDICREATESTRUCT
	   {
		/// <summary>
		/// The name of the window class of the MDI child window. The class name must have been registered by a previous call to the RegisterClass function. 
		/// </summary>
		String		szClass ;

		/// <summary>
		/// The title of the MDI child window. The system displays the title in the child window's title bar. 
		/// </summary>
		String		szTitle ;

		/// <summary>
		/// A handle to the instance of the application creating the MDI client window. 
		/// </summary>
		IntPtr		hOwner ;

		/// <summary>
		/// The initial horizontal position, in client coordinates, of the MDI child window. 
		/// <para>
		/// If this member is CW_USEDEFAULT, the MDI child window is assigned the default horizontal position. 
		/// </para>
		/// </summary>
		int		x ;

		/// <summary>
		/// The initial vertical position, in client coordinates, of the MDI child window. 
		/// <para>
		/// If this member is CW_USEDEFAULT, the MDI child window is assigned the default vertical position. 
		/// </para>
		/// </summary>
		int		y ;

		/// <summary>
		/// The initial width, in device units, of the MDI child window. 
		/// <para>
		/// If this member is CW_USEDEFAULT, the MDI child window is assigned the default width. 
		/// </para>
		/// </summary>
		int		cx ;

		/// <summary>
		/// The initial height, in device units, of the MDI child window. 
		/// <para>
		/// If this member is set to CW_USEDEFAULT, the MDI child window is assigned the default height. 
		/// </para>
		/// </summary>
		int		cy ;

		/// <summary>
		/// The style of the MDI child window. If the MDI client window was created with the MDIS_ALLCHILDSTYLES window style, 
		/// this member can be any combination of the window styles listed in the Window Styles page. 
		/// <para>
		/// Otherwise, this member can be one or more of the following values :
		/// </para>
		/// <br/>
		/// <code>
		/// <para>Value                 Meaning</para>
		/// <para>-----                 -------</para>
		/// <para>WS_MINIMIZE           Creates an MDI child window that is initially minimized.</para>
		/// <para>WS_MAXIMIZE           Creates an MDI child window that is initially maximized.</para>
		/// <para>WS_HSCROLL            Creates an MDI child window that has a horizontal scroll bar.</para>
		/// <para>WS_VSCROLL            Creates an MDI child window that has a vertical scroll bar.</para>
		/// </code>
		/// </summary>
		WS_Constants	style ;

		/// <summary>
		/// An application-defined value. 
		/// </summary>
		IntPtr		lParam ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MDICREATESTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MDICREATESTRUCT structure.</returns>
		public static implicit operator  MDICREATESTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MDICREATESTRUCT		Result ;

			Result. cx		=  0 ;
			Result. cy		=  0 ;
			Result. hOwner		=  IntPtr. Zero ;
			Result. lParam		=  IntPtr. Zero ;
			Result. style		=  WS_Constants. WS_NONE ;
			Result. szClass		=  "" ;
			Result. szTitle		=  "" ;
			Result. x		=  0 ;
			Result. y		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
