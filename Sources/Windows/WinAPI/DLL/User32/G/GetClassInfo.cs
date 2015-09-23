/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetClassInfo.cs

    DESCRIPTION
        GetClassInfo() Windows function.

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
		/// Retrieves information about a window class.
		/// <para>
		/// Note : The GetClassInfo function has been superseded by the GetClassInfoEx function. You can still use GetClassInfo, however, if you do not need 
		/// information about the class small icon.
		/// </para>
 		/// </summary>
		/// <param name="hInstance">
		/// A handle to the instance of the application that created the class. 
		/// <para>
		/// To retrieve information about classes defined by the system (such as buttons or list boxes), set this parameter to NULL. 
		/// </para>
		/// </param>
		/// <param name="lpClassName">
		/// The class name. The name must be that of a preregistered class or a class registered by a previous call to the RegisterClass or RegisterClassEx function. 
		/// <para>
		/// Alternatively, this parameter can be an atom. If so, it must be a class atom created by a previous call to RegisterClass or RegisterClassEx. 
		/// </para>
		/// <para>
		/// The atom must be in the low-order word of lpClassName; the high-order word must be zero.
		/// </para>
		/// </param>
		/// <param name="lpWndClass">
		/// A pointer to a WNDCLASS structure that receives the information about the class. 
		/// </param>
		/// <returns>
		/// If the function finds a matching class and successfully copies the data, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool	GetClassInfo ( IntPtr  hInstance, string  lpClassName, out WNDCLASS  lpWndClass ) ;
		# endregion
	    }
    }