/**************************************************************************************************************

    NAME
        BitArray.cs

    DESCRIPTION
        Implements a bit array using ulong values.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/04]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Collections ;
using	System. Collections. Generic ;

using	Thrak. Core ;


namespace Thrak. Structures
   {
	/// <summary>
	/// Manages a compact bit array, where true represents an activated bit, and false a zero bit.
	/// </summary>
	/// <remarks>
	/// The underlying bit values are stored in 32-bit words.
	/// </remarks>
	public class	BitArray : Structure<BitArray>, ICloneable, IEnumerable
	   {
		# region Data members
		private const int		BYTE_COUNT	=  8 ;				// Item size, in bytes
		private const int		BIT_COUNT	=  ( BYTE_COUNT * 8 ) ;		// Item size, in bits (number of bits in ulong)

		private ulong []		__Bits ;					// Bit array
		private int			__Size ;					// Bit array size, in bits
		private int			__ArraySize ;					// Ulong array size, in ulongs
		private ulong			__LastItemMask ;				// used to mask only the significant bits in the last item of the __Bits array
		internal int			__Version	=  0 ;				// Update version (used by enumerator)

		/// <summary>
		/// String representation for a zero bit.
		/// </summary>
		public String			BitUnsetString	=  "." ;	

		/// <summary>
		/// String representation for a bit set to one.
		/// </summary>
		public String			BitSetString	=  "1" ;	
		# endregion
		

		# region Constructors

		#  region Standard constructor (no initial value)
		/// <summary>
		/// Builds a BitArray with the specified size in bits.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		public BitArray ( int  size )
		   {
			// Check input values
			if  ( size  <  1 )
				throw new ArgumentOutOfRangeException ( "size" ) ;

			// Initialize BitArray fields
			this. __Size		=  size ;					// Array size, in bits
			this. __ArraySize	=  ( size + BIT_COUNT - 1 ) / BIT_COUNT ;	// Array size, in 64-bit words
			this. __Bits		=  new  ulong [ this. __ArraySize ] ;		// Bit array

			// Build the mask for the last item in the __Bits array
			BuildTrailingMask ( ) ;
		    }
		# endregion


		# region Constructors with numeric initial value
		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial boolean value.</param>
		public  BitArray ( int  size, bool  value )	:  this ( size )
		   { this. __Bits [0] = ( ulong ) ( ( value ) ?  1 : 0 ) ; }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial byte value.</param>
		public  BitArray ( int  size, byte  value )	:  this ( size )
		   { this. __Bits [0] = ( ulong ) value ; }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial sbyte value.</param>
		public  BitArray ( int  size, sbyte  value )	:  this ( size, unchecked ( ( byte ) value ) )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial ushort value.</param>
		public  BitArray ( int  size, ushort  value )	:  this ( size )
		   { this. __Bits [0] = ( ulong ) value ; }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial short value.</param>
		public  BitArray ( int  size, short  value )	:  this ( size, unchecked ( ( ushort ) value ) )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial uint value.</param>
		public  BitArray ( int  size, uint  value )	:  this ( size )
		   { this. __Bits [0] = ( ulong ) value ; }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial int value.</param>
		public  BitArray ( int  size, int  value )	:  this ( size, unchecked ( ( uint ) value ) )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial ulong value.</param>
		public  BitArray ( int  size, ulong  value )	:  this ( size )
		   { this. __Bits [0] = value ; }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial long value.</param>
		public  BitArray ( int  size, long  value )	:  this ( size, unchecked ( ( ulong ) value ) )
		   { }

			
		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial float value.</param>
		public  BitArray ( int  size, float  value )	:  this ( size )
		   {
			uint		ivalue ;

			unsafe 
			   {
				uint *		p	=  ( uint * ) & value ;

				ivalue = * p ;
			    }

			this. __Bits [0] =  ivalue ;
		    }


			
		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial double value.</param>
		public  BitArray ( int  size, double  value )	:  this ( size )
		   {
			ulong		lvalue ;

			unsafe 
			   {
				ulong *		p	=  ( ulong * ) & value ;

				lvalue = * p ;
			    }

			this. __Bits [0] =  lvalue ;
		    }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial char value.</param>
		public BitArray ( int  size, char  ch ) : this ( size )
		   { this. __Bits [0]	=  ch ; }
		# endregion


		# region Constructors with String value
		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial string value.</param>
		public BitArray ( int  size, String  value ) : this ( size ) 
		   { ToBits<String,Char> ( value, 8 ) ; }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="value">Initial string value. The bit array size will be 8 * length of string.</param>
		public  BitArray ( String  value ) : this ( value. Length * 8, value )
		   { }
		# endregion


		# region Constructors with array of something
		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial bool array value.</param>
		/// <remarks>
		/// Note that the 1st element of the array is bit 0 ; last element is bit n.
		/// </remarks>
		public BitArray ( int  size, bool[]  value ) : this ( size ) 
		   { ToBits<bool[],bool> ( value, 1 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified bool array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial bool array value.</param>
		public BitArray ( bool[]  value ) : this ( value. Length, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial char array value.</param>
		public BitArray ( int  size, char[]  value ) : this ( size ) 
		   { ToBits<char[],char> ( value, 8 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified char array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial char array value.</param>
		public BitArray ( char[]  value ) : this ( value. Length * 8, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial byte array value.</param>
		public BitArray ( int  size, byte[]  value ) : this ( size ) 
		   { ToBits<byte[],byte> ( value, 8 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified byte array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial byte array value.</param>
		public BitArray ( byte[]  value ) : this ( value. Length * 8, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial sbyte array value.</param>
		public BitArray ( int  size, sbyte[]  value ) : this ( size ) 
		   { ToBits<sbyte[],sbyte> ( value, 8 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified sbyte array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial byte array value.</param>
		public BitArray ( sbyte[]  value ) : this ( value. Length * 8, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial short array value.</param>
		public BitArray ( int  size, short[]  value ) : this ( size ) 
		   { ToBits<short[],short> ( value, 16 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified short array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial short array value.</param>
		public BitArray ( short[]  value ) : this ( value. Length * 16, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial ushort array value.</param>
		public BitArray ( int  size, ushort[]  value ) : this ( size ) 
		   { ToBits<ushort[],ushort> ( value, 16 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified ushort array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial short array value.</param>
		public BitArray ( ushort[]  value ) : this ( value. Length * 16, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial int array value.</param>
		public BitArray ( int  size, int[]  value ) : this ( size ) 
		   { ToBits<int[],int> ( value, 32 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified int array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial int array value.</param>
		public BitArray ( int[]  value ) : this ( value. Length * 32, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial uint array value.</param>
		public BitArray ( int  size, uint[]  value ) : this ( size ) 
		   { ToBits<uint[],uint> ( value, 32 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified uint array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial int array value.</param>
		public BitArray ( uint[]  value ) : this ( value. Length * 32, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial long array value.</param>
		public BitArray ( int  size, long[]  value ) : this ( size ) 
		   { ToBits<long[],long> ( value, 64 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified long array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial long array value.</param>
		public BitArray ( long[]  value ) : this ( value. Length * 64, value )
		   { }


		/// <summary>
		/// Builds a BitArray with the specified size in bits and the specified initial value.
		/// </summary>
		/// <param name="size">Size of the bit array, in bits.</param>
		/// <param name="value">Initial ulong array value.</param>
		public BitArray ( int  size, ulong[]  value ) : this ( size ) 
		   { ToBits<ulong[],ulong> ( value, 64 ) ; }


		/// <summary>
		/// Builds a BitArray using the specified long array. The BitArray size is determined by the number of elements in the array.
		/// </summary>
		/// <param name="value">Initial ulong array value.</param>
		public BitArray ( ulong[]  value ) : this ( value. Length * 64, value )
		   { }
		# endregion


		# region constructor with an existing ByteArray
		/// <summary>
		/// Builds a BitArray object from another BitArray object.
		/// </summary>
		/// <param name="ba">Bit array to be cloned.</param>
		public BitArray ( BitArray  ba )
		   {
			this. __Bits		=  ( ulong [] ) ba. __Bits. Clone ( ) ;
			this. __Size		=  ba. __Size ;
			this. __ArraySize	=  ba. __ArraySize ;
			this. __LastItemMask	=  ba. __LastItemMask ;
		    }
		# endregion

		# endregion


		# region  Bit getter/setter
		/// <summary>
		/// Get the value of a bit at the specified position.
		/// </summary>
		/// <param name="index">Bit position (from 0 to Length - 1).</param>
		/// <returns>A boolean value indicating whether the specified bit is set or not.</returns>
		public bool  Get ( int  index )
		   {
			// Check input parameters
			if  ( index  <  0  ||  index  >=  this. __Size )
				throw new ArgumentOutOfRangeException ( "index" ) ;

			int	ulong_index	=  index / BIT_COUNT ;		// Get desired item index in the __Bits array
			int	bit_index	=  index % BIT_COUNT ;		// Then the appropriate bit index within this item

			ulong	value		=  this. __Bits [ ulong_index ]  &  ( 1LU  <<  bit_index ) ;

			return ( ( value  ==  0 ) ? false : true ) ;
		    } 


		/// <summary>
		/// Sets the value of a bit at the specified position.
		/// </summary>
		/// <param name="index">Bit position (from 0 to Length - 1).</param>
		/// <param name="value">A boolean value indicating whether the specified bit should be set or not.</param>
		public void  Set ( int  index, bool  value )
		   {
			if  ( index  <  0  ||  index  >=  this. __Size )
				throw new ArgumentOutOfRangeException ( "index" ) ;

			int	ulong_index	=  index / BIT_COUNT ;
			int	bit_index	=  index % BIT_COUNT ;

			if  ( value )
				this. __Bits [ ulong_index ]  |=  ( 1LU  <<  bit_index ) ;
			else
				this. __Bits [ ulong_index ]  &=  ~( 1LU  <<  bit_index ) ;

			VersionUpdate ( ) ;
		    } 

		
		/// <summary>
		/// Toggles the value of a bit at the specified position.
		/// <para>
		/// If the bit was false, it will be set to true.
		/// </para>
		/// <para>
		/// If the bit was true, it will be set to false.
		/// </para>
		/// </summary>
		/// <param name="index">Bit position (from 0 to Length - 1).</param>
		public void  Toggle ( int  index )
		   {
			if  ( index  <  0  ||  index  >=  this. __Size )
				throw new ArgumentOutOfRangeException ( "index" ) ;

			int	ulong_index	=  index / BIT_COUNT ;
			int	bit_index	=  index % BIT_COUNT ;
			ulong   mask		=  ( 1U  <<  bit_index ) ;

			if ( ( this. __Bits [ ulong_index ]  &  mask )  ==  0 )
				this. __Bits [ ulong_index ]  |=  mask ;
			else
				this. __Bits [ ulong_index ]  &=  ~mask ;

			MaskLast ( ) ;
			VersionUpdate ( ) ;
		    }

		
		/// <summary>
		/// Set all bits in the BitArray to either true or false.
		/// </summary>
		/// <param name="value">Boolean value to be used to set all bits in the bit array.</param>
		public void  SetAll ( bool  value )
		   {
			ulong		new_value	=  ( value ) ? 0xFFFFFFFFFFFFFFFF : 0x0000000000000000 ;


			for  ( int  i = 0 ; i < this. __ArraySize ; i ++ )
				this. __Bits [i] = new_value ;

			MaskLast ( ) ;
			VersionUpdate ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Returns the bit values of the bit array.
		/// </summary>
		internal ulong []  Bits
		   {
			get { return ( this. __Bits ) ; }
		    }


		/// <summary>
		/// Gets the number of bits set to one.
		/// For performance reasons, this property uses a built-in table that has the count of raised bits for each value
		/// between 0 and 65535.
		/// </summary>
		public int  Count 
		   {
			get
			   {
				int		result		=  0 ;

				// Loop through each ulong value in the bit array
				for  ( int  i = 0 ; i < this. __ArraySize ; i ++ )
				   {
					ulong		word		=  this. __Bits [i] ;
					ushort		value ;

					// Get 16-bits chunk #1
					value	=  ( ushort ) ( word  &  0xFFFF ) ;
					result +=  Math. BitsInWord [ value ] ;

					// Get 16-bits chunk #2
					value	=  ( ushort ) ( ( word  >>  16 )  &  0xFFFF ) ;
					result +=  Math. BitsInWord [ value ] ;

					// Get 16-bits chunk #3
					value	=  ( ushort ) ( ( word  >>  32 )  &  0xFFFF ) ;
					result +=  Math. BitsInWord [ value ] ;

					// Get 16-bits chunk #4
					value	=  ( ushort ) ( ( word  >>  48 )  &  0xFFFF ) ;
					result +=  Math. BitsInWord [ value ] ;
				    }

				// All done, return
				return ( result ) ;
			    }
		    }


		/// <summary>
		/// Gets/sets the high bit value.
		/// </summary>
		public bool  HighBit
		   {
			get { return ( this [ this. __Size - 1 ] ) ; }
			set { this [ this. __Size - 1 ] = value ; }
		    }


		/// <summary>
		/// Gets/sets the length of the bit array.
		/// <para>
		/// When the length is set, values from the bit array are preserved. However, if the bit array is shrinked, shrinked items
		/// will be lost.
		/// </para>
		/// </summary>
		public int  Length
		   {
			get { return ( this. __Size ) ; }
			
			set
			   {
				// Check parameter values
				if  ( value  <  1 )
					throw new ArgumentOutOfRangeException ( "size" ) ;

				// Save original array contents
				ulong []	Saved	=  new ulong [ this. __ArraySize ] ;

				Array. Copy ( this. __Bits, Saved, this. __ArraySize ) ;

				// Initialize (again) this object's members
				this. __Size		=  value ;
				this. __ArraySize	=  ( value + BIT_COUNT - 1 ) / BIT_COUNT ;
				this. __Bits		=  new  ulong [ this. __ArraySize ] ;
				this. __LastItemMask	=  0 ;
			
				// Build the mask for the last item in the __Bits array
				BuildTrailingMask ( ) ;

				// Copy existing items to new array
				for  ( int  i = 0 ; i  <  Math.Min<int> ( value, Saved. Length ) ; i ++ )
					this. __Bits [i]	=  Saved [i] ;

				// Mask the last item in the __Bits array
				MaskLast ( ) ;
				
				VersionUpdate ( ) ;
			    }
		    }


		/// <summary>
		/// Gets/sets the low bit value.
		/// </summary>
		public bool  LowBit 
		   {
			get { return ( this [0] ) ; }
			set { this [0] = value ; }
		    }


		/// <summary>
		/// Gets/sets the bit at the specified position.
		/// </summary>
		/// <param name="index">Bit position in the bit array.</param>
		public bool  this [ int  index ]
		   {
			get { return ( Get ( index ) ) ; }
			set { Set ( index, value ) ; }
		    }
		# endregion


		# region Other public functions
		/// <summary>
		/// Clears the BitArray object. This is quite the same as assigning the value 0 (zero) to an existing object,
		/// excepts that it does not need to allocate a new BitArray for holding the zero value before assignment.
		/// </summary>
		public void  Clear ( ) 
		   {
			for  ( int  i = 0 ; i  <  this. __ArraySize ; i ++ )
				this. __Bits [i]  =  0 ;
		    }
		# endregion


		# region Overridable methods
		/// <summary>
		/// Checks if two BitArray objects are equal.
		/// </summary>
		/// <param name="obj">BitArray object to be compared to.</param>
		/// <returns>True if both objects are equal, false otherwise.</returns>
		/// <remarks>
		/// If <paramref name="obj"/> is not a BitArray object, the function will return false.
		/// </remarks>
		public override bool  Equals ( object obj )
		   {
			if  ( obj  is  BitArray )
				return ( this. __Bits. Equals ( ( obj  as  BitArray ). __Bits ) ) ;
			else
				return ( false ) ;
		    }


		/// <summary>
		/// Gets the hash code for this object.
		/// </summary>
		public override int  GetHashCode ( )
		   {
			return ( this. __Bits. GetHashCode ( ) ) ;
		    }


		/// <summary>
		/// Converts a bit array to a string representation of zeros and ones.
		/// </summary>
		public override string  ToString ( )
		   {
			String		Result		=  "" ;
			int		Count		=  0 ;


			for  ( int  i = 0 ;  i  <  this. __ArraySize ; i ++ )
			   {
				for  ( int  j = 0 ; j  <  BIT_COUNT ; j ++ )
				   {
					ulong	mask		=  ( 1U  <<  j ) ;

					Result  =  ( ( ( this. __Bits [i]  &  mask )  ==  0 ) ?  BitUnsetString : BitSetString ) + Result ;

					Count ++ ;

					if  ( Count  >=  this. __Size )
						goto  Done ;
				     }
			    }

Done:
			return ( Result ) ;
		    }
		# endregion


		# region Helper methods
		/// <summary>
		/// Checks if the BitArray is all zero.
		/// </summary>
		/// <returns>True if the bit array contains only zeros, false otherwise.</returns>
		private bool	IsNull ( )
		   {
			for  ( int  i = 0 ;  i  <  this. __ArraySize ; i ++ )
			   {
				if  ( this. __Bits [i]  !=  0 )
					return ( false ) ;
			    }

			return ( true ) ;
		    }

		
		/// <summary>
		/// Checks if the BitArray contains non-zero values.
		/// </summary>
		/// <returns>True if the bit array contains non-zero values, false otherwise.</returns>
		private bool	IsNotNull ( )
		   {
			for  ( int  i = 0 ;  i  <  this. __ArraySize ; i ++ )
			   {
				if  ( this. __Bits [i]  !=  0 )
					return ( true ) ;
			    }

			return ( false ) ;
		    }


		/// <summary>
		/// The last ulong value of the __Bits array may have unused bits. This function ensures that they are all set to zero.
		/// </summary>
		private void	MaskLast ( )
		   {
			this. __Bits [ this. __ArraySize - 1 ]  &=  this. __LastItemMask ;
		    }


		/// <summary>
		/// Builds the mask that will be used by the MaskLast() function to mask the unused bits of the very last ulong item
		/// of the __Bits array.
		/// </summary>
		private void	BuildTrailingMask ( )
		   {
			/***
				this. __LastItemMask	=  0 ;
			
				int	bit_index	=  this. __Size % BIT_COUNT ;

				for  ( int  i  =  0 ; i  <  bit_index ; i ++ )
					this. __LastItemMask	|=  ( 1U  <<  i ) ;
			 ***/

			this. __LastItemMask	=   Math. MaskUInt64FromRight [ this. __Size % BIT_COUNT ] ;
		    }


		/// <summary>
		/// Updates the object version (upgrade count). This is only used when enumerating the object, to check that the BitArray
		/// has not been modified since the start of the enumeration.
		/// </summary>
		private void	VersionUpdate ( )
		   { this. __Version ++ ; }


		/// <summary>
		/// Generic function used to convert an input array of chars (string), bytes, shorts, ints, etc. to the bit array
		/// stored in the __Bits member.
		/// </summary>
		/// <typeparam name="TA">
		/// Compound type (such as String, byte[], int[], etc.).
		/// </typeparam>
		/// <typeparam name="T">
		/// Item type for elements of the compound type.
		/// </typeparam>
		/// <param name="value">Compound type object.</param>
		/// <param name="bit_width">Bit width of item type (8 for byte, 16 for short, etc.)</param>
		private void	ToBits<TA, T>  ( TA  value, int  bit_width )
					where  TA : IEnumerable
					where  T  : IConvertible
		   {
			int	max_items	=  ( this. __Size + bit_width - 1 ) / bit_width ;	
											// Max bytes to be processed
			int     item_count	=  ( BIT_COUNT / bit_width ) ;		// Number of items in one word of the __Bits array
			int	current_word	=  0 ;					// Current word in the __Bits array
			int	current_item	=  0 ;					// Current byte in the current word (0..7)
			int	shift_count	=  0 ;					// Number of shifts for current item (the value will be shifted
											// that count and or'ed with the current word)
			int	index		=  0 ;					// Current index in the "value" parameter


			// Since we simply or() consecutive items with the current word, this one must initially be zero.
			this. __Bits [ current_word ]	=  0 ;

			// Loop through each item
			foreach  ( T  item  in  value )
			   {
				current_item	=  ( index % item_count ) ;		// Get current byte number in current word
				index ++ ;						// Item index in input value

				// or() the current item (shifted by item_count) with the current word
				this.__Bits [ current_word ]  |=  ( ulong ) Convert. ToInt64 ( item )  <<  shift_count ;

				// Count one more byte
				current_item ++ ;

				// If we arrived at the very last byte of the word, then we must use the next word of the __Bits array.
				if  ( current_item  >=  item_count )
				   {
					current_item				=  0 ;	// Reset to initial values
					shift_count				=  0 ;
					current_word ++ ;				// Go to next word

					// If we did not reach the end of the __Bits array, then initialize this new current word to zero
					if  ( current_word  <   this. __ArraySize )
						this. __Bits [ current_word ]   =  0 ;
				    }
				// Otherwise, simply update the shift count for the next loop iteration
				else
					shift_count  +=  bit_width ;

				// Stop if we processed enough bytes
				if  ( index  >=  max_items )
					break ;
			    }
		    }


		/// <summary>
		/// Generates an array of T from the __Bits member values.
		/// </summary>
		/// <typeparam name="T">Type of items for the returned array.</typeparam>
		/// <param name="bit_width">Size of an item, in bits.</param>
		/// <returns>An array of T[] mapped to the values of the __Bits member.</returns>
		private T []  FromBits<T> ( int  bit_width )
				where  T : struct 
		   {
			int		max_items		=  ( this. __Size + bit_width - 1 ) / bit_width ;	// Max items contained in __Bitss
			int		max_items_per_word	=  BIT_COUNT / bit_width ;				// Item count for each __Bits word
			int		current_word		=  0 ;							// Current word being processed
			int		current_item		=  0 ;							// Current item in current word
			ulong		value ;										// Holds __Bits [current_word]
			ulong		mask			=  0 ;							// All ones up to bit_width bits
			TypeCode	type_code		=  Type. GetTypeCode ( typeof ( T ) ) ;			// Type code of returning type
			T []		result			=  new T [ max_items ] ;				// Resulting array
			ulong		ivalue ;									// Current input masked value
			Object		ovalue ;									// Output value to be added to result[]


			// Get current word
			value	=  this. __Bits [0] ;

			// Build a mask of all ones up to bit_width bits
			for  ( int  i = 0 ; i < bit_width ; i ++ )
				mask |= ( 1LU << i ) ;

			// Loop through __Bits items
			for  ( int  i = 0 ; i  <  max_items ; i ++ )
			   {
				// Mask the current input value to isolate the current item
				ivalue		=  value & mask ;

				// Depending on the type code of T, box the input value to an object having the correct underlying type
				switch ( type_code )
				   {
					case	TypeCode. Boolean :  
						ovalue	=  ( object ) ( ( ivalue  ==  0 ) ?  false : true ) ;
						break ;

					case    TypeCode. Byte :
						ovalue	=  ( object ) ( byte ) ivalue ;
						break ;

					case	TypeCode. Char :
						ovalue  =  ( object ) ( char ) ivalue ;
						break ;

					case	TypeCode. Int16 :
						ovalue	=  ( object ) ( short ) ivalue ;
						break ;

					case	TypeCode. Int32 :
						ovalue  =  ( object ) ( int ) ivalue ;
						break ;

					case	TypeCode. Int64 :
						ovalue	=  ( object ) ( long ) ivalue ;
						break ;

					case    TypeCode. SByte :
						ovalue  =  ( object ) ( sbyte ) ivalue ;
						break ;

					case	TypeCode. UInt16 :
						ovalue  =  ( object ) ( ushort ) ivalue ;
						break ;

					case	TypeCode. UInt32 :
						ovalue  =  ( object ) ( uint ) ivalue ;
						break ;

					case    TypeCode. UInt64 :
						ovalue  =  ( object ) ( ulong ) ivalue ;
						break ;

					case    TypeCode. Single :
						ovalue  =  ( object ) ( float ) ivalue ;
						break ;

					case    TypeCode. Double :
						ovalue  =  ( object ) ( double ) ivalue ;
						break ;

					default :
						ovalue	=  null ;
						break ;
				    }
				
				// Add to resulting array		
				result [i]	=  ( T ) ovalue ;

				// Count one item more in current word
				current_item ++ ;

				// If maximum number of items reached, reset current item and move to next word
				if  ( current_item  >=  max_items_per_word )
				   {
					current_item		=  0 ;
					current_word ++ ;

					// Set value to the new current word in __Bits, if last word not reached
					if  ( current_word  <  this. __ArraySize )
						value	=  this. __Bits [ current_word ] ;
				    }
				// Otherwise shift current value right by bit_width bits.
				else
					value  >>=  bit_width ;
			    }

			// All done, return
			return ( result ) ;
		    }
		# endregion


		# region Bitwise operations
		/// <summary>
		/// Performs a bitwise NOT operation on the bit array.
		/// </summary>
		/// <returns>The original bit array, after the bitwise NOT operation.</returns>
		public BitArray  Not ( )
		   {
			for  ( int  i  =  0 ; i  <  this. __ArraySize ; i ++ )
				this. __Bits [i]	=  ~this. __Bits [i] ;

			MaskLast ( ) ;
			VersionUpdate ( ) ;

			return ( this ) ;
		    }


		/// <summary>
		/// Performs a bitwise NOT operation on a bit array.
		/// </summary>
		/// <param name="a">Bit array on which the operation is to be applied.</param>
		/// <returns>A new bit array, corresponding to the bitwise NOT operation of <paramref name="a"/>.</returns>
		public static BitArray operator  ~ ( BitArray  a )
		   {
			BitArray	b	=  new BitArray ( a ) ;

			return ( b. Not ( ) ) ;
		    }


		/// <summary>
		/// Performs a bitwise OR operation between this array and the one specified by <paramref name="a"/>.
		/// </summary>
		/// <param name="a">Bit array to be OR'ed with the current object.</param>
		/// <returns>The current object, OR'ed with the <paramref name="a"/> parameter.</returns>
		public BitArray		Or ( BitArray  a )
		   {
			for  ( int  i = 0 ; i  <  a. __ArraySize ; i ++ )
				this. __Bits [i] = a. __Bits [i]  |  this. __Bits [i] ;

			VersionUpdate ( ) ;

			return ( this ) ;
		    }


		/// <summary>
		/// Performs a bitwise OR operation on two byte arrays.
		/// </summary>
		/// <param name="a">First byte array.</param>
		/// <param name="b">Second byte array.</param>
		/// <returns>
		/// A new object corresponding to <paramref name="a"/> OR <paramref name="b"/>.
		/// </returns>
		public static BitArray operator  |  ( BitArray  a, BitArray  b )
		   {
			if  ( ( object ) a  ==  null )
				throw new  ArgumentException ( ) ;

			if  ( ( object ) b  ==  null )
				throw new  ArgumentException ( ) ;

			if  (  a. __Size  !=  b. __Size )
				throw new ArgumentException ( "BitArray arguments must have the same size." ) ;

			BitArray	c	=  new BitArray ( a ) ;

			return ( c. Or ( b ) ) ;
		    }


		/// <summary>
		/// Performs a bitwise AND operation between this array and the one specified by <paramref name="a"/>.
		/// </summary>
		/// <param name="a">Bit array to be AND'ed with the current object.</param>
		/// <returns>The current object, AND'ed with the <paramref name="a"/> parameter.</returns>
		public BitArray		And ( BitArray  a )
		   {
			for  ( int  i = 0 ; i  <  a. __ArraySize ; i ++ )
				this. __Bits [i] = a. __Bits [i]  &  this. __Bits [i] ;

			VersionUpdate ( ) ;

			return ( this ) ;
		    }


		/// <summary>
		/// Performs a bitwise AND operation on two byte arrays.
		/// </summary>
		/// <param name="a">First byte array.</param>
		/// <param name="b">Second byte array.</param>
		/// <returns>
		/// A new object corresponding to <paramref name="a"/> AND <paramref name="b"/>.
		/// </returns>
		public static BitArray operator  &  ( BitArray  a, BitArray  b )
		   {
			if  ( ( object ) a  ==  null )
				throw new  ArgumentException ( ) ;

			if  ( ( object ) b  ==  null )
				throw new  ArgumentException ( ) ;

			if  (  a. __Size  !=  b. __Size )
				throw new ArgumentException ( "BitArray arguments must have the same size." ) ;

			BitArray	c	=  new BitArray ( a ) ;

			return ( c. And ( b ) ) ;
		    }


		/// <summary>
		/// Performs a bitwise XOR operation between this array and the one specified by <paramref name="a"/>.
		/// </summary>
		/// <param name="a">Bit array to be XOR'ed with the current object.</param>
		/// <returns>The current object, XOR'ed with the <paramref name="a"/> parameter.</returns>
		public BitArray		Xor ( BitArray  a )
		   {
			for  ( int  i = 0 ; i  <  a. __ArraySize ; i ++ )
				this. __Bits [i] = a. __Bits [i]  ^  this. __Bits [i] ;

			MaskLast ( ) ;
			VersionUpdate ( ) ;

			return ( this ) ;
		    }


		/// <summary>
		/// Performs a bitwise XOR operation on two byte arrays.
		/// </summary>
		/// <param name="a">First byte array.</param>
		/// <param name="b">Second byte array.</param>
		/// <returns>
		/// A new object corresponding to <paramref name="a"/> XOR <paramref name="b"/>.
		/// </returns>
		public static BitArray operator  ^  ( BitArray  a, BitArray  b )
		   {
			if  ( ( object ) a  ==  null )
				throw new  ArgumentException ( ) ;

			if  ( ( object ) b  ==  null )
				throw new  ArgumentException ( ) ;

			if  (  a. __Size  !=  b. __Size )
				throw new ArgumentException ( "BitArray arguments must have the same size." ) ;

			BitArray	c	=  new BitArray ( a ) ;

			return ( c. Xor ( b ) ) ;
		    }
		# endregion


		# region Logical operators
		/// <summary>
		/// Checks if the specified bit array is true (non-zero).
		/// </summary>
		/// <param name="a">Bit array to be checked.</param>
		/// <returns>True if the <paramref name="a"/> paramerer is non-zero, false otherwise.</returns>
		public static bool operator  true  ( BitArray  a )
		   { return ( a. IsNotNull ( ) ) ; }


		/// <summary>
		/// Checks if the specified bit array is false (all zeros).
		/// </summary>
		/// <param name="a">Bit array to be checked.</param>
		/// <returns>True if the <paramref name="a"/> paramerer is zero, false otherwise.</returns>
		public static bool operator  false ( BitArray  a )
		   { return ( a. IsNull ( ) ) ; }


		/// <summary>
		/// Checks if two bit arrays are equal.
		/// </summary>
		/// <param name="a">First bit array.</param>
		/// <param name="b">Second bit array.</param>
		/// <returns>True if both bit arrays are equal, false otherwise.</returns>
		public static bool operator  ==  ( BitArray  a, BitArray  b )
		   { return ( a. __Bits. Equals ( b. __Bits ) ) ; }


		/// <summary>
		/// Checks if two bit arrays are different.
		/// </summary>
		/// <param name="a">First bit array.</param>
		/// <param name="b">Second bit array.</param>
		/// <returns>True if bit arrays are different, false otherwise.</returns>
		public static bool operator  !=  ( BitArray  a, BitArray  b )
		   { return ( a. __Bits. Equals ( b. __Bits ) ) ; }


		/// <summary>
		/// Logical operation that inverts the non-null state of a bit array.
		/// </summary>
		/// <param name="a">Bit array to be tested.</param>
		/// <returns>True if the bit array is zero, false otherwise.</returns>
		public static bool operator  !  ( BitArray  a )
		   { return ( a. IsNull ( ) ) ; }
		# endregion


		# region Cast operators

		# region Cast from something to ByteArray
		/// <summary>
		/// Casts a bool value to a BitArray of size 8.
		/// </summary>
		public static implicit operator  BitArray ( bool  value )
		   { return ( new BitArray ( 8, value ) ) ; }


		/// <summary>
		/// Casts a byte value to a BitArray of size 8.
		/// </summary>
		public static implicit operator  BitArray ( byte  value )
		   { return ( new BitArray ( 8, value ) ) ; }


		/// <summary>
		/// Casts a sbyte value to a BitArray of size 8.
		/// </summary>
		public static implicit operator  BitArray ( sbyte  value )
		   { return ( new BitArray ( 8, value ) ) ; }


		/// <summary>
		/// Casts a ushort value to a BitArray of size 16.
		/// </summary>
		public static implicit operator  BitArray ( ushort  value )
		   { return ( new BitArray ( 16, value ) ) ; }


		/// <summary>
		/// Casts a short value to a BitArray of size 16.
		/// </summary>
		public static implicit operator  BitArray ( short  value )
		   { return ( new BitArray ( 16, value ) ) ; }


		/// <summary>
		/// Casts a uint value to a BitArray of size 32.
		/// </summary>
		public static implicit operator  BitArray ( uint  value )
		   { return ( new BitArray ( 32, value ) ) ; }


		/// <summary>
		/// Casts an int value to a BitArray of size 32.
		/// </summary>
		public static implicit operator  BitArray ( int  value )
		   { return ( new BitArray ( 32, value ) ) ; }


		/// <summary>
		/// Casts a ulong value to a BitArray of size 64.
		/// </summary>
		public static implicit operator  BitArray ( ulong  value )
		   { return ( new BitArray ( 64, value ) ) ; }


		/// <summary>
		/// Casts a long value to a BitArray of size 64.
		/// </summary>
		public static implicit operator  BitArray ( long  value )
		   { return ( new BitArray ( 64, value ) ) ; }


		/// <summary>
		/// Casts a float value to a BitArray of size 32.
		/// </summary>
		public static implicit operator  BitArray ( float  value )
		   { return ( new BitArray ( 32, value ) ) ; }


		/// <summary>
		/// Casts a float value to a BitArray of size 64.
		/// </summary>
		public static implicit operator  BitArray ( double  value )
		   { return ( new BitArray ( 64, value ) ) ; }


		/// <summary>
		/// Casts a char value to a BitArray of size 8.
		/// </summary>
		public static implicit operator  BitArray ( char  value )
		   { return ( new BitArray ( 8, value ) ) ; }

		/// <summary>
		/// Casts a string value to a BitArray of size 8 * string length.
		/// </summary>
		public static implicit operator  BitArray ( String  value )
		   { return ( new BitArray ( value ) ) ; }


		# endregion


		# region Cast from ByteArray to something
		/// <summary>
		/// Casts a bit array to a byte. Higher bits are truncated.
		/// </summary>
		public static implicit operator  byte ( BitArray  ba )
		   { return ( ( byte ) ( ba. __Bits [0] & 0xFFLU ) ) ; }


		/// <summary>
		/// Casts a bit array to a sbyte. Higher bits are truncated.
		/// </summary>
		public static implicit operator  sbyte ( BitArray  ba )
		   { return ( ( sbyte ) ( ba. __Bits [0] & 0xFFLU ) ) ; }


		/// <summary>
		/// Casts a bit array to a ushort. Higher bits are truncated.
		/// </summary>
		public static implicit operator  ushort ( BitArray  ba )
		   { return ( ( ushort ) ( ba. __Bits [0] & 0xFFFFLU ) ) ; }


		/// <summary>
		/// Casts a bit array to a short. Higher bits are truncated.
		/// </summary>
		public static implicit operator  short ( BitArray  ba )
		   { return ( ( short ) ( ba. __Bits [0] & 0xFFFFLU ) ) ; }


		/// <summary>
		/// Casts a bit array to a uint. Higher bits are truncated.
		/// </summary>
		public static implicit operator  uint ( BitArray  ba )
		   { return ( ( uint ) ( ba. __Bits [0] & 0xFFFFFFFFLU ) ) ; }


		/// <summary>
		/// Casts a bit array to an int. Higher bits are truncated.
		/// </summary>
		public static implicit operator  int ( BitArray  ba )
		   { return ( ( int ) ( ba. __Bits [0] & 0xFFFFFFFFLU ) ) ; }


		/// <summary>
		/// Casts a bit array to a ulong. Higher bits are truncated.
		/// </summary>
		public static implicit operator  ulong ( BitArray  ba )
		   { return ( ba. __Bits [0] ) ; }


		/// <summary>
		/// Casts a bit array to a long. Higher bits are truncated.
		/// </summary>
		public static implicit operator  long ( BitArray  ba )
		   { return ( ( long ) ba. __Bits [0] ) ; }


		/// <summary>
		/// Casts a bit array to a float. Higher bits are truncated. An exception can be thrown if the underlying value
		/// no more represents a valid float value.
		/// </summary>
		public static implicit operator  float ( BitArray  ba )
		   {
			float		result ;


			unsafe 
			   {
				fixed ( ulong	* q	=  & ( ba. __Bits [0] ) )
				   {
					uint	ivalue	=  ( uint ) * q ;

					result = * ( float * ) ( & ivalue ) ;
				    }
			    }

			return ( result ) ;
		    }


		/// <summary>
		/// Casts a bit array to a double. Higher bits are truncated. An exception can be thrown if the underlying value
		/// no more represents a valid double value.
		/// </summary>
		public static implicit operator  double ( BitArray  ba )
		   {
			double		result ;


			unsafe 
			   {
				fixed ( ulong	* q	=  & ( ba. __Bits [0] ) )
				   {
					result = * ( double * ) ( q ) ;
				    }
			    }

			return ( result ) ;
		    }


		/// <summary>
		/// Casts a bit array to a char. Higher bits are truncated.
		/// </summary>
		public static implicit operator  char ( BitArray  ba )
		   { return ( ( char ) ba. __Bits [0] ) ; }


		# endregion


		# region Cast from Array of something to BitArray
		/// <summary>
		/// Casts an array of bools to a BitArray.
		/// </summary>
		/// <remarks>
		/// Note that the 1st element of the array is bit 0 ; last element is bit n.
		/// </remarks>
		public static implicit operator  BitArray  ( bool []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of chars to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( char []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of bytes to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( byte []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of sbytes to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( sbyte []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of shorts to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( short []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of ushorts to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( ushort []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of ints to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( int []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of uints to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( uint []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of longs to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( long []  value )
		   { return ( new BitArray ( value ) ) ; }


		/// <summary>
		/// Casts an array of ulongs to a BitArray.
		/// </summary>
		public static implicit operator  BitArray  ( ulong []  value )
		   { return ( new BitArray ( value ) ) ; }
		# endregion


		# region Cast from BitArray to Array of something
		/// <summary>
		/// Casts a BitArray to an array of bools.
		/// </summary>
		public static implicit operator bool []  ( BitArray  ba )
		   { return ( ba. FromBits<bool> ( 1 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of chars.
		/// </summary>
		public static implicit operator char []  ( BitArray  ba )
		   { return ( ba. FromBits<char> ( 8 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of bytes.
		/// </summary>
		public static implicit operator byte []  ( BitArray  ba )
		   { return ( ba. FromBits<byte> ( 8 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of sbytes.
		/// </summary>
		public static implicit operator sbyte []  ( BitArray  ba )
		   { return ( ba. FromBits<sbyte> ( 8 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of shorts.
		/// </summary>
		public static implicit operator short []  ( BitArray  ba )
		   { return ( ba. FromBits<short> ( 16 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of ushorts.
		/// </summary>
		public static implicit operator ushort []  ( BitArray  ba )
		   { return ( ba. FromBits<ushort> ( 16 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of ints.
		/// </summary>
		public static implicit operator int []  ( BitArray  ba )
		   { return ( ba. FromBits<int> ( 32 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of uints.
		/// </summary>
		public static implicit operator uint []  ( BitArray  ba )
		   { return ( ba. FromBits<uint> ( 32 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of longs.
		/// </summary>
		public static implicit operator long []  ( BitArray  ba )
		   { return ( ba. FromBits<long> ( 64 ) ) ; }


		/// <summary>
		/// Casts a BitArray to an array of ulongs.
		/// </summary>
		public static implicit operator ulong []  ( BitArray  ba )
		   { return ( ba. FromBits<ulong> ( 64 ) ) ; }


		# endregion

		# endregion


		# region Interface implementations

		# region ICloneable interface implementation
		/// <summary>
		/// Clone this bit array.
		/// </summary>
		/// <returns>A new BitArray object.</returns>
		/// <remarks>
		/// Deep copy is not used.
		/// </remarks>
		public object Clone ( )
		   {
			return ( new BitArray ( this ) ) ;
		    }
		# endregion


		# region IEnumerable interface implementation
		/// <summary>
		/// Returns an Enumerator object to enumerate all the bits within the bit array.
		/// </summary>
		/// <returns>An Enumerator object.</returns>
		IEnumerator IEnumerable. GetEnumerator ( )
		   {
			return ( new  BitArrayEnumerator ( this ) ) ;
		    }
		# endregion


		# region BitArrayEnumerator class
		/// <summary>
		/// Enumerator object for this class. Allows for enumerating individual bits of the bit array.
		/// </summary>
		[Serializable]
		private class	BitArrayEnumerator : IEnumerator, ICloneable 
		   {
			private BitArray		BitArray ;		// Enumerated bit array
			private bool			CurrentValue ;		// Current bit value
			private int			Index ;			// Current bit index
			private int			Version ;		// Original BitArray "version"

			
			// Clones this enumerator
			public object Clone () 
			   {
				return ( MemberwiseClone ( ) ) ;
			    }
			    
			
			// Class constructor
			public BitArrayEnumerator ( BitArray  ba )
			   {
				Index		=  -1 ;
				BitArray	=  ba ;
				Version		=  ba. __Version ;
			    }

			
			// Get current bit value
			public object Current 
			   {
				get 
				   {
					if  ( Index  ==  -1 )
						throw new InvalidOperationException ( Resources. Localization. Classes. Enumerator. EnumerationNotStarted ) ;

					if ( Index  >=  BitArray. Length )
						throw new InvalidOperationException (  Resources. Localization. Classes. Enumerator. EnumerationEnded ) ;
					
					return ( CurrentValue ) ;
				     }
			    }


			// Move to the next bit
			public bool MoveNext ( )
			   {
				// Check that the enumerated BitArray object did not change since the start of the enumeration
				CheckVersion ( ) ;

				// Check if we still have things to enumerate and, if yes, update current bit value
				if  ( Index  <  BitArray. __ArraySize - 1 )
				   {
					CurrentValue = BitArray [ ++ Index ] ;
					return ( true ) ;
				    }

				// End of enumeration...
				Index = BitArray. __ArraySize ;
				return ( false ) ;
			    }


			// Restarts the enumeration
			public void	Reset  ( )
			   {
				// Check that the enumerated BitArray object did not change since the start of the enumeration
				CheckVersion ( ) ;

				Index	=  -1 ;
			    }
			

			// This function checks that the initial BitArray version is still the same.
			// Otherwise this means that the object has been changed during the enumeration.
			private void  CheckVersion ( )
			{
				if  ( Version  !=  BitArray. __Version )
					throw new InvalidOperationException ( Resources. Localization. Classes. Enumerator. EnumerationStructureChanged ) ;
			}
		}
		# endregion

		# endregion
	   }
    }
