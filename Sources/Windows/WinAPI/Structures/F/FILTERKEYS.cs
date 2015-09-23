/**************************************************************************************************************

    NAME
        WinAPI/Structures/FILTERKEYS.cs

    DESCRIPTION
        FILTERKEYS structure, used with the SPI_GETFILTERKEYS/SPI_SETFILTERKEYS actions of the
	SystemParametersInfo() function.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information associated with audio descriptions. 
	/// <para>
	/// This structure is used with the SystemParametersInfo function when the SPI_GETFILTERKEYS or SPI_SETFILTERKEYS action value is specified.
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct FILTERKEYS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public UInt32			cbSize ;

		/// <summary>
		/// A set of bit flags that specify properties of the FilterKeys feature. 
		/// </summary>
		public FKF_Constants		dwFlags ;

		/// <summary>
		/// Specifies the length of time, in milliseconds, that the user must hold down a key before it is accepted by the computer.
		/// </summary>
		public UInt32			iWaitMSec ;

		/// <summary>
		/// Specifies the length of time, in milliseconds, that the user must hold down a key before it begins to repeat.
		/// </summary>
		public UInt32			iDelayMSec ;

		/// <summary>
		/// Specifies the length of time, in milliseconds, between each repetition of the keystroke.
		/// </summary>
		public UInt32			iRepeatMSec ;

		/// <summary>
		/// Specifies the length of time, in milliseconds, that must elapse after releasing a key before the computer will accept a subsequent press of the same key.
		/// </summary>
		public UInt32			iBounceMSec ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized FILTERKEYS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized FILTERKEYS structure.</returns>
		public static implicit operator  FILTERKEYS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			FILTERKEYS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( FILTERKEYS ) ) ;
			Result. dwFlags		=  FKF_Constants. FKF_NONE ;
			Result. iBounceMSec	=  0 ;
			Result. iDelayMSec	=  0 ;
			Result. iRepeatMSec	=  0 ;
			Result. iWaitMSec	=  0 ;

			return ( Result ) ;
		    }
	    }
    }
