using System.Threading.Tasks;

namespace Server.Pushing;

public interface IAnnouncer
{
    public Task Announce(Message message);
}
