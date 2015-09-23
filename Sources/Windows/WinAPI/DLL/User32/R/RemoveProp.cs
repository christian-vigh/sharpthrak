/**************************************************************************************************************

    NAME
        WinAPI/User32/R/RemoveProp.cs

    DESCRIPTION
        RemoveProp() Windows function.

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
		/// Removes an entry from the property list of the specified window. The specified character string identifies the entry to be removed.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list is to be changed.</param>
		/// <param name="lpString">
		/// A null-terminated character string or an atom that identifies a string. If this parameter is an atom, it must have been created using the GlobalAddAtom function. 
		/// The atom, a 16-bit value, must be placed in the low-order word of lpString; the high-order word must be zero.
		/// </param>
		/// <returns>
		/// The return value identifies the specified data. If the data cannot be found in the specified property list, the return value is NULL.
		/// </returns>
		/// <remarks>
		/// The return value is the hData value that was passed to SetProp; it is an application-defined value. Note, this function only destroys 
		/// the association between the data and the window. If appropriate, the application must free the data handles associated with entries removed 
		/// from a property list. The application can remove only those properties it has added. It must not remove properties added by other applications 
		/// or by the system itself.
		/// <br/>
		/// <para>
		/// Starting with Windows Vista, RemoveProp is subject to the restrictions of User Interface Privilege Isolation (UIPI). 
		/// A process can only call this function on a window belonging to a process of lesser or equal integrity level. When UIPI blocks property changes, 
		/// GetLastError will return 5.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	RemoveProp ( IntPtr  hWnd, String  lpString ) ;
		# endregion


		# region Version with an atom handle as lpString.
		/// <summary>
		/// Removes an entry from the property list of the specified window. The specified character string identifies the entry to be removed.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list is to be changed.</param>
		/// <param name="lpString">
		/// A null-terminated character string or an atom that identifies a string. If this parameter is an atom, it must have been created using the GlobalAddAtom function. 
		/// The atom, a 16-bit value, must be placed in the low-order word of lpString; the high-order word must be zero.
		/// </param>
		/// <returns>
		/// The return value identifies the specified data. If the data cannot be found in the specified property list, the return value is NULL.
		/// </returns>
		/// <remarks>
		/// The return value is the hData value that was passed to SetProp; it is an application-defined value. Note, this function only destroys 
		/// the association between the data and the window. If appropriate, the application must free the data handles associated with entries removed 
		/// from a property list. The application can remove only those properties it has added. It must not remove properties added by other applications 
		/// or by the system itself.
		/// <br/>
		/// <para>
		/// Starting with Windows Vista, RemoveProp is subject to the restrictions of User Interface Privilege Isolation (UIPI). 
		/// A process can only call this function on a window belonging to a process of lesser or equal integrity level. When UIPI blocks property changes, 
		/// GetLastError will return 5.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	RemoveProp ( IntPtr  hWnd, IntPtr  lpString ) ;
		# endregion
	    }
    }