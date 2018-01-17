///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.BLL
/// Class           :   GreetingsManager
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A business logic class for generating greeting related messages
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
    public class GreetingsManager
    {
        public string GetGreetingMessage(UserInfo userInfo)
        {
            string message = string.Empty;


            List<String> messagePoll = new List<string>
            {
                "Hi",
                "Hello there",
                "Hello",
                "Hello " + userInfo.UserFullName,
                "Hi " + userInfo.UserFullName
            };

            message = messagePoll.OrderBy(s => Guid.NewGuid()).First() + ". I am LIDA, LEADS Intelligent Digital Assistant. " +
                "How can I help you?";

            return message;
        }
    }
}
