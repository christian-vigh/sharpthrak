/**************************************************************************************************************

    NAME
        AsynchronousFormThread.cs

    DESCRIPTION
        Class to be instanciated for launching a form in a different thread.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Text ;
using   System. Threading ;
using   System. Windows. Forms ;

using	Thrak ;
using	Thrak. Forms ;


namespace Thrak. Core. Threading
   {
	/// <summary>
	/// Class for creating a form in a separate thread. Usage is :
	/// 
	///	SomeForm	F = new AsynchronousFormThread<SomeForm> ( ). Form ;
	///	F. Show ( ) ;
	///	
	/// </summary>
	/// <typeparam name="FormType">Type of the form to be created. Should derive from the AsynchronousForm class.</typeparam>
	public class AsynchronousFormThread<FormType> where FormType : AsynchronousForm, new ( )
	   {
		// The form that will be created in a separate thread
		private FormType		m_Form		=  default ( FormType ) ;
		// The creating thread
		private Thread			m_Thread ;


		/// <summary>
		/// Default constructor. Start the thread that will create the form.
		/// </summary>
		public AsynchronousFormThread ( )
		   {
			m_Thread			=  new Thread ( new ThreadStart ( this. ThreadStarter ) ) ;
			m_Thread. IsBackground		=  true ;
			m_Thread. Name			= typeof ( FormType ). Name  ; 
			m_Thread. Start ( ) ;
		    }	  


		/// <summary>
		/// This function is invoked in a separate thread to instanciate the desired form.
		/// </summary>
		private void  ThreadStarter ( )
		   {
			FormType	NewForm		= new FormType ( ) ;

			this. m_Form		=  NewForm ;
		    }


		/// <summary>
		/// Gets the form object that has been created by a separate thread.
		/// </summary>
		public FormType  Form 
		   {
			get 
			   {
				// We need to let time to the thread to create the form object.
				while ( m_Form  ==  null )
				   {
					Thread. Sleep ( 5 ) ;
					Application. DoEvents ( ) ;
				    }

				return ( m_Form ) ;
			    }
		    }


		/// <summary>
		/// Returns the thread that creates the object.
		/// </summary>
		public Thread  Thread
		   {
			get { return ( m_Thread ) ; }
		    }
	    }
    }
