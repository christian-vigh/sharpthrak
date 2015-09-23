/**************************************************************************************************************

    NAME
        MSVCRT.cs

    DESCRIPTION
        C runtime functions.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/09]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using  System ;
using  System. Runtime. InteropServices ;


namespace Thrak. Interop
   {
	/// <summary>
	/// Wrapper class for C-runtime functions.
	/// </summary>
	public static partial class CRT
	   {
		/// <summary>
		/// C-runtime DLL name.
		/// </summary>
		public const String		MSVCRT		=  "msvcrt.dll" ;


		# region Memory functions
		/// <summary>
		/// Copies memory.
		/// </summary>
		/// <param name="dest">Destination memory area.</param>
		/// <param name="src">Source memory area.</param>
		/// <param name="count">Number of bytes to copy.</param>
		/// <returns>The number of bytes copied.</returns>
		[DllImport ( MSVCRT )]
		public static extern unsafe int		memcpy ( void *  dest, void *  src, int  count ) ;


		/// <summary>
		/// Initializes memory.
		/// </summary>
		/// <param name="dest">Destination area.</param>
		/// <param name="value">Initial value.</param>
		/// <param name="count">Number of bytes to initialize.</param>
		/// <returns>The number of initialized bytes.</returns>
		[DllImport ( MSVCRT )]
		public static extern unsafe int		memset ( void *  dest, int  value, int  count ) ;
		# endregion


		# region String functions
		/// <summary>
		/// Compare strings.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "strcmp" )]
		public static extern unsafe int		strcmp	( char *  a, char *  b ) ;


		/// <summary>
		/// Compare strings. The comparison is case-insensitive.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "_strcmpi" )]
		public static extern unsafe int		stricmp	( char *  a, char *  b ) ;


		/// <summary>
		/// Compare strings.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <param name="count">Number of characters to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT )]
		public static extern unsafe int		strncmp	( char *  a, char *  b, int  count ) ;


		/// <summary>
		/// Compare strings. The comparison is case-insensitive.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <param name="count">Number of characters to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "_strnicmp" )]
		public static extern unsafe int		strnicmp ( char *  a, char *  b, int  count ) ;


		/// <summary>
		/// Compare strings.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "wcscmp" )]
		public static extern unsafe int		wcscmp	( char *  a, char *  b ) ;


		/// <summary>
		/// Compare strings.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <param name="size">Number of characters to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "wcsncmp" )]
		public static extern unsafe int		wcsncmp	( char *  a, char *  b, int  size ) ;


		/// <summary>
		/// Compare strings.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "_wcsicmp" )]
		public static extern unsafe int		wcsicmp	( char *  a, char *  b ) ;


		/// <summary>
		/// Compare strings.
		/// </summary>
		/// <param name="a">First string to compare.</param>
		/// <param name="b">Second string to compare.</param>
		/// <param name="size">Number of characters to compare.</param>
		/// <returns>A zero value if both strings are identical, a negative value
		/// if <paramref name="a"/> is less than <paramref name="b"/>, and a positive
		/// value if <paramref name="b"/> is greater than <paramref name="a"/>.</returns>
		[DllImport ( MSVCRT, EntryPoint = "_wcsnicmp" )]
		public static extern unsafe int		wcsnicmp ( char *  a, char *  b, int  size ) ;
		# endregion
	    }
    }