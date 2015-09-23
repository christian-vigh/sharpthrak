/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/CLIENTCREATESTRUCT.cs

    DESCRIPTION
        CLIENTCREATESTRUCT structure, send in the lpCreateParams field of the WM_CREATE Windows message.

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
	/// Contains information about the menu and first multiple-document interface (MDI) child window of an MDI client window. 
	/// <para>
	/// An application passes a pointer to this structure as the lpParam parameter of the CreateWindow function when creating an MDI client window. 
	/// </para>
	/// </summary>
	/// <remarks>
	/// When the MDI client window is created by calling CreateWindow, the system sends a WM_CREATE message to the window. 
	/// <para>
	/// The lParam parameter of WM_CREATE contains a pointer to a CREATESTRUCT structure. 
	/// </para>
	/// <para>
	/// The lpCreateParams member of this structure contains a pointer to a CLIENTCREATESTRUCT structure.
	/// </para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct CLIENTCREATESTRUCT
	   {
		/// <summary>
		/// A handle to the MDI application's window menu. An MDI application can retrieve this handle from the menu of the MDI frame window by using 
		/// the GetSubMenu function. 
		/// </summary>
		IntPtr		hWindowMenu ;

		/// <summary>
		/// The child window identifier of the first MDI child window created. The system increments the identifier for each additional MDI child window 
		/// the application creates, and reassigns identifiers when the application destroys a window to keep the range of identifiers contiguous. 
		/// <para>
		/// These identifiers are used in WM_COMMAND messages sent to the application's MDI frame window when a child window is chosen from the window menu; 
		/// they should not conflict with any other command identifiers. 
		/// </para>
		/// </summary>
		uint		idFirstChild ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized CLIENTCREATESTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized CLIENTCREATESTRUCT structure.</returns>
		public static implicit operator  CLIENTCREATESTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			CLIENTCREATESTRUCT		Result ;

			Result. hWindowMenu	=  IntPtr. Zero ;
			Result. idFirstChild	=  0 ;

			return ( Result ) ;
		    }
	    }
    }
