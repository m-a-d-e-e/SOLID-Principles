using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_D_Lib
{
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }


    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification(IMessenger pMessenger)
        {
            _iMessenger = pMessenger;
        }
        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }
}
