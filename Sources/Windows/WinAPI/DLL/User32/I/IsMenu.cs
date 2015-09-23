/**************************************************************************************************************

    NAME
        IsMenu.cs

    DESCRIPTION
        IsMenu() API.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
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
		# region Generic signature
		/// <summary>
		/// Determines whether a handle is a menu handle. 
		/// </summary>
		/// <param name="hMenu">A handle to be tested.</param>
		/// <returns>
		/// If the Menu handle identifies an existing Menu, the return value is nonzero.
		/// <para>
		/// If the Menu handle does not identify an existing Menu, the return value is zero. 
		/// </para>
		/// </returns>
		[DllImport ( USER32 )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	IsMenu ( IntPtr  hMenu ) ;
		# endregion
	    }
    }
