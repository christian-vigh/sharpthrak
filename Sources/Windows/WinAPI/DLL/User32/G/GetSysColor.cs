/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetSysColor.cs

    DESCRIPTION
        GetSysColor() Windows function.

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
using	Thrak. WinAPI. Enums ;
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Retrieves the current color of the specified display element. Display elements are the parts of a window and the display 
		/// that appear on the system display screen.
		/// </summary>
		/// <param name="nIndex">
		/// The display element whose color is to be retrieved. This parameter can be one of the COLOR_Constants values.
		/// </param>
		/// <returns>
		/// The function returns the red, green, blue (RGB) color value of the given element.
		/// <br/>
		/// <para>
		/// If the nIndex parameter is out of range, the return value is zero. Because zero is also a valid RGB value, you cannot use 
		/// GetSysColor to determine whether a system color is supported by the current platform. 
		/// Instead, use the GetSysColorBrush function, which returns NULL if the color is not supported.
		/// </para>
		/// </returns>
		/// <remarks>
		/// To display the component of the RGB value, use the GetRValue, GetGValue, and GetBValue macros.
		/// <br/>
		/// <para>
		/// System colors for monochrome displays are usually interpreted as shades of gray.
		/// </para>
		/// <br/>
		/// <para>
		/// To paint with a system color brush, an application should use GetSysColorBrush(nIndex), instead of CreateSolidBrush(GetSysColor(nIndex)), 
		/// because GetSysColorBrush returns a cached brush, instead of allocating a new one.
		/// </para>
		/// <br/>
		/// <para>
		/// Color is an important visual element of most user interfaces. For guidelines about using color in your applications, see Color.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern uint 	GetSysColor ( COLOR_Constants  nIndex ) ;
		# endregion
	    }
    }