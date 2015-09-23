/**************************************************************************************************************

    NAME
        Exception.cs

    DESCRIPTION
        Generic exception class for the Thrak library.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/10]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Text ;


namespace Thrak. Core
   {
	/// <summary>
	/// Implements a standard exception class for the Thrak library.
	/// </summary>
	public class ThrakException : Exception
	   {
		/// <summary>
		/// Throws an exception without message.
		/// </summary>
		public ThrakException ( )
				: base ( )
		   { }


		/// <summary>
		/// Throws an exception with the specified message.
		/// </summary>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		public ThrakException ( String  message )
				: base ( message )
		   { }


		/// <summary>
		/// Throws an exception with the specified message.
		/// </summary>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		/// <param name="argv">Additional parameters for String.Format().</param>
		public ThrakException ( String  message, params Object []  argv )
				: base ( String. Format ( message, argv ) )
		   { }


		/// <summary>
		/// Throws an exception with the specified inner exception and message.
		/// </summary>
		/// <param name="inner">Inner exception.</param>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		/// <param name="argv">Additional parameters for String.Format().</param>
		public ThrakException ( Exception  inner, String  message, params Object []  argv )
				: base ( String. Format ( message, argv ), inner )
		   { }
	    }
    }
