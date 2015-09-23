/**************************************************************************************************************

    NAME
        WinAPI/Structures/RECT.cs

    DESCRIPTION
        RECT structure.

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
	/// Windows RECT structure.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential ) ]
	public struct RECT
	   {
		# region Data members
		// Private data members
		private int		_Left ;
		private int		_Top ;
		private int		_Right ;
		private int		_Bottom ;
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a RECT structure from another one.
		/// </summary>
		/// <param name="Rectangle">RECT structure to be duplicated.</param>
		public	RECT ( RECT  Rectangle ) : 
				this ( Rectangle. Left, Rectangle. Top, Rectangle. Right, Rectangle. Bottom )
		   { }
	

		/// <summary>
		/// Builds a RECT structure from a System.Drawing.Rectangle instance.
		/// </summary>
		/// <param name="Rectangle">Rectangle instance to be used for building the Windows RECT structure.</param>
		public  RECT ( System. Drawing. Rectangle  Rectangle ) :
				this ( Rectangle. Left, Rectangle. Top, Rectangle. Right, Rectangle. Bottom )
		   { }


		/// <summary>
		/// Builds a RECT structure from the specified coordinates.
		/// </summary>
		/// <param name="Left">X-position of the upper-left corner.</param>
		/// <param name="Top">Y-position of the upper-let corner.</param>
		/// <param name="Right">X-position of the lower-right corner.</param>
		/// <param name="Bottom">Y-position of the lower-right corner.</param>
		public  RECT ( int  Left, int  Top, int  Right, int  Bottom )
		   {
			_Left		=  Left ;
			_Top		=  Top ;
			_Right		=  Right ;
			_Bottom		=  Bottom ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the X-coordinate of the left part of the rectangle.
		/// </summary>
		public int	X 
		   {
			get { return ( _Left ) ; }
			set { _Left = value ; }
		    }


		/// <summary>
		/// Gets/sets the Y-coordinate of the upper part of the rectangle.
		/// </summary>
		public int	Y 
		   {
			get { return ( _Top ) ; }
			set { _Top = value ; }
		    }


		/// <summary>
		/// Gets/sets the X-coordinate of the left part of the rectangle.
		/// </summary>
		public int	Left 
		   {
			get { return ( _Left ) ; }
			set { _Left = value ; }
		    }


		/// <summary>
		/// Gets/sets the Y-coordinate of the upper part of the rectangle.
		/// </summary>
		public int	Top 
		   {
			get { return ( _Top ) ; }
			set { _Top = value ; }
		    }


		/// <summary>
		/// Gets/sets the X-coordinate of the right part of the rectangle.
		/// </summary>
		public int	Right 
		   {
			get { return ( _Right ) ; }
			set { _Right = value ; }
		    }


		/// <summary>
		/// Gets/sets the Y-coordinate of the bottom part of the rectangle.
		/// </summary>
		public int	Bottom 
		   {
			get { return ( _Bottom ) ; }
			set { _Bottom = value ; }
		    }


		/// <summary>
		/// Gets/sets the height of the rectangle.
		/// </summary>
		public int	Height 
		   {
			get { return ( _Bottom - _Top ) ; }
			set { _Bottom = value + _Top ; }
		    }


		/// <summary>
		/// Gets/sets the width of the rectangle.
		/// </summary>
		public int	Width 
		   {
			get { return ( _Right - _Left ) ; }
			set { _Right = value + _Left ; }
		    }


		/// <summary>
		/// Gets the location of the upper-left corner of the rectangle.
		/// </summary>
		public POINT	Location 
		   {
			get { return ( new POINT ( Left, Top ) ) ; }
			set 
			   {
				_Left	=  value. X ;
				_Top	=  value. Y ;
			    }
		    }


		/// <summary>
		/// Gets the location of the upper-left corner of the rectangle.
		/// </summary>
		public POINT	LocationOfULCorner
		   {
			get { return ( new POINT ( _Left, _Top ) ) ; }
		    }


		/// <summary>
		/// Gets the location of the upper-right corner of the rectangle.
		/// </summary>
		public POINT	LocationOfURCorner
		   {
			get { return ( new POINT ( _Right, _Top ) ) ; }
		    }


		/// <summary>
		/// Gets the location of the lower-left corner of the rectangle.
		/// </summary>
		public POINT	LocationOfLLCorner
		   {
			get { return ( new POINT ( _Left, _Bottom ) ) ; }
		    }


		/// <summary>
		/// Gets the location of the lower-right corner of the rectangle.
		/// </summary>
		public POINT	LocationOfLRCorner
		   {
			get { return ( new POINT ( _Right, _Bottom ) ) ; }
		    }



		/// <summary>
		/// Gets/sets the size of the rectangle.
		/// </summary>
		public SIZE	Size 
		   {
			get { return ( new SIZE ( Width, Height ) ) ; }
			set 
			   {
				_Right		=  value. Width  + _Left ;
				_Bottom		=  value. Height + _Top ;
			    }
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Converts a RECT structure to a System.Drawing.Rectangle object.
		/// </summary>
		public static implicit operator		System. Drawing. Rectangle ( RECT  Rectangle )
		   { return ( new  System. Drawing. Rectangle ( Rectangle. _Left, Rectangle. _Top, Rectangle. Width, Rectangle. Height) ) ; }


		/// <summary>
		/// Converts a System.Drawing.Rectangle object into a RECT structure.
		/// </summary>
		public static implicit operator		RECT ( System. Drawing. Rectangle  Rectangle )
		   { return ( new  RECT ( Rectangle. Left, Rectangle. Top, Rectangle. Right, Rectangle. Bottom ) ) ; }




		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized RECT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized RECT structure.</returns>
		public static implicit operator  RECT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			RECT		Result ;

			Result. _Left	=  0 ;
			Result. _Top	=  0 ;
			Result. _Right	=  0 ;
			Result. _Bottom	=  0 ;

			return ( Result ) ;
		    }

		# endregion


		# region Object inherited methods
		/// <summary>
		/// Checks for equality between two RECT structures.
		/// </summary>
		public static bool operator	== ( RECT  Rectangle1, RECT  Rectangle2 )
		   { return  ( Rectangle1. Equals ( Rectangle2 ) ) ; }
	

		/// <summary>
		/// Checks for inequality between two RECT structures.
		/// </summary>
		public static bool operator	!= ( RECT  Rectangle1, RECT  Rectangle2 )
		   { return  ( ! Rectangle1. Equals ( Rectangle2 ) ) ; }


		/// <summary>
		/// Checks for equality between this instance and another RECT structure.
		/// </summary>
		public bool	Equals  ( RECT  Rectangle )
		   {
			return 
			   (
				Rectangle. Left		==  _Left	&& 
				Rectangle. Top		==  _Top	&& 
				Rectangle. Right	==  _Right	&& 
				Rectangle. Bottom	==  _Bottom
			    ) ;
		    }


		/// <summary>
		/// Checks for equality between this instance and a System.Drawing.Rectangle object.
		/// </summary>
		public bool	Equals  ( System. Drawing. Rectangle  Rectangle )
		   {
			return 
			   (
				Rectangle. Left		==  _Left	&& 
				Rectangle. Top		==  _Top	&& 
				Rectangle. Right	==  _Right	&& 
				Rectangle. Bottom	==  _Bottom
			    ) ;
		    }


		/// <summary>
		/// Checks for equality between this instance and a generic object.
		/// </summary>
		public override bool	Equals ( object  Object )
		   {
			if  ( Object  is  RECT ) 
				return ( Equals ( ( RECT ) Object ) ) ;
			else if  ( Object  is  System. Drawing. Rectangle )
				return ( Equals ( ( System. Drawing. Rectangle ) Object ) ) ;
			else
				return ( false ) ;
		    }


		/// <summary>
		/// Provides a string representation of the RECT structure.
		/// </summary>
		public override string	ToString ( )
		   {
			return 
			   (
				"(" + _Left + ", " + _Top + "), (" + _Right + ", " + _Bottom + ")"
			    ) ;
		    }


		/// <summary>
		/// Returns the hash code for this RECT structure.
		/// </summary>
		public override int	GetHashCode ( )
		   {
			long		Sum	=  _Left + _Right + _Top + _Bottom ;
		
			return ( Sum. GetHashCode ( ) ) ;
		    }
		# endregion
	}
    }
