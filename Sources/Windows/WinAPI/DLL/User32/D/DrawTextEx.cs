/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DrawTextEx.cs

    DESCRIPTION
        DrawTextEx() Windows function.

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
		/// The DrawTextEx function draws formatted text in the specified rectangle.
		/// </summary>
		/// <param name="hDC">A handle to the device context in which to draw.</param>
		/// <param name="lpchText">
		/// A pointer to the string that contains the text to draw. If the cchText parameter is -1, the string must be null-terminated.
		/// <para>
		/// If dwDTFormat includes DT_MODIFYSTRING, the function could add up to four additional characters to this string. 
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </para>
		/// </param>
		/// <param name="cchText">
		/// The length of the string pointed to by lpchText. If cchText is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string 
		/// and DrawTextEx computes the character count automatically.
		/// </param>
		/// <param name="lprc">
		/// A pointer to a RECT structure that contains the rectangle, in logical coordinates, in which the text is to be formatted.
		/// </param>
		/// <param name="dwDTFormat">The formatting options. This parameter can be one or more of the DT_Constants values.</param>
		/// <param name="lpDTParams">
		/// A pointer to a DRAWTEXTPARAMS structure that specifies additional formatting options. This parameter can be NULL.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the text height in logical units. 
		/// If DT_VCENTER or DT_BOTTOM is specified, the return value is the offset from lprc->top to the bottom of the drawn text.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The DrawTextEx function supports only fonts whose escapement and orientation are both zero.
		/// <br/>
		/// <para>
		/// The text alignment mode for the device context must include the TA_LEFT, TA_TOP, and TA_NOUPDATECP flags.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern int 	DrawTextEx ( IntPtr  hDC, String  lpchText, int  cchText, ref RECT  lprc, DT_Constants  dwDTFormat,
								ref DRAWTEXTPARAMS  lpDTParams ) ;
	    }
	    # endregion
    }