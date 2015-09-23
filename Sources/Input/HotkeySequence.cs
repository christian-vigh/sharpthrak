/**************************************************************************************************************

    NAME
        HotkeySequence.cs

    DESCRIPTION
        Implements a list of hotkeys.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/15]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System;
using	System. Collections. Generic;


namespace Thrak. Input
   {
	public class  HotkeySequence	:  List<Hotkey>
	   {
		# region Constructors
		/// <summary>
		/// Default constructor. Initialize an empty HotkeySequence object.
		/// </summary>
		public  HotkeySequence ( )
				: base ( )
		   { }


		/// <summary>
		/// Builds a HotkeySequence using the specified key combination.
		/// </summary>
		/// <param name="text">A string representing a comma-separated list of hotkeys.</param>
		public HotkeySequence ( String  text )
		   {
			if  ( text  ==  null ||  text  ==  "" )
				throw new ArgumentNullException ( "text" ) ;

			SetSequence ( text ) ;
		    }


		/// <summary>
		/// Builds a HotkeySequence having a single key.
		/// </summary>
		/// <param name="hotkey">Hotkey object. The sequence will consist of only one hotkey.</param>
		public HotkeySequence ( Hotkey  hotkey )
		   {
			this. Add ( hotkey ) ;
		    }
		# endregion


		# region List<> extension methods
		/// <summary>
		/// Removes the last item in the list.
		/// </summary>
		/// <returns>True if the element was removed, false if no more Hotkeys were available.</returns>
		public bool  RemoveLast ( )
		   {
			if  ( base. Count  >  0 )
			   {
				base. RemoveAt ( base. Count - 1 ) ;
				return ( true ) ;
			    }
			else
				return ( false ) ;
		    }
		# endregion


		# region Overridable methods
		/// <summary>
		/// Check if this object is equal to another one.
		/// </summary>
		/// <param name="obj">Object to be compared to.</param>
		/// <returns>True if both objects are equal, false otherwise.</returns>
		public override bool Equals ( object  obj )
		   {
			if  ( obj  is  HotkeySequence )
			   {
				HotkeySequence		hs	=  ( HotkeySequence ) obj ;

				if  ( hs. Count  !=  this. Count )
					return ( false ) ;

				for  ( int  i = 0 ; i  < this. Count ; i ++ )
				   {
					if  ( ! this [i]. Equals  ( hs [i] ) )
						return ( false ) ;
				    }

				return ( true ) ;
			    }
			else
				return ( false ) ;
		    }


		/// <summary>
		/// Gets the hashcode for this object.
		/// </summary>
		public override int GetHashCode ( )
		   {
			return ( base. GetHashCode ( ) ) ;
		    }


		/// <summary>
		/// Returns the string representation of the hotkey sequence.
		/// </summary>
		public override String  ToString ( )
		   {
			return ( String. Join ( ", ", ( IEnumerable<Hotkey> ) this. ToArray ( ) ) ) ;
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Converts a Hotkey into a single-hotkey sequence.
		/// </summary>
		/// <param name="hk">Hotkey to be converted.</param>
		/// <returns>The HotkeySequence object corresponding to <paramref name="hk"/>.</returns>
		public static implicit operator  HotkeySequence ( Hotkey  hk )
		   { return ( new HotkeySequence ( hk ) ) ; }


		/// <summary>
		/// Converts a string of hotkeys into a hotkey sequence object.
		/// </summary>
		/// <param name="hk">String of hotkeys to be converted.</param>
		/// <returns>The HotkeySequence object corresponding to <paramref name="hk"/>.</returns>
		public static implicit operator  HotkeySequence ( String  hk )
		   { return ( new HotkeySequence ( hk ) ) ; }		   
		# endregion

		
		# region Support functions
		/// <summary>
		/// Initialize the object with the specified sequence.
		/// </summary>
		private void  SetSequence ( String  text )
		   {
			char []			separators	=  { ',' } ;


			this. Clear ( ) ;
			text = text. Replace ( " ", "" ) ;

			String []	hotkeys		=  text. Split ( separators ) ;

			foreach ( String  hotkey  in  hotkeys )
				this. Add ( new Hotkey ( hotkey ) ) ;
		    }
		# endregion
	   }
    }
