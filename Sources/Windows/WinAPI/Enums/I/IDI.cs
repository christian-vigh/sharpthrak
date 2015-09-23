/**************************************************************************************************************

    NAME
        WinAPI/Constants/I/IDI.cs

    DESCRIPTION
        Stocked icons resource identifiers.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/23]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region IDI_ cursor ids
	/// <summary>
	/// Stocked icons resource identifiers.
	/// </summary>
	public enum IDI_Constants		:  int
	   {
		/// <summary>
		/// Application icon.
		/// </summary>
		IDI_APPLICATION     		=  32512,

		/// <summary>
		/// Asterisk icon.
		/// </summary>
		IDI_ASTERISK        		=  32516,

		/// <summary>
		/// Error icon. Same as IDI_HAND.
		/// </summary>
		IDI_ERROR       		=  IDI_HAND,

		/// <summary>
		/// Exclamation point icon.
		/// </summary>
		IDI_EXCLAMATION     		=  32515,

		/// <summary>
		/// Stop sign icon.
		/// </summary>
		IDI_HAND            		=  32513,

		/// <summary>
		/// Information icon. Same as IDI_ASTERISK.
		/// </summary>
		IDI_INFORMATION 		=  IDI_ASTERISK,

		/// <summary>
		/// Question-mark icon.
		/// </summary>
		IDI_QUESTION        		=  32514,

		/// <summary>
		/// Shield icon.
		/// </summary>
		IDI_SHIELD          		=  32518,

		/// <summary>
		/// Question icon. Same as IDI_EXCLAMATION.
		/// </summary>
		IDI_WARNING     		=  IDI_EXCLAMATION,

		/// <summary>
		/// Application icon.
		/// </summary>
		IDI_WINLOGO         		=  32517
	    }
	# endregion
    }
