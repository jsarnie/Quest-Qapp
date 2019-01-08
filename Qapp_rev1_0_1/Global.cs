using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qapp_rev1_0_1
{
    static class Global {

        // Global Variables
        private static int _maxIN = 199;
        private static int _minIn = 16;
        private static int _curIn = 16;
        private static int _maxOut = 16;
        private static DateTime _date = Convert.ToDateTime("01/01/17");
        private static string _dFormat = DateTime.Now.ToString("MM/dd/yy");
        private static DateTime _now = Convert.ToDateTime(DFormat);
        private static double _revName = 1.0;
        private static int _revID = 0;
        private static string _fileName = ".txt";
        private static string _tmpFile = "tmpQappPro.txt";
        private static string _tmpFolder = "QappTmp";
        private static string _tmpPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string _addLine = "insert new line";

        // UIB and CIM count
        private static System.Object[] _esbCount = new System.Object[8];
        public static System.Object[] ESBCount { get { return _esbCount; } set { _esbCount = value; } }

        private static System.Object[] _rmwmCount = new System.Object[6];
        public static System.Object[] RMWMCount { get { return _rmwmCount; } set { _rmwmCount = value; } }

        // testing window
        private static List<string> _windowBox = new string[512].ToList();
        public static List<string> WindowBox { get { return _windowBox; } set { _windowBox = value; } }

        // temp window
        private static List<string> _windowBoxTemp = new string[512].ToList();
        public static List<string> WindowBoxTemp { get { return _windowBoxTemp; } set { _windowBoxTemp = value; } }

        private static List<int> _uinTotal = new int[15].ToList();
        public static List<int> UINTot { get { return _uinTotal; } set { _uinTotal = value; } }

        // Customer ID and Abbreviations
        private static string _custID = "custID";
        private static string _abbrvCharter = "CHRTR";
        private static string _abbrvComcast = "COMCAST";

        // Location ID
        private static string _siteID = "siteID";
        private static string _addrID = "Address";
        private static string _cityID = "cityID";
        private static string _stateID = "ID";

        // TELSEC ID
        private static string _telsecID = "TELSEC";
        private static string _esbID = "ESB";
        private static string _rmwmID = "RMWM";
        private static int _uib = 0;
        private static int _cim = 1;

        // Author ID
        private static string _authID = "ID";

        // Message ID
        private static string _id1message = "something went horribly wrong...";
        private static string _id2message = "something went horribly wrong...";
        private static string _id3message = "something went horribly wrong...";
        private static string _esbHeader = "something went horribly wrong...";
        private static string _uinmessage = "something went horribly wrong...";
        private static string _msgmessage = "something went horribly wrong...";
        private static string _spare = "DEFINE SPARE = " + Uin + UinCount + " MV 0 NOT LOG";
        private static string _define = "DEFINE";
        private static string _type = "TYPE";
        private static string _nonc = "INVDIG";
        private static string _temp = "TEMP";
        private static string _tempType = "THERMF";
        private static string _uin = "UIN.";
        private static string _msg = "MSG.";
        private static string _spt = "SPT";
        private static string _var = "VAR";
        private static string _invdig = "INVDIG";
        private static string _digital = "DIGITAL";
        private static string _cr = "CR";
        private static string _mj = "MJ";
        private static string _mn = "MN";
        private static string _in = "IN";
        private static string _log = "LOG";
        private static string _avg = "NOT AVG";

        // SCALES 
        private static string _humidScale = "SET SCALE 1 -25 349 'RH%'";
        private static string _lightScale = "SET SCALE 2 0 300 'FC'";
        private static string _fuelScale = "SET SCALE 3" + MinGal + " " + MaxGal + "'GAL'";
        private static string _minGal = "0";
        private static string _maxGal = "9999";

        // EQUATIONS
        private static string _tempEqu = "DEFINE  TEMPALM" + TempCount + " = EQU." + TempCount + "\n" +
                             "IF EQU." + TempCount + " < 3 AND(UIN" + UinCount + " > SPT.1) FOR  03:00 \n" +
                             "THEN RETURN 3, ALARM UIN." + UinCount + "CR\n" +
                             "ELSE\n" +
                             "IF EQU." + TempCount + " < 2 AND(UIN" + UinCount + " > SPT.2 AND UIN." + UinCount + " < SPT.1) FOR  03:00\n" +
                             "THEN RETURN 2, ALARM UIN." + UinCount + " MJ \n" +
                             "ELSE\n" +
                             "IF EQU." + TempCount + " < 1 AND UIN." + UinCount + " < SPT.3 FOR  03:00\n" +
                             "THEN RETURN 1 , ALARM UIN." + UinCount + " MN\n" +
                             "ELSE\n" +
                             "IF EQU." + TempCount + " > 0 AND(UIN." + UinCount + " < SPT.2 - 2 AND UIN." + UinCount + " > SPT.3 + 2) FOR 05:00\n" +
                             "THEN RETURN 0, ALARM UIN." + UinCount + " CLEAR\n";

        // MESSAGES
        private static string _tempMsg = Define + " " + "TEMP" + UinCount + " = MSG." + UinCount + " 'ZONE " + UinCount + " TEMPERATURE OUT OF RANGE'";

        // Counters
        private static int _uinCount = 1;
        private static int _tempCount = 1;
        private static int _humidCount = 1;
        private static int _hvacCount = 1;
        private static int _doorCount = 1;
        private static int _smokeCount = 1;
        private static int _fireCount = 1;
        private static int _atsCount = 1;
        private static int _genCount = 1;
        private static int _commCount = 1;
        private static int _upsCount = 1;
        private static int _rectCount = 1;
        private static int _hydroCount = 1;
        private static int _fuseCount = 1;
        private static int _tvssCount = 1;
        private static int _invertCount = 1;
        private static int _waterCount = 1;
        private static int _bdfbCount = 1;
        private static int _count = 1;

        // Getters and Setters
        public static int MaxIN { get { return _maxIN; } set { _maxIN = value; } }
        public static int MinIn { get { return _minIn; } set { _minIn = value; } }
        public static int CurIn { get { return _curIn; } set { _curIn = value; } }
        public static int MaxOut { get { return _maxOut; } set { _maxOut = value; } }
        public static double RevName { get { return _revName; } set { _revName = value; } }
        public static int RevID { get { return _revID; } set { _revID = value; } }
        public static DateTime Date { get { return _date; } set { _date = value; } }
        public static string DFormat { get { return _dFormat; } set { _dFormat = value; } }
        public static DateTime DateNow { get { return _now; } set { _now = value; } }
        public static int UIB { get { return _uib; } set { _uib = value; } }
        public static int CIM { get { return _cim; } set { _cim = value; } }

        public static string FileName { get { return _fileName; } set { _fileName = value; } }
        public static string TmpFile { get { return _tmpFile; } set { _tmpFile = value; } }
        public static string TmpFolder { get { return _tmpFolder; } set { _tmpFolder = value; } }
        public static string TmpPath { get { return _tmpPath; } set { _tmpPath = value; } }
        public static string AddLine { get { return _addLine; } set { _addLine = value; } }
        public static string CustID { get { return _custID; } set { _custID = value; } }
        public static string AbbrvCharter { get { return _abbrvCharter; } set { _abbrvCharter = value; } }
        public static string AbbrvComcast { get { return _abbrvComcast; } set { _abbrvComcast = value; } }
        public static string SiteID { get { return _siteID; } set { _siteID = value; } }
        public static string AddrID { get { return _addrID; } set { _addrID = value; } }
        public static string CityID { get { return _cityID; } set { _cityID = value; } }
        public static string StateID { get { return _stateID; } set { _stateID = value; } }
        public static string TelsecID { get { return _telsecID; } set { _telsecID = value; } }
        public static string EsbID { get { return _esbID; } set { _esbID = value; } }
        public static string RmwmID { get { return _rmwmID; } set { _rmwmID = value; } }
        public static string AuthID { get { return _authID; } set { _authID = value; } }

        // Message Getters and Setters
        public static string ID1Message { get { return _id1message; } set { _id1message = value; } }
        public static string ID2Message { get { return _id2message; } set { _id2message = value; } }
        public static string ID3Message { get { return _id3message; } set { _id3message = value; } }
        public static string ESBHeader { get { return _esbHeader; } set { _esbHeader = value; } }
        public static string UinMessage { get { return _uinmessage; } set { _uinmessage = value; } }
        public static string MsgMessage { get { return _msgmessage; } set { _msgmessage = value; } }
        public static string Spare { get { return _spare; } set { _spare = value; } }
        public static string Define { get { return _define; } set { _define = value; } }
        public static string UinType { get { return _type; } set { _type = value; } }
        public static string NONCType { get { return _nonc; } set { _nonc = value; } }
        public static string Temp { get { return _temp; } set { _temp = value; } }
        public static string TempType { get { return _tempType; } set { _tempType = value; } }
        public static string Uin { get { return _uin; } set { _uin = value; } }
        public static string Msg { get { return _msg; } set { _msg = value; } }
        public static string Spt { get { return _spt; } set { _spt = value; } }
        public static string Var { get { return _var; } set { _var = value; } }
        public static string Invdig { get { return _invdig; } set { _invdig = value; } }
        public static string Digital { get { return _digital; } set { _digital = value; } }
        public static string Cr { get { return _cr; } set { _cr = value; } }
        public static string Mj { get { return _mj; } set { _mj = value; } }
        public static string Mn { get { return _mn; } set { _mn = value; } }
        public static string In { get { return _in; } set { _in = value; } }
        public static string Log { get { return _log; } set { _log = value; } }
        public static string Avg { get { return _avg; } set { _avg = value; } }

        // SCALE Getters and Setters 
        public static string LightScale { get { return _lightScale; } set { _lightScale = value; } }
        public static string HumidScale { get { return _humidScale; } set { _humidScale = value; } }
        public static string FuelScale { get { return _fuelScale; } set { _fuelScale = value; } }
        public static string MinGal { get { return _minGal; } set { _minGal = value; } }
        public static string MaxGal { get { return _maxGal; } set { _maxGal = value; } }

        // EQUATIONS Getters and Setters
        public static string TempEqu { get { return _tempEqu; } set { _tempEqu = value; } }

        // MESSAGES Getters and Setters
        public static string TempMsg { get { return _tempMsg; } set { _tempMsg = value; } }

        // Counter Getters and Setters
        public static int UinCount { get { return _uinCount; } set { _uinCount = value; } }
        public static int TempCount { get { return _tempCount; } set { _tempCount = value; } }
        public static int HumidCount { get { return _humidCount; } set { _humidCount = value; } }
        public static int HvacCount { get { return _hvacCount; } set { _hvacCount = value; } }
        public static int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
        public static int SmokeCount { get { return _smokeCount; } set { _smokeCount = value; } }
        public static int FireCount { get { return _fireCount; } set { _fireCount = value; } }
        public static int AtsCount { get { return _atsCount; } set { _atsCount = value; } }
        public static int GenCount { get { return _genCount; } set { _genCount = value; } }
        public static int CommCount { get { return _commCount; } set { _commCount = value; } }
        public static int UpsCount { get { return _upsCount; } set { _upsCount = value; } }
        public static int RectCount { get { return _rectCount; } set { _rectCount = value; } }
        public static int HydroCount { get { return _hydroCount; } set { _hydroCount = value; } }
        public static int FuseCount { get { return _fuseCount; } set { _fuseCount = value; } }
        public static int TvssCount { get { return _tvssCount; } set { _tvssCount = value; } }
        public static int InvertCount { get { return _invertCount; } set { _invertCount = value; } }
        public static int WaterCount { get { return _waterCount; } set { _waterCount = value; } }
        public static int BdfbCount { get { return _bdfbCount; } set { _bdfbCount = value; } }
        public static int Count { get { return _count; } set { _count = value; } }

    }
}
