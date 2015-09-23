/**************************************************************************************************************

    NAME
        WinAPI/Structures/POINT.cs

    DESCRIPTION
        POINT structure.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Windows POINT structure.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct POINT
	   {
		# region Private data members
		public int	_X ;
		public int	_Y ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a POINT structure from the specified coordinates.
		/// </summary>
		/// <param name="x">X-coordinate of the point.</param>
		/// <param name="y">Y-coordinate of the point.</param>
		public POINT ( int  x, int  y )
		   {
			this. _X  =  x ;
			this. _Y  =  y ;
		    }


		/// <summary>
		/// Builds a POINT structure from a System.Drawing.Point object.
		/// </summary>
		/// <param name="p">Point object used to initialize the POINT structure.</param>
		public POINT ( System. Drawing. Point  p ) :
				this ( p. X, p. Y )
		   { }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the X coordinate of the point.
		/// </summary>
		public int  X
		   {
			get { return ( _X ) ; }
			set { _X = value ; }
		    }


		/// <summary>
		/// Gets/sets the Y coordinate of the point.
		/// </summary>
		public int  Y
		   {
			get { return ( _Y ) ; }
			set { _Y = value ; }
		    }


		/// <summary>
		/// Gets/sets the X coordinate of the point.
		/// </summary>
		public int  Left 
		   {
			get { return ( _X ) ; }
			set { _X = value ; }
		    }


		/// <summary>
		/// Gets/sets the Y coordinate of the point.
		/// </summary>
		public int  Top
		   {
			get { return ( _Y ) ; }
			set { _Y = value ; }
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Converts a POINT structure to a System.Drawing.Point object.
		/// </summary>
		public static implicit operator		System. Drawing. Point ( POINT  p )
		   { return ( new  System. Drawing. Point ( p. _X, p. _Y ) ) ; }


		/// <summary>
		/// Converts a System.Drawing.Point object into a POINT structure.
		/// </summary>
		public static implicit operator		POINT ( System. Drawing. Point  p )
		   { return ( new  POINT ( p. X, p. Y ) ) ; }


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized POINT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized POINT structure.</returns>
		public static implicit operator  POINT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			POINT		Result ;

			Result. _X	=  0 ;
			Result. _Y	=  0 ;

			return ( Result ) ;
		    }
		# endregion


		# region Object inherited methods
		/// <summary>
		/// Checks for equality between two POINT structures.
		/// </summary>
		public static bool operator	== ( POINT  Point1, POINT  Point2 )
		   { return  ( Point1. Equals ( Point2 ) ) ; }
	

		/// <summary>
		/// Checks for inequality between two POINT structures.
		/// </summary>
		public static bool operator	!= ( POINT  Point1, POINT  Point2 )
		   { return  ( ! Point1. Equals ( Point2 ) ) ; }


		/// <summary>
		/// Checks for equality between this instance and another POINT structure.
		/// </summary>
		public bool	Equals  ( POINT  Point )
		   { return ( Point. _X  ==  _X  &&  Point. _Y  ==  _Y ) ; }


		/// <summary>
		/// Checks for equality between this instance and a System.Drawing.Point object.
		/// </summary>
		public bool	Equals  ( System. Drawing. Point  Point )
		   { return ( Point. X  ==  _X  &&  Point. Y  ==  _Y ) ; }


		/// <summary>
		/// Checks for equality between this instance and a generic object.
		/// </summary>
		public override bool	Equals ( object  Object )
		   {
			if  ( Object  is  POINT ) 
				return ( Equals ( ( POINT ) Object ) ) ;
			else if  ( Object  is  System. Drawing. Point )
				return ( Equals ( ( System. Drawing. Point ) Object ) ) ;
			else
				return ( false ) ;
		    }


		/// <summary>
		/// Provides a string representation of the POINT structure.
		/// </summary>
		public override string	ToString ( )
		   { return ( "(" + _X + ", " + _Y + ")" ) ; }


		/// <summary>
		/// Returns the hash code for this POINT structure.
		/// </summary>
		public override int	GetHashCode ( )
		   {
			long		Sum	=  _X + _Y ;
		
			return ( Sum. GetHashCode ( ) ) ;
		    }
		# endregion
	    }
    }