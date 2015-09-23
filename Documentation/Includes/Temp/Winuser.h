#include <stdarg.h>


/*
 * Low level hook flags
 */

#define LLKHF_EXTENDED       (KF_EXTENDED >> 8)
#define LLKHF_INJECTED       0x00000010
#define LLKHF_ALTDOWN        (KF_ALTDOWN >> 8)
#define LLKHF_UP             (KF_UP >> 8)

#define LLMHF_INJECTED       0x00000001

/*
 * Structure used by WH_KEYBOARD_LL
 */
typedef struct tagKBDLLHOOKSTRUCT {
    DWORD   vkCode;
    DWORD   scanCode;
    DWORD   flags;
    DWORD   time;
    ULONG_PTR dwExtraInfo;
} KBDLLHOOKSTRUCT, FAR *LPKBDLLHOOKSTRUCT, *PKBDLLHOOKSTRUCT;

/*
 * Structure used by WH_MOUSE_LL
 */
typedef struct tagMSLLHOOKSTRUCT {
    POINT   pt;
    DWORD   mouseData;
    DWORD   flags;
    DWORD   time;
    ULONG_PTR dwExtraInfo;
} MSLLHOOKSTRUCT, FAR *LPMSLLHOOKSTRUCT, *PMSLLHOOKSTRUCT;

#endif // (_WIN32_WINNT >= 0x0400)

/*
 * Structure used by WH_DEBUG
 */
typedef struct tagDEBUGHOOKINFO
{
    DWORD   idThread;
    DWORD   idThreadInstaller;
    LPARAM  lParam;
    WPARAM  wParam;
    int     code;
} DEBUGHOOKINFO, *PDEBUGHOOKINFO, NEAR *NPDEBUGHOOKINFO, FAR* LPDEBUGHOOKINFO;

/*
 * Structure used by WH_MOUSE
 */
typedef struct tagMOUSEHOOKSTRUCT {
    POINT   pt;
    HWND    hwnd;
    UINT    wHitTestCode;
    ULONG_PTR dwExtraInfo;
} MOUSEHOOKSTRUCT, FAR *LPMOUSEHOOKSTRUCT, *PMOUSEHOOKSTRUCT;

#if(_WIN32_WINNT >= 0x0500)
#ifdef __cplusplus
typedef struct tagMOUSEHOOKSTRUCTEX : public tagMOUSEHOOKSTRUCT
{
    DWORD   mouseData;
} MOUSEHOOKSTRUCTEX, *LPMOUSEHOOKSTRUCTEX, *PMOUSEHOOKSTRUCTEX;
#else // ndef __cplusplus
typedef struct tagMOUSEHOOKSTRUCTEX
{
    MOUSEHOOKSTRUCT;
    DWORD   mouseData;
} MOUSEHOOKSTRUCTEX, *LPMOUSEHOOKSTRUCTEX, *PMOUSEHOOKSTRUCTEX;
#endif
#endif /* _WIN32_WINNT >= 0x0500 */

#if(WINVER >= 0x0400)
/*
 * Structure used by WH_HARDWARE
 */
typedef struct tagHARDWAREHOOKSTRUCT {
    HWND    hwnd;
    UINT    message;
    WPARAM  wParam;
    LPARAM  lParam;
} HARDWAREHOOKSTRUCT, FAR *LPHARDWAREHOOKSTRUCT, *PHARDWAREHOOKSTRUCT;
#endif /* WINVER >= 0x0400 */
#endif /* !NOWH */

#if(WINVER >= 0x0500)
/*
 * Bits in wParam of WM_INPUTLANGCHANGEREQUEST message
 */
#define INPUTLANGCHANGE_SYSCHARSET 0x0001
#define INPUTLANGCHANGE_FORWARD    0x0002
#define INPUTLANGCHANGE_BACKWARD   0x0004
#endif /* WINVER >= 0x0500 */


#if(WINVER >= 0x0500)

typedef struct tagMOUSEMOVEPOINT {
    int   x;
    int   y;
    DWORD time;
    ULONG_PTR dwExtraInfo;
} MOUSEMOVEPOINT, *PMOUSEMOVEPOINT, FAR* LPMOUSEMOVEPOINT;

/*
 * Values for resolution parameter of GetMouseMovePointsEx
 */
#define GMMP_USE_DISPLAY_POINTS          1
#define GMMP_USE_HIGH_RESOLUTION_POINTS  2

WINUSERAPI
int
WINAPI
GetMouseMovePointsEx(
    __in UINT cbSize,
    __in LPMOUSEMOVEPOINT lppt,
    __out_ecount(nBufPoints) LPMOUSEMOVEPOINT lpptBuf,
    __in int nBufPoints,
    __in DWORD resolution);

#endif /* WINVER >= 0x0500 */

#ifndef NODESKTOP
/*
 * Desktop-specific access flags
 */
#define DESKTOP_READOBJECTS         0x0001L
#define DESKTOP_CREATEWINDOW        0x0002L
#define DESKTOP_CREATEMENU          0x0004L
#define DESKTOP_HOOKCONTROL         0x0008L
#define DESKTOP_JOURNALRECORD       0x0010L
#define DESKTOP_JOURNALPLAYBACK     0x0020L
#define DESKTOP_ENUMERATE           0x0040L
#define DESKTOP_WRITEOBJECTS        0x0080L
#define DESKTOP_SWITCHDESKTOP       0x0100L

/*
 * Desktop-specific control flags
 */
#define DF_ALLOWOTHERACCOUNTHOOK    0x0001L

#ifdef _WINGDI_
#ifndef NOGDI

WINUSERAPI
HDESK
WINAPI
CreateDesktopA(
    __in LPCSTR lpszDesktop,
    __reserved LPCSTR lpszDevice,
    __reserved DEVMODEA* pDevmode,
    __in DWORD dwFlags,
    __in ACCESS_MASK dwDesiredAccess,
    __in_opt LPSECURITY_ATTRIBUTES lpsa);
WINUSERAPI
HDESK
WINAPI
CreateDesktopW(
    __in LPCWSTR lpszDesktop,
    __reserved LPCWSTR lpszDevice,
    __reserved DEVMODEW* pDevmode,
    __in DWORD dwFlags,
    __in ACCESS_MASK dwDesiredAccess,
    __in_opt LPSECURITY_ATTRIBUTES lpsa);
#ifdef UNICODE
#define CreateDesktop  CreateDesktopW
#else
#define CreateDesktop  CreateDesktopA
#endif // !UNICODE

WINUSERAPI
HDESK
WINAPI
CreateDesktopExA(
    __in LPCSTR lpszDesktop,
    __reserved LPCSTR lpszDevice,
    __reserved DEVMODEA* pDevmode,
    __in DWORD dwFlags,
    __in ACCESS_MASK dwDesiredAccess,
    __in_opt LPSECURITY_ATTRIBUTES lpsa,
    __in ULONG ulHeapSize,
    __reserved PVOID pvoid);
WINUSERAPI
HDESK
WINAPI
CreateDesktopExW(
    __in LPCWSTR lpszDesktop,
    __reserved LPCWSTR lpszDevice,
    __reserved DEVMODEW* pDevmode,
    __in DWORD dwFlags,
    __in ACCESS_MASK dwDesiredAccess,
    __in_opt LPSECURITY_ATTRIBUTES lpsa,
    __in ULONG ulHeapSize,
    __reserved PVOID pvoid);
#ifdef UNICODE
#define CreateDesktopEx  CreateDesktopExW
#else
#define CreateDesktopEx  CreateDesktopExA
#endif // !UNICODE

#endif /* NOGDI */
#endif /* _WINGDI_ */

WINUSERAPI
HDESK
WINAPI
OpenDesktopA(
    __in LPCSTR lpszDesktop,
    __in DWORD dwFlags,
    __in BOOL fInherit,
    __in ACCESS_MASK dwDesiredAccess);
WINUSERAPI
HDESK
WINAPI
OpenDesktopW(
    __in LPCWSTR lpszDesktop,
    __in DWORD dwFlags,
    __in BOOL fInherit,
    __in ACCESS_MASK dwDesiredAccess);
#ifdef UNICODE
#define OpenDesktop  OpenDesktopW
#else
#define OpenDesktop  OpenDesktopA
#endif // !UNICODE

WINUSERAPI
HDESK
WINAPI
OpenInputDesktop(
    __in DWORD dwFlags,
    __in BOOL fInherit,
    __in ACCESS_MASK dwDesiredAccess);


WINUSERAPI
BOOL
WINAPI
EnumDesktopsA(
    __in_opt HWINSTA hwinsta,
    __in DESKTOPENUMPROCA lpEnumFunc,
    __in LPARAM lParam);
WINUSERAPI
BOOL
WINAPI
EnumDesktopsW(
    __in_opt HWINSTA hwinsta,
    __in DESKTOPENUMPROCW lpEnumFunc,
    __in LPARAM lParam);
#ifdef UNICODE
#define EnumDesktops  EnumDesktopsW
#else
#define EnumDesktops  EnumDesktopsA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
EnumDesktopWindows(
    __in_opt HDESK hDesktop,
    __in WNDENUMPROC lpfn,
    __in LPARAM lParam);

WINUSERAPI
BOOL
WINAPI
SwitchDesktop(
    __in HDESK hDesktop);


WINUSERAPI
BOOL
WINAPI
SetThreadDesktop(
     __in HDESK hDesktop);

WINUSERAPI
BOOL
WINAPI
CloseDesktop(
    __in HDESK hDesktop);

WINUSERAPI
HDESK
WINAPI
GetThreadDesktop(
    __in DWORD dwThreadId);

#endif  /* !NODESKTOP */

#ifndef NOWINDOWSTATION
/*
 * Windowstation-specific access flags
 */
#define WINSTA_ENUMDESKTOPS         0x0001L
#define WINSTA_READATTRIBUTES       0x0002L
#define WINSTA_ACCESSCLIPBOARD      0x0004L
#define WINSTA_CREATEDESKTOP        0x0008L
#define WINSTA_WRITEATTRIBUTES      0x0010L
#define WINSTA_ACCESSGLOBALATOMS    0x0020L
#define WINSTA_EXITWINDOWS          0x0040L
#define WINSTA_ENUMERATE            0x0100L
#define WINSTA_READSCREEN           0x0200L

#define WINSTA_ALL_ACCESS           (WINSTA_ENUMDESKTOPS  | WINSTA_READATTRIBUTES  | WINSTA_ACCESSCLIPBOARD | \
                                     WINSTA_CREATEDESKTOP | WINSTA_WRITEATTRIBUTES | WINSTA_ACCESSGLOBALATOMS | \
                                     WINSTA_EXITWINDOWS   | WINSTA_ENUMERATE       | WINSTA_READSCREEN)

/*
 * Windowstation creation flags.
 */
#define CWF_CREATE_ONLY          0x00000001

/*
 * Windowstation-specific attribute flags
 */
#define WSF_VISIBLE                 0x0001L

WINUSERAPI
HWINSTA
WINAPI
CreateWindowStationA(
    __in_opt LPCSTR lpwinsta,
    __in DWORD dwFlags,
    __in ACCESS_MASK dwDesiredAccess,
    __in_opt LPSECURITY_ATTRIBUTES lpsa);
WINUSERAPI
HWINSTA
WINAPI
CreateWindowStationW(
    __in_opt LPCWSTR lpwinsta,
    __in DWORD dwFlags,
    __in ACCESS_MASK dwDesiredAccess,
    __in_opt LPSECURITY_ATTRIBUTES lpsa);
#ifdef UNICODE
#define CreateWindowStation  CreateWindowStationW
#else
#define CreateWindowStation  CreateWindowStationA
#endif // !UNICODE

WINUSERAPI
HWINSTA
WINAPI
OpenWindowStationA(
    __in LPCSTR lpszWinSta,
    __in BOOL fInherit,
    __in ACCESS_MASK dwDesiredAccess);
WINUSERAPI
HWINSTA
WINAPI
OpenWindowStationW(
    __in LPCWSTR lpszWinSta,
    __in BOOL fInherit,
    __in ACCESS_MASK dwDesiredAccess);
#ifdef UNICODE
#define OpenWindowStation  OpenWindowStationW
#else
#define OpenWindowStation  OpenWindowStationA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
EnumWindowStationsA(
    __in WINSTAENUMPROCA lpEnumFunc,
    __in LPARAM lParam);
WINUSERAPI
BOOL
WINAPI
EnumWindowStationsW(
    __in WINSTAENUMPROCW lpEnumFunc,
    __in LPARAM lParam);
#ifdef UNICODE
#define EnumWindowStations  EnumWindowStationsW
#else
#define EnumWindowStations  EnumWindowStationsA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
CloseWindowStation(
    __in HWINSTA hWinSta);

WINUSERAPI
BOOL
WINAPI
SetProcessWindowStation(
    __in HWINSTA hWinSta);

WINUSERAPI
HWINSTA
WINAPI
GetProcessWindowStation(
    VOID);
#endif  /* !NOWINDOWSTATION */

#ifndef NOSECURITY

WINUSERAPI
BOOL
WINAPI
SetUserObjectSecurity(
    __in HANDLE hObj,
    __in PSECURITY_INFORMATION pSIRequested,
    __in PSECURITY_DESCRIPTOR pSID);

WINUSERAPI
BOOL
WINAPI
GetUserObjectSecurity(
    __in HANDLE hObj,
    __in PSECURITY_INFORMATION pSIRequested,
    __out_bcount_opt(nLength) PSECURITY_DESCRIPTOR pSID,
    __in DWORD nLength,
    __out LPDWORD lpnLengthNeeded);

#define UOI_FLAGS       1
#define UOI_NAME        2
#define UOI_TYPE        3
#define UOI_USER_SID    4
#if(WINVER >= 0x0600)
#define UOI_HEAPSIZE    5
#define UOI_IO          6
#endif /* WINVER >= 0x0600 */

typedef struct tagUSEROBJECTFLAGS {
    BOOL fInherit;
    BOOL fReserved;
    DWORD dwFlags;
} USEROBJECTFLAGS, *PUSEROBJECTFLAGS;

WINUSERAPI
BOOL
WINAPI
GetUserObjectInformationA(
    __in HANDLE hObj,
    __in int nIndex,
    __out_bcount_opt(nLength) PVOID pvInfo,
    __in DWORD nLength,
    __out_opt LPDWORD lpnLengthNeeded);
WINUSERAPI
BOOL
WINAPI
GetUserObjectInformationW(
    __in HANDLE hObj,
    __in int nIndex,
    __out_bcount_opt(nLength) PVOID pvInfo,
    __in DWORD nLength,
    __out_opt LPDWORD lpnLengthNeeded);
#ifdef UNICODE
#define GetUserObjectInformation  GetUserObjectInformationW
#else
#define GetUserObjectInformation  GetUserObjectInformationA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
SetUserObjectInformationA(
    __in HANDLE hObj,
    __in int nIndex,
    __in_bcount(nLength) PVOID pvInfo,
    __in DWORD nLength);
WINUSERAPI
BOOL
WINAPI
SetUserObjectInformationW(
    __in HANDLE hObj,
    __in int nIndex,
    __in_bcount(nLength) PVOID pvInfo,
    __in DWORD nLength);
#ifdef UNICODE
#define SetUserObjectInformation  SetUserObjectInformationW
#else
#define SetUserObjectInformation  SetUserObjectInformationA
#endif // !UNICODE

#endif  /* !NOSECURITY */


#define POINTSTOPOINT(pt, pts)                          \
        { (pt).x = (LONG)(SHORT)LOWORD(*(LONG*)&pts);   \
          (pt).y = (LONG)(SHORT)HIWORD(*(LONG*)&pts); }

#define POINTTOPOINTS(pt)      (MAKELONG((short)((pt).x), (short)((pt).y)))



/*
 * HIWORD(wParam) values in WM_*UISTATE*
 */
#define UISF_HIDEFOCUS                  0x1
#define UISF_HIDEACCEL                  0x2
#if(_WIN32_WINNT >= 0x0501)
#define UISF_ACTIVE                     0x4
#endif /* _WIN32_WINNT >= 0x0501 */
#endif /* _WIN32_WINNT >= 0x0500 */
#endif

#endif
#endif /* WINVER >= 0x0500 */


/* Value for rolling one detent */
#define WHEEL_DELTA                     120

/* Setting to scroll one page for SPI_GET/SETWHEELSCROLLLINES */
#define WHEEL_PAGESCROLL                (UINT_MAX)
#define GET_NCHITTEST_WPARAM(wParam)    ((short)LOWORD(wParam))
#define GET_XBUTTON_WPARAM(wParam)      (HIWORD(wParam))

/* XButton values are WORD flags */
#define XBUTTON1      0x0001
#define XBUTTON2      0x0002
/* Were there to be an XBUTTON3, its value would be 0x0004 */


typedef struct {
    GUID PowerSetting;
    DWORD DataLength;
    UCHAR Data[1];
} POWERBROADCAST_SETTING, *PPOWERBROADCAST_SETTING;


/*
 * SendMessageTimeout values
 */
#define SMTO_NORMAL         0x0000
#define SMTO_BLOCK          0x0001
#define SMTO_ABORTIFHUNG    0x0002
#if(WINVER >= 0x0500)
#define SMTO_NOTIMEOUTIFNOTHUNG 0x0008
#endif /* WINVER >= 0x0500 */
#if(WINVER >= 0x0600)
#define SMTO_ERRORONEXIT    0x0020
#endif /* WINVER >= 0x0600 */

#endif /* !NONCMESSAGES */

/*
 * WM_NCCALCSIZE parameter structure
 */
typedef struct tagNCCALCSIZE_PARAMS {
    RECT       rgrc[3];
    PWINDOWPOS lppos;
} NCCALCSIZE_PARAMS, *LPNCCALCSIZE_PARAMS;


#if(_WIN32_WINNT >= 0x0400)
#ifndef NOTRACKMOUSEEVENT

#define TME_HOVER       0x00000001
#define TME_LEAVE       0x00000002
#if(WINVER >= 0x0500)
#define TME_NONCLIENT   0x00000010
#endif /* WINVER >= 0x0500 */
#define TME_QUERY       0x40000000
#define TME_CANCEL      0x80000000


#define HOVER_DEFAULT   0xFFFFFFFF
#endif /* _WIN32_WINNT >= 0x0400 */

#if(_WIN32_WINNT >= 0x0400)
typedef struct tagTRACKMOUSEEVENT {
    DWORD cbSize;
    DWORD dwFlags;
    HWND  hwndTrack;
    DWORD dwHoverTime;
} TRACKMOUSEEVENT, *LPTRACKMOUSEEVENT;

WINUSERAPI
BOOL
WINAPI
TrackMouseEvent(
    __inout LPTRACKMOUSEEVENT lpEventTrack);
#endif /* _WIN32_WINNT >= 0x0400 */


/* 3D border styles */
#define BDR_RAISEDOUTER 0x0001
#define BDR_SUNKENOUTER 0x0002
#define BDR_RAISEDINNER 0x0004
#define BDR_SUNKENINNER 0x0008

#define BDR_OUTER       (BDR_RAISEDOUTER | BDR_SUNKENOUTER)
#define BDR_INNER       (BDR_RAISEDINNER | BDR_SUNKENINNER)
#define BDR_RAISED      (BDR_RAISEDOUTER | BDR_RAISEDINNER)
#define BDR_SUNKEN      (BDR_SUNKENOUTER | BDR_SUNKENINNER)


#define EDGE_RAISED     (BDR_RAISEDOUTER | BDR_RAISEDINNER)
#define EDGE_SUNKEN     (BDR_SUNKENOUTER | BDR_SUNKENINNER)
#define EDGE_ETCHED     (BDR_SUNKENOUTER | BDR_RAISEDINNER)
#define EDGE_BUMP       (BDR_RAISEDOUTER | BDR_SUNKENINNER)

/* Border flags */
#define BF_LEFT         0x0001
#define BF_TOP          0x0002
#define BF_RIGHT        0x0004
#define BF_BOTTOM       0x0008

#define BF_TOPLEFT      (BF_TOP | BF_LEFT)
#define BF_TOPRIGHT     (BF_TOP | BF_RIGHT)
#define BF_BOTTOMLEFT   (BF_BOTTOM | BF_LEFT)
#define BF_BOTTOMRIGHT  (BF_BOTTOM | BF_RIGHT)
#define BF_RECT         (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM)

#define BF_DIAGONAL     0x0010

// For diagonal lines, the BF_RECT flags specify the end point of the
// vector bounded by the rectangle parameter.
#define BF_DIAGONAL_ENDTOPRIGHT     (BF_DIAGONAL | BF_TOP | BF_RIGHT)
#define BF_DIAGONAL_ENDTOPLEFT      (BF_DIAGONAL | BF_TOP | BF_LEFT)
#define BF_DIAGONAL_ENDBOTTOMLEFT   (BF_DIAGONAL | BF_BOTTOM | BF_LEFT)
#define BF_DIAGONAL_ENDBOTTOMRIGHT  (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT)


#define BF_MIDDLE       0x0800  /* Fill in the middle */
#define BF_SOFT         0x1000  /* For softer buttons */
#define BF_ADJUST       0x2000  /* Calculate the space left over */
#define BF_FLAT         0x4000  /* For flat rather than 3D borders */
#define BF_MONO         0x8000  /* For monochrome borders */


WINUSERAPI
BOOL
WINAPI
DrawEdge(
    __in HDC hdc,
    __inout LPRECT qrc,
    __in UINT edge,
    __in UINT grfFlags);

/* flags for DrawFrameControl */

#define DFC_CAPTION             1
#define DFC_MENU                2
#define DFC_SCROLL              3
#define DFC_BUTTON              4
#if(WINVER >= 0x0500)
#define DFC_POPUPMENU           5
#endif /* WINVER >= 0x0500 */

#define DFCS_CAPTIONCLOSE       0x0000
#define DFCS_CAPTIONMIN         0x0001
#define DFCS_CAPTIONMAX         0x0002
#define DFCS_CAPTIONRESTORE     0x0003
#define DFCS_CAPTIONHELP        0x0004

#define DFCS_MENUARROW          0x0000
#define DFCS_MENUCHECK          0x0001
#define DFCS_MENUBULLET         0x0002
#define DFCS_MENUARROWRIGHT     0x0004
#define DFCS_SCROLLUP           0x0000
#define DFCS_SCROLLDOWN         0x0001
#define DFCS_SCROLLLEFT         0x0002
#define DFCS_SCROLLRIGHT        0x0003
#define DFCS_SCROLLCOMBOBOX     0x0005
#define DFCS_SCROLLSIZEGRIP     0x0008
#define DFCS_SCROLLSIZEGRIPRIGHT 0x0010

#define DFCS_BUTTONCHECK        0x0000
#define DFCS_BUTTONRADIOIMAGE   0x0001
#define DFCS_BUTTONRADIOMASK    0x0002
#define DFCS_BUTTONRADIO        0x0004
#define DFCS_BUTTON3STATE       0x0008
#define DFCS_BUTTONPUSH         0x0010

#define DFCS_INACTIVE           0x0100
#define DFCS_PUSHED             0x0200
#define DFCS_CHECKED            0x0400

#if(WINVER >= 0x0500)
#define DFCS_TRANSPARENT        0x0800
#define DFCS_HOT                0x1000
#endif /* WINVER >= 0x0500 */

#define DFCS_ADJUSTRECT         0x2000
#define DFCS_FLAT               0x4000
#define DFCS_MONO               0x8000

WINUSERAPI
BOOL
WINAPI
DrawFrameControl(
    __in HDC,
    __inout LPRECT,
    __in UINT,
    __in UINT);


/* flags for DrawCaption */
#define DC_ACTIVE           0x0001
#define DC_SMALLCAP         0x0002
#define DC_ICON             0x0004
#define DC_TEXT             0x0008
#define DC_INBUTTON         0x0010
#if(WINVER >= 0x0500)
#define DC_GRADIENT         0x0020
#endif /* WINVER >= 0x0500 */
#if(_WIN32_WINNT >= 0x0501)
#define DC_BUTTONS          0x1000
#endif /* _WIN32_WINNT >= 0x0501 */

WINUSERAPI
BOOL
WINAPI
DrawCaption(
    __in HWND hwnd,
    __in HDC hdc,
    __in CONST RECT * lprect,
    __in UINT flags);


#define IDANI_OPEN          1
#define IDANI_CAPTION       3

WINUSERAPI
BOOL
WINAPI
DrawAnimatedRects(
    __in_opt HWND hwnd,
    __in int idAni,
    __in CONST RECT *lprcFrom,
    __in CONST RECT *lprcTo);

#endif /* WINVER >= 0x0400 */



WINUSERAPI
BOOL
WINAPI
RegisterHotKey(
    __in_opt HWND hWnd,
    __in int id,
    __in UINT fsModifiers,
    __in UINT vk);

WINUSERAPI
BOOL
WINAPI
UnregisterHotKey(
    __in_opt HWND hWnd,
    __in int id);



#if(WINVER >= 0x0400)

#define ENDSESSION_LOGOFF    0x80000000

#define ENDSESSION_CRITICAL  0x40000000

#define ENDSESSION_CLOSEAPP  0x00000001
#endif /* WINVER >= 0x0400 */



WINUSERAPI
LRESULT
WINAPI
SendMessageTimeoutA(
    __in HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam,
    __in UINT fuFlags,
    __in UINT uTimeout,
    __out_opt PDWORD_PTR lpdwResult);
WINUSERAPI
LRESULT
WINAPI
SendMessageTimeoutW(
    __in HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam,
    __in UINT fuFlags,
    __in UINT uTimeout,
    __out_opt PDWORD_PTR lpdwResult);
#ifdef UNICODE
#define SendMessageTimeout  SendMessageTimeoutW
#else
#define SendMessageTimeout  SendMessageTimeoutA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
SendNotifyMessageA(
    __in HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
BOOL
WINAPI
SendNotifyMessageW(
    __in HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define SendNotifyMessage  SendNotifyMessageW
#else
#define SendNotifyMessage  SendNotifyMessageA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
SendMessageCallbackA(
    __in HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam,
    __in SENDASYNCPROC lpResultCallBack,
    __in ULONG_PTR dwData);
WINUSERAPI
BOOL
WINAPI
SendMessageCallbackW(
    __in HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam,
    __in SENDASYNCPROC lpResultCallBack,
    __in ULONG_PTR dwData);
#ifdef UNICODE
#define SendMessageCallback  SendMessageCallbackW
#else
#define SendMessageCallback  SendMessageCallbackA
#endif // !UNICODE

#if(_WIN32_WINNT >= 0x0501)
typedef struct {
    UINT  cbSize;
    HDESK hdesk;
    HWND  hwnd;
    LUID  luid;
} BSMINFO, *PBSMINFO;

WINUSERAPI
long
WINAPI
BroadcastSystemMessageExA(
    __in DWORD flags,
    __inout_opt LPDWORD lpInfo,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam,
    __out_opt PBSMINFO pbsmInfo);
WINUSERAPI
long
WINAPI
BroadcastSystemMessageExW(
    __in DWORD flags,
    __inout_opt LPDWORD lpInfo,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam,
    __out_opt PBSMINFO pbsmInfo);
#ifdef UNICODE
#define BroadcastSystemMessageEx  BroadcastSystemMessageExW
#else
#define BroadcastSystemMessageEx  BroadcastSystemMessageExA
#endif // !UNICODE
#endif /* _WIN32_WINNT >= 0x0501 */

#if(WINVER >= 0x0400)

#if defined(_WIN32_WINNT)
WINUSERAPI
long
WINAPI
BroadcastSystemMessageA(
    __in DWORD flags,
    __inout_opt LPDWORD lpInfo,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
long
WINAPI
BroadcastSystemMessageW(
    __in DWORD flags,
    __inout_opt LPDWORD lpInfo,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define BroadcastSystemMessage  BroadcastSystemMessageW
#else
#define BroadcastSystemMessage  BroadcastSystemMessageA
#endif // !UNICODE
#elif defined(_WIN32_WINDOWS)
// The Win95 version isn't A/W decorated
WINUSERAPI
long
WINAPI
BroadcastSystemMessage(
    __in DWORD flags,
    __inout_opt LPDWORD lpInfo,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);

#endif

//Broadcast Special Message Recipient list
#define BSM_ALLCOMPONENTS       0x00000000
#define BSM_VXDS                0x00000001
#define BSM_NETDRIVER           0x00000002
#define BSM_INSTALLABLEDRIVERS  0x00000004
#define BSM_APPLICATIONS        0x00000008
#define BSM_ALLDESKTOPS         0x00000010

//Broadcast Special Message Flags
#define BSF_QUERY               0x00000001
#define BSF_IGNORECURRENTTASK   0x00000002
#define BSF_FLUSHDISK           0x00000004
#define BSF_NOHANG              0x00000008
#define BSF_POSTMESSAGE         0x00000010
#define BSF_FORCEIFHUNG         0x00000020
#define BSF_NOTIMEOUTIFNOTHUNG  0x00000040
#if(_WIN32_WINNT >= 0x0500)
#define BSF_ALLOWSFW            0x00000080
#define BSF_SENDNOTIFYMESSAGE   0x00000100
#endif /* _WIN32_WINNT >= 0x0500 */
#if(_WIN32_WINNT >= 0x0501)
#define BSF_RETURNHDESK         0x00000200
#define BSF_LUID                0x00000400
#endif /* _WIN32_WINNT >= 0x0501 */


// RegisterDeviceNotification

#if(WINVER >= 0x0500)
typedef  PVOID           HDEVNOTIFY;
typedef  HDEVNOTIFY     *PHDEVNOTIFY;

#define DEVICE_NOTIFY_WINDOW_HANDLE          0x00000000
#define DEVICE_NOTIFY_SERVICE_HANDLE         0x00000001
#if(_WIN32_WINNT >= 0x0501)
#define DEVICE_NOTIFY_ALL_INTERFACE_CLASSES  0x00000004
#endif /* _WIN32_WINNT >= 0x0501 */

WINUSERAPI
HDEVNOTIFY
WINAPI
RegisterDeviceNotificationA(
    __in HANDLE hRecipient,
    __in LPVOID NotificationFilter,
    __in DWORD Flags);
WINUSERAPI
HDEVNOTIFY
WINAPI
RegisterDeviceNotificationW(
    __in HANDLE hRecipient,
    __in LPVOID NotificationFilter,
    __in DWORD Flags);
#ifdef UNICODE
#define RegisterDeviceNotification  RegisterDeviceNotificationW
#else
#define RegisterDeviceNotification  RegisterDeviceNotificationA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
UnregisterDeviceNotification(
    __in HDEVNOTIFY Handle
    );

#if (_WIN32_WINNT >= 0x0502)

#if !defined(_HPOWERNOTIFY_DEF_)

#define _HPOWERNOTIFY_DEF_

typedef  PVOID           HPOWERNOTIFY;
typedef  HPOWERNOTIFY   *PHPOWERNOTIFY;

#endif

WINUSERAPI
HPOWERNOTIFY
WINAPI
RegisterPowerSettingNotification(
    IN HANDLE hRecipient,
    IN LPCGUID PowerSettingGuid,
    IN DWORD Flags
    );

WINUSERAPI
BOOL
WINAPI
UnregisterPowerSettingNotification(
    IN HPOWERNOTIFY Handle
    );
#endif // (_WIN32_WINNT >= 0x0502)
#endif /* WINVER >= 0x0500 */


WINUSERAPI
BOOL
WINAPI
PostMessageA(
    __in_opt HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
BOOL
WINAPI
PostMessageW(
    __in_opt HWND hWnd,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define PostMessage  PostMessageW
#else
#define PostMessage  PostMessageA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
PostThreadMessageA(
    __in DWORD idThread,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
BOOL
WINAPI
PostThreadMessageW(
    __in DWORD idThread,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define PostThreadMessage  PostThreadMessageW
#else
#define PostThreadMessage  PostThreadMessageA
#endif // !UNICODE

#define PostAppMessageA(idThread, wMsg, wParam, lParam)\
        PostThreadMessageA((DWORD)idThread, wMsg, wParam, lParam)
#define PostAppMessageW(idThread, wMsg, wParam, lParam)\
        PostThreadMessageW((DWORD)idThread, wMsg, wParam, lParam)
#ifdef UNICODE
#define PostAppMessage  PostAppMessageW
#else
#define PostAppMessage  PostAppMessageA
#endif // !UNICODE


#ifndef NOCTLMGR

/*
 * WARNING:
 * The following structures must NOT be DWORD padded because they are
 * followed by strings, etc that do not have to be DWORD aligned.
 */
#include <pshpack2.h>

/*
 * original NT 32 bit dialog template:
 */
typedef struct {
    DWORD style;
    DWORD dwExtendedStyle;
    WORD cdit;
    short x;
    short y;
    short cx;
    short cy;
} DLGTEMPLATE;
typedef DLGTEMPLATE *LPDLGTEMPLATEA;
typedef DLGTEMPLATE *LPDLGTEMPLATEW;
#ifdef UNICODE
typedef LPDLGTEMPLATEW LPDLGTEMPLATE;
#else
typedef LPDLGTEMPLATEA LPDLGTEMPLATE;
#endif // UNICODE
typedef CONST DLGTEMPLATE *LPCDLGTEMPLATEA;
typedef CONST DLGTEMPLATE *LPCDLGTEMPLATEW;
#ifdef UNICODE
typedef LPCDLGTEMPLATEW LPCDLGTEMPLATE;
#else
typedef LPCDLGTEMPLATEA LPCDLGTEMPLATE;
#endif // UNICODE

/*
 * 32 bit Dialog item template.
 */
typedef struct {
    DWORD style;
    DWORD dwExtendedStyle;
    short x;
    short y;
    short cx;
    short cy;
    WORD id;
} DLGITEMTEMPLATE;
typedef DLGITEMTEMPLATE *PDLGITEMTEMPLATEA;
typedef DLGITEMTEMPLATE *PDLGITEMTEMPLATEW;
#ifdef UNICODE
typedef PDLGITEMTEMPLATEW PDLGITEMTEMPLATE;
#else
typedef PDLGITEMTEMPLATEA PDLGITEMTEMPLATE;
#endif // UNICODE
typedef DLGITEMTEMPLATE *LPDLGITEMTEMPLATEA;
typedef DLGITEMTEMPLATE *LPDLGITEMTEMPLATEW;
#ifdef UNICODE
typedef LPDLGITEMTEMPLATEW LPDLGITEMTEMPLATE;
#else
typedef LPDLGITEMTEMPLATEA LPDLGITEMTEMPLATE;
#endif // UNICODE


#include <poppack.h> /* Resume normal packing */

WINUSERAPI
HWND
WINAPI
CreateDialogParamA(
    __in_opt HINSTANCE hInstance,
    __in LPCSTR lpTemplateName,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
WINUSERAPI
HWND
WINAPI
CreateDialogParamW(
    __in_opt HINSTANCE hInstance,
    __in LPCWSTR lpTemplateName,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
#ifdef UNICODE
#define CreateDialogParam  CreateDialogParamW
#else
#define CreateDialogParam  CreateDialogParamA
#endif // !UNICODE

WINUSERAPI
HWND
WINAPI
CreateDialogIndirectParamA(
    __in_opt HINSTANCE hInstance,
    __in LPCDLGTEMPLATEA lpTemplate,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
WINUSERAPI
HWND
WINAPI
CreateDialogIndirectParamW(
    __in_opt HINSTANCE hInstance,
    __in LPCDLGTEMPLATEW lpTemplate,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
#ifdef UNICODE
#define CreateDialogIndirectParam  CreateDialogIndirectParamW
#else
#define CreateDialogIndirectParam  CreateDialogIndirectParamA
#endif // !UNICODE

#define CreateDialogA(hInstance, lpName, hWndParent, lpDialogFunc) \
CreateDialogParamA(hInstance, lpName, hWndParent, lpDialogFunc, 0L)
#define CreateDialogW(hInstance, lpName, hWndParent, lpDialogFunc) \
CreateDialogParamW(hInstance, lpName, hWndParent, lpDialogFunc, 0L)
#ifdef UNICODE
#define CreateDialog  CreateDialogW
#else
#define CreateDialog  CreateDialogA
#endif // !UNICODE

#define CreateDialogIndirectA(hInstance, lpTemplate, hWndParent, lpDialogFunc) \
CreateDialogIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)
#define CreateDialogIndirectW(hInstance, lpTemplate, hWndParent, lpDialogFunc) \
CreateDialogIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)
#ifdef UNICODE
#define CreateDialogIndirect  CreateDialogIndirectW
#else
#define CreateDialogIndirect  CreateDialogIndirectA
#endif // !UNICODE

WINUSERAPI
INT_PTR
WINAPI
DialogBoxParamA(
    __in_opt HINSTANCE hInstance,
    __in LPCSTR lpTemplateName,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
WINUSERAPI
INT_PTR
WINAPI
DialogBoxParamW(
    __in_opt HINSTANCE hInstance,
    __in LPCWSTR lpTemplateName,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
#ifdef UNICODE
#define DialogBoxParam  DialogBoxParamW
#else
#define DialogBoxParam  DialogBoxParamA
#endif // !UNICODE

WINUSERAPI
INT_PTR
WINAPI
DialogBoxIndirectParamA(
    __in_opt HINSTANCE hInstance,
    __in LPCDLGTEMPLATEA hDialogTemplate,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
WINUSERAPI
INT_PTR
WINAPI
DialogBoxIndirectParamW(
    __in_opt HINSTANCE hInstance,
    __in LPCDLGTEMPLATEW hDialogTemplate,
    __in_opt HWND hWndParent,
    __in_opt DLGPROC lpDialogFunc,
    __in LPARAM dwInitParam);
#ifdef UNICODE
#define DialogBoxIndirectParam  DialogBoxIndirectParamW
#else
#define DialogBoxIndirectParam  DialogBoxIndirectParamA
#endif // !UNICODE

#define DialogBoxA(hInstance, lpTemplate, hWndParent, lpDialogFunc) \
DialogBoxParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)
#define DialogBoxW(hInstance, lpTemplate, hWndParent, lpDialogFunc) \
DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)
#ifdef UNICODE
#define DialogBox  DialogBoxW
#else
#define DialogBox  DialogBoxA
#endif // !UNICODE

#define DialogBoxIndirectA(hInstance, lpTemplate, hWndParent, lpDialogFunc) \
DialogBoxIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)
#define DialogBoxIndirectW(hInstance, lpTemplate, hWndParent, lpDialogFunc) \
DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)
#ifdef UNICODE
#define DialogBoxIndirect  DialogBoxIndirectW
#else
#define DialogBoxIndirect  DialogBoxIndirectA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
EndDialog(
    __in HWND hDlg,
    __in INT_PTR nResult);

WINUSERAPI
HWND
WINAPI
GetDlgItem(
    __in_opt HWND hDlg,
    __in int nIDDlgItem);

WINUSERAPI
BOOL
WINAPI
SetDlgItemInt(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __in UINT uValue,
    __in BOOL bSigned);

WINUSERAPI
UINT
WINAPI
GetDlgItemInt(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __out_opt BOOL *lpTranslated,
    __in BOOL bSigned);

WINUSERAPI
BOOL
WINAPI
SetDlgItemTextA(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __in LPCSTR lpString);
WINUSERAPI
BOOL
WINAPI
SetDlgItemTextW(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __in LPCWSTR lpString);
#ifdef UNICODE
#define SetDlgItemText  SetDlgItemTextW
#else
#define SetDlgItemText  SetDlgItemTextA
#endif // !UNICODE

WINUSERAPI
UINT
WINAPI
GetDlgItemTextA(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __out_ecount(cchMax) LPSTR lpString,
    __in int cchMax);
WINUSERAPI
UINT
WINAPI
GetDlgItemTextW(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __out_ecount(cchMax) LPWSTR lpString,
    __in int cchMax);
#ifdef UNICODE
#define GetDlgItemText  GetDlgItemTextW
#else
#define GetDlgItemText  GetDlgItemTextA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
CheckDlgButton(
    __in HWND hDlg,
    __in int nIDButton,
    __in UINT uCheck);

WINUSERAPI
BOOL
WINAPI
CheckRadioButton(
    __in HWND hDlg,
    __in int nIDFirstButton,
    __in int nIDLastButton,
    __in int nIDCheckButton);

WINUSERAPI
UINT
WINAPI
IsDlgButtonChecked(
    __in HWND hDlg,
    __in int nIDButton);

WINUSERAPI
LRESULT
WINAPI
SendDlgItemMessageA(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
LRESULT
WINAPI
SendDlgItemMessageW(
    __in HWND hDlg,
    __in int nIDDlgItem,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define SendDlgItemMessage  SendDlgItemMessageW
#else
#define SendDlgItemMessage  SendDlgItemMessageA
#endif // !UNICODE

WINUSERAPI
HWND
WINAPI
GetNextDlgGroupItem(
    __in HWND hDlg,
    __in_opt HWND hCtl,
    __in BOOL bPrevious);

WINUSERAPI
HWND
WINAPI
GetNextDlgTabItem(
    __in HWND hDlg,
    __in_opt HWND hCtl,
    __in BOOL bPrevious);

WINUSERAPI
int
WINAPI
GetDlgCtrlID(
    __in HWND hWnd);

WINUSERAPI
long
WINAPI
GetDialogBaseUnits(VOID);

WINUSERAPI
#ifndef _MAC
LRESULT
WINAPI
#else
LRESULT
CALLBACK
#endif
DefDlgProcA(
    __in HWND hDlg,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
#ifndef _MAC
LRESULT
WINAPI
#else
LRESULT
CALLBACK
#endif
DefDlgProcW(
    __in HWND hDlg,
    __in UINT Msg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define DefDlgProc  DefDlgProcW
#else
#define DefDlgProc  DefDlgProcA
#endif // !UNICODE

/*
 * Window extra byted needed for private dialog classes.
 */
#ifndef _MAC
#define DLGWINDOWEXTRA 30
#else
#define DLGWINDOWEXTRA 48
#endif

#endif /* !NOCTLMGR */

#ifndef NOMSG

WINUSERAPI
BOOL
WINAPI
CallMsgFilterA(
    __in LPMSG lpMsg,
    __in int nCode);
WINUSERAPI
BOOL
WINAPI
CallMsgFilterW(
    __in LPMSG lpMsg,
    __in int nCode);
#ifdef UNICODE
#define CallMsgFilter  CallMsgFilterW
#else
#define CallMsgFilter  CallMsgFilterA
#endif // !UNICODE

#endif /* !NOMSG */

#ifndef NOCLIPBOARD

/*
 * Clipboard Manager Functions
 */

WINUSERAPI
BOOL
WINAPI
OpenClipboard(
    __in_opt HWND hWndNewOwner);

WINUSERAPI
BOOL
WINAPI
CloseClipboard(
    VOID);


#if(WINVER >= 0x0500)

WINUSERAPI
DWORD
WINAPI
GetClipboardSequenceNumber(
    VOID);

#endif /* WINVER >= 0x0500 */

WINUSERAPI
HWND
WINAPI
GetClipboardOwner(
    VOID);

WINUSERAPI
HWND
WINAPI
SetClipboardViewer(
    __in HWND hWndNewViewer);

WINUSERAPI
HWND
WINAPI
GetClipboardViewer(
    VOID);

WINUSERAPI
BOOL
WINAPI
ChangeClipboardChain(
    __in HWND hWndRemove,
    __in HWND hWndNewNext);

WINUSERAPI
HANDLE
WINAPI
SetClipboardData(
    __in UINT uFormat,
    __in_opt HANDLE hMem);

WINUSERAPI
HANDLE
WINAPI
GetClipboardData(
    __in UINT uFormat);

WINUSERAPI
UINT
WINAPI
RegisterClipboardFormatA(
    __in LPCSTR lpszFormat);
WINUSERAPI
UINT
WINAPI
RegisterClipboardFormatW(
    __in LPCWSTR lpszFormat);
#ifdef UNICODE
#define RegisterClipboardFormat  RegisterClipboardFormatW
#else
#define RegisterClipboardFormat  RegisterClipboardFormatA
#endif // !UNICODE

WINUSERAPI
int
WINAPI
CountClipboardFormats(
    VOID);

WINUSERAPI
UINT
WINAPI
EnumClipboardFormats(
    __in UINT format);

WINUSERAPI
int
WINAPI
GetClipboardFormatNameA(
    __in UINT format,
    __out_ecount(cchMaxCount) LPSTR lpszFormatName,
    __in int cchMaxCount);
WINUSERAPI
int
WINAPI
GetClipboardFormatNameW(
    __in UINT format,
    __out_ecount(cchMaxCount) LPWSTR lpszFormatName,
    __in int cchMaxCount);
#ifdef UNICODE
#define GetClipboardFormatName  GetClipboardFormatNameW
#else
#define GetClipboardFormatName  GetClipboardFormatNameA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
EmptyClipboard(
    VOID);

WINUSERAPI
BOOL
WINAPI
IsClipboardFormatAvailable(
    __in UINT format);

WINUSERAPI
int
WINAPI
GetPriorityClipboardFormat(
    __in_ecount(cFormats) UINT *paFormatPriorityList,
    __in int cFormats);

WINUSERAPI
HWND
WINAPI
GetOpenClipboardWindow(
    VOID);

#if(WINVER >= 0x0600)
WINUSERAPI
BOOL
WINAPI
AddClipboardFormatListener(
    __in HWND hwnd);

WINUSERAPI
BOOL
WINAPI
RemoveClipboardFormatListener(
    __in HWND hwnd);

WINUSERAPI
BOOL
WINAPI
GetUpdatedClipboardFormats(
    __out_ecount(cFormats) __notnull PUINT lpuiFormats,
    __in UINT cFormats,
    __out __notnull PUINT pcFormatsOut);
#endif /* WINVER >= 0x0600 */
#endif /* !NOCLIPBOARD */

WINUSERAPI
UINT
WINAPI
SendInput(
    __in UINT cInputs,                     // number of input in the array
    __in_ecount(cInputs) LPINPUT pInputs,  // array of inputs
    __in int cbSize);                      // sizeof(INPUT)

#endif // (_WIN32_WINNT > 0x0400)

#if(WINVER >= 0x0601)

/*
 * Touch Input defines and functions
 */

/*
 * Touch input handle
 */
DECLARE_HANDLE(HTOUCHINPUT);

typedef struct tagTOUCHINPUT {
    LONG x;
    LONG y;
    HANDLE hSource;
    DWORD dwID;
    DWORD dwFlags;
    DWORD dwMask;
    DWORD dwTime;
    ULONG_PTR dwExtraInfo;
    DWORD cxContact;
    DWORD cyContact;
} TOUCHINPUT, *PTOUCHINPUT;
typedef TOUCHINPUT const * PCTOUCHINPUT;


/*
 * Conversion of touch input coordinates to pixels
 */
#define TOUCH_COORD_TO_PIXEL(l)         ((l) / 100)

/*
 * Touch input flag values (TOUCHINPUT.dwFlags)
 */
#define TOUCHEVENTF_MOVE            0x0001
#define TOUCHEVENTF_DOWN            0x0002
#define TOUCHEVENTF_UP              0x0004
#define TOUCHEVENTF_INRANGE         0x0008
#define TOUCHEVENTF_PRIMARY         0x0010
#define TOUCHEVENTF_NOCOALESCE      0x0020
#define TOUCHEVENTF_PEN             0x0040
#define TOUCHEVENTF_PALM            0x0080

/*
 * Touch input mask values (TOUCHINPUT.dwMask)
 */
#define TOUCHINPUTMASKF_TIMEFROMSYSTEM  0x0001  // the dwTime field contains a system generated value
#define TOUCHINPUTMASKF_EXTRAINFO       0x0002  // the dwExtraInfo field is valid
#define TOUCHINPUTMASKF_CONTACTAREA     0x0004  // the cxContact and cyContact fields are valid

WINUSERAPI
BOOL
WINAPI
GetTouchInputInfo(
    __in HTOUCHINPUT hTouchInput,               // input event handle; from touch message lParam
    __in UINT cInputs,                          // number of elements in the array
    __out_ecount(cInputs) PTOUCHINPUT pInputs,  // array of touch inputs
    __in int cbSize);                           // sizeof(TOUCHINPUT)

WINUSERAPI
BOOL
WINAPI
CloseTouchInputHandle(
    __in HTOUCHINPUT hTouchInput);                   // input event handle; from touch message lParam


/*
 * RegisterTouchWindow flag values
 */
#define TWF_FINETOUCH       (0x00000001)
#define TWF_WANTPALM        (0x00000002)

WINUSERAPI
BOOL
WINAPI
RegisterTouchWindow(
    __in HWND hwnd,
    __in ULONG ulFlags);

WINUSERAPI
BOOL
WINAPI
UnregisterTouchWindow(
    __in HWND hwnd);

WINUSERAPI
BOOL
WINAPI
IsTouchWindow(
    __in HWND hwnd,
    __out_opt PULONG pulFlags);

#endif /* WINVER >= 0x0601 */

#if(_WIN32_WINNT >= 0x0500)
typedef struct tagLASTINPUTINFO {
    UINT cbSize;
    DWORD dwTime;
} LASTINPUTINFO, * PLASTINPUTINFO;

WINUSERAPI
BOOL
WINAPI
GetLastInputInfo(
    __out PLASTINPUTINFO plii);
#endif /* _WIN32_WINNT >= 0x0500 */

WINUSERAPI
UINT
WINAPI
MapVirtualKeyA(
    __in UINT uCode,
    __in UINT uMapType);
WINUSERAPI
UINT
WINAPI
MapVirtualKeyW(
    __in UINT uCode,
    __in UINT uMapType);
#ifdef UNICODE
#define MapVirtualKey  MapVirtualKeyW
#else
#define MapVirtualKey  MapVirtualKeyA
#endif // !UNICODE

#if(WINVER >= 0x0400)
WINUSERAPI
UINT
WINAPI
MapVirtualKeyExA(
    __in UINT uCode,
    __in UINT uMapType,
    __in_opt HKL dwhkl);
WINUSERAPI
UINT
WINAPI
MapVirtualKeyExW(
    __in UINT uCode,
    __in UINT uMapType,
    __in_opt HKL dwhkl);
#ifdef UNICODE
#define MapVirtualKeyEx  MapVirtualKeyExW
#else
#define MapVirtualKeyEx  MapVirtualKeyExA
#endif // !UNICODE

#define MAPVK_VK_TO_VSC     (0)
#define MAPVK_VSC_TO_VK     (1)
#define MAPVK_VK_TO_CHAR    (2)
#define MAPVK_VSC_TO_VK_EX  (3)
#endif /* WINVER >= 0x0400 */
#if(WINVER >= 0x0600)
#define MAPVK_VK_TO_VSC_EX  (4)
#endif /* WINVER >= 0x0600 */

WINUSERAPI
BOOL
WINAPI
GetInputState(
    VOID);

WINUSERAPI
DWORD
WINAPI
GetQueueStatus(
    __in UINT flags);


WINUSERAPI
HWND
WINAPI
GetCapture(
    VOID);

WINUSERAPI
HWND
WINAPI
SetCapture(
    __in HWND hWnd);

WINUSERAPI
BOOL
WINAPI
ReleaseCapture(
    VOID);

WINUSERAPI
DWORD
WINAPI
MsgWaitForMultipleObjects(
    __in DWORD nCount,
    __in_ecount_opt(nCount) CONST HANDLE *pHandles,
    __in BOOL fWaitAll,
    __in DWORD dwMilliseconds,
    __in DWORD dwWakeMask);

WINUSERAPI
DWORD
WINAPI
MsgWaitForMultipleObjectsEx(
    __in DWORD nCount,
    __in_ecount_opt(nCount) CONST HANDLE *pHandles,
    __in DWORD dwMilliseconds,
    __in DWORD dwWakeMask,
    __in DWORD dwFlags);


#define MWMO_WAITALL        0x0001
#define MWMO_ALERTABLE      0x0002
#define MWMO_INPUTAVAILABLE 0x0004


#ifndef NOMENUS

WINUSERAPI
HMENU
WINAPI
LoadMenuA(
    __in_opt HINSTANCE hInstance,
    __in LPCSTR lpMenuName);
WINUSERAPI
HMENU
WINAPI
LoadMenuW(
    __in_opt HINSTANCE hInstance,
    __in LPCWSTR lpMenuName);
#ifdef UNICODE
#define LoadMenu  LoadMenuW
#else
#define LoadMenu  LoadMenuA
#endif // !UNICODE

WINUSERAPI
HMENU
WINAPI
LoadMenuIndirectA(
    __in CONST MENUTEMPLATEA *lpMenuTemplate);
WINUSERAPI
HMENU
WINAPI
LoadMenuIndirectW(
    __in CONST MENUTEMPLATEW *lpMenuTemplate);
#ifdef UNICODE
#define LoadMenuIndirect  LoadMenuIndirectW
#else
#define LoadMenuIndirect  LoadMenuIndirectA
#endif // !UNICODE

WINUSERAPI
HMENU
WINAPI
GetMenu(
    __in HWND hWnd);

WINUSERAPI
BOOL
WINAPI
SetMenu(
    __in HWND hWnd,
    __in_opt HMENU hMenu);

WINUSERAPI
BOOL
WINAPI
ChangeMenuA(
    __in HMENU hMenu,
    __in UINT cmd,
    __in_opt LPCSTR lpszNewItem,
    __in UINT cmdInsert,
    __in UINT flags);
WINUSERAPI
BOOL
WINAPI
ChangeMenuW(
    __in HMENU hMenu,
    __in UINT cmd,
    __in_opt LPCWSTR lpszNewItem,
    __in UINT cmdInsert,
    __in UINT flags);
#ifdef UNICODE
#define ChangeMenu  ChangeMenuW
#else
#define ChangeMenu  ChangeMenuA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
HiliteMenuItem(
    __in HWND hWnd,
    __in HMENU hMenu,
    __in UINT uIDHiliteItem,
    __in UINT uHilite);

WINUSERAPI
int
WINAPI
GetMenuStringA(
    __in HMENU hMenu,
    __in UINT uIDItem,
    __out_ecount_opt(cchMax) LPSTR lpString,
    __in int cchMax,
    __in UINT flags);
WINUSERAPI
int
WINAPI
GetMenuStringW(
    __in HMENU hMenu,
    __in UINT uIDItem,
    __out_ecount_opt(cchMax) LPWSTR lpString,
    __in int cchMax,
    __in UINT flags);
#ifdef UNICODE
#define GetMenuString  GetMenuStringW
#else
#define GetMenuString  GetMenuStringA
#endif // !UNICODE

WINUSERAPI
UINT
WINAPI
GetMenuState(
    __in HMENU hMenu,
    __in UINT uId,
    __in UINT uFlags);

WINUSERAPI
BOOL
WINAPI
DrawMenuBar(
    __in HWND hWnd);

#if(_WIN32_WINNT >= 0x0501)
#define PMB_ACTIVE      0x00000001

#endif /* _WIN32_WINNT >= 0x0501 */


WINUSERAPI
HMENU
WINAPI
GetSystemMenu(
    __in HWND hWnd,
    __in BOOL bRevert);


WINUSERAPI
HMENU
WINAPI
CreateMenu(
    VOID);

WINUSERAPI
HMENU
WINAPI
CreatePopupMenu(
    VOID);

WINUSERAPI
BOOL
WINAPI
DestroyMenu(
    __in HMENU hMenu);

WINUSERAPI
DWORD
WINAPI
CheckMenuItem(
    __in HMENU hMenu,
    __in UINT uIDCheckItem,
    __in UINT uCheck);

WINUSERAPI
BOOL
WINAPI
EnableMenuItem(
    __in HMENU hMenu,
    __in UINT uIDEnableItem,
    __in UINT uEnable);

WINUSERAPI
HMENU
WINAPI
GetSubMenu(
    __in HMENU hMenu,
    __in int nPos);

WINUSERAPI
UINT
WINAPI
GetMenuItemID(
    __in HMENU hMenu,
    __in int nPos);

WINUSERAPI
int
WINAPI
GetMenuItemCount(
    __in_opt HMENU hMenu);

WINUSERAPI
BOOL
WINAPI
InsertMenuA(
    __in HMENU hMenu,
    __in UINT uPosition,
    __in UINT uFlags,
    __in UINT_PTR uIDNewItem,
    __in_opt LPCSTR lpNewItem);
WINUSERAPI
BOOL
WINAPI
InsertMenuW(
    __in HMENU hMenu,
    __in UINT uPosition,
    __in UINT uFlags,
    __in UINT_PTR uIDNewItem,
    __in_opt LPCWSTR lpNewItem);
#ifdef UNICODE
#define InsertMenu  InsertMenuW
#else
#define InsertMenu  InsertMenuA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
AppendMenuA(
    __in HMENU hMenu,
    __in UINT uFlags,
    __in UINT_PTR uIDNewItem,
    __in_opt LPCSTR lpNewItem);
WINUSERAPI
BOOL
WINAPI
AppendMenuW(
    __in HMENU hMenu,
    __in UINT uFlags,
    __in UINT_PTR uIDNewItem,
    __in_opt LPCWSTR lpNewItem);
#ifdef UNICODE
#define AppendMenu  AppendMenuW
#else
#define AppendMenu  AppendMenuA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
ModifyMenuA(
    __in HMENU hMnu,
    __in UINT uPosition,
    __in UINT uFlags,
    __in UINT_PTR uIDNewItem,
    __in_opt LPCSTR lpNewItem);
WINUSERAPI
BOOL
WINAPI
ModifyMenuW(
    __in HMENU hMnu,
    __in UINT uPosition,
    __in UINT uFlags,
    __in UINT_PTR uIDNewItem,
    __in_opt LPCWSTR lpNewItem);
#ifdef UNICODE
#define ModifyMenu  ModifyMenuW
#else
#define ModifyMenu  ModifyMenuA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI RemoveMenu(
    __in HMENU hMenu,
    __in UINT uPosition,
    __in UINT uFlags);

WINUSERAPI
BOOL
WINAPI
DeleteMenu(
    __in HMENU hMenu,
    __in UINT uPosition,
    __in UINT uFlags);

WINUSERAPI
BOOL
WINAPI
SetMenuItemBitmaps(
    __in HMENU hMenu,
    __in UINT uPosition,
    __in UINT uFlags,
    __in_opt HBITMAP hBitmapUnchecked,
    __in_opt HBITMAP hBitmapChecked);

WINUSERAPI
LONG
WINAPI
GetMenuCheckMarkDimensions(
    VOID);

WINUSERAPI
BOOL
WINAPI
TrackPopupMenu(
    __in HMENU hMenu,
    __in UINT uFlags,
    __in int x,
    __in int y,
    __in int nReserved,
    __in HWND hWnd,
    __in_opt CONST RECT *prcRect);


typedef struct tagTPMPARAMS
{
    UINT    cbSize;     /* Size of structure */
    RECT    rcExclude;  /* Screen coordinates of rectangle to exclude when positioning */
}   TPMPARAMS;
typedef TPMPARAMS FAR *LPTPMPARAMS;

WINUSERAPI
BOOL
WINAPI
TrackPopupMenuEx(
    __in HMENU,
    __in UINT,
    __in int,
    __in int,
    __in HWND,
    __in_opt LPTPMPARAMS);
#endif /* WINVER >= 0x0400 */

#if(_WIN32_WINNT >= 0x0601)
WINUSERAPI
BOOL
WINAPI
CalculatePopupWindowPosition(
    __in const POINT *anchorPoint,
    __in const SIZE *windowSize,
    __in UINT /* TPM_XXX values */ flags,
    __in_opt RECT *excludeRect,
    __out RECT *popupWindowPosition);

#endif /* _WIN32_WINNT >= 0x0601 */

#if(WINVER >= 0x0500)

#define MNS_NOCHECK         0x80000000
#define MNS_MODELESS        0x40000000
#define MNS_DRAGDROP        0x20000000
#define MNS_AUTODISMISS     0x10000000
#define MNS_NOTIFYBYPOS     0x08000000
#define MNS_CHECKORBMP      0x04000000

#define MIM_MAXHEIGHT               0x00000001
#define MIM_BACKGROUND              0x00000002
#define MIM_HELPID                  0x00000004
#define MIM_MENUDATA                0x00000008
#define MIM_STYLE                   0x00000010
#define MIM_APPLYTOSUBMENUS         0x80000000

typedef struct tagMENUINFO
{
    DWORD   cbSize;
    DWORD   fMask;
    DWORD   dwStyle;
    UINT    cyMax;
    HBRUSH  hbrBack;
    DWORD   dwContextHelpID;
    ULONG_PTR dwMenuData;
}   MENUINFO, FAR *LPMENUINFO;
typedef MENUINFO CONST FAR *LPCMENUINFO;

WINUSERAPI
BOOL
WINAPI
GetMenuInfo(
    __in HMENU,
    __inout LPMENUINFO);

WINUSERAPI
BOOL
WINAPI
SetMenuInfo(
    __in HMENU,
    __in LPCMENUINFO);

WINUSERAPI
BOOL
WINAPI
EndMenu(
        VOID);



#if(WINVER >= 0x0400)
#define MIIM_STATE       0x00000001
#define MIIM_ID          0x00000002
#define MIIM_SUBMENU     0x00000004
#define MIIM_CHECKMARKS  0x00000008
#define MIIM_TYPE        0x00000010
#define MIIM_DATA        0x00000020
#endif /* WINVER >= 0x0400 */

#if(WINVER >= 0x0500)
#define MIIM_STRING      0x00000040
#define MIIM_BITMAP      0x00000080
#define MIIM_FTYPE       0x00000100

#define HBMMENU_CALLBACK            ((HBITMAP) -1)
#define HBMMENU_SYSTEM              ((HBITMAP)  1)
#define HBMMENU_MBAR_RESTORE        ((HBITMAP)  2)
#define HBMMENU_MBAR_MINIMIZE       ((HBITMAP)  3)
#define HBMMENU_MBAR_CLOSE          ((HBITMAP)  5)
#define HBMMENU_MBAR_CLOSE_D        ((HBITMAP)  6)
#define HBMMENU_MBAR_MINIMIZE_D     ((HBITMAP)  7)
#define HBMMENU_POPUP_CLOSE         ((HBITMAP)  8)
#define HBMMENU_POPUP_RESTORE       ((HBITMAP)  9)
#define HBMMENU_POPUP_MAXIMIZE      ((HBITMAP) 10)
#define HBMMENU_POPUP_MINIMIZE      ((HBITMAP) 11)
#endif /* WINVER >= 0x0500 */

#if(WINVER >= 0x0400)
typedef struct tagMENUITEMINFOA
{
    UINT     cbSize;
    UINT     fMask;
    UINT     fType;         // used if MIIM_TYPE (4.0) or MIIM_FTYPE (>4.0)
    UINT     fState;        // used if MIIM_STATE
    UINT     wID;           // used if MIIM_ID
    HMENU    hSubMenu;      // used if MIIM_SUBMENU
    HBITMAP  hbmpChecked;   // used if MIIM_CHECKMARKS
    HBITMAP  hbmpUnchecked; // used if MIIM_CHECKMARKS
    ULONG_PTR dwItemData;   // used if MIIM_DATA
    __field_ecount_opt(cch) LPSTR    dwTypeData;    // used if MIIM_TYPE (4.0) or MIIM_STRING (>4.0)
    UINT     cch;           // used if MIIM_TYPE (4.0) or MIIM_STRING (>4.0)
#if(WINVER >= 0x0500)
    HBITMAP  hbmpItem;      // used if MIIM_BITMAP
#endif /* WINVER >= 0x0500 */
}   MENUITEMINFOA, FAR *LPMENUITEMINFOA;
typedef struct tagMENUITEMINFOW
{
    UINT     cbSize;
    UINT     fMask;
    UINT     fType;         // used if MIIM_TYPE (4.0) or MIIM_FTYPE (>4.0)
    UINT     fState;        // used if MIIM_STATE
    UINT     wID;           // used if MIIM_ID
    HMENU    hSubMenu;      // used if MIIM_SUBMENU
    HBITMAP  hbmpChecked;   // used if MIIM_CHECKMARKS
    HBITMAP  hbmpUnchecked; // used if MIIM_CHECKMARKS
    ULONG_PTR dwItemData;   // used if MIIM_DATA
    __field_ecount_opt(cch) LPWSTR   dwTypeData;    // used if MIIM_TYPE (4.0) or MIIM_STRING (>4.0)
    UINT     cch;           // used if MIIM_TYPE (4.0) or MIIM_STRING (>4.0)
#if(WINVER >= 0x0500)
    HBITMAP  hbmpItem;      // used if MIIM_BITMAP
#endif /* WINVER >= 0x0500 */
}   MENUITEMINFOW, FAR *LPMENUITEMINFOW;
#ifdef UNICODE
typedef MENUITEMINFOW MENUITEMINFO;
typedef LPMENUITEMINFOW LPMENUITEMINFO;
#else
typedef MENUITEMINFOA MENUITEMINFO;
typedef LPMENUITEMINFOA LPMENUITEMINFO;
#endif // UNICODE
typedef MENUITEMINFOA CONST FAR *LPCMENUITEMINFOA;
typedef MENUITEMINFOW CONST FAR *LPCMENUITEMINFOW;
#ifdef UNICODE
typedef LPCMENUITEMINFOW LPCMENUITEMINFO;
#else
typedef LPCMENUITEMINFOA LPCMENUITEMINFO;
#endif // UNICODE


WINUSERAPI
BOOL
WINAPI
InsertMenuItemA(
    __in HMENU hmenu,
    __in UINT item,
    __in BOOL fByPosition,
    __in LPCMENUITEMINFOA lpmi);
WINUSERAPI
BOOL
WINAPI
InsertMenuItemW(
    __in HMENU hmenu,
    __in UINT item,
    __in BOOL fByPosition,
    __in LPCMENUITEMINFOW lpmi);
#ifdef UNICODE
#define InsertMenuItem  InsertMenuItemW
#else
#define InsertMenuItem  InsertMenuItemA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
GetMenuItemInfoA(
    __in HMENU hmenu,
    __in UINT item,
    __in BOOL fByPosition,
    __inout LPMENUITEMINFOA lpmii);
WINUSERAPI
BOOL
WINAPI
GetMenuItemInfoW(
    __in HMENU hmenu,
    __in UINT item,
    __in BOOL fByPosition,
    __inout LPMENUITEMINFOW lpmii);
#ifdef UNICODE
#define GetMenuItemInfo  GetMenuItemInfoW
#else
#define GetMenuItemInfo  GetMenuItemInfoA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
SetMenuItemInfoA(
    __in HMENU hmenu,
    __in UINT item,
    __in BOOL fByPositon,
    __in LPCMENUITEMINFOA lpmii);
WINUSERAPI
BOOL
WINAPI
SetMenuItemInfoW(
    __in HMENU hmenu,
    __in UINT item,
    __in BOOL fByPositon,
    __in LPCMENUITEMINFOW lpmii);
#ifdef UNICODE
#define SetMenuItemInfo  SetMenuItemInfoW
#else
#define SetMenuItemInfo  SetMenuItemInfoA
#endif // !UNICODE


#define GMDI_USEDISABLED    0x0001L
#define GMDI_GOINTOPOPUPS   0x0002L

WINUSERAPI
UINT
WINAPI
GetMenuDefaultItem(
    __in HMENU hMenu,
    __in UINT fByPos,
    __in UINT gmdiFlags);

WINUSERAPI
BOOL
WINAPI
SetMenuDefaultItem(
    __in HMENU hMenu,
    __in UINT uItem,
    __in UINT fByPos);

WINUSERAPI
BOOL
WINAPI
GetMenuItemRect(
    __in_opt HWND hWnd,
    __in HMENU hMenu,
    __in UINT uItem,
    __out LPRECT lprcItem);

WINUSERAPI
int
WINAPI
MenuItemFromPoint(
    __in_opt HWND hWnd,
    __in HMENU hMenu,
    __in POINT ptScreen);
#endif /* WINVER >= 0x0400 */

/*
 * Flags for TrackPopupMenu
 */
#define TPM_LEFTBUTTON  0x0000L
#define TPM_RIGHTBUTTON 0x0002L
#define TPM_LEFTALIGN   0x0000L
#define TPM_CENTERALIGN 0x0004L
#define TPM_RIGHTALIGN  0x0008L
#if(WINVER >= 0x0400)
#define TPM_TOPALIGN        0x0000L
#define TPM_VCENTERALIGN    0x0010L
#define TPM_BOTTOMALIGN     0x0020L

#define TPM_HORIZONTAL      0x0000L     /* Horz alignment matters more */
#define TPM_VERTICAL        0x0040L     /* Vert alignment matters more */
#define TPM_NONOTIFY        0x0080L     /* Don't send any notification msgs */
#define TPM_RETURNCMD       0x0100L
#endif /* WINVER >= 0x0400 */
#if(WINVER >= 0x0500)
#define TPM_RECURSE         0x0001L
#define TPM_HORPOSANIMATION 0x0400L
#define TPM_HORNEGANIMATION 0x0800L
#define TPM_VERPOSANIMATION 0x1000L
#define TPM_VERNEGANIMATION 0x2000L
#if(_WIN32_WINNT >= 0x0500)
#define TPM_NOANIMATION     0x4000L
#endif /* _WIN32_WINNT >= 0x0500 */
#if(_WIN32_WINNT >= 0x0501)
#define TPM_LAYOUTRTL       0x8000L
#endif /* _WIN32_WINNT >= 0x0501 */
#endif /* WINVER >= 0x0500 */
#if(_WIN32_WINNT >= 0x0601)
#define TPM_WORKAREA        0x10000L
#endif /* _WIN32_WINNT >= 0x0601 */


#endif /* !NOMENUS */


#if(WINVER >= 0x0400)
//
// Drag-and-drop support
// Obsolete - use OLE instead
//
typedef struct tagDROPSTRUCT
{
    HWND    hwndSource;
    HWND    hwndSink;
    DWORD   wFmt;
    ULONG_PTR dwData;
    POINT   ptDrop;
    DWORD   dwControlData;
} DROPSTRUCT, *PDROPSTRUCT, *LPDROPSTRUCT;

#define DOF_EXECUTABLE      0x8001      // wFmt flags
#define DOF_DOCUMENT        0x8002
#define DOF_DIRECTORY       0x8003
#define DOF_MULTIPLE        0x8004
#define DOF_PROGMAN         0x0001
#define DOF_SHELLDATA       0x0002

#define DO_DROPFILE         0x454C4946L
#define DO_PRINTFILE        0x544E5250L

WINUSERAPI
DWORD
WINAPI
DragObject(
    __in HWND hwndParent,
    __in HWND hwndFrom,
    __in UINT fmt,
    __in ULONG_PTR data,
    __in_opt HCURSOR hcur);

WINUSERAPI
BOOL
WINAPI
DragDetect(
    __in HWND hwnd,
    __in POINT pt);
#endif /* WINVER >= 0x0400 */



WINUSERAPI
BOOL
WINAPI
GrayStringA(
    __in HDC hDC,
    __in_opt HBRUSH hBrush,
    __in_opt GRAYSTRINGPROC lpOutputFunc,
    __in LPARAM lpData,
    __in int nCount,
    __in int X,
    __in int Y,
    __in int nWidth,
    __in int nHeight);
WINUSERAPI
BOOL
WINAPI
GrayStringW(
    __in HDC hDC,
    __in_opt HBRUSH hBrush,
    __in_opt GRAYSTRINGPROC lpOutputFunc,
    __in LPARAM lpData,
    __in int nCount,
    __in int X,
    __in int Y,
    __in int nWidth,
    __in int nHeight);
#ifdef UNICODE
#define GrayString  GrayStringW
#else
#define GrayString  GrayStringA
#endif // !UNICODE

#if(WINVER >= 0x0400)
/* Monolithic state-drawing routine */
/* Image type */
#define DST_COMPLEX     0x0000
#define DST_TEXT        0x0001
#define DST_PREFIXTEXT  0x0002
#define DST_ICON        0x0003
#define DST_BITMAP      0x0004

/* State type */
#define DSS_NORMAL      0x0000
#define DSS_UNION       0x0010  /* Gray string appearance */
#define DSS_DISABLED    0x0020
#define DSS_MONO        0x0080
#if(_WIN32_WINNT >= 0x0500)
#define DSS_HIDEPREFIX  0x0200
#define DSS_PREFIXONLY  0x0400
#endif /* _WIN32_WINNT >= 0x0500 */
#define DSS_RIGHT       0x8000

WINUSERAPI
BOOL
WINAPI
DrawStateA(
    __in HDC hdc,
    __in_opt HBRUSH hbrFore,
    __in_opt DRAWSTATEPROC qfnCallBack,
    __in LPARAM lData,
    __in WPARAM wData,
    __in int x,
    __in int y,
    __in int cx,
    __in int cy,
    __in UINT uFlags);
WINUSERAPI
BOOL
WINAPI
DrawStateW(
    __in HDC hdc,
    __in_opt HBRUSH hbrFore,
    __in_opt DRAWSTATEPROC qfnCallBack,
    __in LPARAM lData,
    __in WPARAM wData,
    __in int x,
    __in int y,
    __in int cx,
    __in int cy,
    __in UINT uFlags);
#ifdef UNICODE
#define DrawState  DrawStateW
#else
#define DrawState  DrawStateA
#endif // !UNICODE
#endif /* WINVER >= 0x0400 */

WINUSERAPI
LONG
WINAPI
TabbedTextOutA(
    __in HDC hdc,
    __in int x,
    __in int y,
    __in_ecount(chCount) LPCSTR lpString,
    __in int chCount,
    __in int nTabPositions,
    __in_ecount_opt(nTabPositions) CONST INT *lpnTabStopPositions,
    __in int nTabOrigin);
WINUSERAPI
LONG
WINAPI
TabbedTextOutW(
    __in HDC hdc,
    __in int x,
    __in int y,
    __in_ecount(chCount) LPCWSTR lpString,
    __in int chCount,
    __in int nTabPositions,
    __in_ecount_opt(nTabPositions) CONST INT *lpnTabStopPositions,
    __in int nTabOrigin);
#ifdef UNICODE
#define TabbedTextOut  TabbedTextOutW
#else
#define TabbedTextOut  TabbedTextOutA
#endif // !UNICODE

WINUSERAPI
DWORD
WINAPI
GetTabbedTextExtentA(
    __in HDC hdc,
    __in_ecount(chCount) LPCSTR lpString,
    __in int chCount,
    __in int nTabPositions,
    __in_ecount_opt(nTabPositions) CONST INT *lpnTabStopPositions);
WINUSERAPI
DWORD
WINAPI
GetTabbedTextExtentW(
    __in HDC hdc,
    __in_ecount(chCount) LPCWSTR lpString,
    __in int chCount,
    __in int nTabPositions,
    __in_ecount_opt(nTabPositions) CONST INT *lpnTabStopPositions);
#ifdef UNICODE
#define GetTabbedTextExtent  GetTabbedTextExtentW
#else
#define GetTabbedTextExtent  GetTabbedTextExtentA
#endif // !UNICODE

WINUSERAPI
HDC
WINAPI
BeginPaint(
    __in HWND hWnd,
    __out LPPAINTSTRUCT lpPaint);

WINUSERAPI
BOOL
WINAPI
EndPaint(
    __in HWND hWnd,
    __in CONST PAINTSTRUCT *lpPaint);

WINUSERAPI
BOOL
WINAPI
GetUpdateRect(
    __in HWND hWnd,
    __out_opt LPRECT lpRect,
    __in BOOL bErase);

WINUSERAPI
int
WINAPI
GetUpdateRgn(
    __in HWND hWnd,
    __in HRGN hRgn,
    __in BOOL bErase);

WINUSERAPI
int
WINAPI
SetWindowRgn(
    __in HWND hWnd,
    __in_opt HRGN hRgn,
    __in BOOL bRedraw);


WINUSERAPI
int
WINAPI
GetWindowRgn(
    __in HWND hWnd,
    __in HRGN hRgn);

#if(_WIN32_WINNT >= 0x0501)

WINUSERAPI
int
WINAPI
GetWindowRgnBox(
    __in HWND hWnd,
    __out LPRECT lprc);

#endif /* _WIN32_WINNT >= 0x0501 */

WINUSERAPI
int
WINAPI
ExcludeUpdateRgn(
    __in HDC hDC,
    __in HWND hWnd);

WINUSERAPI
BOOL
WINAPI
InvalidateRect(
    __in_opt HWND hWnd,
    __in_opt CONST RECT *lpRect,
    __in BOOL bErase);

WINUSERAPI
BOOL
WINAPI
ValidateRect(
    __in_opt HWND hWnd,
    __in_opt CONST RECT *lpRect);

WINUSERAPI
BOOL
WINAPI
InvalidateRgn(
    __in HWND hWnd,
    __in_opt HRGN hRgn,
    __in BOOL bErase);

WINUSERAPI
BOOL
WINAPI
ValidateRgn(
    __in HWND hWnd,
    __in_opt HRGN hRgn);


WINUSERAPI
BOOL
WINAPI
RedrawWindow(
    __in_opt HWND hWnd,
    __in_opt CONST RECT *lprcUpdate,
    __in_opt HRGN hrgnUpdate,
    __in UINT flags);

/*
 * RedrawWindow() flags
 */
#define RDW_INVALIDATE          0x0001
#define RDW_INTERNALPAINT       0x0002
#define RDW_ERASE               0x0004

#define RDW_VALIDATE            0x0008
#define RDW_NOINTERNALPAINT     0x0010
#define RDW_NOERASE             0x0020

#define RDW_NOCHILDREN          0x0040
#define RDW_ALLCHILDREN         0x0080

#define RDW_UPDATENOW           0x0100
#define RDW_ERASENOW            0x0200

#define RDW_FRAME               0x0400
#define RDW_NOFRAME             0x0800


/*
 * LockWindowUpdate API
 */

WINUSERAPI
BOOL
WINAPI
LockWindowUpdate(
    __in_opt HWND hWndLock);

WINUSERAPI
BOOL
WINAPI
ScrollWindow(
    __in HWND hWnd,
    __in int XAmount,
    __in int YAmount,
    __in_opt CONST RECT *lpRect,
    __in_opt CONST RECT *lpClipRect);

WINUSERAPI
BOOL
WINAPI
ScrollDC(
    __in HDC hDC,
    __in int dx,
    __in int dy,
    __in_opt CONST RECT *lprcScroll,
    __in_opt CONST RECT *lprcClip,
    __in_opt HRGN hrgnUpdate,
    __out_opt LPRECT lprcUpdate);

WINUSERAPI
int
WINAPI
ScrollWindowEx(
    __in HWND hWnd,
    __in int dx,
    __in int dy,
    __in_opt CONST RECT *prcScroll,
    __in_opt CONST RECT *prcClip,
    __in_opt HRGN hrgnUpdate,
    __out_opt LPRECT prcUpdate,
    __in UINT flags);

#define SW_SCROLLCHILDREN   0x0001  /* Scroll children within *lprcScroll. */
#define SW_INVALIDATE       0x0002  /* Invalidate after scrolling */
#define SW_ERASE            0x0004  /* If SW_INVALIDATE, don't send WM_ERASEBACKGROUND */
#if(WINVER >= 0x0500)
#define SW_SMOOTHSCROLL     0x0010  /* Use smooth scrolling */
#endif /* WINVER >= 0x0500 */

#ifndef NOSCROLL

WINUSERAPI
int
WINAPI
SetScrollPos(
    __in HWND hWnd,
    __in int nBar,
    __in int nPos,
    __in BOOL bRedraw);

WINUSERAPI
int
WINAPI
GetScrollPos(
    __in HWND hWnd,
    __in int nBar);

WINUSERAPI
BOOL
WINAPI
SetScrollRange(
    __in HWND hWnd,
    __in int nBar,
    __in int nMinPos,
    __in int nMaxPos,
    __in BOOL bRedraw);

WINUSERAPI
BOOL
WINAPI
GetScrollRange(
    __in HWND hWnd,
    __in int nBar,
    __out LPINT lpMinPos,
    __out LPINT lpMaxPos);

WINUSERAPI
BOOL
WINAPI
ShowScrollBar(
    __in HWND hWnd,
    __in int wBar,
    __in BOOL bShow);

WINUSERAPI
BOOL
WINAPI
EnableScrollBar(
    __in HWND hWnd,
    __in UINT wSBflags,
    __in UINT wArrows);


/*
 * EnableScrollBar() flags
 */
#define ESB_ENABLE_BOTH     0x0000
#define ESB_DISABLE_BOTH    0x0003

#define ESB_DISABLE_LEFT    0x0001
#define ESB_DISABLE_RIGHT   0x0002

#define ESB_DISABLE_UP      0x0001
#define ESB_DISABLE_DOWN    0x0002

#define ESB_DISABLE_LTUP    ESB_DISABLE_LEFT
#define ESB_DISABLE_RTDN    ESB_DISABLE_RIGHT


#endif  /* !NOSCROLL */

WINUSERAPI
BOOL
WINAPI
AdjustWindowRect(
    __inout LPRECT lpRect,
    __in DWORD dwStyle,
    __in BOOL bMenu);

WINUSERAPI
BOOL
WINAPI
AdjustWindowRectEx(
    __inout LPRECT lpRect,
    __in DWORD dwStyle,
    __in BOOL bMenu,
    __in DWORD dwExStyle);


#if(WINVER >= 0x0400)
#define HELPINFO_WINDOW    0x0001
#define HELPINFO_MENUITEM  0x0002

WINUSERAPI
BOOL
WINAPI
SetWindowContextHelpId(
    __in HWND,
    __in DWORD);

WINUSERAPI
DWORD
WINAPI
GetWindowContextHelpId(
    __in HWND);

WINUSERAPI
BOOL
WINAPI
SetMenuContextHelpId(
    __in HMENU,
    __in DWORD);

WINUSERAPI
DWORD
WINAPI
GetMenuContextHelpId(
    __in HMENU);


WINUSERAPI
int
WINAPI
MapWindowPoints(
    __in_opt HWND hWndFrom,
    __in_opt HWND hWndTo,
    __inout_ecount(cPoints) LPPOINT lpPoints,
    __in UINT cPoints);

/*
 * Color Types
 */
#define CTLCOLOR_MSGBOX         0
#define CTLCOLOR_EDIT           1
#define CTLCOLOR_LISTBOX        2
#define CTLCOLOR_BTN            3
#define CTLCOLOR_DLG            4
#define CTLCOLOR_SCROLLBAR      5
#define CTLCOLOR_STATIC         6
#define CTLCOLOR_MAX            7


WINUSERAPI
BOOL
WINAPI
SetSysColors(
    __in int cElements,
    __in_ecount(cElements) CONST INT * lpaElements,
    __in_ecount(cElements) CONST COLORREF * lpaRgbValues);

#endif /* !NOCOLOR */

WINUSERAPI
WORD
WINAPI
SetWindowWord(
    __in HWND hWnd,
    __in int nIndex,
    __in WORD wNewWord);


WINUSERAPI
LONG
WINAPI
SetWindowLongA(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG dwNewLong);
WINUSERAPI
LONG
WINAPI
SetWindowLongW(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG dwNewLong);
#ifdef UNICODE
#define SetWindowLong  SetWindowLongW
#else
#define SetWindowLong  SetWindowLongA
#endif // !UNICODE

#ifdef _WIN64

WINUSERAPI
LONG_PTR
WINAPI
GetWindowLongPtrA(
    __in HWND hWnd,
    __in int nIndex);
WINUSERAPI
LONG_PTR
WINAPI
GetWindowLongPtrW(
    __in HWND hWnd,
    __in int nIndex);
#ifdef UNICODE
#define GetWindowLongPtr  GetWindowLongPtrW
#else
#define GetWindowLongPtr  GetWindowLongPtrA
#endif // !UNICODE

WINUSERAPI
LONG_PTR
WINAPI
SetWindowLongPtrA(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG_PTR dwNewLong);
WINUSERAPI
LONG_PTR
WINAPI
SetWindowLongPtrW(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG_PTR dwNewLong);
#ifdef UNICODE
#define SetWindowLongPtr  SetWindowLongPtrW
#else
#define SetWindowLongPtr  SetWindowLongPtrA
#endif // !UNICODE

#else  /* _WIN64 */

#define GetWindowLongPtrA   GetWindowLongA
#define GetWindowLongPtrW   GetWindowLongW
#ifdef UNICODE
#define GetWindowLongPtr  GetWindowLongPtrW
#else
#define GetWindowLongPtr  GetWindowLongPtrA
#endif // !UNICODE

#define SetWindowLongPtrA   SetWindowLongA
#define SetWindowLongPtrW   SetWindowLongW
#ifdef UNICODE
#define SetWindowLongPtr  SetWindowLongPtrW
#else
#define SetWindowLongPtr  SetWindowLongPtrA
#endif // !UNICODE

#endif /* _WIN64 */

WINUSERAPI
WORD
WINAPI
GetClassWord(
    __in HWND hWnd,
    __in int nIndex);

WINUSERAPI
WORD
WINAPI
SetClassWord(
    __in HWND hWnd,
    __in int nIndex,
    __in WORD wNewWord);

WINUSERAPI
DWORD
WINAPI
GetClassLongA(
    __in HWND hWnd,
    __in int nIndex);
WINUSERAPI
DWORD
WINAPI
GetClassLongW(
    __in HWND hWnd,
    __in int nIndex);
#ifdef UNICODE
#define GetClassLong  GetClassLongW
#else
#define GetClassLong  GetClassLongA
#endif // !UNICODE

WINUSERAPI
DWORD
WINAPI
SetClassLongA(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG dwNewLong);
WINUSERAPI
DWORD
WINAPI
SetClassLongW(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG dwNewLong);
#ifdef UNICODE
#define SetClassLong  SetClassLongW
#else
#define SetClassLong  SetClassLongA
#endif // !UNICODE

#ifdef _WIN64

WINUSERAPI
ULONG_PTR
WINAPI
GetClassLongPtrA(
    __in HWND hWnd,
    __in int nIndex);
WINUSERAPI
ULONG_PTR
WINAPI
GetClassLongPtrW(
    __in HWND hWnd,
    __in int nIndex);
#ifdef UNICODE
#define GetClassLongPtr  GetClassLongPtrW
#else
#define GetClassLongPtr  GetClassLongPtrA
#endif // !UNICODE

WINUSERAPI
ULONG_PTR
WINAPI
SetClassLongPtrA(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG_PTR dwNewLong);
WINUSERAPI
ULONG_PTR
WINAPI
SetClassLongPtrW(
    __in HWND hWnd,
    __in int nIndex,
    __in LONG_PTR dwNewLong);
#ifdef UNICODE
#define SetClassLongPtr  SetClassLongPtrW
#else
#define SetClassLongPtr  SetClassLongPtrA
#endif // !UNICODE

#else  /* _WIN64 */

#define GetClassLongPtrA    GetClassLongA
#define GetClassLongPtrW    GetClassLongW
#ifdef UNICODE
#define GetClassLongPtr  GetClassLongPtrW
#else
#define GetClassLongPtr  GetClassLongPtrA
#endif // !UNICODE

#define SetClassLongPtrA    SetClassLongA
#define SetClassLongPtrW    SetClassLongW
#ifdef UNICODE
#define SetClassLongPtr  SetClassLongPtrW
#else
#define SetClassLongPtr  SetClassLongPtrA
#endif // !UNICODE

#endif /* _WIN64 */

#endif /* !NOWINOFFSETS */

#if(WINVER >= 0x0500)
WINUSERAPI
BOOL
WINAPI
GetProcessDefaultLayout(
    __out DWORD *pdwDefaultLayout);

WINUSERAPI
BOOL
WINAPI
SetProcessDefaultLayout(
    __in DWORD dwDefaultLayout);
#endif /* WINVER >= 0x0500 */

WINUSERAPI
HWND
WINAPI
GetDesktopWindow(
    VOID);


WINUSERAPI
HWND
WINAPI
GetParent(
    __in HWND hWnd);

WINUSERAPI
HWND
WINAPI
SetParent(
    __in HWND hWndChild,
    __in_opt HWND hWndNewParent);

WINUSERAPI
BOOL
WINAPI
EnumChildWindows(
    __in_opt HWND hWndParent,
    __in WNDENUMPROC lpEnumFunc,
    __in LPARAM lParam);

WINUSERAPI
HWND
WINAPI
FindWindowA(
    __in_opt LPCSTR lpClassName,
    __in_opt LPCSTR lpWindowName);
WINUSERAPI
HWND
WINAPI
FindWindowW(
    __in_opt LPCWSTR lpClassName,
    __in_opt LPCWSTR lpWindowName);
#ifdef UNICODE
#define FindWindow  FindWindowW
#else
#define FindWindow  FindWindowA
#endif // !UNICODE

#if(WINVER >= 0x0400)
WINUSERAPI
HWND
WINAPI
FindWindowExA(
    __in_opt HWND hWndParent,
    __in_opt HWND hWndChildAfter,
    __in_opt LPCSTR lpszClass,
    __in_opt LPCSTR lpszWindow);
WINUSERAPI
HWND
WINAPI
FindWindowExW(
    __in_opt HWND hWndParent,
    __in_opt HWND hWndChildAfter,
    __in_opt LPCWSTR lpszClass,
    __in_opt LPCWSTR lpszWindow);
#ifdef UNICODE
#define FindWindowEx  FindWindowExW
#else
#define FindWindowEx  FindWindowExA
#endif // !UNICODE

WINUSERAPI
HWND
WINAPI
GetShellWindow(
    VOID);

#endif /* WINVER >= 0x0400 */


WINUSERAPI
BOOL
WINAPI
RegisterShellHookWindow(
    __in HWND hwnd);

WINUSERAPI
BOOL
WINAPI
DeregisterShellHookWindow(
    __in HWND hwnd);

WINUSERAPI
BOOL
WINAPI
EnumThreadWindows(
    __in DWORD dwThreadId,
    __in WNDENUMPROC lpfn,
    __in LPARAM lParam);

#define EnumTaskWindows(hTask, lpfn, lParam) EnumThreadWindows(HandleToUlong(hTask), lpfn, lParam)




WINUSERAPI
HWND
WINAPI
GetTopWindow(
    __in_opt HWND hWnd);

#define GetNextWindow(hWnd, wCmd) GetWindow(hWnd, wCmd)
#define GetSysModalWindow() (NULL)
#define SetSysModalWindow(hWnd) (NULL)

WINUSERAPI
DWORD
WINAPI
GetWindowThreadProcessId(
    __in HWND hWnd,
    __out_opt LPDWORD lpdwProcessId);

#if(_WIN32_WINNT >= 0x0501)
WINUSERAPI
BOOL
WINAPI
IsGUIThread(
    __in BOOL bConvert);

#endif /* _WIN32_WINNT >= 0x0501 */


#define GetWindowTask(hWnd) \
        ((HANDLE)(DWORD_PTR)GetWindowThreadProcessId(hWnd, NULL))

WINUSERAPI
HWND
WINAPI
GetLastActivePopup(
    __in HWND hWnd);

/*
 * GetWindow() Constants
 */
#define GW_HWNDFIRST        0
#define GW_HWNDLAST         1
#define GW_HWNDNEXT         2
#define GW_HWNDPREV         3
#define GW_OWNER            4
#define GW_CHILD            5
#if(WINVER <= 0x0400)
#define GW_MAX              5
#else
#define GW_ENABLEDPOPUP     6
#define GW_MAX              6
#endif

WINUSERAPI
HWND
WINAPI
GetWindow(
    __in HWND hWnd,
    __in UINT uCmd);


#ifndef NOWH

#ifdef STRICT

WINUSERAPI
HHOOK
WINAPI
SetWindowsHookA(
    __in int nFilterType,
    __in HOOKPROC pfnFilterProc);
WINUSERAPI
HHOOK
WINAPI
SetWindowsHookW(
    __in int nFilterType,
    __in HOOKPROC pfnFilterProc);
#ifdef UNICODE
#define SetWindowsHook  SetWindowsHookW
#else
#define SetWindowsHook  SetWindowsHookA
#endif // !UNICODE

#else /* !STRICT */

WINUSERAPI
HOOKPROC
WINAPI
SetWindowsHookA(
    __in int nFilterType,
    __in HOOKPROC pfnFilterProc);
WINUSERAPI
HOOKPROC
WINAPI
SetWindowsHookW(
    __in int nFilterType,
    __in HOOKPROC pfnFilterProc);
#ifdef UNICODE
#define SetWindowsHook  SetWindowsHookW
#else
#define SetWindowsHook  SetWindowsHookA
#endif // !UNICODE

#endif /* !STRICT */

WINUSERAPI
BOOL
WINAPI
UnhookWindowsHook(
    __in int nCode,
    __in HOOKPROC pfnFilterProc);

WINUSERAPI
HHOOK
WINAPI
SetWindowsHookExA(
    __in int idHook,
    __in HOOKPROC lpfn,
    __in_opt HINSTANCE hmod,
    __in DWORD dwThreadId);
WINUSERAPI
HHOOK
WINAPI
SetWindowsHookExW(
    __in int idHook,
    __in HOOKPROC lpfn,
    __in_opt HINSTANCE hmod,
    __in DWORD dwThreadId);
#ifdef UNICODE
#define SetWindowsHookEx  SetWindowsHookExW
#else
#define SetWindowsHookEx  SetWindowsHookExA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
UnhookWindowsHookEx(
    __in HHOOK hhk);

WINUSERAPI
LRESULT
WINAPI
CallNextHookEx(
    __in_opt HHOOK hhk,
    __in int nCode,
    __in WPARAM wParam,
    __in LPARAM lParam);

/*
 * Macros for source-level compatibility with old functions.
 */
#ifdef STRICT
#define DefHookProc(nCode, wParam, lParam, phhk)\
        CallNextHookEx(*phhk, nCode, wParam, lParam)
#else
#define DefHookProc(nCode, wParam, lParam, phhk)\
        CallNextHookEx((HHOOK)*phhk, nCode, wParam, lParam)
#endif /* STRICT */
#endif /* !NOWH */

#ifndef NOMENUS



#if(WINVER >= 0x0400)

WINUSERAPI
BOOL
WINAPI
CheckMenuRadioItem(
    __in HMENU hmenu,
    __in UINT first,
    __in UINT last,
    __in UINT check,
    __in UINT flags);
#endif /* WINVER >= 0x0400 */

/*
 * Menu item resource format
 */
typedef struct {
    WORD versionNumber;
    WORD offset;
} MENUITEMTEMPLATEHEADER, *PMENUITEMTEMPLATEHEADER;

typedef struct {        // version 0
    WORD mtOption;
    WORD mtID;
    WCHAR mtString[1];
} MENUITEMTEMPLATE, *PMENUITEMTEMPLATE;
#define MF_END             0x00000080L

#endif /* !NOMENUS */


/*
 * Resource Loading Routines
 */

WINUSERAPI
HBITMAP
WINAPI
LoadBitmapA(
    __in_opt HINSTANCE hInstance,
    __in LPCSTR lpBitmapName);
WINUSERAPI
HBITMAP
WINAPI
LoadBitmapW(
    __in_opt HINSTANCE hInstance,
    __in LPCWSTR lpBitmapName);
#ifdef UNICODE
#define LoadBitmap  LoadBitmapW
#else
#define LoadBitmap  LoadBitmapA
#endif // !UNICODE

WINUSERAPI
HCURSOR
WINAPI
LoadCursorA(
    __in_opt HINSTANCE hInstance,
    __in LPCSTR lpCursorName);
WINUSERAPI
HCURSOR
WINAPI
LoadCursorW(
    __in_opt HINSTANCE hInstance,
    __in LPCWSTR lpCursorName);
#ifdef UNICODE
#define LoadCursor  LoadCursorW
#else
#define LoadCursor  LoadCursorA
#endif // !UNICODE

WINUSERAPI
HCURSOR
WINAPI
LoadCursorFromFileA(
    __in LPCSTR lpFileName);
WINUSERAPI
HCURSOR
WINAPI
LoadCursorFromFileW(
    __in LPCWSTR lpFileName);
#ifdef UNICODE
#define LoadCursorFromFile  LoadCursorFromFileW
#else
#define LoadCursorFromFile  LoadCursorFromFileA
#endif // !UNICODE

WINUSERAPI
HCURSOR
WINAPI
CreateCursor(
    __in_opt HINSTANCE hInst,
    __in int xHotSpot,
    __in int yHotSpot,
    __in int nWidth,
    __in int nHeight,
    __in CONST VOID *pvANDPlane,
    __in CONST VOID *pvXORPlane);

WINUSERAPI
BOOL
WINAPI
DestroyCursor(
    __in HCURSOR hCursor);

#ifndef _MAC
#define CopyCursor(pcur) ((HCURSOR)CopyIcon((HICON)(pcur)))
#else
WINUSERAPI
HCURSOR
WINAPI
CopyCursor(
    __in HCURSOR hCursor);
#endif


WINUSERAPI
BOOL
WINAPI
SetSystemCursor(
    __in HCURSOR hcur,
    __in DWORD id);

typedef struct _ICONINFO {
    BOOL    fIcon;
    DWORD   xHotspot;
    DWORD   yHotspot;
    HBITMAP hbmMask;
    HBITMAP hbmColor;
} ICONINFO;
typedef ICONINFO *PICONINFO;

WINUSERAPI
HICON
WINAPI
LoadIconA(
    __in_opt HINSTANCE hInstance,
    __in LPCSTR lpIconName);
WINUSERAPI
HICON
WINAPI
LoadIconW(
    __in_opt HINSTANCE hInstance,
    __in LPCWSTR lpIconName);
#ifdef UNICODE
#define LoadIcon  LoadIconW
#else
#define LoadIcon  LoadIconA
#endif // !UNICODE


WINUSERAPI
UINT
WINAPI
PrivateExtractIconsA(
    __in LPCSTR szFileName,
    __in int nIconIndex,
    __in int cxIcon,
    __in int cyIcon,
    __out_ecount_part_opt(nIcons, return) HICON *phicon,
    __out_ecount_part_opt(nIcons, return) UINT *piconid,
    __in UINT nIcons,
    __in UINT flags);
WINUSERAPI
UINT
WINAPI
PrivateExtractIconsW(
    __in LPCWSTR szFileName,
    __in int nIconIndex,
    __in int cxIcon,
    __in int cyIcon,
    __out_ecount_part_opt(nIcons, return) HICON *phicon,
    __out_ecount_part_opt(nIcons, return) UINT *piconid,
    __in UINT nIcons,
    __in UINT flags);
#ifdef UNICODE
#define PrivateExtractIcons  PrivateExtractIconsW
#else
#define PrivateExtractIcons  PrivateExtractIconsA
#endif // !UNICODE

WINUSERAPI
HICON
WINAPI
CreateIcon(
    __in_opt HINSTANCE hInstance,
    __in int nWidth,
    __in int nHeight,
    __in BYTE cPlanes,
    __in BYTE cBitsPixel,
    __in CONST BYTE *lpbANDbits,
    __in CONST BYTE *lpbXORbits);

WINUSERAPI
BOOL
WINAPI
DestroyIcon(
    __in HICON hIcon);

WINUSERAPI
int
WINAPI
LookupIconIdFromDirectory(
    __in PBYTE presbits,
    __in BOOL fIcon);

#if(WINVER >= 0x0400)
WINUSERAPI
int
WINAPI
LookupIconIdFromDirectoryEx(
    __in PBYTE presbits,
    __in BOOL fIcon,
    __in int cxDesired,
    __in int cyDesired,
    __in UINT Flags);
#endif /* WINVER >= 0x0400 */

WINUSERAPI
HICON
WINAPI
CreateIconFromResource(
    __in PBYTE presbits,
    __in DWORD dwResSize,
    __in BOOL fIcon,
    __in DWORD dwVer);

#if(WINVER >= 0x0400)
WINUSERAPI
HICON
WINAPI
CreateIconFromResourceEx(
    __in PBYTE presbits,
    __in DWORD dwResSize,
    __in BOOL fIcon,
    __in DWORD dwVer,
    __in int cxDesired,
    __in int cyDesired,
    __in UINT Flags);

/* Icon/Cursor header */
typedef struct tagCURSORSHAPE
{
    int     xHotSpot;
    int     yHotSpot;
    int     cx;
    int     cy;
    int     cbWidth;
    BYTE    Planes;
    BYTE    BitsPixel;
} CURSORSHAPE, FAR *LPCURSORSHAPE;
#endif /* WINVER >= 0x0400 */

#define IMAGE_BITMAP        0
#define IMAGE_ICON          1
#define IMAGE_CURSOR        2
#if(WINVER >= 0x0400)
#define IMAGE_ENHMETAFILE   3

#define LR_DEFAULTCOLOR     0x00000000
#define LR_MONOCHROME       0x00000001
#define LR_COLOR            0x00000002
#define LR_COPYRETURNORG    0x00000004
#define LR_COPYDELETEORG    0x00000008
#define LR_LOADFROMFILE     0x00000010
#define LR_LOADTRANSPARENT  0x00000020
#define LR_DEFAULTSIZE      0x00000040
#define LR_VGACOLOR         0x00000080
#define LR_LOADMAP3DCOLORS  0x00001000
#define LR_CREATEDIBSECTION 0x00002000
#define LR_COPYFROMRESOURCE 0x00004000
#define LR_SHARED           0x00008000

WINUSERAPI
HANDLE
WINAPI
LoadImageA(
    __in_opt HINSTANCE hInst,
    __in LPCSTR name,
    __in UINT type,
    __in int cx,
    __in int cy,
    __in UINT fuLoad);
WINUSERAPI
HANDLE
WINAPI
LoadImageW(
    __in_opt HINSTANCE hInst,
    __in LPCWSTR name,
    __in UINT type,
    __in int cx,
    __in int cy,
    __in UINT fuLoad);
#ifdef UNICODE
#define LoadImage  LoadImageW
#else
#define LoadImage  LoadImageA
#endif // !UNICODE

WINUSERAPI
HANDLE
WINAPI
CopyImage(
    __in HANDLE h,
    __in UINT type,
    __in int cx,
    __in int cy,
    __in UINT flags);


WINUSERAPI
HICON
WINAPI
CreateIconIndirect(
    __in PICONINFO piconinfo);

WINUSERAPI
HICON
WINAPI
CopyIcon(
    __in HICON hIcon);

WINUSERAPI
BOOL
WINAPI
GetIconInfo(
    __in HICON hIcon,
    __out PICONINFO piconinfo);

#if(_WIN32_WINNT >= 0x0600)
typedef struct _ICONINFOEXA {
    DWORD   cbSize;
    BOOL    fIcon;
    DWORD   xHotspot;
    DWORD   yHotspot;
    HBITMAP hbmMask;
    HBITMAP hbmColor;
    WORD    wResID;
    CHAR    szModName[MAX_PATH];
    CHAR    szResName[MAX_PATH];
} ICONINFOEXA, *PICONINFOEXA;
typedef struct _ICONINFOEXW {
    DWORD   cbSize;
    BOOL    fIcon;
    DWORD   xHotspot;
    DWORD   yHotspot;
    HBITMAP hbmMask;
    HBITMAP hbmColor;
    WORD    wResID;
    WCHAR   szModName[MAX_PATH];
    WCHAR   szResName[MAX_PATH];
} ICONINFOEXW, *PICONINFOEXW;
#ifdef UNICODE
typedef ICONINFOEXW ICONINFOEX;
typedef PICONINFOEXW PICONINFOEX;
#else
typedef ICONINFOEXA ICONINFOEX;
typedef PICONINFOEXA PICONINFOEX;
#endif // UNICODE

WINUSERAPI
BOOL
WINAPI
GetIconInfoExA(
    __in HICON hicon,
    __inout PICONINFOEXA piconinfo);
WINUSERAPI
BOOL
WINAPI
GetIconInfoExW(
    __in HICON hicon,
    __inout PICONINFOEXW piconinfo);
#ifdef UNICODE
#define GetIconInfoEx  GetIconInfoExW
#else
#define GetIconInfoEx  GetIconInfoExA
#endif // !UNICODE
#endif /* _WIN32_WINNT >= 0x0600 */

#if(WINVER >= 0x0400)
#define RES_ICON    1
#define RES_CURSOR  2
#endif /* WINVER >= 0x0400 */

#ifdef OEMRESOURCE


/*
 * OEM Resource Ordinal Numbers
 */
#define OBM_CLOSE           32754
#define OBM_UPARROW         32753
#define OBM_DNARROW         32752
#define OBM_RGARROW         32751
#define OBM_LFARROW         32750
#define OBM_REDUCE          32749
#define OBM_ZOOM            32748
#define OBM_RESTORE         32747
#define OBM_REDUCED         32746
#define OBM_ZOOMD           32745
#define OBM_RESTORED        32744
#define OBM_UPARROWD        32743
#define OBM_DNARROWD        32742
#define OBM_RGARROWD        32741
#define OBM_LFARROWD        32740
#define OBM_MNARROW         32739
#define OBM_COMBO           32738
#define OBM_UPARROWI        32737
#define OBM_DNARROWI        32736
#define OBM_RGARROWI        32735
#define OBM_LFARROWI        32734

#define OBM_OLD_CLOSE       32767
#define OBM_SIZE            32766
#define OBM_OLD_UPARROW     32765
#define OBM_OLD_DNARROW     32764
#define OBM_OLD_RGARROW     32763
#define OBM_OLD_LFARROW     32762
#define OBM_BTSIZE          32761
#define OBM_CHECK           32760
#define OBM_CHECKBOXES      32759
#define OBM_BTNCORNERS      32758
#define OBM_OLD_REDUCE      32757
#define OBM_OLD_ZOOM        32756
#define OBM_OLD_RESTORE     32755


#define OCR_NORMAL          32512
#define OCR_IBEAM           32513
#define OCR_WAIT            32514
#define OCR_CROSS           32515
#define OCR_UP              32516
#define OCR_SIZE            32640   /* OBSOLETE: use OCR_SIZEALL */
#define OCR_ICON            32641   /* OBSOLETE: use OCR_NORMAL */
#define OCR_SIZENWSE        32642
#define OCR_SIZENESW        32643
#define OCR_SIZEWE          32644
#define OCR_SIZENS          32645
#define OCR_SIZEALL         32646
#define OCR_ICOCUR          32647   /* OBSOLETE: use OIC_WINLOGO */
#define OCR_NO              32648
#if(WINVER >= 0x0500)
#define OCR_HAND            32649
#endif /* WINVER >= 0x0500 */
#if(WINVER >= 0x0400)
#define OCR_APPSTARTING     32650
#endif /* WINVER >= 0x0400 */


#define OIC_SAMPLE          32512
#define OIC_HAND            32513
#define OIC_QUES            32514
#define OIC_BANG            32515
#define OIC_NOTE            32516
#if(WINVER >= 0x0400)
#define OIC_WINLOGO         32517
#define OIC_WARNING         OIC_BANG
#define OIC_ERROR           OIC_HAND
#define OIC_INFORMATION     OIC_NOTE
#endif /* WINVER >= 0x0400 */
#if(WINVER >= 0x0600)
#define OIC_SHIELD          32518
#endif /* WINVER >= 0x0600 */



#endif /* OEMRESOURCE */

#define ORD_LANGDRIVER    1     /* The ordinal number for the entry point of
                                ** language drivers.
                                */
WINUSERAPI
int
WINAPI
LoadStringA(
    __in_opt HINSTANCE hInstance,
    __in UINT uID,
    __out_ecount_part(cchBufferMax, return + 1) LPSTR lpBuffer,
    __in int cchBufferMax);
WINUSERAPI
int
WINAPI
LoadStringW(
    __in_opt HINSTANCE hInstance,
    __in UINT uID,
    __out_ecount_part(cchBufferMax, return + 1) LPWSTR lpBuffer,
    __in int cchBufferMax);
#ifdef UNICODE
#define LoadString  LoadStringW
#else
#define LoadString  LoadStringA
#endif // !UNICODE


/*
 * Edit Control Notification Codes
 */
#define EN_SETFOCUS         0x0100
#define EN_KILLFOCUS        0x0200
#define EN_CHANGE           0x0300
#define EN_UPDATE           0x0400
#define EN_ERRSPACE         0x0500
#define EN_MAXTEXT          0x0501
#define EN_HSCROLL          0x0601
#define EN_VSCROLL          0x0602

#if(_WIN32_WINNT >= 0x0500)
#define EN_ALIGN_LTR_EC     0x0700
#define EN_ALIGN_RTL_EC     0x0701
#endif /* _WIN32_WINNT >= 0x0500 */

#if(WINVER >= 0x0400)
/* Edit control EM_SETMARGIN parameters */
#define EC_LEFTMARGIN       0x0001
#define EC_RIGHTMARGIN      0x0002
#define EC_USEFONTINFO      0xffff
#endif /* WINVER >= 0x0400 */

#if(WINVER >= 0x0500)
/* wParam of EM_GET/SETIMESTATUS  */
#define EMSIS_COMPOSITIONSTRING        0x0001

/* lParam for EMSIS_COMPOSITIONSTRING  */
#define EIMES_GETCOMPSTRATONCE         0x0001
#define EIMES_CANCELCOMPSTRINFOCUS     0x0002
#define EIMES_COMPLETECOMPSTRKILLFOCUS 0x0004
#endif /* WINVER >= 0x0500 */

#ifndef NOWINMESSAGES


/*
 * Edit Control Messages
 */
#define EM_GETSEL               0x00B0
#define EM_SETSEL               0x00B1
#define EM_GETRECT              0x00B2
#define EM_SETRECT              0x00B3
#define EM_SETRECTNP            0x00B4
#define EM_SCROLL               0x00B5
#define EM_LINESCROLL           0x00B6
#define EM_SCROLLCARET          0x00B7
#define EM_GETMODIFY            0x00B8
#define EM_SETMODIFY            0x00B9
#define EM_GETLINECOUNT         0x00BA
#define EM_LINEINDEX            0x00BB
#define EM_SETHANDLE            0x00BC
#define EM_GETHANDLE            0x00BD
#define EM_GETTHUMB             0x00BE
#define EM_LINELENGTH           0x00C1
#define EM_REPLACESEL           0x00C2
#define EM_GETLINE              0x00C4
#define EM_LIMITTEXT            0x00C5
#define EM_CANUNDO              0x00C6
#define EM_UNDO                 0x00C7
#define EM_FMTLINES             0x00C8
#define EM_LINEFROMCHAR         0x00C9
#define EM_SETTABSTOPS          0x00CB
#define EM_SETPASSWORDCHAR      0x00CC
#define EM_EMPTYUNDOBUFFER      0x00CD
#define EM_GETFIRSTVISIBLELINE  0x00CE
#define EM_SETREADONLY          0x00CF
#define EM_SETWORDBREAKPROC     0x00D0
#define EM_GETWORDBREAKPROC     0x00D1
#define EM_GETPASSWORDCHAR      0x00D2
#if(WINVER >= 0x0400)
#define EM_SETMARGINS           0x00D3
#define EM_GETMARGINS           0x00D4
#define EM_SETLIMITTEXT         EM_LIMITTEXT   /* ;win40 Name change */
#define EM_GETLIMITTEXT         0x00D5
#define EM_POSFROMCHAR          0x00D6
#define EM_CHARFROMPOS          0x00D7
#endif /* WINVER >= 0x0400 */

#if(WINVER >= 0x0500)
#define EM_SETIMESTATUS         0x00D8
#define EM_GETIMESTATUS         0x00D9
#endif /* WINVER >= 0x0500 */


#endif /* !NOWINMESSAGES */

/*
 * EDITWORDBREAKPROC code values
 */
#define WB_LEFT            0
#define WB_RIGHT           1
#define WB_ISDELIMITER     2


/*
 * User Button Notification Codes
 */
#define BN_CLICKED          0
#define BN_PAINT            1
#define BN_HILITE           2
#define BN_UNHILITE         3
#define BN_DISABLE          4
#define BN_DOUBLECLICKED    5
#if(WINVER >= 0x0400)
#define BN_PUSHED           BN_HILITE
#define BN_UNPUSHED         BN_UNHILITE
#define BN_DBLCLK           BN_DOUBLECLICKED
#define BN_SETFOCUS         6
#define BN_KILLFOCUS        7
#endif /* WINVER >= 0x0400 */

/*
 * Button Control Messages
 */
#define BM_GETCHECK        0x00F0
#define BM_SETCHECK        0x00F1
#define BM_GETSTATE        0x00F2
#define BM_SETSTATE        0x00F3
#define BM_SETSTYLE        0x00F4
#if(WINVER >= 0x0400)
#define BM_CLICK           0x00F5
#define BM_GETIMAGE        0x00F6
#define BM_SETIMAGE        0x00F7
#endif /* WINVER >= 0x0400 */
#if(WINVER >= 0x0600)
#define BM_SETDONTCLICK    0x00F8
#endif /* WINVER >= 0x0600 */

#if(WINVER >= 0x0400)
#define BST_UNCHECKED      0x0000
#define BST_CHECKED        0x0001
#define BST_INDETERMINATE  0x0002
#define BST_PUSHED         0x0004
#define BST_FOCUS          0x0008
#endif /* WINVER >= 0x0400 */


#ifndef NOWINMESSAGES
/*
 * Static Control Mesages
 */
#define STM_SETICON         0x0170
#define STM_GETICON         0x0171
#if(WINVER >= 0x0400)
#define STM_SETIMAGE        0x0172
#define STM_GETIMAGE        0x0173
#define STN_CLICKED         0
#define STN_DBLCLK          1
#define STN_ENABLE          2
#define STN_DISABLE         3
#endif /* WINVER >= 0x0400 */
#define STM_MSGMAX          0x0174
#endif /* !NOWINMESSAGES */

/*
 * Dialog window class
 */
#define WC_DIALOG       (MAKEINTATOM(0x8002))

/*
 * Dialog Manager Routines
 */

#ifndef NOMSG

WINUSERAPI
BOOL
WINAPI
IsDialogMessageA(
    __in HWND hDlg,
    __in LPMSG lpMsg);
WINUSERAPI
BOOL
WINAPI
IsDialogMessageW(
    __in HWND hDlg,
    __in LPMSG lpMsg);
#ifdef UNICODE
#define IsDialogMessage  IsDialogMessageW
#else
#define IsDialogMessage  IsDialogMessageA
#endif // !UNICODE

#endif /* !NOMSG */

WINUSERAPI
BOOL
WINAPI
MapDialogRect(
    __in HWND hDlg,
    __inout LPRECT lpRect);

WINUSERAPI
int
WINAPI
DlgDirListA(
    __in HWND hDlg,
    __inout LPSTR lpPathSpec,
    __in int nIDListBox,
    __in int nIDStaticPath,
    __in UINT uFileType);
WINUSERAPI
int
WINAPI
DlgDirListW(
    __in HWND hDlg,
    __inout LPWSTR lpPathSpec,
    __in int nIDListBox,
    __in int nIDStaticPath,
    __in UINT uFileType);
#ifdef UNICODE
#define DlgDirList  DlgDirListW
#else
#define DlgDirList  DlgDirListA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
DlgDirSelectExA(
    __in HWND hwndDlg,
    __out_ecount(chCount) LPSTR lpString,
    __in int chCount,
    __in int idListBox);
WINUSERAPI
BOOL
WINAPI
DlgDirSelectExW(
    __in HWND hwndDlg,
    __out_ecount(chCount) LPWSTR lpString,
    __in int chCount,
    __in int idListBox);
#ifdef UNICODE
#define DlgDirSelectEx  DlgDirSelectExW
#else
#define DlgDirSelectEx  DlgDirSelectExA
#endif // !UNICODE

WINUSERAPI
int
WINAPI
DlgDirListComboBoxA(
    __in HWND hDlg,
    __inout LPSTR lpPathSpec,
    __in int nIDComboBox,
    __in int nIDStaticPath,
    __in UINT uFiletype);
WINUSERAPI
int
WINAPI
DlgDirListComboBoxW(
    __in HWND hDlg,
    __inout LPWSTR lpPathSpec,
    __in int nIDComboBox,
    __in int nIDStaticPath,
    __in UINT uFiletype);
#ifdef UNICODE
#define DlgDirListComboBox  DlgDirListComboBoxW
#else
#define DlgDirListComboBox  DlgDirListComboBoxA
#endif // !UNICODE

WINUSERAPI
BOOL
WINAPI
DlgDirSelectComboBoxExA(
    __in HWND hwndDlg,
    __out_ecount(cchOut) LPSTR lpString,
    __in int cchOut,
    __in int idComboBox);
WINUSERAPI
BOOL
WINAPI
DlgDirSelectComboBoxExW(
    __in HWND hwndDlg,
    __out_ecount(cchOut) LPWSTR lpString,
    __in int cchOut,
    __in int idComboBox);
#ifdef UNICODE
#define DlgDirSelectComboBoxEx  DlgDirSelectComboBoxExW
#else
#define DlgDirSelectComboBoxEx  DlgDirSelectComboBoxExA
#endif // !UNICODE


#define DM_GETDEFID         (WM_USER+0)
#define DM_SETDEFID         (WM_USER+1)

#if(WINVER >= 0x0400)
#define DM_REPOSITION       (WM_USER+2)
#endif /* WINVER >= 0x0400 */
/*
 * Returned in HIWORD() of DM_GETDEFID result if msg is supported
 */
#define DC_HASDEFID         0x534B


#define LB_CTLCODE          0L


/*
 * Scroll bar messages
 */
#ifndef NOWINMESSAGES
#define SBM_SETPOS                  0x00E0 /*not in win3.1 */
#define SBM_GETPOS                  0x00E1 /*not in win3.1 */
#define SBM_SETRANGE                0x00E2 /*not in win3.1 */
#define SBM_SETRANGEREDRAW          0x00E6 /*not in win3.1 */
#define SBM_GETRANGE                0x00E3 /*not in win3.1 */
#define SBM_ENABLE_ARROWS           0x00E4 /*not in win3.1 */
#if(WINVER >= 0x0400)
#define SBM_SETSCROLLINFO           0x00E9
#define SBM_GETSCROLLINFO           0x00EA
#endif /* WINVER >= 0x0400 */

#if(_WIN32_WINNT >= 0x0501)
#define SBM_GETSCROLLBARINFO        0x00EB
#endif /* _WIN32_WINNT >= 0x0501 */

#if(WINVER >= 0x0400)
#define SIF_RANGE           0x0001
#define SIF_PAGE            0x0002
#define SIF_POS             0x0004
#define SIF_DISABLENOSCROLL 0x0008
#define SIF_TRACKPOS        0x0010
#define SIF_ALL             (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS)

typedef struct tagSCROLLINFO
{
    UINT    cbSize;
    UINT    fMask;
    int     nMin;
    int     nMax;
    UINT    nPage;
    int     nPos;
    int     nTrackPos;
}   SCROLLINFO, FAR *LPSCROLLINFO;
typedef SCROLLINFO CONST FAR *LPCSCROLLINFO;

WINUSERAPI
int
WINAPI
SetScrollInfo(
    __in HWND hwnd,
    __in int nBar,
    __in LPCSCROLLINFO lpsi,
    __in BOOL redraw);

WINUSERAPI
BOOL
WINAPI
GetScrollInfo(
    __in HWND hwnd,
    __in int nBar,
    __inout LPSCROLLINFO lpsi);


WINUSERAPI
LRESULT
WINAPI
DefFrameProcA(
    __in HWND hWnd,
    __in_opt HWND hWndMDIClient,
    __in UINT uMsg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
LRESULT
WINAPI
DefFrameProcW(
    __in HWND hWnd,
    __in_opt HWND hWndMDIClient,
    __in UINT uMsg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define DefFrameProc  DefFrameProcW
#else
#define DefFrameProc  DefFrameProcA
#endif // !UNICODE

WINUSERAPI
#ifndef _MAC
LRESULT
WINAPI
#else
LRESULT
CALLBACK
#endif
DefMDIChildProcA(
    __in HWND hWnd,
    __in UINT uMsg,
    __in WPARAM wParam,
    __in LPARAM lParam);
WINUSERAPI
#ifndef _MAC
LRESULT
WINAPI
#else
LRESULT
CALLBACK
#endif
DefMDIChildProcW(
    __in HWND hWnd,
    __in UINT uMsg,
    __in WPARAM wParam,
    __in LPARAM lParam);
#ifdef UNICODE
#define DefMDIChildProc  DefMDIChildProcW
#else
#define DefMDIChildProc  DefMDIChildProcA
#endif // !UNICODE

#ifndef NOMSG

WINUSERAPI
BOOL
WINAPI
TranslateMDISysAccel(
    __in HWND hWndClient,
    __in LPMSG lpMsg);

#endif /* !NOMSG */

WINUSERAPI
UINT
WINAPI
ArrangeIconicWindows(
    __in HWND hWnd);

WINUSERAPI
HWND
WINAPI
CreateMDIWindowA(
    __in LPCSTR lpClassName,
    __in LPCSTR lpWindowName,
    __in DWORD dwStyle,
    __in int X,
    __in int Y,
    __in int nWidth,
    __in int nHeight,
    __in_opt HWND hWndParent,
    __in_opt HINSTANCE hInstance,
    __in LPARAM lParam);
WINUSERAPI
HWND
WINAPI
CreateMDIWindowW(
    __in LPCWSTR lpClassName,
    __in LPCWSTR lpWindowName,
    __in DWORD dwStyle,
    __in int X,
    __in int Y,
    __in int nWidth,
    __in int nHeight,
    __in_opt HWND hWndParent,
    __in_opt HINSTANCE hInstance,
    __in LPARAM lParam);
#ifdef UNICODE
#define CreateMDIWindow  CreateMDIWindowW
#else
#define CreateMDIWindow  CreateMDIWindowA
#endif // !UNICODE

#if(WINVER >= 0x0400)
WINUSERAPI
WORD
WINAPI
TileWindows(
    __in_opt HWND hwndParent,
    __in UINT wHow,
    __in_opt CONST RECT * lpRect,
    __in UINT cKids,
    __in_ecount_opt(cKids) const HWND FAR * lpKids);

WINUSERAPI
WORD
WINAPI CascadeWindows(
    __in_opt HWND hwndParent,
    __in UINT wHow,
    __in_opt CONST RECT * lpRect,
    __in UINT cKids,
    __in_ecount_opt(cKids) const HWND FAR * lpKids);

#endif /* WINVER >= 0x0400 */
#endif /* !NOMDI */

#endif /* !NOUSER */

/****** Help support ********************************************************/

#ifndef NOHELP

typedef DWORD HELPPOLY;
typedef struct tagMULTIKEYHELPA {
#ifndef _MAC
    DWORD  mkSize;
#else
    WORD   mkSize;
#endif
    CHAR   mkKeylist;
    CHAR   szKeyphrase[1];
} MULTIKEYHELPA, *PMULTIKEYHELPA, *LPMULTIKEYHELPA;
typedef struct tagMULTIKEYHELPW {
#ifndef _MAC
    DWORD  mkSize;
#else
    WORD   mkSize;
#endif
    WCHAR  mkKeylist;
    WCHAR  szKeyphrase[1];
} MULTIKEYHELPW, *PMULTIKEYHELPW, *LPMULTIKEYHELPW;
#ifdef UNICODE
typedef MULTIKEYHELPW MULTIKEYHELP;
typedef PMULTIKEYHELPW PMULTIKEYHELP;
typedef LPMULTIKEYHELPW LPMULTIKEYHELP;
#else
typedef MULTIKEYHELPA MULTIKEYHELP;
typedef PMULTIKEYHELPA PMULTIKEYHELP;
typedef LPMULTIKEYHELPA LPMULTIKEYHELP;
#endif // UNICODE

typedef struct tagHELPWININFOA {
    int  wStructSize;
    int  x;
    int  y;
    int  dx;
    int  dy;
    int  wMax;
    CHAR   rgchMember[2];
} HELPWININFOA, *PHELPWININFOA, *LPHELPWININFOA;
typedef struct tagHELPWININFOW {
    int  wStructSize;
    int  x;
    int  y;
    int  dx;
    int  dy;
    int  wMax;
    WCHAR  rgchMember[2];
} HELPWININFOW, *PHELPWININFOW, *LPHELPWININFOW;
#ifdef UNICODE
typedef HELPWININFOW HELPWININFO;
typedef PHELPWININFOW PHELPWININFO;
typedef LPHELPWININFOW LPHELPWININFO;
#else
typedef HELPWININFOA HELPWININFO;
typedef PHELPWININFOA PHELPWININFO;
typedef LPHELPWININFOA LPHELPWININFO;
#endif // UNICODE


/*
 * Commands to pass to WinHelp()
 */
#define HELP_CONTEXT      0x0001L  /* Display topic in ulTopic */
#define HELP_QUIT         0x0002L  /* Terminate help */
#define HELP_INDEX        0x0003L  /* Display index */
#define HELP_CONTENTS     0x0003L
#define HELP_HELPONHELP   0x0004L  /* Display help on using help */
#define HELP_SETINDEX     0x0005L  /* Set current Index for multi index help */
#define HELP_SETCONTENTS  0x0005L
#define HELP_CONTEXTPOPUP 0x0008L
#define HELP_FORCEFILE    0x0009L
#define HELP_KEY          0x0101L  /* Display topic for keyword in offabData */
#define HELP_COMMAND      0x0102L
#define HELP_PARTIALKEY   0x0105L
#define HELP_MULTIKEY     0x0201L
#define HELP_SETWINPOS    0x0203L
#if(WINVER >= 0x0400)
#define HELP_CONTEXTMENU  0x000a
#define HELP_FINDER       0x000b
#define HELP_WM_HELP      0x000c
#define HELP_SETPOPUP_POS 0x000d

#define HELP_TCARD              0x8000
#define HELP_TCARD_DATA         0x0010
#define HELP_TCARD_OTHER_CALLER 0x0011

// These are in winhelp.h in Win95.
#define IDH_NO_HELP                     28440
#define IDH_MISSING_CONTEXT             28441 // Control doesn't have matching help context
#define IDH_GENERIC_HELP_BUTTON         28442 // Property sheet help button
#define IDH_OK                          28443
#define IDH_CANCEL                      28444
#define IDH_HELP                        28445

#endif /* WINVER >= 0x0400 */



WINUSERAPI
BOOL
WINAPI
WinHelpA(
    __in_opt HWND hWndMain,
    __in_opt LPCSTR lpszHelp,
    __in UINT uCommand,
    __in ULONG_PTR dwData);
WINUSERAPI
BOOL
WINAPI
WinHelpW(
    __in_opt HWND hWndMain,
    __in_opt LPCWSTR lpszHelp,
    __in UINT uCommand,
    __in ULONG_PTR dwData);
#ifdef UNICODE
#define WinHelp  WinHelpW
#else
#define WinHelp  WinHelpA
#endif // !UNICODE

#endif /* !NOHELP */

#if(WINVER >= 0x0500)

#define GR_GDIOBJECTS       0       /* Count of GDI objects */
#define GR_USEROBJECTS      1       /* Count of USER objects */
#endif /* WINVER >= 0x0500 */
#if(WINVER >= 0x0601)
#define GR_GDIOBJECTS_PEAK  2       /* Peak count of GDI objects */
#define GR_USEROBJECTS_PEAK 4       /* Peak count of USER objects */
#endif /* WINVER >= 0x0601 */

#if(WINVER >= 0x0601)
#define GR_GLOBAL           ((HANDLE)-2)
#endif /* WINVER >= 0x0601 */

#if(WINVER >= 0x0500)
WINUSERAPI
DWORD
WINAPI
GetGuiResources(
    __in HANDLE hProcess,
    __in DWORD uiFlags);
#endif /* WINVER >= 0x0500 */




typedef struct tagSERIALKEYSA
{
    UINT    cbSize;
    DWORD   dwFlags;
    LPSTR     lpszActivePort;
    LPSTR     lpszPort;
    UINT    iBaudRate;
    UINT    iPortState;
    UINT    iActive;
}   SERIALKEYSA, *LPSERIALKEYSA;
typedef struct tagSERIALKEYSW
{
    UINT    cbSize;
    DWORD   dwFlags;
    LPWSTR    lpszActivePort;
    LPWSTR    lpszPort;
    UINT    iBaudRate;
    UINT    iPortState;
    UINT    iActive;
}   SERIALKEYSW, *LPSERIALKEYSW;
#ifdef UNICODE
typedef SERIALKEYSW SERIALKEYS;
typedef LPSERIALKEYSW LPSERIALKEYS;
#else
typedef SERIALKEYSA SERIALKEYS;
typedef LPSERIALKEYSA LPSERIALKEYS;
#endif // UNICODE

/* flags for SERIALKEYS dwFlags field */
#define SERKF_SERIALKEYSON  0x00000001
#define SERKF_AVAILABLE     0x00000002
#define SERKF_INDICATOR     0x00000004


typedef struct tagHIGHCONTRASTA
{
    UINT    cbSize;
    DWORD   dwFlags;
    LPSTR   lpszDefaultScheme;
}   HIGHCONTRASTA, *LPHIGHCONTRASTA;
typedef struct tagHIGHCONTRASTW
{
    UINT    cbSize;
    DWORD   dwFlags;
    LPWSTR  lpszDefaultScheme;
}   HIGHCONTRASTW, *LPHIGHCONTRASTW;
#ifdef UNICODE
typedef HIGHCONTRASTW HIGHCONTRAST;
typedef LPHIGHCONTRASTW LPHIGHCONTRAST;
#else
typedef HIGHCONTRASTA HIGHCONTRAST;
typedef LPHIGHCONTRASTA LPHIGHCONTRAST;
#endif // UNICODE

/* flags for HIGHCONTRAST dwFlags field */
#define HCF_HIGHCONTRASTON  0x00000001
#define HCF_AVAILABLE       0x00000002
#define HCF_HOTKEYACTIVE    0x00000004
#define HCF_CONFIRMHOTKEY   0x00000008
#define HCF_HOTKEYSOUND     0x00000010
#define HCF_INDICATOR       0x00000020
#define HCF_HOTKEYAVAILABLE 0x00000040
#define HCF_LOGONDESKTOP    0x00000100
#define HCF_DEFAULTDESKTOP  0x00000200

/* Flags for ChangeDisplaySettings */
#define CDS_UPDATEREGISTRY           0x00000001
#define CDS_TEST                     0x00000002
#define CDS_FULLSCREEN               0x00000004
#define CDS_GLOBAL                   0x00000008
#define CDS_SET_PRIMARY              0x00000010
#define CDS_VIDEOPARAMETERS          0x00000020
#if(WINVER >= 0x0600)
#define CDS_ENABLE_UNSAFE_MODES      0x00000100
#define CDS_DISABLE_UNSAFE_MODES     0x00000200
#endif /* WINVER >= 0x0600 */
#define CDS_RESET                    0x40000000
#define CDS_RESET_EX                 0x20000000
#define CDS_NORESET                  0x10000000

#include <tvout.h>

/* Return values for ChangeDisplaySettings */
#define DISP_CHANGE_SUCCESSFUL       0
#define DISP_CHANGE_RESTART          1
#define DISP_CHANGE_FAILED          -1
#define DISP_CHANGE_BADMODE         -2
#define DISP_CHANGE_NOTUPDATED      -3
#define DISP_CHANGE_BADFLAGS        -4
#define DISP_CHANGE_BADPARAM        -5
#if(_WIN32_WINNT >= 0x0501)
#define DISP_CHANGE_BADDUALVIEW     -6
#endif /* _WIN32_WINNT >= 0x0501 */

#ifdef _WINGDI_
#ifndef NOGDI

WINUSERAPI
LONG
WINAPI
ChangeDisplaySettingsA(
    __in_opt DEVMODEA* lpDevMode,
    __in DWORD dwFlags);
WINUSERAPI
LONG
WINAPI
ChangeDisplaySettingsW(
    __in_opt DEVMODEW* lpDevMode,
    __in DWORD dwFlags);
#ifdef UNICODE
#define ChangeDisplaySettings  ChangeDisplaySettingsW
#else
#define ChangeDisplaySettings  ChangeDisplaySettingsA
#endif // !UNICODE

WINUSERAPI
LONG
WINAPI
ChangeDisplaySettingsExA(
    __in_opt LPCSTR lpszDeviceName,
    __in_opt DEVMODEA* lpDevMode,
    __reserved HWND hwnd,
    __in DWORD dwflags,
    __in_opt LPVOID lParam);
WINUSERAPI
LONG
WINAPI
ChangeDisplaySettingsExW(
    __in_opt LPCWSTR lpszDeviceName,
    __in_opt DEVMODEW* lpDevMode,
    __reserved HWND hwnd,
    __in DWORD dwflags,
    __in_opt LPVOID lParam);
#ifdef UNICODE
#define ChangeDisplaySettingsEx  ChangeDisplaySettingsExW
#else
#define ChangeDisplaySettingsEx  ChangeDisplaySettingsExA
#endif // !UNICODE

#define ENUM_CURRENT_SETTINGS       ((DWORD)-1)
#define ENUM_REGISTRY_SETTINGS      ((DWORD)-2)

WINUSERAPI
BOOL
WINAPI
EnumDisplaySettingsA(
    __in_opt LPCSTR lpszDeviceName,
    __in DWORD iModeNum,
    __inout DEVMODEA* lpDevMode);
WINUSERAPI
BOOL
WINAPI
EnumDisplaySettingsW(
    __in_opt LPCWSTR lpszDeviceName,
    __in DWORD iModeNum,
    __inout DEVMODEW* lpDevMode);
#ifdef UNICODE
#define EnumDisplaySettings  EnumDisplaySettingsW
#else
#define EnumDisplaySettings  EnumDisplaySettingsA
#endif // !UNICODE

#if(WINVER >= 0x0500)

WINUSERAPI
BOOL
WINAPI
EnumDisplaySettingsExA(
    __in_opt LPCSTR lpszDeviceName,
    __in DWORD iModeNum,
    __inout DEVMODEA* lpDevMode,
    __in DWORD dwFlags);
WINUSERAPI
BOOL
WINAPI
EnumDisplaySettingsExW(
    __in_opt LPCWSTR lpszDeviceName,
    __in DWORD iModeNum,
    __inout DEVMODEW* lpDevMode,
    __in DWORD dwFlags);
#ifdef UNICODE
#define EnumDisplaySettingsEx  EnumDisplaySettingsExW
#else
#define EnumDisplaySettingsEx  EnumDisplaySettingsExA
#endif // !UNICODE

/* Flags for EnumDisplaySettingsEx */
#define EDS_RAWMODE                   0x00000002
#define EDS_ROTATEDMODE               0x00000004

WINUSERAPI
BOOL
WINAPI
EnumDisplayDevicesA(
    __in_opt LPCSTR lpDevice,
    __in DWORD iDevNum,
    __inout PDISPLAY_DEVICEA lpDisplayDevice,
    __in DWORD dwFlags);
WINUSERAPI
BOOL
WINAPI
EnumDisplayDevicesW(
    __in_opt LPCWSTR lpDevice,
    __in DWORD iDevNum,
    __inout PDISPLAY_DEVICEW lpDisplayDevice,
    __in DWORD dwFlags);
#ifdef UNICODE
#define EnumDisplayDevices  EnumDisplayDevicesW
#else
#define EnumDisplayDevices  EnumDisplayDevicesA
#endif // !UNICODE

/* Flags for EnumDisplayDevices */
#define EDD_GET_DEVICE_INTERFACE_NAME 0x00000001

#endif /* WINVER >= 0x0500 */

#if(WINVER >= 0x0601)

WINUSERAPI
LONG
WINAPI
GetDisplayConfigBufferSizes(
    __in UINT32 flags,
    __out UINT32* numPathArrayElements,
    __out UINT32* numModeInfoArrayElements);

WINUSERAPI
LONG
WINAPI
SetDisplayConfig(
    __in UINT32 numPathArrayElements,
    __in_ecount_opt(numPathArrayElements) DISPLAYCONFIG_PATH_INFO* pathArray,
    __in UINT32 numModeInfoArrayElements,
    __in_ecount_opt(numModeInfoArrayElements) DISPLAYCONFIG_MODE_INFO* modeInfoArray,
    __in UINT32 flags);

WINUSERAPI
LONG
WINAPI
QueryDisplayConfig(
    __in UINT32 flags,
    __inout UINT32* numPathArrayElements,
    __out_ecount_part(*numPathArrayElements, *numPathArrayElements) DISPLAYCONFIG_PATH_INFO* pathArray,
    __inout UINT32* numModeInfoArrayElements,
    __out_ecount_part(*numModeInfoArrayElements, *numModeInfoArrayElements) DISPLAYCONFIG_MODE_INFO* modeInfoArray,
    __out DISPLAYCONFIG_TOPOLOGY_ID* currentTopologyId);

WINUSERAPI
LONG
WINAPI
DisplayConfigGetDeviceInfo(
    __inout DISPLAYCONFIG_DEVICE_INFO_HEADER* requestPacket);

WINUSERAPI
LONG
WINAPI
DisplayConfigSetDeviceInfo(
    __in DISPLAYCONFIG_DEVICE_INFO_HEADER* setPacket);

#endif /* WINVER >= 0x0601 */

#endif /* NOGDI */
#endif /* _WINGDI_ */


WINUSERAPI
BOOL
WINAPI
SystemParametersInfoA(
    __in UINT uiAction,
    __in UINT uiParam,
    __inout_opt PVOID pvParam,
    __in UINT fWinIni);
WINUSERAPI
BOOL
WINAPI
SystemParametersInfoW(
    __in UINT uiAction,
    __in UINT uiParam,
    __inout_opt PVOID pvParam,
    __in UINT fWinIni);
#ifdef UNICODE
#define SystemParametersInfo  SystemParametersInfoW
#else
#define SystemParametersInfo  SystemParametersInfoA
#endif // !UNICODE


#endif  /* !NOSYSPARAMSINFO  */

/*
 * Accessibility support
 */
typedef struct tagFILTERKEYS
{
    UINT  cbSize;
    DWORD dwFlags;
    DWORD iWaitMSec;            // Acceptance Delay
    DWORD iDelayMSec;           // Delay Until Repeat
    DWORD iRepeatMSec;          // Repeat Rate
    DWORD iBounceMSec;          // Debounce Time
} FILTERKEYS, *LPFILTERKEYS;

/*
 * FILTERKEYS dwFlags field
 */
#define FKF_FILTERKEYSON    0x00000001
#define FKF_AVAILABLE       0x00000002
#define FKF_HOTKEYACTIVE    0x00000004
#define FKF_CONFIRMHOTKEY   0x00000008
#define FKF_HOTKEYSOUND     0x00000010
#define FKF_INDICATOR       0x00000020
#define FKF_CLICKON         0x00000040


#if(_WIN32_WINNT >= 0x0600)
WINUSERAPI
BOOL
WINAPI
SoundSentry(VOID);
#endif /* _WIN32_WINNT >= 0x0600 */


/*
 * Set debug level
 */

WINUSERAPI
VOID
WINAPI
SetDebugErrorLevel(
    __in DWORD dwLevel);

WINUSERAPI
int
WINAPI
InternalGetWindowText(
    __in HWND hWnd,
    __out_ecount_part(cchMaxCount, return + 1) LPWSTR pString,
    __in int cchMaxCount);


#if defined(WINNT)
WINUSERAPI
BOOL
WINAPI
EndTask(
    __in HWND hWnd,
    __in BOOL fShutDown,
    __in BOOL fForce);
#endif

WINUSERAPI
BOOL
WINAPI
CancelShutdown(
    VOID);


#if(WINVER >= 0x0500)

/*
 * Multimonitor API.
 */

#define MONITOR_DEFAULTTONULL       0x00000000
#define MONITOR_DEFAULTTOPRIMARY    0x00000001
#define MONITOR_DEFAULTTONEAREST    0x00000002

WINUSERAPI
HMONITOR
WINAPI
MonitorFromPoint(
    __in POINT pt,
    __in DWORD dwFlags);

WINUSERAPI
HMONITOR
WINAPI
MonitorFromRect(
    __in LPCRECT lprc,
    __in DWORD dwFlags);

WINUSERAPI
HMONITOR
WINAPI
MonitorFromWindow(
    __in HWND hwnd,
    __in DWORD dwFlags);

#define MONITORINFOF_PRIMARY        0x00000001

#ifndef CCHDEVICENAME
#define CCHDEVICENAME 32
#endif

typedef struct tagMONITORINFO
{
    DWORD   cbSize;
    RECT    rcMonitor;
    RECT    rcWork;
    DWORD   dwFlags;
} MONITORINFO, *LPMONITORINFO;

#ifdef __cplusplus
typedef struct tagMONITORINFOEXA : public tagMONITORINFO
{
    CHAR        szDevice[CCHDEVICENAME];
} MONITORINFOEXA, *LPMONITORINFOEXA;
typedef struct tagMONITORINFOEXW : public tagMONITORINFO
{
    WCHAR       szDevice[CCHDEVICENAME];
} MONITORINFOEXW, *LPMONITORINFOEXW;
#ifdef UNICODE
typedef MONITORINFOEXW MONITORINFOEX;
typedef LPMONITORINFOEXW LPMONITORINFOEX;
#else
typedef MONITORINFOEXA MONITORINFOEX;
typedef LPMONITORINFOEXA LPMONITORINFOEX;
#endif // UNICODE
#else // ndef __cplusplus
typedef struct tagMONITORINFOEXA
{
    MONITORINFO;
    CHAR        szDevice[CCHDEVICENAME];
} MONITORINFOEXA, *LPMONITORINFOEXA;
typedef struct tagMONITORINFOEXW
{
    MONITORINFO;
    WCHAR       szDevice[CCHDEVICENAME];
} MONITORINFOEXW, *LPMONITORINFOEXW;
#ifdef UNICODE
typedef MONITORINFOEXW MONITORINFOEX;
typedef LPMONITORINFOEXW LPMONITORINFOEX;
#else
typedef MONITORINFOEXA MONITORINFOEX;
typedef LPMONITORINFOEXA LPMONITORINFOEX;
#endif // UNICODE
#endif

WINUSERAPI
BOOL
WINAPI
GetMonitorInfoA(
    __in HMONITOR hMonitor,
    __inout LPMONITORINFO lpmi);
WINUSERAPI
BOOL
WINAPI
GetMonitorInfoW(
    __in HMONITOR hMonitor,
    __inout LPMONITORINFO lpmi);
#ifdef UNICODE
#define GetMonitorInfo  GetMonitorInfoW
#else
#define GetMonitorInfo  GetMonitorInfoA
#endif // !UNICODE

typedef BOOL (CALLBACK* MONITORENUMPROC)(HMONITOR, HDC, LPRECT, LPARAM);

WINUSERAPI
BOOL
WINAPI
EnumDisplayMonitors(
    __in_opt HDC hdc,
    __in_opt LPCRECT lprcClip,
    __in MONITORENUMPROC lpfnEnum,
    __in LPARAM dwData);


#ifndef NOWINABLE

/*
 * WinEvents - Active Accessibility hooks
 */

WINUSERAPI
VOID
WINAPI
NotifyWinEvent(
    __in DWORD event,
    __in HWND  hwnd,
    __in LONG  idObject,
    __in LONG  idChild);

typedef VOID (CALLBACK* WINEVENTPROC)(
    HWINEVENTHOOK hWinEventHook,
    DWORD         event,
    HWND          hwnd,
    LONG          idObject,
    LONG          idChild,
    DWORD         idEventThread,
    DWORD         dwmsEventTime);

WINUSERAPI
HWINEVENTHOOK
WINAPI
SetWinEventHook(
    __in DWORD eventMin,
    __in DWORD eventMax,
    __in_opt HMODULE hmodWinEventProc,
    __in WINEVENTPROC pfnWinEventProc,
    __in DWORD idProcess,
    __in DWORD idThread,
    __in DWORD dwFlags);

#if(_WIN32_WINNT >= 0x0501)
WINUSERAPI
BOOL
WINAPI
IsWinEventHookInstalled(
    __in DWORD event);
#endif /* _WIN32_WINNT >= 0x0501 */

/*
 * dwFlags for SetWinEventHook
 */
#define WINEVENT_OUTOFCONTEXT   0x0000  // Events are ASYNC
#define WINEVENT_SKIPOWNTHREAD  0x0001  // Don't call back for events on installer's thread
#define WINEVENT_SKIPOWNPROCESS 0x0002  // Don't call back for events on installer's process
#define WINEVENT_INCONTEXT      0x0004  // Events are SYNC, this causes your dll to be injected into every process

WINUSERAPI
BOOL
WINAPI
UnhookWinEvent(
    __in HWINEVENTHOOK hWinEventHook);

/*
 * idObject values for WinEventProc and NotifyWinEvent
 */

/*
 * hwnd + idObject can be used with OLEACC.DLL's OleGetObjectFromWindow()
 * to get an interface pointer to the container.  indexChild is the item
 * within the container in question.  Setup a VARIANT with vt VT_I4 and
 * lVal the indexChild and pass that in to all methods.  Then you
 * are raring to go.
 */


/*
 * Common object IDs (cookies, only for sending WM_GETOBJECT to get at the
 * thing in question).  Positive IDs are reserved for apps (app specific),
 * negative IDs are system things and are global, 0 means "just little old
 * me".
 */
#define     CHILDID_SELF        0
#define     INDEXID_OBJECT      0
#define     INDEXID_CONTAINER   0

/*
 * Reserved IDs for system objects
 */
#define     OBJID_WINDOW        ((LONG)0x00000000)
#define     OBJID_SYSMENU       ((LONG)0xFFFFFFFF)
#define     OBJID_TITLEBAR      ((LONG)0xFFFFFFFE)
#define     OBJID_MENU          ((LONG)0xFFFFFFFD)
#define     OBJID_CLIENT        ((LONG)0xFFFFFFFC)
#define     OBJID_VSCROLL       ((LONG)0xFFFFFFFB)
#define     OBJID_HSCROLL       ((LONG)0xFFFFFFFA)
#define     OBJID_SIZEGRIP      ((LONG)0xFFFFFFF9)
#define     OBJID_CARET         ((LONG)0xFFFFFFF8)
#define     OBJID_CURSOR        ((LONG)0xFFFFFFF7)
#define     OBJID_ALERT         ((LONG)0xFFFFFFF6)
#define     OBJID_SOUND         ((LONG)0xFFFFFFF5)
#define     OBJID_QUERYCLASSNAMEIDX ((LONG)0xFFFFFFF4)
#define     OBJID_NATIVEOM      ((LONG)0xFFFFFFF0)

/*
 * EVENT DEFINITION
 */
#define EVENT_MIN           0x00000001
#define EVENT_MAX           0x7FFFFFFF

/*
 *  EVENT_SYSTEM_SOUND
 *  Sent when a sound is played.  Currently nothing is generating this, we
 *  this event when a system sound (for menus, etc) is played.  Apps
 *  generate this, if accessible, when a private sound is played.  For
 *  example, if Mail plays a "New Mail" sound.
 *
 *  System Sounds:
 *  (Generated by PlaySoundEvent in USER itself)
 *      hwnd            is NULL
 *      idObject        is OBJID_SOUND
 *      idChild         is sound child ID if one
 *  App Sounds:
 *  (PlaySoundEvent won't generate notification; up to app)
 *      hwnd + idObject gets interface pointer to Sound object
 *      idChild identifies the sound in question
 *  are going to be cleaning up the SOUNDSENTRY feature in the control panel
 *  and will use this at that time.  Applications implementing WinEvents
 *  are perfectly welcome to use it.  Clients of IAccessible* will simply
 *  turn around and get back a non-visual object that describes the sound.
 */
#define EVENT_SYSTEM_SOUND              0x0001

/*
 * EVENT_SYSTEM_ALERT
 * System Alerts:
 * (Generated by MessageBox() calls for example)
 *      hwnd            is hwndMessageBox
 *      idObject        is OBJID_ALERT
 * App Alerts:
 * (Generated whenever)
 *      hwnd+idObject gets interface pointer to Alert
 */
#define EVENT_SYSTEM_ALERT              0x0002

/*
 * EVENT_SYSTEM_FOREGROUND
 * Sent when the foreground (active) window changes, even if it is changing
 * to another window in the same thread as the previous one.
 *      hwnd            is hwndNewForeground
 *      idObject        is OBJID_WINDOW
 *      idChild    is INDEXID_OBJECT
 */
#define EVENT_SYSTEM_FOREGROUND         0x0003

/*
 * Menu
 *      hwnd            is window (top level window or popup menu window)
 *      idObject        is ID of control (OBJID_MENU, OBJID_SYSMENU, OBJID_SELF for popup)
 *      idChild         is CHILDID_SELF
 *
 * EVENT_SYSTEM_MENUSTART
 * EVENT_SYSTEM_MENUEND
 * For MENUSTART, hwnd+idObject+idChild refers to the control with the menu bar,
 *  or the control bringing up the context menu.
 *
 * Sent when entering into and leaving from menu mode (system, app bar, and
 * track popups).
 */
#define EVENT_SYSTEM_MENUSTART          0x0004
#define EVENT_SYSTEM_MENUEND            0x0005

/*
 * EVENT_SYSTEM_MENUPOPUPSTART
 * EVENT_SYSTEM_MENUPOPUPEND
 * Sent when a menu popup comes up and just before it is taken down.  Note
 * that for a call to TrackPopupMenu(), a client will see EVENT_SYSTEM_MENUSTART
 * followed almost immediately by EVENT_SYSTEM_MENUPOPUPSTART for the popup
 * being shown.
 *
 * For MENUPOPUP, hwnd+idObject+idChild refers to the NEW popup coming up, not the
 * parent item which is hierarchical.  You can get the parent menu/popup by
 * asking for the accParent object.
 */
#define EVENT_SYSTEM_MENUPOPUPSTART     0x0006
#define EVENT_SYSTEM_MENUPOPUPEND       0x0007


/*
 * EVENT_SYSTEM_CAPTURESTART
 * EVENT_SYSTEM_CAPTUREEND
 * Sent when a window takes the capture and releases the capture.
 */
#define EVENT_SYSTEM_CAPTURESTART       0x0008
#define EVENT_SYSTEM_CAPTUREEND         0x0009

/*
 * Move Size
 * EVENT_SYSTEM_MOVESIZESTART
 * EVENT_SYSTEM_MOVESIZEEND
 * Sent when a window enters and leaves move-size dragging mode.
 */
#define EVENT_SYSTEM_MOVESIZESTART      0x000A
#define EVENT_SYSTEM_MOVESIZEEND        0x000B

/*
 * Context Help
 * EVENT_SYSTEM_CONTEXTHELPSTART
 * EVENT_SYSTEM_CONTEXTHELPEND
 * Sent when a window enters and leaves context sensitive help mode.
 */
#define EVENT_SYSTEM_CONTEXTHELPSTART   0x000C
#define EVENT_SYSTEM_CONTEXTHELPEND     0x000D

/*
 * Drag & Drop
 * EVENT_SYSTEM_DRAGDROPSTART
 * EVENT_SYSTEM_DRAGDROPEND
 * Send the START notification just before going into drag&drop loop.  Send
 * the END notification just after canceling out.
 * Note that it is up to apps and OLE to generate this, since the system
 * doesn't know.  Like EVENT_SYSTEM_SOUND, it will be a while before this
 * is prevalent.
 */
#define EVENT_SYSTEM_DRAGDROPSTART      0x000E
#define EVENT_SYSTEM_DRAGDROPEND        0x000F

/*
 * Dialog
 * Send the START notification right after the dialog is completely
 *  initialized and visible.  Send the END right before the dialog
 *  is hidden and goes away.
 * EVENT_SYSTEM_DIALOGSTART
 * EVENT_SYSTEM_DIALOGEND
 */
#define EVENT_SYSTEM_DIALOGSTART        0x0010
#define EVENT_SYSTEM_DIALOGEND          0x0011

/*
 * EVENT_SYSTEM_SCROLLING
 * EVENT_SYSTEM_SCROLLINGSTART
 * EVENT_SYSTEM_SCROLLINGEND
 * Sent when beginning and ending the tracking of a scrollbar in a window,
 * and also for scrollbar controls.
 */
#define EVENT_SYSTEM_SCROLLINGSTART     0x0012
#define EVENT_SYSTEM_SCROLLINGEND       0x0013

/*
 * Alt-Tab Window
 * Send the START notification right after the switch window is initialized
 * and visible.  Send the END right before it is hidden and goes away.
 * EVENT_SYSTEM_SWITCHSTART
 * EVENT_SYSTEM_SWITCHEND
 */
#define EVENT_SYSTEM_SWITCHSTART        0x0014
#define EVENT_SYSTEM_SWITCHEND          0x0015

/*
 * EVENT_SYSTEM_MINIMIZESTART
 * EVENT_SYSTEM_MINIMIZEEND
 * Sent when a window minimizes and just before it restores.
 */
#define EVENT_SYSTEM_MINIMIZESTART      0x0016
#define EVENT_SYSTEM_MINIMIZEEND        0x0017


#if(_WIN32_WINNT >= 0x0600)
#define EVENT_SYSTEM_DESKTOPSWITCH      0x0020
#endif /* _WIN32_WINNT >= 0x0600 */


#if(_WIN32_WINNT >= 0x0601)
#define EVENT_SYSTEM_END        0x00FF

#define EVENT_OEM_DEFINED_START     0x0101
#define EVENT_OEM_DEFINED_END       0x01FF

#define EVENT_UIA_EVENTID_START         0x4E00
#define EVENT_UIA_EVENTID_END           0x4EFF

#define EVENT_UIA_PROPID_START          0x7500
#define EVENT_UIA_PROPID_END            0x75FF
#endif /* _WIN32_WINNT >= 0x0601 */

#if(_WIN32_WINNT >= 0x0501)
#define EVENT_CONSOLE_CARET             0x4001
#define EVENT_CONSOLE_UPDATE_REGION     0x4002
#define EVENT_CONSOLE_UPDATE_SIMPLE     0x4003
#define EVENT_CONSOLE_UPDATE_SCROLL     0x4004
#define EVENT_CONSOLE_LAYOUT            0x4005
#define EVENT_CONSOLE_START_APPLICATION 0x4006
#define EVENT_CONSOLE_END_APPLICATION   0x4007

/*
 * Flags for EVENT_CONSOLE_START/END_APPLICATION.
 */
#if defined(_WIN64)
#define CONSOLE_APPLICATION_16BIT       0x0000
#else
#define CONSOLE_APPLICATION_16BIT       0x0001
#endif

/*
 * Flags for EVENT_CONSOLE_CARET
 */
#define CONSOLE_CARET_SELECTION         0x0001
#define CONSOLE_CARET_VISIBLE           0x0002
#endif /* _WIN32_WINNT >= 0x0501 */

#if(_WIN32_WINNT >= 0x0601)
#define EVENT_CONSOLE_END       0x40FF
#endif /* _WIN32_WINNT >= 0x0601 */

/*
 * Object events
 *
 * The system AND apps generate these.  The system generates these for
 * real windows.  Apps generate these for objects within their window which
 * act like a separate control, e.g. an item in a list view.
 *
 * When the system generate them, dwParam2 is always WMOBJID_SELF.  When
 * apps generate them, apps put the has-meaning-to-the-app-only ID value
 * in dwParam2.
 * For all events, if you want detailed accessibility information, callers
 * should
 *      * Call AccessibleObjectFromWindow() with the hwnd, idObject parameters
 *          of the event, and IID_IAccessible as the REFIID, to get back an
 *          IAccessible* to talk to
 *      * Initialize and fill in a VARIANT as VT_I4 with lVal the idChild
 *          parameter of the event.
 *      * If idChild isn't zero, call get_accChild() in the container to see
 *          if the child is an object in its own right.  If so, you will get
 *          back an IDispatch* object for the child.  You should release the
 *          parent, and call QueryInterface() on the child object to get its
 *          IAccessible*.  Then you talk directly to the child.  Otherwise,
 *          if get_accChild() returns you nothing, you should continue to
 *          use the child VARIANT.  You will ask the container for the properties
 *          of the child identified by the VARIANT.  In other words, the
 *          child in this case is accessible but not a full-blown object.
 *          Like a button on a titlebar which is 'small' and has no children.
 */

/*
 * For all EVENT_OBJECT events,
 *      hwnd is the dude to Send the WM_GETOBJECT message to (unless NULL,
 *          see above for system things)
 *      idObject is the ID of the object that can resolve any queries a
 *          client might have.  It's a way to deal with windowless controls,
 *          controls that are just drawn on the screen in some larger parent
 *          window (like SDM), or standard frame elements of a window.
 *      idChild is the piece inside of the object that is affected.  This
 *          allows clients to access things that are too small to have full
 *          blown objects in their own right.  Like the thumb of a scrollbar.
 *          The hwnd/idObject pair gets you to the container, the dude you
 *          probably want to talk to most of the time anyway.  The idChild
 *          can then be passed into the acc properties to get the name/value
 *          of it as needed.
 *
 * Example #1:
 *      System propagating a listbox selection change
 *      EVENT_OBJECT_SELECTION
 *          hwnd == listbox hwnd
 *          idObject == OBJID_WINDOW
 *          idChild == new selected item, or CHILDID_SELF if
 *              nothing now selected within container.
 *      Word '97 propagating a listbox selection change
 *          hwnd == SDM window
 *          idObject == SDM ID to get at listbox 'control'
 *          idChild == new selected item, or CHILDID_SELF if
 *              nothing
 *
 * Example #2:
 *      System propagating a menu item selection on the menu bar
 *      EVENT_OBJECT_SELECTION
 *          hwnd == top level window
 *          idObject == OBJID_MENU
 *          idChild == ID of child menu bar item selected
 *
 * Example #3:
 *      System propagating a dropdown coming off of said menu bar item
 *      EVENT_OBJECT_CREATE
 *          hwnd == popup item
 *          idObject == OBJID_WINDOW
 *          idChild == CHILDID_SELF
 *
 * Example #4:
 *
 * For EVENT_OBJECT_REORDER, the object referred to by hwnd/idObject is the
 * PARENT container in which the zorder is occurring.  This is because if
 * one child is zordering, all of them are changing their relative zorder.
 */
#define EVENT_OBJECT_CREATE                 0x8000  // hwnd + ID + idChild is created item
#define EVENT_OBJECT_DESTROY                0x8001  // hwnd + ID + idChild is destroyed item
#define EVENT_OBJECT_SHOW                   0x8002  // hwnd + ID + idChild is shown item
#define EVENT_OBJECT_HIDE                   0x8003  // hwnd + ID + idChild is hidden item
#define EVENT_OBJECT_REORDER                0x8004  // hwnd + ID + idChild is parent of zordering children
/*
 * NOTE:
 * Minimize the number of notifications!
 *
 * When you are hiding a parent object, obviously all child objects are no
 * longer visible on screen.  They still have the same "visible" status,
 * but are not truly visible.  Hence do not send HIDE notifications for the
 * children also.  One implies all.  The same goes for SHOW.
 */


#define EVENT_OBJECT_FOCUS                  0x8005  // hwnd + ID + idChild is focused item
#define EVENT_OBJECT_SELECTION              0x8006  // hwnd + ID + idChild is selected item (if only one), or idChild is OBJID_WINDOW if complex
#define EVENT_OBJECT_SELECTIONADD           0x8007  // hwnd + ID + idChild is item added
#define EVENT_OBJECT_SELECTIONREMOVE        0x8008  // hwnd + ID + idChild is item removed
#define EVENT_OBJECT_SELECTIONWITHIN        0x8009  // hwnd + ID + idChild is parent of changed selected items

/*
 * NOTES:
 * There is only one "focused" child item in a parent.  This is the place
 * keystrokes are going at a given moment.  Hence only send a notification
 * about where the NEW focus is going.  A NEW item getting the focus already
 * implies that the OLD item is losing it.
 *
 * SELECTION however can be multiple.  Hence the different SELECTION
 * notifications.  Here's when to use each:
 *
 * (1) Send a SELECTION notification in the simple single selection
 *     case (like the focus) when the item with the selection is
 *     merely moving to a different item within a container.  hwnd + ID
 *     is the container control, idChildItem is the new child with the
 *     selection.
 *
 * (2) Send a SELECTIONADD notification when a new item has simply been added
 *     to the selection within a container.  This is appropriate when the
 *     number of newly selected items is very small.  hwnd + ID is the
 *     container control, idChildItem is the new child added to the selection.
 *
 * (3) Send a SELECTIONREMOVE notification when a new item has simply been
 *     removed from the selection within a container.  This is appropriate
 *     when the number of newly selected items is very small, just like
 *     SELECTIONADD.  hwnd + ID is the container control, idChildItem is the
 *     new child removed from the selection.
 *
 * (4) Send a SELECTIONWITHIN notification when the selected items within a
 *     control have changed substantially.  Rather than propagate a large
 *     number of changes to reflect removal for some items, addition of
 *     others, just tell somebody who cares that a lot happened.  It will
 *     be faster an easier for somebody watching to just turn around and
 *     query the container control what the new bunch of selected items
 *     are.
 */

#define EVENT_OBJECT_STATECHANGE            0x800A  // hwnd + ID + idChild is item w/ state change
/*
 * Examples of when to send an EVENT_OBJECT_STATECHANGE include
 *      * It is being enabled/disabled (USER does for windows)
 *      * It is being pressed/released (USER does for buttons)
 *      * It is being checked/unchecked (USER does for radio/check buttons)
 */
#define EVENT_OBJECT_LOCATIONCHANGE         0x800B  // hwnd + ID + idChild is moved/sized item

/*
 * Note:
 * A LOCATIONCHANGE is not sent for every child object when the parent
 * changes shape/moves.  Send one notification for the topmost object
 * that is changing.  For example, if the user resizes a top level window,
 * USER will generate a LOCATIONCHANGE for it, but not for the menu bar,
 * title bar, scrollbars, etc.  that are also changing shape/moving.
 *
 * In other words, it only generates LOCATIONCHANGE notifications for
 * real windows that are moving/sizing.  It will not generate a LOCATIONCHANGE
 * for every non-floating child window when the parent moves (the children are
 * logically moving also on screen, but not relative to the parent).
 *
 * Now, if the app itself resizes child windows as a result of being
 * sized, USER will generate LOCATIONCHANGEs for those dudes also because
 * it doesn't know better.
 *
 * Note also that USER will generate LOCATIONCHANGE notifications for two
 * non-window sys objects:
 *      (1) System caret
 *      (2) Cursor
 */

#define EVENT_OBJECT_NAMECHANGE             0x800C  // hwnd + ID + idChild is item w/ name change
#define EVENT_OBJECT_DESCRIPTIONCHANGE      0x800D  // hwnd + ID + idChild is item w/ desc change
#define EVENT_OBJECT_VALUECHANGE            0x800E  // hwnd + ID + idChild is item w/ value change
#define EVENT_OBJECT_PARENTCHANGE           0x800F  // hwnd + ID + idChild is item w/ new parent
#define EVENT_OBJECT_HELPCHANGE             0x8010  // hwnd + ID + idChild is item w/ help change
#define EVENT_OBJECT_DEFACTIONCHANGE        0x8011  // hwnd + ID + idChild is item w/ def action change
#define EVENT_OBJECT_ACCELERATORCHANGE      0x8012  // hwnd + ID + idChild is item w/ keybd accel change

#if(_WIN32_WINNT >= 0x0600)
#define EVENT_OBJECT_INVOKED                0x8013  // hwnd + ID + idChild is item invoked
#define EVENT_OBJECT_TEXTSELECTIONCHANGED   0x8014  // hwnd + ID + idChild is item w? test selection change

/*
 * EVENT_OBJECT_CONTENTSCROLLED
 * Sent when ending the scrolling of a window object.
 *
 * Unlike the similar event (EVENT_SYSTEM_SCROLLEND), this event will be
 * associated with the scrolling window itself. There is no difference
 * between horizontal or vertical scrolling.
 *
 * This event should be posted whenever scroll action is completed, including
 * when it is scrolled by scroll bars, mouse wheel, or keyboard navigations.
 *
 *   example:
 *          hwnd == window that is scrolling
 *          idObject == OBJID_CLIENT
 *          idChild == CHILDID_SELF
 */
#define EVENT_OBJECT_CONTENTSCROLLED        0x8015
#endif /* _WIN32_WINNT >= 0x0600 */

#if(_WIN32_WINNT >= 0x0601)
#define EVENT_SYSTEM_ARRANGMENTPREVIEW      0x8016
#endif /* _WIN32_WINNT >= 0x0601 */

#if(_WIN32_WINNT >= 0x0601)
#define EVENT_OBJECT_END                    0x80FF

#define EVENT_AIA_START                     0xA000
#define EVENT_AIA_END                       0xAFFF
#endif /* _WIN32_WINNT >= 0x0601 */

/*
 * System Sounds (idChild of system SOUND notification)
 */
#define SOUND_SYSTEM_STARTUP            1
#define SOUND_SYSTEM_SHUTDOWN           2
#define SOUND_SYSTEM_BEEP               3
#define SOUND_SYSTEM_ERROR              4
#define SOUND_SYSTEM_QUESTION           5
#define SOUND_SYSTEM_WARNING            6
#define SOUND_SYSTEM_INFORMATION        7
#define SOUND_SYSTEM_MAXIMIZE           8
#define SOUND_SYSTEM_MINIMIZE           9
#define SOUND_SYSTEM_RESTOREUP          10
#define SOUND_SYSTEM_RESTOREDOWN        11
#define SOUND_SYSTEM_APPSTART           12
#define SOUND_SYSTEM_FAULT              13
#define SOUND_SYSTEM_APPEND             14
#define SOUND_SYSTEM_MENUCOMMAND        15
#define SOUND_SYSTEM_MENUPOPUP          16
#define CSOUND_SYSTEM                   16

/*
 * System Alerts (indexChild of system ALERT notification)
 */
#define ALERT_SYSTEM_INFORMATIONAL      1       // MB_INFORMATION
#define ALERT_SYSTEM_WARNING            2       // MB_WARNING
#define ALERT_SYSTEM_ERROR              3       // MB_ERROR
#define ALERT_SYSTEM_QUERY              4       // MB_QUESTION
#define ALERT_SYSTEM_CRITICAL           5       // HardSysErrBox
#define CALERT_SYSTEM                   6

typedef struct tagGUITHREADINFO
{
    DWORD   cbSize;
    DWORD   flags;
    HWND    hwndActive;
    HWND    hwndFocus;
    HWND    hwndCapture;
    HWND    hwndMenuOwner;
    HWND    hwndMoveSize;
    HWND    hwndCaret;
    RECT    rcCaret;
} GUITHREADINFO, *PGUITHREADINFO, FAR * LPGUITHREADINFO;

#define GUI_CARETBLINKING   0x00000001
#define GUI_INMOVESIZE      0x00000002
#define GUI_INMENUMODE      0x00000004
#define GUI_SYSTEMMENUMODE  0x00000008
#define GUI_POPUPMENUMODE   0x00000010
#if(_WIN32_WINNT >= 0x0501)
#if defined(_WIN64)
#define GUI_16BITTASK       0x00000000
#else
#define GUI_16BITTASK       0x00000020
#endif
#endif /* _WIN32_WINNT >= 0x0501 */

WINUSERAPI
BOOL
WINAPI
GetGUIThreadInfo(
    __in DWORD idThread,
    __inout PGUITHREADINFO pgui);

WINUSERAPI
BOOL
WINAPI
BlockInput(
    BOOL fBlockIt);

#if(_WIN32_WINNT >= 0x0600)

#define USER_DEFAULT_SCREEN_DPI 96

WINUSERAPI
BOOL
WINAPI
SetProcessDPIAware(
    VOID);

WINUSERAPI
BOOL
WINAPI
IsProcessDPIAware(
    VOID);
#endif /* _WIN32_WINNT >= 0x0600 */

WINUSERAPI
UINT
WINAPI
GetWindowModuleFileNameA(
    __in HWND hwnd,
    __out_ecount_part(cchFileNameMax, return) LPSTR pszFileName,
    __in UINT cchFileNameMax);
WINUSERAPI
UINT
WINAPI
GetWindowModuleFileNameW(
    __in HWND hwnd,
    __out_ecount_part(cchFileNameMax, return) LPWSTR pszFileName,
    __in UINT cchFileNameMax);
#ifdef UNICODE
#define GetWindowModuleFileName  GetWindowModuleFileNameW
#else
#define GetWindowModuleFileName  GetWindowModuleFileNameA
#endif // !UNICODE


/*
 * Menubar information
 */
typedef struct tagMENUBARINFO
{
    DWORD cbSize;
    RECT rcBar;          // rect of bar, popup, item
    HMENU hMenu;         // real menu handle of bar, popup
    HWND hwndMenu;       // hwnd of item submenu if one
    BOOL fBarFocused:1;  // bar, popup has the focus
    BOOL fFocused:1;     // item has the focus
} MENUBARINFO, *PMENUBARINFO, *LPMENUBARINFO;

WINUSERAPI
BOOL
WINAPI
GetMenuBarInfo(
    __in HWND hwnd,
    __in LONG idObject,
    __in LONG idItem,
    __inout PMENUBARINFO pmbi);

/*
 * Scrollbar information
 */
typedef struct tagSCROLLBARINFO
{
    DWORD cbSize;
    RECT rcScrollBar;
    int dxyLineButton;
    int xyThumbTop;
    int xyThumbBottom;
    int reserved;
    DWORD rgstate[CCHILDREN_SCROLLBAR + 1];
} SCROLLBARINFO, *PSCROLLBARINFO, *LPSCROLLBARINFO;

WINUSERAPI
BOOL
WINAPI
GetScrollBarInfo(
    __in HWND hwnd,
    __in LONG idObject,
    __inout PSCROLLBARINFO psbi);


/*
 * The "real" ancestor window
 */
#define     GA_PARENT       1
#define     GA_ROOT         2
#define     GA_ROOTOWNER    3

WINUSERAPI
HWND
WINAPI
GetAncestor(
    __in HWND hwnd,
    __in UINT gaFlags);


/*
 * This gets the REAL child window at the point.  If it is in the dead
 * space of a group box, it will try a sibling behind it.  But static
 * fields will get returned.  In other words, it is kind of a cross between
 * ChildWindowFromPointEx and WindowFromPoint.
 */
WINUSERAPI
HWND
WINAPI
RealChildWindowFromPoint(
    __in HWND hwndParent,
    __in POINT ptParentClientCoords);


/*
 * This gets the name of the window TYPE, not class.  This allows us to
 * recognize ThunderButton32 et al.
 */
WINUSERAPI
UINT
WINAPI
RealGetWindowClassA(
    __in HWND hwnd,
    __out_ecount_part(cchClassNameMax, return) LPSTR ptszClassName,
    __in UINT cchClassNameMax);
/*
 * This gets the name of the window TYPE, not class.  This allows us to
 * recognize ThunderButton32 et al.
 */
WINUSERAPI
UINT
WINAPI
RealGetWindowClassW(
    __in HWND hwnd,
    __out_ecount_part(cchClassNameMax, return) LPWSTR ptszClassName,
    __in UINT cchClassNameMax);
#ifdef UNICODE
#define RealGetWindowClass  RealGetWindowClassW
#else
#define RealGetWindowClass  RealGetWindowClassA
#endif // !UNICODE

/*
 * Alt-Tab Switch window information.
 */
typedef struct tagALTTABINFO
{
    DWORD cbSize;
    int cItems;
    int cColumns;
    int cRows;
    int iColFocus;
    int iRowFocus;
    int cxItem;
    int cyItem;
    POINT ptStart;
} ALTTABINFO, *PALTTABINFO, *LPALTTABINFO;

WINUSERAPI
BOOL
WINAPI
GetAltTabInfoA(
    __in_opt HWND hwnd,
    __in int iItem,
    __inout PALTTABINFO pati,
    __out_ecount_opt(cchItemText) LPSTR pszItemText,
    __in UINT cchItemText);
WINUSERAPI
BOOL
WINAPI
GetAltTabInfoW(
    __in_opt HWND hwnd,
    __in int iItem,
    __inout PALTTABINFO pati,
    __out_ecount_opt(cchItemText) LPWSTR pszItemText,
    __in UINT cchItemText);
#ifdef UNICODE
#define GetAltTabInfo  GetAltTabInfoW
#else
#define GetAltTabInfo  GetAltTabInfoA
#endif // !UNICODE

/*
 * Listbox information.
 * Returns the number of items per row.
 */
WINUSERAPI
DWORD
WINAPI
GetListBoxInfo(
    __in HWND hwnd);

#endif /* NOWINABLE */
#endif /* WINVER >= 0x0500 */


#if(_WIN32_WINNT >= 0x0500)
WINUSERAPI
BOOL
WINAPI
LockWorkStation(
    VOID);
#endif /* _WIN32_WINNT >= 0x0500 */

#if(_WIN32_WINNT >= 0x0500)

WINUSERAPI
BOOL
WINAPI
UserHandleGrantAccess(
    __in HANDLE hUserHandle,
    __in HANDLE hJob,
    __in BOOL   bGrant);

#endif /* _WIN32_WINNT >= 0x0500 */

#if(_WIN32_WINNT >= 0x0501)

/*
 * Raw Input Messages.
 */

DECLARE_HANDLE(HRAWINPUT);

/*
 * WM_INPUT wParam
 */

/*
 * Use this macro to get the input code from wParam.
 */
#define GET_RAWINPUT_CODE_WPARAM(wParam)    ((wParam) & 0xff)

/*
 * The input is in the regular message flow,
 * the app is required to call DefWindowProc
 * so that the system can perform clean ups.
 */
#define RIM_INPUT       0

/*
 * The input is sink only. The app is expected
 * to behave nicely.
 */
#define RIM_INPUTSINK   1


/*
 * Raw Input data header
 */
typedef struct tagRAWINPUTHEADER {
    DWORD dwType;
    DWORD dwSize;
    HANDLE hDevice;
    WPARAM wParam;
} RAWINPUTHEADER, *PRAWINPUTHEADER, *LPRAWINPUTHEADER;

/*
 * Type of the raw input
 */
#define RIM_TYPEMOUSE       0
#define RIM_TYPEKEYBOARD    1
#define RIM_TYPEHID         2

/*
 * Raw format of the mouse input
 */
typedef struct tagRAWMOUSE {
    /*
     * Indicator flags.
     */
    USHORT usFlags;

    /*
     * The transition state of the mouse buttons.
     */
    union {
        ULONG ulButtons;
        struct  {
            USHORT  usButtonFlags;
            USHORT  usButtonData;
        };
    };


    /*
     * The raw state of the mouse buttons.
     */
    ULONG ulRawButtons;

    /*
     * The signed relative or absolute motion in the X direction.
     */
    LONG lLastX;

    /*
     * The signed relative or absolute motion in the Y direction.
     */
    LONG lLastY;

    /*
     * Device-specific additional information for the event.
     */
    ULONG ulExtraInformation;

} RAWMOUSE, *PRAWMOUSE, *LPRAWMOUSE;

/*
 * Define the mouse button state indicators.
 */

#define RI_MOUSE_LEFT_BUTTON_DOWN   0x0001  // Left Button changed to down.
#define RI_MOUSE_LEFT_BUTTON_UP     0x0002  // Left Button changed to up.
#define RI_MOUSE_RIGHT_BUTTON_DOWN  0x0004  // Right Button changed to down.
#define RI_MOUSE_RIGHT_BUTTON_UP    0x0008  // Right Button changed to up.
#define RI_MOUSE_MIDDLE_BUTTON_DOWN 0x0010  // Middle Button changed to down.
#define RI_MOUSE_MIDDLE_BUTTON_UP   0x0020  // Middle Button changed to up.

#define RI_MOUSE_BUTTON_1_DOWN      RI_MOUSE_LEFT_BUTTON_DOWN
#define RI_MOUSE_BUTTON_1_UP        RI_MOUSE_LEFT_BUTTON_UP
#define RI_MOUSE_BUTTON_2_DOWN      RI_MOUSE_RIGHT_BUTTON_DOWN
#define RI_MOUSE_BUTTON_2_UP        RI_MOUSE_RIGHT_BUTTON_UP
#define RI_MOUSE_BUTTON_3_DOWN      RI_MOUSE_MIDDLE_BUTTON_DOWN
#define RI_MOUSE_BUTTON_3_UP        RI_MOUSE_MIDDLE_BUTTON_UP

#define RI_MOUSE_BUTTON_4_DOWN      0x0040
#define RI_MOUSE_BUTTON_4_UP        0x0080
#define RI_MOUSE_BUTTON_5_DOWN      0x0100
#define RI_MOUSE_BUTTON_5_UP        0x0200

/*
 * If usButtonFlags has RI_MOUSE_WHEEL, the wheel delta is stored in usButtonData.
 * Take it as a signed value.
 */
#define RI_MOUSE_WHEEL              0x0400

/*
 * Define the mouse indicator flags.
 */
#define MOUSE_MOVE_RELATIVE         0
#define MOUSE_MOVE_ABSOLUTE         1
#define MOUSE_VIRTUAL_DESKTOP    0x02  // the coordinates are mapped to the virtual desktop
#define MOUSE_ATTRIBUTES_CHANGED 0x04  // requery for mouse attributes
#if(WINVER >= 0x0600)
#define MOUSE_MOVE_NOCOALESCE    0x08  // do not coalesce mouse moves
#endif /* WINVER >= 0x0600 */

/*
 * Raw format of the keyboard input
 */
typedef struct tagRAWKEYBOARD {
    /*
     * The "make" scan code (key depression).
     */
    USHORT MakeCode;

    /*
     * The flags field indicates a "break" (key release) and other
     * miscellaneous scan code information defined in ntddkbd.h.
     */
    USHORT Flags;

    USHORT Reserved;

    /*
     * Windows message compatible information
     */
    USHORT VKey;
    UINT   Message;

    /*
     * Device-specific additional information for the event.
     */
    ULONG ExtraInformation;


} RAWKEYBOARD, *PRAWKEYBOARD, *LPRAWKEYBOARD;


/*
 * Define the keyboard overrun MakeCode.
 */

#define KEYBOARD_OVERRUN_MAKE_CODE    0xFF

/*
 * Define the keyboard input data Flags.
 */
#define RI_KEY_MAKE             0
#define RI_KEY_BREAK            1
#define RI_KEY_E0               2
#define RI_KEY_E1               4
#define RI_KEY_TERMSRV_SET_LED  8
#define RI_KEY_TERMSRV_SHADOW   0x10


/*
 * Raw format of the input from Human Input Devices
 */
typedef struct tagRAWHID {
    DWORD dwSizeHid;    // byte size of each report
    DWORD dwCount;      // number of input packed
    BYTE bRawData[1];
} RAWHID, *PRAWHID, *LPRAWHID;

/*
 * RAWINPUT data structure.
 */
typedef struct tagRAWINPUT {
    RAWINPUTHEADER header;
    union {
        RAWMOUSE    mouse;
        RAWKEYBOARD keyboard;
        RAWHID      hid;
    } data;
} RAWINPUT, *PRAWINPUT, *LPRAWINPUT;

#ifdef _WIN64
#define RAWINPUT_ALIGN(x)   (((x) + sizeof(QWORD) - 1) & ~(sizeof(QWORD) - 1))
#else   // _WIN64
#define RAWINPUT_ALIGN(x)   (((x) + sizeof(DWORD) - 1) & ~(sizeof(DWORD) - 1))
#endif  // _WIN64

#define NEXTRAWINPUTBLOCK(ptr) ((PRAWINPUT)RAWINPUT_ALIGN((ULONG_PTR)((PBYTE)(ptr) + (ptr)->header.dwSize)))

/*
 * Flags for GetRawInputData
 */

#define RID_INPUT               0x10000003
#define RID_HEADER              0x10000005

WINUSERAPI
UINT
WINAPI
GetRawInputData(
    __in HRAWINPUT hRawInput,
    __in UINT uiCommand,
    __out_bcount_part_opt(*pcbSize, return) LPVOID pData,
    __inout PUINT pcbSize,
    __in UINT cbSizeHeader);

/*
 * Raw Input Device Information
 */
#define RIDI_PREPARSEDDATA      0x20000005
#define RIDI_DEVICENAME         0x20000007  // the return valus is the character length, not the byte size
#define RIDI_DEVICEINFO         0x2000000b

typedef struct tagRID_DEVICE_INFO_MOUSE {
    DWORD dwId;
    DWORD dwNumberOfButtons;
    DWORD dwSampleRate;
    BOOL  fHasHorizontalWheel;
} RID_DEVICE_INFO_MOUSE, *PRID_DEVICE_INFO_MOUSE;

typedef struct tagRID_DEVICE_INFO_KEYBOARD {
    DWORD dwType;
    DWORD dwSubType;
    DWORD dwKeyboardMode;
    DWORD dwNumberOfFunctionKeys;
    DWORD dwNumberOfIndicators;
    DWORD dwNumberOfKeysTotal;
} RID_DEVICE_INFO_KEYBOARD, *PRID_DEVICE_INFO_KEYBOARD;

typedef struct tagRID_DEVICE_INFO_HID {
    DWORD dwVendorId;
    DWORD dwProductId;
    DWORD dwVersionNumber;

    /*
     * Top level collection UsagePage and Usage
     */
    USHORT usUsagePage;
    USHORT usUsage;
} RID_DEVICE_INFO_HID, *PRID_DEVICE_INFO_HID;

typedef struct tagRID_DEVICE_INFO {
    DWORD cbSize;
    DWORD dwType;
    union {
        RID_DEVICE_INFO_MOUSE mouse;
        RID_DEVICE_INFO_KEYBOARD keyboard;
        RID_DEVICE_INFO_HID hid;
    };
} RID_DEVICE_INFO, *PRID_DEVICE_INFO, *LPRID_DEVICE_INFO;

WINUSERAPI
UINT
WINAPI
GetRawInputDeviceInfoA(
    __in_opt HANDLE hDevice,
    __in UINT uiCommand,
    __inout_bcount_part_opt(*pcbSize, *pcbSize) LPVOID pData,
    __inout PUINT pcbSize);
WINUSERAPI
UINT
WINAPI
GetRawInputDeviceInfoW(
    __in_opt HANDLE hDevice,
    __in UINT uiCommand,
    __inout_bcount_part_opt(*pcbSize, *pcbSize) LPVOID pData,
    __inout PUINT pcbSize);
#ifdef UNICODE
#define GetRawInputDeviceInfo  GetRawInputDeviceInfoW
#else
#define GetRawInputDeviceInfo  GetRawInputDeviceInfoA
#endif // !UNICODE


/*
 * Raw Input Bulk Read: GetRawInputBuffer
 */
WINUSERAPI
UINT
WINAPI
GetRawInputBuffer(
    __out_bcount_opt(*pcbSize) PRAWINPUT pData,
    __inout PUINT pcbSize,
    __in UINT cbSizeHeader);

/*
 * Raw Input request APIs
 */
typedef struct tagRAWINPUTDEVICE {
    USHORT usUsagePage; // Toplevel collection UsagePage
    USHORT usUsage;     // Toplevel collection Usage
    DWORD dwFlags;
    HWND hwndTarget;    // Target hwnd. NULL = follows keyboard focus
} RAWINPUTDEVICE, *PRAWINPUTDEVICE, *LPRAWINPUTDEVICE;

typedef CONST RAWINPUTDEVICE* PCRAWINPUTDEVICE;

#define RIDEV_REMOVE            0x00000001
#define RIDEV_EXCLUDE           0x00000010
#define RIDEV_PAGEONLY          0x00000020
#define RIDEV_NOLEGACY          0x00000030
#define RIDEV_INPUTSINK         0x00000100
#define RIDEV_CAPTUREMOUSE      0x00000200  // effective when mouse nolegacy is specified, otherwise it would be an error
#define RIDEV_NOHOTKEYS         0x00000200  // effective for keyboard.
#define RIDEV_APPKEYS           0x00000400  // effective for keyboard.
#if(_WIN32_WINNT >= 0x0501)
#define RIDEV_EXINPUTSINK       0x00001000
#define RIDEV_DEVNOTIFY         0x00002000
#endif /* _WIN32_WINNT >= 0x0501 */
#define RIDEV_EXMODEMASK        0x000000F0

#define RIDEV_EXMODE(mode)  ((mode) & RIDEV_EXMODEMASK)

#if(_WIN32_WINNT >= 0x0501)
/*
 * Flags for the WM_INPUT_DEVICE_CHANGE message.
 */
#define GIDC_ARRIVAL             1
#define GIDC_REMOVAL             2
#endif /* _WIN32_WINNT >= 0x0501 */

#if (_WIN32_WINNT >= 0x0601)
#define GET_DEVICE_CHANGE_WPARAM(wParam)  (LOWORD(wParam))
#elif (_WIN32_WINNT >= 0x0501)
#define GET_DEVICE_CHANGE_LPARAM(lParam)  (LOWORD(lParam))
#endif /* (_WIN32_WINNT >= 0x0601) */

WINUSERAPI
BOOL
WINAPI
RegisterRawInputDevices(
    __in_ecount(uiNumDevices) PCRAWINPUTDEVICE pRawInputDevices,
    __in UINT uiNumDevices,
    __in UINT cbSize);

WINUSERAPI
UINT
WINAPI
GetRegisteredRawInputDevices(
    __out_ecount_opt( *puiNumDevices) PRAWINPUTDEVICE pRawInputDevices,
    __inout PUINT puiNumDevices,
    __in UINT cbSize);


typedef struct tagRAWINPUTDEVICELIST {
    HANDLE hDevice;
    DWORD dwType;
} RAWINPUTDEVICELIST, *PRAWINPUTDEVICELIST;

WINUSERAPI
UINT
WINAPI
GetRawInputDeviceList(
    __out_ecount_opt(*puiNumDevices) PRAWINPUTDEVICELIST pRawInputDeviceList,
    __inout PUINT puiNumDevices,
    __in UINT cbSize);

WINUSERAPI
LRESULT
WINAPI
DefRawInputProc(
    __in_ecount(nInput) PRAWINPUT* paRawInput,
    __in INT nInput,
    __in UINT cbSizeHeader);

#endif /* _WIN32_WINNT >= 0x0501 */


#if(WINVER >= 0x0600)

/*
 * Message Filter
 */

#define MSGFLT_ADD 1
#define MSGFLT_REMOVE 2

WINUSERAPI
BOOL
WINAPI
ChangeWindowMessageFilter(
    __in UINT message,
    __in DWORD dwFlag);

#endif /* WINVER >= 0x0600 */

#if(WINVER >= 0x0601)

/*
 * Message filter info values (CHANGEFILTERSTRUCT.ExtStatus)
 */
#define MSGFLTINFO_NONE                         (0)
#define MSGFLTINFO_ALREADYALLOWED_FORWND        (1)
#define MSGFLTINFO_ALREADYDISALLOWED_FORWND     (2)
#define MSGFLTINFO_ALLOWED_HIGHER               (3)

typedef struct tagCHANGEFILTERSTRUCT {
    DWORD cbSize;
    DWORD ExtStatus;
} CHANGEFILTERSTRUCT, *PCHANGEFILTERSTRUCT;

/*
 * Message filter action values (action parameter to ChangeWindowMessageFilterEx)
 */
#define MSGFLT_RESET                            (0)
#define MSGFLT_ALLOW                            (1)
#define MSGFLT_DISALLOW                         (2)

WINUSERAPI
BOOL
WINAPI
ChangeWindowMessageFilterEx(
    __in HWND hwnd,                                         // Window
    __in UINT message,                                      // WM_ message
    __in DWORD action,                                      // Message filter action value
    __inout_opt PCHANGEFILTERSTRUCT pChangeFilterStruct);   // Optional

#endif /* WINVER >= 0x0601 */



/*
 * Gesture notification structure
 *   - The WM_GESTURENOTIFY message lParam contains a pointer to this structure.
 *   - The WM_GESTURENOTIFY message notifies a window that gesture recognition is
 *     in progress and a gesture will be generated if one is recognized under the
 *     current gesture settings.
 */
typedef struct tagGESTURENOTIFYSTRUCT {
    UINT cbSize;                    // size, in bytes, of this structure
    DWORD dwFlags;                  // unused
    HWND hwndTarget;                // handle to window targeted by the gesture
    POINTS ptsLocation;             // starting location
    DWORD dwInstanceID;             // internally used
} GESTURENOTIFYSTRUCT, *PGESTURENOTIFYSTRUCT;

/*
 * Gesture argument helpers
 *   - Angle should be a double in the range of -2pi to +2pi
 *   - Argument should be an unsigned 16-bit value
 */
#define GID_ROTATE_ANGLE_TO_ARGUMENT(_arg_)     ((USHORT)((((_arg_) + 2.0 * 3.14159265) / (4.0 * 3.14159265)) * 65535.0))
#define GID_ROTATE_ANGLE_FROM_ARGUMENT(_arg_)   ((((double)(_arg_) / 65535.0) * 4.0 * 3.14159265) - 2.0 * 3.14159265)

/*
 * Gesture information retrieval
 *   - HGESTUREINFO is received by a window in the lParam of a WM_GESTURE message.
 */
WINUSERAPI
BOOL
WINAPI
GetGestureInfo(
    __in HGESTUREINFO hGestureInfo,
    __out PGESTUREINFO pGestureInfo);

/*
 * Gesture extra arguments retrieval
 *   - HGESTUREINFO is received by a window in the lParam of a WM_GESTURE message.
 *   - Size, in bytes, of the extra argument data is available in the cbExtraArgs
 *     field of the GESTUREINFO structure retrieved using the GetGestureInfo function.
 */
WINUSERAPI
BOOL
WINAPI
GetGestureExtraArgs(
    __in HGESTUREINFO hGestureInfo,
    __in UINT cbExtraArgs,
    __out_bcount(cbExtraArgs) PBYTE pExtraArgs);

/*
 * Gesture information handle management
 *   - If an application processes the WM_GESTURE message, then once it is done
 *     with the associated HGESTUREINFO, the application is responsible for
 *     closing the handle using this function. Failure to do so may result in
 *     process memory leaks.
 *   - If the message is instead passed to DefWindowProc, or is forwarded using
 *     one of the PostMessage or SendMessage class of API functions, the handle
 *     is transfered with the message and need not be closed by the application.
 */
WINUSERAPI
BOOL
WINAPI
CloseGestureInfoHandle(
    __in HGESTUREINFO hGestureInfo);


/*
 * Gesture configuration structure
 *   - Used in SetGestureConfig and GetGestureConfig
 *   - Note that any setting not included in either GESTURECONFIG.dwWant or
 *     GESTURECONFIG.dwBlock will use the parent window's preferences or
 *     system defaults.
 */
typedef struct tagGESTURECONFIG {
    DWORD dwID;                     // gesture ID
    DWORD dwWant;                   // settings related to gesture ID that are to be turned on
    DWORD dwBlock;                  // settings related to gesture ID that are to be turned off
} GESTURECONFIG, *PGESTURECONFIG;

/*
 * Gesture configuration flags - GESTURECONFIG.dwWant or GESTURECONFIG.dwBlock
 */

/*
 * Common gesture configuration flags - set GESTURECONFIG.dwID to zero
 */
#define GC_ALLGESTURES                              0x00000001

/*
 * Zoom gesture configuration flags - set GESTURECONFIG.dwID to GID_ZOOM
 */
#define GC_ZOOM                                     0x00000001

/*
 * Pan gesture configuration flags - set GESTURECONFIG.dwID to GID_PAN
 */
#define GC_PAN                                      0x00000001
#define GC_PAN_WITH_SINGLE_FINGER_VERTICALLY        0x00000002
#define GC_PAN_WITH_SINGLE_FINGER_HORIZONTALLY      0x00000004
#define GC_PAN_WITH_GUTTER                          0x00000008
#define GC_PAN_WITH_INERTIA                         0x00000010

/*
 * Rotate gesture configuration flags - set GESTURECONFIG.dwID to GID_ROTATE
 */
#define GC_ROTATE                                   0x00000001

/*
 * Two finger tap gesture configuration flags - set GESTURECONFIG.dwID to GID_TWOFINGERTAP
 */
#define GC_TWOFINGERTAP                             0x00000001

/*
 * PressAndTap gesture configuration flags - set GESTURECONFIG.dwID to GID_PRESSANDTAP
 */
#define GC_PRESSANDTAP                              0x00000001
#define GC_ROLLOVER                                 GC_PRESSANDTAP

#define GESTURECONFIGMAXCOUNT           256             // Maximum number of gestures that can be included
                                                        // in a single call to SetGestureConfig / GetGestureConfig

WINUSERAPI
BOOL
WINAPI
SetGestureConfig(
    __in HWND hwnd,                                     // window for which configuration is specified
    __in DWORD dwReserved,                              // reserved, must be 0
    __in UINT cIDs,                                     // count of GESTURECONFIG structures
    __in_ecount(cIDs) PGESTURECONFIG pGestureConfig,    // array of GESTURECONFIG structures, dwIDs will be processed in the
                                                        // order specified and repeated occurances will overwrite previous ones
    __in UINT cbSize);                                  // sizeof(GESTURECONFIG)


#define GCF_INCLUDE_ANCESTORS           0x00000001      // If specified, GetGestureConfig returns consolidated configuration
                                                        // for the specified window and it's parent window chain

WINUSERAPI
BOOL
WINAPI
GetGestureConfig(
    __in HWND hwnd,                                     // window for which configuration is required
    __in DWORD dwReserved,                              // reserved, must be 0
    __in DWORD dwFlags,                                 // see GCF_* flags
    __in PUINT pcIDs,                                   // *pcIDs contains the size, in number of GESTURECONFIG structures,
                                                        // of the buffer pointed to by pGestureConfig
    __inout_ecount(*pcIDs) PGESTURECONFIG pGestureConfig,
                                                        // pointer to buffer to receive the returned array of GESTURECONFIG structures
    __in UINT cbSize);                                  // sizeof(GESTURECONFIG)



#endif /* WINVER >= 0x0601 */



#define MAX_STR_BLOCKREASON 256

WINUSERAPI
BOOL
WINAPI
ShutdownBlockReasonCreate(
    __in HWND hWnd,
    __in LPCWSTR pwszReason);

WINUSERAPI
BOOL
WINAPI
ShutdownBlockReasonQuery(
    __in HWND hWnd,
    __out_ecount_opt(*pcchBuff) LPWSTR pwszBuff,
    __inout DWORD *pcchBuff);

WINUSERAPI
BOOL
WINAPI
ShutdownBlockReasonDestroy(
    __in HWND hWnd);
