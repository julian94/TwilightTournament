using System.Threading.Tasks;

namespace Server.Pushing;

public class Discord : IUserNotifier
{
    public Task Notify(User user, Message message)
    {
        throw new System.NotImplementedException();
    }
}
