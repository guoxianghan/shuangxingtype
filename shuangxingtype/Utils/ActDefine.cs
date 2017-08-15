using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublestartyre.utils
{
    class PlcUtils
    {
        public const String mNameProLine = "线体";
        //public const String mNameGirder = "桁架";
        public const String mNameGantry = "龙门";

        public static string mAddressGantry = System.Configuration.ConfigurationManager.AppSettings["gantry_address"];
        //public static string mAddressGirder = System.Configuration.ConfigurationManager.AppSettings["girder_address"];
        public static string mAddressProLine = System.Configuration.ConfigurationManager.AppSettings["production_address"];

        public const int mCpuTypeProLine = utils.ActDefine.CPU_L02CPU;
       // public const int mCpuTypeGirder = Utils.ActDefine.CPU_L02CPU;
        //public const int mCpuTypeGantry = Utils.ActDefine.CPU_L02CPU;

        public const int mUnitTypeProLine = utils.ActDefine.UNIT_LNETHER;
       // public const int mUnitTypeGirder = Utils.ActDefine.UNIT_LNETHER;
       // public const int mUnitTypeGantry = Utils.ActDefine.UNIT_LNETHER;

        public const int mProtocolType = utils.ActDefine.PROTOCOL_TCPIP;

        // For test in lab
        //public const String mAddressGirder = "192.168.1.10";
        //public const int mCpuTypeGirder = Utils.ActDefine.CPU_L02CPU;
        //public const int mUnitTypeGirder = Utils.ActDefine.UNIT_LNETHER;
    }
}
