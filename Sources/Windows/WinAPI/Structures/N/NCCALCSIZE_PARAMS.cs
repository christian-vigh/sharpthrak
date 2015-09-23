/**************************************************************************************************************

    NAME
        WinAPI/Structures/N/NCCALCSIZE_PARAMS.cs

    DESCRIPTION
        NCCALCSIZE_PARAMS structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
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
	/// Contains information that an application can use while processing the WM_NCCALCSIZE message to calculate the size, position, 
	/// and valid contents of the client area of a window. 
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  NCCALCSIZE_PARAMS
	   {
		/// <summary>
		/// An array of rectangles. The meaning of the array of rectangles changes during the processing of the WM_NCCALCSIZE message.
		/// <br/>
		/// <para>
		/// When the window procedure receives the WM_NCCALCSIZE message, the first rectangle contains the new coordinates of a window that has been 
		/// moved or resized, that is, it is the proposed new window coordinates. The second contains the coordinates of the window before it was moved 
		/// or resized. The third contains the coordinates of the window's client area before the window was moved or resized. 
		/// If the window is a child window, the coordinates are relative to the client area of the parent window. 
		/// If the window is a top-level window, the coordinates are relative to the screen origin.
		/// </para>
		/// <br/>
		/// <para>
		/// When the window procedure returns, the first rectangle contains the coordinates of the new client rectangle resulting from the move 
		/// or resize. The second rectangle contains the valid destination rectangle, and the third rectangle contains the valid source rectangle. 
		/// The last two rectangles are used in conjunction with the return value of the WM_NCCALCSIZE message to determine the area of the window 
		/// to be preserved.
		/// </para>
		/// </summary>
		RECT				rgrc1 ;

		/// <summary>
		/// See rgrc1.
		/// </summary>
		RECT				rgrc2 ;

		/// <summary>
		/// Set rgrc1.
		/// </summary>
		RECT				rgrc3 ;

		/// <summary>
		/// A pointer to a WINDOWPOS structure that contains the size and position values specified in the operation that moved or resized the window. 
		/// </summary>
		public IntPtr		lppos ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized NCCALCSIZE_PARAMS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized NCCALCSIZE_PARAMS structure.</returns>
		public static implicit operator  NCCALCSIZE_PARAMS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			NCCALCSIZE_PARAMS		Result ;
			RECT				Zero		=  Structure. Empty ;


			Result. rgrc1			=  Zero ;
			Result. rgrc2			=  Zero ;
			Result. rgrc3			=  Zero ;
			Result. lppos			=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }