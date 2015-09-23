/**************************************************************************************************************

    NAME
        Main.cs

    DESCRIPTION
        Provides a way to initialize the library components. Must be called from main program.

    AUTHOR
        Christian Vigh, 07/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/07/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;


namespace Thrak
   {
	public class Library
	   {
		// Flag that tells if the library is initialized
		protected static bool		Initialized		= false ;


		/*==============================================================================================================
		
		    Library initialization method.
		
		  ==============================================================================================================*/
		[STAThread]
		public static void Initialize ( ) 
		  {
			// Initialize the library
			if ( ! Initialized ) 
			   {

				// Tell that we are initialized
				Initialized = true ;
			    }
		   }
	    }
     }
