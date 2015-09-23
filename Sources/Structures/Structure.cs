/**************************************************************************************************************

    NAME
        Structure.cs

    DESCRIPTION
        Implements the Structure class.

    AUTHOR
        Christian Vigh, 10/2007.

    HISTORY
    [Version : 1.0]    [Date : 2007/10/30]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using  System ;
using  System. Reflection ;


namespace  Thrak. Structures
   {
	# region Structure<T> class
	/// <summary>
	/// Base class for all the objects defined in the Toybox.Structures namespace.
	/// </summary>
	/// <typeparam name="BASE_TYPE">Base type of elements contained in derived classes.</typeparam>
	public abstract class Structure<BASE_TYPE> 
	   {
		# region Private data members
		// If true, objects will be cloned and their copy will be used instead of
		// the original object when added to the structure.
		public bool			p_CloneObjects		=  false ;
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the flag indicating if objects are cloned before being added
		/// to the structure.
		/// </summary>
		public bool  CloneObjects
		   {
			get { return ( p_CloneObjects ) ; }
			set { p_CloneObjects = value ; }
		    }
		# endregion


		# region Public methods
		/// <summary>
		/// Creates a copy of the specified object.
		/// </summary>
		/// <param name="source">Object to duplicate.</param>
		/// <returns>Duplicated object.</returns>
		protected BASE_TYPE  CloneObject ( BASE_TYPE  source )
		   {
			// If we are using object references, simply return the source object.
			if  ( ! p_CloneObjects )
				return ( source ) ;

			// Get type information for the source object
			Type		type		= source. GetType ( ) ;


			// If the object is a value type or a string, then a simple assignment will
			// be enough to create a copy of the object, so return the object itself
			if  ( type. IsValueType  ||  type  ==  Type. GetType ( "System.String" ) )
				return ( source ) ;

			// If the object supports the ICloneable interface, use this interface to
			// duplicate the object
			if  ( type. GetInterface ( "ICloneable" )  !=  null )
			   { 
				ICloneable	cloner  = ( ICloneable ) source ;

				return ( ( BASE_TYPE ) cloner. Clone ( ) ) ;
			    }

			// None of the cases above : don't know how to handle that, but anyway return 
			// the original object.
			return ( source ) ;
		    }
		# endregion
	    }
	# endregion
    }