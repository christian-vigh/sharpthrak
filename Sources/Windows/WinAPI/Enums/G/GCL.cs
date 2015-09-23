/**************************************************************************************************************

    NAME
        WinAPI/Constants/G/GCL.cs

    DESCRIPTION
        Window class long constants.

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

	#  region Window class long constants
	/// <summary>
	/// zero-based offset to the Window class long value to be retrieved. 
	/// </summary>
	public enum  GCL_Constants	: int
	   {
		/// <summary>
		/// Retrieves a handle to the background brush associated with the class. Same as GCL_HBRBACKGROUND.
		/// </summary>
		GCLP_HBRBACKGROUND  		=  (-10),

		/// <summary>
		/// Retrieves a handle to the cursor associated with the class. Same as GCL_HCURSOR.
		/// </summary>
		GCLP_HCURSOR        		=  (-12),

		/// <summary>
		/// Retrieves a handle to the icon associated with the class. Same as GCL_HICON.
		/// </summary>
		GCLP_HICON          		=  (-14),

		/// <summary>
		/// Retrieves a handle to the small icon associated with the class. Same as GCL_ICONSM.
		/// </summary>
		GCLP_HICONSM        		=  (-34),

		/// <summary>
		/// Retrieves a handle to the module that registered the class. Same as GCL_MODULE.
		/// </summary>
		GCLP_HMODULE        		=  (-16),

		/// <summary>
		/// Retrieves the address of the menu name string. The string identifies the menu resource associated with the class.
		/// Same as GCL_MENUNAME.
		/// </summary>
		GCLP_MENUNAME       		=  (-8),

		/// <summary>
		/// Retrieves the address of the window procedure, or a handle representing the address of the window procedure. 
		/// <para>
		/// You must use the CallWindowProc function to call the window procedure. 
		/// </para>
		/// <para>
		/// Same as GCL_WNDPROC.
		/// </para>
		/// </summary>
		GCLP_WNDPROC        		=  (-24),

		/// <summary>
		/// Retrieves the size, in bytes, of the extra memory associated with the class.
		/// </summary>
		GCL_CBCLSEXTRA      		=  (-20),

		/// <summary>
		/// Retrieves the size, in bytes, of the extra window memory associated with each window in the class. 
		/// <para>
		/// For information on how to access this memory, see GetWindowLong.
		/// </para>
		/// </summary>
		GCL_CBWNDEXTRA      		=  (-18),

		/// <summary>
		/// Retrieves a handle to the background brush associated with the class. Same as GCLP_HBRBACKGROUND on 64-bit platforms.
		/// </summary>
		GCL_HBRBACKGROUND   		=  (-10),

		/// <summary>
		/// Retrieves a handle to the cursor associated with the class. Same as GCLP_HCURSOR on 64-bit platforms.
		/// </summary>
		GCL_HCURSOR         		=  (-12),

		/// <summary>
		/// Retrieves a handle to the icon associated with the class. Same as GCLP_HICON on 64-bit platforms.
		/// </summary>
		GCL_HICON           		=  (-14),

		/// <summary>
		/// Retrieves a handle to the small icon associated with the class. Same as GCL_ICONSM on 64-bit platforms.
		/// </summary>
		GCL_HICONSM         		=  (-34),

		/// <summary>
		/// Retrieves a handle to the module that registered the class. Same as GCLP_HMODULE on 64-bit platforms.
		/// </summary>
		GCL_HMODULE         		=  (-16),

		/// <summary>
		/// Retrieves the address of the menu name string. The string identifies the menu resource associated with the class.
		/// Same as GCLP_MENUNAME on 64-bit platforms.
		/// </summary>
		GCL_MENUNAME        		=  (-8),

		/// <summary>
		/// Retrieves the window-class style bits.
		/// </summary>
		GCL_STYLE           		=  (-26),

		/// <summary>
		/// Retrieves the address of the window procedure, or a handle representing the address of the window procedure. 
		/// <para>
		/// You must use the CallWindowProc function to call the window procedure. 
		/// </para>
		/// <para>
		/// Same as GCLP_WNDPROC on 64-bit platforms.
		/// </para>
		/// </summary>
		GCL_WNDPROC         		=  (-24),

		/// <summary>
		/// Retrieves an ATOM value that uniquely identifies the window class. This is the same atom that the RegisterClassEx function returns.
		/// </summary>
		GCW_ATOM            		=  (-32),
	    }
	# endregion
    }