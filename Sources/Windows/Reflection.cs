/**************************************************************************************************************

    NAME
        Reflection.cs

    DESCRIPTION
        Reflection classes for the WinAPI namespace.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System  ;
using	System. Runtime. InteropServices  ;


namespace Thrak. WinAPI. WAPI
   {
	# region Windows messages

	# region Message constant types
	/// <summary>
	/// Windows message constant type.
	/// </summary>
	public enum  MessageConstantType
	   {
		/// <summary>
		/// Regular constant.
		/// </summary>
		Constant		=  1,

		/// <summary>
		/// Base constant (never used in SendMessage).
		/// </summary>
		BaseConstant		=  2,

		/// <summary>
		/// Constant is still defined but superseded.
		/// </summary>
		Superseded		=  3
	    }
	# endregion


	/// <summary>
	/// Declares a Windows message constant.
	/// </summary>
	[AttributeUsage ( AttributeTargets. Enum | AttributeTargets. Field | AttributeTargets. Property )]
	public class MessageConstantAttribute : Attribute
	   {
		public MessageConstantType		ConstantType { get ; set ; }

		public MessageConstantAttribute ( MessageConstantType  ConstantType = MessageConstantType. Constant )
		   { }
	    }


	/// <summary>
	/// Puts a version constraint on a class, struct or member.
	/// </summary>
	[AttributeUsage ( AttributeTargets. All )]
	public class ConstraintAttribute	:  Attribute
	   {
		public WindowsVersion		MinVersion { get ; set ; }
		public WindowsVersion		MaxVersion { get ; set ; }


		public  ConstraintAttribute ( )
		   {
			MinVersion	=  WindowsVersion. Default ;
			MaxVersion	=  WindowsVersion. Any ;
		    }
	    }

	# endregion
    }
