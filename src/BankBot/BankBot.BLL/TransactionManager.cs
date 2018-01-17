///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.BLL
/// Class           :   OthersManager
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A business logic class for generating message to handle irrelivent incomming messages.
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
    public class TransactionManager
    {
        UserInfo userInfo;
        public TransactionManager(UserInfo vUserInfo)
        {
            userInfo = vUserInfo;
        }

        public string GetFiveTransaction()
        {
            string msg = string.Empty;

            //this logic for temporary. Must remove in future
            if (userInfo.UserFullName == "Mahedee Hasan")
            {

                msg = "Your account’s Last 5 Transection is as bellow " +
                    "<br/>Date.........Amount.......D / C: " +
                    "<br/>12/12/17.....1,500..........D " +
                    "<br/>07/12/17.....6,650..........C " +
                    "<br/>12/12/17.....8,570..........D " +
                    "<br/>19/12/17.....2,000..........C " +
                    "<br/>05/01/18.....5,700..........D ";

            }
            else if (userInfo.UserFullName == "Giash Uddin Sikder")
            {
                msg = "Your account’s Last 5 Transection is as bellow " +
                    "<br/>Date.........Amount...........D / C: " +
                    "<br/>12/12/17.....345,500............D " +
                    "<br/>14/12/17.....2,645,000..........C " +
                    "<br/>16/12/17.....128,940............D " +
                    "<br/>19/12/17.....2,125,000..........C " +
                    "<br/>05/01/18.....115,000............D ";
            }
            else if (userInfo.UserFullName == "Rahi Mozammel")
            {
                msg = "Your account’s Last 5 Transection is as bellow " +
                    "<br/>Date.........Amount......D / C: " +
                    "<br/>12/12/17.....500...........D " +
                    "<br/>01/01/18.....4500..........C " +
                    "<br/>04/01/18.....3170..........D " +
                    "<br/>08/01/18.....8000..........C " +
                    "<br/>15/01/18.....7700..........D ";
            }
            else
            {
                msg = "Sorry! You are not registered user.";
            }

            return msg;
        }
    }
}
