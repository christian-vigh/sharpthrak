/**************************************************************************************************************

    NAME
        Parsing.cs

    DESCRIPTION
        Generic methods for string parsing.

    AUTHOR
        Christian Vigh, 01/2016.

    HISTORY
    [Version : 1.0]    [Date : 2016/01/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Text ;
using   System. Xml ;


namespace Thrak. Processors
   {
	public static class Parsing
	   {
		/// <summary>
		/// Interprets a string as a list of name="value" pairs, such as for Xml attributes.
		/// </summary>
		/// <param name="value">String value to be parsed.</param>
		/// <returns>A dictionary containing the name/value pairs, or null if the string is syntactically incorrect.</returns>
		public static Dictionary<string,string>  ParseXmlAttributes ( string  value )
		   {
			Dictionary<string,string>	result	=  new Dictionary<string,string> ( StringComparer. OrdinalIgnoreCase ) ;
			XmlDocument			doc	=  new XmlDocument ( ) ;

			try
			   {
				doc. LoadXml ( "<junk " + value + "></junk>" ) ;

				foreach  ( XmlAttribute  attr  in  doc. DocumentElement. Attributes )
					result [ attr. Name ]	 =  attr. Value ;
			    }
			catch
			   { return ( null ) ; }

			return ( result ) ;
		    }
	    }
    }
