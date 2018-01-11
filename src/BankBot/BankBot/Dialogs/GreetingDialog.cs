using BankBot.BLL;
using BankBot.Security;
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
        [LuisIntent("Greetings")]
        //[AuthorizeBot()] //not working here
        public async Task Greetings(IDialogContext context, LuisResult result)
        {
            string message = new GreetingsManager().GetGreetingMessage(userData);
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
    }
}