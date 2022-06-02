using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkSolutions.ClassComponents
{
    public class clsConstants
    {
        public const string LOAD_WEBSITE = "jhnhnryjrmt.github.io";
        public const string MAINTAIN_STATUS_ACTIVE = "ACTIVE";
        public const string MAINTAIN_STATUS_INACTIVE = "IN-ACTIVE";
        public const string YES = "YES";
        public const string NO = "NO";
        public static bool NagFlag;
        public static string USERNAME { get; set; }

        public static string ACCESS { get; set; }

        public enum Form_Mode
        {
            Add,
            Update,
            ReadOnly
        }
    }
}
