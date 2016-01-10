/**************************************************************************************************************

    NAME
        InputBox.cs

    DESCRIPTION
        Displays an input box and returns the user-supplied input value.

    AUTHOR
        Christian Vigh, 01/2016.

    HISTORY
    [Version : 1.0]    [Date : 2016/01/08]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text ;
using	System. Windows. Forms ;
using   System. Drawing ;

using   Thrak. Forms ;


namespace Thrak. Input
   {
	using	WindowsForm		=  System. Windows. Forms. Form ;


	public static class InputBox
	   {
		# region Show() functions without default value and without parent form
		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message, 
					     string		title = null )
		   {
			return ( DoShow ( null, message, String. Empty, title, FormStartPosition. CenterScreen ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <param name="start_position">Start position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     string		title			=  null,
					     FormStartPosition	start_position		=  FormStartPosition. CenterParent )
		   {
			return ( DoShow ( null, message, String. Empty, title, start_position ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="position">Box position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     Point		position )
		   {
			return ( DoShow ( null, message, String. Empty, null, FormStartPosition. Manual, position. X, position. Y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <param name="position">Box position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     string		title,
					     Point		position )
		   {
			return ( DoShow ( null, message, String. Empty, title, FormStartPosition. Manual, position. X, position. Y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="x">Box position (X)</param>
		/// <param name="y">Box position (Y)</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     int		x,
					     int		y )
		   {
			return ( DoShow ( null, message, String. Empty, null, FormStartPosition. Manual, x, y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <param name="x">Box position (X)</param>
		/// <param name="y">Box position (Y)</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     string		title,
					     int		x,
					     int		y )
		   {
			return ( DoShow ( null, message, String. Empty, title, FormStartPosition. Manual, x, y ) ) ;
		    }
		# endregion

		# region Show() functions without default value and with parent form
		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message, 
					     string		title = null )
		   {
			return ( DoShow ( form, message, String. Empty, title, FormStartPosition. CenterScreen ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <param name="start_position">Start position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     string		title			=  null,
					     FormStartPosition	start_position		=  FormStartPosition. CenterParent )
		   {
			return ( DoShow ( form, message, String. Empty, title, start_position ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="position">Box position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     Point		position )
		   {
			return ( DoShow ( form, message, String. Empty, null, FormStartPosition. Manual, position. X, position. Y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <param name="position">Box position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     string		title,
					     Point		position )
		   {
			return ( DoShow ( form, message, String. Empty, title, FormStartPosition. Manual, position. X, position. Y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="x">Box position (X)</param>
		/// <param name="y">Box position (Y)</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     int		x,
					     int		y )
		   {
			return ( DoShow ( form, message, String. Empty, null, FormStartPosition. Manual, x, y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="title">Box title</param>
		/// <param name="x">Box position (X)</param>
		/// <param name="y">Box position (Y)</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     string		title,
					     int		x,
					     int		y )
		   {
			return ( DoShow ( form, message, String. Empty, title, FormStartPosition. Manual, x, y ) ) ;
		    }
		# endregion

		# region Show() functions with default value and without parent form
		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message, 
					     string		default_value,
					     string		title = null )
		   {
			return ( DoShow ( null, message, default_value, title, FormStartPosition. CenterScreen ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <param name="start_position">Start position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     string		default_value,
					     string		title			=  null,
					     FormStartPosition	start_position		=  FormStartPosition. CenterParent )
		   {
			return ( DoShow ( null, message, default_value, title, start_position ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <param name="position">Box position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     string		default_value,
					     string		title,
					     Point		position )
		   {
			return ( DoShow ( null, message, default_value, title, FormStartPosition. Manual, position. X, position. Y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <param name="x">Box position (X)</param>
		/// <param name="y">Box position (Y)</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( string		message,
					     string		default_value,
					     string		title,
					     int		x,
					     int		y )
		   {
			return ( DoShow ( null, message, default_value, title, FormStartPosition. Manual, x, y ) ) ;
		    }
		# endregion

		# region Show() functions without default value and with parent form
		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message, 
					     string		default_value,
					     string		title = null )
		   {
			return ( DoShow ( form, message, default_value, title, FormStartPosition. CenterScreen ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <param name="start_position">Start position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     string		default_value,
					     string		title			=  null,
					     FormStartPosition	start_position		=  FormStartPosition. CenterParent )
		   {
			return ( DoShow ( form, message, default_value, title, start_position ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <param name="position">Box position</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     string		default_value,
					     string		title,
					     Point		position )
		   {
			return ( DoShow ( form, message, default_value, title, FormStartPosition. Manual, position. X, position. Y ) ) ;
		    }


		/// <summary>
		/// Shows an input box.
		/// </summary>
		/// <param name="form">Parent form</param>
		/// <param name="message">Prompt message</param>
		/// <param name="default_value">Default value</param>
		/// <param name="title">Box title</param>
		/// <param name="x">Box position (X)</param>
		/// <param name="y">Box position (Y)</param>
		/// <returns>The supplied input string or null if the user pressed the Cancel button</returns>
		public static string  Show ( WindowsForm	form,
					     string		message,
					     string		default_value,
					     string		title,
					     int		x,
					     int		y )
		   {
			return ( DoShow ( form, message, default_value, title, FormStartPosition. Manual, x, y ) ) ;
		    }
		# endregion


		/// <summary>
		/// Handles the whole stuff of displaying the input box and returning the results.
		/// </summary>
		private static string  DoShow   ( WindowsForm		parent,
						  string		message,
						  string		default_value,
						  string		title,
						  FormStartPosition	start_position,
						  int			x		=  -1,
						  int			y		=  -1 )
		   {
			InputBoxForm	form		=  new InputBoxForm ( ) ;

			if  ( message  !=  null )
				form. MessageLabel. Text		=  message ;

			if  ( title  !=  null )
				form. Text				=  title ;

			form. MessageInputTextbox. Text		=  default_value ;
			form. StartPosition			=  start_position ;

			if  ( x  !=  - 1  &&  y  !=  -1 )
				form. Location	=  new Point ( x, y ) ;

			form. ShowDialog ( parent ) ;

			if  ( form. DialogResult  ==  DialogResult. OK )
				return ( form. MessageInputTextbox. Text ) ;
			else
				return ( String. Empty ) ;
		    }
						 
	    }
    }
