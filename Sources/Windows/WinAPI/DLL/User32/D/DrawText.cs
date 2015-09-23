/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DrawText.cs

    DESCRIPTION
        DrawText() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/02]     [Author : CV]
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
		/// The DrawText function draws formatted text in the specified rectangle. It formats the text according to the specified method 
		/// (expanding tabs, justifying characters, breaking lines, and so forth).
		/// <br/>
		/// <para>To specify additional formatting options, use the DrawTextEx function.</para>
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lpchText">
		/// A pointer to the string that specifies the text to be drawn. If the nCount parameter is -1, the string must be null-terminated.
		/// <br/>
		/// <para>
		/// If uFormat includes DT_MODIFYSTRING, the function could add up to four additional characters to this string. 
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </para>
		/// </param>
		/// <param name="nCount">
		/// The length, in characters, of the string. If nCount is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string 
		/// and DrawText computes the character count automatically.
		/// </param>
		/// <param name="lpRect">
		/// A pointer to a RECT structure that contains the rectangle (in logical coordinates) in which the text is to be formatted.
		/// </param>
		/// <param name="uFormat">
		/// The method of formatting the text. This parameter can be one or more of the DT_Constants values.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the height of the text in logical units. If DT_VCENTER or DT_BOTTOM is specified, 
		/// the return value is the offset from lpRect->top to the bottom of the drawn text.
		/// <br/>
		/// <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		/// The DrawText function uses the device context's selected font, text color, and background color to draw the text. 
		/// Unless the DT_NOCLIP format is used, DrawText clips the text so that it does not appear outside the specified rectangle. 
		/// Note that text with significant overhang may be clipped, for example, an initial "W" in the text string or text that is in italics. 
		/// All formatting is assumed to have multiple lines unless the DT_SINGLELINE format is specified.
		/// <br/>
		/// <para>
		/// If the selected font is too large for the specified rectangle, the DrawText function does not attempt to substitute a smaller font.
		/// </para>
		/// <br/>
		/// <para>
		/// The text alignment mode for the device context must include the TA_LEFT, TA_TOP, and TA_NOUPDATECP flags.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	DrawText ( IntPtr  hDC, String  lpchText, int  nCount, ref RECT  lpRect, DT_Constants  uFormat ) ;
		# endregion
	    }
    }