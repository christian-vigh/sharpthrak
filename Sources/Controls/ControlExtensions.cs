/**************************************************************************************************************

    NAME
	ControlExtensions.cs

    DESCRIPTION
	Extension methods for classes inheriting from Control.

    AUTHOR
	Christian Vigh, 12/2015.

    HISTORY
	[Version : 1.0]		[Date : 2015/12/23]     [Author : CV]
		Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Reflection ;
using   System. Runtime. InteropServices ;
using	System. Text ;
using	System. Windows. Forms ;


namespace Thrak. Forms
   {
	public static class ControlExtensions
	   {
		[DllImport ( "user32.dll", EntryPoint = "LockWindowUpdate" )]
		static extern bool  WinLockWindowUpdate		( IntPtr  hWndLock ) ;


		/// <summary>
		/// Locks window update for the specified control.
		/// </summary>
		/// <param name="lock_update">Indicates whether locking or unlocking should occur.</param>
		public static void  LockWindowUpdate ( this Control  ctrl, bool  lock_update = true )
		   {
			if  ( lock_update )
				WinLockWindowUpdate ( ctrl. Handle ) ;
			else
				WinLockWindowUpdate ( IntPtr. Zero ) ;
		    }

		/// <summary>
		/// Gets the DoubleBuffering property value of a control.
		/// </summary>
		public static bool  GetDoubleBuffering ( this Control  ctrl )
		   {
			object	value	=  ctrl
						.GetType ( )
						.GetProperty ( "DoubleBuffered", BindingFlags. Instance | BindingFlags. NonPublic )
						.GetValue ( ctrl, null ) ;

			
			return ( ( bool ) value ) ;
		    }


		/// <summary>
		/// Sets the DoubleBuffering property value of a control. 
		/// </summary>
		public static void  SetDoubleBuffering ( this Control  ctrl, bool  value )
		   {
			ctrl
				.GetType ( )
				.GetProperty ( "DoubleBuffered", BindingFlags. Instance | BindingFlags. NonPublic )
				.SetValue ( ctrl, value, null ) ;
		    }
	    }
    }
