/**************************************************************************************************************

    NAME
        Log.cs

    DESCRIPTION
        description.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/10]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. IO ;
using	System. Text ;

using   Thrak. Core. Assembly ;


namespace Thrak. Core
   {
	# region LogException class
	/// <summary>
	/// Exception that can be thrown by the Log class.
	/// </summary>
	public class  LogException	:  ThrakException
	   {
		public LogException ( String  message, params Object []  argv )
				: base ( String. Format ( message, argv ) )
		   { }
	    }
	# endregion


	/// <summary>
	/// Log class. Provides a simple, multi-threadead mechanism for logging time-stamped messages in a log file.
	/// Throws a LogException exception in the following cases :
	/// - The directory supposed to contain the log file does not exist.
	/// - The log file could not be created.
	/// </summary>
	public class Log
	   {
		# region Private data members
		private String		m_LogFile ;					// Log file name
		private int		m_LogLevel		=  0 ;			// Logging level. Any message with a level less than or equal will be logged
		private Boolean		m_LogAppend		=  false ;		// When true, new messages are appended to the log. When false, the log is recreated
		private static Object	m_Lock			=  new Object ( ) ;	// Object used to ensure that only one thread at a time will write to the log file.
		#  endregion


		# region Constructors and destructor
		/// <summary>
		/// Creates a log object with a logfile whose name will be the application name (with the ".log" extension) located in the Windows
		/// temp directory.
		/// </summary>
		/// <param name="loglevel">Log level. Only the messages having a log level less than or equal to this parameter will be logged.</param>
		/// <param name="append">When false, the log file is recreated. When true, new messages are appended to the existing log file.</param>
		public Log ( int  loglevel = 0, Boolean  append = false )
		   {
			String		TempPath = GetTempPath ( ) ;

			TempPath	+= ApplicationAssembly. ApplicationName + ".log" ;
			Initialize ( TempPath, loglevel, append ) ;
		    }


		/// <summary>
		/// Creates a log object. If the log file name does not contain any directory information, it will be placed in the Windows
		/// temp directory.
		/// </summary>
		/// <param name="logfile">Log file name.</param>
		/// <param name="loglevel">Log level. Only the messages having a log level less than or equal to this parameter will be logged.</param>
		/// <param name="append">When false, the log file is recreated. When true, new messages are appended to the existing log file.</param>
		public Log ( String  logfile, int  loglevel = 0, Boolean append = false )
		   {
			Initialize ( logfile, loglevel, append ) ;
		    }


		/// <summary>
		/// Initializes the Log object. Called by the class constructors. Puts the "APPLICATION STARTED" message in the log file.
		/// </summary>
		private void  Initialize ( String  logfile, int  loglevel, Boolean  append = false )
		   {
			this. LogLevel		=  loglevel ;
			this. m_LogAppend	=  append ;
			this. LogFile		=  logfile ;
			Write ( "****** APPLICATION STARTED : \"" + ApplicationAssembly. ApplicationName + "\" ******" ) ;
		    }


		/// <summary>
		/// Puts the "APPLICATION ENDED" message in the log file before destroying the object.
		/// </summary>
		~Log ( )
		   {
			Write ( "****** APPLICATION ENDED   : \"" + ApplicationAssembly. ApplicationName + "\" ******" ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the maximum level allowed for logging messages.
		/// </summary>
		public int  LogLevel 
		   {
			get { return ( m_LogLevel ) ; }
			set { m_LogLevel = value ; }
		    }

		/// <summary>
		/// Gets/sets the output log file name. Note that the set() method is private.
		/// </summary>
		public String  LogFile 
		   {
			get { return ( m_LogFile ) ; }
			private set 
			   { 
				String		Dir		=  Path. GetDirectoryName ( value ) ;

				// If no directory part, then assume that the output log file is located in the Windows temp directory.
				if  ( Dir  ==  String. Empty )
				   {
					value = GetTempPath ( ) + value ;
				    }
				// Check that the directory part exists
				else if  ( ! Directory. Exists ( Dir ) )
					throw new LogException ( "The directory specified for the log file name ({0}) does not exist." ) ;

				// Then try to create the log file.
				Boolean			CreateFile		= ! m_LogAppend ;

				if  ( m_LogAppend )
				   {
					if  ( ! File. Exists ( value ) )	// If append mode but the file does not exist...
						CreateFile = true ;		// ... then we will need to create the file to verify that its name is correct
				    }
				
				if  ( CreateFile )
				   {
					try
					   {
						File. Create ( value ). Close ( ) ;
					    }
					catch 
					   {
						throw new LogException ( "Unable to create log file {0}.", value ) ;
					    }
				    }

				// All done, save the log file name and return.
				m_LogFile = value ;
			    }
		    }
		# endregion


		# region Log writing functions
		/// <summary>
		/// Logs a message to the log file, taking into account the message log level.
		/// </summary>
		/// <param name="level">Message level. If this level exceeds the value of the LogLevel property, it won't be logged.</param>
		/// <param name="message">Message to be logged.</param>
		/// <param name="argv">Additional parameters to be passed to the String.Format() function.</param>
		public void  Write ( int  level, String  message, params Object []  argv )
		   {
			if  ( level  <=  m_LogLevel )
				Write ( message, argv ) ;
		    }


		/// <summary>
		/// Logs a message to the log file. This function logs all messages, whatever the value of the LogLevel property is.
		/// </summary>
		/// <param name="message">Message to be logged.</param>
		/// <param name="argv">Additional parameters to be passed to the String.Format() function.</param>
		public void  Write ( String  message, params Object []  argv )
		   {
			lock ( m_Lock )
			   {
				StreamWriter		fp		=  File. AppendText ( m_LogFile ) ;
				String			FinalMessage	=  String. Format ( message, argv ) ;
				String			TimeStamp	=  String. Format ( "{0:yyyy/MM/dd HH:mm:ss.fff}", DateTime. Now ) ;

				fp. WriteLine ( "[" + TimeStamp + "] " + FinalMessage ) ;
				fp. Close ( ) ;
			    }
		    }
		# endregion


		# region Support functions
		/// <summary>
		/// Returns the Windows temp directory, ensuring that it contains a trailing backslash ("\\").
		/// </summary>
		private String  GetTempPath ( )
		   {
			String		TempPath = Path. GetTempPath ( ) ;

			if  ( ! TempPath. EndsWith ( "\\" ) ) 
				TempPath += "\\" ;

			return ( TempPath ) ;			
		    }
		# endregion
	    }
    }
