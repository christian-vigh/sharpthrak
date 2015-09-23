/**************************************************************************************************************

    NAME
        WinAPI/Structures/FILETIME.cs

    DESCRIPTION
        FILETIME structure.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Windows FILETIME structure.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct FILETIME
	   {
		# region Structure members
		private uint	__dwLowDateTime ;		// Low value of file date/time
		private uint	__dwHighDateTime ;		// High value
		# endregion


		# region Constructors
		/// <summary>
		/// Builds a FILETIME structure using the specified values.
		/// </summary>
		/// <param name="low">Low DWORD of the FILETIME structure.</param>
		/// <param name="high">High DWORD of the FILETIME structure.</param>
		public FILETIME ( uint  low = 0, uint  high = 0 )
		   {
			__dwHighDateTime	=  high ;
			__dwLowDateTime		=  low ;
		    }


		/// <summary>
		/// Builds a FILETIME structure using a DateTime value.
		/// </summary>
		/// <param name="dt">DateTime value used to initialize the FILETIME structure.</param>
		public  FILETIME  ( DateTime  dt )
		   {
			ulong		value	=  ( ulong )  dt. ToFileTime ( ) ;

			__dwHighDateTime	=  ( uint ) ( ( value  >>  32 )  &  0xFFFFFFFF ) ;
			__dwLowDateTime		=  ( uint ) ( value  &  0xFFFFFFFF ) ;
			Value	=  ( ulong ) dt. ToFileTime ( ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets/sets the low DWORD value of the FILETIME structure.
		/// </summary>
		public uint  dwLowDateTime
		   {
			get { return ( __dwLowDateTime ) ; }
			set { __dwLowDateTime = value ; }
		    }


		/// <summary>
		/// Gets/sets the high DWORD value of the FILETIME structure.
		/// </summary>
		public uint  dwHighDateTime
		   {
			get { return ( __dwHighDateTime ) ; }
			set { __dwHighDateTime = value ; }
		    }


		/// <summary>
		/// Gets/sets the low and high DWORD values of the FILETIME structure with an unsigned long integer.
		/// </summary>
		public ulong  Value
		   {
			get { return ( ( ulong ) ( __dwHighDateTime  <<  32 )  |  ( ulong ) __dwLowDateTime ) ; }
			set
			   {
				__dwLowDateTime		=  ( uint ) ( value  &  0xFFFFFFFF ) ;
				__dwHighDateTime	=  ( uint ) ( ( value  >>  32 )  &  0xFFFFFFFF ) ;
			    }
		    }
		# endregion


		# region Operators
		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized FILETIME structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized FILETIME structure.</returns>
		public static implicit operator  FILETIME ( Thrak. WinAPI. Structures. Structure  value )
		   {
			FILETIME		Result ;

			Result. __dwHighDateTime	=  0 ;
			Result. __dwLowDateTime		=  0 ;

			return ( Result ) ;
		    }
		# endregion
	    }
    }
