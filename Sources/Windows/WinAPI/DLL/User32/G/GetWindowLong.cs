/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetWindowLong.cs

    DESCRIPTION
        GetWindowLong() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
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
		/// <summary>
		/// Retrieves information about the specified window. The function also retrieves the value at a specified offset into the extra window memory. 
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="nIndex">
		/// The zero-based offset to the value to be retrieved. 
		/// <para>
		/// Valid values are in the range zero through the number of bytes of extra window memory, minus the size of an integer.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the requested value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// <para>
		/// If SetWindowLong or SetWindowLongPtr has not been called previously, GetWindowLongPtr returns zero for values in the extra window or class memory.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function is compatible to both 32- and 64-bits platforms (the GetWindowLongPtr function is called instead).
		/// <para>
		/// Reserve extra window memory by specifying a nonzero value in the cbWndExtra member of the WNDCLASSEX structure used with the RegisterClassEx function. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, EntryPoint = "GetWindowLongPtr", SetLastError = true )]
		public static extern IntPtr GetWindowLong ( IntPtr  hWnd, int  nIndex ) ;


		/// <summary>
		/// Retrieves information about the specified window. The function also retrieves the value at a specified offset into the extra window memory. 
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="nIndex">
		/// The zero-based offset to the value to be retrieved. 
		/// <para>
		/// Valid values are in the range zero through the number of bytes of extra window memory, minus the size of an integer.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the requested value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// <para>
		/// If SetWindowLong or SetWindowLongPtr has not been called previously, GetWindowLongPtr returns zero for values in the extra window or class memory.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function is compatible to both 32- and 64-bits platforms (the GetWindowLongPtr function is called instead).
		/// <para>
		/// Reserve extra window memory by specifying a nonzero value in the cbWndExtra member of the WNDCLASSEX structure used with the RegisterClassEx function. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, EntryPoint = "GetWindowLongPtr", SetLastError = true )]
		public static extern IntPtr GetWindowLongPtr ( IntPtr  hWnd, int  nIndex ) ;


		/// <summary>
		/// Retrieves information about the specified window. The function also retrieves the value at a specified offset into the extra window memory. 
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="nIndex">
		/// The zero-based offset to the value to be retrieved. 
		/// <para>
		/// Valid values are in the range zero through the number of bytes of extra window memory, minus the size of an integer.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the requested value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// <para>
		/// If SetWindowLong or SetWindowLongPtr has not been called previously, GetWindowLongPtr returns zero for values in the extra window or class memory.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function is compatible to both 32- and 64-bits platforms (the GetWindowLongPtr function is called instead).
		/// <para>
		/// Reserve extra window memory by specifying a nonzero value in the cbWndExtra member of the WNDCLASSEX structure used with the RegisterClassEx function. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, EntryPoint = "GetWindowLongPtr", SetLastError = true )]
		public static extern IntPtr GetWindowLong ( IntPtr  hWnd, GWL_Constants  nIndex ) ;


		/// <summary>
		/// Retrieves information about the specified window. The function also retrieves the value at a specified offset into the extra window memory. 
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="nIndex">
		/// The zero-based offset to the value to be retrieved. 
		/// <para>
		/// Valid values are in the range zero through the number of bytes of extra window memory, minus the size of an integer.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the requested value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// <para>
		/// If SetWindowLong or SetWindowLongPtr has not been called previously, GetWindowLongPtr returns zero for values in the extra window or class memory.
		/// </para>
		/// </returns>
		/// <remarks>
		/// This function is compatible to both 32- and 64-bits platforms (the GetWindowLongPtr function is called instead).
		/// <para>
		/// Reserve extra window memory by specifying a nonzero value in the cbWndExtra member of the WNDCLASSEX structure used with the RegisterClassEx function. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, EntryPoint = "GetWindowLongPtr", SetLastError = true )]
		public static extern IntPtr GetWindowLongPtr ( IntPtr  hWnd, GWL_Constants  nIndex ) ;

	    }
    }