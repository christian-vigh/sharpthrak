/**************************************************************************************************************

    NAME
        WinAPI/User32/G/GetComboBoxInfo.cs

    DESCRIPTION
        GetComboBoxInfo() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/22]     [Author : CV]
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
		# region Generic version
		/// <summary>
		/// Retrieves information about the specified combo box.
		/// </summary>
		/// <param name="hWnd">A handle to the combo box. </param>
		/// <param name="pcbi">A pointer to a COMBOBOXINFO structure that receives the information. You must set COMBOBOXINFO.cbSize before calling this function.</param>
		/// <returns>If the function succeeds, the return value is nonzero.</returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int	GetComboBoxInfo ( IntPtr  hWnd, ref COMBOBOXINFO  pcbi ) ;
		# endregion
	    }
    }