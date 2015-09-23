/**************************************************************************************************************

    NAME
        Stack.cs

    DESCRIPTION
        Implements a stack.

    AUTHOR
        Christian Vigh, 10/2007.

    HISTORY
    [Version : 1.0]    [Date : 2007/10/29]     [Author : CV]
        Initial version.
 
    [Version : 1.01]   [Date : 2007/11/04]     [Author : CV]
 	Created an enumerator class to replace the previous enumerator, which was the enumerator of the 
	p_Stack private field, and enumerated through the actual allocated stack size instead of the real number 
	of stack elements.

   [Version : 1.02]    [Date : 2007/11/04]     [Author : CV]
	Added the IStack interface.
  
 **************************************************************************************************************/
using  System ;
using  System. Collections ;
using  System. Collections. Generic ;
using  System. Reflection ;

using  Thrak. Core ;


namespace Thrak. Structures
   {
	# region Stack exceptions
	/// <summary>
	/// Exception thrown when a stack overflow occurs.
	/// </summary>
	public class  StackOverflowException : ThrakException
	   {
		/// <summary>
		/// Builds a stack overflow exception object.
		/// </summary>
		/// <param name="stack_size">Stack size.</param>
		public StackOverflowException ( int  stack_size )
			: base ( Resources. Localization. Classes. Stack. XStackOverflow, stack_size ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when a stack underflow occurs.
	/// </summary>
	public class  StackUnderflowException : ThrakException
	   {
		/// <summary>
		/// Builds a stack underflow exception object.
		/// </summary>
		/// <param name="stack_size">Stack size.</param>
		public StackUnderflowException ( )
			: base ( Resources. Localization. Classes. Stack. XStackUnderflow )
		   { }
	    }


	/// <summary>
	/// Exception thrown when an operation is made on an empty stack.
	/// </summary>
	public class  StackEmptyException : ThrakException
	   {
		/// <summary>
		/// Builds a stack empty exception object.
		/// </summary>
		/// <param name="stack_size">Stack size.</param>
		public StackEmptyException ( )
			: base ( Resources. Localization. Classes. Stack. XStackEmpty ) 
		   { }
	    }


	/// <summary>
	/// Exception thrown when an argument to a method is invalid.
	/// </summary>
	public class  StackArgumentException : ThrakException
	   {
		/// <summary>
		/// Builds a bad argument exception object.
		/// </summary>
		public StackArgumentException ( String  message, params object []  argv )
			: base ( String. Format ( message, argv ) ) 
		   { }
	    }
	# endregion


	# region IStack interface
	/// <summary>
	/// Base interface for stacks.
	/// </summary>
	/// <typeparam name="BASE_TYPE">Stack elements type.</typeparam>
	public interface  IStack<BASE_TYPE>
	   {
		/// <summary>
		/// Clears the stack.
		/// </summary>
		void		Clear ( ) ;


		/// <summary>
		/// Returns the element at the top of stack without removing it from the stack.
		/// </summary>
		BASE_TYPE	Peek  ( ) ;


		/// <summary>
		/// Pops the last element off the stack.
		/// </summary>
		/// <returns></returns>
		BASE_TYPE	Pop   ( ) ;


		/// <summary>
		/// Pushes the specified element onto the stack.
		/// </summary>
		/// <param name="element">Element to push.</param>
		void		Push  ( BASE_TYPE  element ) ;
	    }
	# endregion


	# region Stack class
	/// <summary>
	/// Implements a stack.
	/// </summary>
	/// <typeparam name="BASE_TYPE">Base type for stack elements.</typeparam>
	public class  Stack<BASE_TYPE> : 
			Structure<BASE_TYPE>,
			IStack<BASE_TYPE>,
			ICollection<BASE_TYPE>, System. Collections. IEnumerable, ICloneable
	  {
		# region Private data members
		// This special stack size value marks the stack has unlimited
		public  const int		Unlimited		=  0 ;


		// Default increment size for unlimited stacks
		public  static int		p_DefaultIncrement	=  128 ;

		// Stack contents
		public BASE_TYPE []		p_Stack ;
		// Increment size for unlimited stacks
		public int			p_Increment		=  DefaultIncrement ;
		// Stack top element index
		public int			p_StackCount ;
		// Maximum stack size (0 = unlimited)
		public int			p_StackSize ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a fixed stack object with the default size.
		/// </summary>
		public Stack ( )
			: this ( DefaultIncrement ) 
		   { }


		/// <summary>
		/// Creates an unlimited stack using the specified value as the stack increment.
		/// </summary>
		public Stack ( int  increment )
			: this ( Unlimited, increment )
		   { }


		/// <summary>
		/// Builds a stack object with the specified size.
		/// </summary>
		/// <param name="size">Stack size.</param>
		public  Stack ( int  size, int  increment )
		   { Initialize ( size, increment ) ; }


		/// <summary>
		/// Creates a stack object and initializes it with the specified collection of values.
		/// </summary>
		/// <param name="size">Stack size (Unlimited for unlimited stacks).</param>
		/// <param name="initial_values">Initial values to push onto the stack.</param>
		/// <param name="increment">Increment size (unlimited stacks only).</param>
		public Stack ( int  size, ICollection<BASE_TYPE>  initial_values, int  increment )
		   {
			// Check size and increment values
			CheckSize ( size ) ;
			CheckSize ( increment ) ;

			// Verify that the size is bigger than the number of elements in [initial_values]
			if  ( size  !=  Unlimited  &&  size  <  initial_values. Count )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackSmallerThanInitValues,
						size, initial_values. Count ) ;

			// Initialize the stack
			Initialize ( size, increment ) ;

			// Push the initial values onto the stack
			Push ( initial_values ) ;
		     }


		/// <summary>
		/// Creates a stack object and initializes it with the specified collection of values.
		/// </summary>
		/// <param name="size">Stack size (Unlimited for unlimited stacks).</param>
		/// <param name="initial_values">Initial values to push onto the stack.</param>
		public Stack ( int  size, ICollection<BASE_TYPE>  initial_values )
			: this ( size, initial_values, DefaultIncrement )
		   { }


		/// <summary>
		/// Creates an unlimited stack object and initializes it with the specified collection of values.
		/// </summary>
		/// <param name="initial_values">Initial values to push onto the stack.</param>
		/// <param name="increment">Increment size (unlimited stacks only).</param>
		public Stack ( ICollection<BASE_TYPE>  initial_values, int  increment )
			: this ( Unlimited, initial_values, increment ) 
		   { }


		/// <summary>
		/// Creates an unlimited stack object and initializes it with the specified collection of values.
		/// </summary>
		/// <param name="initial_values">Initial values to push onto the stack.</param>
		/// <param name="increment">Increment size (unlimited stacks only).</param>
		public Stack ( ICollection<BASE_TYPE>  initial_values )
			: this ( Unlimited, initial_values, DefaultIncrement ) 
		   { }


		/// <summary>
		/// Creates a copy of an existing Stack object.
		/// </summary>
		/// <param name="other">Object to copy.</param>
		public Stack ( Stack<BASE_TYPE>  other )
		   {
			p_Stack		= ( BASE_TYPE [] ) other. p_Stack. Clone ( ) ;
			p_Increment	= other. p_Increment ;
			p_StackCount	= other. p_StackCount ;
			p_StackSize	= other. p_StackSize ;
		    }

		# endregion


		# region Properties
		/// <summary>
		/// Returns the actual size of the stack. For a stack which has a 
		/// limited number of elements, the actual stack size will be the 
		/// same as the stack size. For an unlimited stack, stack contents
		/// grow by a number of chunks determined by the increment property.
		/// Thus, the actual stack size will return the size of the currently
		/// allocated stack contents.
		/// </summary>
		public int  ActualSize 
		   {
			get { return ( p_Stack. Length ) ; }
		    }


		/// <summary>
		/// Returns the stack contents (this is the same as calling the
		/// ToArray ( ) method.
		/// </summary>
		public BASE_TYPE []  Contents
		   {
			get { return ( ToArray ( ) ) ; }
		    }


		/// <summary>
		/// Gets/sets the default increment to be used for unlimited stacks.
		/// </summary>
		public static int  DefaultIncrement
		   {
			get { return ( p_DefaultIncrement ) ; }
			set { p_DefaultIncrement = value ; }
		    }


		/// <summary>
		/// Returns the first element in the stack (ie, the very first that has
		/// been pushed onto the stack).
		/// </summary>
		public BASE_TYPE  First
		   {
			get { CheckIndex ( 0 ) ; return ( p_Stack [0] ) ; }
			set { CheckIndex ( 0 ) ; p_Stack [0] = value ; }
		    }


		/// <summary>
		/// Gets the increment size used when an unlimited stack needs to grow.
		/// </summary>
		public int  Increment 
		   {
			get { return ( p_Increment ) ; }
			set 
			   {
				CheckIncrement ( value ) ; 
				p_Increment = value ; 
			    }
		    }


		/// <summary>
		/// Checks if the stack is empty or not.
		/// </summary>
		public bool  IsEmpty 
		   {
			get { return ( p_StackCount  ==  0 ) ; }
		    }


		/// <summary>
		/// Gets the value indicating if the stack is fixed or not.
		/// </summary>
		public bool  IsFixed
		   {
			get { return ( p_StackSize  !=  Unlimited ) ; }
		    }


		/// <summary>
		/// Checks if the stack is full (ie, the next Push() will imply 
		/// a stack overflow exception.
		/// </summary>
		public bool  IsFull 
		   {
			get 
			   {
				if  ( p_StackSize  ==  Unlimited )
					return ( false ) ;
				else if  ( p_StackSize  ==  p_StackCount )
					return ( true ) ;
				else 
					return ( false ) ;
			    }
		    }


		/// <summary>
		/// Gets the value indicating if the stack is unlimited or not.
		/// </summary>
		public bool  IsUnlimited 
		   {
			get { return ( p_StackSize  ==  Unlimited ) ; }
		    }


		/// <summary>
		/// Returns the last element in the stack (ie, the very last that has
		/// been pushed onto the stack).
		/// </summary>
		public BASE_TYPE  Last
		   {
			get { CheckIndex ( p_StackCount - 1 ) ; return ( p_Stack [ p_StackCount - 1 ] ) ; }
			set { CheckIndex ( p_StackCount - 1 ) ; p_Stack [ p_StackCount - 1 ] = value ; }
		    }


		/// <summary>
		/// Returns the last but one element in the stack.
		/// </summary>
		public BASE_TYPE  LastButOne
		   {
			get { CheckIndex ( p_StackCount - 2 ) ; return ( p_Stack [ p_StackCount - 2 ] ) ; }
			set { CheckIndex ( p_StackCount - 2 ) ; p_Stack [ p_StackCount - 2 ] = value ; }
		    }


		/// <summary>
		/// Gets the maximum stack length.
		/// </summary>
		public int  StackSize
		   {
			get { return ( p_StackSize ) ; }
		    }
		# endregion


		# region IStack implementation
		/// <summary>
		/// Clears the stack.
		/// </summary>
		public void  Clear ( )
		   {
			if  ( p_StackCount  >  0 )
			   {
				ClearRange ( 0, p_StackCount - 1 ) ;
				p_StackCount = 0 ;
			    }
		    }


		/// <summary>
		/// Gets the number of elements on the stack.
		/// </summary>
		public int  Count 
		   {
			get { return ( p_StackCount ) ; }
		    }


		/// <summary>
		/// Peeks the element on top of stack.
		/// </summary>
		public BASE_TYPE  Peek ( )
		   {
			CheckEnough ( 1 ) ;
			return ( p_Stack [ p_StackCount - 1 ] ) ;
		     }


		/// <summary>
		/// Pops the element on top of stack.
		/// </summary>
		public BASE_TYPE  Pop ( )
		   {
			BASE_TYPE	result  =  Peek ( ) ;

			Discard ( 1 ) ;
			return ( result ) ;
		    }


		/// <summary>
		/// Pushes an element on top of stack.
		/// </summary>
		/// <param name="item">Element to push.</param>
		public void  Push ( BASE_TYPE  item )
		   {
			Grow ( 1 ) ;
			p_Stack [ p_StackCount ++ ] = CloneObject ( item ) ;
		    }
		# endregion


		# region Extended stack methods 
		/// <summary>
		/// Clears the stack from the top of stack back to the specified index.
		/// </summary>
		/// <param name="index">Indexes of the last element to clear.</param>
		public void  ClearTo ( int  index )
		   {
			ClearRange ( index, p_StackCount ) ;
			p_StackCount = index ;
		    }
			

		/// <summary>
		/// Discards the specified number of elements in the stack.
		/// </summary>
		/// <param name="count">Bytes of elements to discard.</param>
		public void  Discard ( int  count ) 
		   {
			if  ( count  <  1 )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidCount, count ) ;

			CheckEnough ( count ) ;

			int	start_index	=  p_StackCount - count ;

			CheckIndex ( start_index ) ;
			ClearRange ( start_index, p_StackCount - 1 ) ;
			p_StackCount -= count ;
		    }

		
		/// <summary>
		/// Peeks <paramref name="count"/> items from the stack.
		/// </summary>
		/// <param name="count">Bytes of items to peek.</param>
		/// <returns>An array of <paramref name="count"/> items. The
		/// items are put in reverse order.</returns>
		public BASE_TYPE []  Peek ( int  count )
		   { return ( Peek ( count, true ) ) ; }


		/// <summary>
		/// Peeks <paramref name="count"/> items from the stack.
		/// </summary>
		/// <param name="count">Bytes of items to peek.</param>
		/// <param name="reverse">If true, the items in the returned value will
		/// be reversed, ie returnvalue[0] will be the top of stack, 
		/// returnvalue[1] the top of stack - 1, etc.</param>
		/// <returns>An array of <paramref name="count"/> items.</returns>
		public BASE_TYPE []  Peek ( int  count, bool  reverse )
		   {
			// Check that the specified number of elements to peek is correct
			if  ( count  <  1 )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidCount, count ) ;

			// Also check that enough elements remain on the stack.
			CheckEnough ( count ) ;

			// Allocate an array for the Peek'ed objects
			BASE_TYPE []	result	=  new BASE_TYPE [ count ] ;

			// Copy the items to the return value
			if  ( reverse )
			   {
				// Copy the stack items in reverse order
				for  ( int  i = 0 ; i < count ; i ++ )
					result [i] = p_Stack [ p_Stack. Length - i - 1 ] ;
			     }
			else
			   {
				// Copy the stack items in normal order
				for  ( int  i = 0 ; i < count ; i ++ )
					result [i] = p_Stack [ p_Stack. Length - Count + i ] ;
			     }

			// All done, return the result
			return ( result ) ;
		    }


		/// <summary>
		/// Pops <paramref name="count"/> elements from the stack.
		/// </summary>
		/// <param name="count">Bytes of elements to pop.</param>
		/// <returns>An array of <paramref name="count"/> items. The items
		/// are popped in reverse order.</returns>
		public BASE_TYPE []  Pop ( int  count )
		   { return ( Pop ( count, true ) ) ; }


		/// <summary>
		/// Pops <paramref name="count"/> elements from the stack.
		/// </summary>
		/// <param name="reverse">If true, the items in the returned value will
		/// be reversed, ie returnvalue[0] will be the top of stack, 
		/// returnvalue[1] the top of stack - 1, etc.</param>
		/// <returns>An array of <paramref name="count"/> items.</returns>
		public BASE_TYPE []  Pop ( int  count, bool  reverse )
		   {
			BASE_TYPE []	result = Peek ( count, reverse ) ;

			Discard ( count ) ;
			return ( result ) ;
		    }


		/// <summary>
		/// Pops all the elements from the stack, in reverse order.
		/// </summary>
		/// <returns>An array of popped items.</returns>
		public BASE_TYPE []  PopAll ( )
		   { return ( PopAll ( false ) ) ; }


		/// <summary>
		/// Pops all the elements from the stack.
		/// </summary>
		/// <param name="reverse">If true, the items in the returned value will
		/// be reversed, ie returnvalue[0] will be the top of stack, 
		/// returnvalue[1] the top of stack - 1, etc.</param>
		/// <returns>An array of popped items.</returns>
		public BASE_TYPE []  PopAll ( bool  reverse )
		   { return ( Pop ( p_StackCount, reverse ) ) ; }


		/// <summary>
		/// Pops the top of stack and pushes it to the specified output stack.
		/// </summary>
		/// <param name="to">Destination stack where the value is to be pushed.</param>
		public void  PopTo ( Stack<BASE_TYPE>  to )
		   { to. Push ( Pop ( ) ) ; }


		/// <summary>
		/// Pops all the stack contents to the specified stack object.
		/// </summary>
		/// <param name="to">Destination stack.</param>
		public void  PopAllTo ( Stack<BASE_TYPE>  to )
		   {
			CheckEmpty ( ) ;

			for  ( int i = 0 ; i < p_StackCount ; i ++ )
				to. Push ( Pop ( ) ) ;
		    }


		/// <summary>
		/// Pops the top of stack and pushes it to the specified output stack.
		/// </summary>
		/// <param name="to">Destination stack where the values are to be pushed.</param>
		/// <param name="count">Bytes of elements to push.</param>
		public void  PopTo ( Stack<BASE_TYPE>  to, int  count )
		   { to. Push ( Pop ( count, false ) ) ; }



		/// <summary>
		/// Pushes a null item onto the stack.
		/// </summary>
		public void  Push ( )
		   { Push ( CloneObject ( default ( BASE_TYPE ) ) ) ; }


		/// <summary>
		/// Pushes the specified elements on top of stack.
		/// </summary>
		/// <param name="items"></param>
		public void  Push ( ICollection<BASE_TYPE>  items )
		   {
			Grow ( items. Count ) ;

			foreach ( BASE_TYPE  item  in  items )
				Push ( CloneObject ( item ) ) ;
		    }


		/// <summary>
		/// Pushes the specified value onto the stack. Duplicates it
		/// <paramref name="count"/> times.
		/// </summary>
		/// <param name="value">Value to push.</param>
		/// <param name="count">Bytes of times the value is to be pushed.</param>
		public void  Push ( BASE_TYPE  value, int  count )
		   {
			// Check that the item count is correct
			if  ( count  <  1 )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidCount, count ) ;

			Grow ( count ) ;

			// Push [count] copies of the specified value onto the stack.
			while ( count -- > 0 )
				Push ( CloneObject ( value ) ) ;
		    }


		/// <summary>
		/// Pushes the specified array of values onto the stack.
		/// </summary>
		/// <param name="values">List of values to be pushed.</param>
		public void  Push ( BASE_TYPE []  values )
		   { 
			Grow ( values. Length ) ;

			foreach ( BASE_TYPE  value  in  values )
				Push ( value ) ;
		    }


		/// <summary>
		/// Pushes all the elements to the specified stack. The contents
		/// of the initial stack remain unchanged.
		/// </summary>
		/// <param name="to">Destination stack.</param>
		public void  PushAllTo ( Stack<BASE_TYPE>  to )
		   { 
			CheckEmpty ( ) ;

			for  ( int  i = 0 ; i < p_StackCount ; i ++ )
				to. Push ( p_Stack [i] ) ;
		    }

			
		/// <summary>
		/// Pushes an empty object onto the stack.
		/// </summary>
		public void  PushEmpty ( )
		   { PushEmpty ( 1 ) ; }


		/// <summary>
		/// Pushes the specified count of empty objects onto the stack.
		/// </summary>
		/// <param name="count">Bytes of empty objects to push.</param>
		public void  PushEmpty ( int  count )
		   {
			// Check that the item count is correct
			if  ( count  <  1 )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidCount, count ) ;

			Grow ( count ) ;

			// Create an empty object then push [count] copies onto the stack
			BASE_TYPE	zero = CloneObject ( default ( BASE_TYPE ) ) ;

			while ( count -- > 0 )
				Push ( CloneObject ( zero ) ) ;
		    }
		# endregion


		# region Forth-like stack methods
		/// <summary>
		/// Discards the nth-1 element in the stack.
		/// </summary>
		public void  Discard2 ( )
		   {
			CheckEnough ( 2 ) ;
			p_Stack [ p_StackCount - 2 ] = default ( BASE_TYPE ) ;
			p_Stack [ p_StackCount - 2 ] = p_Stack [ p_StackCount - 1 ] ;
			p_Stack [ p_StackCount - 1 ] = default ( BASE_TYPE ) ;
			p_StackCount -- ;
		    }


		/// <summary>
		/// Discards the nth-2 element in the stack.
		/// </summary>
		public void  Discard3 ( )
		   {
			CheckEnough ( 3 ) ;
			p_Stack [ p_StackCount - 3 ] = default ( BASE_TYPE ) ;
			p_Stack [ p_StackCount - 3 ] = p_Stack [ p_StackCount - 2 ] ;
			p_Stack [ p_StackCount - 2 ] = p_Stack [ p_StackCount - 1 ] ;
			p_Stack [ p_StackCount - 1 ] = default ( BASE_TYPE ) ;
			p_StackCount -- ;
		    }


		/// <summary>
		/// Pushes a copy of the item which is on top of stack.
		/// </summary>
		public void  Dup ( )
		   {
			Grow ( 1 ) ;
			CheckEnough ( 1 ) ;
			p_Stack [ p_StackCount ] = ( BASE_TYPE ) CloneItem ( p_StackCount - 1 ) ;
			p_StackCount ++ ;
		    }

		/// <summary>
		/// Pushes two copies of the item which is on top of stack.
		/// </summary>
		public void  Dup2 ( )
		   {
			Grow ( 2 ) ;
			CheckEnough ( 1 ) ;

			BASE_TYPE	tos = p_Stack [ p_StackCount - 1 ] ;

			p_Stack [ p_StackCount + 1 ] = CloneObject ( tos ) ;
			p_Stack [ p_StackCount     ] = CloneObject ( tos ) ;
			p_StackCount += 2 ;
		     }


		/// <summary>
		/// Pushes <paramref name="count"/> copies of the item which is on top of stack.
		/// </summary>
		/// <param name="count">Bytes of copies to push.</param>
		public void  Dupn ( int  count )
		   {
			Grow ( count ) ;
			CheckEnough ( 1 ) ;

			BASE_TYPE	tos = p_Stack [ p_StackCount - 1 ] ;

			for  ( int  i = 0 ; i < count ; i ++ )
				p_Stack [ p_StackCount + i ] = CloneObject ( tos ) ;

			p_StackCount += count ;
		    }


		/// <summary>
		/// Pushes <paramref name="count"/> copies of the pair of items which is on top of stack.
		/// </summary>
		/// <param name="count">Bytes of copies to push.</param>
		public void  Dup2n ( int  count )
		   {
			int	real_count	=  2 * count ;


			Grow ( real_count ) ;
			CheckEnough ( 2 ) ;

			BASE_TYPE	tos  = p_Stack [ p_StackCount - 2 ] ;
			BASE_TYPE	tos2 = p_Stack [ p_StackCount - 1 ] ;

			for  ( int  i = 0 ; i < real_count ; i += 2 )
			   {
				p_Stack [ p_StackCount + i     ] = CloneObject ( tos ) ;
				p_Stack [ p_StackCount + i + 1 ] = CloneObject ( tos2 ) ;
			    }

			p_StackCount += real_count ;
		    }


		/// <summary>
		/// Pushes <paramref name="count"/> copies of the group of <paramref name="value_count"/>
		/// items onto the stack.
		/// </summary>
		/// <param name="count">Bytes of copies to push.</param>
		/// <param name="value_count">Size of the group of values to duplicate.</param>
		public void  Dupmn ( int  count, int  value_count )
		   {
			Grow ( value_count * count ) ;
			CheckEnough ( value_count ) ;

			for  ( int  i = 0 ; i < count ; i ++ )
			   {
				for  ( int  j = 0 ; j < value_count ; j ++ )
					p_Stack [ p_StackCount + ( i * value_count ) + j ] = 
						CloneObject ( p_Stack [ p_StackCount - value_count + j ] ) ;
			    }

			p_StackCount += value_count * count ;
		    }


		/// <summary>
		/// Rotates to the left the 3 elements on top of stack.
		/// </summary>
		public void  LRot ( )
		   {
			CheckEnough ( 3 ) ;

			BASE_TYPE	x1	= p_Stack [ p_StackCount - 3 ] ;
			BASE_TYPE	x2	= p_Stack [ p_StackCount - 2 ] ;
			BASE_TYPE	x3	= p_Stack [ p_StackCount - 1 ] ;

			p_Stack [ p_StackCount - 3 ] = x3 ;
			p_Stack [ p_StackCount - 2 ] = x1 ;
			p_Stack [ p_StackCount - 1 ] = x2 ;
		    }


		/// <summary>
		/// Rotates the last group of <paramref name="count"/> element to the left
		/// in the stack.
		/// </summary>
		/// <param name="count">Bytes of elements implied by the rotation.</param>
		public void  LRotn ( int  count )
		   {
			CheckEnough ( count ) ;

			BASE_TYPE	temp = p_Stack [ p_StackCount - count ] ;

			for  ( int  i = p_StackCount - count ; i < p_StackCount - 1 ; i ++ )
				p_Stack [i] = p_Stack [i+1] ;
			p_Stack [ p_StackCount - 1 ] = temp ;
		    }


		/// <summary>
		/// Duplicates the nth-1 element on top of stack.
		/// </summary>
		public void  Over ( )
		  {
			Grow ( 1 ) ;
			CheckEnough ( 2 ) ;
			p_Stack [ p_StackCount ] = p_Stack [ p_StackCount - 2 ] ;
			p_StackCount ++ ;
		   }


		/// <summary>
		/// Duplicates the nth-1 pair of elements on top of stack.
		/// </summary>
		public void  Over2 ( )
		  {
			Grow ( 2 ) ;
			CheckEnough ( 4 ) ;
			p_Stack [ p_StackCount     ] = p_Stack [ p_StackCount - 4 ] ;
			p_Stack [ p_StackCount + 1 ] = p_Stack [ p_StackCount - 3 ] ;
			p_StackCount += 2 ;
		   }


		/// <summary>
		/// Duplicates the nth-2 element on top of stack.
		/// </summary>
		public void  OverOver ( )
		   {
			Grow ( 1 ) ;
			CheckEnough ( 3 ) ;
			p_Stack [ p_StackCount ] = p_Stack [ p_StackCount - 3 ] ;
			p_StackCount ++ ;
		   }


		/// <summary>
		/// Reverse the top two elements of the stack (equivalent to Swap()).
		/// </summary>
		public void  Reverse ( )
		   { Swap ( ) ; }


		/// <summary>
		/// Reverse the top <paramref name="count"/> elements of the stack.
		/// </summary>
		/// <param name="count">Bytes of elements to put in reverse order.</param>
		public void  Reverse ( int  count )
		   {
			if  ( count  <  2 )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidCount2, count ) ;

			CheckEnough ( count ) ;
			Array. Reverse ( p_Stack, p_StackCount - count, count ) ;
		    }
		

		/// <summary>
		/// Rotates the 3 elements on top of stack.
		/// </summary>
		public void  Rot ( )
		   {
			CheckEnough ( 3 ) ;

			BASE_TYPE	x1	= p_Stack [ p_StackCount - 3 ] ;
			BASE_TYPE	x2	= p_Stack [ p_StackCount - 2 ] ;
			BASE_TYPE	x3	= p_Stack [ p_StackCount - 1 ] ;

			p_Stack [ p_StackCount - 3 ] = x2 ;
			p_Stack [ p_StackCount - 2 ] = x3 ;
			p_Stack [ p_StackCount - 1 ] = x1 ;
		    }


		/// <summary>
		/// Rotates the last group of <paramref name="count"/> element to the right
		/// in the stack.
		/// </summary>
		/// <param name="count">Bytes of elements implied by the rotation.</param>
		public void  Rotn ( int  count )
		   {
			CheckEnough ( count ) ;

			BASE_TYPE	temp = p_Stack [ p_StackCount - 1 ] ;

			for  ( int  i = p_StackCount - 1 ; i > p_StackCount - count ; i -- )
				p_Stack [i] = p_Stack [i-1] ;
			p_Stack [ p_StackCount - count ] = temp ;
		    }

		/// <summary>
		/// Swaps the two items on top of stack.
		/// </summary>
		public void  Swap ( )
		   {
			CheckEnough ( 2 ) ;

			BASE_TYPE	temp	= p_Stack [ p_StackCount - 2 ] ;

			p_Stack [ p_StackCount - 2 ] = p_Stack [ p_StackCount - 1 ] ;
			p_Stack [ p_StackCount - 1 ] = temp ;
		    }


		/// <summary>
		/// Swaps the two pair of items on top of stack.
		/// </summary>
		public void  Swap2 ( )
		   {
			CheckEnough ( 4 ) ;

			BASE_TYPE	temp1	= p_Stack [ p_StackCount - 3 ] ;
			BASE_TYPE	temp2	= p_Stack [ p_StackCount - 4 ] ;

			p_Stack [ p_StackCount - 4 ] = p_Stack [ p_StackCount - 2 ] ;
			p_Stack [ p_StackCount - 3 ] = p_Stack [ p_StackCount - 1 ] ;
			p_Stack [ p_StackCount - 2 ] = temp1 ;
			p_Stack [ p_StackCount - 1 ] = temp2 ;
		    }

		# endregion


		# region Conversions to string
		/// <summary>
		/// Returns the string representation of the stack contents.
		/// </summary>
		public override String  ToString ( )
		   { return ( ToString ( false ) ) ; }


		/// <summary>
		/// Returns the string representation of the stack contents.
		/// </summary>
		/// <param name="full_display">If true, the returned string gives the detailed
		/// contents of the stack, including size and increment. If false, only the list
		/// of stack items is returned.</param>
		public String  ToString ( bool  full_display )
		   {
			String		result	=  "" ;


			// Full display option
			if  ( full_display )
			   {
				result += "Stack contents (" ;

				result += "item count = " + p_StackCount. ToString ( ) ;

				if  ( p_StackSize  ==  Unlimited )
					result += ", unlimited size, increment = " + p_Increment. ToString ( ) ;
				else
					result += ", size = " + p_StackSize. ToString ( ) ;

				result += ") :\n" ;
				result += new String ( '~', result. Length - 3 ) ;
				result += "\n" ;

				for  ( int  i = 0 ; i < p_StackCount ; i ++ )
					result += String. Format ( "\t0x{0:X8}  {1}\n", i, p_Stack [i]. ToString ( ) ) ;
			    }
			// Partial display for empty stack
			else if ( p_StackCount  ==  0 )
				result = "{empty}" ;
			// Partial display for populated stack
			else
			   {
				result += "[" ;

				for  ( int  i = 0 ; i < p_StackCount ; i ++ )
				   {
					result += p_Stack [i]. ToString ( ) ;

					if  ( i + 1  <  p_StackCount )
						result += ", " ;
				     }

				result += "]" ;
			    }

			// Return the result
			return ( result ) ;
		    }
		# endregion


		# region Private methods
		/// <summary>
		/// Throws an exception if the stack is empty.
		/// </summary>
		public void  CheckEmpty ( )
		   {
			if  ( p_StackCount  ==  0 )
				throw new StackEmptyException ( ) ;
		    }


		/// <summary>
		/// Checks that the stack holds at list <paramref name="count"/> items.
		/// Throws an exception if not.
		/// </summary>
		/// <param name="count">Item count to be checked.</param>
		public void  CheckEnough ( int  count )
		   {
			if  ( p_StackCount  <  count )
				throw new StackUnderflowException ( ) ;
		    }


		/// <summary>
		/// Checks that the specified increment value is valid. Throws an exception if not.
		/// </summary>
		/// <param name="increment">Increment value to check.</param>
		private void  CheckIncrement ( int  increment )
		   {
			if  ( increment  <  1 )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidGrowth, increment ) ;
		    }


		/// <summary>
		/// Checks that the specified index is within the stack range.
		/// </summary>
		/// <param name="index">Indexes to check.</param>
		private void  CheckIndex ( int  index )
		   {
			if  ( index  <  0  ||  index  >=  p_StackCount )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidIndex,
						index, p_StackCount - 1 ) ;
		    }


		/// <summary>
		/// Checks that the specified size is valid. Throws an exception if not.
		/// </summary>
		/// <param name="size">Size to check.</param>
		private void  CheckSize ( int  size )
		   {
			if  ( size  <  1  &&  size  !=  Unlimited )
				throw new StackArgumentException ( Resources. Localization. Classes. Stack. XStackInvalidCount, size ) ;
		    }


		/// <summary>
		/// Clears a range of stack items (removes the reference of each item to
		/// an existing object).
		/// </summary>
		/// <param name="first">First item to clear.</param>
		/// <param name="last">Last item to clear.</param>
		private void  ClearRange ( int  first, int  last )
		   {
			CheckIndex ( first ) ;
			CheckIndex ( last ) ;

			for  ( int  i = first ; i <= last ; i ++ )
				p_Stack [i] = default ( BASE_TYPE ) ;
		    }


		/// <summary>
		/// Returns a clone copy of the specified stack item.
		/// </summary>
		/// <param name="index">Indexes of the item to clone.</param>
		/// <returns>Cloned item.</returns>
		private BASE_TYPE  CloneItem ( int  index )
		   {
			return ( CloneObject ( p_Stack [ index ] ) ) ;
		    }


		/// <summary>
		/// Computes the number of stack increments needed to hold
		/// <paramref name="size"/> items. The value is adjusted to be
		/// a multiple of the stack increment.
		/// </summary>
		/// <param name="size">Bytes of items to store in the stack.</param>
		/// <param name="increment">Value of the stack increment.</param>
		/// <returns>A multiple of the specified increment, which is enough
		/// to store <paramref name="size"/> items/</returns>
		private static int ComputeStackSize ( int  size, int  increment )
		   { return ( ( ( size / increment ) + 1 ) * increment ) ; }

			
		/// <summary>
		/// Ensures that at list <paramref name="delta"/> elements remain in the stack.
		/// For unlimited stacks, reallocates the stack array if necessary.
		/// </summary>
		/// <param name="delta">Bytes of values to push onto the stack.</param>
		public virtual void  Grow ( int  delta )
		   {
			// Requested 
			int		requested	=  p_StackCount + delta ;


			// For unlimited stacks, check if we need to reallocate the stack array
			if  ( p_StackSize  ==  Unlimited )
			   {
				// Yes, we have to do it
				if  ( requested  >=  p_Stack. Length )
				   {
					// Compute new stack size (a multiple of Increment)
					int		newsize  = ComputeStackSize ( requested, p_Increment ) ;
					// Allocate the new stack
					BASE_TYPE []	newstack = new BASE_TYPE [newsize] ;

					// Copy old stack contents to the new one
					Array. Copy ( p_Stack, newstack, p_StackCount ) ;
					// And set the new one to be our stack array
					p_Stack = newstack ;
				    }
			    }
			else  // Fixed stack size
			   {
				if  ( requested  >  p_StackSize )
					throw new StackOverflowException ( p_StackSize ) ;
			    }
		    }


		/// <summary>
		/// Initializes the stack.
		/// </summary>
		/// <param name="size">Stack size, or "Unlimited" for unlimited stack.</param>
		/// <param name="increment">Increment size (unlimited stacks only).</param>
		private void  Initialize ( int  size, int  increment )
		   {
			// Check the correctness of the specified size and increment values
			CheckSize ( size ) ;
			CheckIncrement ( increment ) ;

			// Allocate the stack. For unlimited stacks, the initial stack size
			// is given by the [increment] parameter.
			p_Stack		=  new BASE_TYPE [ ( size  ==  Unlimited ) ? 
						increment : size ] ;
			p_StackCount	=  0 ;		// No element on stack for the moment
			p_Increment	=  increment ;
			p_StackSize	=  size ;
		    }


		/// <summary>
		/// Translates an item index within the stack.
		/// </summary>
		/// <param name="from_tos">If true, the index is evaluated from the top of
		/// stack. Otherwise, it is evaluated from the start of stack.
		/// Therefore, TranslateIndex ( true, 0 ) represents the last element of
		/// the stack, TranslateIndex ( true, 1 ) represents the element before
		/// the last element of the stack, and so on.</param>
		/// <param name="index">Indexes to translate. If <paramref name="from_tos"/>
		/// is false, no translation occurs.</param>
		private int  TranslateIndex ( bool  from_tos, int  index )
		   {
			if  ( from_tos )
				index = p_StackCount - index - 1 ;

			CheckIndex ( index ) ;
			return ( index ) ;
		    }
		# endregion


		# region Interface implementations

		# region ICollection interface
		/// <summary>
		/// Pushes the specified item onto the stack. This method is mandatory for
		/// the object to be Xml-serializable.
		/// </summary>
		/// <param name="item">Item to push.</param>
		public void  Add ( object  item )
		   { Push ( ( BASE_TYPE ) item ) ; }


		/// <summary>
		/// Pushes the specified item onto the stack.
		/// </summary>
		/// <param name="item">Item to push.</param>
		public void  Add ( BASE_TYPE  item )
		   { Push ( item ) ; }


		/// <summary>
		/// Checks if the stack contains the specified item.
		/// </summary>
		/// <param name="item">Item to look for.</param>
		/// <returns>True if the item exists in the stack, false otherwise.</returns>
		public bool  Contains ( BASE_TYPE  item )
		   {
			if  ( Array. IndexOf ( p_Stack, item )  <  0 )
				return ( false ) ;
			else
				return ( true ) ;	
		    }


		/// <summary>
		/// Copies stack contents to the specified array, starting at the specified index.
		/// </summary>
		/// <param name="array">Destination array for the copy operation.</param>
		/// <param name="destination_index">Start index in the destination array.</param>
		public void  CopyTo ( BASE_TYPE []  array, int  destination_index )
		   { p_Stack. CopyTo ( array, destination_index ) ; }


		/// <summary>
		/// Checks if the stack object is read only.
		/// </summary>
		/// <remarks>A stack object is always read-write.</remarks>
		public bool  IsReadOnly 
		   {
			get { return ( false ) ; }
		    }


		/// <summary>
		/// Unsupported operation.
		/// </summary>
		public bool  Remove ( BASE_TYPE  item )
		   { throw new NotSupportedException ( Resources. Localization. Classes. Stack. XStackRemoveUnsupported ) ; }
		# endregion


		# region IEnumerable and IEnumerator interfaces
		/// <summary>
		/// Gets the enumerator object for this stack.
		/// </summary>
		public System. Collections. IEnumerator GetEnumerator ( )
		   { return ( new StackEnumerator ( this ) ) ; }


		/// <summary>
		/// Gets the enumerator object for this stack.
		/// </summary>
		IEnumerator<BASE_TYPE>  System. Collections. Generic. IEnumerable<BASE_TYPE>. GetEnumerator ( )
		   { return ( ( IEnumerator<BASE_TYPE> ) new StackEnumerator ( this ) ) ; }


		/// <summary>
		/// Enumerator class for stack elements.
		/// </summary>
		protected class  StackEnumerator : IEnumerator
		   {
			private Stack<BASE_TYPE>	Parent ;
			private int			CurrentElement	=  -1 ;


			public StackEnumerator ( Stack<BASE_TYPE>  parent )
			   { Parent = parent ; }

			public object Current 
			   { get { return ( Parent [ CurrentElement ] ) ; } }

			public void  Reset ( )
			   { CurrentElement = -1 ; }

			public bool  MoveNext ( )
			   {
				CurrentElement ++ ;
				return  ( CurrentElement  <  Parent. Count ) ;
			    }
		    }
		# endregion


		# region ICloneable interface
		/// <summary>
		/// Returns a copy of this stack.
		/// </summary>
		public object Clone ( )
		   { return ( new Stack<BASE_TYPE> ( this ) ) ; }
		# endregion


		# region Array-like methods
		/// <summary>
		/// Returns the underlying array of this stack. The array is dynamically
		/// allocated to reflect the current stack size, not the actual stack size.
		/// </summary>
		public BASE_TYPE []  ToArray ( )
		   { 
			CheckEmpty ( ) ;

			BASE_TYPE []	array = new BASE_TYPE [ p_StackCount ] ;
			Array. Copy ( p_Stack, array, p_StackCount ) ;

			return ( array ) ;
		    }


		/// <summary>
		/// Gets/sets the contents of the specified stack element.
		/// </summary>
		/// <param name="index">Indexes of the stack element to get or set.</param>
		public BASE_TYPE  this [ int  index ]
		   {
			get 
			   {
				CheckIndex ( index ) ;
				return ( p_Stack [ index ] ) ;
			    }
			set 
			   { 
				CheckIndex ( index ) ;
				p_Stack [ index ] = value ; 
			    }
		     }


		/// <summary>
		/// Gets/sets the contents of the specified stack element.
		/// </summary>
		/// <param name="from_tos">If true, the index is evaluated from the top of
		/// stack. Otherwise, it is evaluated from the start of stack.
		/// Therefore, TranslateIndex ( true, 0 ) represents the last element of
		/// the stack, TranslateIndex ( true, 1 ) represents the element before
		/// the last element of the stack, and so on.</param>
		/// <param name="index">Indexes of the stack element to get or set.</param>
		public BASE_TYPE  this [ bool  from_tos, int  index ]
		   {
			get 
			   {
				index = TranslateIndex ( from_tos, index ) ;
				return ( p_Stack [ index ] ) ;
			    }
			set
			   {
				index = TranslateIndex ( from_tos, index ) ;
				p_Stack [ index ] = value ;
			    }
		    }
		# endregion

		# endregion
	    }
	# endregion
    }