using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBot.Model;
using System.Security.Authentication;

namespace BankBot.Security
{
    public class BotAuthentication
    {
        public async Task<UserInfo> GetValidUser(string fromId, string channelId)
        {
            UserInfo userInfo;
            userInfo = new UserInfo();

            if (channelId.Equals("facebook"))
            {
                //userInfo = await db.UserInfos.FirstOrDefaultAsync(p => p.FacebookId.Equals(fromId));
            }
            else if (channelId.Equals("skype"))
            {
                //userInfo = await db.UserInfos.FirstOrDefaultAsync(p => p.SkypeId.Equals(fromId));
            }
            else
            {
                throw new PlatformNotSupportedException("Chat channel is not supported");
            }

            if (userInfo == null) throw new AuthenticationException("Not verified");

            //var employee = await db.Employees.FirstOrDefaultAsync(p => p.UserId == userInfo.Id);
            //var leave = await db.LeaveBalances.FirstOrDefaultAsync(p => p.EmployeeId == employee.Id);

            //return leave;

            return userInfo;
        }
    }
}
