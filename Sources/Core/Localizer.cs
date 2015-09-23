/**************************************************************************************************************

    NAME
	Localizer.cs		

    DESCRIPTION
        Localization helper objects.

    AUTHOR
        Christian Vigh, 07/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/01]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. Threading ;
using	System. Globalization ;


namespace Thrak. Core
   {
	# region LocalizableUI class
	/// <summary>
	/// The LocalizableUI static class allows an application for localizing its UI elements according to the
	/// currently selected culture.
	/// The calling class must implement the ILocalizable interface, then call the Register() function from
	/// its constructor to declare to LocalizableUI the OnCultureChange event.
	/// </summary>
	public class LocalizableUI
	   {
		// Event handlers declared through the Register method.
		private static event EventHandler<LocalizableEventArgs>		CultureChangeEvent ;
		// Flag indicating whether the current culture has been changed
		private static Boolean						CultureChanged ;


		/// <summary>
		/// Registers a new event handler for the specified object, which must implement the ILocalizable interface.
		/// </summary>
		/// <param name="obj">Object implementing the OnCultureChange event handler.</param>
		public static void  Register ( ILocalizable  obj )
		   {
			try { CultureChangeEvent -= obj. OnCultureChange ; }
			catch { }

			CultureChangeEvent += obj. OnCultureChange ;

			// If current culture has been changed, fire the OnCultureChange event for this newcomer
			if  ( CultureChanged )
				obj. OnCultureChange ( null, new LocalizableEventArgs ( LocalizableUI. Culture ) ) ;
		    }


		/// <summary>
		/// Unregisters an existing culture change event handler.
		/// </summary>
		/// <param name="obj">Object implementing the OnCultureChange event handler.</param>
		public static void  Unregister ( ILocalizable  obj )
		   {
			CultureChangeEvent -= obj. OnCultureChange ;
		    }


		/// <summary>
		/// Gets/sets the current culture string.
		/// </summary>
		/// <value>
		/// Culture string, such as "fr-FR", "en-US", etc. Changing this values makes the OnCultureChange event handler
		/// to be called for all registered objects.
		/// </value>
		/// <remarks>The sender object of the event handler is always null.</remarks>
		public static String  Culture
		   {
			get 
			   {
				return ( Thread. CurrentThread. CurrentUICulture. Name ) ;
			    }

			set
			   {
				Thread. CurrentThread. CurrentUICulture = CultureInfo. GetCultureInfo ( value ) ;

				EventHandler<LocalizableEventArgs>	handler		=  CultureChangeEvent ;

				if  ( handler  !=  null )
					handler ( null, new LocalizableEventArgs ( value ) ) ;

				CultureChanged	= true ;
			    }
		    }
	    }
	# endregion


	# region LocalizableEventArgs class
	/// <summary>
	/// Arguments passed to the OnCultureChanged event handler.
	/// </summary>
	public class LocalizableEventArgs : EventArgs
	   {
		private String		m_Culture ;


		public LocalizableEventArgs ( String  Culture ) 
		   {
			m_Culture = Culture ;
		    }


		public String Culture
		   {
			get { return ( m_Culture ) ; }
		    }
	    }
	# endregion
	

	# region ILocalizable interface
	/// <summary>
	/// Objects that want to be UI-culture changes-aware must implement this interface and call the
	/// Register() function in their constructor.
	/// </summary>
	public interface ILocalizable
	   {
		void OnCultureChange ( object  sender, LocalizableEventArgs  args ) ;
	    }
	# endregion
    }
