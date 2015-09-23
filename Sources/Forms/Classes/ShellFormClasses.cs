/**************************************************************************************************************

    NAME
        ShellFormClasses.cs

    DESCRIPTION
        Shell form classes, mainly event args and exceptions.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/22]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text ;
using   System. Text. RegularExpressions ;


using   Thrak. Core ;

namespace Thrak. Forms
   {
	# region Exceptions 
	/// <summary>
	/// Exception thrown when the interpreter loop is run a second time.
	/// </summary>
	public class  ShellAlreadyStartedException :  ThrakException
	   {
		public  ShellAlreadyStartedException ( ) :
				base ( Resources. Localization. Exceptions. ShellAlreadyStartedException ) 
		  { }
	    }


	/// <summary>
	/// Exception thrown when the interpreter loop receives an interrupt (Ctrl+C).
	/// </summary>
	public class  ShellInterruptException :  ThrakException
	   {
		public  ShellInterruptException ( ) :
				base ( ) 
		  { }
	    }
	

	/// <summary>
	/// Exception thrown when trying to stop the interpreter loop, but no interpreter loop was started.
	/// </summary>
	public class  ShellNotStartedException :  ThrakException
	   {
		public  ShellNotStartedException ( ) :
				base ( Resources. Localization. Exceptions. ShellNotStartedException ) 
		  { }
	    }


	/// <summary>
	/// Exception thrown when an invalid command has been encountered.
	/// </summary>
	public class  ShellInvalidCommandException :  ThrakException
	   {
		public  ShellInvalidCommandException ( String  cmd ) :
				base ( String.Format ( Resources. Localization. Exceptions. ShellInvalidCommandException, cmd ) )
		  { }
	    }
	# endregion


	# region InsertModeChangedEventArgs class
	/// <summary>
	/// Event args for the InsertModeChanged event handler.
	/// </summary>
	public class  InsertModeChangedEventArgs 
	   {
		public bool		InsertMode ;


		public	InsertModeChangedEventArgs ( bool  insert_mode )
		   { 
			InsertMode		=  insert_mode ; 
		    }
	    }
	# endregion


	# region CharacterInputEventArgs event
	/// <summary>
	/// Event args for character input. The Echo member can be used to enable/disable character display.
	/// </summary>
	public class  CharacterInputEventArgs 
	   {
		public String		Input ;
		public bool		Echo ;


		public  CharacterInputEventArgs  ( char  ch, bool  echo )
		   {
			Input		=  ch. ToString ( ) ;
			Echo		=  echo ;
		    }


		public  CharacterInputEventArgs  ( String  s, bool  echo )
		   {
			Input		=  s ;
			Echo		=  echo ;
		    }
	    }
	# endregion


	# region CommandInputEventArgs event 
	/// <summary>
	/// Event args for a command input.
	/// </summary>
	public class  CommandInputEventArgs 
	   {
		public String		Command ;
		public int		Argc ;
		public String []	Argv ;
		public bool		Handled		=  false ;

		private const String	TokenizeRE	=  "(" +
							   "(?<string1> \" ( ([\\][\"]) | [^\"] )* \" ) | " +
							   "(?<string2> \' ( ([\\][\']) | [^\'] )* \' ) | " +
							   "(?<word> [^ \t\r\n]+ ) | " +
							   "(?<space> \\s+ )" +
							   ")" ;

		public CommandInputEventArgs  ( String  cmd )
		   { 
			Command = cmd ; 
			ParseCommand ( cmd ) ;
		    }


		/// <summary>
		/// Parses a command string into command arguments (very simple parsing).
		/// </summary>
		private void  ParseCommand ( String  command )
		   {
			List<String>		Args		=  new List<String> ( ) ;
			Regex			re		=  new Regex ( TokenizeRE, RegexOptions. IgnorePatternWhitespace ) ;
			MatchCollection		matches		=  re. Matches ( command ) ;


			foreach ( Match  match  in  matches )
			  {
				String		text	=  match. Value ;

				if  ( text. Trim ( )  ==  "" ) 
					continue ;

				if  ( text [0]  ==  '"' )
					text	=  Unstring ( text, '"' ) ;
				else if  ( text [0]  ==  '\'' )
					text	=  Unstring ( text, '\'' ) ;

				Args. Add ( text ) ;
			   }

			Argc		=  Args. Count ;
			Argv		=  Args. ToArray<String> ( ) ;
		    }


		/// <summary>
		/// Removes quotes from a string parameter.
		/// </summary>
		private String  Unstring ( String  text, char  quote )
		   {
			if  ( text [0]  ==  quote )
				text	=  text. Substring ( 1 ) ;

			if  ( text. Length  >  0  &&  text [ text. Length - 1 ]  ==  quote )
				text	=  text. Substring ( 0, text. Length - 1 ) ;

				String  q = quote.ToString ( ) ;
			text = text. Replace ( "\\" + quote. ToString ( ), quote. ToString ( ) ) ;

			return ( text ) ;
		    }
	    }
	# endregion
    }
