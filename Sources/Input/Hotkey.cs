/**************************************************************************************************************

    NAME
        Hotkey.cs

    DESCRIPTION
        Defines a hotkey.

    AUTHOR
        Christian Vigh, 09/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/09/15]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text. RegularExpressions ;
using	System. Windows. Forms ;


namespace Thrak. Input
   {
	/// <summary>
	/// The Hotkey class holds information about a hotkey along with its modifier keys (Control, Alt, Shift).
	/// </summary>
	public class Hotkey
	   {
		# region Static data

		/// <summary>
		/// Authorized modifier keys.
		/// </summary>
		private static readonly Keys	AuthorizedModifiers	=  Keys. Alt | Keys. Control | Keys. Shift ;

		# region Authorized hotkeys
		/// <summary>
		/// Available hotkeys, to be used in conjunction with modifiers.
		/// <para>Each element is an array of 4 items whose meaning is the following :</para>
		/// <para>- Index 0 : A value of type Keys, that specifies the keycode for the hotkey.</para>
		/// <para>- Index 1 : The string representation of the keycode.</para>
		/// <para>- Index 2 : The list of key modifiers authorized for this keycode. Only Shift, Control and Alt modifiers are allowed.</para>
		/// <para>- Index 3 : A boolean value specifying whether the hotkey can have no modifier at all (true) or must have at least one (false).</para>
		/// </summary>
		private static readonly Object [,]		AuthorizedKeys		=
		   {
			// Letters
			{ Keys. A		, "A"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. B		, "B"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. C		, "C"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D		, "D"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. E		, "E"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F		, "F"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. G		, "G"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. H		, "H"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. I		, "I"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. J		, "J"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. K		, "K"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. L		, "L"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. M		, "M"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. N		, "N"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. O		, "O"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. P		, "P"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Q		, "Q"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. R		, "R"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. S		, "S"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. T		, "T"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. U		, "U"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. V		, "V"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. W		, "W"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. X		, "X"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Y		, "Y"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Z		, "Z"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			
			// Digits
			{ Keys. D0		, "0"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D1		, "1"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D2		, "2"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D3		, "3"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D4		, "4"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D5		, "5"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D6		, "6"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D7		, "7"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D8		, "8"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. D9		, "9"		, Keys. Alt | Keys. Control | Keys. Shift, true },

			// Function keys
			{ Keys. F1		, "F1"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F2		, "F2"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F3		, "F3"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F4		, "F4"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F5		, "F5"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F6		, "F6"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F7		, "F7"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F8		, "F8"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F9		, "F9"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F10		, "F10"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F11		, "F11"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F12		, "F12"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F13		, "F13"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F14		, "F14"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F15		, "F15"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F16		, "F16"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F17		, "F17"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F18		, "F18"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F19		, "F19"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F20		, "F20"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F21		, "F21"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F22		, "F22"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F23		, "F23"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. F24		, "F24"		, Keys. Alt | Keys. Control | Keys. Shift, true },

			// Numeric keypad
			{ Keys. Add		, "+"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Subtract	, "-"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Multiply	, "*"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Divide		, "/"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Decimal		, "."		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad0		, "Num0"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad1		, "Num1"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad2		, "Num2"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad3		, "Num3"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad4		, "Num4"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad5		, "Num5"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad6		, "Num6"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad7		, "Num7"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad8		, "Num8"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad9		, "Num9"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad0		, "Numpad0"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad1		, "Numpad1"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad2		, "Numpad2"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad3		, "Numpad3"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad4		, "Numpad4"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad5		, "Numpad5"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad6		, "Numpad6"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad7		, "Numpad7"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad8		, "Numpad8"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. NumPad9		, "Numpad9"	, Keys. Alt | Keys. Control | Keys. Shift, true },

			// Direction and misc keys
			{ Keys. Back		, "BKSP"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Delete		, "DEL"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Down		, "DOWN"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. End		, "END"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Return		, "ENTER"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Escape		, "ESC"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Home		, "HOME"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Insert		, "INS"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Left		, "LEFT"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. PageDown	, "PGDN"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. PageUp		, "PGUP"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Right		, "RIGHT"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Space		, "SPACE"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Tab		, "TAB"		, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Up		, "UP"		, Keys. Alt | Keys. Control | Keys. Shift, true },

			// OEM keys
			{ Keys. Oem1		, "OEM1"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem2		, "OEM2"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem3		, "OEM3"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem4		, "OEM4"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem5		, "OEM5"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem6		, "OEM6"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem7		, "OEM7"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem8		, "OEM8"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oem102		, "OEM102"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oemcomma	, "OEMCOMMA"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. OemPeriod	, "OEMPERIOD"	, Keys. Alt | Keys. Control | Keys. Shift, true },
			{ Keys. Oemplus		, "OEMPLUS"	, Keys. Alt | Keys. Control | Keys. Shift, true }
		    } ;
		# endregion

		# endregion


		# region Private data members
		private Keys				p_Modifiers		=  Keys. None ;		// Modifiers
		private Keys				p_Keycode 		=  Keys. None ;		// Hotkey
		private String				p_Text			=  "" ;			// KeyboardShortcut text
		# endregion


		# region Constructors
		/// <summary>
		/// Default constructor. Builds an empty Hotkey object.
		/// </summary>
		public Hotkey ( )
		   { }


		/// <summary>
		/// Builds a Hotkey object using the specified value of type Keys.
		/// </summary>
		/// <param name="value">Hotkey value, including the modifiers and keycode.</param>
		public  Hotkey  ( Keys  value ) :
				this ( value & Keys. Modifiers, value & Keys. KeyCode )
		   { }


		/// <summary>
		/// Builds a Hotkey object using the specified modifiers and key code.
		/// </summary>
		/// <param name="modifiers">Hotkey modifiers. Only the Shift, Control and Alt modifiers are allowed.</param>
		/// <param name="keycode">Key code.</param>
		public Hotkey ( Keys  modifiers, Keys  keycode )
		   {
			if  ( keycode  ==  Keys. None ) 
				throw new ArgumentNullException ( "keycode" ) ;

			Initialize ( modifiers, keycode ) ;
		    }


		/// <summary>
		/// Builds a hotkey object from a string representation.
		/// </summary>
		/// <param name="hotkey">
		/// Hotkey value (example : "Ctrl+A", "Alt+Shift+B", "Shift+F1" etc.).
		/// <para>The separator between two hotkey elements can either be a "+" sign or a space.</para>
		/// <para>The string is not case sensitive.</para>
		/// </param>
		public Hotkey ( String  hotkey )
		   {
			if  ( hotkey  ==  null  ||  hotkey  ==  "" )
				throw new ArgumentNullException ( "hotkey" ) ;
				
			InitializeFromString ( hotkey ) ;
		    }
		# endregion


		# region Properties
		/// <summary>
		/// Gets the modifiers part of a hotkey (ie, the state of the shift, control and alt key associated with this keycode).
		/// </summary>
		public Keys  Modifiers 
		   {
			get { return ( p_Modifiers ) ; }
		    }


		/// <summary>
		/// Gets the keycode without any modifiers.
		/// </summary>
		public Keys  KeyCode
		   {
			get { return ( p_Keycode ) ; }
		    }


		/// <summary>
		/// Gets/sets the hotkey value, including the modifiers.
		/// </summary>
		public Keys  Key
		   {	
			get { return ( p_Keycode | p_Modifiers ) ; }
			set { Initialize ( value  &  Keys. Modifiers, value  &  Keys. KeyCode ) ; }
		    }
				

		/// <summary>
		/// Returns a string representation of this hotkey (such as : "Ctrl + F1").
		/// </summary>		
		public String  Text
		   {
			get { return ( p_Text ) ; }
			set { InitializeFromString ( value ) ; }
		    }
		# endregion


		# region Overridable methods
		/// <summary>
		/// Checks if an object is equal to this instance.
		/// </summary>
		/// <param name="obj">Other object to be compared to.</param>
		/// <returns>True if both objects are equal, false otherwise.</returns>
		public override bool Equals ( object  obj )
		   {
			if  ( obj  is  Hotkey )
			   {
				Hotkey		hk	=  ( Hotkey ) obj ;

				return ( p_Keycode  ==  hk. p_Keycode  &&  p_Modifiers  ==  hk. p_Modifiers ) ;
			    }
			else
				return ( false ) ;
		    }


		/// <summary>
		/// Returns the hash code of this object.
		/// </summary>
		public override int GetHashCode ( )
		   {
			return ( p_Text. GetHashCode ( ) ) ;
		    }


		/// <summary>
		/// Returns a string representation of this hotkey (such as : "Ctrl + F1").
		/// </summary>
		public override string ToString ( )
		   {
			return ( p_Text ) ;
		    }
		# endregion


		# region Public methods 
		/// <summary>
		/// Checks if a modifiers/keycode pair is an authorized hotkey.
		/// </summary>
		/// <param name="modifiers">Key modifiers.</param>
		/// <param name="keycode">Key code.</param>
		/// <returns>True if the modifier/keycode pairs are a valid hotkey, false otherwise.</returns>
		public static bool  IsValidHotkey ( Keys  modifiers, Keys  keycode )
		   {
			return 
			   (
				( ( modifiers  &  AuthorizedModifiers )  ==  modifiers )  &&
				( Hotkey. FindHotkey ( modifiers, keycode )  !=  -1 )
			    ) ;
		    }
		# endregion


		# region Operators

		# region Conversion operators
		/// <summary>
		/// Converts a hotkey string to a Hotkey object.
		/// </summary>
		public static implicit operator  Hotkey ( String  hotkey )
		   { return ( new Hotkey ( hotkey ) ) ; }


		/// <summary>
		/// Converts a Keys value, including the keycode and the key modifiers, into a Hotkey object.
		/// </summary>
		public static implicit operator  Hotkey ( Keys  key )
		   { return ( new Hotkey ( key ) ) ; }


		/// <summary>
		/// Converts a hotkey to its string representation.
		/// </summary>
		public static implicit operator  String ( Hotkey  hotkey )
		   { return ( hotkey. p_Text ) ; }


		/// <summary>
		/// Converts a hotkey to a value of type Keys.
		/// </summary>
		public static implicit operator  Keys ( Hotkey  hotkey )
		   { return ( hotkey. p_Modifiers | hotkey. p_Keycode ) ; }
		# endregion


		# region Comparison operators
		/// <summary>
		/// Compares two Hotkeys for equality.
		/// </summary>
		/// <param name="a">The first Hotkey object to be compared.</param>
		/// <param name="b">The second Hotkey object to be compared.</param>
		/// <returns>True if both objects are equal (ie, they have the same keycode and modifiers), false otherwise.</returns>
		public static bool operator  ==  ( Hotkey  a, Hotkey  b )
		   { return ( a. p_Keycode  ==  b. p_Keycode  &&  a. p_Modifiers  ==  b. p_Modifiers ) ; }


		/// <summary>
		/// Compares two Hotkeys for unequality.
		/// </summary>
		/// <param name="a">The first Hotkey object to be compared.</param>
		/// <param name="b">The second Hotkey object to be compared.</param>
		/// <returns>True if both objects are unequal (ie, they have different keycode and/or modifiers), false otherwise.</returns>
		public static bool operator  !=  ( Hotkey  a, Hotkey  b )
		   { return ( a. p_Keycode  !=  b. p_Keycode  ||  a. p_Modifiers  !=  b. p_Modifiers ) ; }


		/// <summary>
		/// Returns true if a Hotkey object does not contain any value (Modifier and Keycode are set to Keys.None).
		/// </summary>
		public static bool operator  false ( Hotkey  hk )
		   { return ( hk. p_Keycode   ==  Keys. None  &&  hk. p_Modifiers  ==  Keys. None ) ; }


		/// <summary>
		/// Returns true if a Hotkey object contains a value (Modifier and/or Keycode are different from Keys.None).
		/// </summary>
		public static bool operator  true ( Hotkey  hk )
		   { return ( hk. p_Keycode  !=  Keys. None ) ; }
		# endregion

		# endregion


		# region  Support methods
		/// <summary>
		/// Internal initializer.
		/// </summary>
		private void  Initialize ( Keys  modifiers, Keys  keycode )
		   {
			Keys		hk_modifiers		=  ( modifiers  &  AuthorizedModifiers ) ;
			Keys		hk_keycode		=  ( keycode    &  Keys. KeyCode   ) ;
			int		keyindex ;


			// The supplied "modifiers" parameter must contain only authorized modifiers (control, alt, shift)
			if  ( hk_modifiers  !=  modifiers )
				throw new ArgumentException ( Resources. Localization. Classes. Hotkey. InvalidModifiersException ) ;
			
			// And the combination modifier/keycode must exist 
			if  ( ( keyindex = Hotkey. FindHotkey ( hk_modifiers, hk_keycode ) )  ==  -1 )
				throw new ArgumentException ( Resources. Localization. Classes. Hotkey. InvalidHotkeyException ) ;

			// Save modifier and keycode
			p_Modifiers	=  hk_modifiers ;
			p_Keycode	=  hk_keycode ;

			// Build the string representation of the hotkey
			String		keytext		=  ( String ) AuthorizedKeys [ keyindex, 1 ] ;
			List<String>	result		=  new List<String> ( ) ;

			
			if  ( ( hk_modifiers  &  Keys. Control )  !=  0 )
				result. Add ( "Ctrl" ) ;

			if (  ( hk_modifiers  &  Keys. Alt )  !=  0 )
				result. Add ( "Alt" ) ;

			if  ( ( hk_modifiers  &  Keys. Shift )  !=  0 )
				result. Add ( "Shift" ) ;

			result. Add ( keytext ) ;
			p_Text	=  String. Join ( " + ", result. ToArray ( ) ) ;
		    }


		/// <summary>
		/// Initializes a Hotkey object from a hotkey string specification.
		/// </summary>
		private void  InitializeFromString ( String  hotkey )
		   {
			char []			separators	=  { ' ' } ;
			Keys			modifiers	=  Keys. None ;
			Keys			keycode		=  Keys. None ;
			int			keyindex ;


			// Remove extra spaces from hotkeys then replace "+" signs with a space
			hotkey = hotkey. Replace ( "+", " " ). Trim ( ) ;
			hotkey = Regex.Replace ( hotkey, "\\s+", " " ) ;

			// Split the string
			String []		parts		=  hotkey. Split ( separators ) ;

			// Loop through string part
			for  ( int  i = 0 ; i < parts. Length - 1 ; i ++ )
			   {
				String		part	=  parts [i]. ToUpper ( ) ;

				switch ( part ) 
				   {
					case	"CTRL"    :
					case	"CONTROL" :  modifiers  |=  Keys. Control	; break ;
					case	"ALT"     :  modifiers  |=  Keys. Alt		; break ;
					case    "SHIFT"	  :  modifiers  |=  Keys. Shift		; break ;

					default :
						throw new ArgumentException ( Resources. Localization. Classes. Hotkey. InvalidModifiersException ) ;
				    }
			    }

			// Lookup for the specified keycode string
			if  ( ( keyindex = FindHotkeyByString ( parts [ parts. Length - 1 ] ) )  ==  -1 )
				throw new ArgumentException ( Resources. Localization. Classes. Hotkey. InvalidHotkeyException ) ;

			keycode		=  ( Keys ) AuthorizedKeys [ keyindex, 0 ] ;

			// Now we can use the standard initializer
			Initialize ( modifiers, keycode ) ;
		    }


		/// <summary>
		/// Search the AuthorizedKeys table for the specified modifiers/keycode combination.
		/// </summary>
		private static int  FindHotkey ( Keys  modifiers, Keys  keycode )
		   {
			// Loop through authorized hotkeys
			for  ( int  i = 0 ; i < AuthorizedKeys. GetLength ( 0 ) ; i ++ )
			   {
				Keys		current_keycode		=  ( Keys ) AuthorizedKeys [i,0] ;

				// If we find this keycode, then we will have to check that the specified modifiers are authorized for
				// this keycode. Note the special case handling for a hotkey without modifiers (null_allowed).
				if  ( current_keycode  ==  keycode )
				   {
					Keys		current_modifiers	=  ( Keys ) AuthorizedKeys [i,2] ;
					bool		null_allowed		=  ( bool ) AuthorizedKeys [i,3] ;

					if  ( ( null_allowed  &&  modifiers  ==  Keys. None )  ||
					      ( ( modifiers  &  current_modifiers )  ==  modifiers ) )
						return ( i ) ;
				    }
			    }

			return ( -1 ) ;
		    }


		/// <summary>
		/// Search the AuthorizedKeys table for the specified key text.
		/// </summary>
		private int  FindHotkeyByString ( String  keytext )
		   {
			// Loop through authorized hotkeys
			for  ( int  i = 0 ; i < AuthorizedKeys. GetLength ( 0 ) ; i ++ )
			   {
				String		value		=  ( String ) AuthorizedKeys [i,1] ;


				if  ( String. Compare ( keytext, value, true )  ==  0 )
					return ( i ) ;
			    }

			return ( -1 ) ;
		    }
		# endregion
	    }
	}
