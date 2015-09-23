/**************************************************************************************************************

    NAME
        WinAPI/Enums/G/GCS.cs

    DESCRIPTION
        GCS constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/31]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region GCS_ constants
	/// <summary>
	/// IME composition string values.
	/// </summary>
	public enum GCS_Constants : int
	   {
		/// <summary>
		/// Retrieve or update the attribute of the composition string.
		/// </summary>
		GCS_COMPATTR                    	=  0x0010,

		/// <summary>
		/// Retrieve or update clause information of the composition string.
		/// </summary>
		GCS_COMPCLAUSE                  	=  0x0020,

		/// <summary>
		/// Retrieve or update the attributes of the reading string of the current composition.
		/// </summary>
		GCS_COMPREADATTR                	=  0x0002,

		/// <summary>
		/// Retrieve or update the clause information of the reading string of the composition string.
		/// </summary>
		GCS_COMPREADCLAUSE              	=  0x0004,

		/// <summary>
		/// Retrieve or update the reading string of the current composition.
		/// </summary>
		GCS_COMPREADSTR                 	=  0x0001,

		/// <summary>
		/// Retrieve or update the current composition string.
		/// </summary>
		GCS_COMPSTR                     	=  0x0008,

		/// <summary>
		/// Retrieve or update the cursor position in composition string.
		/// </summary>
		GCS_CURSORPOS                   	=  0x0080,

		/// <summary>
		/// Retrieve or update the starting position of any changes in composition string.
		/// </summary>
		GCS_DELTASTART                  	=  0x0100,

		/// <summary>
		/// Retrieve or update clause information of the result string.
		/// </summary>
		GCS_RESULTCLAUSE                	=  0x1000,	    

		/// <summary>
		/// Retrieve or update clause information of the reading string.
		/// </summary>
		GCS_RESULTREADCLAUSE            	=  0x0400,

		/// <summary>
		/// Retrieve or update the reading string.
		/// </summary>
		GCS_RESULTREADSTR               	=  0x0200,

		/// <summary>
		/// Retrieve or update the string of the composition result.
		/// </summary>
		GCS_RESULTSTR                   	=  0x0800,

		/// <summary>
		/// Insert the wParam composition character at the current insertion point. 
		/// An application should display the composition character if it processes this message.
		/// </summary>
		CS_INSERTCHAR				=  0x2000,

		/// <summary>
		/// Do not move the caret position as a result of processing the message. For example, if an IME specifies a combination of CS_INSERTCHAR and CS_NOMOVECARET, 
		/// the application should insert the specified character at the current caret position but should not move the caret to the next position. 
		/// A subsequent WM_IME_COMPOSITION message with GCS_RESULTSTR will replace this character.
		/// </summary>
		CS_NOMOVECARET				=  0x4000,

		/// <summary>
		///  Zero value.
		/// </summary>
		GCS_NONE				=  0x0000
	    }
	# endregion
    }