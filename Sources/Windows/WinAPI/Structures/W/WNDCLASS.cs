/**************************************************************************************************************

    NAME
        WinAPI/Structures/WNDCLASS.cs

    DESCRIPTION
        WNDCLASS structure, returned by the RegisterClass() function.

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
	/// Contains the window class attributes that are registered by the RegisterClass function. 
	/// <para>
	/// This structure has been superseded by the WNDCLASSEX structure used with the RegisterClassEx function. 
	/// </para>
	/// <para>
	/// You can still use WNDCLASS and RegisterClass if you do not need to set the small icon associated with the window class.
	/// </para>
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct WNDCLASS
	   {
		/// <summary>
		/// The class style(s). This member can be any combination of the Class Styles. 
		/// </summary>
		public CS_Constants		style ;

		/// <summary>
		/// A pointer to the window procedure. You must use the CallWindowProc function to call the window procedure.
		/// </summary>
		[MarshalAs ( UnmanagedType. FunctionPtr )]
		public WNDPROC			lpfnWndProc ;

		/// <summary>
		/// The number of extra bytes to allocate following the window-class structure. The system initializes the bytes to zero. 
		/// </summary>
		public int			cbClsExtra ;

		/// <summary>
		/// The number of extra bytes to allocate following the window instance. The system initializes the bytes to zero. 
		/// <para>
		/// If an application uses WNDCLASS to register a dialog box created by using the CLASS directive in the resource file, it must set this member to DLGWINDOWEXTRA. 
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
		/// Converts a WinAPI.Structure object into an initialized WNDCLASS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized WNDCLASS structure.</returns>
		public static implicit operator  WNDCLASS ( Thrak. WinAPI. Structures. Structure  value )		   {
			WNDCLASS		Result ;

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

			return ( Result ) ;
		    }
	    }
    }
