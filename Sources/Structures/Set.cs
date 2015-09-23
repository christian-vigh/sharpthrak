/**************************************************************************************************************

    NAME
        Set.cs

    DESCRIPTION
        Implements a delimited set (such as a Pascal set).
	This base class is used by all other set derivates.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/05]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Collections ;
using	System. Collections. Generic ;

using   Thrak. Core ;
using   Thrak. Structures ;


namespace Thrak. Structures
   {
	# region Set exceptions
	/// <summary>
	/// Exception thrown by Set objects when lower and upper bound values are incorrect.
	/// </summary>
	public class  SetBoundsException : SetException
	   {
		/// <summary>
		/// Builds a SetBoundsException object.
		/// </summary>
		/// <param name="lowerbound">Lower bound of the delimited set.</param>
		/// <param name="upperbound">Upper bound of the delimited set.</param>
		public SetBoundsException ( int  lowerbound, int  upperbound )
			: base ( String. Format ( Resources. Localization. Classes. Set. LowerBoundGTUpperBound,  lowerbound, upperbound ) ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown by Set objects when the supplied value does not belong to the set.
	/// </summary>
	public class  ValueNotInSetException : SetException
	   {
		/// <summary>
		/// Builds a ValueNotInSetException object.
		/// </summary>
		/// <param name="value">Offending value.</param>
		public ValueNotInSetException ( int  value )
			: base ( String. Format ( Resources. Localization. Classes. Set. ValueNotInSet, value ) )
		   { }
	    }


	/// <summary>
	/// Exception thrown by Set objects when an operation is applied on two sets which do not have the same boundaries.
	/// </summary>
	public class  SetBoundariesException : SetException
	   {
		/// <summary>
		/// Builds a SetBoundariesException object.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		public SetBoundariesException ( Set	a, Set  b )
			: base ( String. Format ( Resources. Localization. Classes. Set. SetBoundariesUnequal,
					a. Lowerbound, a. Upperbound, b. Lowerbound, b. Upperbound ) )
		   { }
	    }
	# endregion


	# region Set class
	/// <summary>
	/// Implements a Pascal set.
	/// </summary>
	public class  Set	: Structure<BitArray>, ISet, ICloneable, IEnumerable
	   {
		# region Data members
		/// <summary>
		/// Underlying bit array.
		/// </summary>
		protected BitArray		__BitArray ;			

		/// <summary>
		/// Lower bound for this delimited set.
		/// </summary>
		protected int			__LowerBound ;

		/// <summary>
		/// Upper bound for this delimited set.
		/// </summary>
		protected int			__UpperBound ;

		/// <summary>
		/// Delta to be added to __Lowerbound and __Upperbound to start the range from zero.
		/// </summary>
		protected int			__Delta ;

		/// <summary>
		/// Length of the delimited range (number of bits between lowerbound and upperbound).
		/// </summary>
		protected int			__Length ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a delimited set starting from zero to the specified upper bound.
		/// </summary>
		/// <param name="upperbound">Upper bound for the delimited set.</param>
		public  Set ( int  upperbound ) : this ( 0, upperbound, null ) 
		   { }


		/// <summary>
		/// Builds a delimited set starting from the sepecified lower bound to the specified upper bound.
		/// </summary>
		/// <param name="lowerbound">Lower bound for the delimited set.</param>
		/// <param name="upperbound">Upper bound for the delimited set.</param>
		public  Set ( int  lowerbound, int  upperbound ) : this ( lowerbound, upperbound, null )
		   { }


		/// <summary>
		/// Builds a delimited set starting from the sepecified lower bound to the specified upper bound.
		/// Initializes the set with the specified values.
		/// </summary>
		/// <param name="lowerbound">Lower bound for the delimited set.</param>
		/// <param name="upperbound">Upper bound for the delimited set.</param>
		/// <param name="values">Values used to initialize the set.</param>
		public  Set ( int  lowerbound, int  upperbound, int []  values )
		   {
			if  ( lowerbound  >  upperbound )
				throw new  SetBoundsException ( lowerbound, upperbound ) ;

			this. __LowerBound	=  lowerbound ;
			this. __UpperBound	=  upperbound ;
			this. __Delta		=  - lowerbound ;
			this. __Length		=  upperbound - lowerbound ;

			this. __BitArray	=  new BitArray ( this. __Length ) ;

			if  ( values  !=  null ) 
			   {
				for  ( int  i = 0 ; i  <  values. Length ; i ++ )
					Add ( values [i] ) ;
			    }
		    }


		/// <summary>
		/// Creates a new set from an existing one.
		/// </summary>
		/// <param name="value">Existing set.</param>
		public Set ( Set  value )
		   {
			this. __BitArray	=  new BitArray ( value. __BitArray ) ;
			this. __Delta		=  value. __Delta ;
			this. __Length		=  value. __Length ;
			this. __LowerBound	=  value. __LowerBound ;
			this. __UpperBound	=  value. __UpperBound ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the number of values present in the set.
		/// </summary>
		public int  Count 
		   {
			get { return ( this. __BitArray. Count ) ; }
		    }


		/// <summary>
		/// Returns true if the set is empty.
		/// </summary>
		public bool	IsEmpty		
		   { 
			get { return ( this. __BitArray. Count  ==  0 ) ; }
		    }


		/// <summary>
		/// Gets the size of the delimited set (upper bound - lower bound).
		/// </summary>
		public int  Length 
		   {
			get { return ( this. __Length ) ; }
		    }


		/// <summary>
		/// Gets the lower bound of this set.
		/// </summary>
		public int  Lowerbound
		   {
			get { return ( this. __LowerBound ) ; }
		    }


		/// <summary>
		/// Gets the upper bound of this set.
		/// </summary>
		public int  Upperbound 
		   {
			get { return ( this. __UpperBound ) ; }
		    }


		/// <summary>
		/// Gets a boolean value indicating whether the specified value is in the set.
		/// </summary>
		/// <param name="value">Value to be checked.</param>
		/// <returns>True if the set includes the specified value, false otherwise.</returns>
		public bool  this [ int  value ]
		   {
			get 
			   {
				CheckForValidIndex ( value ) ;

				value		=  GetOffset ( value ) ;

				return ( this. __BitArray [ value ] ) ;
			    }
		    }
		# endregion


		# region Set items manipulation functions
		/// <summary>
		/// Adds a value to the set.
		/// </summary>
		/// <param name="value">Value to be added.</param>
		public void  Add ( int  value )
		   {
			CheckForValidIndex ( value ) ;

			value				=  GetOffset ( value ) ;
			this. __BitArray [ value ]	=  true ;
		    }

		
		/// <summary>
		/// Adds a collection of values to a set.
		/// </summary>
		/// <param name="values">
		/// An object, such as an array, implementing the ICollection interface and containing the values to be added.
		/// </param>
		public void  Add ( ICollection  values )
		   {
			if  ( values  ==  null ) 
				throw new ArgumentNullException ( "values" ) ;

			foreach  ( int  value  in  values )
				Add ( value ) ;
		    }


		/// <summary>
		/// Clears the delimited set contents.
		/// </summary>
		public void Clear ( )
		   {
			this. __BitArray. Clear ( ) ;
		    }


		/// <summary>
		/// Checks if the set contains the specified value.
		/// </summary>
		/// <param name="value">Value to be tested.</param>
		/// <returns>True if the specified value exists in the set, false otherwise.</returns>
		public bool  Contains ( int  value )
		   {
			CheckForValidIndex ( value ) ;

			value	=  GetOffset ( value ) ;

			return ( this. __BitArray [value] ) ;
		    }


		/// <summary>
		/// Checks if this instance contains the same value as the specified set.
		/// </summary>
		/// <param name="set">Set to be compared with.</param>
		/// <returns>True if both sets are equal, false otherwise.</returns>
		public bool IsEqual ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;

			return ( this. __BitArray  ==  set. __BitArray ) ;
		    }


		/// <summary>
		/// Check if this instance is a proper subset of the specified set.
		/// </summary>
		/// <param name="iset">The set to be compared against.</param>
		/// <returns>True if this set is a subset of the specified set, false otherwise.</returns>
		/// <remarks>
		/// A is a proper subset of B if :
		/// <para>
		/// - A is a subset of B, and
		/// </para>
		/// <para>
		/// - A  !=  B
		/// </para>
		/// </remarks>
		public bool  IsProperSubsetOf ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;

			if  ( this. __BitArray  ==  set. __BitArray ) 
				return ( false ) ;

			return ( IsSubsetOf ( iset ) ) ;
		    }


		/// <summary>
		/// Check if this instance is a proper superset of the specified set.
		/// </summary>
		/// <param name="iset">The set to be compared against.</param>
		/// <returns>True if this set is a superset of the specified set, false otherwise.</returns>
		/// <remarks>
		/// A is a proper superset of B if :
		/// <para>
		/// - A is a superset of B, and
		/// </para>
		/// <para>
		/// - A  !=  B
		/// </para>
		/// </remarks>
		public bool  IsProperSupersetOf ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			return ( set. IsProperSubsetOf ( this ) ) ;
		    }


		/// <summary>
		/// Check if this instance is a subset of the specified set.
		/// </summary>
		/// <param name="iset">The set to be compared against.</param>
		/// <returns>True if this set is a subset of the specified set, false otherwise.</returns>
		public bool  IsSubsetOf ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;

			for  ( int  i = 0 ; i  <  this. __BitArray. Bits. Length ; i ++ )
			   {
				ulong		a	=  this. __BitArray. Bits [i] ;
				ulong		b	=  set. __BitArray. Bits [i] ;

				if  ( ( a | b )  !=  b )
					return ( false ) ;
			    }

			return ( true ) ;
		    }


		/// <summary>
		/// Check if this instance is a superset of the specified set.
		/// </summary>
		/// <param name="iset">The set to be compared against.</param>
		/// <returns>True if this set is a superset of the specified set, false otherwise.</returns>
		public bool  IsSupersetOf ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			return ( set. IsSubsetOf ( this ) ) ;
		    }



		/// <summary>
		/// Remove the specified value from the set.
		/// </summary>
		/// <param name="value">Value to be removed.</param>
		public void  Remove ( int  value )
		   {
			CheckForValidIndex ( value ) ;

			value				=  GetOffset ( value ) ;
			this. __BitArray [ value ]	=  false ;
		    }


		/// <summary>
		/// Removes a collection of values from a set.
		/// </summary>
		/// <param name="values">
		/// An object, such as an array, implementing the ICollection interface and containing the values to be removed.
		/// </param>
		public void  Remove ( ICollection  values )
		   {
			if  ( Object. Equals ( values, null ) )
				throw new ArgumentNullException ( "values" ) ;

			foreach  ( int  value  in  values )
				Remove ( value ) ;
		    }
		# endregion


		# region Set operations
		/// <summary>
		/// Performs the difference between this instance and the specified set.
		/// <para>
		/// The difference of two sets includes the values present in one set but not in the other.
		/// This is an XOR operation.
		/// </para>
		/// <para>
		/// The operation is performed in-place, that is, after the operation this &lt;- this ^ <paramref name="set"/>.
		/// </para>
		/// </summary>
		/// <param name="set">Set to be xor'ed with this instance.</param>
		public void Difference ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set	set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;
			this. __BitArray. Xor ( set. __BitArray ) ;
		    }


		/// <summary>
		/// Performs the intersection of this instance with the specified set. 
		/// <para>
		/// The intersection of two sets is a new set that includes present in both sets.
		/// </para>
		/// <para>
		/// The operation is performed in-place, that is, after the operation this &lt;- this & <paramref name="set"/>.
		/// </para>
		/// </summary>
		/// <param name="set">Set to be and'ed with this instance.</param>
		public void Intersection ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;
			this. __BitArray. And ( set. __BitArray ) ;
		    }


		public void  Minus  ( ISet  iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set		set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;

			for  ( int  i = 0 ; i < this. __BitArray. Bits. Length ; i ++ )
				this. __BitArray. Bits [i]  &=  ~set. __BitArray. Bits [i] ;
		    }


		/// <summary>
		/// Get the symetric set of the current instance. 
		/// <para>
		/// The symetric of a set is the set of all values not comprised in the set.
		/// </para>
		/// <para>
		/// The operation is performed in-place, that is, after the operation this &lt;- ~this.
		/// </para>
		/// </summary>
		/// <param name="set">Set to be and'ed with this instance.</param>
		public void Symetric ( )
		   {
			this. __BitArray. Not ( ) ;
		    }


		/// <summary>
		/// Performs the union of this instance with the specified set. 
		/// <para>
		/// The union of two sets is a new set that includes the elements present in either set, or both.
		/// </para>
		/// <para>
		/// The operation is performed in-place, that is, after the operation this &lt;- this | <paramref name="set"/>.
		/// </para>
		/// </summary>
		/// <param name="set">Set to be or'ed with this instance.</param>
		public void Union ( ISet   iset )
		   {
			if  ( Object. Equals ( iset, null ) )
				throw new ArgumentNullException ( "iset" ) ;

			Set	set	=  ( Set ) iset ;

			CheckForSetBoundaries ( this, set ) ;
			this. __BitArray. Or ( set. __BitArray ) ;
		    }


		# endregion


		# region Overloaded operators

		# region Logical operators
		/// <summary>
		/// Returns true if the set is non-empty.
		/// </summary>
		public static bool operator  true  ( Set  set )
		   {	
			if (  Object. Equals ( set, null ) )
				return ( false ) ;
			else
				return ( set. Count  !=  0 ) ; 
		    }


		/// <summary>
		/// Returns false if the set is empty.
		/// </summary>
		public static bool operator  false ( Set  set )
		   {
			if  ( Object. Equals ( set, null ) ) 
				return ( true ) ;
			else
				return ( set. Count  ==  0 ) ; 
		    }


		/// <summary>
		/// Compares two sets for equality.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>True if both sets have the same boundaries and contents, false otherwise.</returns>
		public static bool operator  ==  ( Set  a, Set  b )
		   {
			bool		a_null		=  Object. Equals ( a, null ) ;
			bool		b_null		=  Object. Equals ( b, null ) ;

			if  ( a_null  &&  b_null )
				return ( true ) ;

			if  ( a_null  ||  b_null ) 
				return ( false ) ;

			if  ( AreBoundariesEqual ( a, b ) )
			   {
				if  ( a. __BitArray  ==  b. __BitArray )
					return ( true ) ;
			    }

			return ( false ) ;
		    }


		/// <summary>
		/// Compares two sets for inequality.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>True if both sets have different boundaries or contents, false otherwise.</returns>
		public static bool operator  !=  ( Set  a, Set  b )
		   {
			bool		a_null		=  Object. Equals ( a, null ) ;
			bool		b_null		=  Object. Equals ( b, null ) ;

			if  ( a_null  &&  b_null )
				return ( false ) ;

			if  ( a_null  ||  b_null ) 
				return ( true ) ;

			if  ( ! AreBoundariesEqual ( a, b ) )
			   {
				if (  a. __BitArray  !=  b. __BitArray )
					return ( true ) ;
			    }

			return ( false ) ;
		    }


		/// <summary>
		/// Checks if one set is the proper subset of the other.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>True if <paramref name="a"/> is a proper subset of <paramref name="b"/>, false otherwise.</returns>
		public static bool operator  <  ( Set  a, Set  b )
		   { 
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			return ( a. IsProperSubsetOf ( b ) ) ; 
		    }


		/// <summary>
		/// Checks if one set is the proper superset of the other.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>True if <paramref name="a"/> is a proper superset of <paramref name="b"/>, false otherwise.</returns>
		public static bool operator  >  ( Set  a, Set  b )
		   { 
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			return ( b. IsProperSubsetOf ( a ) ) ; 
		    }


		/// <summary>
		/// Checks if one set is the subset of the other.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>True if <paramref name="a"/> is a subset of <paramref name="b"/>, false otherwise.</returns>
		public static bool operator  <=  ( Set  a, Set  b )
		   { 
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			return ( a. IsSubsetOf ( b ) ) ; 
		    }


		/// <summary>
		/// Checks if one set is the superset of the other.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>True if <paramref name="a"/> is a superset of <paramref name="b"/>, false otherwise.</returns>
		public static bool operator  >=  ( Set  a, Set  b )
		   { 
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			return ( b. IsSubsetOf ( a ) ) ; 
		    }


		/// <summary>
		/// Returns true if the set is empty, false otherwise.
		/// </summary>
		public static bool operator  ! ( Set  a )
		   {
			if  ( Object. Equals ( a, null ) )
				return ( true ) ;
			else
				return ( a. Count  ==  0 ) ; 
		    }
		# endregion

		# region Arithmetic operators
		/// <summary>
		/// Performs the union of two sets.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>A new set, containing the union of <paramref name="a"/> and <paramref name="b"/>.</returns>
		public static Set operator  |  ( Set  a, Set  b )
		   {
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			Set. CheckForSetBoundaries ( a, b ) ;

			Set		Result		=  new Set ( a ) ;

			Result. Union ( b ) ;

			return ( Result ) ;
		    }


		/// <summary>
		/// Performs the intersection of two sets.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>A new set, containing the intersection of <paramref name="a"/> and <paramref name="b"/>.</returns>
		public static Set operator  &  ( Set  a, Set  b )
		   {
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			Set. CheckForSetBoundaries ( a, b ) ;

			Set		Result		=  new Set ( a ) ;

			Result. Intersection ( b ) ;

			return ( Result ) ;
		    }


		/// <summary>
		/// Performs the difference of two sets.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>A new set, containing the difference of <paramref name="a"/> and <paramref name="b"/>.</returns>
		public static Set operator  ^  ( Set  a, Set  b )
		   {
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			Set. CheckForSetBoundaries ( a, b ) ;

			Set		Result		=  new Set ( a ) ;

			Result. Difference ( b ) ;

			return ( Result ) ;
		    }


		/// <summary>
		/// Performs the minus difference of two sets, which removes from first set any element present in the second set.
		/// </summary>
		/// <param name="a">First set.</param>
		/// <param name="b">Second set.</param>
		/// <returns>A new set, containing the minus difference of <paramref name="a"/> and <paramref name="b"/>.</returns>
		public static Set operator  -  ( Set  a, Set  b )
		   {
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			if  ( Object. Equals ( b, null ) )
				throw new ArgumentNullException ( "b" ) ;

			Set. CheckForSetBoundaries ( a, b ) ;

			Set		Result		=  new Set ( a ) ;

			Result. Minus ( b ) ;

			return ( Result ) ;
		    }


		/// <summary>
		/// Builds a new set based on the elements not present in the specified set.
		/// </summary>
		/// <param name="a">Initial set.</param>
		/// <returns>The negation of <paramref name="a"/>.</returns>
		public static Set operator  ~ ( Set  a )
		   {
			if  ( Object. Equals ( a, null ) )
				throw new ArgumentNullException ( "a" ) ;

			Set		Result		=  new Set ( a ) ;

			Result.Symetric ( ) ;

			return ( Result ) ;
		    }
		# endregion

		# endregion


		# region  Helper functions
		/// <summary>
		/// Checks if two sets have the same boundaries.
		/// </summary>
		private static bool	AreBoundariesEqual ( Set  a, Set  b )
		   {
			return ( a. __LowerBound  ==  b. __LowerBound  &&
				 a. __UpperBound  ==  b. __UpperBound ) ;
		    }


		/// <summary>
		/// Checks that the specified value belongs to the delimited set range.
		/// </summary>
		/// <param name="value">Value to be checked.</param>
		private void  CheckForValidIndex ( int  value )
		   {
			if  ( value  <  this. __LowerBound  ||  value  >  this. __UpperBound )
				throw new  ValueNotInSetException ( value ) ;
		    }


		/// <summary>
		/// Checks that two sets have the same boundaries
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		private static void  CheckForSetBoundaries ( Set  a, Set  b )
		   {
			if  ( ! AreBoundariesEqual ( a, b ) )
				throw new SetBoundariesException ( a, b ) ;
		    }


		/// <summary>
		/// Gets the effective bit number corresponding to the specified value.
		/// </summary>
		/// <param name="value">Value to be translated into a bit number.</param>
		/// <returns>The bit number corresponding to the specified value.</returns>
		private int  GetOffset ( int  value )
		   { return ( value + this. __Delta ) ; }
		# endregion


		# region Overridden object functions
		/// <summary>
		/// Checks if two delimited sets are equal.
		/// </summary>
		/// <param name="obj">Demimited set to be compared to.</param>
		/// <returns>
		/// If both sets have the same bounds and the same elements in them, the function returns true.
		/// <br/>
		/// <para>
		/// The function returns false if :
		/// </para>
		/// <para>- Both sets have the same bounds but not the same elements in them.</para>
		/// <para>- The two sets have different bound.</para>
		/// <para>- The object specified by the <paramref name="obj"/> parameter is not a set.</para>
		/// </returns>
		public override bool Equals ( object obj )
		   {
			if  ( obj  is  Set )
			   {
				Set	Other		=  ( Set ) obj ;


				if (  this. __LowerBound  !=  Other. __LowerBound  ||
				      this. __UpperBound  !=  Other. __UpperBound )
					return ( false ) ;

				return ( this. __BitArray. Equals ( Other. __BitArray ) ) ;
			    }
			else
				return ( false ) ;
		    }


		/// <summary>
		/// Returns the hash code for this object.
		/// </summary>
		public override int GetHashCode ( )
		   {
			return ( this. __BitArray. GetHashCode ( ) + this. __LowerBound. GetHashCode ( ) + this. __UpperBound. GetHashCode ( ) ) ;
		    }


		/// <summary>
		/// Provides a string representation of the set's contents.
		/// </summary>
		public override string  ToString ( )
		   {
			String		Result		=  "{" ;
			int		Count		=  0 ;

			for  ( int  i = 0 ; i  <  this. __Length ; i ++ )
			   {
				if  ( this. __BitArray [i] )
				   {
					int		value	=  i - this. __Delta ;

					if  ( Count  !=  0 )
						Result  +=  ", " ;

					Result += value. ToString ( ) ;
					Count ++ ;
				    }
			    }

			Result += "}" ;
			return ( Result ) ;
		    }
		# endregion


		# region Interfaces implementation
		/// <summary>
		/// Clones a Set.
		/// </summary>
		public object Clone ( )
		   {
			return ( new Set ( this ) ) ; 
		    }


		/// <summary>
		/// Returns the enumerator object for this set.
		/// </summary>
		public IEnumerator GetEnumerator ( )
		   {
			return ( new SetEnumerator ( this. __BitArray ) ) ;
		    }
		# endregion


		# region Set class enumerator
		# region BitArrayEnumerator class
		/// <summary>
		/// Enumerator object for this class. Allows for enumerating individual values in the set.
		/// </summary>
		[Serializable]
		private class	SetEnumerator : IEnumerator, ICloneable 
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
			public SetEnumerator ( BitArray  ba )
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
					
					return ( Index ) ;
				     }
			    }


			// Move to the next bit
			public bool MoveNext ( )
			   {
				// Check that the enumerated BitArray object did not change since the start of the enumeration
				CheckVersion ( ) ;

				// Check if we still have things to enumerate and, if yes, update current bit value
				CurrentValue	=  false ;

				while  ( ! CurrentValue )
				   {
					Index ++ ;

					if  ( Index  <  BitArray. Length - 1 )
					   {
						CurrentValue = BitArray [ Index ] ;

						if  ( CurrentValue )
							return ( true ) ;
					    }
					else
						break ;
				    }

				// End of enumeration...
				Index = BitArray. Count ;
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
	# endregion
    }
