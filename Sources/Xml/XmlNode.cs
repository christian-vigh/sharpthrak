/**************************************************************************************************************

    NAME
	XmlValidatedDocument.cs

    DESCRIPTION
	Implements an XmlDocument that validates contents against an xsd schema.

    AUTHOR
	Christian Vigh, 12/2015.

    HISTORY
	[Version : 1.0]		[Date : 2015/012/11]     [Author : CV]
		Initial version.

 **************************************************************************************************************/
using  System;
using  System. Collections. Generic ;
using  System. IO ;
using  System. Linq ; 
using  System. Reflection ;
using  System. Text ;
using  System. Threading. Tasks ;
using  System. Xml ;
using  System. Xml. Schema ;
using  System. Xml. XPath ;


namespace Thrak. Xml
   {
	# region	XmlNode extensions
	/// <summary>
	/// Provides extension functions for the XmlNode class.
	/// </summary>
	static class	XmlNodeExtensions
	   {
		# region	Methods for partial conversions to string
		/// <summary>
		/// Returns the specified attribute as a string (ie, attr="value").
		/// </summary>
		/// <param name="attr">XmlAttribute item to be converted.</param>
		public static string  GetAttributeAsString ( this XmlNode  node, XmlAttribute  attr )
		   { return ( GetAttributeAsString ( node, attr. Name, attr. Value ) ) ; }


		/// <summary>
		/// Returns the specified attribute as a string (ie, attr="value").
		/// </summary>
		/// <param name="attr">Name of the attribute to be converted.</param>
		/// <returns>
		///	The specified attribute definition, or null if <paramref name="attr"/> does not exist.
		/// </returns>
		public static string  GetAttributeAsString ( this XmlNode  node, string  name )
		   {
			if  ( node. Attributes. Count  ==  0 )	
				return ( null ) ;
			else
			   {
				XmlAttribute	attr	=  node. Attributes [ name ] ;

				if  ( attr  ==  null )
					return ( null ) ;
				else
					return ( GetAttributeAsString ( node, attr. Name, attr. Value ) ) ;
			    }
		    }

		
		/// <summary>
		/// Returns the specified attribute name and value, as an xml definition.
		/// <para>
		/// Concerning value quoting, the following rules apply :
		/// <list type="-">
		///	<item>
		///		<paramref name="value"/> contains single quotes, or not quotes at all : 
		///		double quotes will be used to quote the value.
		///	</item>
		///	<item>
		///		<paramref name="value"/> contains double quotes : 
		///		single quotes will be used to quote the value.
		///	</item>
		///	<item>
		///		<paramref name="value"/> contains both single and double quotes : 
		///		double quotes will be replaced by the &amp;lquot; html entity and the
		///		value will be quoted using double quotes.
		///	</item>
		/// </list>
		/// </para>
		/// </summary>
		/// <param name="node"></param>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string  GetAttributeAsString ( this XmlNode  node, string  name, string  value )
		   {
			int	has_quotes		=  value. IndexOf ( '\'' )  ;
			int	has_doublequotes	=  value. IndexOf ( '"' ) ;
			char	quote			=  '"' ;


			// If the value has both quotes and doublequotes, sacrify the doublequotes and replace them
			// with the &quot; html entity 
			if  ( has_quotes  >=  0  &&  has_doublequotes  >=  0 )
				value		=  value. Replace ( "\"", "&quot;" ) ;
			// Otherwise, change the quoting character to "'" if doublequotes are present
			else if  ( has_doublequotes  >=  0 )
				quote		=  '\'' ;

			return ( name + '=' + quote + value + quote ) ;
		    }

		/// <summary>
		/// Returns a node's attributes as a string.
		/// </summary>
		public static string  GetAttributesAsString ( this XmlNode  node )
		   {
			List<string>	attributes	=  new List<string> ( ) ;

			foreach  ( XmlAttribute  attr  in  node. Attributes )
				attributes. Add ( GetAttributeAsString ( node, attr ) ) ;
				
			string		result		=  String. Join ( " ", attributes ) ;

			if  ( string. IsNullOrWhiteSpace ( result ) )
				return ( String. Empty ) ;
			else
				return ( result ) ;
		    }


		/// <summary>
		/// Gets an attribute value, catching all exceptions.
		/// </summary>
		/// <param name="name">Attribute name.</param>
		/// <param name="default_value">Default value to use if the attribute does not exist.</param>
		/// <returns>The attribute value.</returns>
		public static string  GetAttributeValue ( this XmlNode  node, string  name, string  default_value = "" )
		   {
			if  ( node. Attributes. Count  !=  0 )
		 	   {
				if  ( node. Attributes  [ name ]. Value  !=  null )
					return ( node. Attributes  [ name ]. Value. Trim ( ) ) ;
				else
					return ( default_value ) ;
			    }
			else
				return ( default_value ) ;
		    }


		/// <summary>
		/// Returns the starting xml node tag as a string, including its attributes.
		/// </summary>
		/// <param name="closed">When true</param>
		public static string  GetOpeningTag ( this XmlNode  node, bool  closed = false )
		   {
			string		end	=  ( closed ) ?  "/>" : ">" ;

			return ( "<" + node. Name + GetAttributesAsString ( node ) + end ) ;
		    }


		/// <summary>
		/// Returns the closing xml node tag.
		/// </summary>
		public static string  GetClosingTag ( this XmlNode  node )
		   {
			return ( "</" + node. Name + ">" ) ;
		    }
		# endregion

		# region	Node text-retrieval methods
		/// <summary>
		/// Gets the text contained in an xml node. This method is intended to retrieve the contents
		/// of multiline data such as :
		/// 
		///	&lt;mytag&gt;
		///		my tag contents.
		///	&lt;/mytag&gt;
		///	
		/// Normally, the Text method will extra spaces and newlines after the opening tag, as
		/// well as the extra spaces and newline before the closing tag. This method ensures that
		/// only the enclosed contents are returned (ie, the line containing "my tag contents").
		/// </summary>
		/// <returns>The xml node text.</returns>
		public static string  GetNodeText ( this XmlNode  node )
		   {
			string		text		=  node. InnerText ;
			int		start		=  0,
					end		=  text. Length - 1 ;

			if  ( String. IsNullOrEmpty ( text ) )
				return ( "" ) ;

			// Skip the potential cr+lf after the opening tag
			if  ( text [ start ]  ==  '\n'  ||  text [ start ]  ==  '\r' )
				start ++ ;

			if  ( text [ start ]  ==  '\n'  ||  text [ start ]  ==  '\r' )
				start ++ ;

			// Remove trailing whitespaces
			if  ( text [ end ]  ==  ' '  ||  text [ end ]  ==  '\t' )
			   {
				while  ( end  >  start  &&  ( text [ end ]  ==  ' '  ||  text [ end ]  ==  '\t' ) ) 
					end -- ;
			    }

			// Remove the very last crlf (make sure the last line doesn't end with spaces because
			// we will split the node text on newlines)
			if  ( text [ end ]  ==  '\n'  ||  text [ end ]  ==  '\r' )
				end -- ;

			if  ( text [ end ]  ==  '\n'  ||  text [ end ]  ==  '\r' )
				end -- ;

			if  ( start  >=  end )
				return ( String. Empty ) ;
			else
				return ( text. Substring ( start, end - start + 1 ) ) ;
		    }
		# endregion

		# region		Misc methods
		/// <summary>
		/// Returns the nesting level of the current node.
		/// </summary>
		/// <returns>Nesting level of the current node. The root node nesting level is 0.</returns>
		public static int	GetNestingLevel ( this XmlNode  node )
		   {
			int		nesting_level	=  0 ;
			XmlNode		nd		=  node. ParentNode ;
			
			while  ( nd  !=  null )
			   {
				nesting_level ++ ;
				nd	=  nd. ParentNode ;
			    }

			nesting_level -- ;	// Count one less, since the top level node is the XmlDocument itself

			return ( nesting_level ) ;
		    }
		# endregion

	     }
	# endregion
    }
