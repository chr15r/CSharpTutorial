namespace Polymorphism
{
    public class SMSNotificationChannel : INotificationChannel
    {
        public void SendMessage(Message message)
        {
            System.Console.WriteLine("Sending SMS....");
        }
    }
}
