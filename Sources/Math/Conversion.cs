/**************************************************************************************************************

    NAME
        Conversion.cs

    DESCRIPTION
        Handles conversions from base to base.

    AUTHOR
        Christian Vigh, 10/2007.

    HISTORY
    [Version : 1.0]    [Date : 2007/10/21]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using  System ;

using  Thrak. Core ;

namespace  Thrak
   {
	public static partial class  Math
	   {
		/// <summary>
		/// Handles base to base integer number conversions.
		/// </summary>
		public static class  Conversion
		   {
			// Digits for bases from 2 to 36
			public const String	BaseCharacters	= "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
			// Common base values
			public const int	Hexadecimal	= 16 ;
			public const int	Decimal		= 10 ;
			public const int	Octal		= 8 ;
			public const int	Binary		= 2 ;


			# region Validation methods
			/// <summary>
			/// Checks if the specified base is correct (between 2 and 36).
			/// </summary>
			/// <param name="base_value">Base to check.</param>
			/// <returns>True if the base is correct, false otherwise.</returns>
			public static bool  IsValidBase ( int  base_value )
			   {
				if  ( base_value  <  2  ||  base_value  >=  BaseCharacters. Length )
					return ( false ) ;

				return ( true ) ;
			    }


			/// <summary>
			/// Checks if the specified digit belongs to the specified number base.
			/// </summary>
			/// <param name="digit">Digit to check.</param>
			/// <param name="base_value">Digit base (between 2 and 36).</param>
			/// <returns>True if <paramref name="digit"/> belongs to the specified
			/// base, false otherwise.</returns>
			public static  bool IsValidDigit ( char  digit, int  base_value )
			   {
				int		x = char. ToUpper ( digit ) ;


				if  ( x  <  BaseCharacters [0]  ||  x  >  BaseCharacters [base_value - 1] )
					return ( false ) ;

				return ( true ) ;
			    } 


			/// <summary>
			/// Checks the specified base and throws an exception if the base is
			/// not valid (ie, outside the range [2..36]).
			/// </summary>
			/// <param name="base_value">Base to check.</param>
			public static void  ValidateBase ( int  base_value )
			   {
				if  ( ! IsValidBase ( base_value ) )
					throw new ThrakException ( Resources. Localization. Classes. Math. XMathInvalidBase, base_value ) ;
			    }


			/// <summary>
			/// Checks the specified string and throws an exception if it contains
			/// invalid digit for the specified base.
			/// </summary>
			/// <param name="value">Digit to check.</param>
			/// <param name="base_value">Digit base.</param>
			public static void  Validate ( String  value, int  base_value )
			   {
				ValidateBase ( base_value ) ;

				for  ( int  i = 0 ; i < value. Length ; i ++ )
				   {
					if  ( ! IsValidDigit ( value [i], base_value ) )
						throw new ThrakException ( Resources. Localization. Classes. Math. XMathInvalidBaseNumber,
								value [i], value, base_value ) ;
				    }
			     }


			/// <summary>
			/// Returns the byte value corresponding to the specified digit.
			/// </summary>
			/// <param name="digit">Digit to convert.</param>
			/// <returns>The byte value of the digit (0 for '0', 1 for '1',
			/// 10 for 'A' or 'a', etc.).</returns>
			public static byte  Digit ( char  digit )
			   {
				char		x = char. ToUpper ( digit ) ;

				if  ( x  >=  '0'  &&  x  <=  '9' )
					return ( ( byte ) ( x - '0' ) ) ;
				else 
					return ( ( byte ) ( x - 'A' + 10 ) ) ;
			    }


			/// <summary>
			/// Returns the character value corresponding to the specified digit.
			/// </summary>
			/// <param name="digit">Digit to convert.</param>
			/// <returns>The character value of the digit ('0' for 0, '1' for 1,
			/// 'A' for 10, etc.).</returns>
			public static char  Character ( byte  digit )
			   {
				if  ( digit  <  10 )
					return ( ( char ) ( digit + '0' ) ) ;
				else
					return ( ( char ) ( digit + 'A' - 10 ) ) ;
			     }
			# endregion



			# region Conversion methods
			/// <summary>
			/// Converts a string representing an integer value from a base to another.
			/// <para>
			/// The input base is given by the number representation ; the value can
			/// start with "0x" (hexadecimal number), "0d" (decimal number), "0o"
			/// (octal number) or "0b" (binary number). If no prefix is given, then an
			/// input base of decimal is assumed.
			/// </para>
			/// </summary>
			/// <param name="to_base">Destination base.</param>
			/// <param name="value">Value to convert.</param>
			/// <returns>Converted value.</returns>
			public static String  Convert ( String  value, int  to_base )
			   {
				int			from_base ;
				int			start ;


				if  ( value. StartsWith ( "0x" )  ||  value. StartsWith ( "0X" ) )
					{ from_base = 16 ; start = 2 ; }
				else if  ( value. StartsWith ( "0d" )  ||  value. StartsWith ( "0D" ) )
					{ from_base = 10 ; start = 2 ; }
				else if  ( value. StartsWith ( "0o" )  ||  value. StartsWith ( "0O" ) )
					{ from_base = 8 ; start = 2 ; }
				else if  ( value. StartsWith ( "0b" )  ||  value. StartsWith ( "0B" ) )
					{ from_base = 2 ; start = 2 ; }
				else
					{ from_base = 10 ; start = 0 ; }

				return ( Convert ( value. Substring ( start ), from_base, to_base ) ) ;
			     }


			/// <summary>
			/// Converts a string representing an integer value from a base to another.
			/// </summary>
			/// <param name="from_base">Original base.</param>
			/// <param name="to_base">Destination base.</param>
			/// <param name="value">Value to convert.</param>
			/// <returns>Converted value.</returns>
			/// <remarks>
			/// Adapted from a code by Andrew Jonkers ; copyright below :
			/// <para>
			/// Copyright Andrew Jonkers 2006-
			/// convert a positive integer in base:from  to another base (allowable bases from 2 to 36)
			/// the number can be any number of digits long
			/// input and output in string format (e.g. digits in base 2="0-1", base 16="0-F", base 20="0-J" etc 
			/// </para>
			/// </remarks>
			public static String  Convert ( String  value, int  from_base, int  to_base )
			   {
				// Basic checkings
				ValidateBase ( to_base ) ;
				Validate ( value, from_base ) ;

				// Convert input string to an array of byte values
				int		length		= value. Length ;
				byte []		input		= new byte [ length ] ;

				for  ( int  i = length - 1, k = 0 ; i >= 0 ; i --, k ++ )
					input [k] = Digit ( value [i] ) ;


				// Find how many digits the output needs
				int		output_length	= length * ( ( from_base / to_base ) + 1 ) ;
				int []		cums		= new int [ output_length + 10 ] ;
				int []		results		= new int [ output_length + 10 ] ;


				cums [0] = 1 ;		// Initialize array with number 1

				
				// Evaluate the output
				for  ( int  i = 0 ; i < length ; i ++ )	// For each input digit
				    {
					// Add the input digit times (to_base from_base^i) to the output accumulator.
					for  ( int  j = 0 ; j < output_length ; j ++ ) 
					   {
						results [j] += cums [j] * input [i] ;

						int		temp	=  results [j] ;
						int		remnant =  0 ;
						int		ip	=  j ;

						// Fix up any remainders in to_base
						do
						   {
							remnant = temp / to_base ;
							results [ip] = temp - ( remnant * to_base ) ;
							ip ++ ;
							results [ip] += remnant ;
							temp = results [ip] ;
						    } while  ( temp  >=  to_base ) ;
					    }

					// Calculate the nex power (from_base^i) in to_base format
					for  ( int  j = 0 ; j < output_length ; j ++ )
						cums [j] = cums [j] * from_base ;

					// Check for any remainders
					for  ( int  j = 0 ; j < output_length ; j ++ )
					   {
						int	temp	= cums [j] ;
						int	remnant = 0 ;
						int	ip	= j ;

						do
						   {
							remnant = temp / to_base ;
							cums [ip] = temp - ( remnant * to_base ) ;
							ip ++ ;
							cums [ip] += remnant ;
							temp = cums [ip] ;
						     } while ( temp  >=  to_base ) ;
					    }
				    }

				// Convert the output to string format 
				String		output	= String. Empty ;
				bool		first   = false ;

				for  ( int  i = output_length ; i >= 0 ; i -- )
				   {
					if  ( results [i]  !=  0 )
						first = true ;

					if  ( ! first )
						continue ;

					output += Character ( ( byte ) results [i] )  ;
				     }

				// Return the final value
				if  ( String. IsNullOrEmpty ( output ) )
					return ( "0" ) ;
				else
					return ( output ) ;
			    }
			# endregion
		    }
	    }
    }
