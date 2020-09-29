using  TransportLayer.Models;

namespace TransportLayer.Models
{
    public class BindingNotification
    {
        public Notifications Notification { get; set; }
        public int IsRead { get; set; }
    }
}