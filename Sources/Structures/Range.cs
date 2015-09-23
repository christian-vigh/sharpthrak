/**************************************************************************************************************

    NAME
        Range.cs

    DESCRIPTION
        Implements the Range class.

    AUTHOR
        Christian Vigh, 11/2007.

    HISTORY
    [Version : 1.0]    [Date : 2007/11/14]     [Author : CV]
        Initial version.

    [Version : 1.01]   [Date : 2007/11/14]     [Author : CV]
	Integration in the 2012 version of the Thrak library.

 **************************************************************************************************************/

using  System ;
using  System. Reflection ;

using  Thrak. Core ;


namespace  Thrak. Structures
   {
	# region Exceptions
	/// <summary>
	/// Exception thrown when an argument to a method is invalid.
	/// </summary>
	public class  RangeArgumentException : ThrakException
	   {
		/// <summary>
		/// Builds a bad argument exception object.
		/// </summary>
		/// <param name="stack_size">Stack size.</param>
		public RangeArgumentException ( String  message, params object []  argv )
			: base ( String. Format ( message, argv ) ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when an operation on a range is invalid.
	/// </summary>
	public class  RangeInvalidOperationException : ThrakException
	   {
		/// <summary>
		/// Builds an invalid operation exception object.
		/// </summary>
		/// <param name="stack_size">Stack size.</param>
		public RangeInvalidOperationException ( String  message, params object []  argv )
			: base ( String. Format ( message, argv ) ) 
		   { }
	    }
	# endregion


	# region Range class
	/// <summary>
	/// Implements a Range of values.
	/// </summary>
	/// <typeparam name="BOUNDARY_TYPE">Type of Range boundaries. Must be a ValueType.</typeparam>
	public class  Range<BOUNDARY_TYPE> : 
				Structure<BOUNDARY_TYPE>,
				IComparable, 
				IComparable< Range<BOUNDARY_TYPE> >,
				ICloneable
			where  BOUNDARY_TYPE : IComparable
	   {
		# region Data members
		// Range boundaries. 
		protected BOUNDARY_TYPE				p_Low,
								p_High ;
		// Range size
		protected object				p_Length	=  null ;
		# endregion


		# region Constructors
		/// <summary>
		/// Private constructor. Creates an empty Range object.
		/// </summary>
		protected  Range ( )
		   { }


		/// <summary>
		/// Creates a Range object whose low and high boundaries are equal.
		/// </summary>
		/// <param name="bounds">Value of the Range low and high boundaries.</param>
		public  Range ( BOUNDARY_TYPE  bounds )
			: this ( bounds, bounds )
		   { }


		/// <summary>
		/// Creates a Range object.
		/// </summary>
		/// <param name="low">Low boundary of the Range.</param>
		/// <param name="high">High boundary of the Range.</param>
		public  Range ( BOUNDARY_TYPE  low, BOUNDARY_TYPE  high )
		   {
			// Check that the low boundary does not exceed high boundary
			if  ( low. CompareTo ( high )  >  0 )
				throw new RangeArgumentException ( 
					Resources. Localization. Classes. Range. XRangeLimitError,
					low, high ) ;

			// Initialize data members
			p_Low		=  low ;
			p_High		=  high ;

			// Compute the size of the interval
			// Only the basic integral types are handled. The length of a DateTime range
			// will be a TimeSpan object.
			switch ( Type. GetTypeCode ( typeof ( BOUNDARY_TYPE ) ) )
			   {
				case TypeCode. Byte     :
					p_Length = Convert. ToByte ( p_High ) - Convert. ToByte ( p_Low ) + 1 ;
					break ;

				case TypeCode. Char     :
					p_Length = Convert. ToInt32 ( p_High ) - Convert. ToInt32 ( p_Low ) + 1 ;
					break ;

				case TypeCode. DateTime :
					p_Length = Convert. ToDateTime ( p_High ) - Convert. ToDateTime ( p_Low ) +
							new TimeSpan ( 0, 0, 1 ) ;
					break ;

				case TypeCode. Decimal  :
					p_Length = Convert. ToDecimal ( p_High ) - Convert. ToDecimal ( p_Low ) + 1 ;
					break ;

				case TypeCode. Double   :
					p_Length = Convert. ToDouble ( p_High ) - Convert. ToDouble ( p_Low ) + 1 ;
					break ;

				case TypeCode. Int16    :
					p_Length = Convert. ToInt16 ( p_High ) - Convert. ToInt16 ( p_Low ) + 1 ;
					break ;

				case TypeCode. Int32    :
					p_Length = Convert. ToInt32 ( p_High ) - Convert. ToInt32 ( p_Low ) + 1 ;
					break ;

				case TypeCode. Int64    :
					p_Length = Convert. ToInt64 ( p_High ) - Convert. ToInt64 ( p_Low ) + 1 ;
					break ;

				case TypeCode. SByte    :
					p_Length = Convert. ToSByte ( p_High ) - Convert. ToSByte ( p_Low ) + 1 ;
					break ;

				case TypeCode. Single   :
					p_Length = Convert. ToSingle ( p_High ) - Convert. ToSingle ( p_Low ) + 1 ;
					break ;

				case TypeCode. UInt16   :
					p_Length = Convert. ToInt16 ( p_High ) - Convert. ToInt16 ( p_Low ) + 1 ;
					break ;

				case TypeCode. UInt32   :
					p_Length = Convert. ToUInt32 ( p_High ) - Convert. ToUInt32 ( p_Low ) + 1 ;
					break ;

				case TypeCode. UInt64   :
					p_Length = Convert. ToUInt64 ( p_High ) - Convert. ToUInt64 ( p_Low ) + 1 ;
					break ;
			    }
		    }


		/// <summary>
		/// Creates a clone copy of the specified Range.
		/// </summary>
		/// <param name="other">Range to clone.</param>
		public  Range ( Range<BOUNDARY_TYPE>  other )
		   {
			CloneBoundaries ( other ) ;
		    }
		# endregion


		# region Private methods
		/// <summary>
		/// Clone the boundary values of the specified Range into this one.
		/// </summary>
		/// <param name="other">Range whose boundaries are to be cloned.</param>
		protected void CloneBoundaries ( Range<BOUNDARY_TYPE>  other )
		   {
			// Get the ICloneable interface
			Type		cloneable  =  typeof ( BOUNDARY_TYPE ). GetInterface ( "ICloneable", true ) ;

			// If the ICloneable interface is defined for the BOUNDARY_TYPE type,
			// then call it to clone the Range boundaries
			if  ( cloneable  !=  null )
			   {
				MethodInfo	clone	= cloneable. GetMethod ( "Clone" ) ;

				p_Low  = ( BOUNDARY_TYPE ) clone. Invoke ( other. p_Low , null ) ;
				p_High = ( BOUNDARY_TYPE ) clone. Invoke ( other. p_High, null ) ;
			    }
			// Otherwise this is probably a value type so a simple assignment will do the job
			// (don't care of classes that do not implement the ICloneable interface)
			else
			   {
				p_Low  = other. p_Low ;
				p_High = other. p_High ;
			    }

			p_Length = other. p_Length ;
		    }
		# endregion


		# region System interface

		# region IComparable members
		/// <summary>
		/// Compares this Range with another Range object.
		/// </summary>
		/// <param name="obj">Range object to compare to.</param>
		/// <returns>A negative value if this Range is less than <paramref name="obj"/>,
		/// a positive value if it is greater, and a zero value if they are strictly identical.</returns>
		/// <remarks>A Range is considered to be less than another Range if its low boundary
		/// is less than the low boundary of the other Range.</remarks>
		public int  CompareTo ( object  obj )
		   {
			if  ( ! ( obj  is  BOUNDARY_TYPE ) )
				throw new RangeInvalidOperationException ( 
						Resources. Localization. Classes. Range. XRangeBadCompare,
						this. GetType ( ). Name, obj. GetType ( ). Name ) ;

			return ( CompareTo ( ( BOUNDARY_TYPE ) obj ) ) ;
		    }


		/// <summary>
		/// Compares this Range with another Range object.
		/// </summary>
		/// <param name="other">Range object to compare to.</param>
		/// <returns>A negative value if this Range is less than <paramref name="other"/>,
		/// a positive value if it is greater, and a zero value if they are strictly identical.</returns>
		/// <remarks>A Range is considered to be less than another Range if its low boundary
		/// is less than the low boundary of the other Range.</remarks>
		public int  CompareTo ( Range<BOUNDARY_TYPE>  other )
		   {
			int			cmp   = p_Low. CompareTo ( other. p_Low ) ;

			if  ( cmp  !=  0 )
				return ( cmp ) ;

			return ( p_High. CompareTo ( other. p_High ) ) ;			   
		    }
		# endregion

		# region ICloneable members
		/// <summary>
		/// Clones this Range, including boundary values.
		/// </summary>
		/// <returns>A clone copy of this Range.</returns>
		public object Clone ( )
		   { return ( new Range<BOUNDARY_TYPE> ( this ) ) ; }
		# endregion

		# region Overridden methods
		/// <summary>
		/// Checks if this Range is the same as the specified one.
		/// </summary>
		/// <param name="obj">Range to compare to.</param>
		/// <returns>True if both Ranges have the same boundaries, false otherwise.</returns>
		public override bool Equals ( object obj )
		   {
			if  ( obj  is  Range<BOUNDARY_TYPE> )
			   {
				Range<BOUNDARY_TYPE>	other = ( Range<BOUNDARY_TYPE> ) obj ;

				return ( p_Low . CompareTo ( other. p_Low  )  ==  0  &&
					 p_High. CompareTo ( other. p_High )  ==  0 ) ;
			    }
			else
				throw new RangeInvalidOperationException ( 
						Resources. Localization. Classes. Range. XRangeBadCompare,
						this. GetType ( ). Name, obj. GetType ( ). Name ) ;
		    }


		/// <summary>
		/// Returns the hash code for this Range (this is the hash code of
		/// the Range low boundary).
		/// </summary>
		public override int GetHashCode ( )
		   { return ( p_Low. GetHashCode ( ) ) ; }


		/// <summary>
		/// Returns the string representation of the Range.
		/// </summary>
		public override string ToString ( )
		   {
			return ( "[" + p_Low. ToString ( ) + ".." + p_High. ToString ( ) + "]" ) ;
		    }
		# endregion

		# endregion


		# region Properties
		/// <summary>
		/// Gets the low boundary of the Range.
		/// </summary>
		public BOUNDARY_TYPE  Low 
		   {
			get { return ( p_Low ) ; }
		    }


		/// <summary>
		/// Gets the high boundary of the Range.
		/// </summary>
		public BOUNDARY_TYPE  High
		   {
			get { return ( p_High ) ; }
		    }


		/// <summary>
		/// Gets the range size. Throws an exception if the range size cannot be retrieved
		/// (the range size is defined only if the BOUNDARY_TYPE parameter is an integral type,
		/// or if a class inheriting from this Range class has overridden the Length property.
		/// </summary>
		public virtual BOUNDARY_TYPE  Length 
		   {
			get  
			   {
				if  ( p_Length  ==  null )
					throw new RangeInvalidOperationException ( 
							Resources. Localization. Classes. Range. XRangeUndefinedSize,
								typeof ( BOUNDARY_TYPE ). Name ) ;
				return ( ( BOUNDARY_TYPE ) p_Length ) ; 
			    }
		    }
		# endregion


		# region Public methods
		/// <summary>
		/// Checks if the specified value is within the range.
		/// </summary>
		/// <param name="value">Value to check.</param>
		/// <returns>True if the value is within the range, false otherwise.</returns>
		public bool  Contains ( BOUNDARY_TYPE  value )
		   {
			return ( p_Low . CompareTo ( value )  <=  0  &&
				 p_High. CompareTo ( value )  >=  0 ) ;
		     }


		/// <summary>
		/// Checks if the specified range is contained by this range.
		/// </summary>
		/// <param name="value">Range to check.</param>
		/// <returns>True if <paramref name="value"/> is contained by this range,
		/// false otherwise.</returns>
		public bool  Contains ( Range<BOUNDARY_TYPE>  value )
		   {
			if  ( value  ==  null )
				throw new ArgumentNullException ( ) ;

			return ( p_Low . CompareTo ( value. p_Low  )  <=  0  &&
				 p_High. CompareTo ( value. p_High )  >=  0 ) ;
		    }


		/// <summary>
		/// Returns the difference of two ranges.
		/// </summary>
		/// <param name="value">Range to remove from this one.</param>
		/// <returns>The complemented range, or null if <paramref name="other"/>
		/// is contained by this range, or if they do not overlap.</returns>
		public Range<BOUNDARY_TYPE>  Difference ( Range<BOUNDARY_TYPE>  value )
		   {
			if  ( Contains ( value )  ||  value. Contains ( this )  ||  ! Overlaps ( value ) )
				return ( null ) ;

			return ( new Range<BOUNDARY_TYPE> (
					( p_Low . CompareTo ( value. p_Low  )  >  0  &&  
					  p_Low . CompareTo ( value. p_High )  <  0 ) ?
						value. p_High : p_Low,
					( p_High. CompareTo ( value. p_Low  )  >  0  &&
					  p_High. CompareTo ( value. p_High )  <  0 ) ?
						value. p_Low : p_High ) ) ;
		    }


		/// <summary>
		/// Returns the intersection of this range with the specified one.
		/// </summary>
		/// <param name="value">Range to intersect with.</param>
		/// <returns>A new range object representing the intersection of this
		/// range with <paramref name="value"/>, or null if both ranges are
		/// discontiguous.</returns>
		public Range<BOUNDARY_TYPE>  Intersection ( Range<BOUNDARY_TYPE>  value )
		   {
			// If the other range is null, then the union of 'this' and 'null'
			// is always 'this'
			if  ( ( object ) value  ==  ( object ) null )
				return ( this ) ;

			// If ranges overlap, return the intersection
			if  ( Overlaps ( value ) )
				return ( new Range<BOUNDARY_TYPE> (
					p_Low. CompareTo ( value. p_Low ) > 0 ?
						p_Low : value. p_Low,
					p_High. CompareTo ( value. p_High )  <  0 ?
						p_High : value. p_High ) ) ;
			// Otherwise return a null range
			else
				return ( null ) ;
		     }


		/// <summary>
		/// Checks if this range is contained by the specified range.
		/// </summary>
		/// <param name="value">Range to check.</param>
		/// <returns>True if <paramref name="value"/> contains this range,
		/// false otherwise.</returns>
		public bool  IsContainedBy ( Range<BOUNDARY_TYPE>  value )
		    { 
			if  ( ( object ) value  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( value. Contains ( this ) ) ; 
		     }


	       /// <summary>
		/// Checks if two ranges are contiguous.
		/// </summary>
		/// <param name="range">Range to check.</param>
		/// <returns>True if the two ranges are contiguous, false otherwise.</returns>
		/// <remarks>Contiguous can mean containing, overlapping, or being next to.</remarks>
		public bool  IsContiguousWith ( Range<BOUNDARY_TYPE>  range )
		   {
			if ( Overlaps ( range )		|| 
			     range. Overlaps ( this )	|| 
			     range. Contains ( this )   || 
			     Contains ( range ) )
				return ( true ) ;

			// Once we remove overlapping and containing, only touching if available
			return ( p_High. Equals ( range. p_Low )  ||  p_Low. Equals ( range. p_High ) ) ;
		    }


		/// <summary>
		/// Checks if this range is located after the specified range.
		/// </summary>
		/// <param name="other">Range to compare to.</param>
		/// <returns>True if the range is after, false otherwise.</returns>
		/// <remarks>This method will return false if the range is after, but
		/// touches <paramref name="other"/>.</remarks>
		public bool IsLeftTo ( Range<BOUNDARY_TYPE>  other )
		   { 
			if  ( ( object ) other  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( p_Low. CompareTo ( other. p_High )  >  0 ) ; 
		    }


		/// <summary>
		/// Checks if this range is located before the specified range.
		/// </summary>
		/// <param name="other">Range to compare to.</param>
		/// <returns>True if the range is before, false otherwise.</returns>
		/// <remarks>This method will return false if the range is before, but
		/// touches <paramref name="other"/>.</remarks>
		public bool IsRightTo ( Range<BOUNDARY_TYPE>  other )
		   { 
			if  ( ( object ) other  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( p_High. CompareTo ( other. p_Low )  <  0 ) ; 
		    }

		   
		/// <summary>
		/// Checks if two ranges overlap.
		/// </summary>
		/// <param name="other">Range to compare to.</param>
		/// <returns>True if both ranges overlap, false otherwise.</returns>
		public bool Overlaps ( Range<BOUNDARY_TYPE>  other )
		   { 
			if  ( ( object ) other  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( Contains ( other. p_Low )  ||
				 Contains ( other. p_High ) ||
				 other. Contains ( p_Low )  ||
				 other. Contains ( p_High ) ) ;
		    }


		/// <summary>
		/// Checks if this range is contiguous to the specified range, ie if
		/// it ends where <paramref name="other"/> starts, or if it starts where
		/// <paramref name="other"/> ends.
		/// </summary>
		/// <param name="other">Range to compare to.</param>
		/// <returns>True if this range touches <paramref name="other"/>, false otherwise.</returns>
		public bool Touches ( Range<BOUNDARY_TYPE>  other )
		   { 
			if  ( ( object ) other  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( TouchesLeft ( other )  ||  TouchesRight ( other ) ) ; 
		    }


		/// <summary>
		/// Checks if this range is contiguous to the left of the specified range, ie if
		/// it ends where <paramref name="other"/> starts.
		/// </summary>
		/// <param name="other">Range to compare to.</param>
		/// <returns>True if this range touches <paramref name="other"/>, false otherwise.</returns>
		public bool TouchesLeft ( Range<BOUNDARY_TYPE>  other )
		   { 
			if  ( ( object ) other  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( p_High. CompareTo ( other. p_Low )  ==  0 ) ; 
		    }


		/// <summary>
		/// Checks if this range is contiguous to the specified range, ie 
		/// if it starts where <paramref name="other"/> ends.
		/// </summary>
		/// <param name="other">Range to compare to.</param>
		/// <returns>True if this range touches <paramref name="other"/>, false otherwise.</returns>
		public bool TouchesRight ( Range<BOUNDARY_TYPE>  other )
		   { 
			if  ( ( object ) other  ==  ( object ) null )
				throw new ArgumentNullException ( ) ;

			return ( p_Low. CompareTo ( other. p_High )  ==  0 ) ; 
		    }


		/// <summary>
		/// Returns the union of two overlapping ranges.
		/// </summary>
		/// <param name="other">Range to unify.</param>
		/// <returns>The union of this range with <paramref name="other"/>,
		/// or null if ranges do not overlap.</returns>
		public Range<BOUNDARY_TYPE>  Union ( Range<BOUNDARY_TYPE>  other )
		   {
			// If the other range is null, then the union of 'this' and 'null'
			// is always 'this'
			if  ( ( object ) other  ==  ( object ) null )
				return ( this ) ;

			// Check that both ranges have at least one point in common
			if  ( ! Overlaps ( other ) )
				return ( null ) ;

			// If this interval contains the other, then we have nothing to do
			if  ( Contains ( other ) )
				return ( this ) ;

			// Same if the other interval contains this one
			if  ( other. Contains ( this ) )
				return ( other ) ;


			// Common case : create the intersection
			return ( new Range<BOUNDARY_TYPE> ( 
 				( p_Low . CompareTo ( other. p_Low  )  <  0 ) ?
					p_Low : other. p_Low,
				( p_High. CompareTo ( other. p_High )  >  0 ) ?
					p_High : other. p_High ) ) ;
		    }
		# endregion


		# region Comparison operators
		/// <summary>
		/// Checks if two ranges are equal.
		/// </summary>
		/// <param name="left">First range to compare.</param>
		/// <param name="right">Second range to compare.</param>
		/// <returns>True if both ranges are equal, false otherwise.</returns>
		public static bool  operator  ==  ( Range<BOUNDARY_TYPE>  left, 
						    Range<BOUNDARY_TYPE>  right )
		   {
			// If both object are null, or same instance, return true
			if  ( object. ReferenceEquals ( left, right ) )
				return ( true ) ;

			// If one is null, but not both, return false
			if  ( ( object ) left   ==  ( object ) null  ||  
			      ( object ) right  ==  ( object ) null )
				return ( false ) ;

			return ( left. Equals ( right ) ) ;
		    }


		/// <summary>
		/// Checks if A range is equal with a range whose bounds are equal.
		/// </summary>
		/// <param name="left">Range to compare.</param>
		/// <param name="right">Value to compare to.</param>
		/// <returns>True if both ranges are equal, false otherwise.</returns>
		public static bool  operator  ==  ( Range<BOUNDARY_TYPE>	left, 
						    BOUNDARY_TYPE		right )
		   {
			return ( left. CompareTo ( right )  ==  0 ) ;
		    }


		/// <summary>
		/// Checks if two ranges are different.
		/// </summary>
		/// <param name="left">First range to compare.</param>
		/// <param name="right">Second range to compare.</param>
		/// <returns>True if both ranges are different, false otherwise.</returns>
		public static bool  operator  !=  ( Range<BOUNDARY_TYPE>  left, 
						    Range<BOUNDARY_TYPE>  right )
		   { return ( ! ( left  ==  right ) ) ; }


		/// <summary>
		/// Checks if a range is different from a range whose bounds are equal.
		/// </summary>
		/// <param name="left">Range to compare.</param>
		/// <param name="right">Value to compare to.</param>
		/// <returns>True if both ranges are equal, false otherwise.</returns>
		public static bool  operator  !=  ( Range<BOUNDARY_TYPE>	left, 
						    BOUNDARY_TYPE			right )
		   { return ( ! ( left  ==  right ) ) ; }
		# endregion


		# region Range operators
		/// <summary>
		/// Computes the union of two ranges.
		/// </summary>
		/// <param name="left">First range.</param>
		/// <param name="right">Second range.</param>
		/// <returns>The union of the two ranges if they overlap, or null.</returns>
		public static Range<BOUNDARY_TYPE>  operator | ( Range<BOUNDARY_TYPE>  left, 
									    Range<BOUNDARY_TYPE>  right )
		   { return ( left. Union ( right ) ) ; }


		/// <summary>
		/// Computes the intersection of two ranges.
		/// </summary>
		/// <param name="left">First range.</param>
		/// <param name="right">Second range.</param>
		/// <returns>The intersection of the two ranges if they overlap, or null.</returns>
		public static Range<BOUNDARY_TYPE>  operator & ( Range<BOUNDARY_TYPE>  left, 
									    Range<BOUNDARY_TYPE>  right )
		   { return ( left. Intersection ( right ) ) ; }


		/// <summary>
		/// Computes the difference of two ranges.
		/// </summary>
		/// <param name="left">First range.</param>
		/// <param name="right">Second range.</param>
		/// <returns>The difference of the two ranges if they overlap, or null if they are disjoint or if
		/// the second range is contained by the first one.</returns>
		public static Range<BOUNDARY_TYPE>  operator ^ ( Range<BOUNDARY_TYPE>  left, 
									    Range<BOUNDARY_TYPE>  right )
		   { return ( left. Difference ( right ) ) ; }
		# endregion
	    }
	# endregion
    }