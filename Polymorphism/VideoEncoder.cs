using System.Collections.Generic;

namespace Polymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
       
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            foreach (var n in _notificationChannels)
            {
                n.SendMessage(new Message());
            }            
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

    }
}
