using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublestartyre.Data
{
    public struct Account
    {
        public Int32 id; // account id
        public String number; // account number
        public String name; // account name
        public String password; // account password
        public Int32 permission; // account password and the values is defined in Constants
        public Int32 status; // account status and the values is defined in Constants
    }
}
