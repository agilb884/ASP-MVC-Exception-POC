using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Common
{
    interface IUser
    {
        string UserId { get; set; }
        string Password { get; set; }
        string Token { get; }
    }
}
