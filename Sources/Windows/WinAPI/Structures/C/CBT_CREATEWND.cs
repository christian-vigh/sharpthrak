/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/CBT_CREATEWND.cs

    DESCRIPTION
        Contains information passed to a WH_CBT hook procedure, CBTProc, before a window is created. 

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
	/// Contains information passed to a WH_CBT hook procedure, CBTProc, before a window is created. 
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct CBT_CREATEWND
	   {
		/// <summary>
		/// A pointer to a CREATESTRUCT structure that contains initialization parameters for the window about to be created. 
		/// </summary>
		IntPtr			lpcs ;

		/// <summary>
		/// A handle to the window whose position in the Z order precedes that of the window being created. This member can also be NULL.
		/// </summary>
		IntPtr			hwndInsertAfter ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized CBT_CREATEWND structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized CBT_CREATEWND structure.</returns>
		public static implicit operator  CBT_CREATEWND ( Thrak. WinAPI. Structures. Structure  value )
		   {
			CBT_CREATEWND		Result ;

			Result. lpcs			=  IntPtr. Zero ;
			Result. hwndInsertAfter		=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }
