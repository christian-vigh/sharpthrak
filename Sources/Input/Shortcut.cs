/**************************************************************************************************************

    NAME
        KeyboardShortcut.cs

    DESCRIPTION
        KeyboardShortcut objects.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. ComponentModel ;
using	System. Collections. Generic ;


namespace Thrak. Input
   {
	/// <summary>
	/// GUI controls that want to process shortcut must implement this interface.
	/// </summary>
	public interface IShortcutClient 
	   {
		/// <summary>
		/// Gets the list of shortcuts handled by the control.
		/// </summary>
		KeyboardShortcut []		Shortcuts { get ; }

		/// <summary>
		/// When a shortcut has been recognized, ask the control to execute the appropriate action.
		/// </summary>
		/// <returns></returns>
		void				Execute ( ShortcutEventArgs	e ) ;
	    }


	/// <summary>
	/// Base class for shortcuts definitions.
	/// </summary>
	public class KeyboardShortcut
	   {
		// Private data members 
		private Object			p_Id ;						// KeyboardShortcut id
		private HotkeySequence		p_Sequence ;					// Hotkey sequence
		private bool			p_Enabled	=  true ;			// True if enabled, false otherwise
		private ShortcutEventHandler	p_Handler	=  null ;			// Shortcut event handler


		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <param name="id">Shortcut id.</param>
		/// <param name="hs">Hotkey sequence associated with this shortcut.</param>
		public KeyboardShortcut ( Object  id, HotkeySequence  hs )
		   {
			p_Id		=  id ;
			p_Sequence	=  hs ;
		    }


		/// <summary>
		/// Constructor with a delegate.
		/// </summary>
		/// <param name="id">Shortcut id.</param>
		/// <param name="hs">Hotkey sequence associated with this shortcut.</param>
		/// <param name="handler">Event handler for this shortcut.</param>
		public KeyboardShortcut ( Object  id, HotkeySequence  hs, ShortcutEventHandler  handler ) :
				this ( id, hs )
		   {
			p_Handler		=  handler ;
		    }


		/// <summary>
		/// Gets/sets the hotkey sequence associated with this shortcut.
		/// </summary>
		public HotkeySequence  Sequence
		   {
			get { return ( p_Sequence ) ; }
			set { p_Sequence = value ; }
		    }


		/// <summary>
		/// Gets/sets a flag indicating whether this shortcut is enabled or not.
		/// </summary>
		public bool  Enabled
		   {
			get { return ( p_Enabled ) ; }
			set { p_Enabled = value ; }
		    }


		/// <summary>
		/// Gets/sets the event handler for this shortcut.
		/// </summary>
		public ShortcutEventHandler  Handler 
		   {
			get { return ( p_Handler ) ; }
			set { p_Handler = value ; }
		    }


		/// <summary>
		/// Gets/sets the shortcut id.
		/// </summary>
		public Object  Id 
		   {
			get { return ( p_Id ) ; }
			set { p_Id = value ; }
		    }
	    }
    }

