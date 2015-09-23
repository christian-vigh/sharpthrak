/**************************************************************************************************************

    NAME
        WinAPI/Structures/STICKYKEYS.cs

    DESCRIPTION
        ACCESSTIMEOUT structure, used with the SPI_GETSTICKYKEYS/SPI_SETSTICKYKEYS actions of the
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
	/// Contains information about the StickyKeys accessibility feature. 
	/// <para>
	/// When the StickyKeys feature is on, the user can press a modifier key (SHIFT, CTRL, or ALT) and then another key in sequence rather than at the same time, 
	/// to enter shifted (modified) characters and other key combinations. 
	/// </para>
	/// <para>
	/// Pressing a modifier key once latches the key down until the user presses a non-modifier key or clicks a mouse button. 
	/// </para>
	/// <para>
	/// Pressing a modifier key twice locks the key until the user presses the key a third time.
	/// </para>
	/// </summary>
	/// <remarks>
	/// An application uses a STICKYKEYS structure when calling the SystemParametersInfo function with the uiAction parameter set to SPI_GETSTICKYKEYS or SPI_SETSTICKYKEYS. 
	/// <para>
	/// When using SPI_GETSTICKYKEYS, you must specify the cbSize member of the STICKYKEYS structure; the SystemParametersInfo function fills the remaining members. 
	/// </para>
	/// <para>
	/// You must specify all structure members when using the SPI_SETSTICKYKEYS value.
	/// </para>
	/// <br/>
	/// <para>
	/// If you call SystemParametersInfo with the SPI_SETSTICKYKEYS value, the following flags are ignored :
	/// </para>
	/// <para>• SKF_LALTLATCHED</para>
	/// <para>• SKF_LCTLLATCHED</para>
	/// <para>• SKF_LSHIFTLATCHED</para>
	/// <para>• SKF_RALTLATCHED</para>
	/// <para>• SKF_RCTLLATCHED</para>
	/// <para>• SKF_RSHIFTLATCHED</para>
	/// <para>• SKF_LALTLOCKED</para>
	/// <para>• SKF_LCTLLOCKED</para>
	/// <para>• SKF_LSHIFTLOCKED</para>
	/// <para>• SKF_RALTLOCKED</para>
	/// <para>• SKF_RCTLLOCKED</para>
	/// <para>• SKF_RSHIFTLOCKED</para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential )]
	public struct STICKYKEYS
	   {
		/// <summary>
		/// Specifies the size, in bytes, of this structure.
		/// </summary>
		public  UInt32			cbSize ;

		/// <summary>
		/// A set of bit-flags that specify properties of the StickyKeys feature.
		/// </summary>
		public  SKF_Constants		dwFlags ;



		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized STICKYKEYS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized STICKYKEYS structure.</returns>
		public static implicit operator  STICKYKEYS ( Thrak. WinAPI. Structures. Structure  value )		   {
			STICKYKEYS		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( STICKYKEYS ) ) ;
			Result. dwFlags		=  SKF_Constants. SKF_NONE ;

			return ( Result ) ;
		    }
	    }
    }
