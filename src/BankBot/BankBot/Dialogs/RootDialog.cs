using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankBot.Dialogs
{

    [LuisModel("da795aee-cdfd-42c5-ac03-fd3c96049346", "0ab97bdd3cfa46cfaa1e71e7ad6eb950", domain: "westus.api.cognitive.microsoft.com")]

    [Serializable]
    public partial class RootDialog : LuisDialog<object>
    //: IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            // return our reply to the user
            await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            context.Wait(MessageReceivedAsync);
        }

        //[LuisIntent("Greetings")]
        //public async Task Greetings(IDialogContext context, LuisResult result)
        //{
        //    List<String> messagePoll = new List<string>
        //    {
        //        "Hi",
        //        "Hello there",
        //        "Hello"
        //        //,
        //        //"Hello " + userData,
        //        //"Hi " + userData
        //    };

        //    string message = messagePoll.OrderBy(s => Guid.NewGuid()).First() + ". I am Digital Bank Assistant, How can I help you?";

        //    //string message = "Hi! I am Digital Bank Assistant, How can I help you!";
        //    await context.PostAsync(message);
        //    context.Wait(this.MessageReceived);
        //}
    }
}