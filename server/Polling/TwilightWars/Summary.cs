using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Server.Polling.TwilightWars;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
public class Ability
{
    public bool Used { get; set; }
    public bool DelayedEffect { get; set; }

    [JsonPropertyName("_id")]
    public string ID { get; set; }
    public bool IsComponentAction { get; set; }
    public string Step { get; set; }
    public string Timing { get; set; }
}

public class AbilityRound
{
    public bool InProgress { get; set; }
    public List<object> Passed { get; set; }
    public List<PlayedActionCard> PlayedActionCards { get; set; }
    public int Current { get; set; }
    public int Previous { get; set; }
}

public class ActionCards
{
    public List<Discard> Discard { get; set; }
}

public class Agendas
{
    public List<object> Discard { get; set; }
}

public class Discard
{
    [JsonPropertyName("_id")]
    public string ID { get; set; }
    public string Name { get; set; }
    public Ability Ability { get; set; }
    public string Type { get; set; }
}

public class FrontierCards
{
    public List<Discard> Discard { get; set; }
}

public class PlayedActionCard
{
    [JsonPropertyName("_id")]
    public string ID { get; set; }
    public string Name { get; set; }
    public string PlayerId { get; set; }
}

public class Player
{
    public int Current { get; set; }
    public int Previous { get; set; }
    public int Active { get; set; }
}

public class PublicObjective
{
    public List<object> CanScorePlayerIds { get; set; }
    public bool Revealed { get; set; }
    public string ID { get; set; }
    public string Name { get; set; }
    public int Stage { get; set; }
    public string Type { get; set; }
    public string Phase { get; set; }
    public int VictoryPoints { get; set; }
    public List<Score> Scores { get; set; }
}

public class Summary
{
    [JsonPropertyName("_id")]
    public string ID { get; set; }
    public AbilityRound AbilityRound { get; set; }
    public Turn Turn { get; set; }
    public bool IsPublic { get; set; }
    public bool UsePok { get; set; }
    public List<object> ControlledPlanets { get; set; }
    public List<object> InvadedPlanets { get; set; }
    public List<object> CombatDestroyedShipTypes { get; set; }
    public List<object> CombatParticipants { get; set; }
    public bool CustodiansTokenRemoved { get; set; }
    public string Phase { get; set; }
    public int Round { get; set; }
    public string Step { get; set; }
    public List<object> TradePlayers { get; set; }
    public List<object> Transactions { get; set; }
    public int VictoryPoints { get; set; }
    public bool Over { get; set; }
    public bool CanUndoLastAction { get; set; }
    public List<string> ImperialScores { get; set; }
    public string Name { get; set; }
    public string Mode { get; set; }
    public string PresetMap { get; set; }
    public int NumberOfPlayers { get; set; }
    public List<PublicObjective> PublicObjectives { get; set; }
    public List<object> StrategyCards { get; set; }
    public ActionCards ActionCards { get; set; }
    public Agendas Agendas { get; set; }
    public FrontierCards FrontierCards { get; set; }
    public string AppVersion { get; set; }
    public List<object> AbilityRoundQueue { get; set; }
    public List<object> Laws { get; set; }
    public List<object> SubStepQueue { get; set; }
    public int Speaker { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }

    [JsonPropertyName("__v")]
    public int VersionPerhaps { get; set; }
    public string LastPlayedActionCardId { get; set; }
    public string Timing { get; set; }
}

public class Score
{
    [JsonPropertyName("_id")]
    public string ID { get; set; }
    public string PlayerId { get; set; }
    public int Round { get; set; }
    public string Phase { get; set; }
}

public class Turn
{
    public Player Player { get; set; }
    public string Direction { get; set; }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
