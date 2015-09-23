/**************************************************************************************************************

    NAME
        WinAPI/User32/R/RegisterClass.cs

    DESCRIPTION
        RegisterClass() Windows function.

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
		/// Registers a window class for subsequent use in calls to the CreateWindow or CreateWindowEx function.
		/// <para>
		/// Note  The RegisterClass function has been superseded by the RegisterClassEx function. You can still use RegisterClass, however, 
		/// if you do not need to set the class small icon.
		/// </para>
 		/// </summary>
		/// <param name="lpWndClass">
		/// A pointer to a WNDCLASS structure. You must fill the structure with the appropriate class attributes before passing it to the function
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a class atom that uniquely identifies the class being registered. 
		/// This atom can only be used by the CreateWindow, CreateWindowEx, GetClassInfo, GetClassInfoEx, FindWindow, FindWindowEx, and UnregisterClass functions 
		/// and the IActiveIMMap::FilterClientWindows method. 
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// If you register the window class by using RegisterClassA, the application tells the system that the windows of the created class expect messages with 
		/// text or character parameters to use the ANSI character set; if you register it by using RegisterClassW, the application requests that the system pass 
		/// text parameters of messages as Unicode. The IsWindowUnicode function enables applications to query the nature of each window. 
		/// <para>
		/// For more information on ANSI and Unicode functions, see Conventions for Function Prototypes.
		/// </para>
		/// <para>
		/// All window classes that an application registers are unregistered when it terminates. 
		/// </para>
		/// <para>
		/// No window classes registered by a User32 are unregistered when the User32 is unloaded. A User32 must explicitly unregister its classes when it is unloaded. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern ushort	RegisterClass ( ref WNDCLASS  lpWndClass ) ;
		# endregion
	    }
    }