/**************************************************************************************************************

    NAME
        String.cs

    DESCRIPTION
        Extension methods for the String and Char classes.

    AUTHOR
        Christian Vigh, 01/2013.

    HISTORY
    [Version : 1.0]    [Date : 2013/01/27]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Text ;
using   System. Text. RegularExpressions ;
using	System. Windows. Forms ;



namespace Thrak. Types
   {
	# region Types for String extensions

	# region ToIdentifierOptions flags
	/// <summary>
	/// Options for the ToIdentifier() string method extension.	
	/// </summary>
	public enum  ToIdentifierOptions
	   {
		/// <summary>
		/// All letters not allowed in a C# identifier are replaced with an underline.
		/// </summary>
		None			=  0x0000,

		/// <summary>
		/// All letters are uppercased.
		/// </summary>
		Uppercase		=  0x0001,

		/// <summary>
		/// All letters are lowercased.
		/// </summary>
		Lowercase		=  0x0002,		// All letters are lowercased.

		/// <summary>
		/// Only the first letter of a word within an identifier is uppercased, the other are lowercased.
		/// </summary>
		UppercaseFirst		=  0x0004,

		/// <summary>
		/// Remove duplicate underlines. This applies only to underlines that replace characters that
		/// are invalid in a C# identifier. Underlines that already were in the input identifier are
		/// left as is.
		/// </summary>
		RemoveDuplicates	=  0x0008,

		/// <summary>
		/// Replace underlines to the left of the input string before any processing takes place.
		/// </summary>
		CleanLeft		=  0x0010,

		/// <summary>
		/// Replace underlines to the right of the input string before any processing takes place.
		/// </summary>
		CleanRight		=  0x0020,

		/// <summary>
		/// Replaces underlines on both ends of the input string before any processing takes place.
		/// </summary>
		Clean			=  0x0030,

		/// <summary>
		/// Remove all duplicate underlines after processing.
		/// </summary>
		RemoveAllDuplicates	=  0x0040,

		/// <summary>
		/// Remove all underlines after processing.
		/// </summary>
		NoUnderlines		=  0x0080
	    } ;
	# endregion


	# region CTYPE flags
	/// <summary>
	/// Character classification constants.
	/// </summary>
	public enum CTYPE
	   {
		/// <summary>
		/// Unknown character class.
		/// </summary>
		UNKNOWN			=  0x00,

		/// <summary>
		/// Uppercase letter.
		/// </summary>
		UPPER			=  0x01,

		/// <summary>
		/// Lowercase letter.
		/// </summary>
		LOWER			=  0x02,

		/// <summary>
		/// Digit [0-9]
		/// </summary>
		DIGIT			=  0x04,

		/// <summary>
		/// Space (TAB, CR, LF, VT or FF).
		/// </summary>
		SPACE			=  0x08,

		/// <summary>
		/// Punctuation character.
		/// </summary>
		PUNCTUATION		=  0x10,

		/// <summary>
		/// Control character.
		/// </summary>
		CONTROL			=  0x20,

		/// <summary>
		/// Space character.
		/// </summary>
		BLANK			=  0x40,		// Space character

		/// <summary>
		/// Hexadecimal digit.
		/// </summary>
		HEXDIGIT		=  0x80
	    } ;
	# endregion


	# region Explode flags
	/// <summary>
	/// String splitting options using the Explode() method.
	/// </summary>
	public enum   ExplodeStringOptions
	    {
		/// <summary>
		/// No special option.
		/// </summary>
		None			=  0x0000,

		/// <summary>
		/// Remove empty strings. This test is applied AFTER trimming, if trim options are specified.
		/// </summary>
		RemoveEmptyStrings	=  0x0001,

		/// <summary>
		/// Trim strings left. Trimming is applied before removing empty string, if the RemoveEmptyStrings flag is specified.
		/// </summary>
		TrimLeft		=  0x0002,

		/// <summary>
		/// Trim strings right. Trimming is applied before removing empty string, if the RemoveEmptyStrings flag is specified.
		/// </summary>
		TrimRight		=  0x0004,

		/// <summary>
		/// Trims strings.  Trimming is applied before removing empty string, if the RemoveEmptyStrings flag is specified.
		/// </summary>
		Trim			=  TrimLeft + TrimRight,

		/// <summary>
		/// For string separators only : the specified separators are regular expressions.
		/// </summary>
		UseRegex		=  0x0008,

		/// <summary>
		/// Sorts the results, using the default sort option (ascending).
		/// </summary>
		Sort			=  0x0020,

		/// <summary>
		/// Sorts the results, ascending.
		/// </summary>
		SortAscending		=  0x0020,

		/// <summary>
		/// Sorts the results, descending.
		/// </summary>
		SortDescending		=  0x0030,

		/// <summary>
		/// Informs that the input string has quoted strings that must be considered as one single element.
		/// Quoted strings are unquoted.
		/// </summary>
		HasQuotedStrings	=  0x0040
	     }

	# endregion

	# endregion


	# region StringExtensions
	/// <summary>
	/// Provides extension methods to the String and Char base types. Works also for Char[] and String[] data types.
	/// </summary>
	public static  class StringExtensions
	   {
		# region Character/String classification methods
		# region CTYPE table
		private static  CTYPE []	CTYPE_TABLE = new CTYPE []
		   {
			CTYPE. CONTROL,						// 00 (NUL)
			CTYPE. CONTROL,                				// 01 (SOH)
			CTYPE. CONTROL,                				// 02 (STX)
			CTYPE. CONTROL,                				// 03 (ETX)
			CTYPE. CONTROL,                				// 04 (EOT)
			CTYPE. CONTROL,                				// 05 (ENQ)
			CTYPE. CONTROL,                				// 06 (ACK)
			CTYPE. CONTROL,                				// 07 (BEL)
			CTYPE. CONTROL,                				// 08 (BS)
			CTYPE. SPACE | CTYPE. CONTROL,         			// 09 (HT)
			CTYPE. SPACE | CTYPE. CONTROL,         			// 0A (LF)
			CTYPE. SPACE | CTYPE. CONTROL,         			// 0B (VT)
			CTYPE. SPACE | CTYPE. CONTROL,         			// 0C (FF)
			CTYPE. SPACE | CTYPE. CONTROL,         			// 0D (CR)
			CTYPE. CONTROL,                				// 0E (SI)
			CTYPE. CONTROL,                				// 0F (SO)
			CTYPE. CONTROL,               				// 10 (DLE)
			CTYPE. CONTROL,                				// 11 (DC1)
			CTYPE. CONTROL,                				// 12 (DC2)
			CTYPE. CONTROL,                				// 13 (DC3)
			CTYPE. CONTROL,                				// 14 (DC4)
			CTYPE. CONTROL,                				// 15 (NAK)
			CTYPE. CONTROL,                				// 16 (SYN)
			CTYPE. CONTROL,                				// 17 (ETB)
			CTYPE. CONTROL,                				// 18 (CAN)
			CTYPE. CONTROL,                				// 19 (EM)
			CTYPE. CONTROL,                				// 1A (SUB)
			CTYPE. CONTROL,                				// 1B (ESC)
			CTYPE. CONTROL,                				// 1C (FS)
			CTYPE. CONTROL,                				// 1D (GS)
			CTYPE. CONTROL,                				// 1E (RS)
			CTYPE. CONTROL,                				// 1F (US)
			CTYPE. SPACE | CTYPE. BLANK,           			// 20 SPACE
			CTYPE. PUNCTUATION,                  			// 21 !
			CTYPE. PUNCTUATION,                  			// 22 "
			CTYPE. PUNCTUATION,                  			// 23 #
			CTYPE. PUNCTUATION,                  			// 24 $
			CTYPE. PUNCTUATION,                  			// 25 %
			CTYPE. PUNCTUATION,                  			// 26 &
			CTYPE. PUNCTUATION,                  			// 27 '
			CTYPE. PUNCTUATION,                  			// 28 (
			CTYPE. PUNCTUATION,                  			// 29 )
			CTYPE. PUNCTUATION,                  			// 2A *
			CTYPE. PUNCTUATION,                  			// 2B +
			CTYPE. PUNCTUATION,                  			// 2C  
			CTYPE. PUNCTUATION,                  			// 2D -
			CTYPE. PUNCTUATION,                  			// 2E .
			CTYPE. PUNCTUATION,                  			// 2F /
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 30 0
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 31 1
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 32 2
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 33 3
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 34 4
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 35 5
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 36 6
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 37 7
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 38 8
			CTYPE. DIGIT | CTYPE. HEXDIGIT,             		// 39 9
			CTYPE. PUNCTUATION,                  			// 3A :
			CTYPE. PUNCTUATION,                  			// 3B ;
			CTYPE. PUNCTUATION,                  			// 3C <
			CTYPE. PUNCTUATION,                  			// 3D =
			CTYPE. PUNCTUATION,                  			// 3E >
			CTYPE. PUNCTUATION,                  			// 3F ?
			CTYPE. PUNCTUATION,                  			// 40 @
			CTYPE. UPPER | CTYPE. HEXDIGIT,             		// 41 A
			CTYPE. UPPER | CTYPE. HEXDIGIT,             		// 42 B
			CTYPE. UPPER | CTYPE. HEXDIGIT,             		// 43 C
			CTYPE. UPPER | CTYPE. HEXDIGIT,             		// 44 D
			CTYPE. UPPER | CTYPE. HEXDIGIT,             		// 45 E
			CTYPE. UPPER | CTYPE. HEXDIGIT,             		// 46 F
			CTYPE. UPPER,                  				// 47 G
			CTYPE. UPPER,                  				// 48 H
			CTYPE. UPPER,                  				// 49 I
			CTYPE. UPPER,                  				// 4A J
			CTYPE. UPPER,                  				// 4B K
			CTYPE. UPPER,                  				// 4C L
			CTYPE. UPPER,                  				// 4D M
			CTYPE. UPPER,                  				// 4E N
			CTYPE. UPPER,                  				// 4F O
			CTYPE. UPPER,                  				// 50 P
			CTYPE. UPPER,                  				// 51 Q
			CTYPE. UPPER,                  				// 52 R
			CTYPE. UPPER,                  				// 53 S
			CTYPE. UPPER,                  				// 54 T
			CTYPE. UPPER,                  				// 55 U
			CTYPE. UPPER,                  				// 56 V
			CTYPE. UPPER,                  				// 57 W
			CTYPE. UPPER,                  				// 58 X
			CTYPE. UPPER,                  				// 59 Y
			CTYPE. UPPER,                  				// 5A Z
			CTYPE. PUNCTUATION,                  			// 5B [
			CTYPE. PUNCTUATION,                  			// 5C \ 
			CTYPE. PUNCTUATION,                  			// 5D ]
			CTYPE. PUNCTUATION,                  			// 5E ^
			CTYPE. PUNCTUATION,                  			// 5F _
			CTYPE. PUNCTUATION,                  			// 60 `
			CTYPE. LOWER | CTYPE. HEXDIGIT,             		// 61 a
			CTYPE. LOWER | CTYPE. HEXDIGIT,             		// 62 b
			CTYPE. LOWER | CTYPE. HEXDIGIT,             		// 63 c
			CTYPE. LOWER | CTYPE. HEXDIGIT,             		// 64 d
			CTYPE. LOWER | CTYPE. HEXDIGIT,             		// 65 e
			CTYPE. LOWER | CTYPE. HEXDIGIT,             		// 66 f
			CTYPE. LOWER,                  				// 67 g
			CTYPE. LOWER,                  				// 68 h
			CTYPE. LOWER,                  				// 69 i
			CTYPE. LOWER,                  				// 6A j
			CTYPE. LOWER,                  				// 6B k
			CTYPE. LOWER,                  				// 6C l
			CTYPE. LOWER,                  				// 6D m
			CTYPE. LOWER,                  				// 6E n
			CTYPE. LOWER,                  				// 6F o
			CTYPE. LOWER,                  				// 70 p
			CTYPE. LOWER,                  				// 71 q
			CTYPE. LOWER,                  				// 72 r
			CTYPE. LOWER,                  				// 73 s
			CTYPE. LOWER,                  				// 74 t
			CTYPE. LOWER,                  				// 75 u
			CTYPE. LOWER,                  				// 76 v
			CTYPE. LOWER,                  				// 77 w
			CTYPE. LOWER,                  				// 78 x
			CTYPE. LOWER,                  				// 79 y
			CTYPE. LOWER,                  				// 7A z
			CTYPE. PUNCTUATION,                  			// 7B {
			CTYPE. PUNCTUATION,                  			// 7C |
			CTYPE. PUNCTUATION,                  			// 7D }
			CTYPE. PUNCTUATION,                  			// 7E ~
			CTYPE. CONTROL                				// 7F (DEL)
		    } ;
		# endregion


		# region CTypeOf method
		// CTypeOf -
		//	Returns the character class of the specified character.
		public static CTYPE  CTypeOf ( this Char  ch )
		   {
			String		chu	=  ch. ToString ( ). Unaccentuate ( ) ;
			byte		b	=  ( byte ) chu [0] ;


			if  ( b  >=  0  &&  b  <  128 )
				return ( CTYPE_TABLE [b] ) ;
			else
				return ( CTYPE. UNKNOWN ) ;
		    }
		# endregion


		# region Character classification methods
		/// <summary>
		/// Checks if the specified character is a digit.
		/// </summary>
		/// <returns>True if the character is a digit, false otherwise.</returns>
		public static bool  IsDigit ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. DIGIT ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is a hexadecimal digit.
		/// </summary>
		/// <returns>True if the character is a hexadecimal digit, false otherwise.</returns>
		public static bool  IsHexDigit ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. HEXDIGIT ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is a lowercase letter.
		/// </summary>
		/// <returns>True if the character is a lowercase letter, false otherwise.</returns>
		public static bool  IsLowercaseLetter ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. LOWER ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is an uppercase letter.
		/// </summary>
		/// <returns>True if the character is an uppercase letter, false otherwise.</returns>
		public static bool  IsUppercaseLetter ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. UPPER ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is a letter, whatever its case.
		/// </summary>
		/// <returns>True if the character is a letter, false otherwise.</returns>
		public static bool  IsLetter ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  ( CTYPE. LOWER | CTYPE. UPPER ) )  !=  0 ) ) ; }


		/// <summary>
		/// Checks if the specified character is a space (including tabs, carriage returns, line feeds, etc.).
		/// </summary>
		/// <returns>True if the character is a space, false otherwise.</returns>
		public static bool  IsSpace ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. SPACE ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is a punctuation character.
		/// </summary>
		/// <returns>True if the character is a punctuation character, false otherwise.</returns>
		public static bool  IsPunctuation ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. PUNCTUATION ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is a control character.
		/// </summary>
		/// <returns>True if the character is a control character, false otherwise.</returns>
		public static bool  IsControl ( this Char  ch ) 
		   { return ( ( ( int ) ( CTypeOf ( ch )  &  CTYPE. CONTROL ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is a space (ascii character 32).
		/// </summary>
		/// <returns>True if the character is a space, false otherwise.</returns>
		public static bool  IsBlank ( this Char  ch ) 
		   { return ( ( ( int ) ( StringExtensions.CTypeOf ( ch )  &  CTYPE. BLANK ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is valid in a C# identifier, starting as the second character of the identifier.
		/// </summary>
		/// <returns>True if the character is a valid character for a C# identifier, false otherwise.</returns>
		public static bool  IsIdentifier ( this Char  ch ) 
		   { return ( ch  ==  '_'  ||  ( ( int ) ( CTypeOf ( ch )  &  ( CTYPE. LOWER | CTYPE. UPPER | CTYPE. DIGIT ) ) )  !=  0 ) ; }


		/// <summary>
		/// Checks if the specified character is valid in a C# identifier, starting as the first character of the identifier.
		/// </summary>
		/// <returns>True if the character is a valid character for a C# identifier, false otherwise.</returns>
		public static bool  IsIdentifierFirstChar ( this Char  ch ) 
		   { return ( ch  ==  '_'  ||  ( ( int ) ( CTypeOf ( ch )  &  ( CTYPE. LOWER | CTYPE. UPPER ) ) )  !=  0 ) ; }
		# endregion


		# region Character classification methods for strings
		/// <summary>
		/// Checks if a string contains only digits.
		/// </summary>
		/// <returns>Returns true if the specified string contains only digits, false otherwise.</returns>
		public static bool  IsDigits ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsDigit ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only hexadecimal digits.
		/// </summary>
		/// <returns>Returns true if the specified string contains only hexadecimal digits, false otherwise.</returns>
		public static bool  IsHexDigits ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsHexDigit ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only lowercase letters.
		/// </summary>
		/// <returns>Returns true if the specified string contains only lowercase letters, false otherwise.</returns>
		public static bool  IsLowercaseLetters ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsLowercaseLetter ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only uppercase letters.
		/// </summary>
		/// <returns>Returns true if the specified string contains only digits, false otherwise.</returns>
		public static bool  IsUppercaseLetters ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsUppercaseLetter ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only lowercase or uppercase letters.
		/// </summary>
		/// <returns>Returns true if the specified string contains only letters, false otherwise.</returns>
		public static bool  IsLetters ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsLetter ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only spaces (space, tab, newline, carriage return, etc.).
		/// </summary>
		/// <returns>Returns true if the specified string contains only spaces, false otherwise.</returns>
		public static bool  IsSpaces ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsSpace ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only punctuation characters.
		/// </summary>
		/// <returns>Returns true if the specified string contains only punctuation characters, false otherwise.</returns>
		public static bool  IsPunctuations ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsPunctuation ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only control characters.
		/// </summary>
		/// <returns>Returns true if the specified string contains only control characters, false otherwise.</returns>
		public static bool  IsControls ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsControl ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string contains only space characters (ascii value 32).
		/// </summary>
		/// <returns>Returns true if the specified string contains only space characters, false otherwise.</returns>
		public static bool  IsBlanks ( this String  value ) 
		   {
			foreach  ( Char  ch  in  value )
			   {
				if  ( ! ch. IsBlank ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Checks if a string is a valid C# identifier.
		/// </summary>
		/// <returns>Returns true if the specified string is a valid C# identifier, false otherwise.</returns>
		public static bool  IsIdentifier ( this String  value ) 
		   {
			Char		ch	=  value [0] ;

			if  ( ! ch. IsIdentifierFirstChar ( ) )
				return ( false ) ;

			for  ( int  i = 1 ; i  <  value. Length ; i ++ )
			   {
				if  ( ! ch. IsIdentifier ( ) )
					return ( false ) ;
			    }

			return ( true ) ;
		    }
		# endregion
		# endregion


		# region Character extension methods
		/// <summary>
		/// Returns the ordinal value of a character.
		/// </summary>
		/// <returns>The ordinal (numeric) value of the specified character.</returns>
		public static int  GetNumericValue ( this Char  ch )
		   { return ( ( int ) Char. GetNumericValue ( ch ) ) ; }


		/// <summary>
		/// Converts a character to lowercase.
		/// </summary>
		/// <returns>The supplied character, converted to lowercase.</returns>
		public static Char  ToLower ( this Char  ch )
		   { return ( Char. ToLower ( ch ) ) ; }


		/// <summary>
		/// Converts a character to uppercase.
		/// </summary>
		/// <returns>The supplied character, converted to uppercase.</returns>
		public static Char  ToUpper ( this Char  ch )
		   { return ( Char. ToUpper ( ch ) ) ; }
		# endregion


		# region Regular expression methods
		/// <summary>
		/// Replaces a string using a regular expression.
		/// </summary>
		/// <param name="pattern">Pattern to be applied.</param>
		/// <param name="replacement">Replacement string.</param>
		/// <param name="options">Regex options.</param>
		/// <returns>The initial string, with the pattern replacement(s) applied.</returns>
		public static String  RegReplace ( this String  value, String  pattern, String  replacement, RegexOptions  options  = RegexOptions. None )
		   { return ( Regex. Replace ( value, pattern, replacement, options ) ) ; }
		# endregion


		# region Conversion methods

		# region ToIdentifier method
		/// <summary>
		/// Converts a string into a valid C# identifier.
		/// </summary>
		/// <param name="options">Options that guide the conversion process.</param>
		/// <returns>A valid C# identifier.</returns>
		public static String  ToIdentifier ( this String  value, ToIdentifierOptions  options = ToIdentifierOptions. None )
		   {
			StringBuilder		Temp		=  new StringBuilder ( ) ;
			bool			StartedName	=  false ;

	
			// Since the caller may want to keep initial underlines, replace them with character #1 so that they will not be
			// affected by the RemoveDuplicates option.
			value	=  value. Replace ( '_', ( Char ) 1 ) ;

			// Replace accentuated characters
			value	=  value. Unaccentuate ( ) ;

			// Loop through input characters
			foreach  ( Char  ch  in  value )
			   {
				Char	ch2	=  ch. ToUpper ( ) ;

				// Check for valid character in a C# identifier
				if  ( ( ch2  >=  'A'  &&  ch2  <=  'Z' )  || ( ch2  >=  '0'  &&  ch2  <=  '9' )  ||  ch  ==  ( Char ) 1 )
				   {
					// If we already started a name, check for upppercase/lowercase conversions
					if  ( StartedName )
					   {
						if  ( ( options  &  ToIdentifierOptions. Lowercase )  !=  0 )
							Temp. Append ( ch. ToLower ( ) ) ;
						else if  ( ( options  &  ToIdentifierOptions. Uppercase )  !=  0 )
							Temp. Append  ( ch2 ) ;
						else
							Temp. Append ( ch ) ;
					    }
					// Otherwise...
					else
					   {
						// If it is a letter, check for uppercase/lowercase/uppercasefirst conversions
						if   ( ch2  >=  'A'  &&  ch2  <=  'Z' )
						   {
							if  ( ( options  &  ( ToIdentifierOptions. UppercaseFirst  |  ToIdentifierOptions. Uppercase ) )  !=  0 ) 
								Temp. Append ( ch2 ) ;
							else if  ( ( options  &  ( ToIdentifierOptions. Lowercase ) )  !=  0 )  
								Temp. Append ( ch. ToLower ( ) ) ;
							else
								Temp. Append ( ch ) ;

							StartedName = true ;
						    }
						// Otherwise, simply take the character as is
						else
						   {
							Temp. Append ( ch ) ;
							StartedName = false ;
						    }
					    }
				    }
				// If the current character is not valid within a C# identifier, replace it with an underline
				else
				   {
					Temp. Append ( '_' ) ;
					StartedName = false ;
				    }
			    }

			// Convert our StringBuilder result
			String		Result		=  Temp. ToString ( ) ;

			// Check if we have to clean underlines to the left
			if  ( ( options  &  ToIdentifierOptions. CleanLeft )  !=  0 ) 
				Result	=  Result. RegReplace ( "^[_]+", "" ) ;

			// ... then to the right
			if  ( ( options  &  ToIdentifierOptions. CleanRight )  !=  0 ) 
				Result	=  Result. RegReplace ( "[_]+$", "" ) ;

			// Remove duplicate underlines NOT initially specified in the input string
			if  ( ( options  &  ToIdentifierOptions. RemoveDuplicates )  !=  0 ) 
				Result	=  Result. RegReplace ( "[" + ( ( Char ) 1 ) + "_][_]+", "_" ) ;
		
			// If the processed input string still starts with a digit
			if  ( value [0]  >=  '0'  &&  value [0]  <=  '9' )
				value = ( ( Char ) 1 ) + value ;

			// Restore initial input string underlines
			Result	=  Result. Replace  ( ( Char ) 1, '_' ) ;

			// Check if we need to remove all duplicates underlines, either the ones supplied on the input string, or
			// the ones that replaced invalid characters for a C# identifier.
			if  ( ( options  &  ToIdentifierOptions. RemoveAllDuplicates )  !=  0 ) 
				Result	=  Result. RegReplace ( "[_][_]+", "_" ) ;

			// Finally, check if we do not have to remove ALL underlines
			if  ( ( options  &  ToIdentifierOptions. NoUnderlines )  !=  0 ) 
				Result	=  Result. RegReplace ( "[_]+", "" ) ;

			// All done, return
			return ( Result ) ;
		    }
		# endregion

		# endregion


		# region String manipulation methods

		# region ExpandTabs method
		/// <summary>
		/// Extension to the string object : expands tabs within a string.
		/// </summary>
		/// <param name="text">String object</param>
		/// <param name="tabsize">Number of spaces represented by a tab.</param>
		/// <param name="stop_at_first_nonspace">When true, expansion stops at the first nonspace character.</param>
		/// <returns>The expanded string.</returns>
		public static string  ExpandTabs ( this string		text, 
						   int			tabsize			=  8, 
						   bool			stop_at_first_nonspace	=  false )
		   {
			StringBuilder	result		=  new StringBuilder ( ) ;
			int		column		=  0,
					index		=  0 ;

			foreach  ( Char  ch  in  text )
			   {
				switch ( ch )
				   {
					case	'\t' :
						do
						   {
							result. Append ( ' ' ) ;
							column ++ ;
						    }  while ( ( column & ( tabsize - 1 ) )  !=  0 ) ;
						break ;

					case	'\n' :
					case	'\r' :
						column	=  0 ;
						break ;
					
					case	' ' :
						result. Append ( ' ' ) ;
						column ++ ;
						break ;

					default :
						if  ( stop_at_first_nonspace )
						   {
							result. Append ( text. Substring ( index ) ) ;
							return ( result. ToString ( ) ) ;
						    }
						else
						   {
							result. Append ( ch ) ;
							column ++ ;
						     }
						break ;
				    }

				index ++ ;
			    }

			return ( result. ToString ( ) ) ;
		    }

		# endregion

		# region Implode method
		/// <summary>
		/// Concatenates an array of strings, using the specified separator.
		/// </summary>
		/// <param name="separator">Separator to be used. Default is a space.</param>
		/// <returns>
		/// The string items separated by the specified separator, or an empty string if the array is empty.
		/// </returns>
		public static String Implode ( this String []  values, String  separator = " " )
		   {
			if  ( values. Length  ==  0 )
				return ( "" ) ;

			StringBuilder		sb	=  new StringBuilder ( ) ;
			int			last	=  values. Length - 1 ;


			for  ( int  i = 0 ; i  <  last ; i ++ )
			   {
				sb. Append ( values [i] ) ;
				sb. Append ( separator ) ;
			    }

			sb. Append ( values [ last ] ) ;

			return ( sb. ToString ( ) ) ;
		    }


		/// <summary>
		/// Concatenates an array of <typeparamref name="T"/> values, using the specified separator.
		/// </summary>
		/// <typeparam name="T">Type of array values.</typeparam>
		/// <param name="separator">Separator to be used. Default is a space.</param>
		/// <returns>
		/// The <typeparamref name="T"/> item values separated by the specified separator, or an empty string if the array is empty.
		/// </returns>
		/// <remarks>
		/// This templated version is intended to be used on basic types, such as char, byte, float, etc. which will avoid
		/// boxing and unboxing operations that would occur with the version of the Explode() method which takes an array of objects
		/// as input.
		/// </remarks>
		public static String Implode<T> ( this T []  values, String  separator )
		   {
			if  ( values. Length  ==  0 )
				return ( "" ) ;

			StringBuilder		sb	=  new StringBuilder ( ) ;
			int			last	=  values. Length - 1 ;


			for  ( int  i = 0 ; i  <  last ; i ++ )
			   {
				sb. Append ( values [i]. ToString ( ) ) ;
				sb. Append ( separator ) ;
			    }

			sb. Append ( values [ last ] ) ;

			return ( sb. ToString ( ) ) ;
		    }


		/// <summary>
		/// Concatenates an array of objects, using the specified separator.
		/// </summary>
		/// <param name="separator">Separator to be used. Default is a space.</param>
		/// <returns>
		/// The object items converted to string using the ToString() method,
		/// separated by the specified separator, or an empty string if the array is empty.
		/// </returns>
		public static String Implode ( this Object []  values, String  separator )
		   {
			if  ( values. Length  ==  0 )
				return ( "" ) ;

			StringBuilder		sb	=  new StringBuilder ( ) ;
			int			last	=  values. Length - 1 ;


			for  ( int  i = 0 ; i  <  last ; i ++ )
			   {
				sb. Append ( values [i]. ToString ( ) ) ;
				sb. Append ( separator ) ;
			    }

			sb. Append ( values [ last ] ) ;

			return ( sb. ToString ( ) ) ;
		    }

		# endregion

		# region Quote method
		/// <summary>
		/// Returns the quoted version of the string.
		/// </summary>
		/// <param name="delimiter">String delimiter.</param>
		/// <param name="escape">Escape character to be used when the string contains the specified delimiter.</param>
		/// <returns>The quoted version of the string.</returns>
		public static String  Quote ( this String  value, String  delimiter = "\"", String  escape = "\\" )
		   { return ( delimiter + value. Replace ( delimiter, escape + delimiter ) + delimiter ) ; }


		/// <summary>
		/// Returns the quoted version of the specified character.
		/// </summary>
		/// <param name="delimiter">String delimiter.</param>
		/// <param name="escape">Escape character to be used when the string contains the specified delimiter.</param>
		/// <returns>The quoted version of the string.</returns>
		public static String  Quote ( this String  value, Char  delimiter = '"', Char  escape = '\\' )
		   { return ( value. Quote ( delimiter. ToString ( ), escape.ToString ( ) ) ) ; }

		#  endregion

		# region  UppercaseFirst method
		/// <summary>
		/// Returns the supplied value with the first character converted to uppercase and the remaining characters
		/// converted to lowercase.
		/// </summary>
		/// <param name="value">Value to be converted.</param>
		public static String  UppercaseFirst ( this string  value )
		   {
			if  ( String. IsNullOrEmpty ( value ) )
				return ( String. Empty ) ;
			else
				return ( value [0]. ToUpper ( ) + value.Substring ( 1 ). ToLower ( ) ) ;
		    }
		# endregion

		# region  Repeat method
		/// <summary>
		/// Repeats a string by the specified number of times.
		/// </summary>
		/// <param name="count">Repeat count.</param>
		/// <returns>The string instance repeated 'count' times.</returns>
		public static String  Repeat ( this String  value, int  count )
		   {
			if  ( count  <  0 )
				throw new IndexOutOfRangeException ( ) ;
			else if  ( count  ==  0 )
				return ( "" ) ;
			
			StringBuilder		result	=  new StringBuilder ( ) ;

			while  ( count --  >=  0 )
				result. Append ( value ) ;

			return ( result. ToString ( ) ) ;
		    }


		/// <summary>
		/// Repeats a character by the specified number of times.
		/// </summary>
		/// <param name="count">Repeat count.</param>
		/// <returns>The character instance repeated 'count' times.</returns>
		public static String  Repeat ( this Char  value, int  count )
		   {
			if  ( count  <  0 )
				throw new IndexOutOfRangeException ( ) ;

			return ( "". PadLeft ( count, value ) ) ;
		    }
		# endregion

		# region Unaccentuate method
		// Maps accentuated letters with unaccentuated ones.
		private static Dictionary<String, String>		AccentuatedLetters  = new Dictionary<String, String> ( )
		   {
			{ "À", "A" }, { "Á", "A" }, { "Â", "A" }, { "Ã", "A" }, { "Ä", "A" }, { "Å", "A" }, { "Æ", "AE" },
			{ "Ç", "C" }, { "È", "E" }, { "É", "E" }, { "Ê", "E" }, { "Ë", "E" }, { "Ì", "I" }, { "Í", "I" },
			{ "Î", "I" }, { "Ï", "I" }, { "Ð", "D" }, { "Ñ", "N" }, { "Ò", "O" }, { "Ó", "O" }, { "Ô", "O" },
			{ "Õ", "O" }, { "Ö", "O" }, { "Ø", "O" }, { "Ù", "U" }, { "Ú", "U" }, { "Û", "U" }, { "Ü", "U" },
			{ "Ý", "Y" }, { "ß", "s" }, { "à", "a" }, { "á", "a" }, { "â", "a" }, { "ã", "a" }, { "ä", "a" },
			{ "å", "a" }, { "æ", "ae" }, { "ç", "c" }, { "è", "e" }, { "é", "e" }, { "ê", "e" }, { "ì", "i" },
			{ "í", "i" }, { "î", "i" }, { "ï", "i" }, { "ð", "o" }, { "ñ", "n" }, { "ò", "o" }, { "ó", "o" },
			{ "ô", "o" }, { "õ", "o" }, { "ö", "o" }, { "ø", "o" }, { "ú", "u" }, { "û", "u" }, { "ü", "u" },
			{ "ý", "y" }, { "ÿ", "y" }, { "Ž", "Z" }, { "ž", "z" }, { "ù", "u" }, { "ë", "e" }
		    } ;		    


		/// <summary>
		/// Replace accentuated letters to unaccentuated ones.
		/// </summary>
		/// <returns>The input string, with all accentuated characters replaced with their unaccentuated equivalent.</returns>
		public static String Unaccentuate ( this String  value )
		   {
			StringBuilder		Result	= new StringBuilder ( ) ;


			foreach ( Char  ch  in  value )
			   {
				String		chs	= ch. ToString ( ) ;

				if  ( AccentuatedLetters. ContainsKey ( chs ) )
					Result. Append ( AccentuatedLetters [chs] ) ;
				else
					Result. Append ( chs ) ;
			    }

			return ( Result. ToString ( ) ) ;
		    }
		# endregion
		
		# endregion
	    }
	# endregion
    }
