///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.Model
/// Class           :   UserInfo
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	Model to store user information
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBot.Model
{
    public class UserInfo
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public string MobileNo { get; set; }
        public string FacebookId { get; set; }
        public string FacebookFullName { get; set; }
        public int? FacebookOTP { get; set; }
        public string SkypeId { get; set; }
        public int? SkypeOTP { get; set; }
        public string SlackId { get; set; }
        public int? SlackOTP { get; set; }

        //OPT for web chat means chatting from web interface
        //Not sure how to maintain credintial from web interface, will fix later
        public int? WebOTP { get; set; }

    }
}
