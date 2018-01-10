using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.BLL
{
    public class OthersManager
    {
        public string GetCommonMessage()
        {
            string msg = string.Empty;
            msg = "Sorry! I don't have answer. Please contact with customer manager.";
            return msg;
        }
    }
}
