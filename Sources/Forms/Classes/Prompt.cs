/**************************************************************************************************************

    NAME
        Prompt.cs

    DESCRIPTION
        Prompt class for ShellForm components.

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


namespace Thrak. Forms
   {
	/// <summary>
	/// Generic class for a ShellForm window prompt.
	/// </summary>
	public class  Prompt
	   {
		private String		p_Text ;


		/// <summary>
		/// Default constructor.
		/// </summary>
		public  Prompt ( String  text  =  "" )
		   {
			p_Text	=  text ;
		    }


		/// <summary>
		/// Gets/sets the prompt text.
		/// </summary>
		public String  Text 
		   {
			get { return ( GetText ( ) ) ; }
			set { SetText ( value ) ; }
		    }


		/// <summary>
		/// Returns the real prompt text.
		/// </summary>
		protected virtual String  GetText ( )
		   { return ( p_Text ) ; }


		/// <summary>
		/// Sets the real prompt text.
		/// </summary>
		protected virtual void  SetText ( String  newtext )
		   { p_Text = newtext ; }
	    }
    }
