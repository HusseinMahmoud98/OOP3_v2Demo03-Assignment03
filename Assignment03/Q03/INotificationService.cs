using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Q03
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);

    }
}
