/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetClassName.cs

    DESCRIPTION
        GetClassName() Windows function.

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
		# region Version with a StringBuilder object.
		/// <summary>
		/// Retrieves the name of the class to which the specified window belongs. 
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs. </param>
		/// <param name="lpClassName">The class name string.</param>
		/// <param name="nMaxCount">
		/// The length of the lpClassName buffer, in characters. 
		/// The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to nMaxCount-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int	GetClassName ( IntPtr  hWnd, StringBuilder  lpClassName, int  nMaxCount ) ;
		# endregion


		# region Version with an out String object.
		/// <summary>
		/// Retrieves the name of the class to which the specified window belongs. 
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs. </param>
		/// <param name="lpClassName">The class name string.</param>
		/// <param name="nMaxCount">
		/// The length of the lpClassName buffer, in characters. 
		/// The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to nMaxCount-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		public static int	GetClassName ( IntPtr  hWnd, out String  lpClassName, int  nMaxCount )
		   {
			if  ( nMaxCount  <  1 )
				nMaxCount	=  Defines. DEFAULT_OUT_STRING_LENGTH ;

			StringBuilder	value		=  new StringBuilder ( nMaxCount ) ;
			int		result		=  GetClassName ( hWnd, value, nMaxCount ) ;

			lpClassName	=  value. ToString ( ) ;

			return ( result ) ;
		    }
		# endregion
	    }
    }