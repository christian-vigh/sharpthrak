/**************************************************************************************************************

    NAME
        Shortcuts.cs

    DESCRIPTION
        Implements an object that can be used by a form or a control to track a hotkey or sequence of hotkeys
	typed by the user.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/16]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using   System. ComponentModel ;
using   System. Windows. Forms ;

using   Thrak. Core ;


namespace Thrak. Input
   {
	# region Exceptions
	/// <summary>
	/// Exception object base for the Shortcuts exceptions.
	/// </summary>
	public class ShortcutException	:  ThrakException
	   {
		/// <summary>
		/// Throws an exception with the specified message.
		/// </summary>
		/// <param name="message">Exception message, formatted using String.Format().</param>
		/// <param name="argv">Additional parameters for String.Format().</param>
		public ShortcutException ( String  message, params Object []  argv )
				: base ( String. Format ( message, argv ) )
		   { }
	    }


	/// <summary>
	/// Exception thrown when trying to add an already defined hotkey sequence to a Shortcuts object.
	/// </summary>
	public class  ShortcutAlreadyDefinedException	:  ShortcutException
	   {
		public  ShortcutAlreadyDefinedException ( String  hotkey )
				: base ( Resources. Localization. Classes. Hotkey. HotkeyAlreadyDefinedException, hotkey )
		   { }
	    }


	/// <summary>
	/// Exception thrown when trying to add an already defined hotkey sequence to a Shortcuts object.
	/// </summary>
	public class  ShortcutNameAlreadyDefinedException	:  ShortcutException
	   {
		public  ShortcutNameAlreadyDefinedException ( String  hotkey )
				: base ( Resources. Localization. Classes. Hotkey. HotkeyNameAlreadyDefinedException, hotkey )
		   { }
	    }


	/// <summary>
	/// Exception thrown when trying to add an already defined hotkey sequence to a Shortcuts object.
	/// </summary>
	public class  ShortcutCommonSequenceException	:  ShortcutException
	   {
		public  ShortcutCommonSequenceException ( String  new_hotkey, String  existing_hotkey )
				: base ( Resources. Localization. Classes. Hotkey. CommonSequenceException, 
						new_hotkey, existing_hotkey )
		   { }
	    }
	# endregion


	# region Event args and delegates
	/// <summary>
	/// Handler called when a specific shortcut has been entered by the user.
	/// </summary>
	/// <param name="sender">Sender object.</param>
	/// <param name="e">KeyboardShortcut definition.</param>
	public delegate void	ShortcutEventHandler	( ShortcutEventArgs  e ) ;


	/// <summary>
	/// Event args sent to a form.
	/// </summary>
	public class  ShortcutEventArgs
	   {
		/// <summary>
		/// Hotkeys collected so far.
		/// </summary>
		public KeyboardShortcut			Hotkey ;


		/// <summary>
		/// Default constructor.
		/// </summary>
		public  ShortcutEventArgs ( )
		   { }


		/// <summary>
		/// Returns a string representation of the captured hotkey.
		/// </summary>
		public override string ToString ( )
		   {
			return ( Hotkey. ToString ( ) ) ;
		    }
	    }
	# endregion


	# region Shortcuts class
	/// <summary>
	/// The Shortcuts class is used to define hotkeys or complex hotkey sequences.
	/// It also provides support to a form for interpreting user input and finding the appropriate hotkey.
	/// <para>(this is the case for example of the Thrak.Forms.Form object, which has an internal Shortcuts object).</para>
	/// </summary>
	public class  Shortcuts
	   {
		# region Internal members
		// List of hotkey sequences
		internal List<KeyboardShortcut>				Sequences		=  new List<KeyboardShortcut> ( ) ;
		// Current hotkey tracking list
		internal List<KeyEventArgs>			Tracker			=  new List<KeyEventArgs> ( ) ;
		# endregion


		# region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		internal Shortcuts ( )
		   { }
		# endregion


		# region Public methods
		/// <summary>
		/// Adds the specified shortcut to the shortcut table.
		/// </summary>
		public void  Add ( KeyboardShortcut  sh )
		   {
			/// Check the validity of the new shortcut
			foreach  ( KeyboardShortcut  csh  in  Sequences )
			   {
				// Check that the id is unique
				//if  ( csh. Id. Equals ( sh. Id ) )
				//	throw new ShortcutNameAlreadyDefinedException ( sh. Id. ToString ( ) ) ;

				// Check that the hotkey sequence is unique
				if (  csh. Sequence. Equals ( sh. Sequence ) )
					throw new ShortcutAlreadyDefinedException ( sh. Sequence. ToString ( ) ) ;

				// Finally, check that there is no common sequence between two shortcuts
				int		max		=  Math. Min<int> ( csh. Sequence. Count, sh. Sequence. Count ) ;
				int		common		=  0 ;

				for  ( int  i = 0 ; i < max ; i ++ )
				   {
					if ( csh.Sequence [i]. Equals ( sh. Sequence [i] ) )
						common ++ ;
					else
						break ;
				    }

				if  ( common  ==  max )
					throw new ShortcutCommonSequenceException ( sh. Sequence. ToString ( ), csh. Sequence. ToString ( ) ) ;
			    }

			// All done, add the shortcut to the list
			Sequences. Add ( sh ) ;
		    }


		/// <summary>
		/// Clears the hotkeys collected so far.
		/// </summary>
		public void  Clear ( )
		   {
			Tracker. Clear ( ) ;
		     }
		# endregion


		# region Internal methods
		/// <summary>
		/// Handles a new keyboard event and tries to match with a defined key sequence.
		/// </summary>
		/// <returns>True if the event has been handled, false otherwise.</returns>
		internal ShortcutEventArgs  HandleKeyEvent ( KeyEventArgs  e )
		   {
			// If not shortcut defined, then let the chance to other keyboard handler derivates to handle this one
			if  ( Sequences. Count  ==  0 )
			   {
				e. Handled	=  false ;
				return ( null ) ;
			    }

			// First of all, check if key combination can be a Hotkey
			if ( ! Hotkey. IsValidHotkey ( e. Modifiers, e. KeyCode ) )
				return ( null ) ;

			// Resulting value
			ShortcutEventArgs		hke		=  new ShortcutEventArgs ( ) ;


			// If no previous hotkey was entered, then we should not "eat" this one if it does not belong to our list of
			// existing hotkey sequences, so search for any sequence that could start with this one
			Tracker. Add ( e ) ;

			// Loop through each sequence
			foreach  ( KeyboardShortcut  hs  in  Sequences )
			   {
				// If accumulated hotkey count different from that particular sequence cont, ignore it
				if  ( hs. Sequence. Count  <  Tracker. Count )
					continue ;

				// Compare the current sequence with the accumulated hotkeys
				int	max_index		=  Math. Min<int> ( hs. Sequence. Count, Tracker. Count ) ;
				int	matches			=  0 ;

				for  ( int  i = 0 ;  i  <  max_index ; i ++ )
				   {
					// If current hotkey is current accumulated key event, count one more match
					if  ( hs. Sequence [i]. Modifiers  ==  Tracker [i]. Modifiers  &&  
					      hs. Sequence [i]. KeyCode    ==  Tracker [i]. KeyCode )
						matches ++ ;
					// Otherwise, we had a common sequence between hotkey and accumulated key events
					else
					   {
						matches		=  -1 ;
						break ;
					    }
				    }

				// Hotkey and accumulated key events start with a common sequence, but the remainer is different so process
				// next hotkey sequence
				if  ( matches  ==  -1 )
					continue ;
				// We have found an exact match
				else if  ( matches  ==  hs. Sequence. Count  &&  matches  ==  Tracker. Count )
				   {
					hke. Hotkey	=  hs ;

					Tracker. Clear ( ) ;
					e. Handled	=  true ;

					return ( hke ) ;
				    }
				// We have found a partial match
				else if  ( matches  >  0  &&  matches  <  hs. Sequence. Count )
				   {
					e. Handled	=  true ;
					return ( null ) ;
				    }
			    }

			// No match found
			Tracker. Clear ( ) ;
			e. Handled	=  false ;
			return ( null ) ;
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Adds a shortcut to the shortcut table.
		/// </summary>
		public static Shortcuts  operator + ( Shortcuts  list, KeyboardShortcut  s )
		   {
			list. Add ( s ) ;
			return ( list ) ;
		    }
		# endregion
	    }
	# endregion
    }
