/**************************************************************************************************************

    NAME
        WinAPI/User32/I/InSendMessageEx.cs

    DESCRIPTION
        InSendMessageEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Determines whether the current window procedure is processing a message that was sent from another thread (in the same process or a different process).
 		/// </summary>
		/// <param name="lpReserved">
		/// Reserved; must be NULL.
		/// </param>
		/// <returns>
		/// An ISMEX constant describing the state of the message.
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern ISMEX_Constants 	InSendMessageEx ( IntPtr   lpReserved ) ;
		# endregion


		# region Version with a default value for the lpReserved parameter.
		/// <summary>
		/// Determines whether the current window procedure is processing a message that was sent from another thread (in the same process or a different process).
 		/// </summary>
		/// <param name="lpReserved">
		/// Reserved; must be NULL.
		/// </param>
		/// <returns>
		/// An ISMEX constant describing the state of the message.
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern ISMEX_Constants 	InSendMessageEx ( uint  lpReserved = 0 ) ;
		# endregion
	    }
    }