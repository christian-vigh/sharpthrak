/**************************************************************************************************************

    NAME
        WinAPI/Structures/M/MSGBOXPARAMS.cs

    DESCRIPTION
        MSGBOXPARAMS structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/07]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using   Thrak. WinAPI. Callbacks ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Contains information used to display a message box. The MessageBoxIndirect function uses this structure.
	/// </summary>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  MSGBOXPARAMS
	   {
		/// <summary>
		/// The structure size, in bytes. 
		/// </summary>
		public uint			cbSize ;

		/// <summary>
		/// A handle to the owner window. This member can be NULL. 
		/// </summary>
		public IntPtr			hwndOwner ;

		/// <summary>
		/// A handle to the module that contains the icon resource identified by the lpszIcon member, 
		/// and the string resource identified by the lpszText or lpszCaption member. 
		/// </summary>
		public IntPtr			hInstance ;

		/// <summary>
		/// A null-terminated string, or the identifier of a string resource, that contains the message to be displayed. 
		/// </summary>
		public String			lpszText ;

		/// <summary>
		/// A null-terminated string, or the identifier of a string resource, that contains the message box title. 
		/// If this member is NULL, the default title Error is used. 
		/// </summary>
		public String			lpszCaption ;

		/// <summary>
		/// The contents and behavior of the dialog box. This member can be a combination of flags described for the uType parameter of 
		/// the MessageBoxEx function. 
		/// <br/>
		/// <para>
		/// In addition, you can specify the MB_USERICON flag (0x00000080L) if you want the message box to display the icon specified 
		/// by the lpszIcon member. 
		/// </para>
		/// </summary>
		public MB_Constants		dwStyle ;

		/// <summary>
		/// Identifies an icon resource. This parameter can be either a null-terminated string or an integer resource identifier passed to 
		/// the MAKEINTRESOURCE macro. 
		/// <br/>
		/// <para>
		/// To load one of the standard system-defined icons, set the hInstance member to NULL and set lpszIcon to one of the values listed 
		/// with the LoadIcon function. 
		/// </para>
		/// <br/>
		/// <para>
		/// This member is ignored if the dwStyle member does not specify the MB_USERICON flag. 
		/// </para>
		/// </summary>
		public String			lpzIcon ;

		/// <summary>
		/// Identifies a help context. If a help event occurs, this value is specified in the HELPINFO structure that the message box sends 
		/// to the owner window or callback function. 
		/// </summary>
		public IntPtr			dwContextHelpId ;

		/// <summary>
		/// A pointer to the callback function that processes help events for the message box.
		/// <para>
		/// If this member is NULL, the message box sends WM_HELP messages to the owner window when help events occur. 
		/// </para>
		/// </summary>
		public MSGBOXCALLBACK		lpfnMsgBoxCallback ;

		/// <summary>
		/// The language in which to display the text contained in the predefined push buttons. 
		/// This value must be in the form returned by the MAKELANGID macro. 
		/// <br/>
		/// <para>
		/// For a list of supported language identifiers, see Language Identifiers. Note that each localized release of Windows typically contains 
		/// resources only for a limited set of languages. Thus, for example, the U.S. version offers LANG_ENGLISH, the French version offers 
		/// LANG_FRENCH, the German version offers LANG_GERMAN, and the Japanese version offers LANG_JAPANESE. Each version offers LANG_NEUTRAL. 
		/// This limits the set of values that can be used with the dwLanguageId parameter. Before specifying a language identifier, 
		/// you should enumerate the locales that are installed on a system. 
		/// </para>
		/// </summary>
		public uint			dwLanguageId ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized MSGBOXPARAMS structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized MSGBOXPARAMS structure.</returns>
		public static implicit operator  MSGBOXPARAMS ( Thrak. WinAPI. Structures. Structure  value )
		   {
			MSGBOXPARAMS		Result ;

			Result.cbSize			=  Macros. GETSTRUCTSIZE ( typeof ( MSGBOXPARAMS ) ) ;
			Result.dwContextHelpId		=  IntPtr. Zero ;
			Result.dwLanguageId		=  0 ;
			Result.dwStyle			=  MB_Constants. MB_NONE ;
			Result. hInstance		=  IntPtr. Zero ;
			Result. hwndOwner		=  IntPtr. Zero ;
			Result. lpfnMsgBoxCallback	=  null ;
			Result. lpszCaption		=  null ;
			Result. lpszText		=  null ;
			Result. lpzIcon			=  null ;

			return ( Result ) ;
		    }
	    }
    }