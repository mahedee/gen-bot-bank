///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.BLL
/// Class           :   AccountManager
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A business logic class for generating account related messages
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
    public class AccountManager
    {
        UserInfo userInfo;
        public AccountManager(UserInfo vUserInfo)
        {
            userInfo = vUserInfo;
        }
        public string GetAccountHolderInfo()
        {
            string msg = string.Empty;

            //this logic for temporary. Must remove in future
            if (userInfo.UserFullName == "Mahedee Hasan")
            {
                msg = "Your Account Name is: Md. Mahedee Hasan. " +
                    "<br/>Your Account Number: 962002433." +
                    "<br/>Account Opening Branch: Matijheel, Dhaka";
            }
            else if (userInfo.UserFullName == "Giash Uddin Sikder")
            {
                msg = "Your Account Name is: Giash Uddin Sikder. " +
                    "<br/>Your Account Number: 8876440098" +
                    "<br/>Account Opening Branch: Mohakhali, Dhaka";
            }
            else if (userInfo.UserFullName == "Rahi Mozammel")
            {
                msg = "Your Account Name is: Mozammel bin Motalab " +
                    "<br/>Your Account Number: 9620024335" +
                    "<br/>Account Opening Branch: Kakrail, Dhaka";
            }
            else
            {
                msg = "Sorry! You are not registered user.";
            }
            return msg;
        }
    }
}
