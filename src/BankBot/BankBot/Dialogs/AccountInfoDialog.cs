///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.Dialogs
/// Class           :   RootDialog
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A partial class of RootDialog to handle account information
///	Creation Date	:	02/01/2018
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  1.     02-01-2018  Mahedee             1.0     Created
///	**************************************************************************************************

using BankBot.BLL;
using BankBot.Model;
using BankBot.Util;
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
            UserProfile userProfile = new UserProfile();
            UserInfo userInfo = userProfile.GetUserInfo(context);

            AccountManager accountManager = new AccountManager(userInfo);
            string message = accountManager.GetAccountHolderInfo();

            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
    }
}