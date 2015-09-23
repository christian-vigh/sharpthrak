/**************************************************************************************************************

    NAME
        ApplicationSettingsForm.cs

    DESCRIPTION
        Implements an application settings form.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/10]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. ComponentModel ;
using	System. Drawing ;
using	System. Text ;
using	System. Windows. Forms ;

using	Thrak ;
using	Thrak. Core ;


namespace Thrak. Forms
   {
	public partial class ApplicationSettingsForm : Thrak. Forms. Form, ILocalizable
	   {
		public enum  FormUIState 
		   {
			Initial			=  0x0000,
			BeginSearch		=  0x0001,
			ShowSearchResult	=  0x0002,
			ItemSelected		=  0x0003
		    }

		private FormUIState	m_UIState ;


		public ApplicationSettingsForm ( )
		   {
			InitializeComponent ( ) ;
			LocalizableUI. Register ( this ) ;
		    }

		~ApplicationSettingsForm ( )
		   {
			LocalizableUI. Unregister ( this ) ;
		    }


		[Browsable ( false )]
		public FormUIState	UIState
		   {
			get { return ( m_UIState ) ; }
			private set 
			   {
				switch ( value )
				   {
					case	FormUIState. Initial :
						this. AcceptButton			= this. OkButtonCommand ;
						this. SearchResultsListBox.Visible	= false ;
						this.SettingsTreeView.Visible		= true ;
						this. SettingsTreeView. Focus ( ) ;
						break ;

					case	FormUIState. BeginSearch :
						this. AcceptButton			= this. SearchButtonCommand ;
						this.SettingsTreeView.Visible		= false ;
						this.SearchResultsListBox.Visible	= true ;
						break ;
				    }

				m_UIState	=  value ;
			    }
		    }


		private void ApplicationSettingsForm_Load ( object sender, EventArgs e )
		   {
			UIState		=  FormUIState. Initial ;
		    }


		private void SearchTextBox_Enter ( object sender, EventArgs e )
		   {
			this. UIState	=  FormUIState. BeginSearch ;
		    }


		public void OnCultureChange ( object  sender, LocalizableEventArgs  args )
		   {
			this. SearchLabel. Text			= Resources. Localization. Forms. ApplicationSettingsForm. SearchLabel ;
			this. Text				= Resources. Localization. Forms. ApplicationSettingsForm. WindowTitle ;
			this. OkButtonCommand. Text		= Resources. Localization. Forms. ApplicationSettingsForm. OKButton ;
			this. CancelButtonCommand. Text		= Resources. Localization. Forms. ApplicationSettingsForm. CancelButton ;
			this. ApplyButtonCommand. Text		= Resources. Localization. Forms. ApplicationSettingsForm. ApplyButton ;
		    }



	    }
    }
