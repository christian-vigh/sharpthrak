/**************************************************************************************************************

    NAME
        WinAPI/Constants/G/GID.cs

    DESCRIPTION
        GID constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {
	# region GID_ constants
	/// <summary>
	/// The identifier of the gesture command.
	/// </summary>
	public enum GID_Constants : uint
	   {
		/// <summary>
		/// Zero value.
		/// </summary>
		GID_NONE			=  0,

		/// <summary>
		/// A gesture is starting.
		/// </summary>
		GID_BEGIN			=  1,

		/// <summary>
		/// A gesture is ending.	    
		/// </summary>
		GID_END				=  2,

		/// <summary>
		/// The Pan gesture.
		/// <para>
		/// The GID_PAN gesture has built-in inertia. At the end of a pan gesture, additional pan gesture messages are created by the operating system. 
		/// </para>
		/// </summary>
		GID_PAN				=  4,

		/// <summary>
		/// The press and tap gesture.
		/// </summary>
		GID_PRESSANDTAP			=  7,

		/// <summary>
		/// The rotation gesture.
		/// </summary>
		GID_ROTATE			=  5,

		/// <summary>
		/// The two-finger tap gesture.
		/// </summary>
		GID_TWOFINGERTAP		=  6,

		/// <summary>
		/// The Zoom gesture.
		/// </summary>
		GID_ZOOM			=  3,
	    }
	# endregion
    }