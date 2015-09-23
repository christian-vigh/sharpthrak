/**************************************************************************************************************

    NAME
        WinAPI.cs

    DESCRIPTION
        Windows native methods (based on Microsoft source).

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/11]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;

using   Thrak. Core ;


namespace Thrak. WinAPI
   {
	# region Enumerations
	public enum  WindowsArchitecture
	   {
		Windows32Bits		=  0,
		Windows64Bits		=  1
	    }


	// Windows version ; don't care of Win9x/ME and previous versions because we will never run on them !
	// This enum helps mapping the version found in the Environment.OsVersion class with the constants used
	// in the Winuser.h file
	public enum  WindowsVersion 
	   {
		Windows7		=  0x0601,
		WindowsServer2008	=  0x0600,
		WindowsVista		=  0x0600,
		WindowsServer2003SP1	=  0x0502,
		WindowsXPSP2		=  0x0502,
		WindowsServer2003	=  0x0501,
		WindowsXP		=  0x0501,
		Windows2000		=  0x0500,
		WindowsNT40		=  0x0400,
		Windows95		=  0x0400,
		Windows98		=  0x0410,
		WindowsNT351		=  0x0410,
		WindowsME		=  0x0400,
		Windows			=  0x0400,
		Default			=  Windows2000,		// Used when current version could not be determined (as of Winuser.h)
		Any			=  0xFFFF		// Indicates that any Windows version is supported (not stored in OSVersion property)
	    }
	# endregion


	# region Types

	# endregion


	/// <summary>
	/// Class that provides facilities for interoperability between .NET and the Windows API.
	/// </summary>
	public static class  Support
	   {
		# region Private data members
		private static WindowsArchitecture	p_WindowsArchitecture ;		// OS architecture
		private static WindowsVersion		p_WindowsVersion ;		// OS version
		# endregion


		# region Exceptions

		# region InvalidWindowsTargetException
		/// <summary>
		/// Exception raised when an API function is called on a wrong version of Windows.
		/// </summary>
		private class  InvalidWindowsTargetException  :  ThrakException
		   {
			public InvalidWindowsTargetException ( WindowsVersion   ExpectedVersion, 
							       WindowsVersion   FoundVersion )
					: base ( "Wrong Windows platform (\"" + FoundVersion. ToString ( ) +
							"\") ; Expected version is : " + ExpectedVersion. ToString ( ) + "." )
			   { }
		    }
		# endregion

		# endregion


		# region Class constructor
		static Support ( )
		   {
			GetOSArchitecture ( ) ;
			GetOSVersion ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the OS architecture (32 or 64 bits).
		/// </summary>
		public static WindowsArchitecture  OSArchitecture
		   {
			get { return ( p_WindowsArchitecture ) ; }
		    }


		/// <summary>
		/// Gets the OS version, as used in Winuser.h
		/// </summary>
		public static WindowsVersion  OSVersion
		   {
			get { return ( p_WindowsVersion ) ; }
		    }
		# endregion


		# region Internal support functions
		/// <summary>
		/// Retrieves the OS architecture (32 or 64 bits).
		/// </summary>
		private static void GetOSArchitecture ( )
		   {
			String		Architecture		=  Environment. GetEnvironmentVariable ( "PROCESSOR_ARCHITECTURE" ) ;

			if  ( Architecture  ==  String. Empty  ||  String. Compare ( Architecture, 0, "x86", 0, 3, true )  ==  0 )
				p_WindowsArchitecture	=  WindowsArchitecture. Windows32Bits ;
			else
				p_WindowsArchitecture   =  WindowsArchitecture. Windows64Bits ;
		    }

		
		/// <summary>
		/// Retrieves the OS version, such as used for the WINVER macro of the Winuser.h include file.
		/// </summary>
		private static void GetOSVersion ( )
		   {
			WindowsVersion		Result		=  WindowsVersion. Windows ;


			switch ( Environment. OSVersion. Platform )
			   {
				case  PlatformID. Win32Windows :
					switch ( Environment. OSVersion. Version. Minor )
					   {
						case	0 :
							Result = WindowsVersion. Windows95 ;
							break ;

						case	10 :
							Result = WindowsVersion. Windows98 ;
							break ;

						case	90 :
							Result = WindowsVersion. WindowsME ;
							break ;
					    }
					break ;

				case  PlatformID. Win32NT :
					switch ( Environment. OSVersion. Version. Major )
					   {
						case	3 :
							Result = WindowsVersion. WindowsNT351 ;
							break ;

						case	4 :
							Result = WindowsVersion. WindowsNT40 ;
							break ;

						case	5 :
							if (  Environment. OSVersion. Version. Minor  ==  0 )
								Result = WindowsVersion. Windows2000 ;
							else
								Result = WindowsVersion. WindowsXP ;
							break ;

						case	6 :
							if  ( Environment. OSVersion. Version. Minor  ==  0 )
								Result = WindowsVersion. WindowsVista ;
							else
								Result = WindowsVersion. Windows7 ;
							break ;
					    }
					break ;
			    }

			p_WindowsVersion = Result ;
		    }
		# endregion

	    }
    }