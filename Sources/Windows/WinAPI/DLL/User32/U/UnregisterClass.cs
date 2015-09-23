/**************************************************************************************************************

    NAME
        WinAPI/User32/R/UnregisterClass.cs

    DESCRIPTION
        UnregisterClass() Windows function.

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
		/// Unregisters a window class, freeing the memory required for the class. 
 		/// </summary>
		/// <param name="lpClassName">
		/// A null-terminated string or a class atom. If lpClassName is a string, it specifies the window class name. 
		/// <para>
		/// This class name must have been registered by a previous call to the RegisterClass or RegisterClassEx function. 
		/// </para>
		/// <para>
		/// System classes, such as dialog box controls, cannot be unregistered. If this parameter is an atom, it must be a class atom created by a previous call 
		/// to the RegisterClass or RegisterClassEx function. The atom must be in the low-order word of lpClassName; the high-order word must be zero.
		/// </para>
		/// </param>
		/// <param name="hInstance">
		/// A handle to the instance of the module that created the class. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. 
		/// <para>
		/// If the class could not be found or if a window still exists that was created with the class, the return value is zero. To get extended error information, 
		/// call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// Before calling this function, an application must destroy all windows created with the specified class. 
		/// <para>
		/// All window classes that an application registers are unregistered when it terminates. 
		/// </para>
		/// <para>
		/// Class atoms are special atoms returned only by RegisterClass and RegisterClassEx. 
		/// </para>
		/// <para>
		/// No window classes registered by a User32 are unregistered when the .dll is unloaded. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern ushort	UnregisterClass ( String  lpClassName, IntPtr  hInstance ) ;
		# endregion
	    }
    }