/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetProp.cs

    DESCRIPTION
        GetProp() Windows function.

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
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Retrieves a data handle from the property list of the specified window. The character string identifies the handle to be retrieved. 
		/// The string and handle must have been added to the property list by a previous call to the SetProp function. 
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list is to be searched. </param>
		/// <param name="lpString">
		/// An atom that identifies a string. If this parameter is an atom, it must have been created by using the GlobalAddAtom function. 
		/// The atom, a 16-bit value, must be placed in the low-order word of the lpString parameter; the high-order word must be zero. 
		/// </param>
		/// <returns>
		/// If the property list contains the string, the return value is the associated data handle. Otherwise, the return value is NULL. 
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetProp ( IntPtr  hWnd, String  lpString ) ;
		# endregion


		# region Version with an atom handle as lpString
		/// <summary>
		/// Retrieves a data handle from the property list of the specified window. The character string identifies the handle to be retrieved. 
		/// The string and handle must have been added to the property list by a previous call to the SetProp function. 
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list is to be searched. </param>
		/// <param name="lpString">
		/// An atom that identifies a string. If this parameter is an atom, it must have been created by using the GlobalAddAtom function. 
		/// The atom, a 16-bit value, must be placed in the low-order word of the lpString parameter; the high-order word must be zero. 
		/// </param>
		/// <returns>
		/// If the property list contains the string, the return value is the associated data handle. Otherwise, the return value is NULL. 
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	GetProp ( IntPtr  hWnd, IntPtr  lpString ) ;
		# endregion
	    }
    }