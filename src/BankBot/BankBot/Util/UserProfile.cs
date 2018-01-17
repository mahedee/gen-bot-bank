///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.Util
/// Class           :   UserProfile
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	To set user information from dialog context
///	Creation Date	:	17/01/2018
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  1.     17-01-2018  Mahedee             1.0     Created
///	**************************************************************************************************
///	

using BankBot.Model;
using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankBot.Util
{
    public class UserProfile
    {
        public UserInfo GetUserInfo(IDialogContext context)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserFullName = context.Activity.From.Name;

            if (context.Activity.ChannelId == "Facebook")
            {
                userInfo.FacebookId = context.Activity.From.Id;
                userInfo.FacebookFullName = context.Activity.From.Name;
            }

            return userInfo;
        }
    }
}