using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Common
{
    interface IAuthenticateUser
    {
        bool IsValid(IUser user);
    }
}
