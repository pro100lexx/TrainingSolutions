using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsMonitor
{
    public class AccountsDBclass
    {
        public string Path { get; set; }
        public string OwnerName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountBalance { get; set; }
        public int EURUSD { get; set; }
        public int GBPUSD { get; set; }
        public int GBPGPY { get; set; }
        public int USDCAD { get; set; }
        public int AUDUSD { get; set; }

        public AccountsDBclass()
        {

        }
    }
}
