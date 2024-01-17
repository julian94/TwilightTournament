using System.Threading.Tasks;

namespace Server.Pushing;

public interface IUserNotifier
{
    public Task Notify(User user, Message message);
}
