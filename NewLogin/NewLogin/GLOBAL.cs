using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLogin
{
    internal class GLOBAL
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userid)
        {
            GlobalUserId = userid;
        }
    }
}
