﻿/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/CREATESTRUCT.cs

    DESCRIPTION
        CREATESTRUCT structure, send through the WM_CREATE Windows message.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Runtime. InteropServices ;
using   System.Windows.Forms ;

using   Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Defines the initialization parameters passed to the window procedure of an application. 
	/// <para>
	/// These members are identical to the parameters of the CreateWindowEx function.
	/// </para>
	/// </summary>
	/// <remarks>
	/// Because the lpszClass member can contain a pointer to a local (and thus inaccessable) atom, do not obtain the class name by using this member. 
	/// Use the GetClassName function instead.
	/// <para>
	/// You should access the data represented by the lpCreateParams member using a pointer that has been declared using the UNALIGNED type, 
	/// because the pointer may not be DWORD aligned. This is demonstrated in the following example:
	/// </para>
	/// </remarks>
	[StructLayout ( LayoutKind. Sequential, CharSet = CharSet. Auto )]
	public struct CREATESTRUCT
	   {
		/// <summary>
		/// Contains additional data which may be used to create the window. If the window is being created as a result of a call to the 
		/// CreateWindow or CreateWindowEx function, this member contains the value of the lpParam parameter specified in the function call.
		/// <para>
		/// If the window being created is a MDI client window, this member contains a pointer to a CLIENTCREATESTRUCT structure. 
		/// </para>
		/// <para>
		/// If the window being created is a MDI child window, this member contains a pointer to an MDICREATESTRUCT structure.
		/// </para>
		/// <para>
		/// If the window is being created from a dialog template, this member is the address of a SHORT value that specifies the size, in bytes, 
		/// of the window creation data. The value is immediately followed by the creation data. For more information, see the following Remarks section. 
		/// </para>
		/// </summary>
		public IntPtr		lpCreateParams ;

		/// <summary>
		/// A handle to the module that owns the new window. 
		/// </summary>
		public IntPtr		hInstance ;

		/// <summary>
		/// A handle to the menu to be used by the new window. 
		/// </summary>
		public IntPtr		hMenu ;

		/// <summary>
		/// A handle to the parent window, if the window is a child window. 
		/// <para>
		/// If the window is owned, this member identifies the owner window. If the window is not a child or owned window, this member is NULL. 
		/// </para>
		/// </summary>
		public IntPtr		hwndParent ;

		/// <summary>
		/// The width of the new window, in pixels. 
		/// </summary>
		public int		cx ;

		/// <summary>
		/// The height of the new window, in pixels. 
		/// </summary>
		public int		cy ;

		/// <summary>
		/// The x-coordinate of the upper left corner of the new window. 
		/// <para>
		/// If the new window is a child window, coordinates are relative to the parent window. Otherwise, the coordinates are relative to the screen origin. 
		/// </para>
		/// </summary>
		public int		x ;

		/// <summary>
		/// The y-coordinate of the upper left corner of the new window. 
		/// <para>
		/// If the new window is a child window, coordinates are relative to the parent window. Otherwise, the coordinates are relative to the screen origin. 
		/// </para>
		/// </summary>
		public int		y ;

		/// <summary>
		/// The style for the new window. 
		/// </summary>
		public WS_Constants	style ;

		/// <summary>
		/// The name of the new window. 
		/// </summary>
		public String		lpszName ;

		/// <summary>
		/// A pointer to a null-terminated string or an atom that specifies the class name of the new window. 
		/// </summary>
		public String		lpszClass ;

		/// <summary>
		/// The extended window style for the new window. For a list of possible values, see Extended Window Styles.
		/// </summary>
		public WS_EX_Constants	dwExStyle ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized CREATESTRUCT structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized CREATESTRUCT structure.</returns>
		public static implicit operator  CREATESTRUCT ( Thrak. WinAPI. Structures. Structure  value )
		   {
			CREATESTRUCT		Result ;

			Result. cx		=  0 ;
			Result. cy		=  0 ;
			Result. dwExStyle	=  WS_EX_Constants. WS_EX_NONE ;
			Result. hInstance	=  IntPtr. Zero ;
			Result. hMenu		=  IntPtr. Zero ;
			Result. hwndParent	=  IntPtr. Zero ;
			Result. lpCreateParams	=  IntPtr. Zero ;
			Result. lpszClass	=  "" ;
			Result. lpszName	=  "" ;
			Result. style		=  WS_Constants. WS_NONE ;
			Result. x		=  0 ;
			Result. y		=  0 ;

			return ( Result ) ;
		    }
	    }
    }
