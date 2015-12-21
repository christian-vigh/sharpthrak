/**************************************************************************************************************

    NAME
	VariableStore.cs

    DESCRIPTION
	List of variables that can be expanded during comment expansion.

    AUTHOR
	Christian Vigh, 12/2015.

    HISTORY
	[Version : 1.0]		[Date : 2015/12/20]     [Author : CV]
		Initial version.

 **************************************************************************************************************/
using  System ;
using  System. Collections. Generic ;
using  System. Linq ;
using  System. Text ;

using  Thrak. Types ;


namespace Thrak. Structures
   {
	# region Exceptions
	/// <summary>
	/// Exception thrown when trying to add a variable that already exists.
	/// </summary>
	public class VariableAlreadyDefinedException	:  Exception
	   {
		public VariableAlreadyDefinedException ( string  variable_name ) :
			base ( "Variable \"" + variable_name + "\" is already defined" ) 
		   {}
	    }


	/// <summary>
	/// Exception thrown when referencing a non-existing variable.
	/// </summary>
	public class UndefinedVariableException	:  Exception
	   {
		public UndefinedVariableException ( string  variable_name ) :
			base ( "Undefined variable \"" + variable_name + "\"" ) 
		   {}
	    }
	# endregion


	# region Variable<T> class
	/// <summary>
	/// Implements a variable name/value pair. A variable values can be a delegate which will be invoked
	/// each time the variable value will be retrieved.
	/// </summary>
	/// <typeparam name="VT">Variable value type</typeparam>
	public class  Variable<VT>
	   {
		protected string []		InternalName ;		// Name and aliases
		protected object		InternalValue ;		// Value


		/// <summary>
		/// Builds a variable.
		/// </summary>
		/// <param name="names">Variable name and aliases</param>
		/// <param name="value">Variable value</param>
		public Variable ( string []  names, object  value )
		   { Initialize ( names, value ) ; }


		/// <summary>
		/// Builds a variable.
		/// </summary>
		/// <param name="name">Variable name</param>
		/// <param name="value">Variable value</param>
		public Variable ( string  name, object  value )
		   { Initialize ( new string [1] { name }, value ) ; }


		/// <summary>
		/// Internal initialization function called by constructors.
		/// </summary>
		private void Initialize ( string []  name, object  value )
		   {
			InternalName		=  name ;
			InternalValue		=  value ;
		    }


		/// <summary>
		/// Checks if the variable has the specified alias.
		/// </summary>
		/// <param name="alias">Alias to be checked</param>
		/// <returns>True if the specified alias belongs to the variable's aliases list, false otherwise.</returns>
		public bool  this [ string  alias ]
		   {
			get
			   {
				foreach  ( string  name  in  InternalName )
				   {
					if  ( String. Compare ( name, alias, true )  ==  0 )
						return ( true ) ;
				    }

				return ( false ) ;
			    }
		    }


		/// <summary>
		/// Gets the primary name of the variable.
		/// </summary>
		public string  Name
		   {
			get { return ( InternalName [0] ) ; }
		    }


		/// <summary>
		/// Gets the variable name and its aliases.
		/// </summary>
		public string []  Names
		   {
			get { return ( InternalName ) ; }
		    }


		/// <summary>
		/// Gets/sets the variable value.
		/// </summary>
		public virtual VT  Value
		   {
			get
			   {
				if  ( InternalValue  is  Delegate )
					return ( ( ( Func<VT> ) InternalValue ) ( ) ) ;
				else 
					return ( ( VT ) InternalValue ) ;
			    }

			set { InternalValue = value ; }
		    } 


		/// <summary>
		/// Gets/sets the underlying variable value (either of type VT, or a delegate, or an object...)
		/// </summary>
		public virtual object  UnderlyingValue
		   {
			get		{ return ( InternalValue ) ; }
			internal set	{ InternalValue = value ; }
		    } 
	    }
	# endregion



	# region VariableStore class
	/// <summary>
	/// Implements a variable store.
	/// </summary>
	public class VariableStore<T>	: IEnumerable<T> 
	   {
		// List of defined variables and values. Since variables can have multiple aliases, they are identified
		// in the VariableList dictionary by a unique id that is incremented after each variable definition.
		// The VariableNames dictionary provides an association between a variable name or alias and its unique
		// id.
		protected int				NextVariableId		=  1 ;
		protected Dictionary<int, Variable<T>>	VariableList		=  new Dictionary<int,Variable<T>> ( ) ;
		protected Dictionary<string,int>	VariableNamesAndIds	=
					new Dictionary<string, int> ( StringComparer. CurrentCultureIgnoreCase ) ;
		protected List<string>			VariableNames		=  new List<string> ( ) ;
		// When strict mode is on, defining a variable that already exists will throw an exception, as well
		// as undefining a non-existing one.
		protected bool				StrictMode ;


		/// <summary>
		/// Creates an empty variable store.
		/// </summary>
		public  VariableStore ( bool  strict_mode  =  false )
		   { 
			StrictMode		=  strict_mode ;
		    }


		# region Internal functions
		/// <summary>
		/// Creates a new variable, or overrides an existing one in non-strict mode.
		/// </summary>
		private void  CreateVariable ( Variable<T>  variable )
		   {
			bool		is_defined	=  false ;


			// Check first that the variable name is not already defined
			foreach  ( string  name  in  variable. Names )
			   {
				if  ( IsDefined ( name ) )
				   {
					is_defined	=  true ;
					break ;
				    }
			    }

			// If defined then...
			if  ( is_defined )
			   {
				// Either throw an exception in strict mode or...
				if  ( StrictMode )
					throw new VariableAlreadyDefinedException ( variable. Name ) ;
				// override the existing variable value
				else
				   {
					Variable<T>	existing_variable	=  FindVariableByName ( variable. Name ) ;

					existing_variable. UnderlyingValue	=  variable. UnderlyingValue ;
				    }
			    }
			// Undefined variable : create it
			else
			   {
				foreach  ( string  name  in  variable. Names )
					VariableNamesAndIds. Add ( name, NextVariableId ) ;

				VariableList. Add ( NextVariableId, variable ) ;
				VariableNames. Add ( variable. Name ) ;
				NextVariableId ++ ;
			    }
		    }


		/// <summary>
		/// Create a variable from a name/alias list and a value.
		/// </summary>
		private void  CreateVariable ( string []  names, object  value )
		   { CreateVariable ( new Variable<T> ( names, value ) ) ; }


		/// <summary>
		/// Creates a variable from a name and value.
		/// </summary>
		private void  CreateVariable ( string  name, object  value )
		   { CreateVariable ( new string [1] { name }, value ) ; }


		/// <summary>
		/// Find the id of a variable.
		/// </summary>
		/// <param name="name">Name of the variable to be searched</param>
		/// <returns>
		/// The id of the searched variable. If the variable does not exists, throws an exception
		/// in strict mode or returns -1 otherwise.
		/// </returns>
		private int	FindVariableId ( string  name )
		   {
			int		id ;

			if  ( VariableNamesAndIds. TryGetValue ( name, out  id ) ) 
				return ( id ) ;
			else if  ( StrictMode )
				throw new UndefinedVariableException ( name ) ;
			else
				return ( -1 ) ;
		    }


		/// <summary>
		/// Finds a variable by name.
		/// </summary>
		/// <param name="name">Name of the variable to be searched.</param>
		/// <returns>
		/// A Variable object. If the variable does not exist, throws an exception in strict mode or returns
		/// null otherwise.
		/// </returns>
		private Variable<T>  FindVariableByName ( string  name )
		   {
			int		id	=  FindVariableId ( name ) ;

			if  ( id  ==  -1 )
			   {
				if  ( StrictMode )
					throw new UndefinedVariableException ( name ) ;
				else
					return ( null ) ;
			    }

			return ( VariableList [ id ] ) ;
		    }
		# endregion


		# region Public methods
		/// <summary>
		/// Defines a variable.
		/// </summary>
		/// <param name="names">Name/alias of the variable</param>
		/// <param name="value">Variable value</param>
		public void  Define ( string []  names, object  value )
		   { CreateVariable ( names, value ) ; }


		/// <summary>
		/// Defines a variable.
		/// </summary>
		/// <param name="names">Name of the variable</param>
		/// <param name="value">Variable value</param>
		public void  Define ( string  name, object  value )
		   {
			string []	names	=  new string [1] { name } ;

			CreateVariable ( names, value ) ;
		    }


		/// <summary>
		/// Defines a variable from a Variable object.
		/// </summary>
		/// <param name="variable">Variable object containing the variable definition</param>
		public void  Define ( Variable<T>  variable )
		   { CreateVariable ( variable ) ; }


		/// <summary>
		/// Gets the names of the variables defined so far.
		/// </summary>
		public string []	Names
		   {
			get { return ( VariableNames. ToArray ( ) ) ; }
		    }


		/// <summary>
		/// Checks if the specified variable is defined.
		/// </summary>
		/// <param name="name">Name of the variable to be checked for existence.</param>
		/// <returns>True if the variable exists, false otherwise</returns>
		public bool	IsDefined ( string  name )
		   { return ( VariableNamesAndIds. ContainsKey ( name ) ) ; }


		/// <summary>
		/// Undefines (removes) the specified variable. In strict mode, throws an exception if
		/// the variable does not exist.
		/// </summary>
		/// <param name="name">Name of the variable to be undefined.</param>
		public void	Undefine ( string  name )
		   {
			if  ( IsDefined ( name ) )
			   {
				int		id	=  FindVariableId ( name ) ;

				VariableList. Remove ( id ) ;
				VariableNamesAndIds
					. Where ( kv  => ( kv. Value  ==  id ) )
					. ToList ( )
					. ForEach ( kv => VariableNamesAndIds. Remove ( kv. Key ) ) ;
			    }
			else if  (  StrictMode )
				throw new UndefinedVariableException ( name ) ;
		    }


		/// <summary>
		/// Gets/sets the value of the specified variable.
		/// </summary>
		public T	this [ string  name ]
		   {
			get
			   {
				if  ( IsDefined ( name ) )
					return ( FindVariableByName ( name ). Value ) ;
				else if  ( StrictMode )
					throw new UndefinedVariableException ( name ) ;
				else
					return ( default ( T ) ) ;
			    }

			set { CreateVariable ( name, value ) ; }
		    }
		# endregion


		#region Enumeration stuff
		/// <summary>
		/// Enumerates variable values.
		/// </summary>
		public IEnumerator<T> GetEnumerator ( )
		   {
			foreach  ( KeyValuePair<int,Variable<T>>  item  in  VariableList )
				yield return item. Value. Value ;
		    }

		/// <summary>
		/// Enumerates variable values.
		/// </summary>
		System. Collections. IEnumerator System. Collections. IEnumerable. GetEnumerator ( )
		   { return ( this. GetEnumerator ( ) ) ; }
		# endregion
	   }
	# endregion
    }