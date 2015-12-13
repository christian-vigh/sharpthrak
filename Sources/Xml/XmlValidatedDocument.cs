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
# region	Base types and enumerations
	// Just an alias...
	using	XmlParseErrors	=  List<XmlParseError> ;


	/// <summary>
	/// Identifies the parsing step
	/// </summary>
	public enum  XmlParseStep
	   {
		XmlParsing,			// Basic parsing of xml data (using LoadXml)
		XsdValidation,			// Xsd document syntax validation
		XmlValidation,			// Xml validation using the specified xsd data
		UserValidation			// Errors or informational messages can later be added by a derived class,
						// using the AddUserError() method
	    }


	/// <summary>
	/// Error severities. Warning and Error match the XmlSeverityType constants ; the other ones 
	/// can be specified when performing user validation ("user validation" means "validation by a derived class").
	/// </summary>
	public enum  XmlParseErrorSeverity
	   {
		Warning			=  XmlSeverityType. Warning,
		Error			=  XmlSeverityType. Error,
		Informational,
		Notice,
		Fatal
	    }


	/// <summary>
	/// A structure that unifies xml/xsd parsing/validation errors.
	/// </summary>
	public class	XmlParseError	
	   {
		public XmlParseStep		Step		{ get ; internal set ; }
		public XmlParseErrorSeverity	Severity	{ get ; internal set ; }
		public string			Message		{ get ; internal set ; }
		public int			Line		{ get ; internal set ; }
		public int			Column		{ get ; internal set ; }
		public string			Source		{ get ; internal set ; }
		public string			SourceUri	{ get ; internal set ; }
	    }
# endregion


	# region	XmlValidatedDocument
	/// <summary>
	/// The XmlValidatedDocument class serves the purpose of loading an Xml document, knowing that all
	/// validation steps have been performed.
	/// Once loaded, the boolean IsValid flag will reflect whether errors have been encountered or node.
	/// The ValidationMessages list will contain the list of information, warning, error... messages.
	/// </summary>
	public class XmlValidatedDocument	:  XmlDocument
	    {
		// Xml and Xsd data specified to the constructor
		public string	XmlData ;
		public string	XsdData ;

		// Message list
		public XmlParseErrors	ValidationMessages	{ get ; protected set ; }
		// Indicates if errors were encountered
		public bool		IsValid			{ get ; protected set ; }


		# region	Constructor
		/// <summary>
		/// Builds and validates an Xml document.
		/// </summary>
		/// <param name="xml_data">Xml contents, specified as a string</param>
		/// <param name="xsd_data">Xsd specifications, specified as a string</param>
		public XmlValidatedDocument ( string		xml_data, 
					      string		xsd_data	=  null ) : base ( )
		    {
			// Initilizations
			IsValid			=  true ;			// Consider that by default the document is valid until some crap is found
			ValidationMessages	=  new XmlParseErrors ( ) ;
			XmlData			=  xml_data ;			// Remember supplied parameters
			XsdData			=  xsd_data ;
			
			// Step 1 : load xml data
			try
			   {
				LoadXml ( xml_data ) ;
			    }
			// Catch parsing errors such as opening/closing tag mismatch, or attribute with no value
			catch ( XmlException  e )
			   {
				XmlParseError	pe	=  new XmlParseError ( ) ;

				IsValid			=  false ;
				pe. Step		=  XmlParseStep. XmlParsing ;
				pe. Severity		=  XmlParseErrorSeverity. Error ;
				pe. Message		=  e. Message ;
				pe. Line		=  e. LineNumber ;
				pe. Column		=  e. LinePosition ;
				pe. Source		=  e. Source ;
				pe. SourceUri		=  e. SourceUri ;

				ValidationMessages. Add ( pe ) ;
			    }

			// Stop here if step 1 failed : validation cannot be performed on syntactically incorrect xml data
			if  ( ! IsValid ) 
				return ;

			// Perform steps 2 (Xsd validation) and 3 (Xml validation using Xsd) only if xsd data has been specified
			if  ( xsd_data  !=  null )
			   { 
				// Step 2 : Validate the xsd itself before using it for validating the xml...
				XmlSchema		schema		=  XmlSchema. Read
				   (
					new StringReader ( xsd_data ),
					( object  sender, ValidationEventArgs  e ) =>
					   {
						XmlParseError	pe	=  new XmlParseError ( ) ;

						pe. Step		=  XmlParseStep. XsdValidation ;
						pe. Severity		=  ( XmlParseErrorSeverity ) e. Severity ;
						pe. Message		=  e. Message ;
						pe. Line		=  e. Exception. LineNumber ;
						pe. Column		=  e. Exception. LinePosition ;
						pe. Source		=  e. Exception. Source ;
						pe. SourceUri		=  e. Exception. SourceUri ;

						ValidationMessages. Add ( pe ) ;
						SetValidState ( pe. Severity ) ;
					     }
				    ) ;

				// Stop here if xsd contain errors : we will not be able to use it for xml validation anyway
				if  ( ! IsValid )
					return ;

				// Step 3 : validate the xml document using the xsd schema
				Schemas. Add ( schema ) ;
		
				Validate
				   ( 
					( object  sender, ValidationEventArgs  e ) =>
					   {
						XmlParseError	pe	=  new XmlParseError ( ) ;

						pe. Step		=  XmlParseStep. XmlValidation ;
						pe. Severity		=  XmlParseErrorSeverity. Error ;
						pe. Message		=  e. Message ;
						pe. Line		=  e. Exception. LineNumber ;
						pe. Column		=  e. Exception. LinePosition ;
						pe. Source		=  e. Exception. Source ;
						pe. SourceUri		=  e. Exception. SourceUri ;

						ValidationMessages. Add ( pe ) ;				   
						SetValidState ( pe. Severity ) ;
					    }
				    ) ;

				// Stop here if validation failed ; there is no need to perform user processing at that stage
				if  ( ! IsValid )
					return ;
			    }

			// Step 4 : everything went smooth (perhaps we had some informational or warning messages), so
			//          we can perform user processing.
			ValidateStructure ( ) ;
		     }
		# endregion


		# region	Protected stuff
		/// <summary>
		/// Derived classes can call AddUserError() to add errors or warnings or else to the existing list
		/// of parsing/validation errors.
		/// The IsValid flag will be set to false if error severity is Error or Fatal.
		/// </summary>
		/// <param name="severity">Error severity</param>
		/// <param name="message">Message</param>
		/// <param name="line">Source line</param>
		public void  AddValidationMessage ( XmlParseErrorSeverity  severity, string  message, int  line = 0 )
		   {
			XmlParseError	pe	=  new XmlParseError ( ) ;

			pe. Step		=  XmlParseStep. UserValidation ;
			pe. Severity		=  severity ;
			pe. Message		=  message ;
			pe. Line		=  line ;
			pe. Column		=  0 ;
			pe. Source		=  "xml document" ;
			pe. SourceUri		=  "xml document" ;

			ValidationMessages. Add ( pe ) ;				   
			SetValidState ( pe. Severity ) ;
		    }


		/// <summary>
		/// Called to validate xml contents after all the validation steps have been performed.
		/// Override this to perform all the checkings that cannot be enforced by xml parsing and 
		/// schema validation.
		/// This method is not abstract, so you are free NOT to implement it.
		/// Should you implement it, feel free to call the AddValidationMessage() method each time
		/// you have an information, warning or error to add to the validation message list.
		/// </summary>
		protected virtual void  ValidateStructure ( )
		   { }
		# endregion


		# region	Private methods
		/// <summary>
		/// Sets the IsValid flag to false if the specified error severity is either Error or Fatal.
		/// </summary>
		private void  SetValidState ( XmlParseErrorSeverity  severity )
		   {
			if  ( IsValid  &&  
			      ( severity  ==  XmlParseErrorSeverity. Error  ||  severity  ==  XmlParseErrorSeverity. Fatal ) )
				IsValid		=  false ;
		    }
		# endregion
	     }
	# endregion
   }

