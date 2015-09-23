/**************************************************************************************************************

    NAME
        ColorPair.cs

    DESCRIPTION
        Implements a pair of colors (background and foreground) along with the appropriate IDE type converter.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/18]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. Collections ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using   System. Drawing. Design ;
using	System. Text ;
using   System. Text. RegularExpressions ;
using	System. Windows. Forms ;
using   System. Windows. Forms. Design ;


namespace Thrak. Forms
  {
	# region ColorPair class
	/// <summary>
	/// A ColorPair object is used to hold two colors : background and foreground.
	/// <para>
	/// This is to simplify the customization task under the VS designer.
	/// </para>
	/// </summary>
	/// <remarks>
	/// Since this is a class and not a struct, you must provide the following attribute if you
	/// declare a property having this type :
	/// <code>
	/// [DesignerSerializationVisibility ( DesignerSerializationVisibility. Content )]
	/// <para>public ColorPair  TheColor { get ; set ; }</para>
	/// </code>
	/// </remarks>
	[TypeConverter ( typeof ( ColorPairTypeConverter ) )]	
	public class ColorPair
	   {
		private	Color		m_Background	=  Color. Empty ;
		private Color		m_Foreground	=  Color. Empty ;


		/// <summary>
		/// Default constructor.
		/// </summary>
		public  ColorPair ( )
		   { }

		/// <summary>
		/// Constructor that take a foreground and background color.
		/// </summary>
		public  ColorPair ( Color  fore, Color  back )
		   {
			m_Background	=  back ;
			m_Foreground	=  fore ;
		    }


		/// <summary>
		/// Gets/sets the background color.
		/// </summary>
		[DefaultValue ( "" ), NotifyParentProperty ( true ), RefreshProperties ( RefreshProperties. Repaint )]
		[Browsable ( true )]
		public Color  Background 
		   {
			get { return ( m_Background ) ; }
			set { m_Background = value ; }
		    }


		/// <summary>
		/// Gets/sets the foreground color.
		/// </summary>
		[DefaultValue ( "" ), NotifyParentProperty ( true ), RefreshProperties ( RefreshProperties. Repaint )]
		[Browsable ( true )]
		public Color  Foreground 
		   {
			get { return ( m_Foreground ) ; }
			set { m_Foreground = value ; }
		    }
	    }
	# endregion


	# region ColorPairTypeConverter type converter
	/// <summary>
	/// Type converter class for a ColorPair object.
	/// </summary>
	internal class  ColorPairTypeConverter :  ExpandableObjectConverter 
	   {
		/// <summary>
		/// Indicates if we support creating new instances of ColorPair objects.
		/// </summary>
		/// <returns>This function always return true.</returns>
		public override bool   GetCreateInstanceSupported( ITypeDescriptorContext context) 
			{ return ( true ) ; }
   

		/// <summary>
		/// Creates a ColorPair object based on the supplied property values.
		/// </summary>
		public override object  CreateInstance ( ITypeDescriptorContext  context, IDictionary  propertyValues ) 
		   {
			Color		back		=  ( Color ) propertyValues [ "Background" ] ;
			Color		fore		=  ( Color ) propertyValues [ "Foreground" ] ;

			return ( new ColorPair ( back, fore ) ) ;
		    }


		/// <summary>
		/// Indicates that we can convert from String.
		/// </summary>
		public override bool  CanConvertFrom ( ITypeDescriptorContext  context, Type  sourcetype ) 
		   {
			if  ( sourcetype  ==  typeof ( string ) )
				return ( true ) ;

			return ( base. CanConvertFrom ( context, sourcetype ) ) ;
		    }


		/// <summary>
		/// Indicates that we can convert to ColorPair.
		/// </summary>
		public override bool CanConvertTo ( ITypeDescriptorContext context, Type destinationtype )
		   {
			if  ( destinationtype  ==  typeof ( ColorPair ) )
				return ( true ) ;

			return ( base. CanConvertTo ( context, destinationtype ) ) ;
		    }


		/// <summary>
		/// Converts from a string to a ColorPair object.
		/// </summary>
		/// <param name="value">
		/// String to be converted in the form "color1 on color2". Both "color1" and "color2" can be specified as either 
		/// a color name or an RGB value in the form : "R;G;B".
		/// </param>
		/// <returns>A ColorPair object that contains the specified colors, "color1" as foreground and "color2" as background.</returns>
		public override object ConvertFrom ( ITypeDescriptorContext  context, System. Globalization. CultureInfo culture, object value )
		   {
			String		StringValue	=  value. ToString ( ) ;
			ColorPair	Pair		=  new ColorPair ( ) ;

			if  ( StringValue  !=  String. Empty )
			   {
				String []	Parts		=  Regex. Split ( StringValue, "\\s+on\\s+", RegexOptions. IgnoreCase ) ;
				TypeConverter	Converter	=  TypeDescriptor. GetConverter ( typeof ( Color ) ) ;
				Color		fore		=  ( Color ) Converter. ConvertFromString ( context, culture, Parts [0] ) ;
				Color		back		=  ( Color ) Converter. ConvertFromString ( context, culture, Parts [1] ) ;

				Pair. Foreground		=  fore ;
				Pair. Background		=  back ;
			    }

			return ( Pair ) ;
		    }


		/// <summary>
		/// Converts from a ColorPair object to a string of the form : "color1 on color2", where "color1" is the foreground color,
		/// and "color2" the background color.
		/// </summary>
		/// <returns>A string representation of the ColorPair object.</returns>
		public override object ConvertTo ( ITypeDescriptorContext context, System. Globalization. CultureInfo  culture, 
							object value , Type  destinationType )
		   {
			ColorPair	pair	=  value  as  ColorPair ;


			if  ( pair. Background  ==  Color. Empty  &&  pair. Foreground  ==  Color. Empty )
				return ( String. Empty ) ;
			else
			   {
				TypeConverter	Converter	=  TypeDescriptor. GetConverter ( typeof ( Color ) ) ;

				return ( Converter. ConvertToString ( context, culture, pair. Foreground ) + " on " +
					 Converter. ConvertToString ( context, culture, pair. Background ) ) ;
			    }
		    }
	    }
	# endregion
   }
