using System.Collections.Generic;

namespace NadekoBot.Modules.Searches.Models
{
    public class WarframeModel
    {
        public class Rootobject
        {
            public int Version { get; set; }
            public string BuildLabel { get; set; }
            public int Time { get; set; }
            public int Date { get; set; }
            public Event[] Events { get; set; }
            public object[] Goals { get; set; }
            public Alert[] Alerts { get; set; }
            public Sorty[] Sorties { get; set; }
            public Syndicatemission[] SyndicateMissions { get; set; }
            public Activemission[] ActiveMissions { get; set; }
            public object[] GlobalUpgrades { get; set; }
            public Flashsale[] FlashSales { get; set; }
            public Invasion[] Invasions { get; set; }
            public object[] HubEvents { get; set; }
            public Nodeoverride[] NodeOverrides { get; set; }
            public Badlandnode[] BadlandNodes { get; set; }
            public Voidtrader[] VoidTraders { get; set; }
            public Primeaccessavailability PrimeAccessAvailability { get; set; }
            public Primevaultavailability[] PrimeVaultAvailabilities { get; set; }
            public Dailydeal[] DailyDeals { get; set; }
            public Libraryinfo LibraryInfo { get; set; }
            public Pvpchallengeinstance[] PVPChallengeInstances { get; set; }
            public object[] PersistentEnemies { get; set; }
            public Pvpalternativemode[] PVPAlternativeModes { get; set; }
            public float[] ProjectPct { get; set; }
            public string WorldSeed { get; set; }
        }

        public class Primeaccessavailability
        {
            public string State { get; set; }
        }

        public class Libraryinfo
        {
            public string LastCompletedTargetType { get; set; }
        }

        public class Event
        {
            public _Id _id { get; set; }
            public Messages[] Messages { get; set; }
            public string Prop { get; set; }
            public Date Date { get; set; }
            public string ImageUrl { get; set; }
            public bool Priority { get; set; }
            public bool MobileOnly { get; set; }
            public Eventstartdate EventStartDate { get; set; }
        }

        public class _Id
        {
            public string id { get; set; }
        }

        public class Date
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Eventstartdate
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Messages
        {
            public string LanguageCode { get; set; }
            public string Message { get; set; }
        }

        public class Alert
        {
            public _Id1 _id { get; set; }
            public Activation Activation { get; set; }
            public Expiry Expiry { get; set; }
            public Missioninfo MissionInfo { get; set; }
        }

        public class _Id1
        {
            public string id { get; set; }
        }

        public class Activation
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Expiry
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Missioninfo
        {
            public string missionType { get; set; }
            public string faction { get; set; }
            public string location { get; set; }
            public string levelOverride { get; set; }
            public string enemySpec { get; set; }
            public int minEnemyLevel { get; set; }
            public int maxEnemyLevel { get; set; }
            public float difficulty { get; set; }
            public int seed { get; set; }
            public Missionreward missionReward { get; set; }
        }

        public class Missionreward
        {
            public int credits { get; set; }
            public string[] items { get; set; }
        }

        public class Sorty
        {
            public _Id2 _id { get; set; }
            public Activation1 Activation { get; set; }
            public Expiry1 Expiry { get; set; }
            public string Reward { get; set; }
            public object[] ExtraDrops { get; set; }
            public int Seed { get; set; }
            public Variant[] Variants { get; set; }
        }

        public class _Id2
        {
            public string id { get; set; }
        }

        public class Activation1
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Expiry1
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Variant
        {
            public int bossIndex { get; set; }
            public int regionIndex { get; set; }
            public int missionIndex { get; set; }
            public int modifierIndex { get; set; }
            public string node { get; set; }
            public string tileset { get; set; }
        }

        public class Syndicatemission
        {
            public _Id3 _id { get; set; }
            public Activation2 Activation { get; set; }
            public Expiry2 Expiry { get; set; }
            public string Tag { get; set; }
            public int Seed { get; set; }
            public string[] Nodes { get; set; }
        }

        public class _Id3
        {
            public string id { get; set; }
        }

        public class Activation2
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Expiry2
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Activemission
        {
            public _Id4 _id { get; set; }
            public int Region { get; set; }
            public int Seed { get; set; }
            public Activation3 Activation { get; set; }
            public Expiry3 Expiry { get; set; }
            public string Node { get; set; }
            public string Modifier { get; set; }
        }

        public class _Id4
        {
            public string id { get; set; }
        }

        public class Activation3
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Expiry3
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Flashsale
        {
            public string TypeName { get; set; }
            public Startdate StartDate { get; set; }
            public Enddate EndDate { get; set; }
            public bool Featured { get; set; }
            public bool Popular { get; set; }
            public int BannerIndex { get; set; }
            public int Discount { get; set; }
            public int RegularOverride { get; set; }
            public int PremiumOverride { get; set; }
            public int BogoBuy { get; set; }
            public int BogoGet { get; set; }
        }

        public class Startdate
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Enddate
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Invasion
        {
            public _Id5 _id { get; set; }
            public string Faction { get; set; }
            public string Node { get; set; }
            public int Count { get; set; }
            public int Goal { get; set; }
            public string LocTag { get; set; }
            public bool Completed { get; set; }
            public object AttackerReward { get; set; }
            public Attackermissioninfo AttackerMissionInfo { get; set; }
            public Defenderreward DefenderReward { get; set; }
            public Defendermissioninfo DefenderMissionInfo { get; set; }
            public Activation4 Activation { get; set; }
        }

        public class _Id5
        {
            public string id { get; set; }
        }

        public class Attackermissioninfo
        {
            public int seed { get; set; }
            public string faction { get; set; }
        }

        public class Defenderreward
        {
            public Counteditem[] countedItems { get; set; }
        }

        public class Counteditem
        {
            public string ItemType { get; set; }
            public int ItemCount { get; set; }
        }

        public class Defendermissioninfo
        {
            public int seed { get; set; }
            public string faction { get; set; }
            public object[] missionReward { get; set; }
        }

        public class Activation4
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Nodeoverride
        {
            public _Id6 _id { get; set; }
            public string Node { get; set; }
            public bool Hide { get; set; }
        }

        public class _Id6
        {
            public string id { get; set; }
        }

        public class Badlandnode
        {
            public _Id7 _id { get; set; }
            public Defenderinfo DefenderInfo { get; set; }
            public History[] History { get; set; }
            public string Node { get; set; }
            public Postconflictcooldown PostConflictCooldown { get; set; }
        }

        public class _Id7
        {
            public string id { get; set; }
        }

        public class Defenderinfo
        {
            public int CreditsTaxRate { get; set; }
            public int MemberCreditsTaxRate { get; set; }
            public int ItemsTaxRate { get; set; }
            public int MemberItemsTaxRate { get; set; }
            public Taxchangeallowedtime TaxChangeAllowedTime { get; set; }
            public bool IsAlliance { get; set; }
            public Id Id { get; set; }
            public string Name { get; set; }
            public int StrengthRemaining { get; set; }
            public int MaxStrength { get; set; }
            public Deploymentactivationtime DeploymentActivationTime { get; set; }
            public string RailType { get; set; }
            public string MOTD { get; set; }
            public string DeployerName { get; set; }
            public string DeployerClan { get; set; }
            public int RailHealReserve { get; set; }
            public float HealRate { get; set; }
            public int DamagePerMission { get; set; }
            public int BattlePayReserve { get; set; }
            public int MissionBattlePay { get; set; }
            public string BattlePaySetBy { get; set; }
            public string BattlePaySetByClan { get; set; }
            public string TaxLastChangedBy { get; set; }
            public string TaxLastChangedByClan { get; set; }
            public Railid RailId { get; set; }
        }

        public class Taxchangeallowedtime
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Id
        {
            public string id { get; set; }
        }

        public class Deploymentactivationtime
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Railid
        {
            public string id { get; set; }
        }

        public class Postconflictcooldown
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class History
        {
            public string Def { get; set; }
            public Defid DefId { get; set; }
            public bool DefAli { get; set; }
            public string Att { get; set; }
            public Attid AttId { get; set; }
            public bool AttAli { get; set; }
            public Winid WinId { get; set; }
            public Start Start { get; set; }
            public End End { get; set; }
        }

        public class Defid
        {
            public string id { get; set; }
        }

        public class Attid
        {
            public string id { get; set; }
        }

        public class Winid
        {
            public string id { get; set; }
        }

        public class Start
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class End
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Voidtrader
        {
            public _Id8 _id { get; set; }
            public Activation5 Activation { get; set; }
            public Expiry4 Expiry { get; set; }
            public string Character { get; set; }
            public string Node { get; set; }
        }

        public class _Id8
        {
            public string id { get; set; }
        }

        public class Activation5
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Expiry4
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Primevaultavailability
        {
            public string State { get; set; }
        }

        public class Dailydeal
        {
            public string StoreItem { get; set; }
            public Activation6 Activation { get; set; }
            public Expiry5 Expiry { get; set; }
            public int Discount { get; set; }
            public int OriginalPrice { get; set; }
            public int SalePrice { get; set; }
            public int AmountTotal { get; set; }
            public int AmountSold { get; set; }
        }

        public class Activation6
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Expiry5
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Pvpchallengeinstance
        {
            public _Id9 _id { get; set; }
            public string challengeTypeRefID { get; set; }
            public Startdate1 startDate { get; set; }
            public Enddate1 endDate { get; set; }
            public Param[] _params { get; set; }
            public bool isGenerated { get; set; }
            public string PVPMode { get; set; }
            public Subchallenge[] subChallenges { get; set; }
            public string Category { get; set; }
        }

        public class _Id9
        {
            public string id { get; set; }
        }

        public class Startdate1
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Enddate1
        {
            public int sec { get; set; }
            public int usec { get; set; }
        }

        public class Param
        {
            public string n { get; set; }
            public int v { get; set; }
        }

        public class Subchallenge
        {
            public string id { get; set; }
        }

        public class Pvpalternativemode
        {
            public string TargetMode { get; set; }
            public string TitleLoc { get; set; }
            public string DescriptionLoc { get; set; }
            public bool DisableEnergyPickups { get; set; }
            public bool DisableEnergySurge { get; set; }
            public bool DisableAmmoPickups { get; set; }
            public Forcedloadout[] ForcedLoadouts { get; set; }
        }

        public class Forcedloadout
        {
            public Weaponoverride[] WeaponOverrides { get; set; }
        }

        public class Weaponoverride
        {
            public bool Override { get; set; }
            public string Resource { get; set; }
            public string OriginalVersion { get; set; }
        }
    }
}
