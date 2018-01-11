using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.BLL
{
    public class AccountManager
    {
        public string GetAccountHolderInfo()
        {
            string msg = string.Empty;
            msg = "Your Account Name is: Md. Mahedee Hasan. " +
                "<br/>Your Account Number: 962002433." +
                "<br/>Account Opening Branch: Matijheel, Dhaka";
            return msg;
        }
    }
}
