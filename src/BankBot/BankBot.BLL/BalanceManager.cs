using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.BLL
{
    public class BalanceManager
    {
        public string GetCurrentBalance()
        {
            string msg = string.Empty;

            List<String> messagePoll = new List<string>
            {
                "Your total balance is {0} BDT",
                "You current balance is {0} BDT",
                "You have total {0} BDT in your account"
            };

            msg = messagePoll.OrderBy(s => Guid.NewGuid()).First();
            msg = String.Format(msg, "1003052");
            
            return msg;
        }
    }
}
