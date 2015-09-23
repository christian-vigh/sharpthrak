/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetProp.cs

    DESCRIPTION
        SetProp() Windows function.

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
		/// Adds a new entry or changes an existing entry in the property list of the specified window. The function adds a new entry to the list 
		/// if the specified character string does not exist already in the list. The new entry contains the string and the handle. 
		/// Otherwise, the function replaces the string's current handle with the specified handle. 
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list receives the new entry. </param>
		/// <param name="lpString">
		/// A null-terminated string or an atom that identifies a string. If this parameter is an atom, it must be a global atom created by a previous call 
		/// to the GlobalAddAtom function. The atom must be placed in the low-order word of lpString; the high-order word must be zero. 
		/// </param>
		/// <param name="hData">
		/// A handle to the data to be copied to the property list. The data handle can identify any value useful to the application. </param>
		/// <returns>
		/// If the data handle and string are added to the property list, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Before a window is destroyed (that is, before it returns from processing the WM_NCDESTROY message), an application must remove all entries 
		/// it has added to the property list. The application must use the RemoveProp function to remove the entries. 
		/// <br/>
		/// <para>
		/// SetProp is subject to the restrictions of User Interface Privilege Isolation (UIPI). A process can only call this function on a window belonging to 
		/// a process of lesser or equal integrity level. When UIPI blocks property changes, GetLastError will return 5.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetProp ( IntPtr  hWnd, String  lpString, IntPtr  hData ) ;
		# endregion


		# region Version with an atom handle as lpString value
		/// <summary>
		/// Adds a new entry or changes an existing entry in the property list of the specified window. The function adds a new entry to the list 
		/// if the specified character string does not exist already in the list. The new entry contains the string and the handle. 
		/// Otherwise, the function replaces the string's current handle with the specified handle. 
		/// </summary>
		/// <param name="hWnd">A handle to the window whose property list receives the new entry. </param>
		/// <param name="lpString">
		/// A null-terminated string or an atom that identifies a string. If this parameter is an atom, it must be a global atom created by a previous call 
		/// to the GlobalAddAtom function. The atom must be placed in the low-order word of lpString; the high-order word must be zero. 
		/// </param>
		/// <param name="hData">
		/// A handle to the data to be copied to the property list. The data handle can identify any value useful to the application. </param>
		/// <returns>
		/// If the data handle and string are added to the property list, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Before a window is destroyed (that is, before it returns from processing the WM_NCDESTROY message), an application must remove all entries 
		/// it has added to the property list. The application must use the RemoveProp function to remove the entries. 
		/// <br/>
		/// <para>
		/// SetProp is subject to the restrictions of User Interface Privilege Isolation (UIPI). A process can only call this function on a window belonging to 
		/// a process of lesser or equal integrity level. When UIPI blocks property changes, GetLastError will return 5.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetProp ( IntPtr  hWnd, IntPtr  lpString, IntPtr  hData ) ;
		# endregion
	    }
    }