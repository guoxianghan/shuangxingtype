using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublestartyre.Utils
{
    public static class Constants
    {
        // The values for account permission
        public static Int32 ACCOUNT_PERMISSION_ADMINISTRATOR = 1;
        public static Int32 ACCOUNT_PERMISSION_NORMAL = 2;

        // The values for account status
        public static Int32 ACCOUNT_STATUS_LOGIN = 1;
        public static Int32 ACCOUNT_STATUS_LOGOUT = 0;

        //动均检测结果常量定义， 1=检测合格，2=检测合格
        public const int DJResultOK1 = 1;
        public const int DJResultOK2 = 2;
    }
}
