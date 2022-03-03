using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brudnopis
{
    interface INotification {
        public void Send(string text);
    }
    class SmsSender : INotification {
        public void Send(string text){
            //sending sms
        } }
    class EmailSender : INotification {
        public void Send(string text)
        {
            //senind email
        } }
    class DependecyInjection
    {
        INotification notification = null;
        public void Notification1(INotification notification_param)
        {
            notification_param.Send("hello world");
        }
        public DependecyInjection(INotification notification)
        {
            this.notification = notification;
        }
        

        public INotification Notification
        {
            set { notification = value; }
        }
        public void SendSomething()
        {
            notification.Send("hello world");
        }
        
        //static void Main(string[] args)
        //{
        //    SmsSender smss = new SmsSender();
        //    EmailSender ems = new EmailSender();
        //    //depend what implementation you want 
        //    DependecyInjection di = new DependecyInjection(smss);
        //    //DependecyInjection di = new DependecyInjection(ems);
        //}
    }

    
}
