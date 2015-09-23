/**************************************************************************************************************

    NAME
        WinAPI/User32/D/DestroyAcceleratorTable.cs

    DESCRIPTION
        DestroyAcceleratorTable() Windows function.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/26]     [Author : CV]
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
		/// Destroys an accelerator table.
		/// </summary>
		/// <param name="hAccel">
		/// A handle to the accelerator table to be destroyed. This handle must have been created by a call to the CreateAcceleratorTable or LoadAccelerators function. 
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. However, if the table has been loaded more than one call to LoadAccelerators, 
		/// the function will return a nonzero value only when DestroyAcceleratorTable has been called an equal number of times.
		/// <para>
		/// If the function fails, the return value is zero. 
		/// </para>
		/// </returns>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	DestroyAcceleratorTable ( IntPtr  hAccel ) ;
		# endregion
	    }
    }