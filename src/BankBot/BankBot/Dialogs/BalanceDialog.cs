using BankBot.BLL;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BankBot.Dialogs
{
    public partial class RootDialog
    {
        [LuisIntent("Balance")]
        public async Task GetCurrentBalance(IDialogContext context, LuisResult result)
        {
            //List<String> messagePoll = new List<string>
            //{
            //    "Your total balance is {0} ",
            //    "You current balance is {0}",
            //    "You have total {0} taka in your account"
            //};

            //string message = messagePoll.OrderBy(s => Guid.NewGuid()).First();
            //message = String.Format(message, "1003052");

            string message = new BalanceManager().GetCurrentBalance();
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
    }
}