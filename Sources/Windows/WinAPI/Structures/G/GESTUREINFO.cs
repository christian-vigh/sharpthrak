/**************************************************************************************************************

    NAME
        WinAPI/Structure/G/GESTUREINFO.cs

    DESCRIPTION
        GESTUREINFO structure.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/29]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;
using   System. Text ;

using	Thrak. WinAPI ;
using	Thrak. WinAPI. Enums ;


namespace Thrak. WinAPI. Structures
   {
	/// <summary>
	/// Stores information about a gesture.
	/// </summary>
	/// <remarks>
	/// The HIDWORD of the ullArguments member is always 0, with the following exceptions :
	/// <para>• For GID_PAN, it is 0 except when there is inertia. When GF_INERTIA is set, the HIDWORD is an inertia vector (two 16-bit values).</para>
	/// <para>• For GID_PRESSANDTAP, it is the distance between the two points.</para>
	/// <br/>
	/// <para>
	/// Note   Most applications should ignore the GID_BEGIN and GID_END messages and pass them to DefWindowProc. 
	/// These messages are used by the default gesture handler. Application behavior is undefined when the GID_BEGIN and GID_END messages are consumed by 
	/// a third-party application.
	/// </para>
	/// </remarks>
 	[StructLayout ( LayoutKind. Sequential ) ]
	public struct  GESTUREINFO
	   {
		/// <summary>
		/// The size of the structure, in bytes. The caller must set this to sizeof(GESTUREINFO).
		/// </summary>
		public uint		cbSize ;

		/// <summary>
		/// The state of the gesture. 
		/// </summary>
		public GF_Constants	dwFlags ;

		/// <summary>
		/// The identifier of the gesture command.
		/// </summary>
		public GID_Constants	dwID ;

		/// <summary>
		/// A handle to the window that is targeted by this gesture.
		/// </summary>
		public IntPtr		hwndTarget ;

		/// <summary>
		/// A POINTS structure containing the coordinates associated with the gesture. These coordinates are always relative to the origin of the screen.
		/// </summary>
		public POINTS		ptsLocation ;

		/// <summary>
		/// An internally used identifier for the structure.
		/// </summary>
		public uint		dwInstanceID ;

		/// <summary>
		/// An internally used identifier for the sequence.
		/// </summary>
		public uint		dwSequenceID ;

		/// <summary>
		/// A 64-bit unsigned integer that contains the arguments for gestures that fit into 8 bytes. 
		/// </summary>
		public ulong		ullArguments ;

		/// <summary>
		/// The size, in bytes, of extra arguments that accompany this gesture.
		/// </summary>
		public uint		cbExtraArgs ;


		/// <summary>
		/// Converts a WinAPI.Structure object into an initialized GESTUREINFO structure. This is only syntactical sugar to zero out a structure
		/// using the Structure.Empty property.
		/// </summary>
		/// <returns>An initialized GESTUREINFO structure.</returns>
		public static implicit operator  GESTUREINFO ( Thrak. WinAPI. Structures. Structure  value )
		   {
			GESTUREINFO		Result ;

			Result. cbExtraArgs		=  0 ;
			Result. cbSize			=  Macros. GETSTRUCTSIZE ( typeof ( GESTUREINFO ) ) ;
			Result. dwFlags			=  GF_Constants. GF_NONE ;
			Result. dwID			=  GID_Constants. GID_NONE ;
			Result. dwInstanceID		=  0 ;
			Result. dwSequenceID		=  0 ;
			Result. hwndTarget		=  IntPtr. Zero ;
			Result. ptsLocation		=  Structure. Empty ;
			Result. ullArguments		=  0 ;

			return ( Result ) ;
		    }
	    }
    }