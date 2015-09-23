/**************************************************************************************************************

    NAME
        History.cs

    DESCRIPTION
        Handles a shell history.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text ;


namespace Thrak. Forms
   {
	# region ShellHistoryEntry class
	/// <summary>
	/// Holds a history entry.
	/// </summary>
	public class  ShellHistoryEntry
	   {
		// Private data members
		private String			p_Text ;			// Command text
		private int			p_LineIndex ;			// Line index in the textbox
		private DateTime		p_TimeStamp ;			// Timestamp of the insertion


		/// <summary>
		/// Builds a ShellHistoryEntry object.
		/// </summary>
		public  ShellHistoryEntry ( String  text, int  line_index = 0 )
		   {
			p_Text		=  text. Replace ( "\n", "" ) ;
			p_LineIndex	=  line_index ;
			p_TimeStamp	=  DateTime. Now ;
		    }


		/// <summary>
		/// Gets the command text.
		/// </summary>
		public String  Text 
		   {
			get { return ( p_Text ) ; }
		    }


		/// <summary>
		/// Gets the line index in the textbox parent.
		/// </summary>
		public int  LineIndex 
		   {
			get { return ( p_LineIndex ) ; }
		    }


		/// <summary>
		/// Gets the timestamp when the command was entered.
		/// </summary>
		public DateTime   TimeStamp
		   {
			get { return ( p_TimeStamp ) ; }
		    }
	    }
	# endregion


	# region ShellHistory class
	/// <summary>
	/// Holds a shell window command history.
	/// </summary>
	public class  ShellHistory 
	   {
		// Private variables
		private List<ShellHistoryEntry>			p_Entries	=  new List<ShellHistoryEntry> ( ) ;
		private ShellForm				p_Parent ;


		/// <summary>
		/// Builds a history for the specified shell window.
		/// </summary>
		public  ShellHistory ( ShellForm  parent )
		   {
			p_Parent	=  parent ;
		    }


		/// <summary>
		/// Adds a command to the shell history.
		/// </summary>
		public void  Add ( String  text, int  line_index )
		   {
			ShellHistoryEntry	she	=  new ShellHistoryEntry ( text, line_index ) ;

			p_Entries. Add ( she ) ;
		    }


		/// <summary>
		/// Gets the number of entries in the history.
		/// </summary>
		public int  Count 
		   {
			get { return ( p_Entries. Count ) ; }
		    }


		/// <summary>
		/// Gets a history entry by index.
		/// </summary>
		public ShellHistoryEntry  this [ int  index ]
		   {
			get { return ( p_Entries [ index ] ) ; }
		    }
	    }
	# endregion


	# region ShellHistoryNavigator class
	/// <summary>
	/// A class to navigate through a command history.
	/// </summary>
	public class  ShellHistoryNavigator
	   {
		// Private data members
		private ShellHistory		p_History ;				// Command history object
		private int			p_Position		=  0 ;		// Current position in history
		private String			p_Text ;				// Text base to restrict history search on


		/// <summary>
		/// Builds a navigator object.
		/// </summary>
		public ShellHistoryNavigator ( ShellHistory  history, String  text =  "" )
		   {
			p_History	=  history ;
			p_Text		=  text ;
			p_Position	=  history. Count ;
		    }


		/// <summary>
		/// Moves to the previous command in history.
		/// </summary>
		public void  Backward ( )
		   {
			if  ( p_History. Count  ==  0 )
				return ;

			if (  p_Text. Length  ==  0 )
			   {
				p_Position -- ;

				if  ( p_Position  <  0 )
					p_Position = p_History. Count - 1 ;
			     }
			else
			   {
				int	position		=  p_Position ;

				for  ( int  i = 0 ; i < p_History. Count ; i ++ )
				   {
					position -- ;

					if  ( position  <  0 )
						position = p_History. Count - 1 ;

					if  ( p_History [ position ]. Text. StartsWith ( p_Text, true, null ) )
					   {
						p_Position	=  position ;
						return ;
					    }
				    }
			    }
		    }


		/// <summary>
		/// Moves to the next command in history.
		/// </summary>
		public void  Forward ( )
		   {
			if  ( p_History. Count  >  0 )
				return ;

			if (  p_Text. Length  ==  0 )
			   {
				p_Position ++ ;

				if  ( p_Position  >=  p_History. Count )
					p_Position = 0 ;
			     }
			else
			   {
				int	position		=  p_Position ;

				for  ( int  i = 0 ; i < p_History. Count ; i ++ )
				   {
					position ++ ;

					if  ( position  >=  p_History. Count )
						position = 0 ;

					if  ( p_History [ position ]. Text. StartsWith ( p_Text, true, null ) )
					   {
						p_Position	=  position ;
						return ;
					    }
				    }
			    }
		    }


		/// <summary>
		/// Gets the current history entry, or null if no history command exists.
		/// </summary>
		public ShellHistoryEntry  Current
		   {
			get
			   {
				if  ( p_History. Count  !=  0 )
					return ( p_History [ p_Position ] ) ;
				else
					return ( null ) ;
			    }
		    }
	    }
	# endregion
    }
