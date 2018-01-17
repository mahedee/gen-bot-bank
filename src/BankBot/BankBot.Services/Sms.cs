///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	HRMBot.Services
/// Class           :   UserInfo
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	Send sms using some services
///	Creation Date	:	02/01/2018
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  1.     02-01-2018  Mahedee             1.0     Created
///	**************************************************************************************************
///	



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HRMBot.Services
{
    public class Sms : IMessageProvider
    {
        public async Task<bool> SendSMSAsync(string mobileNumber, string message)
        {
            const string apiUrl = "http://smsgateway.me/api/v3/messages/send";

            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //var email = Environment.GetEnvironmentVariable("APPSETTING_mymainemail");
                //var password = Environment.GetEnvironmentVariable("APPSETTING_smsgateway_password");
                //var device = Environment.GetEnvironmentVariable("APPSETTING_smsgateway_device");

                var email = "mahedee.hasan@gmail.com";
                var password = "test123";
                var device = "64911";


                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("email", email),
                    new KeyValuePair<string, string>("password", password),
                    new KeyValuePair<string, string>("device", device),
                    new KeyValuePair<string, string>("number", mobileNumber),
                    new KeyValuePair<string, string>("message", message)
                });

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                return response.IsSuccessStatusCode;
            }
        }
    }
}