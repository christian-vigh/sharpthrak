/**************************************************************************************************************

    NAME
        WinAPI/Structures/ACCESSTIMEOUT.cs

    DESCRIPTION
        ACCESSTIMEOUT structure, used with the SPI_GETACCESSTIMEOUT/SPI_SETACCESSTIMEOUT actions of the
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
	/// Contains information about the time-out period associated with the Microsoft Win32 accessibility features. 
	/// <para>
	/// The accessibility time-out period is the length of time that must pass without keyboard and mouse input before the operating system automatically 
	/// turns off accessibility features. 
	/// </para>
	/// <para>
	/// The accessibility time-out is designed for computers that are shared by several users so that options selected by one user do not inconvenience a subsequent user.
	/// </para>
	/// <para>
	/// The accessibility features affected by the time-out are the FilterKeys features (SlowKeys, BounceKeys, and RepeatKeys), MouseKeys, ToggleKeys, and StickyKeys. 
	/// </para>
	/// <para>
	/// The accessibility time-out also affects the high contrast mode setting.
	/// </para>
	/// </summary>
	/// <remarks>
	/// Use an ACCESSTIMEOUT structure when calling the SystemParametersInfo function with the uiAction parameter set to the SPI_GETACCESSTIMEOUT or 
	/// SPI_SETACCESSTIMEOUT value. When using SPI_GETACCESSTIMEOUT, you must specify the cbSize member of the ACCESSTIMEOUT structure ; 
	/// the SystemParametersInfo function fills in the remaining members. Specify all structure members when using the SPI_SETACCESSTIMEOUT value.
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct ACCESSTIMEOUT
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;
		/// <summary>
		/// A set of bit flags that specify properties of the time-out behavior for accessibility features.
		/// See the ATF_Constants enum help.
		/// </summary>
		public  ATF_Constants		dwFlags ;
		/// <summary>
		/// Specifies the time-out period, in milliseconds.
		/// </summary>
		public  UInt32			iTimeOutMSec ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized ACCESSTIMEOUT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized ACCESSTIMEOUT structure.</returns>
		public static implicit operator  ACCESSTIMEOUT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			ACCESSTIMEOUT		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( ACCESSTIMEOUT ) ) ;
			Result. dwFlags		=  ATF_Constants. ATF_NONE ;
			Result. iTimeOutMSec	=  0 ;

			return ( Result ) ;
		    }
	    }
    }
