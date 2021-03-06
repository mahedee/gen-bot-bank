﻿///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.Dialogs
/// Class           :   RootDialog
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A partial class of RootDialog. Actually main class to handle incomming message for corresponding luis intend
///	Creation Date	:	02/01/2018
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  1.     02-01-2018  Mahedee             1.0     Created
///	**************************************************************************************************
///	
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
        private string userData;

        public RootDialog(string userData)
        {
            this.userData = userData;
        }

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

    }
}