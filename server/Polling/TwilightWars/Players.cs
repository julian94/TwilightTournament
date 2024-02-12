using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Server.Polling.TwilightWars;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
public class AntiFighterBarrage
{
    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("rolls")]
    public int Rolls { get; set; }
}

public class Bombardment
{
    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("rolls")]
    public int Rolls { get; set; }
}

public class Combat
{
    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("rolls")]
    public int Rolls { get; set; }
}

public class Cost
{
    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("units")]
    public int Units { get; set; }
}

public class LastReadMessage
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("userId")]
    public string UserId { get; set; }

    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }
}

public class Law
{
    [JsonPropertyName("exhausted")]
    public bool Exhausted { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("isElection")]
    public bool IsElection { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("electionType")]
    public string ElectionType { get; set; }
}

public class PlanetCard
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("resources")]
    public int Resources { get; set; }

    [JsonPropertyName("influence")]
    public int Influence { get; set; }

    [JsonPropertyName("trait")]
    public string Trait { get; set; }

    [JsonPropertyName("tech")]
    public string Tech { get; set; }

    [JsonPropertyName("exhausted")]
    public bool Exhausted { get; set; }

    [JsonPropertyName("units")]
    public List<object> Units { get; set; }

    [JsonPropertyName("laws")]
    public List<object> Laws { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }
}

public class Prerequisites
{
    [JsonPropertyName("propulsion")]
    public int Propulsion { get; set; }

    [JsonPropertyName("cybernetic")]
    public int? Cybernetic { get; set; }

    [JsonPropertyName("warfare")]
    public int? Warfare { get; set; }

    [JsonPropertyName("biotic")]
    public int? Biotic { get; set; }
}

public class Production
{
    [JsonPropertyName("x")]
    public int X { get; set; }
}

public class Reinforcements
{
    [JsonPropertyName("commandTokens")]
    public int CommandTokens { get; set; }

    [JsonPropertyName("units")]
    public List<Unit> Units { get; set; }
}

public class RevealedSecretObjective
{
    [JsonPropertyName("canScorePlayerIds")]
    public List<object> CanScorePlayerIds { get; set; }

    [JsonPropertyName("revealed")]
    public bool Revealed { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("victoryPoints")]
    public int VictoryPoints { get; set; }

    [JsonPropertyName("scores")]
    public List<Score> Scores { get; set; }
}

public class PlayerFull
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("reinforcements")]
    public Reinforcements Reinforcements { get; set; }

    [JsonPropertyName("eliminated")]
    public bool Eliminated { get; set; }

    [JsonPropertyName("passed")]
    public bool Passed { get; set; }

    [JsonPropertyName("onSecondAction")]
    public bool OnSecondAction { get; set; }

    [JsonPropertyName("tradeGoods")]
    public int TradeGoods { get; set; }

    [JsonPropertyName("commodities")]
    public int Commodities { get; set; }

    [JsonPropertyName("fleetPool")]
    public int FleetPool { get; set; }

    [JsonPropertyName("strategyPool")]
    public int StrategyPool { get; set; }

    [JsonPropertyName("tacticPool")]
    public int TacticPool { get; set; }

    [JsonPropertyName("victoryPoints")]
    public int VictoryPoints { get; set; }

    [JsonPropertyName("hits")]
    public int Hits { get; set; }

    [JsonPropertyName("nonFighterHits")]
    public int NonFighterHits { get; set; }

    [JsonPropertyName("zombies")]
    public int Zombies { get; set; }

    [JsonPropertyName("alastorUnitIds")]
    public List<object> AlastorUnitIds { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("planetCards")]
    public List<PlanetCard> PlanetCards { get; set; }

    [JsonPropertyName("promissoryNotes")]
    public int PromissoryNotes { get; set; }

    [JsonPropertyName("startingUnits")]
    public List<object> StartingUnits { get; set; }

    [JsonPropertyName("technology")]
    public List<Technology> Technology { get; set; }

    [JsonPropertyName("technologyDeck")]
    public List<TechnologyDeck> TechnologyDeck { get; set; }

    [JsonPropertyName("game")]
    public string Game { get; set; }

    [JsonPropertyName("actionCards")]
    public int ActionCards { get; set; }

    [JsonPropertyName("enemyActionCards")]
    public int EnemyActionCards { get; set; }

    [JsonPropertyName("activeActionCards")]
    public List<object> ActiveActionCards { get; set; }

    [JsonPropertyName("secretObjectives")]
    public int SecretObjectives { get; set; }

    [JsonPropertyName("strategyCards")]
    public List<StrategyCard> StrategyCards { get; set; }

    [JsonPropertyName("results")]
    public List<object> Results { get; set; }

    [JsonPropertyName("laws")]
    public List<Law> Laws { get; set; }

    [JsonPropertyName("lastReadMessages")]
    public List<LastReadMessage> LastReadMessages { get; set; }

    [JsonPropertyName("__v")]
    public int V { get; set; }

    [JsonPropertyName("lastReadGroupMessageId")]
    public string LastReadGroupMessageId { get; set; }

    [JsonPropertyName("tradedPromissoryNote")]
    public bool TradedPromissoryNote { get; set; }

    [JsonPropertyName("revealedPromissoryNotes")]
    public List<object> RevealedPromissoryNotes { get; set; }

    [JsonPropertyName("revealedSecretObjectives")]
    public List<RevealedSecretObjective> RevealedSecretObjectives { get; set; }

    [JsonPropertyName("hasCustodiansToken")]
    public bool? HasCustodiansToken { get; set; }
}

public class SpaceCannon
{
    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("rolls")]
    public int Rolls { get; set; }
}

public class StrategyCard
{
    [JsonPropertyName("exhausted")]
    public bool Exhausted { get; set; }

    [JsonPropertyName("tradeGoods")]
    public int TradeGoods { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class SustainDamage
{
    [JsonPropertyName("used")]
    public bool Used { get; set; }

    [JsonPropertyName("thisRound")]
    public bool ThisRound { get; set; }
}

public class Technology
{
    [JsonPropertyName("exhausted")]
    public bool Exhausted { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("prerequisites")]
    public Prerequisites Prerequisites { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("ability")]
    public Ability Ability { get; set; }
}

public class TechnologyDeck
{
    [JsonPropertyName("exhausted")]
    public bool Exhausted { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("prerequisites")]
    public Prerequisites Prerequisites { get; set; }

    [JsonPropertyName("ability")]
    public Ability Ability { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }
}

public class Unit
{
    [JsonPropertyName("upgraded")]
    public bool Upgraded { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("cost")]
    public Cost Cost { get; set; }

    [JsonPropertyName("combat")]
    public Combat Combat { get; set; }

    [JsonPropertyName("move")]
    public int? Move { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("antiFighterBarrage")]
    public AntiFighterBarrage AntiFighterBarrage { get; set; }

    [JsonPropertyName("spaceCannon")]
    public SpaceCannon SpaceCannon { get; set; }

    [JsonPropertyName("planetaryShield")]
    public bool? PlanetaryShield { get; set; }

    [JsonPropertyName("production")]
    public Production Production { get; set; }

    [JsonPropertyName("bombardment")]
    public Bombardment Bombardment { get; set; }

    [JsonPropertyName("sustainDamage")]
    public SustainDamage SustainDamage { get; set; }
}

public class User
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("uploadedAvatar")]
    public bool UploadedAvatar { get; set; }

    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

