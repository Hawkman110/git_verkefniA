using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //Give all Items,Quests,Monsters and Locations an ID      
        //Item ID's
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_IRON_SWORD = 2;
        public const int ITEM_ID_RAT_TAIL = 3;
        public const int ITEM_ID_PIECE_OF_FUR = 4;
        public const int ITEM_ID_SNAKE_FANG = 5;
        public const int ITEM_ID_SNAKESKIN = 6;
        public const int ITEM_ID_CLUB = 7;
        public const int ITEM_ID_HEALING_POTION = 8;
        public const int ITEM_ID_EXPERIMENTAL_POTION = 9;
        public const int ITEM_ID_SPIDER_FANG = 10;
        public const int ITEM_ID_SPIDER_SILK = 11;
        public const int ITEM_ID_ADVENTURER_PASS = 12;
        public const int ITEM_ID_SKULL = 13;
        public const int ITEM_ID_BONES = 14;
        public const int ITEM_ID_GOBLIN_EYE = 15;
        public const int ITEM_ID_GOBLIN_SKIN = 16;
        public const int ITEM_ID_LICH_DUST = 17;
        public const int ITEM_ID_LICH_HEARTSONE = 18;
        public const int ITEM_ID_THRONEROOM_KEY = 19;
        public const int ITEM_ID_RUSTY_GATE_KEY = 20;
        public const int ITEM_ID_FAMILY_HEIRLOOM = 21;
        public const int ITEM_ID_LICH_CROWN = 22;
        public const int ITEM_ID_FLAMING_SWORD = 23;
        public const int ITEM_ID_WHEREGOAT_FUR = 24;
        public const int ITEM_ID_WHEREGOAT_HORN = 25;

        //Monster ID's
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_SKELLATON = 4;
        public const int MONSTER_ID_GOBLIN = 5;
        public const int MONSTER_ID_WHEREGOAT = 6;
        public const int MONSTER_ID_LICH = 7;
        public const int MONSTER_ID_LICH_KING = 8;

        //Quest ID's
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_CLEAR_MYSTIC_TEMPLE = 3;
        public const int QUEST_ID_CLEAR_DARK_CAVE = 4;
        public const int QUEST_ID_CLEAR_SKELLATON_TOMS_FARM = 5;
        public const int QUEST_ID_FETCH_FAMILY_HEIRLOOM = 6;
        public const int QUEST_ID_FETCH_LITCH_HEARTSTONES = 7;
        public const int QUEST_ID_KILL_LICH_KING = 8;

        //Location ID's
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_Dead_Forest = 10;
        public const int LOCATION_ID_Broken_Bridge = 11;
        public const int LOCATION_ID_Mystic_Temple_Yard = 12;
        public const int LOCATION_ID_Mystic_Temple = 13;
        public const int LOCATION_ID_SWAMP = 14;
        public const int LOCATION_ID_DARK_CAVE = 15;
        public const int LOCATION_ID_DARK_NARROW_ROAD = 16;
        public const int LOCATION_ID_OLD_CABIN = 17;
        public const int LOCATION_ID_ANCIENT_TOMB_YARD = 18;
        public const int LOCATION_ID_ANCIENT_TOMB_HALLWAY = 19;
        public const int LOCATION_ID_ANCIENT_TOMB_THRONEROOM_DOOR = 20;
        public const int LOCATION_ID_ANCIENT_TOMB_THRONEROOM = 21;
        public const int LOCATION_ID_SKELLATON_TOMS_FARMHOUSE = 22;
        public const int LOCATION_ID_SKELLATON_TOMS_FARM = 23;



        //Other
        public const int UNSELLABLE_ITEM_PRICE = -1;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        //Creating the Items
        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5, 5));
            Items.Add(new Weapon(ITEM_ID_IRON_SWORD, "Iron sword", "Iron swords", 0, 7, 10));
            Items.Add(new Weapon(ITEM_ID_FLAMING_SWORD, "Flaming sword", "Flaming swords", 1, 12, 20));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 1));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 1));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 1));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 2));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10, 8));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 3));
            Items.Add(new HealingPotion(ITEM_ID_EXPERIMENTAL_POTION, "Experimental potion", "Experimental potion's", 10, 8));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 2));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 5));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_RUSTY_GATE_KEY, "Rusty gate key", "Rusty gate keys", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_THRONEROOM_KEY, "Throneroom key", "Throneroom keys", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_SKULL, "Skull", "Skulls", 5));
            Items.Add(new Item(ITEM_ID_BONES, "Bone", "Bones", 1));
            Items.Add(new Item(ITEM_ID_GOBLIN_EYE, "Goblin eye", "Goblin eyes", 5));
            Items.Add(new Item(ITEM_ID_GOBLIN_SKIN, "Goblin Skin", "Goblin Skin's", 1));
            Items.Add(new Item(ITEM_ID_LICH_DUST, "Lich dust", "lich dusts", 3));
            Items.Add(new Item(ITEM_ID_LICH_HEARTSONE, "Lich heartsone", "Lich Heartsones", 10));
            Items.Add(new Item(ITEM_ID_FAMILY_HEIRLOOM, "Family heirloom", "Family heirlooms", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_LICH_CROWN, "Lich crown", "Lich crowns", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_WHEREGOAT_FUR, "Wheregoat fur", "Wheregoat furs", 3));
            Items.Add(new Item(ITEM_ID_WHEREGOAT_HORN, "Wheregoat horn", "Wheregoat horns", 10));
        }

        //Creating the monsters
        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster skellaton = new Monster(MONSTER_ID_SKELLATON, "Skellaton", 10, 4, 15, 5, 5);
            skellaton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SKULL), 75, false));
            skellaton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BONES), 75, true));

            Monster Goblin = new Monster(MONSTER_ID_GOBLIN, "Goblin", 8, 5, 15, 7, 7);
            Goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOBLIN_EYE), 30, false));
            Goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOBLIN_SKIN), 75, true));

            Monster Lich = new Monster(MONSTER_ID_LICH, "Lich", 15, 10, 15, 10, 10);
            Lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LICH_DUST), 50, true));
            Lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LICH_HEARTSONE), 15, false));

            Monster LichKing = new Monster(MONSTER_ID_LICH_KING, "Lich King", 25, 100, 100, 20, 20);
            LichKing.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LICH_CROWN), 100, true));
            LichKing.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LICH_DUST), 75, false));

            Monster whereGoat = new Monster(MONSTER_ID_WHEREGOAT, "Wheregoat", 10, 5, 10, 10, 10);
            whereGoat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WHEREGOAT_FUR), 75, true));
            whereGoat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WHEREGOAT_HORN), 25, false));


            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(skellaton);
            Monsters.Add(Goblin);
            Monsters.Add(whereGoat);
            Monsters.Add(Lich);
            Monsters.Add(LichKing);
        }

        //Creating the quests
        private static void PopulateQuests()
        {
            //Clear the alchemsist garden
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden",
                    "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            // Clear the farmers field
            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            //Clear the mystic temple
            Quest clearMysticTemple =
                new Quest(
                    QUEST_ID_CLEAR_MYSTIC_TEMPLE,
                    "Clear the mystic temple",
                    "Kill skellatons in the mystic temple and bring back 5 skulls. you will receive 30 gold pieces and an iron sword", 30, 30);

            clearMysticTemple.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SKULL), 5));

            clearMysticTemple.RewardItem = ItemByID(ITEM_ID_IRON_SWORD);

            //Clear the dark cave
            Quest clearDarkCave =
                new Quest(
                    QUEST_ID_CLEAR_DARK_CAVE,
                    "Clear the dark cave",
                    "Hi there wiery traveler, I need 3 goblin eye's to complete my new experemental potion, would you be so kind as to kill a few goblins and bring back 3 goblin eye's?. I'll give you a portion of the potions I'll make and some gold", 20, 30);

            clearDarkCave.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_GOBLIN_EYE), 3));

            clearDarkCave.RewardItem = ItemByID(ITEM_ID_EXPERIMENTAL_POTION);

            //Fetch family heirloom
            Quest fetchFamilyHeirloom =
                new Quest(
                    QUEST_ID_FETCH_FAMILY_HEIRLOOM,
                    "Fetch Rundvig's family heirloom",
                    "Please wiery traveler I need your help, a strange old man stole my family heirloom it's all I have to remember my mom by, I think Skellaton Tom has the key to the tomb, I'll pay you good I swear", 100, 100);

            fetchFamilyHeirloom.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_FAMILY_HEIRLOOM), 1));

            fetchFamilyHeirloom.RewardItem = ItemByID(ITEM_ID_FLAMING_SWORD);

            //Clear Skellaton Tom's farm
            Quest clearSkellatonTomsFram =
                new Quest(
                    QUEST_ID_CLEAR_SKELLATON_TOMS_FARM,
                    "Clear skellaton Tom's farm",
                    "Aah so you need the key to the old tomb do ya,the hell eith it I'll give it to ya if you kill thoes damned wheregoats on my farm, bring back 5 wheregoat horns", 10, 15);

            clearSkellatonTomsFram.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WHEREGOAT_HORN), 5));

            clearSkellatonTomsFram.RewardItem = ItemByID(ITEM_ID_RUSTY_GATE_KEY);

            //Fetch lich heartstones
            Quest fetchLichHeratsones =
                new Quest(
                    QUEST_ID_FETCH_LITCH_HEARTSTONES,
                    "Fetch 3 lich heartstones",
                    "Aagh I can't get this damn door open, hey you there you'r here for that heirloom right?, I'll give it back if you kill the lich king and bring me his crown but to do so I need 3 lich heartstones to create a throneroom key that fits the door", 20, 0);

            fetchLichHeratsones.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LICH_HEARTSONE), 3));

            fetchLichHeratsones.RewardItem = ItemByID(ITEM_ID_THRONEROOM_KEY);

            //Kill the lich king
            Quest killLichKing =
                new Quest(
                    QUEST_ID_KILL_LICH_KING,
                    "Kill the lich king, take it's crown and give it to the old man",
                    "I need to get into the throneroom and kill the lich king and then return it's crown to the old man", 0, 0);

            killLichKing.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LICH_CROWN), 1));

            killLichKing.RewardItem = ItemByID(ITEM_ID_FAMILY_HEIRLOOM);


            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(clearMysticTemple);
            Quests.Add(clearDarkCave);
            Quests.Add(clearSkellatonTomsFram);
            Quests.Add(fetchFamilyHeirloom);
            Quests.Add(fetchLichHeratsones);
            Quests.Add(killLichKing);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "No place like home.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain and a rusty sword in the gudder.");

            Vendor bobTheRatCatcher = new Vendor("Bob the Rat-Catcher");
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_RAT_TAIL), 3);

            townSquare.VendorWorkingHere = bobTheRatCatcher;

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location deadForest = new Location(LOCATION_ID_Dead_Forest, "Dead Forest", "You see nothing but mist and dead flora");

            Location brokenBridge = new Location(LOCATION_ID_Broken_Bridge, "Broken Bridge", "An old broken bridge crosses a dried out river");

            Location mysticTempleYard = new Location(LOCATION_ID_Mystic_Temple_Yard, "Mystic Temple yard", "You see the entrance to an old ruind mystic temple");
            mysticTempleYard.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_MYSTIC_TEMPLE);

            Location mysticTemple = new Location(LOCATION_ID_Mystic_Temple, "Mystic Temple", "You see glowing eyes in the darkness");
            mysticTemple.MonsterLivingHere = MonsterByID(MONSTER_ID_SKELLATON);

            Location swamp = new Location(LOCATION_ID_SWAMP, "Swamp", "Your feet are wet and you see an entrance to a cave to the north");
            swamp.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_DARK_CAVE);

            Location darkCave = new Location(LOCATION_ID_DARK_CAVE, "Dark Cave", "Utter darkness and eckoing shriek's");
            darkCave.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN);

            Location darkNarrowRoad = new Location(LOCATION_ID_DARK_NARROW_ROAD, "Dark Narrow Road", "A dark narrow road heading north covered in dead trees");

            Location oldCabin = new Location(LOCATION_ID_OLD_CABIN, "Old Cabin", "An old rundown cabin");
            oldCabin.QuestAvailableHere = QuestByID(QUEST_ID_FETCH_FAMILY_HEIRLOOM);

            Location skellatonTomsFarmhouse = new Location(LOCATION_ID_SKELLATON_TOMS_FARMHOUSE, "Skellaton Tom's Farmhouse", "A skellaton retired from the skellaton business growing crops");
            skellatonTomsFarmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_SKELLATON_TOMS_FARM);

            Location skellatonTomsFarm = new Location(LOCATION_ID_SKELLATON_TOMS_FARM, "Skellaton Tom's farm", "Wheregoats everywhere eating por Tom's crops");

            Location ancientTombYard = new Location(LOCATION_ID_ANCIENT_TOMB_YARD, "Ancient tomb yard", "You see the entrance to an old tomb");

            Location ancientTombHallway = new Location(LOCATION_ID_ANCIENT_TOMB_HALLWAY, "Ancient tomb hallway", "There are magic cantles lighting up the place");
            ancientTombHallway.ItemRequiredToEnter = ItemByID(ITEM_ID_RUSTY_GATE_KEY);

            Location ancientTombThroneroomDoor = new Location(LOCATION_ID_ANCIENT_TOMB_THRONEROOM_DOOR, "Throneroom door", "A huge door with ancient language carved in it");
            ancientTombThroneroomDoor.QuestAvailableHere = QuestByID(QUEST_ID_FETCH_LITCH_HEARTSTONES);
            ancientTombThroneroomDoor.QuestAvailableHere = QuestByID(QUEST_ID_KILL_LICH_KING);
            ancientTombThroneroomDoor.ItemRequiredToEnter = ItemByID(ITEM_ID_THRONEROOM_KEY);

            Location ancientTombThroneroom = new Location(LOCATION_ID_ANCIENT_TOMB_THRONEROOM, "Throneroom", "A huge room filled with ancient knowledge stored in books an tomes");

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;
            alchemistsGarden.LocationToNorth = deadForest;

            deadForest.LocationToSouth = alchemistsGarden;
            deadForest.LocationToWest = brokenBridge;
            deadForest.LocationToEast = swamp;
            deadForest.LocationToNorth = darkNarrowRoad;

            darkNarrowRoad.LocationToSouth = deadForest;
            darkNarrowRoad.LocationToEast = oldCabin;
            darkNarrowRoad.LocationToNorth = ancientTombYard;

            oldCabin.LocationToWest = darkNarrowRoad;
            oldCabin.LocationToSouth = skellatonTomsFarmhouse;

            skellatonTomsFarmhouse.LocationToNorth = oldCabin;
            skellatonTomsFarmhouse.LocationToEast = skellatonTomsFarm;

            skellatonTomsFarm.LocationToWest = skellatonTomsFarmhouse;

            ancientTombYard.LocationToSouth = darkNarrowRoad;
            ancientTombYard.LocationToNorth = ancientTombHallway;

            ancientTombHallway.LocationToSouth = ancientTombYard;
            ancientTombHallway.LocationToEast = ancientTombThroneroomDoor;

            ancientTombThroneroomDoor.LocationToWest = ancientTombHallway;
            ancientTombThroneroomDoor.LocationToNorth = ancientTombThroneroom;

            ancientTombThroneroom.LocationToSouth = ancientTombThroneroomDoor;

            brokenBridge.LocationToEast = deadForest;
            brokenBridge.LocationToWest = mysticTempleYard;

            mysticTempleYard.LocationToEast = brokenBridge;
            mysticTempleYard.LocationToNorth = mysticTemple;

            mysticTemple.LocationToSouth = mysticTempleYard;

            swamp.LocationToWest = deadForest;
            swamp.LocationToNorth = darkCave;

            darkCave.LocationToSouth = swamp;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(deadForest);
            Locations.Add(brokenBridge);
            Locations.Add(mysticTempleYard);
            Locations.Add(mysticTemple);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
            Locations.Add(swamp);
            Locations.Add(darkCave);
            Locations.Add(darkNarrowRoad);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}