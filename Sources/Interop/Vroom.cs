/**************************************************************************************************************

    NAME
        Vroom.cs

    DESCRIPTION
        Interface to the Vroom dll.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/04]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Runtime. InteropServices ;


namespace Thrak. Interop
   {
	public class	Vroom
	   {
		/// <summary>
		/// Name of the Vroom library.
		/// </summary>
		public const string	VROOM		=  "Vroom.DLL" ;
		

		# region fastmath.h

		# region vroom_math_ipow2ge()
		/// <summary>
		/// Computes the next power of two greater than or equal to the specified value.
		/// </summary>
		/// <param name="value">Value whose next power of two is to be compute.</param>
		/// <returns>
		/// The return value is the next power of two greater than or equal to <paramref name="value"/>.
		/// <para>
		/// If <paramref name="value"/> is zero, the return value will be one.
		/// </para>
		/// <para>
		/// If <paramref name="value"/> is 0x80000000 or greater, the return value will be zero.
		/// </para>
		/// </returns>
		[DllImport ( VROOM, CallingConvention = CallingConvention. FastCall )]
		public static extern uint	vroom_math_ipow2ge ( uint   value ) ;
		# endregion

		# region vroom_math_ipow2gt()
		/// <summary>
		/// Computes the next power of two strictly greater than the specified value.
		/// </summary>
		/// <param name="value">Value whose next power of two is to be compute.</param>
		/// <returns>
		/// The return value is the next power of two strictly greater than <paramref name="value"/>.
		/// <para>
		/// If <paramref name="value"/> is zero, the return value will be one.
		/// </para>
		/// <para>
		/// If <paramref name="value"/> is 0x80000000 or greater, the return value will be zero.
		/// </para>
		/// </returns>
		[DllImport ( VROOM, CallingConvention = CallingConvention. FastCall )]
		public static extern uint	vroom_math_ipow2gt ( uint   value ) ;
		# endregion

		# region vroom_math_ipow2ceiling()
		/// <summary>
		/// Computes the ceiling of the specified value, up to <paramref name="power"/>, which must be a power of two.
		/// <para>If <paramref name="value"/> modulo <paramref name="power"/> is zero, no rounding occurs.</para>
		/// </summary>
		/// <param name="value">Value to be rounded.</param>
		/// <param name="power">Power of two used for rounding. Must be greater than the specified value.</param>
		/// <returns>The rounded value.</returns>
		[DllImport ( VROOM, CallingConvention = CallingConvention. FastCall )]
		public static extern uint	vroom_math_ipow2ceiling ( uint   value, uint  power ) ;
		# endregion

		# endregion


		# region memcpy.h

		# region vroom_memcpy()
		/// <summary>
		/// Copies memory.
		/// </summary>
		/// <param name="dst">Destination buffer.</param>
		/// <param name="src">Source buffer.</param>
		/// <param name="size">Number of bytes to copy.</param>
		/// <returns>
		/// A pointer to <paramref name="dst"/>.
		/// </returns>
		/// <remarks>
		/// This function calls the C intrinsic memcpy() function.
		/// </remarks>
		[DllImport ( VROOM, CallingConvention = CallingConvention. FastCall )]
		public static extern IntPtr	vroom_memcpy ( IntPtr  dst, IntPtr  src, uint  size ) ;
		# endregion

		# region vroom_stdmemcpy()
		/// <summary>
		/// Copies memory.
		/// </summary>
		/// <param name="dst">Destination buffer.</param>
		/// <param name="src">Source buffer.</param>
		/// <param name="size">Number of bytes to copy.</param>
		/// <returns>
		/// A pointer to <paramref name="dst"/>.
		/// </returns>
		/// <remarks>
		/// This function calls the C intrinsic memcpy() function.
		/// </remarks>
		[DllImport ( VROOM, CallingConvention = CallingConvention. FastCall )]
		public static extern IntPtr	vroom_stdmemcpy ( IntPtr  dst, IntPtr  src, uint  size ) ;
		# endregion

		# endregion
	    }
    }
