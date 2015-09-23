/**************************************************************************************************************

    NAME
        WinAPI/Functions/G/GetKeyboardType.cs

    DESCRIPTION
        GetKeyboardType() Windows function.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/14]     [Author : CV]
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
		/// Retrieves information about the current keyboard.
		/// </summary>
		/// <param name="nTypeFlag">
		/// The type of keyboard information to be retrieved. This parameter can be one of the following values :
		/// <para>. 0 : Keyboard type</para>
		/// <para>. 1 : Keyboard subtype</para>
		/// <para>. 2 : The number of function keys on the keyboard</para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value specifies the requested information.
		/// <br/>
		/// <para>
		/// If the function fails and nTypeFlag is not one, the return value is zero; zero is a valid return value when nTypeFlag is one 
		/// (keyboard subtype). To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The type may be one of the following values :
		/// <br/>
		/// <para>. 1 : IBM PC/XT or compatible (83-key) keyboard</para>
		/// <para>. 2 : Olivetti "ICO" (102-key) keyboard</para>
		/// <para>. 3 : IBM PC/AT (84-key) or similar keyboard</para>
		/// <para>. 4 : IBM enhanced (101- or 102-key) keyboard</para>
		/// <para>. 5 : Nokia 1050 and similar keyboards</para>
		/// <para>. 6 : Nokia 9140 and similar keyboards</para>
		/// <para>. 7 : Japanese keyboard</para>
		/// <br/>
		/// <para>
		/// The subtype is an original equipment manufacturer (OEM)-dependent value.
		/// <br/>
		/// <para>
		/// The application can also determine the number of function keys on a keyboard from the keyboard type. Following are the number 
		/// of function keys for each keyboard type :
		/// </para>
		/// <para>1 : 10</para>
		/// <para>2 : 12 (sometimes 18)</para>
		/// <para>3 : 10</para>
		/// <para>4 : 12</para>
		/// <para>5 : 10</para>
		/// <para>6 : 24</para>
		/// <para>7 : Hardware dependent and specified by the OEM</para>
		/// <br/>
		/// <para>
		/// When a single USB keyboard is connected to the computer, this function returns the code 81.
		/// </para>
		/// </remarks>
		[DllImport ( "User32.dll", SetLastError = true, CharSet = CharSet. Auto )]
		public static extern int 	GetKeyboardType ( int  nTypeFlag ) ;
		# endregion
	    }
    }