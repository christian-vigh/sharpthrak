/**************************************************************************************************************

    NAME
        BitStructure.cs

    DESCRIPTION
        Maps an integral value to a structure of bits.
	The structure is a class deriving from the BitLayout class ; each field corresponds to a bit or bit
	range mapped to the underlying ulong value.
	
	Here is an example :

		public enum WM_ACTIVATE_REASON
		   {
			WA_INACTIVE	=  0,
			WA_ACTIVE	=  1,
			WA_CLICKACTIVE	=  2
		    }

		public class  WM_ACTIVATE_WPARAM	: BitLayout
		   {
			public  WM_ACTIVATE_WPARAM ( ) : base ( 32 )
			   { }

			[LOWORD ( )]
			public BitField<WM_ACTIVATE_REASON>		Reason ;

			[HIWORD ( )]
			public BitField<int>				Minimized ;	

			[Bit(31)]
			public BitField<bool>				ZZ  = true ;
		    }

	A few remarks about this example :
	- The BitLayout constructor must be called by specifying the value width in bits (here 32). Valid value
	  widths range from 1 to 64.
	- The class must declare every bit or bitrange field as a BitField<T> type, where T can be any integral
	  type, including booleans and enumerations
	- Each BitField<T> field must have one of the following attributes :
		- Bit ( int position ) :
			Defines a value at the specified bit position in the underlying ulong value. The value
			type is typically boolean (true for 1, false for 0) but can also be mapped to any
			supported integral type.
			Bit positions are numbered from 0 to BitLayout width - 1.
		- Bits ( int  start, int  end ) :
			Defines a bit range.
		- LOWORD ( ) :
			Synonym for Bits ( 0, 15 ).
		- HIWORD ( ) :
			Synonym for Bits ( 16, 31 ).
		- LOBYTE ( ) :
			Synonym for Bits ( 0, 7 ).
		- HIBYTE ( ) :
			Synonym for Bits ( 8, 15 ).
		- LODWORD ( ) :
			Synonym for Bits ( 0, 31 ).
		- HIDWORD ( ) :
			Synonym for Bits ( 31, 63 ).
 
	You can set bit or bitrange values by directly setting the corresponding field value.
	The Value property get returns the combined values of individual fields. Conversely, the Value property
	set defines the values of each individual BitField<> fields.
	Note that you can overlap bits or bitranges within a BitLayout structure.
  
    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/17]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Collections. Generic ;
using   System. Reflection ;
using   System. Runtime. InteropServices ;


using   Thrak. Core ;


namespace Thrak. Structures
   {
	# region BitStructure exceptions
	/// <summary>
	/// Exception object base for the BitStructure exceptions.
	/// </summary>
	public class BitStructureException	:  ThrakException
	   {
		/// <summary>
		/// Throws an exception with the specified message.
		/// </summary>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		/// <param name="argv">Additional parameters for String.Format().</param>
		public BitStructureException ( String  message, params Object []  argv )
				: base ( String. Format ( message, argv ) )
		   { }


		/// <summary>
		/// Throws an exception with the specified message.
		/// </summary>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		public BitStructureException ( String  message )
				: base ( message )
		   { }
	    }


	/// <summary>
	/// Exception thrown when a bit position is out of range.
	/// </summary>
	public class BitPositionOutOfRangeException	:  BitStructureException
	   {
		public BitPositionOutOfRangeException ( int  position )
				: base ( Resources. Localization. Classes. BitStructure. XBitPositionOutOfRange, position ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when a starting bit is greater than the ending bit.
	/// </summary>
	public class InvalidBitRangeException	:  BitStructureException
	   {
		public InvalidBitRangeException ( int  bitmin, int  bitmax )
				: base ( Resources. Localization. Classes. BitStructure. XInvalidBitRange, bitmin, bitmax ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when the BitField underlying type is not a value type.
	/// </summary>
	public class InvalidTypeException	:  BitStructureException
	   {
		public InvalidTypeException ( Type  type )
				: base ( Resources. Localization. Classes. BitStructure. XInvalidType, type. Name ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when a BitField exceeds BitLayout width.
	/// </summary>
	public class InvalidWidthException	:  BitStructureException
	   {
		public InvalidWidthException ( int  width, String  field )
				: base ( Resources. Localization. Classes. BitStructure. XInvalidWidth, width, field ) 
		   { }
	    }
	# endregion


	# region BitsAttribute class and derived

	# region BitsAttributeBase class
	/// <summary>
	/// Base class for bit attributes used by BitLayout derivates.
	/// </summary>
	[AttributeUsage ( AttributeTargets. Field )]
	public abstract class  BitsAttributeBase	:  Attribute 
	   {
		# region Private data members
		int		__Min ;					// Min bit position
		int		__Max ;					// Max bit position
		ulong		__Mask			=  0 ;		// Mask used to isolate the bits attribute value
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a BitsAttribute object that occupies bits <paramref name="bitmin"/> to <paramref name="bitmax"/> in a BitLayout structure.
		/// </summary>
		/// <param name="bitmin">First bit position of the field.</param>
		/// <param name="bitmax">Last bit position of the field.</param>
		public  BitsAttributeBase ( int  bitmin, int  bitmax )
		   {
			// Check that bitmin and bitmax have authorized values
			if  ( bitmin  <  0  ||  bitmin  >  63 )
				throw new BitPositionOutOfRangeException ( bitmin ) ;

			if  ( bitmax  <  0  ||  bitmax  >  63 )
				throw new BitPositionOutOfRangeException ( bitmax ) ;

			// ... and that bitmin is less than or equal to bitmax
			if  ( bitmin  >  bitmax )
				throw new InvalidBitRangeException ( bitmin, bitmax ) ;

			// Save min and max bit positions
			__Min	=  bitmin ;
			__Max	=  bitmax ;

			// Build a mask to extract the bit range value
			for  ( int  i = bitmin ; i  <=  bitmax ; i ++ )
				__Mask  |=  ( ulong ) ( ( ulong ) 1  <<  i ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the min bit position.
		/// </summary>
		public int  Min
		   {
			get { return ( __Min ) ; }
		    }


		/// <summary>
		/// Gets the max bit position.
		/// </summary>
		public int  Max
		   {
			get { return ( __Max ) ; }
		    }


		/// <summary>
		/// Gets the bit mask used to extract the value.
		/// </summary>
		public ulong  Mask
		   {
			get { return ( __Mask ) ; }
		    }
		# endregion
	    }
	# endregion


	# region BitsAttributeBase derivates
	/// <summary>
	/// Specifies a range of bits.
	/// </summary>
	public class  BitsAttribute	:  BitsAttributeBase
	   {
		public BitsAttribute ( int  bitmin, int  bitmax ) :
				base ( bitmin, bitmax )
		   { }
	    }


	/// <summary>
	/// Specifies a bit at a specific position.
	/// </summary>
	public class  BitAttribute	:  BitsAttributeBase
	   {
		public BitAttribute ( int  position ) :
				base ( position, position )
		   { }
	    }


	/// <summary>
	/// Specifies a bit range corresponding to the low byte portion of the value.
	/// </summary>
	public class  LOBYTEAttribute	:  BitsAttributeBase
	   {
		public  LOBYTEAttribute ( ) : base ( 0, 7 )
		   { }
	    }
		

	/// <summary>
	/// Specifies a bit range corresponding to the high byte portion of the value.
	/// </summary>
	public class  HIBYTEAttribute	:  BitsAttributeBase
	   {
		public  HIBYTEAttribute ( ) : base ( 8, 15 )
		   { }
	    }


	/// <summary>
	/// Specifies a bit range corresponding to the low word portion of the value.
	/// </summary>
	public class  LOWORDAttribute	:  BitsAttributeBase
	   {
		public  LOWORDAttribute ( ) : base ( 0, 15 )
		   { }
	    }
		

	/// <summary>
	/// Specifies a bit range corresponding to the high word portion of the value.
	/// </summary>
	public class  HIWORDAttribute	:  BitsAttributeBase
	   {
		public  HIWORDAttribute ( ) : base ( 16, 31 )
		   { }
	    }


	/// <summary>
	/// Specifies a bit range corresponding to the low dword portion of the value.
	/// </summary>
	public class  LODWORDAttribute	:  BitsAttributeBase
	   {
		public  LODWORDAttribute ( ) : base ( 0, 31 )
		   { }
	    }
		

	/// <summary>
	/// Specifies a bit range corresponding to the high dword portion of the value.
	/// </summary>
	public class  HIDWORDAttribute	:  BitsAttributeBase
	   {
		public  HIDWORDAttribute ( ) : base ( 32, 63 )
		   { }
	    }
	# endregion

	# endregion


	# region BitLayout class
	/// <summary>
	/// Implements a bit layout upon an integral value.
	/// </summary>
	public abstract class  BitLayout
	   {
		# region Private data members
		int		__Width	;			// Layout width, in bytes (from 1 to 64)
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a BitLayout structure having the specified width (max is 64, the size of the longest integral type available).
		/// </summary>
		/// <param name="width">Width in bytes of the data value.</param>
		public  BitLayout ( int  width = 64 )	: this ( 0, width )
		   { }


		/// <summary>
		/// Builds a BitLayout structure having the specified width (max is 64, the size of the longest integral type available).
		/// </summary>
		/// <param name="value">Initial value.</param>
		/// <param name="width">Width in bytes of the data value.</param>
		public  BitLayout ( ulong  value, int  width  =  64 )
		   { 
			// Check width argument
			if  ( width  <  1  ||  width  >  64 )
				throw new ArgumentOutOfRangeException ( "width" ) ;

			__Width		=  width ;

			// Check structure layout
			CheckLayout ( ) ;

			// Save the initial value
			//Value		=  value ; 
		    }
		# endregion


		# region Private members
		/// <summary>
		/// Checks that the specified layout fits with the width declared when building the object.
		/// </summary>
		private void  CheckLayout ( )
		   {
			BitLayoutFieldInfo []	Fields		=  GetBitFields ( ) ;


			foreach  ( BitLayoutFieldInfo  Field  in  Fields )
			   {
				if  ( Field. BitsAttribute. Min >=  __Width  ||  Field. BitsAttribute. Max  >=  __Width )
					throw new InvalidWidthException ( __Width, Field.FieldInfo. Name ) ;
			    }
		    }


		/// <summary>
		/// Holds information about a BitsAttribute object (inherited from BitsAttributeBase).
		/// </summary>
		private struct  BitLayoutFieldInfo
		   {
			// Data members
			public BitLayout		Parent ;		// Parent BitLayout structure
			public FieldInfo		FieldInfo ;		// Field mentioning the BitsAttributeBase attribute
			public BitsAttributeBase	BitsAttribute ;		// BitsAttributeBase object


			/// <summary>
			/// Builds a BitLayoutFieldInfo structure.
			/// </summary>
			/// <param name="parent">Parent BitLayout structure.</param>
			/// <param name="info">Information about the field having a BitsAttributeBase attribute.</param>
			/// <param name="bits">BitsAttributeBase object.</param>
			public  BitLayoutFieldInfo ( BitLayout  parent, FieldInfo  info, BitsAttributeBase  bits )
			   {
				Parent		=  parent ;
				FieldInfo	=  info ;
				BitsAttribute	=  bits ;
			    }


			/// <summary>
			/// Gets/sets the value of the field having a BitsAttributeBase attribute.
			/// </summary>
			public ulong	Value
			   {
				get
				   {
					dynamic		FieldValue	=  FieldInfo. GetValue ( Parent ) ;


					// Handle uninitialized field values
					if  ( FieldValue  ==  null )
						return ( 0 ) ;
					else
						return ( ( ulong ) Convert. ToUInt64 ( FieldValue. Value ) ) ;
				    }


				set 
				   { 
					Type 		BitFieldType	=  FieldInfo. FieldType. GetGenericArguments ( ) [0] ;
					dynamic		FieldValue	=  FieldInfo. GetValue ( Parent ) ;

					
					FieldValue. SetValue ( value ) ;
				    }
			    }
		    }


		/// <summary>
		/// Gets an array of all the fields in a BitLayout structure having the BitsAttributeBase attribute.
		/// </summary>
		/// <returns>Array of found fields.</returns>
		private  BitLayoutFieldInfo []  GetBitFields ( )
		   {
			FieldInfo []			Fields		=  this. GetType ( ). GetFields ( BindingFlags. GetField | BindingFlags. Instance | 
														BindingFlags. Public ) ;
			List<BitLayoutFieldInfo>	BitFields	=  new List<BitLayoutFieldInfo> ( ) ;


			// Loop through BitLayout fields
			foreach  ( FieldInfo  Field  in  Fields )
			   {
				Object []		Attributes	=  Field. GetCustomAttributes ( true ) ;

				// Check for each individual attribute
				foreach  ( Attribute  Attribute  in  Attributes )
				   {
					// If a BitsAttributeBase attribute is found, then we're done : simply add this object to the resulting list.
					if  ( Attribute  is  BitsAttributeBase )
					   {
						BitFields. Add ( new BitLayoutFieldInfo ( this, Field, ( BitsAttributeBase ) Attribute ) ) ;
						continue ;
					    }
				    }
			    }

			// All done, return the result
			return ( BitFields. ToArray ( ) ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the value of the BitLayout mapped structure.
		/// </summary>
		public ulong  Value
		   {
			get 
			   { 
				BitLayoutFieldInfo []	Fields		=  GetBitFields ( ) ;
				ulong			Result		=  0 ;


				// Loop through all fields that have an attribute which inherits from BitsAttributeBase
				for  ( int  i = 0 ; i  <  Fields. Length ; i ++ )
				   {
					BitLayoutFieldInfo	Field		=  Fields [i] ;
					ulong			Item		=  Field. Value ;


					// Build the resulting flag value
					Item	 =  ( Item  <<  Field. BitsAttribute. Min ) ;
					Result	|=  Item ;
				    }

				// All done, return
				return ( Result ) ; 
			    }


			set
			   { 
				BitLayoutFieldInfo []	Fields		=  GetBitFields ( ) ;


				// Loop through all fields that have an attribute which inherits from BitsAttributeBase
				for  ( int  i = 0 ; i  <  Fields. Length ; i ++ )
				   {
					BitLayoutFieldInfo	Field		=  Fields [i] ;
					ulong			Value		=  ( value  &  Field. BitsAttribute. Mask ) >> Field. BitsAttribute. Min ;

					// Set the field value through a BitLayoutInfo structure
					Field. Value	=  Value ;
				    }
			    }
			   
		    }


		/// <summary>
		/// Gets the width in bits of this structure (cannot exceed largest data type size, 64).
		/// </summary>
		public int  Width 
		   {
			get { return ( __Width ) ; }
		    }
		# endregion


		# region Conversion operators
		/// <summary>
		/// Converts a bit layout to a byte.
		/// </summary>
		/// <param name="bs">BitLayout structure to be converted.</param>
		/// <returns>Byte value corresponding to the BitLayout structure.</returns>
		public static implicit operator  byte ( BitLayout  bs )
		   { return ( unchecked ( ( byte ) ( bs. Value & 0xFF ) ) ) ; }


		/// <summary>
		/// Converts a bit layout to an unsigned short integer.
		/// </summary>
		/// <param name="bs">BitLayout structure to be converted.</param>
		/// <returns>Unsigned short integer value corresponding to the BitLayout structure.</returns>
		public static implicit operator  ushort ( BitLayout  bs )
		   { return ( unchecked ( ( ushort ) ( bs. Value & 0xFFFF ) ) ) ; }


		/// <summary>
		/// Converts a bit layout to an unsigned integer.
		/// </summary>
		/// <param name="bs">BitLayout structure to be converted.</param>
		/// <returns>Unsigned integer value corresponding to the BitLayout structure.</returns>
		public static implicit operator  uint ( BitLayout  bs )
		   { return ( unchecked ( ( uint ) ( bs. Value & 0xFFFFFFFF ) ) ) ; }


		/// <summary>
		/// Converts a bit layout to an unsigned long integer.
		/// </summary>
		/// <param name="bs">BitLayout structure to be converted.</param>
		/// <returns>Unsigned long integer value corresponding to the BitLayout structure.</returns>
		public static implicit operator  ulong ( BitLayout  bs )
		   { return ( unchecked ( ( ulong ) ( bs. Value ) ) ) ; }
		# endregion
	    }
	# endregion


	# region BitField class
	/// <summary>
	/// Specifies a bit field or bit range within a BitLayout structure.
	/// </summary>
	/// <typeparam name="T">Type of the BitField.</typeparam>
	public class  BitField<T>
	   {
		private T	__Value ;		// BitField value
		private Type	__ValueType ;		// Bitfield type


		/// <summary>
		/// Builds a BitField value using the default value of type T.
		/// </summary>
		public  BitField ( ) : this ( default ( T ) )
		   { }


		/// <summary>
		/// Builds a BitField value using the specified initial value.
		/// </summary>
		/// <param name="value">Initial value.</param>
		public  BitField ( T  value )
		   {
			__ValueType	=  typeof ( T ) ;

			if  ( !  __ValueType.IsEnum  &&  ! __ValueType. IsValueType )
				throw new InvalidTypeException ( typeof ( T ) ) ;
				 
			__Value = value ; 
		    }


		/// <summary>
		/// Gets/sets the BitField value.
		/// </summary>
		public T	Value
		   {
			get { return ( __Value ) ; }
			set { __Value = value ; }
		    }



		/// <summary>
		/// Sets the internal value when its type is an enum type.
		/// This operation cannot be done from the calling class (BitLayout) since a "dynamic" variable is used,
		/// which restricts the typecasts that we can perform, for example on the result of the Enum.ToObject() function.
		/// </summary>
		/// <param name="value">New value.</param>
		internal void  SetValue ( Object  value )
		   {
			if  ( __ValueType. IsEnum )
				__Value = ( T ) Enum. ToObject ( __ValueType, value ) ;
			else
				__Value = ( T ) Convert. ChangeType ( value, __ValueType ) ;
		    }


		/// <summary>
		/// Implicitly converts a value of generic type parameter T into a BitField<T> value.
		/// </summary>
		/// <param name="value">Value to be converted.</param>
		/// <returns>A BitField object.</returns>
		public static implicit operator  BitField<T> ( T  value )
		   { return ( new BitField<T> ( value ) ) ; }
	    }
	# endregion
    }