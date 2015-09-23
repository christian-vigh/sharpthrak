/**************************************************************************************************************

    NAME
        WinAPI/User32/E/EnumPropsEx.cs

    DESCRIPTION
        EnumPropsEx() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/01]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Callbacks ;
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Enumerates all entries in the property list of a window by passing them, one by one, to the specified callback function.
		/// EnumPropsEx continues until the last entry is enumerated or the callback function returns FALSE.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list is to be enumerated. </param>
		/// <param name="lpEnumFunc">A pointer to the callback function. For more information about the callback function, see the PropEnumProc function. </param>
		/// <param name="lParam">Application-defined data to be passed to the callback function. </param>
		/// <returns>The return value specifies the last value returned by the callback function. It is -1 if the function did not find a property for enumeration. </returns>
		/// <remarks>
		/// An application can remove only those properties it has added. It must not remove properties added by other applications or by the system itself. 
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	EnumPropsEx ( IntPtr  hWnd, PROPENUMPROCEX  lpEnumFunc, IntPtr  lParam ) ;
		# endregion
	    }
    }