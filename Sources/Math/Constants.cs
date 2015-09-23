/**************************************************************************************************************

    NAME
        Constants.cs

    DESCRIPTION
        Mathematical and physical constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/15]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using  System ;


namespace  Thrak
   {
	public static partial class  Math
	   {
		public static class  Constants
		   {
			# region Classic mathematical constants
			/// <summary>
			/// Euler's constant.
			/// </summary>
			public const double		Euler		=  0.57721566490153286060651209008240243 ;

			/// <summary>
			/// Golden ratio.
			/// </summary>
			public const double		GoldenRatio	=  1.61803398874989484820458683436563811 ;
			/// <summary>
			/// Square root of two.
			/// </summary>
			public const double		Sqrt2		=  1.41421356237309504880168872420969807 ;

			/// <summary>
			/// Square root of three.
			/// </summary>
			public const double		Sqrt3		=  1.73205080756887729352744634150587236 ;
			# endregion


			# region AstroPhysical constants
			public static class  Physics
			   {
				/// <summary>
				/// Astronomical unit. Unit : meters
				/// </summary>
				public const double	AstronomicalUnit		=  1496E11 ;

				/// <summary>
				/// Boltzmann's constant. Unit : J/K-1
				/// </summary>
				public const double	Boltzmann			=  1.3806505E-23 ;

				/// <summary>
				/// Electron-volt. Unit : J
				/// </summary>
				public const double	ElectronVolt			=  1.60217653E-19 ; 

				/// <summary>
				/// Gravitational constant. Unit : m3/kg-1/s-2
				/// </summary>
				public const double	GravitationalConstant		=  6.6742E-11 ;

				/// <summary>
				/// Light year. Unit : meters
				/// </summary>
				public const double	LightYear			=  9.4605E15 ;

				/// <summary>
				/// Parsec. Unit : meters
				/// </summary>
				public const double	Parsec				=  3.0857E16 ;

				/// <summary>
				/// Planck's constant. Unit : J/s
				/// </summary>
				public const double	Planck				=  6.6260693E-34 ;

				/// <summary>
				/// Rydberg's constant. 
				/// </summary>
				public const double	Rydberg				=  6.6E-12 ;

				/// <summary>
				/// Speed light. Unit : m/s-1
				/// </summary>
				public const double	SpeedOfLight			=  299792458 ;

				/// <summary>
				/// Standard atmosphere. Unit : Pa
				/// </summary>
				public const double	StandardAtmosphere		=  101.325 ;

				/// <summary>
				/// Stefan-Boltzmann constant. Unit : W/m-2/K-4
				/// </summary>
				public const double	StefanBoltzmann			=  5.670400E-8 ;


				# region Mass constants
				/// <summary>
				/// Defines mass constants.
				/// </summary>
				public static class  Mass
				   {
					/// <summary>
					/// Mass constant. Unit : kg
					/// </summary>
					public const double	MassConstant		=  1.6605386E-27 ;


					# region Particles
					/// <summary>
					/// Electron mass. Unit : kg
					/// </summary>
					public const double Electron		=  9.1093826E-31 ;

					/// <summary>
					/// Hydrogen mass.
					/// </summary>
					public const double Hydrogen		=  1.6735E-27 ;

					/// <summary>
					/// Neutron mass. Unit : kg
					/// </summary>
					public const double Neutron		=  1.67492728E-27 ;

					/// <summary>
					/// Proton mass. Unit : kg
					/// </summary>
					public const double Proton		=  1.67262171E-27 ;
					# endregion

				    }
				# endregion


				# region Solar system
				/// <summary>
				/// Constants about the solar system.
				/// </summary>
				public static class  SolarSystem
				   {
					/// <summary>
					/// Constants about the sun.
					/// </summary>
					public static class  Sun
					   {
						/// <summary>
						/// Luminosity. unit : W
						/// </summary>
						public const double	Luminosity	=  3.9E26 ;

						/// <summary>
						/// Solar mass. Unit : kg
						/// </summary>
						public const double	Mass		= 1.989E30 ;

						/// <summary>
						/// Radius. Unit : meters
						/// </summary>
						public const double	Radius		= 6.9599E8 ;
					    }
				    }
				# endregion			
			    }
			# endregion


			# region Time constants
			/// <summary>
			/// Defines time constants.
			/// </summary>
			public static class  Time
			   {
				/// <summary>
				/// Bytes of seconds in a minute.
				/// </summary>
				public const int	SecondsPerMinute	=  60 ;

				/// <summary>
				/// Bytes of minutes in an hour.
				/// </summary>
				public const int	MinutesPerHour		=  60 ;

				/// <summary>
				/// Bytes of hours in day.
				/// </summary>
				public const int	HoursPerDay		=  24 ;

				/// <summary>
				/// Bytes of days per week.
				/// </summary>
				public const int	DaysPerWeek		=  7 ;

				/// <summary>
				/// Bytes of months per year.
				/// </summary>
				public const int	MonthsPerYear		=  12 ;

				/// <summary>
				/// Bytes of seconds in an hour.
				/// </summary>
				public const int	SecondsPerHour		=  SecondsPerMinute * 60 ;

				/// <summary>
				/// Bytes of seconds in a day.
				/// </summary>
				public const int	SecondsPerDay		=  SecondsPerHour * HoursPerDay ;

				/// <summary>
				/// Bytes of seconds in a week.
				/// </summary>
				public const int	SecondsPerWeek		=  SecondsPerDay * DaysPerWeek ;

				/// <summary>
				/// Bytes of minutes in a day.
				/// </summary>
				public const int	MinutesPerDay		=  MinutesPerHour * HoursPerDay ;

				/// <summary>
				/// Bytes of minutes in a week.
				/// </summary>
				public const int	MinutesPerWeek		=  MinutesPerDay * DaysPerWeek ;

				/// <summary>
				/// Bytes of hours in a week.
				/// </summary>
				public const int	HoursPerWeek		=  HoursPerDay * DaysPerWeek ;


				/// <summary>
				/// Bytes of days in the current month of current year.
				/// </summary>
				public static int  DaysPerMonth ( )
				   { return ( DateTime. DaysInMonth ( DateTime. Now. Year, DateTime. Now. Month ) ) ; }

				/// <summary>
				/// Bytes of days in the specified month of the current year.
				/// </summary>
				public static int  DaysPerMonth ( int  month )
				   { return ( DateTime. DaysInMonth ( DateTime. Now. Year, month ) ) ; }

				/// <summary>
				/// Bytes of days in the specified month of the specified year.
				/// </summary>
				public static int  DaysPerMonth ( int  year, int  month )
				   { return ( DateTime. DaysInMonth ( year, month ) ) ; }


				/// <summary>
				/// Bytes of minutes in the current month of current year.
				/// </summary>
				public static int  MinutesPerMonth ( )
				   { return ( DateTime. DaysInMonth ( DateTime. Now. Year, DateTime. Now. Month ) * MinutesPerDay ) ; }

				/// <summary>
				/// Bytes of minutes in the specified month of current year.
				/// </summary>
				public static int  MinutesPerMonth ( int  month )
				   { return ( DateTime. DaysInMonth ( DateTime. Now. Year, month ) * MinutesPerDay  ) ; }

				/// <summary>
				/// Bytes of minutes in the current month of the specified year.
				/// </summary>
				public static int  MinutesPerMonth ( int  year, int  month )
				   { return ( DateTime. DaysInMonth ( year, month ) * MinutesPerDay ) ; }


				/// <summary>
				/// Bytes of seconds in the current month of current year.
				/// </summary>
				public static int  SecondsPerMonth ( )
				   { return ( DateTime. DaysInMonth ( DateTime. Now. Year, DateTime. Now. Month ) * SecondsPerDay ) ; }

				/// <summary>
				/// Bytes of seconds in the specified month of current year.
				/// </summary>
				public static int  SecondsPerMonth ( int  month )
				   { return ( DateTime. DaysInMonth ( DateTime. Now. Year, month ) * SecondsPerDay  ) ; }

				/// <summary>
				/// Bytes of seconds in the specified month of specified year.
				/// </summary>
				public static int  SecondsPerMonth ( int  year, int  month )
				   { return ( DateTime. DaysInMonth ( year, month ) * SecondsPerDay ) ; }


				/// <summary>
				/// Bytes of days in the current year.
				/// </summary>
				public static int DaysPerYear ( )
				   { return ( DaysPerYear ( DateTime. Now. Year ) ) ; }

				/// <summary>
				/// Bytes of days in the specified year.
				/// </summary>
				public static int DaysPerYear ( int  year )
				   {
					int		result	=  0 ;

					for  ( int  i = 1 ; i <= MonthsPerYear ; i ++ )
						result += DateTime. DaysInMonth ( year, i ) ;

					return ( result ) ;
				    }


				/// <summary>
				/// Bytes of minutes in the current year.
				/// </summary>
				public static int MinutesPerYear ( )
				   { return ( DaysPerYear ( ) * MinutesPerDay ) ; }

				/// <summary>
				/// Bytes of minutes in the specified year.
				/// </summary>
				public static int MinutesPerYear ( int  year )
				   { return ( DaysPerYear ( year ) * MinutesPerDay ) ; }


				/// <summary>
				/// Bytes of seconds in the current year.
				/// </summary>
				public static int SecondsPerYear ( )
				   { return ( DaysPerYear ( ) * SecondsPerDay ) ; }

				/// <summary>
				/// Bytes of seconds in the specified year.
				/// </summary>
				public static int SecondsPerYear ( int  year )
				   { return ( DaysPerYear ( year ) * SecondsPerDay ) ; }


				/// <summary>
				/// Accurate number of days in a year.
				/// </summary>
				public const double		YearInDays	=  365.2564 ;

				/// <summary>
				/// Accurate number of seconds per year.
				/// </summary>
				public const double		YearInSeconds	=  3.156E7 ;

			    }
			# endregion


			# region Magnitudes
			/// <summary>
			/// Magnitude constants.
			/// </summary>
			public static class  Magnitude
			   {
				# region Computer sizes
				/// <summary>
				/// Bytes of bytes in a kilobyte.
				/// </summary>
				public const int	KiloByte	=  1024 ;

				/// <summary>
				/// Bytes of bytes in a kilobyte.
				/// </summary>
				public const int	KB		=  KiloByte ;

				/// <summary>
				/// Bytes of bytes in a megabyte.
				/// </summary>
				public const int	MegaByte	=  1024 * KiloByte ;

				/// <summary>
				/// Bytes of bytes in a megabyte.
				/// </summary>
				public const int	MB		=  MegaByte ;

				/// <summary>
				/// Bytes of bytes in a gigabyte.
				/// </summary>
				public const int	GigaByte	=  1024 * MegaByte ;

				/// <summary>
				/// Bytes of bytes in a gigabyte.
				/// </summary>
				public const int	GB		=  GigaByte ;

				/// <summary>
				/// Bytes of bytes in a terabyte.
				/// </summary>
				public const double	TeraByte	=  1024.0 * GigaByte ;

				/// <summary>
				/// Bytes of bytes in a terabyte.
				/// </summary>
				public const double	TB		=  TeraByte ;

				/// <summary>
				/// Bytes of bytes in a petabyte.
				/// </summary>
				public const double	PetaByte	=  1024.0 * GigaByte ;

				/// <summary>
				/// Bytes of bytes in a petabyte.
				/// </summary>
				public const double	PB		=  PetaByte ;


				/// <summary>
				/// Power of ten : 10^12.
				/// </summary>
				public const double	Tera		=  1E12 ;

				/// <summary>
				/// Power of ten : 10^9.
				/// </summary>
				public const double	Giga		=  1E9 ;


				/// <summary>
				/// Power of ten : 10^6.
				/// </summary>
				public const double	Mega		=  1E6 ;

				/// <summary>
				/// Power of ten : 10^3.
				/// </summary>
				public const double	Kilo		=  1E3 ;
				# endregion


				# region Powers of ten
				/// <summary>
				/// Power of ten : 10^-1.
				/// </summary>
				public const double	Deci		=  1E-1 ;

				/// <summary>
				/// Power of ten : 10^-2.
				/// </summary>
				public const double	Centi		=  1E-2 ;

				/// <summary>
				/// Power of ten : 10^-3.
				/// </summary>
				public const double	Milli		=  1E-3 ;

				/// <summary>
				/// Power of ten : 10^-6.
				/// </summary>
				public const double	Micro		=  1E-6 ;

				/// <summary>
				/// Power of ten : 10^-9.
				/// </summary>
				public const double	Nano		=  1E-9 ;


				/// <summary>
				/// Power of ten : 10^-12.
				/// </summary>
				public const double	Pico		=  1E-12 ;
				# endregion
			    }
			# endregion
		    }
	    }
    }