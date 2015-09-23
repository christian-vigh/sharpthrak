/**************************************************************************************************************

    NAME
        WinAPI/Constants/G/GWL.cs

    DESCRIPTION
        Window long constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	#  region Window long constants
	/// <summary>
	/// zero-based offset to the Window long value to be retrieved. 
	/// Valid values are in the range zero through the number of bytes of extra window memory, minus the size of an integer.
	/// </summary>
	public enum  GWL_Constants	: int
	   {
		/// <summary>
		/// Retrieves the extended window styles. 
		/// </summary>
		GWL_EXSTYLE			=  (-20),

		/// <summary>
		/// Retrieves a handle to the application instance.
		/// </summary>
		GWL_HINSTANCE			=  (-6),

		/// <summary>
		/// Retrieves a handle to the parent window, if there is one.
		/// </summary>
		GWL_HWNDPARENT			=  (-8),

		/// <summary>
		/// Retrieves the identifier of the window.
		/// </summary>
		GWL_ID				=  (-12),

		/// <summary>
		/// Retrieves the window styles.
		/// </summary>
		GWL_STYLE			=  (-16),

		/// <summary>
		/// Retrieves the user data associated with the window. This data is intended for use by the application that created the window. Its value is initially zero.
		/// </summary>
		GWL_USERDATA			=  (-21),

		/// <summary>
		/// Retrieves the pointer to the window procedure, or a handle representing the pointer to the window procedure. 
		/// <para>
		/// You must use the CallWindowProc function to call the window procedure.
		/// </para>
		/// </summary>
		GWL_WNDPROC			=  (-4),

		/// <summary>
		/// Retrieves a handle to the application instance. Same as GWL_INSTANCE but used on 64-bits platforms.
		/// </summary>
		GWLP_HINSTANCE			=  (-6),

		/// <summary>
		/// Retrieves a handle to the parent window, if there is one. Same as GWL_HWNDPARENT but used on 64-bits platforms.
		/// </summary>
		GWLP_HWNDPARENT			=  (-8),

		/// <summary>
		/// Retrieves the identifier of the window. Same as GWL_ID but used on 64-bits platforms.
		/// </summary>
		GWLP_ID				=  (-12),

		/// <summary>
		/// Retrieves the user data associated with the window. This data is intended for use by the application that created the window. Its value is initially zero.
		/// <para>
		/// Same as GWL_USERDATA but used on 64-bits platforms.
		/// </para>
		/// </summary>
		GWLP_USERDATA			=  (-21),

		/// <summary>
		/// Retrieves the pointer to the window procedure, or a handle representing the pointer to the window procedure. 
		/// <para>
		/// You must use the CallWindowProc function to call the window procedure.
		/// </para>
		/// <para>
		/// Same as GWL_WNDPROC but used on 64-bits platforms.
		/// </para>
		/// </summary>
		GWLP_WNDPROC			=  (-4),
	    }
	# endregion
    }