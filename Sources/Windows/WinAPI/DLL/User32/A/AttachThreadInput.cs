/**************************************************************************************************************

    NAME
        WinAPI/User32/A/AttachThreadInput.cs

    DESCRIPTION
        AttachThreadInput() Windows function.

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
using	Thrak. WinAPI. Structures ;


namespace Thrak. WinAPI. DLL
   {
	public static partial class User32
	   {
		# region Generic version.
		/// <summary>
		/// Attaches or detaches the input processing mechanism of one thread to that of another thread.
		/// </summary>
		/// <param name="idAttach">The identifier of the thread to be attached to another thread. The thread to be attached cannot be a system thread.</param>
		/// <param name="idAttachTo">
		/// The identifier of the thread to which idAttach will be attached. This thread cannot be a system thread.
		/// <para>
		/// A thread cannot attach to itself. Therefore, idAttachTo cannot equal idAttach.
		/// </para> 
		/// </param>
		/// <param name="fAttach">If this parameter is TRUE, the two threads are attached. If the parameter is FALSE, the threads are detached.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <br/>
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </para>
		/// <br/>
		/// <para>
		/// Windows Server 2003 and Windows XP:  There is no extended error information; do not call GetLastError. This behavior changed as of Windows Vista.
		/// </para>
		/// </returns>
		/// <remarks>
		/// Windows created in different threads typically process input independently of each other. That is, they have their own input states 
		/// (focus, active, capture windows, key state, queue status, and so on), and their input processing is not synchronized with the input processing 
		/// of other threads. By using the AttachThreadInput function, a thread can attach its input processing mechanism to another thread. 
		/// Keyboard and mouse events received by both threads are processed by the thread specified by the idAttachTo parameter until the threads are detached 
		/// by calling AttachThreadInput a second time and specifying FALSE for the fAttach parameter. This also allows threads to share their input states, 
		/// so they can call the SetFocus function to set the keyboard focus to a window of a different thread. This also allows threads to get key-state information. 
		/// <br/>
		/// <para>
		/// The AttachThreadInput function fails if either of the specified threads does not have a message queue. The system creates a thread's message queue 
		/// when the thread makes its first call to one of the USER or GDI functions. The AttachThreadInput function also fails if a journal record hook is installed. 
		/// Journal record hooks attach all input queues together.
		/// </para>
		/// <br/>
		/// <para>
		/// Note that key state, which can be ascertained by calls to the GetKeyState or GetKeyboardState function, is reset after a call to AttachThreadInput. 
		/// You cannot attach a thread to a thread in another desktop.
		/// </para>
		/// </remarks>
		[DllImport ( USER32, SetLastError = true, CharSet = CharSet. Auto )]
		[return: MarshalAs ( UnmanagedType. Bool )]
		public static extern bool 	AttachThreadInput ( IntPtr  idAttach, IntPtr  idAttachTo, [MarshalAs ( UnmanagedType. Bool )]  bool  fAttach ) ;
		# endregion
	    }
    }