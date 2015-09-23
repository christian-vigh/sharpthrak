/**************************************************************************************************************

    NAME
        WinAPI/Structures/SIZE.cs

    DESCRIPTION
        SIZE structure.

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
	/// Windows SIZE structure.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct SIZE 
	   {
		# region Private data members
		public int	_cx ;
		public int	_cy ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a SIZE structure from width and height values.
		/// </summary>
		/// <param name="cx">Width value.</param>
		/// <param name="cy">Height value.</param>
		public  SIZE ( int  cx, int  cy ) 
	           {
			this. _cx	=  cx ;
			this. _cy	=  cy ;
		    }


		/// <summary>
		/// Builds a SIZE structure from a System.Drawing.Size object.
		/// </summary>
		/// <param name="p">Object to be used to build the SIZE structure.</param>
		public SIZE ( System. Drawing. Size  p ) :
				this ( p. Width, p. Height )
		   { }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the width of the SIZE structure.
		/// </summary>
		public int  cx
		   {
			get { return ( _cx ) ; }
			set { _cx = value ; }
		    }


		/// <summary>
		/// Gets/sets the height of the SIZE structure.
		/// </summary>
		public int  cy
		   {
			get { return ( _cy ) ; }
			set { _cy = value ; }
		    }


		/// <summary>
		/// Gets/sets the width of the SIZE structure.
		/// </summary>
		public int  Width
		   {
			get { return ( _cx ) ; }
			set { _cx = value ; }
		    }


		/// <summary>
		/// Gets/sets the height of the SIZE structure.
		/// </summary>
		public int  Height
		   {
			get { return ( _cy ) ; }
			set { _cy = value ; }
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Converts a SIZE structure to a System.Drawing.Size object.
		/// </summary>
		public static implicit operator		System. Drawing. Size ( SIZE  s )
		   { return ( new  System. Drawing. Size ( s. _cx, s. _cy ) ) ; }


		/// <summary>
		/// Converts a System.Drawing.Size object into a SIZE structure.
		/// </summary>
		public static implicit operator		SIZE ( System. Drawing. Size  s )
		   { return ( new  SIZE ( s. Width, s. Height ) ) ; }


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized SIZE structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized SIZE structure.</returns>
		public static implicit operator  SIZE ( Thrak. WinAPI. Structures. Structure  value )
		   {
			SIZE		Result ;

			Result. _cx	=  0 ;
			Result. _cy	=  0 ;

			return ( Result ) ;
		    }
		# endregion


		# region Object inherited methods
		/// <summary>
		/// Checks for equality between two SIZE structures.
		/// </summary>
		public static bool operator	== ( SIZE  Size1, SIZE  Size2 )
		   { return  ( Size1. Equals ( Size2 ) ) ; }
	

		/// <summary>
		/// Checks for inequality between two SIZE structures.
		/// </summary>
		public static bool operator	!= ( SIZE  Size1, SIZE  Size2 )
		   { return  ( ! Size1. Equals ( Size2 ) ) ; }


		/// <summary>
		/// Checks for equality between this instance and another SIZE structure.
		/// </summary>
		public bool	Equals  ( SIZE  Size )
		   { return ( Size. _cx   ==  _cx  &&  Size. _cy  ==  _cy ) ; }


		/// <summary>
		/// Checks for equality between this instance and a System.Drawing.Size object.
		/// </summary>
		public bool	Equals  ( System. Drawing. Size  Size )
		   { return ( Size. Width  ==  _cx  &&  Size. Height  ==  _cy ) ; }


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
		   { return ( "(" + _cx + ", " + _cy + ")" ) ; }


		/// <summary>
		/// Returns the hash code for this POINT structure.
		/// </summary>
		public override int	GetHashCode ( )
		   {
			long		Sum	=  _cx + _cy ;
		
			return ( Sum. GetHashCode ( ) ) ;
		    }
		# endregion
	    } 
    }