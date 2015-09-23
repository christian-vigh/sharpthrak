/**************************************************************************************************************

    NAME
        WinAPI/Structures/WNDCLASSEXEX.cs

    DESCRIPTION
        WNDCLASSEX structure, returned by the RegisterClassEx() function.

    AUTHOR
        Christian Vigh, 08/2012, based on pInvoke.net.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/24]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Callbacks ;
using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains window class information. It is used with the RegisterClassEx and GetClassInfoEx  functions. 
	/// <para>
	/// The WNDCLASSEX structure is similar to the WNDCLASS structure. There are two differences. WNDCLASSEX includes the cbSize member, 
	/// which specifies the size of the structure, and the hIconSm member, which contains a handle to a small icon associated with the window class.
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct WNDCLASSEX
	   {
		/// <summary>
		/// The size, in bytes, of this structure. Set this member to sizeof(WNDCLASSEX). Be sure to set this member before calling the GetClassInfoEx function. 
		/// </summary>
		uint				cbSize ;

		/// <summary>
		/// The class style(s). This member can be any combination of the CS_Constants styles.
		/// </summary>
		CS_Constants			style ;

		/// <summary>
		/// A pointer to the window procedure. You must use the CallWindowProc function to call the window procedure.
		/// </summary>
		[MarshalAs ( UnmanagedType. FunctionPtr ) ]
		public WNDPROC			lpfnWndProc ;

		/// <summary>
		/// The number of extra bytes to allocate following the window-class structure. The system initializes the bytes to zero. 
		/// </summary>
		public int			cbClsExtra ;

		/// <summary>
		/// The number of extra bytes to allocate following the window instance. The system initializes the bytes to zero. 
		/// <para>
		/// If an application uses WNDCLASSEX to register a dialog box created by using the CLASS directive in the resource file, it must set this member to DLGWINDOWEXTRA. 
		/// </para>
		/// </summary>
		public int			cbWndExtra ;

		/// <summary>
		/// A handle to the instance that contains the window procedure for the class. 
		/// </summary>
		public IntPtr			hInstance ;

		/// <summary>
		/// A handle to the class icon. This member must be a handle to an icon resource. If this member is NULL, the system provides a default icon. 
		/// </summary>
		public IntPtr			hIcon ;

		/// <summary>
		/// A handle to the class cursor. This member must be a handle to a cursor resource. 
		/// <para>
		/// If this member is NULL, an application must explicitly set the cursor shape whenever the mouse moves into the application's window. 
		/// </para>
		/// </summary>
		public IntPtr			hCursor ;

		/// <summary>
		/// A handle to the class background brush. This member can be a handle to the physical brush to be used for painting the background, or it can be a color value. 
		/// <para>
		/// A color value must be one of the following standard system colors (the value 1 must be added to the chosen color). 
		/// </para>
		/// <para>
		/// If a color value is given, you must convert it to one of the COLOR_Constants values.
		/// </para>
		/// </summary>
		public IntPtr			hbrBackground ;

		/// <summary>
		/// The resource name of the class menu, as the name appears in the resource file. If you use an integer to identify the menu, use the MAKEINTRESOURCE macro. 
		/// <para>
		/// If this member is NULL, windows belonging to this class have no default menu. 
		/// </para>
		/// </summary>
		[MarshalAs ( UnmanagedType. LPTStr )]
		public string			lpszMenuName ;

		/// <summary>
		/// A pointer to a null-terminated string or is an atom. If this parameter is an atom, it must be a class atom created by a previous call to the RegisterClass 
		/// or RegisterClassEx function. The atom must be in the low-order word of lpszClassName; the high-order word must be zero. 
		/// <para>
		/// If lpszClassName is a string, it specifies the window class name. The class name can be any name registered with RegisterClass or RegisterClassEx, 
		/// or any of the predefined control-class names. 
		/// </para>
		/// <para>
		/// The maximum length for lpszClassName is 256. If lpszClassName is greater than the maximum length, the RegisterClass function will fail.
		/// </para>
		/// </summary>
		[MarshalAs ( UnmanagedType. LPTStr )]
		public string			lpszClassName ;

		/// <summary>
		/// A handle to a small icon that is associated with the window class. If this member is NULL, the system searches the icon resource specified by 
		/// the hIcon member for an icon of the appropriate size to use as the small icon. 
		/// </summary>
		public IntPtr			hIconSm ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized WNDCLASSEX structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized WNDCLASSEX structure.</returns>
		public static implicit operator  WNDCLASSEX ( Thrak. WinAPI. Structures. Structure  value )		   {
			WNDCLASSEX		Result ;

			Result. cbSize			=  Macros. GETSTRUCTSIZE ( typeof ( WNDCLASSEX ) ) ;
			Result. cbClsExtra		=  0 ;
			Result. cbWndExtra		=  0 ;
			Result. hbrBackground		=  ( IntPtr ) COLOR_Constants. COLOR_NONE ;
			Result. hCursor			=  IntPtr. Zero ;
			Result. hIcon			=  IntPtr. Zero ;
			Result. hInstance		=  IntPtr. Zero ;
			Result. lpfnWndProc		=  null ;
			Result. lpszClassName		=  "" ;
			Result. lpszMenuName		=  "" ;
			Result. style			=  CS_Constants. CS_NONE ;
			Result. hIconSm			=  IntPtr. Zero ;

			return ( Result ) ;
		    }
	    }
    }
