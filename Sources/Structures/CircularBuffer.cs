/**************************************************************************************************************

    NAME
        CircularBuffer.cs

    DESCRIPTION
        Implementation of a circular buffer.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/16]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. Collections ;
using	System. Collections. Generic ;
using   System. Threading ;

using   Thrak. Core ;


namespace Thrak. Structures
   {
	# region Exceptions
	/// <summary>
	/// Exception object base for the CircularBuffer exceptions.
	/// </summary>
	public class CircularBufferException	:  ThrakException
	   {
		/// <summary>
		/// Throws an exception with the specified message.
		/// </summary>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		/// <param name="argv">Additional parameters for String.Format().</param>
		public CircularBufferException ( String  message, params Object []  argv )
				: base ( String. Format ( message, argv ) )
		   { }
	    }


	/// <summary>
	/// Exception thrown when an invalid capacity has been supplied.
	/// </summary>
	public class  CircularBufferInvalidCapacityException	:  CircularBufferException
	   {
		public  CircularBufferInvalidCapacityException ( int  capacity ) :
				base ( Resources. Localization. Classes. CircularBuffer. InvalidCapacityException, capacity ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when the specified item count is invalid.
	/// </summary>
	public class  CircularBufferInvalidCountException	:  CircularBufferException
	   {
		public  CircularBufferInvalidCountException ( int  count ) :
				base ( Resources. Localization. Classes. CircularBuffer. InvalidCountException, count )
		   { }
	    }


	/// <summary>
	/// Exception thrown when a circular buffer item index is out of range.
	/// </summary>
	public class  CircularBufferInvalidIndexException	:  CircularBufferException
	   {
		public  CircularBufferInvalidIndexException ( int  count ) :
				base ( Resources. Localization. Classes. CircularBuffer. InvalidIndexException, count )
		   { }
	    }
	# endregion


	# region Circular buffer
	/// <summary>
	/// Implements a circular buffer.
	/// </summary>
	/// <typeparam name="T">Type of the circular buffer entries.</typeparam>
	public class CircularBuffer<T> :  ICollection<T>, IEnumerable<T>, ICollection, IEnumerable
	   {
		# region Private data members
		private int				p_Capacity ;			// Circular buffer capacity
		private int				p_Head ;			// Circular buffer head
		private int				p_Tail ;			// Circular buffer end
		private int				p_Length ;			// Number of elements currently present in the circular buffer
		private T []				p_Items ;			// Buffer items

		[NonSerialized]
		private Object				p_SyncRoot ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a circular buffer.
		/// </summary>
		/// <param name="capacity"></param>
		public  CircularBuffer ( int  capacity )
		   {
			if  ( capacity  <  1 )
				throw new CircularBufferInvalidCapacityException ( capacity ) ;

			p_Head		=  0 ;
			p_Tail		=  0 ;
			p_Capacity	=  capacity ;
			p_Items		=  new T [ capacity ] ;
			p_Length	=  0 ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the circular buffer capacity.
		/// </summary>
		public int  Capacity
		   {
			get { return ( p_Capacity ) ; }
			set
			   {
				if  ( value  <  1 )
					throw new CircularBufferInvalidCapacityException ( value ) ;

				T []		new_items		=  new T [ value ] ;
				int		max			=  Math. Min<int> ( p_Capacity, value ) ;
				int		index			=  0 ;


				for  ( int  i = p_Head ; i  !=  p_Tail ; i = ( i + 1 ) % max )
					new_items [ ++ index ]	=  p_Items [i] ;
					
				p_Items		=  new_items ;
				p_Head		=  0 ;
				p_Tail		=  ( p_Length  !=  0 ) ?  0 : p_Length - 1 ;
				p_Capacity	=  value ;				
			    }
		    }


		/// <summary>
		/// Gets the number of elements present in the buffer.
		/// </summary>
		public int  Length
		   {
			get { return ( p_Length ) ; }
		    }


		/// <summary>
		/// Gets/sets the specified circular buffer item.
		/// </summary>
		/// <param name="index">Item index, ranging from zero to Capacity -1.</param>
		/// <returns>The item at the specified index.</returns>
		public T  this [ int  index ]
		   {
			get { return ( p_Items [ IndexOf ( index ) ] ) ; }
			set { p_Items [ IndexOf ( index ) ] = value ; }
		    }
		# endregion

		
		# region Public methods
		/// <summary>
		/// Adds the specified item to the circular buffer. Overrides the oldest item if the circular buffer max capacity
		/// has been reached.
		/// </summary>
		/// <param name="item">Item to be added.</param>
		public void   Add ( T  item )
		   {
			p_Items [ p_Tail ]	=  item ;
			p_Tail			=  ( p_Tail + 1 ) % p_Capacity ;
			p_Length ++ ;

			if  ( p_Length  >  p_Capacity )
			   {
				p_Head		=  ( p_Head + 1 ) % p_Capacity ;
				p_Length -- ;
			    }
		    }


		/// <summary>
		/// Clears the circular buffer.
		/// </summary>
		public void  Clear ( )
		   {
			p_Head		=  0 ;
			p_Tail		=  0 ;
			p_Length	=  0 ;
		    }


		/// <summary>
		/// Checks if the circular buffer contains the specified item.
		/// </summary>
		/// <param name="item">Item to be tested for presence.</param>
		/// <returns>True if the item is present in the circular buffer, false otherwise.</returns>
		public bool  Contains  ( T  item )
		   {
			for  ( int  i = 0 ; i < this. Length ; i ++ )
			   {
				if  ( this [i]. Equals ( item ) )
					return ( true ) ;
			    }

			return ( false ) ;
		    }


		/// <summary>
		/// Copy the circular buffer into an array.
		/// </summary>
		public void  CopyTo ( T []  array )
		   { CopyTo ( array, 0 ) ; }


		/// <summary>
		/// Copy the circular buffer into an array, starting at <paramref name="array_index"/> into the output array.
		/// </summary>
		public void  CopyTo ( T []  array, int  array_index )
		   { CopyTo ( array, array_index, p_Length ) ; }


		/// <summary>
		/// Copy <paramref name="count"/> items from the circular buffer into an array, starting at
		/// <paramref name="array_index"/> into the output array.
		/// </summary>
		public void  CopyTo ( T []  array, int  array_index, int  count )
		   {
			if  ( count  >  p_Length )
				throw new CircularBufferInvalidCountException ( count ) ;

			for  ( int  i = 0 ; i < this. p_Length ; i ++ )
				array [i + array_index  ]	=  this [i] ;
		    }


		/// <summary>
		/// Removes the specified number of items from the tail of the circular buffer.
		/// </summary>
		/// <param name="count">Number of items to be removed.</param>
		public void	Shrink ( int  count  =  1 ) 
		   {
			if (  count  <  1  ||  count  >  p_Length )
				throw new CircularBufferInvalidCountException ( count ) ;
				
			if  ( count  ==  p_Length )
				Clear ( ) ;
			else
			   {
				p_Tail  -=  count ;

				if  ( p_Tail  <  0 )
					p_Tail += p_Capacity ;

				p_Length	-=  count ;
			    }
		    }


		/// <summary>
		/// Removes the specified number of items from the start of the circular buffer.
		/// </summary>
		/// <param name="count">Number of items to be removed.</param>
		public void Skip  ( int  count )
		   {
			if (  count  <  1  ||  count  >  p_Length )
				throw new CircularBufferInvalidCountException ( count ) ;

			if  ( count  ==  p_Length )
				Clear ( ) ;
			else
			   {
				p_Head		 =  ( p_Head + count ) % p_Capacity ;
				p_Length	-=  count ;
			    }
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Adds the specified string to the circular buffer.
		/// </summary>
		public static CircularBuffer<T>  operator + ( CircularBuffer<T>  cb, T  value )
		  {
			cb. Add ( value ) ;
			return ( cb ) ;
		   }
		# endregion


		# region Support functions
		/// <summary>
		/// Returns the real index in the circular buffer of the specified virtual index.
		/// </summary>
		/// <param name="index">Virtual index.</param>
		private int	IndexOf ( int  index  =  1 )
		   {
			if  ( index  >=  p_Length )
				throw new  CircularBufferInvalidIndexException ( index ) ;

			return ( ( p_Head + index ) % p_Length ) ;
		    }
		# endregion


		# region Interface implementations

		# region ICollection<T> interface
		/// <summary>
		/// Adds the specified item to the collection.
		/// </summary>
		void ICollection<T>. Add ( T item )
		   {
			this. Add ( item ) ;
		    }


		/// <summary>
		/// Clears the collection.
		/// </summary>
		void ICollection<T>. Clear ( )
		   {
			this. Clear ( ) ;
		    }


		/// <summary>
		/// Checks if the collection contains the specified item.
		/// </summary>
		bool ICollection<T>. Contains ( T item )
		   {
			return ( this. Contains ( item ) ) ;
		    }


		/// <summary>
		/// Copy the circular buffer to the supplied array, starting at index <paramref name="arrayIndex"/> in the output array.
		/// </summary>
		void ICollection<T>. CopyTo ( T [] array, int arrayIndex )
		   {
			this. CopyTo ( array, arrayIndex, p_Length ) ;
		    }


		/// <summary>
		/// Gets the number of items in the collection.
		/// </summary>
		int ICollection<T>. Count
		   {
			get { return ( this. Length  ) ; }
		    }


		/// <summary>
		/// Gets an enumerator object for this collection.
		/// </summary>
		public IEnumerator<T>  GetEnumerator ( )
		   {
			for  ( int  i = 0 ; i  <  p_Length ; i ++ )
				yield return ( p_Items [ IndexOf ( i ) ] ) ;
		    }


		/// <summary>
		/// Gets a flag indicating whether this collection is readonly or not.
		/// </summary>
		bool ICollection<T>. IsReadOnly
		   {
			get { return ( false ) ; }
		    }


		/// <summary>
		/// Remove an item (not implemented).
		/// </summary>
		bool ICollection<T>. Remove ( T item )
		   {
			throw new NotImplementedException ( ) ;
		    }
		# endregion


		# region  ICollection interface
		/// <summary>
		/// Copy the collection to the specified array, starting at the specified index.
		/// </summary>
		void ICollection. CopyTo ( Array array, int index )
		   {
			this. CopyTo ( ( T [] ) array, index, p_Length ) ;
		    }


		/// <summary>
		/// Gets the number of elements in the collection.
		/// </summary>
		int ICollection. Count
		   {
			get { return ( p_Length ) ; }
		    }


		/// <summary>
		/// Gets a value indicating whether access to this collection is thread-safe.
		/// </summary>
		bool ICollection. IsSynchronized
		   {
			get { return ( true ) ; }
		    }


		/// <summary>
		/// Returns an object that can be used with the lock() instruction to allow for access in a multithreading environment.
		/// </summary>
		object ICollection. SyncRoot
		   {
			get
			   {
				if  ( p_SyncRoot  ==  null )
					Interlocked. CompareExchange ( ref  p_SyncRoot, new object ( ), null ) ;

		                return ( p_SyncRoot ) ;
			    }

		    }
		# endregion


		# region IEnumerable<T> interface
		/// <summary>
		/// Returns a IEnumerator&lt;T&gt; object for this collection.
		/// </summary>
		IEnumerator<T> IEnumerable<T>. GetEnumerator ( )
		   {
			return ( GetEnumerator ( ) ) ;
		    }
		# endregion


		# region  IEnumerable interface
		/// <summary>
		/// Returns a IEnumerator object for this collection.
		/// </summary>
		IEnumerator IEnumerable. GetEnumerator ( )
		   {
			return ( ( IEnumerator ) GetEnumerator ( ) ) ;
		    }
		# endregion

		# endregion
	   }
	# endregion
    }
