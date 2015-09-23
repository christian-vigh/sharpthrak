/**************************************************************************************************************

    NAME
        WinAPI/Macros.cs

    DESCRIPTION
        Windows macros.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/2]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using   System. Runtime. InteropServices ;


using   Thrak. WinAPI. Enums ;
using   Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI
   {
	# region Macros
	/// <summary>
	/// Implements macros defined in WinUser.h
	/// </summary>
	public static class  Macros
	   {
		/// <summary>
		/// Extracts the RIM_Constants value from the wParam parameter of the WM_INPUT message.
		/// </summary>
		/// <param name="wParam">wParam parameter.</param>
		/// <returns>The RIM_Constants value.</returns>
		public static RIM_Constants   GET_RAWINPUT_CODE_WPARAM ( uint  wParam )
		   {
			return ( ( RIM_Constants ) ( wParam  &  0xFF ) ) ;
		    }


		/// <summary>
		/// Used to initialize the cbSize field of certain Windows structures.
		/// </summary>
		/// <param name="T">Structure type.</param>
		/// <returns>The size of the structure, in bytes.</returns>
		public static UInt32	GETSTRUCTSIZE ( Type  T )
		   { return ( ( UInt32 ) Marshal. SizeOf ( T ) ) ; }

		
		/// <summary>
		/// For WM_MOUSEWHEEL messages, retrieves the key state from wParam.
		/// </summary>
		public static int	GET_KEYSTATE_WPARAM ( uint  wparam )
		   { return ( LOWORD ( wparam ) ) ; }

		
		/// <summary>
		/// Returns the SC_ command from the wParam parameter of a WM_SYSCOMMAND message.
		/// </summary>
		public static int	GET_SC_PARAM ( uint  wparam )
		   { return ( ( int ) ( wparam  &  0xFFF0 ) ) ; }


		/// <summary>
		/// When a screen coordinate is specified as a DWORD (such as the return value from the GetMessagePos() function),
		/// extract the signed short X coordinate.
		/// </summary>
		/// <param name="lparam">DWORD value containing the X & Y coordinates as signed short integer values.</param>
		/// <returns>The X coordinate of the point.</returns>
		public static int  GET_X_LPARAM ( uint  lparam )
		   { return ( ( int ) ( short ) LOWORD ( lparam ) ) ; }


		/// <summary>
		/// When a screen coordinate is specified as a DWORD (such as the return value from the GetMessagePos() function),
		/// extract the signed short Y coordinate.
		/// </summary>
		/// <param name="lparam">DWORD value containing the X & Y coordinates as signed short integer values.</param>
		/// <returns>The Y coordinate of the point.</returns>
		public static int  GET_Y_LPARAM ( uint  lparam )
		   { return ( ( int ) ( short ) HIWORD ( lparam ) ) ; }


		/// <summary>
		/// For WM_MOUSEWHEEL messages, retrieves the wheel delta value from wParam.
		/// </summary>
		public static short  GET_WHEEL_DELTA_WPARAM ( uint  wparam )
		   { return ( ( short ) HIWORD ( wparam ) ) ; }


		/// <summary>
		/// Gets the high-order byte of a value.
		/// </summary>
		public static byte  HIBYTE ( uint  value )
		   { return ( ( byte ) ( ( value >> 8 )  &  0xFF ) ) ; }


		/// <summary>
		/// Gets the high-order word of a value.
		/// </summary>
		public static ushort  HIWORD ( uint  value )
		   { return ( ( ushort ) ( ( value >> 16 )  &  0xFFFF ) ) ; }

		
		/// <summary>
		/// Gets the high-order dword of a value.
		/// </summary>
		public static ushort  HIDWORD ( uint  value )
		   { return ( ( ushort ) ( ( value >> 32 )  &  0xFFFFFFFF ) ) ; }

		
		/// <summary>
		/// Checks if the specified integer value is an integer resource identifier.
		/// </summary>
		/// <param name="value">Value to be checked.</param>
		/// <returns>True if the specified value is an integer resource identifier, false otherwise.</returns>
		public static bool	IS_INTRESOURCE ( int  value )
		   {
			return ( ( value  >>  16 )  ==  0 ) ;
		    }


		/// <summary>
		/// Checks if the specified IntPtr value is an integer resource identifier.
		/// </summary>
		/// <param name="value">Value to be checked.</param>
		/// <returns>True if the specified value is an integer resource identifier, false otherwise.</returns>
		public static bool	IS_INTRESOURCE ( IntPtr  value )
		   { return ( IS_INTRESOURCE ( value. ToInt32 ( ) ) ) ; }


		/// <summary>
		/// Extract the language id from an LCID.
		/// </summary>
		/// <param name="lcid">LCID value.</param>
		/// <returns>The language id stored in the LCID.</returns>
		public static int	LANGIDFROMLCID ( int  lcid )
		   { return ( ( ushort ) ( lcid  &  0xFFFF ) ) ; }


		/// <summary>
		/// Gets the low-order byte of a value.
		/// </summary>
		public static byte  LOBYTE ( uint  value )
		   { return ( ( byte ) ( ( ( uint ) value )  &  0xFF ) ) ; }


		/// <summary>
		/// Gets the high-order word of a value.
		/// </summary>
		public static ushort  LOWORD ( uint  value )
		   { return ( ( ushort ) ( ( ( uint ) value )  &  0xFFFF ) ) ; }


		/// <summary>
		/// Gets the high-order dword of a value.
		/// </summary>
		public static ushort  LODWORD ( uint  value )
		   { return ( ( ushort ) ( ( ( uint ) value )  &  0xFFFFFFFF ) ) ; }


		/// <summary>
		/// Converts a value to an integer resource.
		/// </summary>
		/// <param name="value">Value to be converted.</param>
		/// <returns>An IntPtr value representing the resource id.</returns>
		public static IntPtr	MAKEINTRESOURCE ( int  value )
		   {
			IntPtr		result		=  new IntPtr ( value  &  0xFFFF ) ;

			return ( result ) ;
		     }


		/// <summary>
		/// construct language id from a primary language id and a sublanguage id.
		/// </summary>
		/// <param name="lang">Language id.</param>
		/// <param name="sublang">Sublanguage id.</param>
		/// <returns>The language/sublanguage id pair.</returns>
		public static int  MAKELANGID ( int  lang, int  sublang )
		   {
			return ( ( int ) ( ( ( ushort ) ( sublang  <<  10 ) )  |  ( ( ushort ) lang ) ) ) ;
		    }


		/// <summary>
		/// construct language id from a primary language id and a sublanguage id.
		/// </summary>
		/// <param name="lang">Language id.</param>
		/// <param name="sublang">Sublanguage id.</param>
		/// <returns>The language/sublanguage id pair.</returns>
		public static int  MAKELANGID ( LANG_Constants  lang, SUBLANG_Constants  sublang )
		   {
			return ( ( int ) ( ( ( ushort ) ( ( ( ushort ) sublang )  <<  10 ) )  |  ( ( ushort ) lang ) ) ) ;
		    }


		/// <summary>
		/// construct the locale id from a language id and a sort id.
		/// </summary>
		/// <param name="lgid">Language id.</param>
		/// <param name="sortid">Sort id.</param>
		/// <returns>The corresponding LCID value.</returns>
		public static uint  MAKELCID ( int  lgid, int  sortid )
		   {
			return ( ( uint )
					( ( uint ) ( ( ushort ) sortid )  <<  16 )  |
					( ( uint ) ( ( ushort ) lgid ) ) 
				) ;
		    }


		/// <summary>
		/// Makes a word from two words (low-order word : a, high-order word : b).
		/// </summary>
		public static uint  MAKELONG ( uint  a, uint  b )
		   { return ( ( uint ) ( LOWORD ( a )  | ( LOWORD ( b )  <<  16 ) ) ) ; }


		/// <summary>
		/// Builds an LPARAM value from a low and high WORD.
		/// </summary>
		public static uint  MAKELPARAM ( uint  low, uint  high )
		   { return ( MAKELONG ( low, high ) ) ; }


		/// <summary>
		/// Builds an LRESULT value from a low and high WORD.
		/// </summary>
		public static uint  MAKELRESULT ( uint  low, uint  high )
		   { return ( MAKELONG ( low, high ) ) ; }


		/// <summary>
		/// Converts a DWORD containing x/y coordinates as signed shorts to a POINTS structure.
		/// </summary>
		/// <param name="lparam">DWORD containing the signedd x and y coordinates.</param>
		/// <returns>A POINTS structure containing the screen coordinates.</returns>
		public static POINTS	MAKEPOINTS ( uint  lparam )
		   {
			POINTS			p ;

			p. x		=  ( short ) GET_X_LPARAM ( lparam ) ;
			p. y		=  ( short ) GET_Y_LPARAM ( lparam ) ;

			return ( p ) ;
		    }


		/// <summary>
		/// Construct the locale id from a language id, sort id, and sort version.
		/// </summary>
		/// <param name="lgid">Language id.</param>
		/// <param name="sortid">Sort id.</param>
		/// <param name="version">Sort version.</param>
		/// <returns></returns>
		public static uint  MAKESORTLCID ( int  lgid, int sortid, int  version )
		   {
			return ( ( uint )
					( MAKELCID ( lgid, sortid )  |
					( ( uint ) ( ( ushort ) version )  <<  20 ) )
				) ;
		    }


		/// <summary>
		/// Makes a word from two bytes (low-order byte : a, high-order byte : b).
		/// </summary>
		public static ushort  MAKEWORD ( uint  low, uint  high )
		   { return ( ( ushort ) ( LOBYTE ( low )  | ( LOBYTE ( high )  <<  8 ) ) ) ; }


		/// <summary>
		/// Builds a WPARAM value from two words.
		/// </summary>
		public static uint  MAKEWPARAM ( uint  low, uint  high )
		   { return ( MAKELONG ( low, high ) ) ; }


		/// <summary>
		/// Extract primary language id from a language id.
		/// </summary>
		/// <param name="lgid">Language id, containing the primary and sublanguage ids.</param>
		/// <returns>The language id.</returns>
		public static LANG_Constants  PRIMARYLANGID ( int  lgid )
		    {
			return ( ( LANG_Constants ) ( ( ushort ) ( lgid  &  0x03FFF ) ) ) ;
		      }

		
		/// <summary>
		/// Extracts the sort id from an LCID.
		/// </summary>
		/// <param name="lcid">LCID containing the sort id.</param>
		/// <returns>The sort id.</returns>
		public static ushort  SORTIDFROMLCID ( int  lcid )
		   {
			return ( ( ushort ) ( ( ( ( uint ) lcid ) >>  16 )  &  0x0F ) ) ; 
		    }


		public static ushort  SORTVERSIONFROMLCID ( int  lcid )
		   {
			return ( ( ushort ) ( ( ( ( uint ) lcid )  >>  20 )  &  0x0F ) ) ; 
		    }


		/// <summary>
		/// Extract sublanguage id from a language id.
		/// </summary>
		/// <param name="lgid">Language id, containing the primary and sublanguage ids.</param>
		/// <returns>The sublanguage id.</returns>
		public static  SUBLANG_Constants  SUBLANGID ( int  lgid )
		   {
			return ( ( SUBLANG_Constants ) ( ( ushort ) ( lgid  >>  10 ) ) ) ;
		    }
	    }
	# endregion
    }
    