/**************************************************************************************************************

    NAME
	EditPoint.cs

    DESCRIPTION
	Extension methods for DTE.EditPoint.

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
	public static class EditPointExtensions
	   {
		/// <summary>
		/// Creates an edit point for the specified line and column.
		/// </summary>
		public static EditPoint  CreateEditPoint ( this EditPoint  ep, int  line, int  column )
		   {
			EditPoint	new_ep		=  ep. CreateEditPoint ( ) ;

			new_ep. MoveToLineAndOffset ( line, column ) ;

			return ( new_ep ) ;
		    }
		    

		/// <summary>
		/// Creates an edit point to the start of line position of the specified point.
		/// </summary>
		public static EditPoint	 CreateBolEditPoint ( this EditPoint  ep )
		   {
			EditPoint	new_ep		=  ep. CreateEditPoint ( ) ;

			new_ep. StartOfLine ( ) ;

			return ( new_ep ) ;
		    }


		/// <summary>
		/// Creates an edit point to the end of line position of the specified point.
		/// </summary>
		public static EditPoint  CreateEolEditPoint ( this EditPoint  ep )
		   {
			EditPoint	new_ep		=  ep. CreateEditPoint ( ) ;

			new_ep. EndOfLine ( ) ;

			return ( new_ep ) ;
		    }
		    				

		/// <summary>
		/// Creates an edit point to the first non-space character of a line.
		/// </summary>
		public static EditPoint	 FindFirstNonSpace ( this EditPoint  ep )
		   {
			if  ( ep. LineLength  ==  0 )
				return ( null ) ;

			EditPoint	new_ep		=  ep. CreateBolEditPoint ( ) ;
			string		line		=  ep. GetText ( ep. LineLength ) ;
			int		nonspace_index	=  0 ;

			for  ( int  i = 0 ; i  <  line. Length ; i ++ )
			   {
				if  ( line [i]. IsSpace ( ) )
					nonspace_index ++ ;
				else
					break ;
			    }

			new_ep. MoveToLineAndOffset ( new_ep. Line, nonspace_index + 1 ) ;

			return ( new_ep ) ;
		    }


		/// <summary>
		/// Gets a string representing the leding spaces of the specified line.
		/// </summary>
		public static string  GetLeadingSpaces ( this EditPoint  ep )
		   {
			EditPoint	new_ep	=  ep. FindFirstNonSpace ( ) ;

			if  ( new_ep  ==  null  ||  new_ep. LineCharOffset  ==  1 )
				return ( "" ) ;
			else
				return ( ep. GetText ( new_ep. LineCharOffset - 1 ) ) ;
		    }
	    }
    }
