/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/CBTACTIVATESTRUCT.cs

    DESCRIPTION
        Contains information passed to a WH_CBT hook procedure, CBTProc, before a window is created. 

    AUTHOR
        Christian Vigh, 08/2012.

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
	/// Contains information passed to a WH_CBT hook procedure, CBTProc, before a window is activated. 
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct CBTACTIVATESTRUCT
	   {
		/// <summary>
		/// This member is TRUE if a mouse click is causing the activation or FALSE if it is not. 
		/// </summary>
		[MarshalAs ( UnmanagedType. Bool)]
		bool		fMouse ;

		/// <summary>
		/// A handle to the active window. 
		/// </summary>
		IntPtr		hWndActive ;

		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized CBTACTIVATESTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized CBTACTIVATESTRUCT structure.</returns>
		public static implicit operator  CBTACTIVATESTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			CBTACTIVATESTRUCT		Result ;

			Result. fMouse			=  false ;
			Result. hWndActive		=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }
