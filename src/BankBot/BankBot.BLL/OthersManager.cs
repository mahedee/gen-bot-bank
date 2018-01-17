///	Copyright		:	Copyright© LEADSOFT 2018. All rights reserved.
///	NameSpace		:	BankBot.BLL
/// Class           :   OthersManager
/// Inherits        :   NA
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	A business logic class for generating message to handle irrelivent incomming messages.
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

namespace BankBot.BLL
{
    public class OthersManager
    {
        public string GetCommonMessage()
        {
            string msg = string.Empty;
            msg = "Sorry! I don't have answer. Please contact with customer manager.";
            return msg;
        }
    }
}
