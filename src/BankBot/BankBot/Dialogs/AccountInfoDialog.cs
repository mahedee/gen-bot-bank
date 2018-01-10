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
        [LuisIntent("AccountInfo")]
        public async Task GetAccountInfo(IDialogContext context, LuisResult result)
        {
            AccountManager accountManager = new AccountManager();
            string message = accountManager.GetAccountHolderInfo();

            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
    }
}