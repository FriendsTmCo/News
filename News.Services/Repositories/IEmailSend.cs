using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Services.Repositories
{
    public interface IEmailSend
    {
        Task Sendsms(string email, string subjet, string message, bool ishtml = false);
    }
}
