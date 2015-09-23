/**************************************************************************************************************

    NAME
        GDI.cs

    DESCRIPTION
        GDI-related utilities.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/21]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Drawing ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text ;
using   System. Windows. Forms ;


namespace Thrak. Graphics
   {
	public class GDI
	   {
		/// <summary>
		/// Gets the average character size in the font associated to the specified control.
		/// Works only for fixed-pitch fonts.
		/// </summary>
		public static Size  GetFixedCharacterSize ( Control  window )
		   {
			String				test		=  new String ( '0', 80 ) ;
			System. Drawing. Graphics	gdi		=  window. CreateGraphics ( ) ;
			SizeF				fsize ;
			Size				size		=  new Size ( ) ;

			gdi. PageUnit		=  GraphicsUnit. Pixel ;
			fsize			=  gdi. MeasureString ( test, window. Font ) ;
			gdi. Dispose ( ) ;

			size. Width	=  ( int ) ( fsize. Width / 80 ) ;
			size. Height	=  ( int ) fsize. Height ;

			return ( size ) ;
		    }
	    }
     }
