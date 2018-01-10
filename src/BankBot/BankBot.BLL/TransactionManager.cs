using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.BLL
{
    public class TransactionManager
    {
        public string GetFiveTransaction()
        {
            string msg = string.Empty;
            msg = "Your account’s Last 5 Transection is as bellow Date: Amount: D / C: 12 / 12 / 17   5000 / -D 12 / 01 / 18  5000 / -C 12 / 02 / 18  5000 / -D 12 / 04 / 18  5000 / -C 12 / 06 / 18  5000 / -D";
            return msg;
        }
    }
}
