/**************************************************************************************************************

    NAME
        WinAPI/Structures/C/COMBOBOXINFO.cs

    DESCRIPTION
        COMBOBOXINFO structure, send through the CB_GETCOMBOBOXINFO Windows message.

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
	/// Contains combo box status information.
	/// </summary>
	[StructLayout ( LayoutKind. Sequential )]
	public struct COMBOBOXINFO
	   {
		/// <summary>
		/// The size, in bytes, of the structure. The calling application must set this to sizeof(COMBOBOXINFO). 
		/// </summary>
		public uint			cbSize ;

		/// <summary>
		/// A RECT structure that specifies the coordinates of the edit box. 
		/// </summary>
		public RECT			rcItem ;

		/// <summary>
		/// A RECT structure that specifies the coordinates of the button that contains the drop-down arrow. 
		/// </summary>
		public RECT			rcButton ;

		/// <summary>
		/// The combo box button state. This parameter can be one of the following values :
		///<br/>
		///<code>
		/// <para>Value                      Meaning</para>
		/// <para>-----                      -------</para>
		/// <para>STATE_SYSTEM_NONE          The button exists and is not pressed.</para>
		/// <para>STATE_SYSTEM_INVISIBLE     There is no button.</para>
		/// <para>STATE_SYSTEM_PRESSED       The button is pressed.</para>
		/// </code>
		/// </summary>
		public STATE_SYSTEM_Constants	stateButton ;

		/// <summary>
		/// A handle to the combo box. 
		/// </summary>
		public IntPtr			hwndCombo ;

		/// <summary>
		/// A handle to the edit box. 
		/// </summary>
		public IntPtr			hwndItem ;

		/// <summary>
		/// A handle to the drop-down list. 
		/// </summary>
		public IntPtr			hwndList ;



		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized COMBOBOXINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized COMBOBOXINFO structure.</returns>
		public static implicit operator  COMBOBOXINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			COMBOBOXINFO		Result ;

			Result. cbSize		=  Macros. GETSTRUCTSIZE ( typeof ( COMBOBOXINFO ) ) ;
			Result. hwndCombo	=  IntPtr. Zero ;
			Result. hwndItem	=  IntPtr. Zero ;
			Result. hwndList	=  IntPtr. Zero ;
			Result. rcButton	=  Structure. Empty ;
			Result. rcItem		=  Structure. Empty ;
			Result. stateButton	=  0 ;

			return ( Result ) ;
		    }
	    }
    }
