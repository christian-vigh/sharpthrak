/**************************************************************************************************************

    NAME
        Math.cs

    DESCRIPTION
        Math functions.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/15]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using  System ;
using  System. Collections ;
using  System. Collections. Generic ;


namespace  Thrak
   {
	public static partial class  Math
	   {
		# region Generic functions (min, max, etc.)
		/// <summary>
		/// Min() function using generics. 
		/// </summary>
		/// <typeparam name="T">Data type.</typeparam>
		/// <param name="Values">Array or list of values whose minimum is to be searched.</param>
		/// <returns>The min value within the specified set of values.</returns>
		/// <remarks>It is not necessary to provide a strongly-typed Min() function. The performance of a
		/// "long Min()" functions are similar to those of "Min<long> ()". On 10M iterations, the generic
		/// version even takes a few hundred ms less./></remarks>
		public static T  Min<T>  ( params T []  Values )
					where  T : IComparable
		   {
			if  ( Values  ==  null  ||  Values. Length  ==  0 )
				throw  new  ArgumentNullException ( "Values" ) ;

			T		Result		=  Values [0] ;
			
			for ( int  i = 1 ; i  <  Values. Length	; i ++ )
			   {
				if  ( Result. CompareTo ( Values [i] )  >  0 )
					Result = Values [i] ;
			    }

			return ( Result ) ;
		    }


		/// <summary>
		/// Max() function using generics. 
		/// </summary>
		/// <typeparam name="T">Data type.</typeparam>
		/// <param name="Values">Array or list of values whose maximum is to be searched.</param>
		/// <returns>The max value within the specified set of values.</returns>
		public static T  Max<T>  ( params T []  Values )
					where  T : IComparable
		   {
			if  ( Values  ==  null  ||  Values. Length  ==  0 )
				throw  new  ArgumentNullException ( "Values" ) ;

			T		Result		=  Values [0] ;
			
			for ( int  i = 1 ; i  <  Values. Length	; i ++ )
			   {
				if  ( Result. CompareTo ( Values [i] )  <  0 )
					Result = Values [i] ;
			    }

			return ( Result ) ;
		    }


		/// <summary>
		/// Structure returned by the MinMax function.
		/// </summary>
		/// <typeparam name="T">Underlying data type.</typeparam>
		public struct MINMAX<T>		
		   {
			public T	Min ;
			public T	Max ;


			public override string ToString ( )
			   {
				return ( "Min = " + Min + ", Max = " + Max ) ;
			    }
		    }


		/// <summary>
		/// Max() function using generics. 
		/// </summary>
		/// <typeparam name="T">Data type.</typeparam>
		/// <param name="Values">Array or list of values whose maximum is to be searched.</param>
		/// <returns>The max value within the specified set of values.</returns>
		public static MINMAX<T>  MinMax<T>  ( params T []  Values )
						where  T : IComparable
		   {
			if  ( Values  ==  null  ||  Values. Length  ==  0 )
				throw  new  ArgumentNullException ( "Values" ) ;

			MINMAX<T>		Result ;

			Result. Min	=  Values [0] ;
			Result. Max	=  Values [0] ;
			
			for ( int  i = 1 ; i  <  Values. Length	; i ++ )
			   {
				if  ( Result. Min. CompareTo ( Values [i] )  >  0 )
					Result. Min = Values [i] ;

				if  ( Result. Max. CompareTo ( Values [i] )  <  0 )
					Result. Max = Values [i] ;
			    }

			return ( Result ) ;
		    }
		# endregion


		# region Factorial, combinations and permutations
	
		# region Table for the first factorials
		private static double []  	FactorialValues  = new double []
		   {
			/* 0!  */ 1D,
			/* 1!  */ 1D,
			/* 2!  */ 2D,
			/* 3!  */ 6D,
			/* 4!  */ 24D,
			/* 5!  */ 120D,
			/* 6!  */ 720D,
			/* 7!  */ 5040D,
			/* 8!  */ 40320D,
			/* 9!  */ 362880D,
			/* 10! */ 3628800D,
			/* 11! */ 39916800D,
			/* 12! */ 479001600D,
			/* 13! */ 6227020800D,
			/* 14! */ 87178291200D,
			/* 15! */ 1307674368000D,
			/* 16! */ 20922789888000D,
			/* 17! */ 355687428096000D,
			/* 18! */ 6402373705728000D,
			/* 19! */ 121645100408832000D,
			/* 20! */ 2432902008176640000D,
			/* 21! */ 51090942171709440000D,
			/* 22! */ 1124000727777607680000D,
			/* 23! */ 25852016738884976640000D,
			/* 24! */ 620448401733239439360000D,
			/* 25! */ 15511210043330985984000000D,
			/* 26! */ 403291461126605635584000000D,
			/* 27! */ 10888869450418352160768000000D,
			/* 28! */ 304888344611713860501504000000D,
			/* 29! */ 8841761993739701954543616000000D,
			/* 30! */ 265252859812191058636308480000000D,
			/* 31! */ 8222838654177922817725562880000000D,
			/* 32! */ 263130836933693530167218012160000000D,
			/* 33! */ 8683317618811886495518194401280000000D,
			/* 34! */ 295232799039604140847618609643520000000D,
			/* 35! */ 10333147966386144929666651337523200000000D,
			/* 36! */ 371993326789901217467999448150835200000000D,
			/* 37! */ 13763753091226345046315979581580902400000000D,
			/* 38! */ 523022617466601111760007224100074291200000000D,
			/* 39! */ 20397882081197443358640281739902897356800000000D,
			/* 40! */ 815915283247897734345611269596115894272000000000D,
			/* 41! */ 33452526613163807108170062053440751665152000000000D,
			/* 42! */ 1405006117752879898543142606244511569936384000000000D,
			/* 43! */ 60415263063373835637355132068513997507264512000000000D,
			/* 44! */ 2658271574788448768043625811014615890319638528000000000D,
			/* 45! */ 119622220865480194561963161495657715064383733760000000000D,
			/* 46! */ 5502622159812088949850305428800254892961651752960000000000D,
			/* 47! */ 258623241511168180642964355153611979969197632389120000000000D,
			/* 48! */ 12413915592536072670862289047373375038521486354677760000000000D,
			/* 49! */ 608281864034267560872252163321295376887552831379210240000000000D,
			/* 50! */ 30414093201713378043612608166064768844377641568960512000000000000D,
			/* 51! */ 1551118753287382280224243016469303211063259720016986112000000000000D,
			/* 52! */ 80658175170943878571660636856403766975289505440883277824000000000000D,
			/* 53! */ 4274883284060025564298013753389399649690343788366813724672000000000000D,
			/* 54! */ 230843697339241380472092742683027581083278564571807941132288000000000000D,
			/* 55! */ 12696403353658275925965100847566516959580321051449436762275840000000000000D,
			/* 56! */ 710998587804863451854045647463724949736497978881168458687447040000000000000D,
			/* 57! */ 40526919504877216755680601905432322134980384796226602145184481280000000000000D,
			/* 58! */ 2350561331282878571829474910515074683828862318181142924420699914240000000000000D,
			/* 59! */ 138683118545689835737939019720389406345902876772687432540821294940160000000000000D,
			/* 60! */ 8320987112741390144276341183223364380754172606361245952449277696409600000000000000D,
			/* 61! */ 507580213877224798800856812176625227226004528988036003099405939480985600000000000000D,
			/* 62! */ 31469973260387937525653122354950764088012280797258232192163168247821107200000000000000D,
			/* 63! */ 1982608315404440064116146708361898137544773690227268628106279599612729753600000000000000D,
			/* 64! */ 126886932185884164103433389335161480802865516174545192198801894375214704230400000000000000D,
			/* 65! */ 8247650592082470666723170306785496252186258551345437492922123134388955774976000000000000000D,
			/* 66! */ 544344939077443064003729240247842752644293064388798874532860126869671081148416000000000000000D,
			/* 67! */ 36471110918188685288249859096605464427167635314049524593701628500267962436943872000000000000000D,
			/* 68! */ 2480035542436830599600990418569171581047399201355367672371710738018221445712183296000000000000000D,
			/* 69! */ 171122452428141311372468338881272839092270544893520369393648040923257279754140647424000000000000000D,
			/* 70! */ 11978571669969891796072783721689098736458938142546425857555362864628009582789845319680000000000000000D,
			/* 71! */ 850478588567862317521167644239926010288584608120796235886430763388588680378079017697280000000000000000D,
			/* 72! */ 61234458376886086861524070385274672740778091784697328983823014963978384987221689274204160000000000000000D,
			/* 73! */ 4470115461512684340891257138125051110076800700282905015819080092370422104067183317016903680000000000000000D,
			/* 74! */ 330788544151938641225953028221253782145683251820934971170611926835411235700971565459250872320000000000000000D,
			/* 75! */ 24809140811395398091946477116594033660926243886570122837795894512655842677572867409443815424000000000000000000D,
			/* 76! */ 1885494701666050254987932260861146558230394535379329335672487982961844043495537923117729972224000000000000000000D,
			/* 77! */ 145183092028285869634070784086308284983740379224208358846781574688061991349156420080065207861248000000000000000000D,
			/* 78! */ 11324281178206297831457521158732046228731749579488251990048962825668835325234200766245086213177344000000000000000000D,
			/* 79! */ 894618213078297528685144171539831652069808216779571907213868063227837990693501860533361810841010176000000000000000000D,
			/* 80! */ 71569457046263802294811533723186532165584657342365752577109445058227039255480148842668944867280814080000000000000000000D,
			/* 81! */ 5797126020747367985879734231578109105412357244731625958745865049716390179693892056256184534249745940480000000000000000000D,
			/* 82! */ 475364333701284174842138206989404946643813294067993328617160934076743994734899148613007131808479167119360000000000000000000D,
			/* 83! */ 39455239697206586511897471180120610571436503407643446275224357528369751562996629334879591940103770870906880000000000000000000D,
			/* 84! */ 3314240134565353266999387579130131288000666286242049487118846032383059131291716864129885722968716753156177920000000000000000000D,
			/* 85! */ 281710411438055027694947944226061159480056634330574206405101912752560026159795933451040286452340924018275123200000000000000000000D,
			/* 86! */ 24227095383672732381765523203441259715284870552429381750838764496720162249742450276789464634901319465571660595200000000000000000000D,
			/* 87! */ 2107757298379527717213600518699389595229783738061356212322972511214654115727593174080683423236414793504734471782400000000000000000000D,
			/* 88! */ 185482642257398439114796845645546284380220968949399346684421580986889562184028199319100141244804501828416633516851200000000000000000000D,
			/* 89! */ 16507955160908461081216919262453619309839666236496541854913520707833171034378509739399912570787600662729080382999756800000000000000000000D,
			/* 90! */ 1485715964481761497309522733620825737885569961284688766942216863704985393094065876545992131370884059645617234469978112000000000000000000000D,
			/* 91! */ 135200152767840296255166568759495142147586866476906677791741734597153670771559994765685283954750449427751168336768008192000000000000000000000D,
			/* 92! */ 12438414054641307255475324325873553077577991715875414356840239582938137710983519518443046123837041347353107486982656753664000000000000000000000D,
			/* 93! */ 1156772507081641574759205162306240436214753229576413535186142281213246807121467315215203289516844845303838996289387078090752000000000000000000000D,
			/* 94! */ 108736615665674308027365285256786601004186803580182872307497374434045199869417927630229109214583415458560865651202385340530688000000000000000000000D,
			/* 95! */ 10329978488239059262599702099394727095397746340117372869212250571234293987594703124871765375385424468563282236864226607350415360000000000000000000000D,
			/* 96! */ 991677934870949689209571401541893801158183648651267795444376054838492222809091499987689476037000748982075094738965754305639874560000000000000000000000D,
			/* 97! */ 96192759682482119853328425949563698712343813919172976158104477319333745612481875498805879175589072651261284189679678167647067832320000000000000000000000D,
			/* 98! */ 9426890448883247745626185743057242473809693764078951663494238777294707070023223798882976159207729119823605850588608460429412647567360000000000000000000000D,
			/* 99! */ 933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000D,
			/* 100! */93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000D
		    } ;
		# endregion


		/// <summary>
		/// Returns the number of combinations of p elements among n.
		/// </summary>
		public static double  Combinations ( int  n, int  p )
		   { return ( Permutations ( n, p ) / Factorial ( p ) ) ; }


		/// <summary>
		/// Computes the factorial of the specified value.
		/// </summary>
		/// <param name="rank">Factorial number.</param>
		/// <returns>The factorial of <paramref name="rank"/>.</returns>
		/// <remarks>This method uses a static table for the factorials from 0 to 100.</remarks>
		public static double  Factorial ( int  rank )
		   {
			// Check that the value is positive
			if  ( rank  <  0 )
				throw new ArgumentException ( Resources. Localization. Classes. Math. XMathNegativeFactorial ) ;

			// Remember the size of the factorial table
			int	length	=  FactorialValues. Length ;

			// If the specified rank is defined in the factorial table, return the factorial value
			if  ( rank  <  length )
				return ( FactorialValues [ rank ] ) ;

			// Otherwise, compute the factorial, starting from the last element of the factorial table
			double		result		=  FactorialValues [ length - 1 ] ;

			// Compute loop
			for  ( int  i = length ; i <= rank ; i ++ )
			   {
				result *= i ;

				// Overflow of a double value : return +INF
				if  ( result  ==  double. PositiveInfinity )
					return ( result ) ;
			    }

			// All done, return the result
			return ( result ) ;
		    }


		/// <summary>
		/// Returns the number of permutations of p elements among n.
		/// </summary>
		public static double  Permutations ( int  n, int  p )
		   { return ( Factorial ( n ) / Factorial ( n - p ) ) ; }


		/// <summary>
		/// Returns an array where the permutation whose number is given by
		/// <paramref name="index"/> has been applied on <paramref name="table"/>.
		/// </summary>
		/// <param name="index">Permutation index.</param>
		/// <param name="table">Table on which the permutation has been applied.</param>
		/// <returns>A new permuted array.</returns>
		public static Array  Permutation ( int  index, Array  table )
		   {
			// Check that the supplied table is correct
			if  ( table  ==  null  ||  table. Length  ==  0 )
				throw new ArgumentNullException ( "table" ) ;

			// Table length
			int	Length		=  table. Length ;
			// Computes the number of permutations
			int	F		=  ( int ) Factorial ( Length - 1 ) ;

			// Check that the supplied index is between 0 and PermutationCount - 1
			if  ( index  <  0  ||  index  >=  ( int ) Factorial ( Length ) )
				throw new ArgumentOutOfRangeException ( "index" ) ;

			// Make a copy of the supplied array
			Array	Result		=  ( Array ) table. Clone ( ) ;

			// If the array only contains one object, then the job is not too complicated
			if  ( Length  ==  1 )
				return ( Result ) ;

			// Perform the permutation
			// (algorithm source : Wikipedia)
			for  ( int  j = 0 ; j  <  Length - 1 ; j ++ )
			   {
				int		temp_j		=  ( index / F ) % ( Length - j ) ;
				object		temp_obj	=  Result. GetValue ( j + temp_j ) ;

				for  ( int  i = j + temp_j ; i  >  j ; i -- )
					Result. SetValue ( Result. GetValue ( i - 1 ), i ) ;

				Result. SetValue ( temp_obj, j ) ;

				F = F  / ( Length - 1 - j ) ;
			    }

			// All done, return the result
			return ( Result ) ;
		    }
		# endregion	


		# region Geometric functions expressed in degrees instead of radians
		public const double	RadiansToDegrees = System. Math. PI / 180 ;

		/// <summary>
		/// Returns the angle whose cosinus corresponds to the specified value.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Acos  ( double  v ) { return ( System. Math. Acos  ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the angle whose inus corresponds to the specified value.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Asin  ( double  v ) { return ( System. Math. Asin  ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the angle whose tangent corresponds to the specified value.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Atan  ( double  v ) { return ( System. Math. Atan  ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the angle whose tangent is the quotient of the specified values.
		/// </summary>
		public static double  Atan2 ( double  a, double  b ) { return ( System. Math. Atan2 ( a, b ) ) ; }

		/// <summary>
		/// Returns the cosine of the specified angle.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Cos   ( double  v ) { return ( System. Math. Cos   ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the hyperbolic cosine of the specified angle.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Cosh  ( double  v ) { return ( System. Math. Cosh  ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the sine of the specified angle.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Sin   ( double  v ) { return ( System. Math. Sin   ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the hyperbolic sine of the specified angle.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Sinh  ( double  v ) { return ( System. Math. Sinh  ( v * RadiansToDegrees ) ) ; }

		/// <summary>
		/// Returns the tangent of the specified angle.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Tan   ( double  v ) { return ( System. Math. Tan   ( v * RadiansToDegrees ) ) ; }


		/// <summary>
		/// Returns the hyperbolic tangent of the specified angle.
		/// </summary>
		/// <param name="v">Angle, expressed in degrees.</param>
		public static double  Tanh  ( double  v ) { return ( System. Math. Tanh  ( v * RadiansToDegrees ) ) ; }
		# endregion


		# region Various math functions

		/// <summary>
		/// Gets the greatest common divisor between two numbers.
		/// </summary>
		public static double  Gcd ( double  a, double  b )
		   {
			if  ( b  ==  0 )
				return ( a ) ;

			double		tmp	=  a % b ;

			while  ( tmp  >  0 )
			   {
				a   = b ;
				b   = tmp ;
				tmp = a % b ;
			    }

			return ( b ) ;
		    }


		/// <summary>
		/// Compute the base-2 logarithm of the specified number.
		/// </summary>
		/// <param name="value">Value to compute the logarithm of.</param>
		/// <returns>The base 2 logarithm of <paramref name="value"/>.</returns>
		public static double  Ln ( double  value )
		   { return ( System. Math. Log ( value, 2 ) ) ; }



		/// <summary>
		/// Returns the sum of integers in the range [<paramref name="first"/>..<paramref name="last"/>].
		/// </summary>
		/// <param name="first">Low range value.</param>
		/// <param name="last">High range value.</param>
		public static double  Sigma ( int  last )
		   { return ( ( last * ( last + 1 ) ) / 2 ) ; }


		/// <summary>
		/// Returns the sum of integers in the range [<paramref name="first"/>..<paramref name="last"/>].
		/// </summary>
		/// <param name="first">Low range value.</param>
		/// <param name="last">High range value.</param>
		public static double  Sigma ( int  first, int  last )
		   {
			// Check that the supplied range is correct.
			if  ( first  >  last )
				throw new ArgumentException ( Resources. Localization. Classes. Math. XMathSumError ) ;

			// If the lower value of the range is strictly positive, then there is a simple formula for sigma
			if  ( first  >  0 )
				return ( ( ( last - first + 1 ) * ( first + last ) ) / 2 ) ;

			// Otherwise, manually perform the sum.
			int	result		=  0 ;

			for  ( int  i = first ; i < last ; i ++ )
				result += i ;

			return ( result ) ;
		    }
		# endregion

	    }
    }