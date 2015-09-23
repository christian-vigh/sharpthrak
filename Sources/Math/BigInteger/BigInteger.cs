/**************************************************************************************************************

    NAME
        BigInteger.cs

    DESCRIPTION
        Implementation of arbitrary-size integers.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/19]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;



namespace Thrak
   {
	public static partial class  Math
	   {
		/// <summary>
		/// Implements arbitrary-size big integers.
		/// </summary>
		public partial class BigInteger
		   {
			public readonly sbyte			Sign ;
			public readonly UInt32 []		Data ;
		    }
	    }
    }
