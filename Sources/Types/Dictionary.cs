/**************************************************************************************************************

    NAME
        Dictionary.cs

    DESCRIPTION
        Extension functions for Dictionary objects.

    AUTHOR
        Christian Vigh, 01/2016.

    HISTORY
    [Version : 1.0]    [Date : 2016/01/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Text ;

namespace Thrak. Types
   {
	public static class DictionaryExtensions
	   {
		/// <summary>
		/// Returns a dictionary entry value WITHOUT throwing an exception.
		/// </summary>
		/// <typeparam name="KT">Dictionary key type</typeparam>
		/// <typeparam name="VT">Dictionary value type</typeparam>
		/// <param name="key">Key value to be retrieved</param>
		/// <param name="default_value">Default value if the specified key does not exist</param>
		/// <returns>The desired key value</returns>
		public static VT  GetValue<KT,VT>  ( this Dictionary<KT,VT>  dict, KT  key, VT  default_value = default ( VT ) )
		   {
			VT	result ;

			if  ( dict. TryGetValue ( key, out  result ) )
				return ( result ) ;
			else
				return ( default_value ) ;
		    }
	    }
    }
