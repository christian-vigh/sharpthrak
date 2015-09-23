/**************************************************************************************************************

    NAME
        WinAPI/Structures/MOUSEKEYS.cs

    DESCRIPTION
        ACCESSTIMEOUT structure, used with the SPI_GETMOUSEKEYS/SPI_SETMOUSEKEYS actions of the
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
	/// </summary>
	/// <remarks>
	/// An application uses a MOUSEKEYS structure when calling the SystemParametersInfo function with the uiAction parameter set to 
	/// the SPI_GETMOUSEKEYS or SPI_SETMOUSEKEYS value. When using SPI_GETMOUSEKEYS, an application must specify the cbSize member of the MOUSEKEYS structure ; 
	/// the SystemParametersInfo function fills the remaining members. An application must specify all structure members when using the SPI_SETMOUSEKEYS value.
	/// <br/>
	/// <para>
	/// If you call SystemParametersInfo with the SPI_SETMOUSEKEYS value, the following flags are ignored:
	/// </para>
	/// <para>• MKF_LEFTBUTTONDOWN</para>
	/// <para>• MKF_LEFTBUTTONSEL</para>
	/// <para>• MKF_MOUSEMODE</para>
	/// <para>• MKF_RIGHTBUTTONDOWN</para>
	/// <para>• MKF_RIGHTBUTTONSEL</para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct MOUSEKEYS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;
		
		/// <summary>
		/// A set of bit-flags that specify properties of the FilterKeys feature.
		/// </summary>
		public MKF_Constants		dwFlags ;

		/// <summary>
		/// Specifies the maximum speed the mouse cursor attains when an arrow key is held down.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Windows 95/98: Range checking is not performed.
		/// </para>
		/// <para>
		/// Windows NT/2000: Valid values are from 10 to 360.
		/// </para>
		/// </remarks>
		public UInt32			iMaxSpeed ;

		/// <summary>
		/// Specifies the length of time, in milliseconds, that it takes for the mouse cursor to reach maximum speed when an arrow key is held down. 
		/// Valid values are from 1000 to 5000.
		/// </summary>
		public UInt32			iTimeToMaxSpeed ;

		/// <summary>
		/// Specifies the multiplier to apply to the mouse cursor speed when the user holds down the CTRL key while using the arrow keys to move the cursor. 
		/// <para>
		/// This value is ignored if MKF_MODIFIERS is not set.
		/// </para>
		/// </summary>
		public UInt32			iCtrlSpeed ;

		/// <summary>
		/// This member is reserved for future use. It must be set to zero.
		/// </summary>
		public UInt32			dwReserved1 ;

		/// <summary>
		/// This member is reserved for future use. It must be set to zero.
		/// </summary>
		public UInt32			dwReserved2 ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MOUSEKEYS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MOUSEKEYS structure.</returns>
		public static implicit operator  MOUSEKEYS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MOUSEKEYS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( MOUSEKEYS ) ) ;
			Result. dwFlags		=  MKF_Constants. MKF_NONE ;
			Result. dwReserved1	=  0 ;
			Result. dwReserved2	=  0 ;
			Result. iCtrlSpeed	=  0 ;
			Result. iMaxSpeed	=  0 ;
			Result. iTimeToMaxSpeed	=  0 ;

			return ( Result ) ;
		    }
	    }
    }
