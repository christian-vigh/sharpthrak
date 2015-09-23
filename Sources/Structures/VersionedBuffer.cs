/**************************************************************************************************************

    NAME
        VersionedBuffer.cs

    DESCRIPTION
        Implements a string with multiple content versions.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/16]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. Collections ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text ;


namespace Thrak. Structures
   {
	/// <summary>
	/// A small utility class that allows for keeping several versions of a string, and performs undos and redos on it.
	/// <para>This class can be used in conjunction with a text box, to keep track of more than one modification.</para>
	/// </summary>
	public class	VersionedBuffer
	   {
		# region Private data members
		// Circular buffer used for holding the successive versions of a string.
		private CircularBuffer<String>		p_Buffer ;
		// Current index in the circular buffer.
		private int				p_Index			=  -1 ;
		# endregion


		# region Constructor
		/// <summary>
		/// Builds a VersionedBuffer object of the specified size.
		/// </summary>
		/// <param name="size">Max versions of the same string to be tracked.</param>
		public  VersionedBuffer ( int  size )
		   {
			p_Buffer		=  new CircularBuffer<string> ( size ) ;
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Equivalent to the Add() method.
		/// </summary>
		public static VersionedBuffer  operator  +  ( VersionedBuffer  vb, String  value )
		   { 
			vb. Add ( value ) ;

			return ( vb ) ;
		     }
		# endregion


		# region Public methods
		/// <summary>
		/// Add the specified string as a new version.
		/// <para>Versions that may appear after the current insertion point are discarded.</para>
		/// </summary>
		/// <param name="value">New string value to be versioned.</param>
		public void  Add ( String  value )
		   {
			if  ( p_Index + 1  <  p_Buffer. Length )
				p_Buffer. Shrink ( p_Buffer. Length - ( p_Index + 1 ) ) ;

			p_Buffer. Add  ( value ) ;
			p_Index ++ ;
		    }


		/// <summary>
		/// Undo the last version.
		/// <para>
		/// The current insertion point is moved backward, but subsequent versions are kept in case of the Redo() function
		/// is called later. Those subsequent versions, however, will be discarded when the Add() function will be called.
		/// </para>
		/// </summary>
		/// <returns>The previous version of the string, or the current string if no more modification can be undone.</returns>
		public String  Undo ( )
		   {
			String		result ;


			if  ( p_Index  ==  0 )
				result = "" ;
			else
				result = p_Buffer [ -- p_Index ] ;

			return ( result ) ;
		    }


		/// <summary>
		/// Redo the last version.
		/// <para>
		/// The current insertion point is moved forward.
		/// </para>
		/// </summary>
		/// <returns>The next version of the string, or the current string if no more modifications are available.</returns>
		public String  Redo ( ) 
		   {
			String		result ;


			if  ( p_Index  + 1  <  p_Buffer. Length )
				result = p_Buffer [ ++ p_Index ] ;
			else
				result = p_Buffer [ p_Index ] ;

			return ( result ) ;
		    }
		# endregion
	    }
    }
