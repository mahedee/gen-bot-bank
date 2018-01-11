using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.BLL
{
    public class GreetingsManager
    {
        public string GetGreetingMessage(string userName)
        {
            string message = string.Empty;


            List<String> messagePoll = new List<string>
            {
                "Hi",
                "Hello there",
                "Hello",
                "Hello " + userName,
                "Hi " + userName
            };

            message = messagePoll.OrderBy(s => Guid.NewGuid()).First() + ". I am LIDA, LEADS Intelligent Digital Assistant. " +
                "How can I help you?";

            return message;
        }
    }
}
