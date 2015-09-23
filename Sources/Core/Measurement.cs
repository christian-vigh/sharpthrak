/**************************************************************************************************************

    NAME
        Measurement.cs

    DESCRIPTION
        Provides methods for measuring program execution.

    AUTHOR
        Christian Vigh, 07/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/07/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Collections ;
using   System. Collections. Generic ;
using   System. Windows. Forms ;


namespace Thrak. Core. Runtime
   {
	# region Enumerations
	/// <summary>
	/// Enumeration used by the GetCounters() method to select the measurement counters.
	/// </summary>
	public enum  MeasurementCounterSelection
	   {
		Started			=  0,			// Select started counters
		Stopped			=  1,			// Select stopped counters
		All			=  2			// Select all counters
	    }


	/// <summary>
	/// Used by methods such as ShowMessageBox(), which give the counter results using the specified granularity.
	/// </summary>
	public enum  MeasurementCounterGranularity
	   {
		Days,
		Hours,
		Minutes,
		Seconds,
		Milliseconds,
		Ticks
	    }
	# endregion


	# region MeasurementCounter class
	/// <summary>
	/// Implements a counter. Measurement counters do not run asynchronously : they simply have a start time,
	/// and when the counter is stopped, either by setting the Running property to false or by calling the
	/// Stop() or StopAll() method of the MeasurementCounters class, they are assigned an ending time, which
	/// gives the elapsed time.
	/// </summary>
	public class  MeasurementCounter 
	   {
		# region Private data members
		private String		p_Name ;					// Counter name
		private DateTime	p_StartTime	=  DateTime. MinValue ;		// Start time (default is... Pleistocene)
		private DateTime	p_EndTime	=  DateTime. MinValue ;		// End time
		private TimeSpan	p_Elapsed	=  TimeSpan. MinValue ;		// Elapsed time
		private Boolean		p_Running ;					// When true, the counter is still "running"
		# endregion


		# region Constructor
		/// <summary>
		/// Builds a MeasurementCounter object with the specified name.
		/// </summary>
		/// <param name="Name">Counter name.</param>
		public  MeasurementCounter ( String  Name )
		   { p_Name = Name ; }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the name of the counter.
		/// </summary>
		public String  Name
		   {
			get { return ( p_Name ) ; }
		    }


		/// <summary>
		/// Gets the counter starting time.
		/// </summary>
		public DateTime  StartTime
		   {
			get { return ( p_StartTime ) ; }
		    }


		/// <summary>
		/// Gets the counter ending time. 
		/// If the counter is still running, updates the p_EndTime and p_Elapsed members before returning the result.
		/// </summary>
		public DateTime  EndTime
		   {
			get
			   {
				if  ( p_Running )
					UpdateEndTime ( ) ;

				return ( p_EndTime ) ;
			    }
		    }


		/// <summary>
		/// Gets the counter elapsed time. 
		/// If the counter is still running, updates the p_EndTime and p_Elapsed members before returning the result.
		/// </summary>
		public TimeSpan  Elapsed
		   {
			get 
			   {
				if  ( p_Running )
					UpdateEndTime ( ) ;

				return ( p_Elapsed ) ;
			    }
		    }


		/// <summary>
		/// Gets/sets the running state of the counter.
		/// When set to true, the counter starting time is updated accordingly.
		/// When set to false (counter is stopped), the p_EndTime and p_Elapsed members are updated to the current time.
		/// </summary>
		public  Boolean  Running
		   {
			get { return ( p_Running ) ; }

			set
			   {
				if  ( value )
					p_StartTime	=  DateTime. Now ;
				else 
					UpdateEndTime ( ) ;

				p_Running	=  value ;
			    }
		    }
		# endregion


		private void  UpdateEndTime ( )
		   {
			p_EndTime	=  DateTime. Now ;
			p_Elapsed	=  p_EndTime. Subtract ( p_StartTime ) ;
		    }
	    }
	# endregion


	# region MeasurementCounters class
	/// <summary>
	/// The MeasurementCounters class allows for a fast way to measure execution times of blocks of codes.
	/// It is mainly used for debugging purposes.
	/// 
	/// The basic usage is :
	///	MeasurementCounters  C	=  new MeasurementCounters ( ) ;
	///	
	///	C. Start ( "C1" ) ;		// Creates a counter named "C1" and starts it
	///	{ ... block of code ... }
	///	C. Stop ( ) ;			// Stops the last created counter ( C. Stop ( "C1" ) would do the same
	///	
	/// It is possible to create embedded counters ; for example :
	/// 
	///	C. Start ( "Global" )
	///	C. Start ( "C1" ) ;
	///	{ ... block of code ... }
	///	C. Stop ( "C1" ) ;
	///	C. Start ( "C2" ) ;
	///	{ ... block of code ... }
	///	
	///	// You can put the following optional statements :
	///	C. Stop ( "C2" ) ;
	///	C. Stop ( "Global" ) ;
	///	// Or even C. StopAll ( )
	///	
	///	// Before displaying the results in a message box :
	///	C. ShowMessageBox ( ) ;
	/// </summary>
	public class  MeasurementCounters  : IEnumerable
	   {
		// List of measurement counters
		private List<MeasurementCounter>		p_Counters ;


		# region Constructor
		/// <summary>
		/// Builds a MeasurementCounters object with an empty list of counters.
		/// </summary>
		public MeasurementCounters ( )
		   {
			Clear ( ) ; 
		    }
		# endregion


		# region Public methods
		/// <summary>
		/// Defines a counter with a unique name in the counter list. The counter will have the name "#x",
		/// where "x" is the count of already defined counters plus one.
		/// </summary>
		/// <returns>The newly created MeasurementCounter object.</returns>
		public MeasurementCounter  Define ( )
		   {
			String		Name	=  "#" + ( p_Counters.Count + 1 ). ToString ( ) ;

			return ( Define ( Name ) ) ;
		    }


		/// <summary>
		/// Defines a counter with the specified name.
		/// Throws an exception if the counter already exists.
		/// </summary>
		/// <param name="Name">Counter name.</param>
		/// <returns>The newly created MeasurementCounter object.</returns>
		public MeasurementCounter  Define ( String  Name )
		   {
			MeasurementCounter	Item		=  GetCounter ( Name ) ;


			if  ( Item  ==  null )
			   {
				Item	=  new MeasurementCounter ( Name ) ;
				p_Counters. Add ( Item ) ;
				return ( Item ) ;
			    }

			throw new ArgumentException ( "Measurement counter \"" + Name + "\" already defined." ) ;
		    }


		/// <summary>
		/// Removes the specified counter.
		/// </summary>
		/// <param name="Name">Name of the counter to be removed.</param>
		public void  Undefine ( String  Name )
		   {
			MeasurementCounter	Item		=  GetCounter ( Name ) ;


			if  ( Item   !=  null )
				p_Counters. Remove ( Item ) ;
			else
				throw new ArgumentException ( "Measurement counter \"" + Name + "\" does not exist." ) ;
		    }


		/// <summary>
		/// Creates a new counter and sets its state to "running".
		/// </summary>
		/// <returns>The newly created MeasurementCounter object.</returns>
		public MeasurementCounter  Start ( )
		   {
			MeasurementCounter	Item		=  Define ( ) ;

			Item. Running	=  true ;

			return ( Item ) ;
		    }


		/// <summary>
		/// Starts an existing counter having the specified index.
		/// Throws an exception if the counter index is out of range.
		/// </summary>
		/// <param name="Index">Index of the counter to be started.</param>
		/// <returns>The MeasurementCounter object corresponding to the started counter.</returns>
		public MeasurementCounter  Start ( int  Index )
		   {
			MeasurementCounter	Item		=  GetCounter ( Index ) ;

			if  ( Item  !=  null )
			   {
				Item. Running	=  true ;
				return ( Item ) ;
			    }

			throw new ArgumentException ( "Measurement counter at index " + Index. ToString ( ) + " does not exist." ) ;
		    }


		/// <summary>
		/// Starts a counter having the specified name. Creates the counter if it does not already exist.
		/// </summary>
		/// <param name="Name">Counter name.</param>
		/// <returns>Either an existing counter object, or the newly created counter object if <paramref name="Name"/>does not exist.</returns>
		public MeasurementCounter  Start ( String  Name )
		   {
			MeasurementCounter	Item		=  GetCounter ( Name ) ;


			if  ( Item  ==  null )
				Item = Define ( Name ) ;

			Item. Running	=  true ;

			return ( Item ) ;
		    }


		/// <summary>
		/// Stops the last started counter.
		/// </summary>
		/// <returns>The MeasurementCounter object corresponding to the last started counter.</returns>
		public MeasurementCounter  Stop ( )
		   {
			for  ( int  i = p_Counters. Count - 1 ; i  >=  0 ; i -- )
			   {
				MeasurementCounter	Item		=  p_Counters [i] ;

				if  ( Item. Running )
				   {
					Item. Running  =  false ;
					return ( Item ) ;
				    }
			    }

			throw new ArgumentOutOfRangeException ( "No measurement counter is currently running." ) ;
		    }


		/// <summary>
		/// Stops the counter at the specified index.
		/// </summary>
		/// <param name="Index">Index of the counter to be stopped.</param>
		/// <returns>The MeasurementCounter object that has been put in a stopped state.</returns>
		public MeasurementCounter  Stop ( int  Index )
		   {
			MeasurementCounter	Item		=  GetCounter ( Index ) ;


			if  ( Item  !=  null )
			   {
				Item. Running	=  false ;
				return ( Item ) ;
			    }

			throw new ArgumentException ( "Measurement counter at index " + Index. ToString ( ) + " does not exist." ) ;
		    }


		/// <summary>
		/// Stops the counter having the specified name.
		/// Throws an exception if no counter exists with that specific name.
		/// </summary>
		/// <param name="Name">Counter name.</param>
		/// <returns>The MeasurementCounter object that has been stopped.</returns>
		public MeasurementCounter  Stop ( String  Name )
		   {
			MeasurementCounter	Item		=  GetCounter ( Name ) ;


			if  ( Item  !=  null )
			   {
				Item. Running	=  false ;
				return ( Item ) ;
			    }

			throw new ArgumentException ( "Measurement counter \"" + Name + "\" does not exist." ) ;
		    }


		/// <summary>
		/// Set all counters to the running state.
		/// </summary>
		public void  StartAll ( )
		   {
			foreach ( MeasurementCounter  Item  in  p_Counters )
				Item. Running	=  true ;
		    }


		/// <summary>
		/// Sets all counters to the stopped state.
		/// </summary>
		public void  StopAll ( )
		   {
			foreach  ( MeasurementCounter  Item  in  p_Counters )
				Item. Running	=  false ;
		    }


		/// <summary>
		/// Gets the list of currently defined counters.
		/// </summary>
		/// <param name="Selection">Counter selection : All, Started or Stopped.</param>
		/// <returns>A list of MeasurementCounter objects corresponding to the selection.</returns>
		public List<MeasurementCounter>  GetCounters ( MeasurementCounterSelection  Selection	=  MeasurementCounterSelection. Started ) 
		   {
			if  ( Selection  ==  MeasurementCounterSelection. All )
				return ( p_Counters ) ;

			List<MeasurementCounter>	Selected	=  new List<MeasurementCounter> ( ) ;

			foreach ( MeasurementCounter  Item  in  p_Counters )
			   {
				if  ( (   Item. Running   &&  Selection  ==  MeasurementCounterSelection. Started ) ||
				      ( ! Item. Running   &&  Selection  ==  MeasurementCounterSelection. Stopped ) )
					Selected. Add ( Item ) ;
			     }

			return ( Selected ) ;
		    }


		/// <summary>
		/// A quick way to show the currently defined counter values.
		/// </summary>
		/// <param name="Selection">Selects running or stopped counters, or all.</param>
		/// <param name="Granularity">Specifies the granularity of the counter values to be displayed 
		/// (milliseconds, seconds, minutes, etc.)</param>
		public  void ShowMessageBox  ( MeasurementCounterSelection    Selection		=  MeasurementCounterSelection. All,
					       MeasurementCounterGranularity  Granularity	=  MeasurementCounterGranularity. Milliseconds )
		   {
			List<MeasurementCounter>	Items		=  GetCounters ( Selection ) ;
			String				Message ;


			if  (  Items. Count  ==  0 )
				Message = "No counter defined." ;
			else
			   {
				Message = "Counter status :" ;

				foreach  ( MeasurementCounter  Item  in  Items )
				   {
					Message +=	"\n" + String. Format ( "{0,-32} : ", Item. Name ) ;

					switch ( Granularity )
					   {
						case  MeasurementCounterGranularity. Days :
							Message += Item. Elapsed. TotalDays + "d" ;
							break ;

						case  MeasurementCounterGranularity. Hours :
							Message += Item. Elapsed. TotalHours + "h" ;
							break ;

						case  MeasurementCounterGranularity. Minutes :
							Message += Item. Elapsed. TotalMinutes + "mn" ;
							break ;

						case  MeasurementCounterGranularity. Seconds :
							Message += Item. Elapsed. TotalSeconds + "s" ;
							break ;

						case  MeasurementCounterGranularity. Milliseconds :
							Message += Item. Elapsed. TotalMilliseconds + "ms" ;
							break ;

						case  MeasurementCounterGranularity. Ticks :
							Message += Item. Elapsed. Ticks ;
							break ;
					    }

					if  ( Item. Running )
						Message += " (R)" ;
					else
						Message += " (S)" ;
				    }
			    }

			MessageBox. Show ( Message, "Counters", MessageBoxButtons. OK ) ;
		    }
		# endregion


		# region List-mimicking functions
		/// <summary>
		/// Clears the current counters list.
		/// </summary>
		public void  Clear ( )
		   {
			p_Counters	=  new List<MeasurementCounter> ( ) ;
		    }


		/// <summary>
		/// Returns the number of counters currently defined.
		/// </summary>
		public int  Count 
		   {
			get { return ( p_Counters. Count ) ; }
		    }


		/// <summary>
		/// Returns a MeasurementCounter object having the specified index in the list.
		/// Throws an exception if the index is out of range.
		/// </summary>
		/// <param name="Index">Index of the MeasurementCounter object to be retrieved.</param>
		/// <returns>The MeasurementCounter object having the specified index.</returns>
		public MeasurementCounter  this [ int  Index ]
		   {
			get
			   {
				MeasurementCounter	Item	=  GetCounter ( Index ) ;
				
				if  ( Item  !=  null )
					return ( Item ) ;
								
				throw new ArgumentOutOfRangeException ( "Index" ) ;
			    }
		    }


		/// <summary>
		/// Returns a MeasurementCounter object having the specified name in the list.
		/// Throws an exception if no object exists with that name.
		/// </summary>
		/// <param name="Name">Name of the MeasurementCounter object to be retrieved.</param>
		/// <returns>The MeasurementCounter object having the specified name.</returns>
		public MeasurementCounter  this [ String  Name ]
		   {
			get
			   {
				MeasurementCounter	Item	=  GetCounter ( Name ) ;

				if  ( Item  !=  null )
					return ( Item ) ;

				throw new ArgumentOutOfRangeException ( "Name" ) ;
			    }
		    }


		/// <summary>
		/// Allows for the use of the foreach() construct on this class.
		/// </summary>
		/// <returns>The enumerator object of the underlying list of MeasurementCounter objects.</returns>
		IEnumerator IEnumerable. GetEnumerator ( )
		   { return ( p_Counters. GetEnumerator ( ) ) ; }
		# endregion


		# region Support methods
		/// <summary>
		/// Returns the MeasurementCounter object having the specified index, or null if index is out of range.
		/// </summary>
		private MeasurementCounter  GetCounter ( int  Index )
		   {
			if  ( Index  >=  0  &&  Index  <  p_Counters. Count )
				return ( p_Counters [ Index ] ) ;
			else
				return ( null ) ;
		    }


		/// <summary>
		/// Returns the MeasurementCounter object having the specified name, or null if no counter having this name exists.
		/// </summary>
		private MeasurementCounter  GetCounter ( String  Name )
		   {
			foreach  ( MeasurementCounter  Item  in  p_Counters )
			   {
				if  ( String. Compare ( Name, Item. Name, true )  ==  0 )
					return ( Item ) ;
			    }

			return ( null ) ;
		    }
		# endregion
	   }
	# endregion
    }