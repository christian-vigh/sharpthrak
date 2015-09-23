/**************************************************************************************************************

    NAME
        WinAPI/User32/S/SetCursor.cs

    DESCRIPTION
        SetCursor() Windows function.

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
		/// Sets the cursor shape. 
		/// </summary>
		/// <param name="hCursor">
		/// A handle to the cursor. The cursor must have been created by the CreateCursor function or loaded by the LoadCursor or LoadImage function. 
		/// If this parameter is NULL, the cursor is removed from the screen.
		/// </param>
		/// <returns>
		/// The return value is the handle to the previous cursor, if there was one. 
		/// <para>
		/// If there was no previous cursor, the return value is NULL. 
		/// </para>
		/// </returns>
		/// <remarks>
		/// The cursor is set only if the new cursor is different from the previous cursor; otherwise, the function returns immediately. 
		/// <br/>
		/// <para>
		/// The cursor is a shared resource. A window should set the cursor shape only when the cursor is in its client area or when the window 
		/// is capturing mouse input. In systems without a mouse, the window should restore the previous cursor before the cursor leaves 
		/// the client area or before it relinquishes control to another window. 
		/// </para>
		/// <br/>
		/// <para>
		/// If your application must set the cursor while it is in a window, make sure the class cursor for the specified window's class 
		/// is set to NULL. If the class cursor is not NULL, the system restores the class cursor each time the mouse is moved. 
		/// </para>
		/// <br/>
		/// <para>
		/// The cursor is not shown on the screen if the internal cursor display count is less than zero. This occurs if the application uses 
		/// the ShowCursor function to hide the cursor more times than to show the cursor. 
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		public static extern IntPtr 	SetCursor ( IntPtr  hCursor ) ;
		# endregion
	    }
    }