///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.BLL
/// Class           :   BalanceManager
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A business logic class for generating balance related messages
///	Creation Date	:	02/01/2018
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  1.     02-01-2018  Mahedee             1.0     Created
///	**************************************************************************************************
///	

using BankBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.BLL
{
    public class BalanceManager
    {
        UserInfo userInfo;
        public BalanceManager(UserInfo vUserInfo)
        {
            userInfo = vUserInfo;
        }

        public string GetCurrentBalance()
        {
            string msg = string.Empty;

            List<String> messagePoll = new List<string>
            {
                "Your total balance is {0} BDT {1} USD",
                "You current balance is {0} BDT {1} USD",
                "You have total {0} BDT {1} USD in your account"
            };

            msg = messagePoll.OrderBy(s => Guid.NewGuid()).First();

            //this logic for temporary. Must remove in future
            if (userInfo.UserFullName == "Mahedee Hasan")
            {
                msg = String.Format(msg, "1003052", "000");
            }
            else if (userInfo.UserFullName == "Giash Uddin Sikder")
            {
                msg = String.Format(msg, "727,754", "430");
            }
            else if (userInfo.UserFullName == "Rahi Mozammel")
            {
                msg = String.Format(msg, "455,678", "000");
            }
            else
            {
                msg = "Sorry! You are not registered user.";
            }


            
            
            return msg;
        }
    }
}
