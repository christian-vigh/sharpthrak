/**************************************************************************************************************

    NAME
	TextSelection.cs

    DESCRIPTION
	Extension methods for DTE.Selection.

    AUTHOR
	Christian Vigh, 01/2016.

    HISTORY
	[Version : 1.0]		[Date : 2016/01/09]     [Author : CV]
		Initial version.

 **************************************************************************************************************/
using	System ;
using	EnvDTE ;

using	Thrak. Types ;


namespace Thrak. EnvDTE
   {
	public static class TextSelectionExtensions
	   {
		/// <summary>
		/// Returns the active point in the selection.
		/// </summary>
		public static EditPoint  GetActivePoint ( this TextSelection  selection )
		   { return ( ( EditPoint ) selection. ActivePoint. CreateEditPoint ( ) ) ; }


		/// <summary>
		/// Returns the anchor point.
		/// </summary>
		public static EditPoint  GetAnchorPoint ( this TextSelection  selection )
		   { return ( ( EditPoint ) selection. AnchorPoint. CreateEditPoint ( ) ) ; }


		/// <summary>
		/// Returns the selection's bottom point.
		/// </summary>
		public static EditPoint  GetBottomPoint ( this TextSelection  selection )
		   { return ( ( EditPoint ) selection. BottomPoint. CreateEditPoint ( ) ) ; }


		/// <summary>
		/// Returns the selection start (top) point.
		/// </summary>
		public static EditPoint  GetTopPoint ( this TextSelection  selection )
		   { return ( ( EditPoint ) selection. TopPoint. CreateEditPoint ( ) ) ; }
		   
	    }
    }
