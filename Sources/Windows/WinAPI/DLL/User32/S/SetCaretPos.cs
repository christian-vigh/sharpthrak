/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetCaretPos.cs

    DESCRIPTION
        SetCaretPos() Windows function.

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
		/// Moves the caret to the specified coordinates. If the window that owns the caret was created with the CS_OWNDC class style, 
		/// then the specified coordinates are subject to the mapping mode of the device context associated with that window. 
		/// </summary>
		/// <param name="X">The new x-coordinate of the caret. </param>
		/// <param name="Y">The new y-coordinate of the caret. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError. </para>
		/// </returns>
		/// <remarks>
		/// SetCaretPos moves the caret whether the caret is hidden. 
		/// <br/>
		/// <para>
		/// The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. 
		/// The window should destroy the caret before losing the keyboard focus or becoming inactive. 
		/// A window can set the caret position only if it owns the caret. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	SetCaretPos ( int  X, int  Y ) ;
		# endregion
	    }
    }