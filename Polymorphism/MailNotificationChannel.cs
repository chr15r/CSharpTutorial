namespace Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void SendMessage(Message message)
        {
            System.Console.WriteLine("Sending Mail....");
        }
    }
}
