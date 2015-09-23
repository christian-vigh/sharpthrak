/**************************************************************************************************************

    NAME
        WinAPI/Structures/MINMAXINFO.cs

    DESCRIPTION
       Contains information about a window's maximized size and position and its minimum and maximum tracking size. 

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information about a window's maximized size and position and its minimum and maximum tracking size. 
	/// </summary>
	/// <remarks>
	/// For systems with multiple monitors, the ptMaxSize and ptMaxPosition members describe the maximized size and position of the window on the primary monitor, 
	/// even if the window ultimately maximizes onto a secondary monitor. 
	/// <para>
	/// In that case, the window manager adjusts these values to compensate for differences between the primary monitor and the monitor that displays the window. 
	/// </para>
	/// <para>
	/// Thus, if the user leaves ptMaxSize untouched, a window on a monitor larger than the primary monitor maximizes to the size of the larger monitor.
	/// </para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct MINMAXINFO
	   {
		/// <summary>
		/// Reserved; do not use.
		/// </summary>
		POINT ptReserved ;

		/// <summary>
		/// The maximized width (x member) and the maximized height (y member) of the window. For top-level windows, this value is based on the width of the primary monitor.
		/// </summary>
		POINT ptMaxSize ;

		/// <summary>
		/// The position of the left side of the maximized window (x member) and the position of the top of the maximized window (y member). 
		/// <para>
		/// For top-level windows, this value is based on the position of the primary monitor.
		/// </para>
		/// </summary>
		POINT ptMaxPosition ;

		/// <summary>
		/// The minimum tracking width (x member) and the minimum tracking height (y member) of the window.
		/// <para>
		/// This value can be obtained programmatically from the system metrics SM_CXMINTRACK and SM_CYMINTRACK (see the GetSystemMetrics function).
		/// </para>
		/// </summary>
		POINT ptMinTrackSize ;

		/// <summary>
		/// The maximum tracking width (x member) and the maximum tracking height (y member) of the window. 
		/// <para>
		/// This value is based on the size of the virtual screen and can be obtained programmatically from the system metrics SM_CXMAXTRACK and SM_CYMAXTRACK (see the GetSystemMetrics function).
		/// </para>
		/// </summary>
		POINT ptMaxTrackSize ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MINMAXINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MINMAXINFO structure.</returns>
		public static implicit operator  MINMAXINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MINMAXINFO		Result ;

			Result. ptMaxPosition		=  Structure. Empty ;
			Result. ptMaxSize		=  Structure. Empty ;
			Result. ptMaxTrackSize		=  Structure. Empty ;
			Result. ptMinTrackSize		=  Structure. Empty ;
			Result. ptReserved		=  Structure. Empty ;

			return ( Result ) ;
		    }
	    }
    }
