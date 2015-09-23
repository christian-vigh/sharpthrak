/**************************************************************************************************************

    NAME
        ISet.cs

    DESCRIPTION
        Interface for mathematical sets.

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
	/// Exception thrown by Set objects.
	/// </summary>
	public class  SetException : ThrakException
	   {
		/// <summary>
		/// Builds a SetException object.
		/// </summary>
		public SetException ( String  message )
			: base ( message ) 
		   { }
	    }
	# endregion


	# region  ISet interface
	/// <summary>
	/// Standard interface for sets.
	/// </summary>
	public interface  ISet
	   {
		void  Difference		( ISet		set ) ;
		void  Intersection		( ISet		set ) ;
		void  Union			( ISet		set ) ;
		void  Symetric			( ) ;
		void  Minus			( ISet		set ) ;

		void  Add			( int		value ) ;
		void  Add			( ICollection	values ) ;
		void  Clear			( ) ;
		bool  Contains			( int		value ) ;
		bool  IsEqual			( ISet		value ) ;
		bool  IsProperSubsetOf		( ISet		value ) ;
		bool  IsProperSupersetOf	( ISet		value ) ;
		bool  IsSubsetOf		( ISet		value ) ;
		bool  IsSupersetOf		( ISet		value ) ;
		void  Remove			( int		value ) ;
		void  Remove			( ICollection	values ) ;

		int   Count	{ get ; }
		bool  IsEmpty   { get ; }
	    }
	# endregion
    }
