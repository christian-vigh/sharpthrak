namespace Thrak. WinAPI
   {
	namespace  Controls
	   {
		public
	    }
	public static class  WinAPI
	   {
		// Button messages 
		public const int	BM_GETCHECK			= 0x00F0 ; 
		public const int	BM_GETSTATE			= 0x00F2 ;
		public const int	BM_SETSTATE			= 0x00F3 ; 
		public const int	BM_CLICK			= 0xF0F5 ;
		public const int	BM_CLICK			= 0x00F5 ;

 
		// Combobox 
		public const int	CB_GETCURSEL			= 0x0147 ;
		public const int	CB_GETLBTEXT			= 0x0148 ; 
		public const int	CB_GETLBTEXTLEN			= 0x0149 ; 
		public const int	CB_SHOWDROPDOWN			= 0x014F ;
		public const int	CB_GETDROPPEDSTATE		= 0x0157 ; 


		// Date/Time picker
		public const int	DTM_GETSYSTEMTIME		= 0x1001 ;
		public const int	DTM_SETSYSTEMTIME		= 0x1002 ; 
		public const int	DTM_GETMONTHCAL			= 0x1008 ;

  
		// Editbox messages 
		public const int	EM_GETSEL			= 0x00B0 ;
		public const int	EM_SETSEL			= 0x00B1 ; 
		public const int	EM_GETRECT			= 0x00B2 ;
		public const int	EM_LINESCROLL			= 0x00B6 ;
		public const int	EM_GETLINECOUNT			= 0x00BA ;
		public const int	EM_LINEINDEX			= 0x00BB ; 
		public const int	EM_LINEFROMCHAR			= 0x00C9 ;
		public const int	EM_GETFIRSTVISIBLELINE		= 0x00CE ; 
		public const int	EM_GETLIMITTEXT			= 0x00D5 ; 
		public const int	EM_POSFROMCHAR			= 0x00D6 ;
		public const int	EM_CHARFROMPOS			= 0x00D7 ; 
 

		// SysHeader
		public const int	HDM_FIRST			= 0x1200 ;
		public const int	HDM_GETITEMCOUNT		= HDM_FIRST + 0 ; 
		public const int	HDM_HITTEST			= HDM_FIRST + 6 ;
		public const int	HDM_GETITEMRECT			= HDM_FIRST + 7 ; 
		public const int	HDM_GETITEMW			= HDM_FIRST + 11 ; 
		public const int	HDM_ORDERTOINDEX		= HDM_FIRST + 15 ;
		public const int	HDM_GETITEMDROPDOWNRECT		= HDM_FIRST + 25 ; 
		public const int	HDM_GETFOCUSEDITEM		= HDM_FIRST + 27 ;

 

		// Listbox messages

		public const int LB_ERR = -1 ; 

		public const int LB_SETSEL = 0x0185 ;

		public const int LB_SETCURSEL = 0x0186 ; 

		public const int LB_GETSEL = 0x0187 ; 

		public const int LB_GETCURSEL = 0x0188 ;

		public const int LB_GETTEXT = 0x0189 ; 

		public const int LB_GETTEXTLEN = 0x018A ;

		public const int LB_GETCOUNT = 0x018B ;

		public const int LB_GETSELCOUNT = 0x0190 ;

		public const int LB_SETTOPINDEX = 0x0197 ; 

		public const int LB_GETITEMRECT = 0x0198 ;

		public const int LB_GETITEMDATA = 0x0199 ; 

		public const int LB_SETCARETINDEX = 0x019E ; 

		public const int LB_GETCARETINDEX = 0x019F ;

		public const int LB_ITEMFROMPOINT = 0x01A9 ; 

 

		// Listbox notification message

		public const int LBN_SELCHANGE = 1 ;

  

		// List-view messages

		public const int LVM_FIRST = 0x1000 ; 

		public const int LVM_GETITEMCOUNT = LVM_FIRST + 4 ; 

		public const int LVM_GETNEXTITEM = LVM_FIRST + 12 ;

		public const int LVM_GETITEMRECT = LVM_FIRST + 14 ; 

		public const int LVM_GETITEMPOSITION = LVM_FIRST + 16 ;

		public const int LVM_HITTEST = (LVM_FIRST + 18) ;

		public const int LVM_ENSUREVISIBLE = LVM_FIRST + 19 ;

		public const int LVM_SCROLL = LVM_FIRST + 20 ; 

		public const int LVM_GETHEADER = LVM_FIRST + 31 ;

		public const int LVM_GETITEMSTATE = LVM_FIRST + 44 ; 

		public const int LVM_SETITEMSTATE = LVM_FIRST + 43 ; 

		public const int LVM_GETEXTENDEDLISTVIEWSTYLE = LVM_FIRST + 55 ;

		public const int LVM_GETSUBITEMRECT = LVM_FIRST + 56 ; 

		public const int LVM_SUBITEMHITTEST = LVM_FIRST + 57 ;

		public const int LVM_APPROXIMATEVIEWRECT = LVM_FIRST + 64 ;

		public const int LVM_GETITEMW = LVM_FIRST + 75 ;

		public const int LVM_GETTOOLTIPS = LVM_FIRST + 78 ; 

		public const int LVM_GETFOCUSEDGROUP = LVM_FIRST + 93 ;

		public const int LVM_GETGROUPRECT = LVM_FIRST + 98 ; 

		public const int LVM_EDITLABEL = LVM_FIRST + 118 ; 

		public const int LVM_GETVIEW = LVM_FIRST + 143 ;

		public const int LVM_SETVIEW = LVM_FIRST + 142 ; 

		public const int LVM_SETGROUPINFO = LVM_FIRST + 147 ;

		public const int LVM_GETGROUPINFO = LVM_FIRST + 149 ;

		public const int LVM_GETGROUPINFOBYINDEX = LVM_FIRST + 153 ;

		public const int LVM_GETGROUPMETRICS = LVM_FIRST + 156 ; 

		public const int LVM_HASGROUP = LVM_FIRST + 161 ;

		public const int LVM_ISGROUPVIEWENABLED = LVM_FIRST + 175 ; 

		public const int LVM_GETFOCUSEDCOLUMN = LVM_FIRST + 186 ; 

 

		public const int LVM_GETEMPTYTEXT = LVM_FIRST + 204 ; 

		public const int LVM_GETFOOTERRECT = LVM_FIRST + 205 ;

		public const int LVM_GETFOOTERINFO = LVM_FIRST + 206 ;

		public const int LVM_GETFOOTERITEMRECT = LVM_FIRST + 207 ;

		public const int LVM_GETFOOTERITEM = LVM_FIRST + 208 ; 

		public const int LVM_GETITEMINDEXRECT = LVM_FIRST + 209 ;

		public const int LVM_SETITEMINDEXSTATE = LVM_FIRST + 210 ; 

		public const int LVM_GETNEXTITEMINDEX = LVM_FIRST + 211 ; 

 

		// calendar control specific constants taken from commctrl.h 

		// commctrl MONTHCAL CONTROL win messages

		public const int MCM_FIRST = 0x1000 ;

		public const int MCM_GETCURSEL = (MCM_FIRST + 1) ;

		public const int MCM_SETCURSEL = (MCM_FIRST + 2) ; 

		public const int MCM_GETMAXSELCOUNT = (MCM_FIRST + 3) ;

		public const int MCM_GETSELRANGE = (MCM_FIRST + 5) ; 

		public const int MCM_SETSELRANGE = (MCM_FIRST + 6) ; 

		public const int MCM_GETMONTHRANGE = (MCM_FIRST + 7) ;

		public const int MCM_GETMINREQRECT = (MCM_FIRST + 9) ; 

		public const int MCM_GETTODAY = (MCM_FIRST + 13) ;

		public const int MCM_HITTEST = (MCM_FIRST + 14) ;

		public const int MCM_GETFIRSTDAYOFWEEK = (MCM_FIRST + 16) ;

		public const int MCM_GETRANGE = (MCM_FIRST + 17) ; 

		public const int MCM_SETMONTHDELTA = (MCM_FIRST + 20) ;

		public const int MCM_GETMAXTODAYWIDTH = (MCM_FIRST + 21) ; 

		public const int MCM_GETCURRENTVIEW = (MCM_FIRST + 22) ; 

		public const int MCM_GETCALENDARCOUNT = (MCM_FIRST + 23) ;

		public const int MCM_GETCALENDARGRIDINFO = (MCM_FIRST + 24) ; 

 

		// PAGER CONTROL from commctrl.h

		public const int PGM_FIRST = 0x1400 ;

		public const int PGM_SETCHILD = (PGM_FIRST + 1) ; 

		public const int PGM_RECALCSIZE = (PGM_FIRST + 2) ;

		public const int PGM_FORWARDMOUSE = (PGM_FIRST + 3) ; 

		public const int PGM_SETBKCOLOR = (PGM_FIRST + 4) ; 

		public const int PGM_GETBKCOLOR = (PGM_FIRST + 5) ;

		public const int PGM_SETBORDER = (PGM_FIRST + 6) ; 

		public const int PGM_GETBORDER = (PGM_FIRST + 7) ;

		public const int PGM_SETPOS = (PGM_FIRST + 8) ;

		public const int PGM_GETPOS = (PGM_FIRST + 9) ;

		public const int PGM_SETBUTTONSIZE = (PGM_FIRST + 10) ; 

		public const int PGM_GETBUTTONSIZE = (PGM_FIRST + 11) ;

		public const int PGM_GETBUTTONSTATE = (PGM_FIRST + 12) ; 

  

		// SysTabControl32

		public const int TCM_FIRST = 0x1300 ; 

		public const int TCM_GETITEMCOUNT = TCM_FIRST + 4 ;

		public const int TCM_GETITEMRECT = TCM_FIRST + 10 ;

		public const int TCM_GETCURSEL = TCM_FIRST + 11 ;

		public const int TCM_SETCURSEL = TCM_FIRST + 12 ; 

		public const int TCM_HITTEST = TCM_FIRST + 13 ;

		public const int TCM_GETTOOLTIPS = TCM_FIRST + 45 ; 

		public const int TCM_GETCURFOCUS = TCM_FIRST + 47 ; 

		public const int TCM_SETCURFOCUS = TCM_FIRST + 48 ;

		public const int TCM_DESELECTALL = TCM_FIRST + 50 ; 

		public const int TCM_GETITEMW = TCM_FIRST + 60 ;

 

		// TreeView

		public const int TV_FIRST = 0x1100 ; 

		public const int TVM_EXPAND = (TV_FIRST + 2) ;

		public const int TVM_GETITEMRECT = (TV_FIRST + 4) ; 

		public const int TVM_GETCOUNT = (TV_FIRST + 5) ; 

		public const int TVM_GETNEXTITEM = (TV_FIRST + 10) ;

		public const int TVM_SELECTITEM = (TV_FIRST + 11) ; 

		public const int TVM_HITTEST = (TV_FIRST + 17) ;

		public const int TVM_ENSUREVISIBLE = (TV_FIRST + 20) ;

		public const int TVM_ENDEDITLABELNOW = (TV_FIRST + 22) ;

		public const int TVM_GETTOOLTIPS = (TV_FIRST + 25) ; 

		public const int TVM_GETITEMSTATE = (TV_FIRST + 39) ;

		public const int TVM_MAPACCIDTOHTREEITEM = (TV_FIRST + 42) ; 

		public const int TVM_MAPHTREEITEMTOACCID = (TV_FIRST + 43) ; 

		public const int TVM_GETITEMW = (TV_FIRST + 62) ;

		public const int TVM_SETITEMW = (TV_FIRST + 63) ; 

		public const int TVM_EDITLABELW = (TV_FIRST + 65) ;

 

		// Window

		public const int WM_SETTEXT = 0x000C ; 

		public const int WM_GETTEXT = 0x000D ;

		public const int WM_GETTEXTLENGTH = 0x000E ; 

		public const int WM_QUIT = 0x0012 ; 

		public const int WM_GETFONT = 0x0031 ;

		public const int WM_GETOBJECT = 0x003D ; 

		public const int WM_NCHITTEST = 0x0084 ;

		public const int WM_KEYDOWN = 0x0100 ;

		public const int WM_KEYUP = 0x0101 ;

		public const int WM_COMMAND = 0x0111 ; 

		public const int WM_SYSCOMMAND = 0x0112 ;

		public const int WM_HSCROLL = 0x0114 ; 

		public const int WM_VSCROLL = 0x0115 ; 

		public const int WM_LBUTTONDOWN = 0x0201 ;

		public const int WM_LBUTTONUP = 0x0202 ; 

		public const int WM_RBUTTONDOWN = 0x0204 ;

		public const int WM_RBUTTONUP = 0x0205 ;

		public const int WM_MDITILE = 0x0226 ;

		public const int WM_MDICASCADE = 0x0227 ; 

		public const int WM_HOTKEY = 0x0312 ;

		public const int WM_GETTITLEBARINFOEX = 0x033F ; 

		public const int WM_USER = 0x0400 ; 

 

		// Dialog Codes 

		public const int WM_GETDLGCODE = 0x0087 ;

		public const int DLGC_STATIC = 0x0100 ;

 

		// Slider 

		public const int TBM_GETPOS = WM_USER ;

		public const int TBM_GETRANGEMIN = WM_USER + 1 ; 

		public const int TBM_GETRANGEMAX = WM_USER + 2 ; 

		public const int TBM_SETPOS = WM_USER + 5 ;

		public const int TBM_GETPAGESIZE = WM_USER + 22 ; 

		public const int TBM_GETLINESIZE = WM_USER + 24 ;

		public const int TBM_GETTHUMBRECT = WM_USER + 25 ;

		public const int TBM_GETCHANNELRECT = WM_USER + 26 ;

		public const int TBM_GETTOOLTIPS = WM_USER + 30 ; 

 

		// Progress Bar 

		public const int PBM_GETRANGE = (WM_USER + 7) ; 

		public const int PBM_GETPOS = (WM_USER + 8) ;

  

		// Status Bar

		public const int SB_GETPARTS = (WM_USER + 6) ;

		public const int SB_GETRECT = (WM_USER + 10) ;

		public const int SB_GETTEXTLENGTHW = (WM_USER + 12) ; 

		public const int SB_GETTEXTW = (WM_USER + 13) ;

  

		// Rebar 

		public const int RB_HITTEST = WM_USER + 8 ;

		public const int RB_GETRECT = WM_USER + 9 ; 

		public const int RB_GETBANDCOUNT = WM_USER + 12 ;

		public const int RB_GETTOOLTIPS = WM_USER + 17 ;

		public const int RB_GETBANDINFOA = WM_USER + 29 ;

		public const int RB_PUSHCHEVRON = WM_USER + 43 ; 

 

		// ToolBar 

		public const int TB_PRESSBUTTON = WM_USER + 3 ; 

		public const int TB_ISBUTTONENABLED = WM_USER + 9 ;

		public const int TB_ISBUTTONCHECKED = WM_USER + 10 ; 

		public const int TB_ISBUTTONHIDDEN = WM_USER + 12 ;

		public const int TB_GETBUTTON = WM_USER + 23 ;

		public const int TB_BUTTONCOUNT = WM_USER + 24 ;

		public const int TB_GETITEMRECT = WM_USER + 29 ; 

		public const int TB_GETTOOLTIPS = WM_USER + 35 ;

		public const int TB_GETIMAGELIST = WM_USER + 49 ; 

		public const int TB_GETHOTITEM = WM_USER + 71 ; 

		public const int TB_SETHOTITEM = WM_USER + 72 ;

		public const int TB_GETBUTTONTEXT = WM_USER + 75 ; 

		public const int TB_GETEXTENDEDSTYLE = WM_USER + 85 ;

 

		// Tooltip

		public const int TTM_GETTOOLINFO = (WM_USER + 53) ; 

		public const int TTM_HITTEST = (WM_USER + 55) ;

		public const int TTM_GETTEXT = (WM_USER + 56) ; 

		public const int TTM_GETCURRENTTOOL = (WM_USER + 59) ; 

 

		// IPAddress 

		public const int IPM_SETADDRESS = (WM_USER + 101) ;

 

		//  SpinControl

		public const int UDM_GETRANGE = (WM_USER + 102) ; 

		public const int UDM_SETPOS = (WM_USER + 103) ;

		public const int UDM_GETPOS = (WM_USER + 104) ; 

		public const int UDM_GETBUDDY = (WM_USER + 106) ; 

 

		// Hyperlink 

		public const int LM_FIRST = (WM_USER + 0x300) ;

		public const int LM_HITTEST = LM_FIRST ;

		public const int LM_GETIDEALHEIGHT = (LM_FIRST + 1) ;

		public const int LM_SETITEM = (LM_FIRST + 2) ; 

		public const int LM_GETITEM = (LM_FIRST + 3) ;

  

  

		// Button styles

		public const int BS_PUSHBUTTON = 0x00000000 ; 

		public const int BS_DEFPUSHBUTTON = 0x00000001 ;

		public const int BS_CHECKBOX = 0x00000002 ;

		public const int BS_AUTOCHECKBOX = 0x00000003 ;

		public const int BS_RADIOBUTTON = 0x00000004 ; 

		public const int BS_3STATE = 0x00000005 ;

		public const int BS_AUTO3STATE = 0x00000006 ; 

		public const int BS_GROUPBOX = 0x00000007 ; 

		public const int BS_USERBUTTON = 0x00000008 ;

		public const int BS_AUTORADIOBUTTON = 0x00000009 ; 

		public const int BS_PUSHBOX = 0x0000000A ;

		public const int BS_OWNERDRAW = 0x0000000B ;

		public const int BS_SPLITBUTTON = 0x0000000C ;

		public const int BS_TYPEMASK = 0x0000000F ; 

 

		// Date/Time picker styles 

		public const int DTS_UPDOWN = 0x0001 ; 

		public const int DTS_SHOWNONE = 0x0002 ;

		// DTS_TIMEFORMAT is wrongly defined in the common control include file with a value of 9 

		// TIME_FORMAT + DTS_UPDOWN.

		public const int DTS_TIMEFORMAT = 0x0009 ;

		// Removes the UPDOWN bit. Use this const to check for TIMEFORMAT

		public const int DTS_TIMEFORMATONLY = DTS_TIMEFORMAT & ~DTS_UPDOWN ; 

 

		// Dialogbox Styles 

		public const int DS_CONTROL = 0x00000400 ; 

 

		// Editbox styles 

		public const int ES_LEFT = 0x0000 ;

		public const int ES_CENTER = 0x0001 ;

		public const int ES_RIGHT = 0x0002 ;

		public const int ES_MULTILINE = 0x0004 ; 

		public const int ES_UPPERCASE = 0x0008 ;

		public const int ES_LOWERCASE = 0x0010 ; 

		public const int ES_PASSWORD = 0x0020 ; 

		public const int ES_AUTOHSCROLL = 0x0080 ;

		public const int ES_READONLY = 0x0800 ; 

		public const int ES_NUMBER = 0x2000 ;

 

		// Listbox styles

		public const int LBS_NOTIFY = 0x0001 ; 

		public const int LBS_SORT = 0x0002 ;

		public const int LBS_MULTIPLESEL = 0x0008 ; 

		public const int LBS_OWNERDRAWFIXED = 0x0010 ; 

		public const int LBS_WANTKEYBOARDINPUT = 0x0400 ;

		public const int LBS_EXTENDEDSEL = 0x0800 ; 

		public const int LBS_COMBOBOX = 0x8000 ;

 

		// Listview styles

		public const int LVS_REPORT = 0x0001 ; 

		public const int LVS_LIST = 0x0003 ;

		public const int LVS_TYPEMASK = 0x0003 ; 

		public const int LVS_SINGLESEL = 0x0004 ; 

		public const int LVS_AUTOARRANGE = 0x0100 ;

		public const int LVS_EDITLABELS = 0x0200 ; 

		public const int LVS_NOSCROLL = 0x2000 ;

		public const int LVS_NOCOLUMNHEADER = 0x4000 ;

 

		// Listview extended styles 

		public const int LVS_EX_CHECKBOXES = 0x4 ;

		public const int LVS_EX_FULLROWSELECT = 0x00000020 ; 

		public const int LVS_EX_ONECLICKACTIVATE = 0x00000040 ; 

		public const int LVS_EX_TWOCLICKACTIVATE = 0x00000080 ;

		public const int LVS_EX_UNDERLINEHOT = 0x00000800 ; 

		public const int LVS_EX_UNDERLINECOLD = 0x00001000 ;

		public const int LVS_EX_JUSTIFYCOLUMNS = 0x00200000 ; // Icons are lined up in columns that use up the whole view area

 

		// Listview item states 

		public const int LVIS_FOCUSED = 0x0001 ;

		public const int LVIS_SELECTED = 0x0002 ; 

		public const int LVIS_STATEIMAGEMASK = 0xFFFF ; 

 

		// commctrl MONTHCAL CONTROL style constants 

		public const int MCS_DAYSTATE = 0x0001 ;

		public const int MCS_MULTISELECT = 0x0002 ;

		public const int MCS_WEEKNUMBERS = 0x0004 ;

		public const int MCS_NOTODAYCIRCLE = 0x0008 ; 

		public const int MCS_NOTODAY = 0x0010 ;

  

		// PAGER CONTROL styles from commctrl.h 

		public const int PGS_VERT = 0x00000000 ;

		public const int PGS_HORZ = 0x00000001 ; 

 

		// Scrollbar style

		public const int SBS_HORZ = 0x0000 ;

		public const int SBS_VERT = 0x0001 ; 

 

		// Slider style 

		public const int TBS_VERT = 0x0002 ; 

		public const int TBS_REVERSED = 0x0200 ;

  

		// Static styles

		public const int SS_LEFT = 0x00000000 ;

		public const int SS_CENTER = 0x00000001 ;

		public const int SS_RIGHT = 0x00000002 ; 

		public const int SS_ICON = 0x00000003 ;

		public const int SS_BLACKRECT = 0x00000004 ; 

		public const int SS_GRAYRECT = 0x00000005 ; 

		public const int SS_WHITERECT = 0x00000006 ;

		public const int SS_BLACKFRAME = 0x00000007 ; 

		public const int SS_GRAYFRAME = 0x00000008 ;

		public const int SS_WHITEFRAME = 0x00000009 ;

		public const int SS_USERITEM = 0x0000000A ;

		public const int SS_SIMPLE = 0x0000000B ; 

		public const int SS_LEFTNOWORDWRAP = 0x0000000C ;

		public const int SS_OWNERDRAW = 0x0000000D ; 

		public const int SS_BITMAP = 0x0000000E ; 

		public const int SS_ENHMETAFILE = 0x0000000F ;

		public const int SS_ETCHEDHORZ = 0x00000010 ; 

		public const int SS_ETCHEDVERT = 0x00000011 ;

		public const int SS_ETCHEDFRAME = 0x00000012 ;

		public const int SS_TYPEMASK = 0x0000001F ;

  

		// SysHeader32 styles

		//public const int HDS_HORZ = 0x0000 ; 

		public const int HDS_VERT = 0x0001 ; 

 

		// Toolbar styles 

		public const int TBSTYLE_EX_DRAWDDARROWS = 0x00000001 ;

 

		// Toolbar button styles

		public const byte BTNS_SEP       = 0x0001 ; 

		public const byte BTNS_CHECK     = 0x0002 ;

		public const byte BTNS_GROUP     = 0x0004 ; 

		public const byte BTNS_DROPDOWN  = 0x0008 ; 

 

		// Image list constants 

		public const int I_IMAGENONE = -2 ;

 

		// Window styles

		public const int WS_OVERLAPPED    = 0x00000000 ; 

		public const int WS_TABSTOP       = 0x00010000 ;

		public const int WS_MAXIMIZEBOX   = 0x00010000 ; 

		public const int WS_GROUP         = 0x00020000 ; 

		public const int WS_MINIMIZEBOX   = 0x00020000 ;

		public const int WS_SYSMENU       = 0x00080000 ; 

		public const int WS_HSCROLL       = 0x00100000 ;

		public const int WS_VSCROLL       = 0x00200000 ;

		public const int WS_BORDER        = 0x00800000 ;

		public const int WS_CAPTION       = 0x00C00000 ; 

		public const int WS_MAXIMIZE      = 0x01000000 ;

		public const int WS_DISABLED      = 0x08000000 ; 

		public const int WS_VISIBLE       = 0x10000000 ; 

		public const int WS_MINIMIZE      = 0x20000000 ;

		public const int WS_CHILD         = 0x40000000 ; 

		public const int WS_POPUP         = unchecked((int)0x80000000) ;

 

		// Window extended sytles

		public const int WS_EX_DLGMODALFRAME  = 0x00000001 ; 

		public const int WS_EX_MDICHILD       = 0x00000040 ;

		public const int WS_EX_TOOLWINDOW     = 0x00000080 ; 

		public const int WS_EX_CONTEXTHELP    = 0x00000400 ; 

		public const int WS_EX_RTLREADING     = 0x00002000 ;

		public const int WS_EX_CONTROLPARENT  = 0x00010000 ; 

		public const int WS_EX_LAYOUTRTL      = 0x00400000 ; // Right to left mirroring

 

		// Button states

		public const int BST_UNCHECKED = 0x0000 ; 

		public const int BST_CHECKED = 0x0001 ;

		public const int BST_INDETERMINATE = 0x0002 ; 

		public const int BST_PUSHED = 0x0004 ; 

		public const int BST_FOCUS = 0x0008 ;

  

		//GetDeviceCaps()

		public const int LOGPIXELSX = 88 ;

		public const int LOGPIXELSY = 90 ;

  

		// GetWindow()

		public const int GW_HWNDFIRST = 0 ; 

		public const int GW_HWNDLAST = 1 ; 

		public const int GW_HWNDNEXT = 2 ;

		public const int GW_HWNDPREV = 3 ; 

		public const int GW_OWNER = 4 ;

		public const int GW_CHILD = 5 ;

 

		// GetWindowLong() 

		public const int GWL_EXSTYLE = (-20) ;

		public const int GWL_STYLE = (-16) ; 

		public const int GWL_ID = (-12) ; 

		public const int GWL_HWNDPARENT = (-8) ;

		public const int GWL_WNDPROC = (-4) ; 

 

		// GetSysColor()

		public const int COLOR_WINDOW = 5 ;

		public const int COLOR_WINDOWTEXT = 8 ; 

 

		// Mouse Key 

		public const int MK_LBUTTON = 0x0001 ; 

		public const int MK_RBUTTON = 0x0002 ;

  

		// Scrollbar

		public const int SB_HORZ = 0 ;

		public const int SB_VERT = 1 ;

		public const int SB_CTL = 2 ; 

		public const int SB_LINEUP = 0 ;

		public const int SB_LINELEFT = 0 ; 

		public const int SB_LINEDOWN = 1 ; 

		public const int SB_LINERIGHT = 1 ;

		public const int SB_PAGEUP = 2 ; 

		public const int SB_PAGELEFT = 2 ;

		public const int SB_PAGEDOWN = 3 ;

		public const int SB_PAGERIGHT = 3 ;

		public const int SB_THUMBPOSITION = 4 ; 

		public const int SB_THUMBTRACK = 5 ;

		public const int SB_LEFT = 6 ; 

		public const int SB_RIGHT = 7 ; 

		public const int SB_ENDSCROLL = 8 ;

		public const int SB_TOP = 6 ; 

		public const int SB_BOTTOM = 7 ;

 

		public const int SORT_DEFAULT = 0x0 ;

		public const int SUBLANG_DEFAULT = 0x01 ; 

 

		public const int SC_TASKLIST = 0xF130 ; 

  

		// ShowWindow()

		public const int SW_HIDE = 0 ; 

		public const int SW_NORMAL = 1 ;

		public const int SW_SHOWMINIMIZED = 2 ;

		public const int SW_SHOWMAXIMIZED = 3 ;

		public const int SW_MAXIMIZE = 3 ; 

		public const int SW_SHOWNOACTIVATE = 4 ;

		public const int SW_SHOW = 5 ; 

		public const int SW_MINIMIZE = 6 ; 

		public const int SW_SHOWMINNOACTIVE = 7 ;

		public const int SW_SHOWNA = 8 ; 

		public const int SW_RESTORE = 9 ;

		public const int SW_MAX = 10 ;

 

		public const int SWP_NOSIZE = 0x0001 ; 

		public const int SWP_NOMOVE = 0x0002 ;

		public const int SWP_NOZORDER = 0x0004 ; 

		public const int SWP_NOACTIVATE = 0x0010 ; 

		public const int SWP_SHOWWINDOW = 0x0040 ;

		public const int SWP_HIDEWINDOW = 0x0080 ; 

		public const int SWP_DRAWFRAME = 0x0020 ;

 

		// System Metrics

		public const int SM_CXSCREEN = 0 ; 

		public const int SM_CYSCREEN = 1 ;

		public const int SM_CXVSCROLL = 2 ; 

		public const int SM_CYHSCROLL = 3 ; 

		public const int SM_CYCAPTION = 4 ;

		public const int SM_CXBORDER = 5 ; 

		public const int SM_CYBORDER = 6 ;

		public const int SM_CYVTHUMB = 9 ;

		public const int SM_CXHTHUMB = 10 ;

		public const int SM_CXICON = 11 ; 

		public const int SM_CYICON = 12 ;

		public const int SM_CXCURSOR = 13 ; 

		public const int SM_CYCURSOR = 14 ; 

		public const int SM_CYMENU = 15 ;

		public const int SM_CYKANJIWINDOW = 18 ; 

		public const int SM_MOUSEPRESENT = 19 ;

		public const int SM_CYVSCROLL = 20 ;

		public const int SM_CXHSCROLL = 21 ;

		public const int SM_DEBUG = 22 ; 

		public const int SM_SWAPBUTTON = 23 ;

		public const int SM_CXMIN = 28 ; 

		public const int SM_CYMIN = 29 ; 

		public const int SM_CXSIZE = 30 ;

		public const int SM_CYSIZE = 31 ; 

		public const int SM_CXFRAME = 32 ;

		public const int SM_CYFRAME = 33 ;

		public const int SM_CXMINTRACK = 34 ;

		public const int SM_CYMINTRACK = 35 ; 

		public const int SM_CXDOUBLECLK = 36 ;

		public const int SM_CYDOUBLECLK = 37 ; 

		public const int SM_CXICONSPACING = 38 ; 

		public const int SM_CYICONSPACING = 39 ;

		public const int SM_MENUDROPALIGNMENT = 40 ; 

		public const int SM_PENWINDOWS = 41 ;

		public const int SM_DBCSENABLED = 42 ;

		public const int SM_CMOUSEBUTTONS = 43 ;

		public const int SM_CXFIXEDFRAME = 7 ; 

		public const int SM_CYFIXEDFRAME = 8 ;

		public const int SM_SECURE = 44 ; 

		public const int SM_CXEDGE = 45 ; 

		public const int SM_CYEDGE = 46 ;

		public const int SM_CXMINSPACING = 47 ; 

		public const int SM_CYMINSPACING = 48 ;

		public const int SM_CXSMICON = 49 ;

		public const int SM_CYSMICON = 50 ;

		public const int SM_CYSMCAPTION = 51 ; 

		public const int SM_CXSMSIZE = 52 ;

		public const int SM_CYSMSIZE = 53 ; 

		public const int SM_CXMENUSIZE = 54 ; 

		public const int SM_CYMENUSIZE = 55 ;

		public const int SM_ARRANGE = 56 ; 

		public const int SM_CXMINIMIZED = 57 ;

		public const int SM_CYMINIMIZED = 58 ;

		public const int SM_CXMAXTRACK = 59 ;

		public const int SM_CYMAXTRACK = 60 ; 

		public const int SM_CXMAXIMIZED = 61 ;

		public const int SM_CYMAXIMIZED = 62 ; 

		public const int SM_NETWORK = 63 ; 

		public const int SM_CLEANBOOT = 67 ;

		public const int SM_CXDRAG = 68 ; 

		public const int SM_CYDRAG = 69 ;

		public const int SM_SHOWSOUNDS = 70 ;

		public const int SM_CXMENUCHECK = 71 ;

		public const int SM_CYMENUCHECK = 72 ; 

		public const int SM_MIDEASTENABLED = 74 ;

		public const int SM_MOUSEWHEELPRESENT = 75 ; 

		public const int SM_XVIRTUALSCREEN = 76 ; 

		// Stock Logical Objects

		public const int SYSTEM_FONT = 13 ; 

 

		public const int SM_YVIRTUALSCREEN = 77 ;

		public const int SM_CXVIRTUALSCREEN = 78 ;

		public const int SM_CYVIRTUALSCREEN = 79 ; 

 

		// Virtal Keys 

		public const int VK_TAB = 0x09 ; 

		public const int VK_RETURN = 0x0D ;

		public const int VK_ESCAPE = 0x1B ; 

		public const int VK_PRIOR = 0x21 ;

		public const int VK_NEXT = 0x22 ;

		public const int VK_F4 = 0x73 ;

  

		public const int MAX_PATH = 260 ;

  

		public const int MDITILE_VERTICAL = 0x0000 ; 

		public const int MDITILE_HORIZONTAL = 0x0001 ;

		public const int MDITILE_SKIPDISABLED = 0x0002 ; 

 

		public const int S_OK = 0x00000000 ;

		public const int S_FALSE = 0x00000001 ;

  

        // We have this wrapper because casting IntPtr to int may

        // generate OverflowException when one of high 32 bits is set. 

        public static int IntPtrToInt32(IntPtr intPtr) 

        {

            return unchecked((int)intPtr.ToInt64()) ; 

        }

 

        public unsafe delegate bool EnumChildrenCallbackVoid(IntPtr hwnd, void* lParam) ;

  

        [StructLayout (LayoutKind.Sequential)]

        public struct MSG 

        { 

            public IntPtr hwnd ;

            public int message ; 

            public IntPtr wParam ;

            public IntPtr lParam ;

            public int time ;

  

            // pt was a by-value POINT structure

            public int pt_x ; 

            public int pt_y ; 

        }

  

        [StructLayout (LayoutKind.Sequential, CharSet = CharSet.Unicode)]

        public struct LOGFONT

        {

            public int lfHeight ; 

            public int lfWidth ;

            public int lfEscapement ; 

            public int lfOrientation ; 

            public int lfWeight ;

            public byte lfItalic ; 

            public byte lfUnderline ;

            public byte lfStrikeOut ;

            public byte lfCharSet ;

            public byte lfOutPrecision ; 

            public byte lfClipPrecision ;

            public byte lfQuality ; 

            public byte lfPitchAndFamily ; 

 

            [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 32)] 

            public string lfFaceName ;

        }

 

        // struct for unmanaged SYSTEMTIME struct 

        [StructLayout (LayoutKind.Sequential)]

        public struct SYSTEMTIME 

        { 

            public ushort wYear ;

            public ushort wMonth ; 

            public ushort wDayOfWeek ;

            public ushort wDay ;

            public ushort wHour ;

            public ushort wMinute ; 

            public ushort wSecond ;

            public ushort wMilliseconds ; 

        } 

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct NMHDR

        {

            public IntPtr hwndFrom ;

            public int idFrom ; 

            public int code ;

        } 

  

        [StructLayout (LayoutKind.Sequential, Pack = 1)]

        public struct TBBUTTON 

        {

            public int iBitmap ;

            public int idCommand ;

            public byte fsState ; 

            public byte fsStyle ;

            public byte bReserved0 ; 

            public byte bReserved1 ; 

            public int dwData ;

            public IntPtr iString ; 

        }

 

        //

        // ListView constants and strucs 

        //

  

        // ListView item relation flags 

        //      public const int LVNI_ALL = 0x0000 ;

        public const int LVNI_FOCUSED = 0x0001 ; 

        public const int LVNI_SELECTED = 0x0002 ;

        public const int LVNI_BELOW = 0x0200 ;

        public const int LVNI_TORIGHT = 0x0800 ;

  

        public const int LVNI_VISIBLEORDER = 0x0010 ;

        public const int LVNI_PREVIOUS = 0x0020 ; 

        public const int LVNI_VISIBLEONLY = 0x0040 ; 

        public const int LVNI_SAMEGROUPONLY = 0x0080 ;

  

        // Listview's VIEW. v5 and up

        public const int LV_VIEW_ICON = 0x0000 ;

        public const int LV_VIEW_DETAILS = 0x0001 ;

        public const int LV_VIEW_SMALLICON = 0x0002 ; 

        public const int LV_VIEW_LIST = 0x0003 ;

        public const int LV_VIEW_TILE = 0x0004 ; 

  

        // ListView rectangle related constants

        public const int LVIR_BOUNDS = 0 ; 

        public const int LVIR_ICON = 1 ;

        public const int LVIR_LABEL = 2 ;

        public const int LVIR_SELECTBOUNDS = 3 ;

  

        // ListView hit test defines

        public const int LVHT_NOWHERE = 0x0001 ; 

        public const int LVHT_ONITEMICON = 0x0002 ; 

        public const int LVHT_ONITEMLABEL = 0x0004 ;

        public const int LVHT_ONITEMSTATEICON = 0x0008 ; 

        public const int LVHT_ONITEM = (LVHT_ONITEMICON | LVHT_ONITEMLABEL | LVHT_ONITEMSTATEICON) ;

 

        public const int LVHT_EX_GROUP_HEADER = 0x10000000 ;

        public const int LVHT_EX_GROUP_FOOTER = 0x20000000 ; 

        public const int LVHT_EX_GROUP_COLLAPSE = 0x40000000 ;

        public const int LVHT_EX_GROUP_BACKGROUND = unchecked((int)0x80000000) ; 

        public const int LVHT_EX_GROUP_STATEICON = 0x01000000 ; 

        public const int LVHT_EX_GROUP_SUBSETLINK = 0x02000000 ;

        public const int LVHT_EX_GROUP = (LVHT_EX_GROUP_BACKGROUND | LVHT_EX_GROUP_COLLAPSE | LVHT_EX_GROUP_FOOTER | LVHT_EX_GROUP_HEADER | LVHT_EX_GROUP_STATEICON | LVHT_EX_GROUP_SUBSETLINK) ; 

        public const int LVHT_EX_ONCONTENTS = 0x04000000 ;

        public const int LVHT_EX_FOOTER = 0x08000000 ;

 

        // ListView  item flag 

        public const int LVIF_TEXT = 0x0001 ;

        public const int LVIF_STATE = 0x0008 ; 

        public const int LVIF_GROUPID = 0x0100 ; 

 

        // This used publicly and not passed to the listview the other two 

        // struct will be passed to the listview depending on what version the list is.

        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]

        public struct LVHITTESTINFO_public

        { 

            public Win32Point pt ;

            public uint flags ; 

            public int iItem ; 

            public int iSubItem ;    // this is was NOT in win95.  valid only for LVM_SUBITEMHITTEST

            public int iGroup ;    // version 6 common control 

        }

 

        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]

        public struct LVHITTESTINFO 

        {

            public Win32Point pt ; 

            public uint flags ; 

            public int iItem ;

            public int iSubItem ;    // this is was NOT in win95.  valid only for LVM_SUBITEMHITTEST 

 

            public LVHITTESTINFO(LVHITTESTINFO_public htinfo)

            {

                pt = htinfo.pt ; 

                flags = htinfo.flags ;

                iItem = htinfo.iItem ; 

                iSubItem = htinfo.iSubItem ; 

            }

        } 

 

        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]

        public struct LVHITTESTINFO_V6

        { 

            public Win32Point pt ;

            public uint flags ; 

            public int iItem ; 

            public int iSubItem ;    // this is was NOT in win95.  valid only for LVM_SUBITEMHITTEST

            public int iGroup ;    // version 6 common control 

 

            public LVHITTESTINFO_V6(LVHITTESTINFO_public htinfo)

            {

                pt = htinfo.pt ; 

                flags = htinfo.flags ;

                iItem = htinfo.iItem ; 

                iSubItem = htinfo.iSubItem ; 

                iGroup = htinfo.iGroup ;

            } 

        }

 

        // Should be class so we can use it with our XSendMessage.XSend

        [StructLayout (LayoutKind.Sequential, CharSet = CharSet.Auto)] 

        public struct LVITEM

        { 

            public int mask ; 

            public int iItem ;

            public int iSubItem ; 

            public int state ;

            public int stateMask ;

            public IntPtr pszText ;

            public int cchTextMax ; 

            public int iImage ;

            public IntPtr lParam ; 

            public int iIndent ; 

        }

  

        // new LVITEM structure

        [StructLayout (LayoutKind.Sequential)]

        public struct LVITEM_V6

        { 

            public uint mask ;

            public int iItem ; 

            public int iSubItem ; 

            public int state ;

            public int stateMask ; 

            public IntPtr pszText ;

            public int cchTextMax ;

            public int iImage ;

            public IntPtr lParam ; 

            public int iIndent ;

            public int iGroupID ; 

            public int cColumns ; 

            public IntPtr puColumns ;

        } 

 

        // Listview group specific flags

        public const int LVGF_HEADER  = 0x00000001 ;

        public const int LVGF_FOOTER  = 0x00000002 ; 

        public const int LVGF_STATE   = 0x00000004 ;

        public const int LVGF_ALIGN   = 0x00000008 ; 

        public const int LVGF_GROUPID = 0x00000010 ; 

 

        public const int LVGF_SUBTITLE = 0x00000100 ; 

        public const int LVGF_TASK = 0x00000200 ;

        public const int LVGF_DESCRIPTIONTOP = 0x00000400 ;

        public const int LVGF_DESCRIPTIONBOTTOM = 0x00000800 ;

        public const int LVGF_TITLEIMAGE = 0x00001000 ; 

        public const int LVGF_EXTENDEDIMAGE = 0x00002000 ;

        public const int LVGF_ITEMS = 0x00004000 ; 

        public const int LVGF_SUBSET = 0x00008000 ; 

        public const int LVGF_SUBSETITEMS = 0x00010000 ;

  

        // Listview group styles

        public const int LVGS_NORMAL      = 0x00000000 ;

        public const int LVGS_COLLAPSED   = 0x00000001 ;

        public const int LVGS_HIDDEN      = 0x00000002 ; 

        public const int LVGS_NOHEADER    = 0x00000004 ;

        public const int LVGS_COLLAPSIBLE = 0x00000008 ; 

        public const int LVGS_FOCUSED     = 0x00000010 ; 

        public const int LVGS_SELECTED    = 0x00000020 ;

        public const int LVGS_SUBSETED    = 0x00000040 ; 

        public const int LVGS_SUBSETLINKFOCUSED = 0x00000080 ;

        public const int LVGGR_GROUP = 0 ;

        public const int LVGGR_HEADER = 1 ;

        public const int LVGGR_LABEL = 2 ; 

        public const int LVGGR_SUBSETLINK = 3 ;

  

        // Should be class so we can use it with our XSendMessage.XSend 

        [StructLayout (LayoutKind.Sequential)]

        public struct LVGROUP 

        {

            public int cbSize ;

            public int mask ;

            public IntPtr pszHeader ; 

            public int cchHeader ;

            public IntPtr pszFooter ; 

            public int cchFooter ; 

            public int iGroupID ;

            public int stateMask ; 

            public int state ;

            public int align ;

 

            public void Init (int size) 

            {

                cbSize = size ; 

                mask = 0 ; 

                pszHeader = pszFooter = IntPtr.Zero ;

                cchFooter = cchHeader = 0 ; 

                iGroupID = -1 ;

                stateMask = state = align = 0 ;

            }

        } 

 

        // Should be class so we can use it with our XSendMessage.XSend 

        [StructLayout (LayoutKind.Sequential)] 

        public struct LVGROUP_V6

        { 

            public int cbSize ;

            public int mask ;

            public IntPtr pszHeader ;

            public int cchHeader ; 

            public IntPtr pszFooter ;

            public int cchFooter ; 

            public int iGroupID ; 

            public int stateMask ;

            public int state ; 

            public int align ;

 

            // new stuff for v6

            public IntPtr pszSubtitle ; 

            public int cchSubtitle ;

            public IntPtr pszTask ; 

            public int cchTask ; 

            public IntPtr pszDescriptionTop ;

            public int cchDescriptionTop ; 

            public IntPtr pszDescriptionBottom ;

            public int cchDescriptionBottom ;

            public int iTitleImage ;

            public int iExtendedImage ; 

            public int iFirstItem ;         // Read only

            public int cItems ;             // Read only 

            public IntPtr pszSubsetTitle ;     // NULL if group is not subset 

            public int cchSubsetTitle ;

  

 

            public void Init (int size)

            {

                cbSize = size ; 

                mask = 0 ;

                pszHeader = pszFooter = IntPtr.Zero ; 

                cchFooter = cchHeader = 0 ; 

                iGroupID = -1 ;

                stateMask = state = align = 0 ; 

 

                //new stuff for v6

                pszSubtitle = IntPtr.Zero ;

                cchSubtitle = 0 ; 

                pszTask = IntPtr.Zero ;

                cchTask = 0 ; 

                pszDescriptionTop = IntPtr.Zero ; 

                cchDescriptionTop = 0 ;

                pszDescriptionBottom = IntPtr.Zero ; 

                cchDescriptionBottom = 0 ;

                iTitleImage = 0 ;

                iExtendedImage = 0 ;

                iFirstItem = 0 ;         // Read only 

                cItems = 0 ;             // Read only

                pszSubsetTitle = IntPtr.Zero ; // NULL if group is not subset 

                cchSubsetTitle = 0 ; 

            }

        } 

 

        public const int LVGMF_BORDERSIZE = 0x00000001 ;

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct LVGROUPMETRICS

        { 

            public int cbSize ; 

            public int mask ;

            public int Left ; 

            public int Top ;

            public int Right ;

            public int Bottom ;

            public int crLeft ; 

            public int crTop ;

            public int crBottom ; 

            public int crRightHeader ; 

            public int crFooter ;

  

            public LVGROUPMETRICS (int size, int flag)

            {

                cbSize = size ;

                mask = flag ; 

                Left = Top = Bottom = Right = 0 ;

                crLeft = crTop = crBottom = crLeft = crFooter = crRightHeader = 0 ; 

            } 

        }

  

 

        // supports a single item in multiple groups.

        [StructLayout(LayoutKind.Sequential)]

        public struct LVITEMINDEX 

        {

            public int iItem ;          // listview item index 

            public int iGroup ;         // group index (must be -1 if group view is not enabled) 

 

            public LVITEMINDEX (int item, int group) 

            {

                iItem = item ;

                iGroup = group ;

            } 

        }

  

  

        //

        // Getting the version of the common controls 

        //

 

        public const int CCM_FIRST = 0x2000 ;

        public const int CCM_GETVERSION = CCM_FIRST + 0x8 ; 

 

  

        // 

        // PAGER CONTROL consts and structs from commctrl.h

        // 

 

        public const int PGB_TOPORLEFT = 0 ;

        public const int PGB_BOTTOMORRIGHT = 1 ;

  

        // height and width values

        public const int PGF_CALCWIDTH = 1 ; 

        public const int PGF_CALCHEIGHT = 2 ; 

 

        //The scroll can be in one of the following control State 

        public const int PGF_INVISIBLE = 0 ;      // Scroll button is not visible

        public const int PGF_NORMAL = 1 ;      // Scroll button is in normal state

        public const int PGF_GRAYED = 2 ;      // Scroll button is in grayed state

        public const int PGF_DEPRESSED = 4 ;      // Scroll button is in depressed state 

        public const int PGF_HOT = 8 ;      // Scroll button is in hot state

  

        [StructLayout(LayoutKind.Sequential)] 

        private struct NMPGSCROLL

        { 

            public NMHDR hdr ;

            public bool fwKeys ;

            public Rect rcParent ;

            public int iDir ; 

            public int iXpos ;

            public int iYpos ; 

            public int iScroll ; 

        }

  

        [StructLayout(LayoutKind.Sequential)]

        private struct NMPGCALCSIZE

        {

            public NMHDR hdr ; 

            public uint dwFlag ;

            public int iWidth ; 

            public int iHeight ; 

        }

  

        //CASRemoval:[System.Security.Permissions.SecurityPermissionAttribute (System.Security.Permissions.SecurityAction.LinkDemand, Flags = System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]

        static public class Util

        {

            public static int MAKELONG (int low, int high) 

            {

                return (high << 16) | (low & 0xffff) ; 

            } 

 

            public static IntPtr MAKELPARAM (int low, int high) 

            {

                return (IntPtr)((high << 16) | (low & 0xffff)) ;

            }

  

            public static int HIWORD (int n)

            { 

                return (n >> 16) & 0xffff ; 

            }

            public static int HIDWORD(long n) 

            {

                return unchecked((int)((n >> 32) & 0xffffffff)) ;

            }

  

            public static int LOWORD (int n)

            { 

                return n & 0xffff ; 

            }

            public static int LODWORD(long n) 

            {

                return unchecked((int)(n & 0xffffffff)) ;

            }

        } 

 

        //Win32 additions 

        public const int EventSystemSound = 0x0001 ; 

        public const int EventSystemAlert = 0x0002 ;

        public const int EventSystemForeground = 0x0003 ; 

        public const int EventSystemMenuStart = 0x0004 ;

        public const int EventSystemMenuEnd = 0x0005 ;

        public const int EventSystemMenuPopupStart = 0x0006 ;

        public const int EventSystemMenuPopupEnd = 0x0007 ; 

        public const int EventSystemCaptureStart = 0x0008 ;

        public const int EventSystemCaptureEnd = 0x0009 ; 

        public const int EventSystemMoveSizeStart = 0x000a ; 

        public const int EventSystemMoveSizeEnd = 0x000b ;

        public const int EventSystemContextHelpStart = 0x000c ; 

        public const int EventSystemContextHelpEnd = 0x000d ;

        public const int EventSystemDragDropStart = 0x000e ;

        public const int EventSystemDragDropEnd = 0x000f ;

        public const int EventSystemDialogStart = 0x0010 ; 

        public const int EventSystemDialogEnd = 0x0011 ;

        public const int EventSystemScrollingStart = 0x0012 ; 

        public const int EventSystemScrollingEnd = 0x0013 ; 

        public const int EventSystemSwitchEnd = 0x0015 ;

        public const int EventSystemMinimizeStart = 0x0016 ; 

        public const int EventSystemMinimizeEnd = 0x0017 ;

        public const int EventSystemPaint = 0x0019 ;

 

        public const int EventConsoleCaret = 0x4001 ; 

        public const int EventConsoleUpdateRegion = 0x4002 ;

        public const int EventConsoleUpdateSimple = 0x4003 ; 

        public const int EventConsoleUpdateScroll = 0x4004 ; 

        public const int EventConsoleLayout = 0x4005 ;

        public const int EventConsoleStartApplication = 0x4006 ; 

        public const int EventConsoleEndApplication = 0x4007 ;

 

        public const int EventObjectCreate = 0x8000 ;

        public const int EventObjectDestroy = 0x8001 ; 

        public const int EventObjectShow = 0x8002 ;

        public const int EventObjectHide = 0x8003 ; 

        public const int EventObjectReorder = 0x8004 ; 

        public const int EventObjectFocus = 0x8005 ;

        public const int EventObjectSelection = 0x8006 ; 

        public const int EventObjectSelectionAdd = 0x8007 ;

        public const int EventObjectSelectionRemove = 0x8008 ;

        public const int EventObjectSelectionWithin = 0x8009 ;

        public const int EventObjectStateChange = 0x800A ; 

        public const int EventObjectLocationChange = 0x800B ;

        public const int EventObjectNameChange = 0x800C ; 

        public const int EventObjectDescriptionChange = 0x800D ; 

        public const int EventObjectValueChange = 0x800E ;

        public const int EventObjectParentChange = 0x800F ; 

        public const int EventObjectHelpChange = 0x8010 ;

        public const int EventObjectDefactionChange = 0x8011 ;

        public const int EventObjectAcceleratorChange = 0x8012 ;

        public const int EventObjectInvoke = 0x8013 ; 

        public const int EventObjectTextSelectionChanged = 0x8014 ;

  

        #region Oleacc 

 

        public const int OBJID_CLIENT = unchecked((int)0xFFFFFFFC) ; 

        public const int OBJID_WINDOW = 0x00000000 ;

        public const int OBJID_VSCROLL = unchecked((int)0xFFFFFFFB) ;

        public const int OBJID_HSCROLL = unchecked((int)0xFFFFFFFA) ;

        public const int OBJID_MENU = unchecked((int)0xFFFFFFFD) ; 

        public const int OBJID_SYSMENU = unchecked((int)0xFFFFFFFF) ;

        public const int OBJID_NATIVEOM = unchecked((int)0xFFFFFFF0) ; 

        public const int OBJID_CARET = unchecked((int)0xFFFFFFF8) ; 

 

        #endregion 

 

        public const int SELFLAG_TAKEFOCUS = 0x1 ;

        public const int SELFLAG_TAKESELECTION = 0x2 ;

        public const int SELFLAG_ADDSELECTION = 0x8 ; 

        public const int SELFLAG_REMOVESELECTION = 0x10 ;

  

        public const int E_ACCESSDENIED = unchecked((int)0x80070005) ; 

        public const int E_FAIL = unchecked((int)0x80004005) ;

        public const int E_UNEXPECTED = unchecked((int)0x8000FFFF) ; 

        public const int E_INVALIDARG = unchecked((int)0x80070057) ;

        public const int E_MEMBERNOTFOUND = unchecked((int)0x80020003) ;

        public const int E_NOTIMPL = unchecked((int)0x80004001) ;

        public const int E_OUTOFMEMORY = unchecked((int)0x8007000E) ; 

 

        // Thrown during stress (Win32 call failing in COM) 

        public const int RPC_E_SYS_CALL_FAILED = unchecked((int)0x80010100) ; 

 

        public const int RPC_E_SERVERFAULT = unchecked((int)0x80010105) ; 

        public const int RPC_E_DISCONNECTED = unchecked((int)0x80010108) ;

 

        public const int DISP_E_BADINDEX = unchecked((int)0x8002000B) ;

  

        // Thrown by Word and possibly others

        // The RPC server is unavailable 

        public const int RPC_E_UNAVAILABLE = unchecked((int)0x800706BA) ; 

        // The interface is unknown

        public const int E_INTERFACEUNKNOWN = unchecked((int)0x800706B5) ; 

        // An unknown Error code thrown by Word being closed while a search is running

        public const int E_UNKNOWNWORDERROR = unchecked((int)0x800A01A8) ;

 

  

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct Win32Rect 

        {

            public int left ; 

            public int top ;

            public int right ;

            public int bottom ;

  

            public Win32Rect (int left, int top, int right, int bottom)

            { 

                this.left = left ; 

                this.top = top ;

                this.right = right ; 

                this.bottom = bottom ;

            }

 

            public Win32Rect (Rect rc) 

            {

                this.left = (int)rc.Left ; 

                this.top = (int)rc.Top ; 

                this.right = (int)rc.Right ;

                this.bottom = (int)rc.Bottom ; 

            }

 

            public bool IsEmpty

            { 

                get

                { 

                    return left >= right || top >= bottom ; 

                }

            } 

 

            static public Win32Rect Empty

            {

                get

                {

                    return new Win32Rect (0, 0, 0, 0) ; 

                } 

            }

  

            static public explicit operator Rect (Win32Rect rc)

            {

                // Convert to Windows.Rect (x, y, witdh, heigh)

  

                // Note we need special case Win32Rect.Empty since Rect with widht/height of 0

                // does not consider to be Empty (see Rect in Base\System\Windows\Rect.cs) 

  

                // This test is necessary to prevent throwing an exception in new Rect()

                if (rc.IsEmpty) 

                {

                    return Rect.Empty ;

                }

                return new Rect(rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top) ; 

            }

  

            public Rect ToRect(bool isRtoL) 

            {

                Normalize(isRtoL) ; 

                return (Rect)this ;

            }

 

            public void Normalize(bool isRtoL) 

            {

                // Invert the left and right values for right-to-left windows 

                if (isRtoL) 

                {

                    int temp = this.left ; 

                    this.left = this.right ;

                    this.right = temp ;

                }

            } 

        }

  

        [StructLayout (LayoutKind.Sequential)] 

        public struct Win32Point

        { 

            public int x ;

            public int y ;

 

            public Win32Point (int x, int y) 

            {

                this.x = x ; 

                this.y = y ; 

            }

  

            static public explicit operator Win32Point(Point pt)

            {

                return checked (new Win32Point((int)pt.X, (int)pt.Y)) ;

            } 

        }

  

        [StructLayout (LayoutKind.Sequential)] 

        public struct SIZE

        { 

            public int cx ;

            public int cy ;

 

            public SIZE (int cx, int cy) 

            {

                this.cx = cx ; 

                this.cy = cy ; 

            }

        } 

 

        public const int PROCESSOR_ARCHITECTURE_INTEL = 0 ;

        public const int PROCESSOR_ARCHITECTURE_MIPS = 1 ;

        public const int PROCESSOR_ARCHITECTURE_ALPHA = 2 ; 

        public const int PROCESSOR_ARCHITECTURE_PPC = 3 ;

        public const int PROCESSOR_ARCHITECTURE_SHX = 4 ; 

        public const int PROCESSOR_ARCHITECTURE_ARM = 5 ; 

        public const int PROCESSOR_ARCHITECTURE_IA64 = 6 ;

        public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7 ; 

        public const int PROCESSOR_ARCHITECTURE_MSIL = 8 ;

        public const int PROCESSOR_ARCHITECTURE_AMD64 = 9 ;

        public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF ;

  

        [StructLayout(LayoutKind.Sequential, Pack = 1)]

        public struct SYSTEM_INFO 

        { 

            public ushort wProcessorArchitecture ;

            public ushort wReserved ; 

            public uint dwPageSize ;

            public IntPtr lpMinimumApplicationAddress ;

            public IntPtr lpMaximumApplicationAddress ;

            public IntPtr dwActiveProcessorMask ; 

            public uint dwNumberOfProcessors ;

            public uint dwProcessorType ; 

            public uint dwAllocationGranularity ; 

            public ushort wProcessorLevel ;

            public ushort wProcessorRevision ; 

        }

 

        //

        // ScrollInfo consts and struct 

        //

  

        public const int SIF_RANGE = 0x0001 ; 

        public const int SIF_PAGE = 0x0002 ;

        public const int SIF_POS = 0x0004 ; 

        public const int SIF_TRACKPOS = 0x0010 ;

        public const int SIF_ALL = (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS) ;

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct ScrollInfo

        { 

            public int cbSize ; 

            public int fMask ;

            public int nMin ; 

            public int nMax ;

            public int nPage ;

            public int nPos ;

            public int nTrackPos ; 

        }

  

        [StructLayout (LayoutKind.Sequential)] 

        public struct ScrollBarInfo

        { 

            public int cbSize ;

            public Win32Rect rcScrollBar ;

            public int dxyLineButton ;

            public int xyThumbTop ; 

            public int xyThumbBottom ;

            public int reserved ; 

            public int scrollBarInfo ; 

            public int upArrowInfo ;

            public int largeDecrementInfo ; 

            public int thumbnfo ;

            public int largeIncrementInfo ;

            public int downArrowInfo ;

        } 

 

        public const int QS_KEY = 0x0001 ; 

        public const int QS_MOUSEMOVE = 0x0002 ; 

        public const int QS_MOUSEBUTTON = 0x0004 ;

        public const int QS_POSTMESSAGE = 0x0008 ; 

        public const int QS_TIMER = 0x0010 ;

        public const int QS_PAINT = 0x0020 ;

        public const int QS_SENDMESSAGE = 0x0040 ;

        public const int QS_HOTKEY = 0x0080 ; 

        public const int QS_ALLPOSTMESSAGE = 0x0100 ;

        public const int QS_MOUSE = QS_MOUSEMOVE | QS_MOUSEBUTTON ; 

        public const int QS_INPUT = QS_MOUSE | QS_KEY ; 

        public const int QS_ALLEVENTS = QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY ;

        public const int QS_ALLINPUT = QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY | QS_SENDMESSAGE ; 

 

        public const int INFINITE = unchecked((int)0xFFFFFFFF) ;

 

        public const int WAIT_FAILED = unchecked((int)0xFFFFFFFF) ; 

        public const int WAIT_TIMEOUT = 0x00000102 ;

  

        public const int SMTO_BLOCK = 0x0001 ; 

 

        // 

        // INPUT consts and structs

        //

 

        public const int KEYEVENTF_EXTENDEDKEY = 0x0001 ; 

        public const int KEYEVENTF_KEYUP = 0x0002 ;

        public const int KEYEVENTF_SCANCODE = 0x0008 ; 

        public const int MOUSEEVENTF_VIRTUALDESK = 0x4000 ; 

 

        public const int INPUT_MOUSE = 0 ; 

        public const int INPUT_KEYBOARD = 1 ;

 

        [StructLayout(LayoutKind.Sequential)]

        public struct INPUT 

        {

            public int type ; 

            public INPUTUNION union ; 

        } ;

  

        [StructLayout(LayoutKind.Explicit)]

        public struct INPUTUNION

        {

            [FieldOffset(0)] 

            public MOUSEINPUT mouseInput ;

            [FieldOffset(0)] 

            public KEYBDINPUT keyboardInput ; 

        } ;

  

        [StructLayout(LayoutKind.Sequential)]

        public struct MOUSEINPUT

        {

            public int dx ; 

            public int dy ;

            public int mouseData ; 

            public int dwFlags ; 

            public int time ;

            public IntPtr dwExtraInfo ; 

        } ;

 

        [StructLayout(LayoutKind.Sequential)]

        public struct KEYBDINPUT 

        {

            public short wVk ; 

            public short wScan ; 

            public int dwFlags ;

            public int time ; 

            public IntPtr dwExtraInfo ;

        } ;

 

        public const int GA_PARENT = 1 ; 

 

        public const int PM_REMOVE = 0x0001 ; 

  

        public const int HEAP_SHARED = 0x04000000 ;      // Win95 only

  

        public const int PROCESS_VM_OPERATION = 0x0008 ;

        public const int PROCESS_VM_READ = 0x0010 ;

        public const int PROCESS_VM_WRITE = 0x0020 ;

        public const int PROCESS_QUERY_INFORMATION = 0x0400 ; 

        public const int STANDARD_RIGHTS_REQUIRED = 0x000F0000 ;

        public const int SYNCHRONIZE = 0x00100000 ; 

        public const int PROCESS_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFF ; 

 

        public const int CHILD_SELF = 0x0 ; 

 

        public const int ROLE_SYSTEM_MENUBAR = 0x2 ;

        public const int ROLE_SYSTEM_TOOLBAR = 0x16 ;

        public const int ROLE_SYSTEM_CLIENT = 0xa ; 

        public const int ROLE_SYSTEM_MENUPOPUP = 0xb ;

        public const int ROLE_SYSTEM_LINK = 0x1e ; 

        public const int ROLE_SYSTEM_TEXT = 0x0000002A ; 

        public const int ROLE_SYSTEM_BUTTONDROPDOWN   = 0x00000038 ;

        public const int ROLE_SYSTEM_BUTTONMENU = 0x39 ; 

        public const int ROLE_SYSTEM_MENUITEM = 0x0000000C ;

        public const int ROLE_SYSTEM_GROUPING = 0x14 ;

        public const int ROLE_SYSTEM_BUTTONDROPDOWNGRID = 0x0000003A ;

        public const int ROLE_SYSTEM_DROPLIST = 0x0000002F ; 

        public const int ROLE_SYSTEM_LISTITEM = 0x22 ;

  

        public const int ROLE_SYSTEM_PUSHBUTTON = 0x2b ; 

        public const int ROLE_SYSTEM_CHECKBUTTON = 0x2c ;

        public const int ROLE_SYSTEM_RADIOBUTTON = 0x2d ; 

        public const int ROLE_SYSTEM_COMBOBOX = 0x2e ;

        public const int ROLE_SYSTEM_SPINBUTTON = 0x34 ;

 

        public const int STATE_SYSTEM_FLOATING = 0x00001000 ; 

        public const int STATE_SYSTEM_FOCUSED = 0x4 ;

        public const int STATE_SYSTEM_MOVEABLE = 0x00040000 ; 

        public const int STATE_SYSTEM_CHECKED = 0x10 ; 

        public const int STATE_SYSTEM_MIXED = 0x20 ;

        public const int STATE_SYSTEM_UNAVAILABLE = 0x0001 ; 

        public const int STATE_SYSTEM_INVISIBLE = 0x8000 ;

        public const int STATE_SYSTEM_OFFSCREEN = 0x010000 ;

        public const int STATE_SYSTEM_PRESSED = 0x8 ;

        public const int STATE_SYSTEM_SIZEABLE = 0x00020000 ; 

        public const int STATE_SYSTEM_HOTTRACKED = 0x00000080 ;

  

        public const int CBS_SIMPLE = 0x0001 ; 

        public const int CBS_DROPDOWN = 0x0002 ;

        public const int CBS_DROPDOWNLIST = 0x0003 ; 

        public const int CBS_COMBOTYPEMASK = 0x0003 ;

 

        public const int CBN_EDITUPDATE = 6 ;

        public const int CBN_DROPDOWN = 7 ; 

 

        [StructLayout (LayoutKind.Sequential)] 

        public struct COMBOBOXINFO 

        {

            public int cbSize ; 

            public Win32Rect rcItem ;

            public Win32Rect rcButton ;

            public int stateButton ;

            public IntPtr hwndCombo ; 

            public IntPtr hwndItem ;

            public IntPtr hwndList ; 

  

            public COMBOBOXINFO(int size)

            { 

                cbSize = size ;

                rcItem = Win32Rect.Empty ;

                rcButton = Win32Rect.Empty ;

                stateButton = 0 ; 

                hwndCombo = IntPtr.Zero ;

                hwndItem = IntPtr.Zero ; 

                hwndList = IntPtr.Zero ; 

            }

        } ; 

        public static int comboboxInfoSize = Marshal.SizeOf(typeof(NativeMethods.COMBOBOXINFO)) ;

 

        [StructLayout (LayoutKind.Sequential)]

        public struct MENUBARINFO 

        {

            public int cbSize ; 

            public Win32Rect rcBar ; 

            public IntPtr hMenu ;

            public IntPtr hwndMenu ; 

            public int focusFlags ;

        }

 

        public const int GUI_CARETBLINKING = 0x00000001 ; 

        public const int GUI_INMOVESIZE = 0x00000002 ;

        public const int GUI_INMENUMODE = 0x00000004 ; 

        public const int GUI_SYSTEMMENUMODE = 0x00000008 ; 

        public const int GUI_POPUPMENUMODE = 0x00000010 ;

  

        [StructLayout(LayoutKind.Sequential)]

        public struct GUITHREADINFO

        {

            public int cbSize ; 

            public int dwFlags ;

            public IntPtr hwndActive ; 

            public IntPtr hwndFocus ; 

            public IntPtr hwndCapture ;

            public IntPtr hwndMenuOwner ; 

            public IntPtr hwndMoveSize ;

            public IntPtr hwndCaret ;

            public Win32Rect rc ;

        } 

 

        // 

        // Menu consts and structs 

        //

  

        public const int MF_BYCOMMAND = 0x00000000 ;

        public const int MF_GRAYED = 0x00000001 ;

        public const int MF_DISABLED = 0x00000002 ;

        public const int MF_BITMAP = 0x00000004 ; 

        public const int MF_CHECKED = 0x00000008 ;

        public const int MF_MENUBARBREAK = 0x00000020 ; 

        public const int MF_MENUBREAK = 0x00000040 ; 

        public const int MF_HILITE = 0x00000080 ;

        public const int MF_OWNERDRAW = 0x00000100 ; 

        public const int MF_BYPOSITION = 0x00000400 ;

        public const int MF_SEPARATOR = 0x00000800 ;

 

        public const int MFT_RADIOCHECK = 0x00000200 ; 

 

        public const int MIIM_STATE = 0x00000001 ; 

        public const int MIIM_ID = 0x00000002 ; 

        public const int MIIM_SUBMENU = 0x00000004 ;

        public const int MIIM_CHECKMARKS = 0x00000008 ; 

        public const int MIIM_TYPE = 0x00000010 ;

        public const int MIIM_DATA = 0x00000020 ;

        public const int MIIM_FTYPE = 0x00000100 ;

  

        // obtain the HMENU from the hwnd

        public const int MN_GETHMENU = 0x01E1 ; 

  

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]

        public struct MENUITEMINFO 

        {

            public int cbSize ;

            public int fMask ;

            public int fType ; 

            public int fState ;

            public int wID ; 

            public IntPtr hSubMenu ; 

            public IntPtr hbmpChecked ;

            public IntPtr hbmpUnchecked ; 

            public IntPtr dwItemData ;

            public IntPtr dwTypeData ;

            public int cch ;

            public IntPtr hbmpItem ; 

        }

  

        #region REBAR Constants and Structs 

 

        [StructLayout (LayoutKind.Sequential)] 

        public struct RB_HITTESTINFO

        {

            public Win32Point pt ;

            public uint uFlags ; 

            public int iBand ;

        } 

  

        [StructLayout (LayoutKind.Sequential)]

        public struct REBARBANDINFO 

        {

            public uint cbSize ;

            public uint fMask ;

            public uint fStyle ; 

            public int clrFore ;

            public int clrBack ; 

            public IntPtr lpText ; 

            public uint cch ;

            public int iImage ; 

            public IntPtr hwndChild ;

            public uint cxMinChild ;

            public uint cyMinChild ;

            public uint cx ; 

            public IntPtr hbmBack ;

            public uint wID ; 

            public uint cyChild ; 

            public uint cyMaxChild ;

            public uint cyIntegral ; 

            public uint cxIdeal ;

            public IntPtr lParam ;

            public uint cxHeader ;

        } 

 

        // 

        // TreeView constants and strucs 

        //

  

        public const int TVIF_TEXT = 0x0001 ;

        public const int TVIF_IMAGE = 0x0002 ;

        public const int TVIF_STATE = 0x0008 ;

        public const int TVIF_CHILDREN = 0x0040 ; 

 

        public const int TVIS_SELECTED = 0x0002 ; 

        public const int TVIS_EXPANDED = 0x0020 ; 

        public const int TVIS_STATEIMAGEMASK = 0xF000 ;

  

        public const int TVGN_ROOT = 0x0000 ;

        public const int TVGN_NEXT = 0x0001 ;

        public const int TVGN_PREVIOUS = 0x0002 ;

        public const int TVGN_PARENT = 0x0003 ; 

        public const int TVGN_CHILD = 0x0004 ;

        public const int TVGN_CARET = 0x0009 ; 

  

        // note: this flag has effect only on WinXP and up

        public const int TVSI_NOSINGLEEXPAND = 0x8000 ; 

 

        public const int TVE_COLLAPSE = 0x0001 ;

        public const int TVE_EXPAND = 0x0002 ;

  

        // style

        public const int TVS_EDITLABELS = 0x0008 ; 

        public const int TVS_CHECKBOXES = 0x0100 ; 

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct TVITEM

        {

            public uint mask ;

            public IntPtr hItem ; 

            public uint state ;

            public uint stateMask ; 

            public IntPtr pszText ; 

            public int cchTextMax ;

            public int iImage ; 

            public int iSelectedImage ;

            public int cChildren ;

            public IntPtr lParam ;

  

            public void Init (IntPtr item)

            { 

                mask = 0 ; 

                hItem = item ;

                state = 0 ; 

                stateMask = 0 ;

                pszText = IntPtr.Zero ;

                cchTextMax = 0 ;

                iImage = 0 ; 

                iSelectedImage = 0 ;

                cChildren = 0 ; 

                lParam = IntPtr.Zero ; 

            }

        } 

 

        [StructLayout (LayoutKind.Sequential)]

        public struct TVHITTESTINFO

        { 

            public Win32Point pt ;

            public uint flags ; 

            public IntPtr hItem ; 

 

            public TVHITTESTINFO (int x, int y, uint flg) 

            {

                pt.x = x ;

                pt.y = y ;

                flags = flg ; 

                hItem = IntPtr.Zero ;

            } 

        } 

 

        #endregion 

 

        public const int INDEX_TITLEBAR_SELF        = 0 ;

        public const int INDEX_TITLEBAR_IMEBUTTON   = 1 ;

        public const int INDEX_TITLEBAR_MINBUTTON   = 2 ; 

        public const int INDEX_TITLEBAR_MAXBUTTON   = 3 ;

        public const int INDEX_TITLEBAR_HELPBUTTON  = 4 ; 

        public const int INDEX_TITLEBAR_CLOSEBUTTON = 5 ; 

 

        public const int INDEX_TITLEBAR_MIC = 1 ; 

        public const int INDEX_TITLEBAR_MAC = 5 ;

        public const int CCHILDREN_TITLEBAR = 5 ;

 

        // Hit Test areas 

        public const int HTTRANSPARENT = -1 ;

        public const int HTCAPTION = 2 ; 

        public const int HTSYSMENU = 3 ; 

        public const int HTGROWBOX = 4 ;

        public const int HTMENU = 5 ; 

        public const int HTHSCROLL = 6 ;

        public const int HTVSCROLL = 7 ;

        public const int HTMINBUTTON = 8 ;

        public const int HTMAXBUTTON = 9 ; 

        public const int HTLEFT = 10 ;

        public const int HTRIGHT = 11 ; 

        public const int HTTOP = 12 ; 

        public const int HTTOPLEFT = 13 ;

        public const int HTTOPRIGHT = 14 ; 

        public const int HTBOTTOM = 15 ;

        public const int HTBOTTOMLEFT = 16 ;

        public const int HTBOTTOMRIGHT = 17 ;

        public const int HTBORDER = 18 ; 

        public const int HTCLOSE =  20 ;

        public const int HTHELP = 21 ; 

        public const int HTMDIMAXBUTTON = 66 ; 

        public const int HTMDIMINBUTTON = 67 ;

        public const int HTMDICLOSE = 68 ; 

 

        // System Commands

        public const int SC_MINIMIZE = 0xF020 ;

        public const int SC_MAXIMIZE = 0xF030 ; 

        public const int SC_CLOSE = 0xF060 ;

        public const int SC_KEYMENU = 0xF100 ; 

        public const int SC_RESTORE = 0xF120 ; 

        public const int SC_CONTEXTHELP = 0xF180 ;

  

        // WinEvent specific consts and delegates

 

        public const int WINEVENT_OUTOFCONTEXT = 0x0000 ;

  

        public const int EVENT_MIN = 0x00000001 ;

        public const int EVENT_MAX = 0x7FFFFFFF ; 

  

        public const int EVENT_SYSTEM_SOUND = 0x0001 ;

        public const int EVENT_SYSTEM_ALERT = 0x0002 ; 

        public const int EVENT_SYSTEM_FOREGROUND = 0x0003 ;

        public const int EVENT_SYSTEM_MENUSTART = 0x0004 ;

        public const int EVENT_SYSTEM_MENUEND = 0x0005 ;

        public const int EVENT_SYSTEM_MENUPOPUPSTART = 0x0006 ; 

        public const int EVENT_SYSTEM_MENUPOPUPEND = 0x0007 ;

        public const int EVENT_SYSTEM_CAPTURESTART = 0x0008 ; 

        public const int EVENT_SYSTEM_CAPTUREEND = 0x0009 ; 

        public const int EVENT_SYSTEM_MOVESIZESTART = 0x000A ;

        public const int EVENT_SYSTEM_MOVESIZEEND = 0x000B ; 

        public const int EVENT_SYSTEM_CONTEXTHELPSTART = 0x000C ;

        public const int EVENT_SYSTEM_CONTEXTHELPEND = 0x000D ;

        public const int EVENT_SYSTEM_DRAGDROPSTART = 0x000E ;

        public const int EVENT_SYSTEM_DRAGDROPEND = 0x000F ; 

        public const int EVENT_SYSTEM_DIALOGSTART = 0x0010 ;

        public const int EVENT_SYSTEM_DIALOGEND = 0x0011 ; 

        public const int EVENT_SYSTEM_SCROLLINGSTART = 0x0012 ; 

        public const int EVENT_SYSTEM_SCROLLINGEND = 0x0013 ;

        public const int EVENT_SYSTEM_SWITCHEND = 0x0015 ; 

        public const int EVENT_SYSTEM_MINIMIZESTART = 0x0016 ;

        public const int EVENT_SYSTEM_MINIMIZEEND = 0x0017 ;

        public const int EVENT_SYSTEM_PAINT = 0x0019 ;

        public const int EVENT_CONSOLE_CARET = 0x4001 ; 

        public const int EVENT_CONSOLE_UPDATE_REGION = 0x4002 ;

        public const int EVENT_CONSOLE_UPDATE_SIMPLE = 0x4003 ; 

        public const int EVENT_CONSOLE_UPDATE_SCROLL = 0x4004 ; 

        public const int EVENT_CONSOLE_LAYOUT = 0x4005 ;

        public const int EVENT_CONSOLE_START_APPLICATION = 0x4006 ; 

        public const int EVENT_CONSOLE_END_APPLICATION = 0x4007 ;

        public const int EVENT_OBJECT_CREATE = 0x8000 ;

        public const int EVENT_OBJECT_DESTROY = 0x8001 ;

        public const int EVENT_OBJECT_SHOW = 0x8002 ; 

        public const int EVENT_OBJECT_HIDE = 0x8003 ;

        public const int EVENT_OBJECT_REORDER = 0x8004 ; 

        public const int EVENT_OBJECT_FOCUS = 0x8005 ; 

        public const int EVENT_OBJECT_SELECTION = 0x8006 ;

        public const int EVENT_OBJECT_SELECTIONADD = 0x8007 ; 

        public const int EVENT_OBJECT_SELECTIONREMOVE = 0x8008 ;

        public const int EVENT_OBJECT_SELECTIONWITHIN = 0x8009 ;

        public const int EVENT_OBJECT_STATECHANGE = 0x800A ;

        public const int EVENT_OBJECT_LOCATIONCHANGE = 0x800B ; 

        public const int EVENT_OBJECT_NAMECHANGE = 0x800C ;

        public const int EVENT_OBJECT_DESCRIPTIONCHANGE = 0x800D ; 

        public const int EVENT_OBJECT_VALUECHANGE = 0x800E ; 

        public const int EVENT_OBJECT_PARENTCHANGE = 0x800F ;

        public const int EVENT_OBJECT_HELPCHANGE = 0x8010 ; 

        public const int EVENT_OBJECT_DEFACTIONCHANGE = 0x8011 ;

        public const int EVENT_OBJECT_ACCELERATORCHANGE = 0x8012 ;

 

        // WinEvent fired when new Avalon UI is created 

        public const int EventObjectUIFragmentCreate = 0x6FFFFFFF ;

  

        // the delegate passed to USER for receiving a WinEvent 

        public delegate void WinEventProcDef(int winEventHook, int eventId, IntPtr hwnd, int idObject, int idChild, int eventThread, uint eventTime) ;

  

        //

        // SysTabControl32 constants and strucs

        //

  

        public const int TCIF_TEXT          = 0x0001 ;

        public const int TCIF_STATE         = 0x0010 ; 

  

        public const int TCIS_BUTTONPRESSED = 0x0001 ;

  

        public const int TCS_RIGHT          = 0x0002 ;

        public const int TCS_MULTISELECT    = 0x0004 ;

        public const int TCS_VERTICAL       = 0x0080 ;

        public const int TCS_BUTTONS        = 0x0100 ; 

        public const int TCS_MULTILINE      = 0x0200 ;

        public const int TCS_FOCUSNEVER     = 0x8000 ; 

  

        [StructLayout(LayoutKind.Sequential)]

        public struct TCITEM 

        {

            public int mask ;

            public int dwState ;

            public int dwStateMask ; 

            public IntPtr pszText ;

            public int cchTextMax ; 

            public int iImage ; 

            public IntPtr lParam ;

  

            public void Init()

            {

                mask = 0 ;

                dwState = 0 ; 

                dwStateMask = 0 ;

                pszText = IntPtr.Zero ; 

                cchTextMax = 0 ; 

                iImage = 0 ;

                lParam = IntPtr.Zero ; 

            }

 

            public void Init(int m)

            { 

                mask = m ;

                dwState = 0 ; 

                dwStateMask = 0 ; 

                pszText = IntPtr.Zero ;

                cchTextMax = 0 ; 

                iImage = 0 ;

                lParam = IntPtr.Zero ;

            }

        } 

 

        // 

        // SysHeader constants and strucs 

        //

  

        public const uint HDI_TEXT = 0x0002 ;

        public const uint HDI_FORMAT = 0x0004 ;

        public const uint HDI_ORDER = 0x0080 ;

  

        public const int HDS_BUTTONS = 0x0002 ;

        public const int HDS_HIDDEN = 0x0008 ; 

        public const int HDS_FILTERBAR = 0x0100 ; 

 

        public const int HDF_SORTUP = 0x0400 ; 

        public const int HDF_SORTDOWN = 0x0200 ;

        public const int HDF_SPLITBUTTON = 0x1000000 ;

 

        public const int HHT_ONHEADER = 0x0002 ; 

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct HDITEM 

        {

            public uint mask ; 

            public int cxy ;

            public IntPtr pszText ;

            public IntPtr hbm ;

            public int cchTextMax ; 

            public int fmt ;

            public IntPtr lParam ; 

            public int iImage ; 

            public int iOrder ;

            public uint type ; 

            public IntPtr pvFilter ;

 

            public void Init()

            { 

                mask = 0 ;

                cxy = 0 ; 

                pszText = IntPtr.Zero ; 

                hbm = IntPtr.Zero ;

                cchTextMax = 0 ; 

                fmt = 0 ;

                lParam = IntPtr.Zero ;

                iImage = 0 ;

                iOrder = 0 ; 

                type = 0 ;

                pvFilter = IntPtr.Zero ; 

            } 

 

            // return an empty HDITEM 

            public static readonly HDITEM Empty = new HDITEM() ;

        }

 

        [StructLayout(LayoutKind.Sequential)] 

        public struct HDHITTESTINFO

        { 

            public NativeMethods.Win32Point pt ; 

            public uint flags ;

            public int item ; 

        }

 

        //

        // Win32 Hyperlink constants and strucs 

        //

  

        public const int LIF_ITEMINDEX = 0x00000001 ; 

        public const int LIF_STATE = 0x00000002 ;

        public const int LIF_ITEMID = 0x00000004 ; 

        public const int LIF_URL = 0x00000008 ;

 

        public const int LIS_FOCUSED = 0x00000001 ;

        public const int LIS_ENABLED = 0x00000002 ; 

        public const int LIS_VISITED = 0x00000004 ;

  

        public const int L_MAX_URL_LENGTH = 2048 + 32 + 3 ; 

 

  

        //

        //  Win32API SpinControl constants

        //

  

        public const int UDS_HORZ = 0x0040 ;

  

  

        //

        // Tooltip strucs 

        //

 

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]

        public struct TOOLINFO 

        {

            public int cbSize ; 

            public int uFlags ; 

            public IntPtr hwnd ;

            public int uId ; 

            public Win32Rect rect ;

            public IntPtr hinst ;

            public IntPtr pszText ;

            public IntPtr lParam ; 

 

            public void Init(int size) 

            { 

                cbSize = size ;

                uFlags = 0 ; 

                hwnd = IntPtr.Zero ;

                uId = 0 ;

                rect = Win32Rect.Empty ;

                hinst = IntPtr.Zero ; 

                pszText = IntPtr.Zero ;

                lParam = IntPtr.Zero ; 

            } 

        }

  

        public const int TTF_IDISHWND = 0x0001 ;

    }

}
