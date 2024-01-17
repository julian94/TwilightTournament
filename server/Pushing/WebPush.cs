using System.Threading.Tasks;

namespace Server.Pushing;

public class WebPush : IUserNotifier
{
    public Task Notify(User user, Message message)
    {
        throw new System.NotImplementedException();
    }
}
