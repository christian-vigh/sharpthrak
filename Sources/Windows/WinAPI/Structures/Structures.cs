/**************************************************************************************************************

    NAME
        WinAPI/Structures.cs

    DESCRIPTION
        Windows structures.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using   System ;
using	System. Runtime. InteropServices ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// The "Structure" structure contains only one member, "Empty", which is used to initialize Win32 API structures
	/// to zero.
	/// <para>
	/// Each Win32 structure (contained in the Structures subdirectory) has an implicit type conversion operator which
	/// takes a Structure value (Structure.Empty) and creates the corresponding Win32 structure with all fields initialized
	/// to a default value.
	/// </para>
	/// <br/>
	/// <para>
	/// For example :
	/// </para>
	/// <code>
	///	ACCESS		a	=  Structure.Empty ;
	/// </code>
	/// </summary>
	//  Disable the fucking warning that state that the __Empty field is declared but not used.
	# pragma warning disable  0649
	public struct  Structure
	   {
		// Singleton object
		private static Structure	__Empty ;
		

		/// <summary>
		/// Initializes a Win32 structure with all fields set to their default value.
		/// </summary>
		public static Structure  Empty
		   {
			get { return ( __Empty ) ; }
		    }


		/// <summary>
		/// Converts a structure to an array of bytes.
		/// </summary>
		/// <typeparam name="T">The type of the structure.</typeparam>
		/// <param name="value">The structure itself.</param>
		/// <returns>The input structure, converted to a byte array.</returns>
		public static byte[]  ToByteArray<T> ( T  value )
		   {
			int		size		=  Marshal. SizeOf ( value ) ;     
			byte[]		array		=  new byte [ size ] ;     
			IntPtr		ptr		=  Marshal. AllocHGlobal ( size ) ;      
			
			Marshal. StructureToPtr ( value, ptr, true ) ;     
			Marshal. Copy ( ptr, array, 0, size ) ;     
			Marshal. FreeHGlobal ( ptr ) ;      
			
			return ( array ) ;
		    }


		/// <summary>
		/// Converts an array of bytes to a structure.
		/// </summary>
		/// <typeparam name="T">The type of the structure.</typeparam>
		/// <param name="value">The array of bytes.</param>
		/// <returns>The byte array, converted to the specified structure type.</returns>
		public static T  ToStructure<T>  ( byte[]  array )
					where  T : new ( )
		   {
			T		value		=   new T ( ) ;
			int		size		=   Marshal. SizeOf ( value ) ;     
			IntPtr		ptr		=   Marshal. AllocHGlobal ( size ) ;      
			
			Marshal. Copy ( array, 0, ptr, size ) ;      
			value	=  (T) Marshal. PtrToStructure ( ptr, value. GetType ( ) ) ;     
			Marshal. FreeHGlobal ( ptr ) ;
			
			return ( value ) ;
		    }
	    }
	# pragma warning restore  0649
    }
