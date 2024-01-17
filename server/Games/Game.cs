using System.Collections.Generic;

namespace Server.Games;

public class Game
{
    public string ID { get; set; }
    public string Name { get; set; }
    public List<Player> Players { get; set; }
}
