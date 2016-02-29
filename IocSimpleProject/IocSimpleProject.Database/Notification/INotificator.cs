using System.Threading.Tasks;

namespace IocSimpleProject.Database.Notification
{
    public interface INotificator
    {
        Task Notify(NotificationModel notification);
    }

    public class NotificationModel
    {
        public string Message { get; set; }
    }
}