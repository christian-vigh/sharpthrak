/**************************************************************************************************************

    NAME
        WinAPI/Constants.cs

    DESCRIPTION
        Top class file for Windows constants.

    AUTHOR
        Christian Vigh, 08/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/08/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/


using	System  ;
using	System. Runtime. InteropServices  ;

using   Thrak. WinAPI. WAPI ;


namespace Thrak. WinAPI. Enums
   {

	# region SUBLANG_ constants for sub-language ids
	/// <summary>
	/// Sublanguage IDs.
	/// <para>
	/// The name immediately following SUBLANG_ dictates which primary language ID that sublanguage ID can be combined with to form a valid language ID.
	/// </para>
	/// <para>
	/// Note that the LANG, SUBLANG construction is not always consistent. The named locale APIs (eg GetLocaleInfoEx) are recommended.
	/// </para>
	/// </summary>
	public enum  SUBLANG_Constants		:  ushort 
	   {
		/// <summary>
		/// Language neutral
		/// </summary>
		SUBLANG_NEUTRAL                             =  0x00,
		/// <summary>
		/// User default
		/// </summary>
		SUBLANG_DEFAULT                             =  0x01,
		/// <summary>
		/// System default
		/// </summary>
		SUBLANG_SYS_DEFAULT                         =  0x02,
		/// <summary>
		/// Default custom language/locale
		/// </summary>
		SUBLANG_CUSTOM_DEFAULT                      =  0x03,
		/// <summary>
		/// custom language/locale
		/// </summary>
		SUBLANG_CUSTOM_UNSPECIFIED                  =  0x04,
		/// <summary>
		/// Default custom MUI language/locale
		/// </summary>
		SUBLANG_UI_CUSTOM_DEFAULT                   =  0x05,

		/// <summary>
		/// Afrikaans (South Africa) =  0x0436 af-ZA
		/// </summary>
		SUBLANG_AFRIKAANS_SOUTH_AFRICA              =  0x01,
		/// <summary>
		/// Albanian (Albania) =  0x041c sq-AL
		/// </summary>
		SUBLANG_ALBANIAN_ALBANIA                    =  0x01,
		/// <summary>
		/// Alsatian (France) =  0x0484,
		/// </summary>
		SUBLANG_ALSATIAN_FRANCE                     =  0x01,
		/// <summary>
		/// Amharic (Ethiopia) =  0x045e,
		/// </summary>
		SUBLANG_AMHARIC_ETHIOPIA                    =  0x01,
		/// <summary>
		/// Arabic (Saudi Arabia)
		/// </summary>
		SUBLANG_ARABIC_SAUDI_ARABIA                 =  0x01,
		/// <summary>
		/// Arabic (Iraq)
		/// </summary>
		SUBLANG_ARABIC_IRAQ                         =  0x02,
		/// <summary>
		/// Arabic (Egypt)
		/// </summary>
		SUBLANG_ARABIC_EGYPT                        =  0x03,
		/// <summary>
		/// Arabic (Libya)
		/// </summary>
		SUBLANG_ARABIC_LIBYA                        =  0x04,
		/// <summary>
		/// Arabic (Algeria)
		/// </summary>
		SUBLANG_ARABIC_ALGERIA                      =  0x05,
		/// <summary>
		/// Arabic (Morocco)
		/// </summary>
		SUBLANG_ARABIC_MOROCCO                      =  0x06,
		/// <summary>
		/// Arabic (Tunisia)
		/// </summary>
		SUBLANG_ARABIC_TUNISIA                      =  0x07,
		/// <summary>
		/// Arabic (Oman)
		/// </summary>
		SUBLANG_ARABIC_OMAN                         =  0x08,
		/// <summary>
		/// Arabic (Yemen)
		/// </summary>
		SUBLANG_ARABIC_YEMEN                        =  0x09,
		/// <summary>
		/// Arabic (Syria)
		/// </summary>
		SUBLANG_ARABIC_SYRIA                        =  0x0a,
		/// <summary>
		/// Arabic (Jordan)
		/// </summary>
		SUBLANG_ARABIC_JORDAN                       =  0x0b,
		/// <summary>
		/// Arabic (Lebanon)
		/// </summary>
		SUBLANG_ARABIC_LEBANON                      =  0x0c,
		/// <summary>
		/// Arabic (Kuwait)
		/// </summary>
		SUBLANG_ARABIC_KUWAIT                       =  0x0d,
		/// <summary>
		/// Arabic (U.A.E)
		/// </summary>
		SUBLANG_ARABIC_UAE                          =  0x0e,
		/// <summary>
		/// Arabic (Bahrain)
		/// </summary>
		SUBLANG_ARABIC_BAHRAIN                      =  0x0f,
		/// <summary>
		/// Arabic (Qatar)
		/// </summary>
		SUBLANG_ARABIC_QATAR                        =  0x10,
		/// <summary>
		/// Armenian (Armenia) =  0x042b hy-AM
		/// </summary>
		SUBLANG_ARMENIAN_ARMENIA                    =  0x01,
		/// <summary>
		/// Assamese (India) =  0x044d,
		/// </summary>
		SUBLANG_ASSAMESE_INDIA                      =  0x01,
		/// <summary>
		/// Azeri (Latin)
		/// </summary>
		SUBLANG_AZERI_LATIN                         =  0x01,
		/// <summary>
		/// Azeri (Cyrillic)
		/// </summary>
		SUBLANG_AZERI_CYRILLIC                      =  0x02,
		/// <summary>
		/// Bashkir (Russia) =  0x046d ba-RU
		/// </summary>
		SUBLANG_BASHKIR_RUSSIA                      =  0x01,
		/// <summary>
		/// Basque (Basque) =  0x042d eu-ES
		/// </summary>
		SUBLANG_BASQUE_BASQUE                       =  0x01,
		/// <summary>
		/// Belarusian (Belarus) =  0x0423 be-BY
		/// </summary>
		SUBLANG_BELARUSIAN_BELARUS                  =  0x01,
		/// <summary>
		/// Bengali (India)
		/// </summary>
		SUBLANG_BENGALI_INDIA                       =  0x01,
		/// <summary>
		/// Bengali (Bangladesh)
		/// </summary>
		SUBLANG_BENGALI_BANGLADESH                  =  0x02,
		/// <summary>
		/// Bosnian (Bosnia and Herzegovina - Latin) =  0x141a bs-BA-Latn
		/// </summary>
		SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN    =  0x05,
		/// <summary>
		/// Bosnian (Bosnia and Herzegovina - Cyrillic) =  0x201a bs-BA-Cyrl
		/// </summary>
		SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC =  0x08,
		/// <summary>
		/// Breton (France) =  0x047e,
		/// </summary>
		SUBLANG_BRETON_FRANCE                       =  0x01,
		/// <summary>
		/// Bulgarian (Bulgaria) =  0x0402,
		/// </summary>
		SUBLANG_BULGARIAN_BULGARIA                  =  0x01,
		/// <summary>
		/// Catalan (Catalan) =  0x0403,
		/// </summary>
		SUBLANG_CATALAN_CATALAN                     =  0x01,
		/// <summary>
		/// Chinese (Taiwan) =  0x0404 zh-TW
		/// </summary>
		SUBLANG_CHINESE_TRADITIONAL                 =  0x01,
		/// <summary>
		/// Chinese (PR China) =  0x0804 zh-CN
		/// </summary>
		SUBLANG_CHINESE_SIMPLIFIED                  =  0x02,
		/// <summary>
		/// Chinese (Hong Kong S.A.R., P.R.C.) =  0x0c04 zh-HK
		/// </summary>
		SUBLANG_CHINESE_HONGKONG                    =  0x03,
		/// <summary>
		/// Chinese (Singapore) =  0x1004 zh-SG
		/// </summary>
		SUBLANG_CHINESE_SINGAPORE                   =  0x04,
		/// <summary>
		/// Chinese (Macau S.A.R.) =  0x1404 zh-MO
		/// </summary>
		SUBLANG_CHINESE_MACAU                       =  0x05,
		/// <summary>
		/// Corsican (France) =  0x0483,
		/// </summary>
		SUBLANG_CORSICAN_FRANCE                     =  0x01,
		/// <summary>
		/// Czech (Czech Republic) =  0x0405,
		/// </summary>
		SUBLANG_CZECH_CZECH_REPUBLIC                =  0x01,
		/// <summary>
		/// Croatian (Croatia)
		/// </summary>
		SUBLANG_CROATIAN_CROATIA                    =  0x01,
		/// <summary>
		/// Croatian (Bosnia and Herzegovina - Latin) =  0x101a hr-BA
		/// </summary>
		SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN   =  0x04,
		/// <summary>
		/// Danish (Denmark) =  0x0406,
		/// </summary>
		SUBLANG_DANISH_DENMARK                      =  0x01,
		/// <summary>
		/// Dari (Afghanistan)
		/// </summary>
		SUBLANG_DARI_AFGHANISTAN                    =  0x01,
		/// <summary>
		/// Divehi (Maldives) =  0x0465 div-MV
		/// </summary>
		SUBLANG_DIVEHI_MALDIVES                     =  0x01,
		/// <summary>
		/// Dutch
		/// </summary>
		SUBLANG_DUTCH                               =  0x01,
		/// <summary>
		/// Dutch (Belgian)
		/// </summary>
		SUBLANG_DUTCH_BELGIAN                       =  0x02,
		/// <summary>
		/// English (USA)
		/// </summary>
		SUBLANG_ENGLISH_US                          =  0x01,
		/// <summary>
		/// English (UK)
		/// </summary>
		SUBLANG_ENGLISH_UK                          =  0x02,
		/// <summary>
		/// English (Australian)
		/// </summary>
		SUBLANG_ENGLISH_AUS                         =  0x03,
		/// <summary>
		/// English (Canadian)
		/// </summary>
		SUBLANG_ENGLISH_CAN                         =  0x04,
		/// <summary>
		/// English (New Zealand)
		/// </summary>
		SUBLANG_ENGLISH_NZ                          =  0x05,
		/// <summary>
		/// English (Irish)
		/// </summary>
		SUBLANG_ENGLISH_EIRE                        =  0x06,
		/// <summary>
		/// English (South Africa)
		/// </summary>
		SUBLANG_ENGLISH_SOUTH_AFRICA                =  0x07,
		/// <summary>
		/// English (Jamaica)
		/// </summary>
		SUBLANG_ENGLISH_JAMAICA                     =  0x08,
		/// <summary>
		/// English (Caribbean)
		/// </summary>
		SUBLANG_ENGLISH_CARIBBEAN                   =  0x09,
		/// <summary>
		/// English (Belize)
		/// </summary>
		SUBLANG_ENGLISH_BELIZE                      =  0x0a,
		/// <summary>
		/// English (Trinidad)
		/// </summary>
		SUBLANG_ENGLISH_TRINIDAD                    =  0x0b,
		/// <summary>
		/// English (Zimbabwe)
		/// </summary>
		SUBLANG_ENGLISH_ZIMBABWE                    =  0x0c,
		/// <summary>
		/// English (Philippines)
		/// </summary>
		SUBLANG_ENGLISH_PHILIPPINES                 =  0x0d,
		/// <summary>
		/// English (India)
		/// </summary>
		SUBLANG_ENGLISH_INDIA                       =  0x10,
		/// <summary>
		/// English (Malaysia)
		/// </summary>
		SUBLANG_ENGLISH_MALAYSIA                    =  0x11,
		/// <summary>
		/// English (Singapore)
		/// </summary>
		SUBLANG_ENGLISH_SINGAPORE                   =  0x12,
		/// <summary>
		/// Estonian (Estonia) =  0x0425 et-EE
		/// </summary>
		SUBLANG_ESTONIAN_ESTONIA                    =  0x01,
		/// <summary>
		/// Faroese (Faroe Islands) =  0x0438 fo-FO
		/// </summary>
		SUBLANG_FAEROESE_FAROE_ISLANDS              =  0x01,
		/// <summary>
		/// Filipino (Philippines) =  0x0464 fil-PH
		/// </summary>
		SUBLANG_FILIPINO_PHILIPPINES                =  0x01,
		/// <summary>
		/// Finnish (Finland) =  0x040b,
		/// </summary>
		SUBLANG_FINNISH_FINLAND                     =  0x01,
		/// <summary>
		/// French
		/// </summary>
		SUBLANG_FRENCH                              =  0x01,
		/// <summary>
		/// French (Belgian)
		/// </summary>
		SUBLANG_FRENCH_BELGIAN                      =  0x02,
		/// <summary>
		/// French (Canadian)
		/// </summary>
		SUBLANG_FRENCH_CANADIAN                     =  0x03,
		/// <summary>
		/// French (Swiss)
		/// </summary>
		SUBLANG_FRENCH_SWISS                        =  0x04,
		/// <summary>
		/// French (Luxembourg)
		/// </summary>
		SUBLANG_FRENCH_LUXEMBOURG                   =  0x05,
		/// <summary>
		/// French (Monaco)
		/// </summary>
		SUBLANG_FRENCH_MONACO                       =  0x06,
		/// <summary>
		/// Frisian (Netherlands) =  0x0462 fy-NL
		/// </summary>
		SUBLANG_FRISIAN_NETHERLANDS                 =  0x01,
		/// <summary>
		/// Galician (Galician) =  0x0456 gl-ES
		/// </summary>
		SUBLANG_GALICIAN_GALICIAN                   =  0x01,
		/// <summary>
		/// Georgian (Georgia) =  0x0437 ka-GE
		/// </summary>
		SUBLANG_GEORGIAN_GEORGIA                    =  0x01,
		/// <summary>
		/// German
		/// </summary>
		SUBLANG_GERMAN                              =  0x01,
		/// <summary>
		/// German (Swiss)
		/// </summary>
		SUBLANG_GERMAN_SWISS                        =  0x02,
		/// <summary>
		/// German (Austrian)
		/// </summary>
		SUBLANG_GERMAN_AUSTRIAN                     =  0x03,
		/// <summary>
		/// German (Luxembourg)
		/// </summary>
		SUBLANG_GERMAN_LUXEMBOURG                   =  0x04,
		/// <summary>
		/// German (Liechtenstein)
		/// </summary>
		SUBLANG_GERMAN_LIECHTENSTEIN                =  0x05,
		/// <summary>
		/// Greek (Greece)
		/// </summary>
		SUBLANG_GREEK_GREECE                        =  0x01,
		/// <summary>
		/// Greenlandic (Greenland) =  0x046f kl-GL
		/// </summary>
		SUBLANG_GREENLANDIC_GREENLAND               =  0x01,
		/// <summary>
		/// Gujarati (India (Gujarati Script)) =  0x0447 gu-IN
		/// </summary>
		SUBLANG_GUJARATI_INDIA                      =  0x01,
		/// <summary>
		/// Hausa (Latin, Nigeria) =  0x0468 ha-NG-Latn
		/// </summary>
		SUBLANG_HAUSA_NIGERIA_LATIN                 =  0x01,
		/// <summary>
		/// Hebrew (Israel) =  0x040d,
		/// </summary>
		SUBLANG_HEBREW_ISRAEL                       =  0x01,
		/// <summary>
		/// Hindi (India) =  0x0439 hi-IN
		/// </summary>
		SUBLANG_HINDI_INDIA                         =  0x01,
		/// <summary>
		/// Hungarian (Hungary) =  0x040e,
		/// </summary>
		SUBLANG_HUNGARIAN_HUNGARY                   =  0x01,
		/// <summary>
		/// Icelandic (Iceland) =  0x040f,
		/// </summary>
		SUBLANG_ICELANDIC_ICELAND                   =  0x01,
		/// <summary>
		/// Igbo (Nigeria) =  0x0470 ig-NG
		/// </summary>
		SUBLANG_IGBO_NIGERIA                        =  0x01,
		/// <summary>
		/// Indonesian (Indonesia) =  0x0421 id-ID
		/// </summary>
		SUBLANG_INDONESIAN_INDONESIA                =  0x01,
		/// <summary>
		/// Inuktitut (Syllabics) (Canada) =  0x045d iu-CA-Cans
		/// </summary>
		SUBLANG_INUKTITUT_CANADA                    =  0x01,
		/// <summary>
		/// Inuktitut (Canada - Latin)
		/// </summary>
		SUBLANG_INUKTITUT_CANADA_LATIN              =  0x02,
		/// <summary>
		/// Irish (Ireland)
		/// </summary>
		SUBLANG_IRISH_IRELAND                       =  0x02,
		/// <summary>
		/// Italian
		/// </summary>
		SUBLANG_ITALIAN                             =  0x01,
		/// <summary>
		/// Italian (Swiss)
		/// </summary>
		SUBLANG_ITALIAN_SWISS                       =  0x02,
		/// <summary>
		/// Japanese (Japan) =  0x0411,
		/// </summary>
		SUBLANG_JAPANESE_JAPAN                      =  0x01,
		/// <summary>
		/// Kannada (India (Kannada Script)) =  0x044b kn-IN
		/// </summary>
		SUBLANG_KANNADA_INDIA                       =  0x01,
		/// <summary>
		/// Kashmiri (South Asia)
		/// </summary>
		SUBLANG_KASHMIRI_SASIA                      =  0x02,
		/// <summary>
		/// For app compatibility only
		/// </summary>
		SUBLANG_KASHMIRI_INDIA                      =  0x02,
		/// <summary>
		/// Kazakh (Kazakhstan) =  0x043f kk-KZ
		/// </summary>
		SUBLANG_KAZAK_KAZAKHSTAN                    =  0x01,
		/// <summary>
		/// Khmer (Cambodia) =  0x0453 kh-KH
		/// </summary>
		SUBLANG_KHMER_CAMBODIA                      =  0x01,
		/// <summary>
		/// K'iche (Guatemala)
		/// </summary>
		SUBLANG_KICHE_GUATEMALA                     =  0x01,
		/// <summary>
		/// Kinyarwanda (Rwanda) =  0x0487 rw-RW
		/// </summary>
		SUBLANG_KINYARWANDA_RWANDA                  =  0x01,
		/// <summary>
		/// Konkani (India) =  0x0457 kok-IN
		/// </summary>
		SUBLANG_KONKANI_INDIA                       =  0x01,
		/// <summary>
		/// Korean (Extended Wansung)
		/// </summary>
		SUBLANG_KOREAN                              =  0x01,
		/// <summary>
		/// Kyrgyz (Kyrgyzstan) =  0x0440 ky-KG
		/// </summary>
		SUBLANG_KYRGYZ_KYRGYZSTAN                   =  0x01,
		/// <summary>
		/// Lao (Lao PDR) =  0x0454 lo-LA
		/// </summary>
		SUBLANG_LAO_LAO                             =  0x01,
		/// <summary>
		/// Latvian (Latvia) =  0x0426 lv-LV
		/// </summary>
		SUBLANG_LATVIAN_LATVIA                      =  0x01,
		/// <summary>
		/// Lithuanian
		/// </summary>
		SUBLANG_LITHUANIAN                          =  0x01,
		/// <summary>
		/// Lower Sorbian (Germany) =  0x082e wee-DE
		/// </summary>
		SUBLANG_LOWER_SORBIAN_GERMANY               =  0x02,
		/// <summary>
		/// Luxembourgish (Luxembourg) =  0x046e lb-LU
		/// </summary>
		SUBLANG_LUXEMBOURGISH_LUXEMBOURG            =  0x01,
		/// <summary>
		/// Macedonian (Macedonia (FYROM)) =  0x042f mk-MK
		/// </summary>
		SUBLANG_MACEDONIAN_MACEDONIA                =  0x01,
		/// <summary>
		/// Malay (Malaysia)
		/// </summary>
		SUBLANG_MALAY_MALAYSIA                      =  0x01,
		/// <summary>
		/// Malay (Brunei Darussalam)
		/// </summary>
		SUBLANG_MALAY_BRUNEI_DARUSSALAM             =  0x02,
		/// <summary>
		/// Malayalam (India (Malayalam Script) ) =  0x044c ml-IN
		/// </summary>
		SUBLANG_MALAYALAM_INDIA                     =  0x01,
		/// <summary>
		/// Maltese (Malta) =  0x043a mt-MT
		/// </summary>
		SUBLANG_MALTESE_MALTA                       =  0x01,
		/// <summary>
		/// Maori (New Zealand) =  0x0481 mi-NZ
		/// </summary>
		SUBLANG_MAORI_NEW_ZEALAND                   =  0x01,
		/// <summary>
		/// Mapudungun (Chile) =  0x047a arn-CL
		/// </summary>
		SUBLANG_MAPUDUNGUN_CHILE                    =  0x01,
		/// <summary>
		/// Marathi (India) =  0x044e mr-IN
		/// </summary>
		SUBLANG_MARATHI_INDIA                       =  0x01,
		/// <summary>
		/// Mohawk (Mohawk) =  0x047c moh-CA
		/// </summary>
		SUBLANG_MOHAWK_MOHAWK                       =  0x01,
		/// <summary>
		/// Mongolian (Cyrillic, Mongolia)
		/// </summary>
		SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA         =  0x01,
		/// <summary>
		/// Mongolian (PRC)
		/// </summary>
		SUBLANG_MONGOLIAN_PRC                       =  0x02,
		/// <summary>
		/// Nepali (India)
		/// </summary>
		SUBLANG_NEPALI_INDIA                        =  0x02,
		/// <summary>
		/// Nepali (Nepal) =  0x0461 ne-NP
		/// </summary>
		SUBLANG_NEPALI_NEPAL                        =  0x01,
		/// <summary>
		/// Norwegian (Bokmal)
		/// </summary>
		SUBLANG_NORWEGIAN_BOKMAL                    =  0x01,
		/// <summary>
		/// Norwegian (Nynorsk)
		/// </summary>
		SUBLANG_NORWEGIAN_NYNORSK                   =  0x02,
		/// <summary>
		/// Occitan (France) =  0x0482 oc-FR
		/// </summary>
		SUBLANG_OCCITAN_FRANCE                      =  0x01,
		/// <summary>
		/// Oriya (India (Oriya Script)) =  0x0448 or-IN
		/// </summary>
		SUBLANG_ORIYA_INDIA                         =  0x01,
		/// <summary>
		/// Pashto (Afghanistan)
		/// </summary>
		SUBLANG_PASHTO_AFGHANISTAN                  =  0x01,
		/// <summary>
		/// Persian (Iran) =  0x0429 fa-IR
		/// </summary>
		SUBLANG_PERSIAN_IRAN                        =  0x01,
		/// <summary>
		/// Polish (Poland) =  0x0415,
		/// </summary>
		SUBLANG_POLISH_POLAND                       =  0x01,
		/// <summary>
		/// Portuguese
		/// </summary>
		SUBLANG_PORTUGUESE                          =  0x02,
		/// <summary>
		/// Portuguese (Brazilian)
		/// </summary>
		SUBLANG_PORTUGUESE_BRAZILIAN                =  0x01,
		/// <summary>
		/// Punjabi (India (Gurmukhi Script)) =  0x0446 pa-IN
		/// </summary>
		SUBLANG_PUNJABI_INDIA                       =  0x01,
		/// <summary>
		/// Quechua (Bolivia)
		/// </summary>
		SUBLANG_QUECHUA_BOLIVIA                     =  0x01,
		/// <summary>
		/// Quechua (Ecuador)
		/// </summary>
		SUBLANG_QUECHUA_ECUADOR                     =  0x02,
		/// <summary>
		/// Quechua (Peru)
		/// </summary>
		SUBLANG_QUECHUA_PERU                        =  0x03,
		/// <summary>
		/// Romanian (Romania) =  0x0418,
		/// </summary>
		SUBLANG_ROMANIAN_ROMANIA                    =  0x01,
		/// <summary>
		/// Romansh (Switzerland) =  0x0417 rm-CH
		/// </summary>
		SUBLANG_ROMANSH_SWITZERLAND                 =  0x01,
		/// <summary>
		/// Russian (Russia) =  0x0419,
		/// </summary>
		SUBLANG_RUSSIAN_RUSSIA                      =  0x01,
		/// <summary>
		/// Northern Sami (Norway)
		/// </summary>
		SUBLANG_SAMI_NORTHERN_NORWAY                =  0x01,
		/// <summary>
		/// Northern Sami (Sweden)
		/// </summary>
		SUBLANG_SAMI_NORTHERN_SWEDEN                =  0x02,
		/// <summary>
		/// Northern Sami (Finland)
		/// </summary>
		SUBLANG_SAMI_NORTHERN_FINLAND               =  0x03,
		/// <summary>
		/// Lule Sami (Norway)
		/// </summary>
		SUBLANG_SAMI_LULE_NORWAY                    =  0x04,
		/// <summary>
		/// Lule Sami (Sweden)
		/// </summary>
		SUBLANG_SAMI_LULE_SWEDEN                    =  0x05,
		/// <summary>
		/// Southern Sami (Norway)
		/// </summary>
		SUBLANG_SAMI_SOUTHERN_NORWAY                =  0x06,
		/// <summary>
		/// Southern Sami (Sweden)
		/// </summary>
		SUBLANG_SAMI_SOUTHERN_SWEDEN                =  0x07,
		/// <summary>
		/// Skolt Sami (Finland)
		/// </summary>
		SUBLANG_SAMI_SKOLT_FINLAND                  =  0x08,
		/// <summary>
		/// Inari Sami (Finland)
		/// </summary>
		SUBLANG_SAMI_INARI_FINLAND                  =  0x09,
		/// <summary>
		/// Sanskrit (India) =  0x044f sa-IN
		/// </summary>
		SUBLANG_SANSKRIT_INDIA                      =  0x01,
		/// <summary>
		/// Scottish Gaelic (United Kingdom) =  0x0491 gd-GB
		/// </summary>
		SUBLANG_SCOTTISH_GAELIC                     =  0x01,
		/// <summary>
		/// Serbian (Bosnia and Herzegovina - Latin)
		/// </summary>
		SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN    =  0x06,
		/// <summary>
		/// Serbian (Bosnia and Herzegovina - Cyrillic)
		/// </summary>
		SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC =  0x07,
		/// <summary>
		/// Serbian (Montenegro - Latn)
		/// </summary>
		SUBLANG_SERBIAN_MONTENEGRO_LATIN            =  0x0b ,
		/// <summary>
		/// Serbian (Montenegro - Cyrillic)
		/// </summary>
		SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC         =  0x0c,
		/// <summary>
		/// Serbian (Serbia - Latin)
		/// </summary>
		SUBLANG_SERBIAN_SERBIA_LATIN                =  0x09,
		/// <summary>
		/// Serbian (Serbia - Cyrillic)
		/// </summary>
		SUBLANG_SERBIAN_SERBIA_CYRILLIC             =  0x0a,
		/// <summary>
		/// Croatian (Croatia) =  0x041a hr-HR
		/// </summary>
		SUBLANG_SERBIAN_CROATIA                     =  0x01,
		/// <summary>
		/// Serbian (Latin)
		/// </summary>
		SUBLANG_SERBIAN_LATIN                       =  0x02,
		/// <summary>
		/// Serbian (Cyrillic)
		/// </summary>
		SUBLANG_SERBIAN_CYRILLIC                    =  0x03,
		/// <summary>
		/// Sindhi (India) reserved =  0x0459,
		/// </summary>
		SUBLANG_SINDHI_INDIA                        =  0x01,
		/// <summary>
		/// Sindhi (Pakistan) reserved =  0x0859,
		/// </summary>
		SUBLANG_SINDHI_PAKISTAN                     =  0x02,
		/// <summary>
		/// For app compatibility only
		/// </summary>
		SUBLANG_SINDHI_AFGHANISTAN                  =  0x02,
		/// <summary>
		/// Sinhalese (Sri Lanka)
		/// </summary>
		SUBLANG_SINHALESE_SRI_LANKA                 =  0x01,
		/// <summary>
		/// Northern Sotho (South Africa)
		/// </summary>
		SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA         =  0x01,
		/// <summary>
		/// Slovak (Slovakia) =  0x041b sk-SK
		/// </summary>
		SUBLANG_SLOVAK_SLOVAKIA                     =  0x01,
		/// <summary>
		/// Slovenian (Slovenia) =  0x0424 sl-SI
		/// </summary>
		SUBLANG_SLOVENIAN_SLOVENIA                  =  0x01,
		/// <summary>
		/// Spanish (Castilian)
		/// </summary>
		SUBLANG_SPANISH                             =  0x01,
		/// <summary>
		/// Spanish (Mexican)
		/// </summary>
		SUBLANG_SPANISH_MEXICAN                     =  0x02,
		/// <summary>
		/// Spanish (Modern)
		/// </summary>
		SUBLANG_SPANISH_MODERN                      =  0x03,
		/// <summary>
		/// Spanish (Guatemala)
		/// </summary>
		SUBLANG_SPANISH_GUATEMALA                   =  0x04,
		/// <summary>
		/// Spanish (Costa Rica)
		/// </summary>
		SUBLANG_SPANISH_COSTA_RICA                  =  0x05,
		/// <summary>
		/// Spanish (Panama)
		/// </summary>
		SUBLANG_SPANISH_PANAMA                      =  0x06,
		/// <summary>
		/// Spanish (Dominican Republic)
		/// </summary>
		SUBLANG_SPANISH_DOMINICAN_REPUBLIC          =  0x07,
		/// <summary>
		/// Spanish (Venezuela)
		/// </summary>
		SUBLANG_SPANISH_VENEZUELA                   =  0x08,
		/// <summary>
		/// Spanish (Colombia)
		/// </summary>
		SUBLANG_SPANISH_COLOMBIA                    =  0x09,
		/// <summary>
		/// Spanish (Peru)
		/// </summary>
		SUBLANG_SPANISH_PERU                        =  0x0a,
		/// <summary>
		/// Spanish (Argentina)
		/// </summary>
		SUBLANG_SPANISH_ARGENTINA                   =  0x0b,
		/// <summary>
		/// Spanish (Ecuador)
		/// </summary>
		SUBLANG_SPANISH_ECUADOR                     =  0x0c,
		/// <summary>
		/// Spanish (Chile)
		/// </summary>
		SUBLANG_SPANISH_CHILE                       =  0x0d,
		/// <summary>
		/// Spanish (Uruguay)
		/// </summary>
		SUBLANG_SPANISH_URUGUAY                     =  0x0e,
		/// <summary>
		/// Spanish (Paraguay)
		/// </summary>
		SUBLANG_SPANISH_PARAGUAY                    =  0x0f,
		/// <summary>
		/// Spanish (Bolivia)
		/// </summary>
		SUBLANG_SPANISH_BOLIVIA                     =  0x10,
		/// <summary>
		/// Spanish (El Salvador)
		/// </summary>
		SUBLANG_SPANISH_EL_SALVADOR                 =  0x11,
		/// <summary>
		/// Spanish (Honduras)
		/// </summary>
		SUBLANG_SPANISH_HONDURAS                    =  0x12,
		/// <summary>
		/// Spanish (Nicaragua)
		/// </summary>
		SUBLANG_SPANISH_NICARAGUA                   =  0x13,
		/// <summary>
		/// Spanish (Puerto Rico)
		/// </summary>
		SUBLANG_SPANISH_PUERTO_RICO                 =  0x14,
		/// <summary>
		/// Spanish (United States)
		/// </summary>
		SUBLANG_SPANISH_US                          =  0x15,
		/// <summary>
		/// Swahili (Kenya) =  0x0441 sw-KE
		/// </summary>
		SUBLANG_SWAHILI_KENYA                       =  0x01,
		/// <summary>
		/// Swedish
		/// </summary>
		SUBLANG_SWEDISH                             =  0x01,
		/// <summary>
		/// Swedish (Finland)
		/// </summary>
		SUBLANG_SWEDISH_FINLAND                     =  0x02,
		/// <summary>
		/// Syriac (Syria) =  0x045a syr-SY
		/// </summary>
		SUBLANG_SYRIAC_SYRIA                        =  0x01,
		/// <summary>
		/// Tajik (Tajikistan) =  0x0428 tg-TJ-Cyrl
		/// </summary>
		SUBLANG_TAJIK_TAJIKISTAN                    =  0x01,
		/// <summary>
		/// Tamazight (Latin, Algeria) =  0x085f tmz-DZ-Latn
		/// </summary>
		SUBLANG_TAMAZIGHT_ALGERIA_LATIN             =  0x02,
		/// <summary>
		/// Tamil (India)
		/// </summary>
		SUBLANG_TAMIL_INDIA                         =  0x01,
		/// <summary>
		/// Tatar (Russia) =  0x0444 tt-RU
		/// </summary>
		SUBLANG_TATAR_RUSSIA                        =  0x01,
		/// <summary>
		/// Telugu (India (Telugu Script)) =  0x044a te-IN
		/// </summary>
		SUBLANG_TELUGU_INDIA                        =  0x01,
		/// <summary>
		/// Thai (Thailand) =  0x041e th-TH
		/// </summary>
		SUBLANG_THAI_THAILAND                       =  0x01,
		/// <summary>
		/// Tibetan (PRC)
		/// </summary>
		SUBLANG_TIBETAN_PRC                         =  0x01,
		/// <summary>
		/// Tigrigna (Eritrea)
		/// </summary>
		SUBLANG_TIGRIGNA_ERITREA                    =  0x02,
		/// <summary>
		/// Setswana / Tswana (South Africa) =  0x0432 tn-ZA
		/// </summary>
		SUBLANG_TSWANA_SOUTH_AFRICA                 =  0x01,
		/// <summary>
		/// Turkish (Turkey) =  0x041f tr-TR
		/// </summary>
		SUBLANG_TURKISH_TURKEY                      =  0x01,
		/// <summary>
		/// Turkmen (Turkmenistan) =  0x0442 tk-TM
		/// </summary>
		SUBLANG_TURKMEN_TURKMENISTAN                =  0x01,
		/// <summary>
		/// Uighur (PRC) =  0x0480 ug-CN
		/// </summary>
		SUBLANG_UIGHUR_PRC                          =  0x01,
		/// <summary>
		/// Ukrainian (Ukraine) =  0x0422 uk-UA
		/// </summary>
		SUBLANG_UKRAINIAN_UKRAINE                   =  0x01,
		/// <summary>
		/// Upper Sorbian (Germany) =  0x042e wen-DE
		/// </summary>
		SUBLANG_UPPER_SORBIAN_GERMANY               =  0x01,
		/// <summary>
		/// Urdu (Pakistan)
		/// </summary>
		SUBLANG_URDU_PAKISTAN                       =  0x01,
		/// <summary>
		/// Urdu (India)
		/// </summary>
		SUBLANG_URDU_INDIA                          =  0x02,
		/// <summary>
		/// Uzbek (Latin)
		/// </summary>
		SUBLANG_UZBEK_LATIN                         =  0x01,
		/// <summary>
		/// Uzbek (Cyrillic)
		/// </summary>
		SUBLANG_UZBEK_CYRILLIC                      =  0x02,
		/// <summary>
		/// Vietnamese (Vietnam) =  0x042a vi-VN
		/// </summary>
		SUBLANG_VIETNAMESE_VIETNAM                  =  0x01,
		/// <summary>
		/// Welsh (United Kingdom) =  0x0452 cy-GB
		/// </summary>
		SUBLANG_WELSH_UNITED_KINGDOM                =  0x01,
		/// <summary>
		/// Wolof (Senegal)
		/// </summary>
		SUBLANG_WOLOF_SENEGAL                       =  0x01,
		/// <summary>
		/// isiXhosa / Xhosa (South Africa) =  0x0434 xh-ZA
		/// </summary>
		SUBLANG_XHOSA_SOUTH_AFRICA                  =  0x01,
		/// <summary>
		/// Yakut (Russia) =  0x0485 sah-RU
		/// </summary>
		SUBLANG_YAKUT_RUSSIA                        =  0x01,
		/// <summary>
		/// Yi (PRC)) =  0x0478,
		/// </summary>
		SUBLANG_YI_PRC                              =  0x01,
		/// <summary>
		/// Yoruba (Nigeria) 046a yo-NG
		/// </summary>
		SUBLANG_YORUBA_NIGERIA                      =  0x01,
		/// <summary>
		/// isiZulu / Zulu (South Africa) =  0x0435 zu-ZA
		/// </summary>
		SUBLANG_ZULU_SOUTH_AFRICA                   =  0x01
	    }
	# endregion
    }