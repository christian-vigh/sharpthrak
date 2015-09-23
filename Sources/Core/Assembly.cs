/**************************************************************************************************************

    NAME
        Reflection.cs

    DESCRIPTION
        Provides methods for retrieving informations about the running application, such as application name, 
	version, etc.

    AUTHOR
        Christian Vigh, 07/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/07/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Reflection ;
using	System. IO ;


namespace Thrak. Core. Assembly
   {
	/// <summary>
	/// Architecture for which this application is compiled.
	/// </summary>
	public enum  Architecture
	   {
		/// <summary>
		/// Intel 32-bits architecture.
		/// </summary>
		x86			=  1,

		/// <summary>
		/// 64-bits architecture.
		/// </summary>
		x64			=  2 
	    }


	/// <summary>
	/// Provides information contained in the running assembly.
	/// </summary>
	public class ApplicationAssembly
 	   {
		# region Private data members
		// Assembly for which this runtime information is related to.
		static global::System. Reflection. Assembly		p_Assembly ;
		# endregion


		# region Constructor
		/// <summary>
		/// Builds Runtime object using the information defined for the running application.
		/// </summary>
		static ApplicationAssembly ( )
		   {
			// Initialize the library, if not yet done
			Library. Initialize ( ) ;

			// Get the current assembly
			p_Assembly = global::System. Reflection. Assembly. GetEntryAssembly ( ) ; 

			// If the entry is null, we may be have been called by a User32 (for example, a Visual Studio add-in), 
			// so assume the calling assembly is the top-level one.
			if  ( p_Assembly  ==  null )
				p_Assembly = global::System. Reflection. Assembly. GetCallingAssembly ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Returns the name of the application.
		/// </summary>
		 public static string  ApplicationName
		   {
			get { return ( global::System. IO. Path. GetFileNameWithoutExtension ( ApplicationPath ) ) ; }
		    }


		/// <summary>
		/// Returns the application title.
		/// </summary>
		 public static string ApplicationTitle
		   {
			get
			   {
				object []	attributes =  p_Assembly. GetCustomAttributes ( 
								typeof ( AssemblyTitleAttribute ), false ) ;

				
				// Obtain all the Title attributes for this assembly ;
				// If at least one title attribute exists...
				if ( attributes. Length > 0 )
				    {
					// Then select the first one
					AssemblyTitleAttribute	title = ( AssemblyTitleAttribute ) attributes [0] ;

					// If not empty, then return it
					if ( title. Title != "" )
						return ( title. Title ) ;
				    }

				// If not title exists, or is empty, then return file name without extension
				return ( ApplicationName ) ;
			    }
		    }


		/// <summary>
		/// Returns the full application executable path.
		/// </summary>
		 public static string ApplicationPath
		   {
			get { return ( p_Assembly. Location ) ; }
		    }


		/// <summary>
		/// Returns the assembly object to which these parameters are related.
		/// </summary>
		public global::System. Reflection. Assembly  AssemblyObject
		   {
			get { return ( p_Assembly ) ; }
		    }


		/// <summary>
		/// Returns the name of the company which developed the application.
		/// </summary>
		 public static string Company
		   {
			get
			   {
				object []	attributes = p_Assembly. GetCustomAttributes ( 
										typeof ( AssemblyCompanyAttribute ), false ) ;

				// If no Company attribute exist, return an empty string.
				if ( attributes. Length == 0 )
					return ( "" ) ;

				// Otherwise return its value
				return ( ( AssemblyCompanyAttribute ) attributes [0] ). Company ;
			    }
		    }

		
		/// <summary>
		/// Returns the application copyright string.
		/// </summary>
		 public static string Copyright
		   {
			get
			   {
				object []	 attributes = p_Assembly. GetCustomAttributes ( 
								typeof ( AssemblyCopyrightAttribute ), false ) ;

				// If no attribute exists, return an empty string
				if ( attributes. Length == 0 )
					return ( "" ) ;

				// Otherwise, return its value
				return ( ( AssemblyCopyrightAttribute ) attributes [0] ). Copyright ;
			   }
		    }

		
		/// <summary>
		/// Returns the description of the application.
		/// </summary>
		 public static string Description
		   {
			get
			   {
				object []	attributes = p_Assembly. GetCustomAttributes ( 
								typeof ( AssemblyDescriptionAttribute ), false ) ;

				// If not attributes exist, return an empty string
				if ( attributes. Length == 0 )
					return ( "" ) ;

				// Otherwise, return its value
				return ( ( AssemblyDescriptionAttribute ) attributes [0] ). Description ;
			    }
		    }

		
		/// <summary>
		/// Returns true if the application is running in design mode.
		/// </summary>
		 public static bool  DesignMode
		   {
			get
			   {
				if  ( System. Diagnostics. Process. GetCurrentProcess ( ). ProcessName  ==  "devenv" )
					return ( true ) ;
				  
				// Don't trust the DesignMode property of the application
				return ( 
						( global::System. ComponentModel. LicenseManager. UsageMode  == 
								global::System. ComponentModel. LicenseUsageMode. Designtime ) ) ;
			     }
		    }


		/// <summary>
		/// Returns the directory where the application executable file is installed.
		/// </summary>
		 public static string Directory
		   {
			get { return ( global::System. IO. Path. GetDirectoryName ( ApplicationPath ) ) ; }
		    }


		/// <summary>
		/// Returns the product name defined for the application.
		/// </summary>
		 public static string ProductName
		   {
			get
			   {
				object []	attributes = p_Assembly. GetCustomAttributes ( 
								typeof ( AssemblyProductAttribute ), false ) ;

				// If no Product attribute exist, return an empty string.
				if ( attributes. Length == 0 )
					return ( "" ) ;

				// Otherwise, return its value
				return ( ( AssemblyProductAttribute ) attributes [0] ). Product ;
			    }
		    }


		/// <summary>
		/// Returns the target architecture (32- or 64-bits).
		/// </summary>
		public static Architecture  TargetArchitecture
		   {
			get
			   {
				if  ( IntPtr. Size  ==  8 )
					return ( Architecture. x64 ) ;
				else
					return ( Architecture. x86 ) ;
			    }
		    }


		/// <summary>
		/// Returns the full version number.
		/// </summary>
		public static string  Version 
		   {
			get { return ( p_Assembly. GetName ( ). Version. ToString ( ) ) ; }
		    }


		/// <summary>
		/// Returns the minor version number.
		/// </summary>
		public static string  VersionMinor 
		   {
			get { return ( p_Assembly. GetName ( ). Version. Minor. ToString ( ) ) ; }
		    }


		/// <summary>
		/// Returns the major version number.
		/// </summary>
		public static string  VersionMajor 
		   {
			get { return ( p_Assembly. GetName ( ). Version. Major. ToString ( ) ) ; }
		    }


		/// <summary>
		/// Returns the version revision number.
		/// </summary>
		public static string  VersionRevision 
		   {
			get { return ( p_Assembly. GetName ( ). Version. Revision. ToString ( ) ) ; }
		    }


		/// <summary>
		/// Returns the version build number.
		/// </summary>
		public static string  VersionBuild
		   {
			get { return ( p_Assembly. GetName ( ). Version. Build. ToString ( ) ) ; }
		    }
		# endregion


		# region Type handling methods
		/// <summary>
		/// Evaluates the <paramref name="value"/> parameter and tries to convert it
		/// to an object of type <paramref name="value_type"/>.
		/// </summary>
		/// <param name="value_type">Destination type.</param>
		/// <param name="value">String value to convert.</param>
		/// <returns>An object having the specified type.</returns>
		public static Object  AsValue ( Type  value_type, String  value )
		   {
			// Special case for enums : the attribute string is an enum
			// so try to convert it to a constant
			if  ( value_type. IsEnum )
				return ( Enum. Parse ( value_type, value, true ) ) ;
			// Otherwise, try a direct type casting
			else
				return ( Convert. ChangeType ( value, value_type ) ) ;
		    }


		/// <summary>
		/// Returns a Type object corresponding to a type name expressed as a string.
		/// </summary>
		/// <param name="typename">Name of the type.</param>
		/// <returns>The type object corresponding to <paramref name="typename"/>.</returns>
		public static Type  AsType ( String  typename )
		   {
			switch ( typename. Trim ( ). ToLower ( ) )  
			   {
				case  "byte"		: 
				case  "system.byte"	:
				case  "unsigned-byte"	:
					return ( typeof ( global::System. Byte ) ) ;

				case  "sbyte"		: 
				case  "system.sbyte"	:
				case  "signed-byte"	:
					return ( typeof ( global::System. SByte ) ) ;

				case  "char"		: 
				case  "system.char"	:
				case  "character"	:
					return ( typeof ( global::System. Char ) ) ;

				case  "ushort"		: 
				case  "system.uint16"	:
				case  "word"		:
				case  "unsigned-short"	:
					return ( typeof ( global::System. UInt16 ) ) ;

				case  "short"		: 
				case  "system.int16"	:
					return ( typeof ( global::System. Int16 ) ) ;

				case  "uint"		: 
				case  "system.uint32"	:
				case  "dword"		:
				case  "unsigned-integer":
					return ( typeof ( global::System. UInt32 ) ) ;

				case  "int"		: 
				case  "system.int32"	:
				case  "integer"		:
					return ( typeof ( global::System. Int32 ) ) ;

				case  "ulong"		: 
				case  "system.uint64"	:
				case  "qword"		:
				case  "unsigned-long"	: 
					return ( typeof ( global::System. UInt64 ) ) ;

				case  "long"		: 
				case  "system.int64"	:
				case  "long-integer"	:
					return ( typeof ( global::System. Int64 ) ) ;

				case  "string"		:
				case  "system.string"	:
					return ( typeof ( global::System. String ) ) ;

				case  "datetime"	:
				case  "system.datetime" :
				case  "date"		:
					return ( typeof ( global::System. DateTime ) ) ;

				// Non-standard type : loop through the types defined in this assembly and its parent assemblies
				default :
					Type	result = FindType ( typename ) ;

					if  ( result  ==  null )
						return ( null ) ;

					return ( result ) ;
			    }
		    }


		/// <summary>
		/// Tries to find the Type object for the given type name in all loaded assemblies.
		/// Type name comparisons are case-sensitive.
		/// </summary>
		/// <param name="typename">Type name to search for.</param>
		/// <returns>The corresponding Type object, or null if the specified type name does not exist.</returns>
		public static Type  FindType ( String  typename )
		   { return ( FindType ( typename, true ) ) ; }



		/// <summary>
		/// Tries to find the Type object for the given type name in all loaded assemblies.
		/// </summary>
		/// <param name="typename">Type name to search for.</param>
		///<param name="ignore_case">If true, comparisons on type names will be case insensitive.</param>
		/// <returns>The corresponding Type object, or null if the specified type name does not exist.</returns>
		public static Type  FindType ( String  typename, bool  ignore_case = false )
		   {
			// Loop through loaded assemblies
			foreach ( global::System. Reflection. Assembly  asm  in  AppDomain. CurrentDomain. GetAssemblies ( ) )
			   {
				// Then through each assembly type list
				foreach ( Type  type  in  asm. GetTypes ( ) )
				   {
					// Match found
					if  ( String. Compare ( typename, type.Name, ignore_case )  ==  0 )
						return ( type ) ;
				    }
			     }

			return ( null ) ;
		     }


		/// <summary>
		/// Tries to find the Type object for the given type name in the specified assembly.
		/// </summary>
		/// <param name="assembly">Assembly to look into.</param>
		/// <param name="typename">Type name to search for.</param>
		///<param name="ignore_case">If true, comparisons on type names will be case insensitive.</param>
		/// <returns>The corresponding Type object, or null if the specified type name does not exist.</returns>
		public static Type  FindType ( global::System. Reflection. Assembly  assembly, String  typename, bool  ignore_case )
		   {
			// Loop through each assembly type list
			foreach ( global::System.Type   type  in  assembly. GetTypes ( ) )
			   {
				// Match found
				if  ( String. Compare ( typename, type.Name, ignore_case )  ==  0 )
					return ( type ) ;
			    }

			return ( null ) ;
		     }
		# endregion

	    }
    }
