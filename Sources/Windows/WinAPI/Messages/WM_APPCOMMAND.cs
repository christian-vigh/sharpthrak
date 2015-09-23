/**************************************************************************************************************

    NAME
        WM_APPCOMMAND.cs

    DESCRIPTION
        WM_APPCOMMAND message helper classes.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. Structures ;
using   Thrak. WinAPI. WAPI ;
using   Thrak. WinAPI. Enums ;
using   Thrak. WinAPI ;


namespace Thrak. WinAPI. Messages 
   {
	# region WM_APPCOMMAND class
	/// <summary>
	/// Helper class for extracting information from WM_APPCOMMAND parameters.
	/// </summary>
	public static class	WM_APPCOMMAND
	   {	
		/// <summary>
		/// Returns the APPCOMMAND value stored in the LPARAM parameter of the WM_APPCOMMAND Windows message.
		/// </summary>
		/// <param name="lParam">LPARAM value of the WM_APPCOMMAND Windows message.</param>
		/// <returns>The APPCOMMAND value.</returns>
		public static short  GET_APPCOMMAND_LPARAM ( uint  lParam )
		   {
			return ( ( short ) ( Macros. HIWORD ( lParam )   &  ~( ( ushort ) FAPPCOMMAND. FAPPCOMMAND_MASK ) ) ) ;
		     }

		
		/// <summary>
		/// Returns the input device that generated the command.
		/// </summary>
		/// <param name="lParam">LPARAM value of the WM_APPCOMMAND Windows message.</param>
		/// <returns>The FAPPCOMMAND value.</returns>
		public static ushort  GET_DEVICE_LPARAM ( uint  lParam )
		   {
			return ( ( ushort ) ( Macros. HIWORD ( lParam )  &  ( ( ushort ) FAPPCOMMAND. FAPPCOMMAND_MASK ) ) ) ;
		    }


		/// <summary>
		/// A synonym to the GET_DEVICE_LPARAM function.
		/// </summary>
		public static ushort  GET_MOUSEORKEY_LPARAM ( uint  lParam )
		   {
			return ( GET_DEVICE_LPARAM ( lParam ) ) ;
		    }


		/// <summary>
		/// Returns some key states at the time the WM_APPCOMMAND message was generated.
		/// </summary>
		/// <param name="lParam"></param>
		/// <returns></returns>
		public static ushort  GET_KEYSTATE_LPARAM ( uint  lParam )
		   {
			return ( GET_FLAGS_LPARAM ( lParam ) ) ;
		    }


		/// <summary>
		/// A synonym to the GET_KEYSTATE_LPARAM function.
		/// </summary>
		public static ushort  GET_FLAGS_LPARAM ( uint  lParam )
		   {
			return ( Macros. LOWORD ( lParam ) ) ;
		    }
	    }
	# endregion


	# region WM_APPCOMMAND_LPARAM class.
	/// <summary>
	/// Maps the LPARAM parameter of the WM_APPCOMMAND window message to a BitLayout structure.
	/// </summary>
	public class	WM_APPCOMMAND_LPARAM	:  BitLayout
	   {
		/// <summary>
		/// Builds a WM_APP_COMMAND_LPARAM object that will map to the LPARAM parameter of the Windows message.
		/// </summary>
		public  WM_APPCOMMAND_LPARAM ( )  : base ( 32 )
		   { }


		/// <summary>
		/// Input message origin.
		/// </summary>
		[Bits ( 24, 31 )]
		public BitField<FAPPCOMMAND_Constants>		InputOrigin ;


		/// <summary>
		/// Command sent to the application.
		/// </summary>
		[Bits ( 16, 24 )]
		public BitField<APPCOMMAND_Constants>		Command ;


		/// <summary>
		/// Mouse buttons state.
		/// </summary>
		[Bits ( 0, 15 )]
		public BitField<MK_Constants>			MouseState ;
	    }
	# endregion
    }