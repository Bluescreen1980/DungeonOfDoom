using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonOfDoom
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]

        //Luodaan kaksiulotteinen array. Tämä on luolasto
        //0 = tyhjä huone, 1 = avaimen numero joka pitää olla että huoneeseen voi mennä
        //ok ehkä 1 = kiviseinä josta ei pääse läpi

        //locArray[y,x]
        //vaakarivi y, pystyrivi x 

        public static int[,] locArray = {
            {0 ,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20},
            {1 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {2 ,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {3 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {4 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {5 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {6 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {7 ,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,1},
            {8 ,1,1,1,1,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1},
            {9 ,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,1},
            {10,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {11,1,1,1,1,1,1,1,1,1,0,3,0,0,0,0,1,1,1,1,1},
            {12,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {13,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {14,1,1,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1},
            {15,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,1},
            {16,1,1,1,1,1,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1},
            {17,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,1},
            {18,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {19,1,1,1,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,0,1},
            {20,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
            };

        //paikkamme alussa (locArray)
        public static int locX = 10;
        public static int locY = 19;

        //start x 10 y 19
        //intro screens&text x10,y18  ja x10,y17
        //eka varsinainen huone x10, y16

        public static bool key2 = false;
        public static bool key3 = false;
        public static bool kerberosDead = false;


        //luodaan kolmiulotteinen array tiedoille, tämä jää alussa täyttämättä
        //info array on täytetty tiedoilla, x,y vastaavat locArrayn paikkaa, mutta z kertoo eri vaihtoehtoja 
        //nämä kaksi arrayta voisivat olla samat, mutta halusimme alustaa arrayn graafisesti.

        public static string[,,] caveInfo = new string[21, 21, 21];

        //Luodaan lista tavaroille

        public static List<string> items = new List<string>();
        



        static void Main()
        {
            SetInfo(caveInfo);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void SetInfo(string[,,] caveInfo)
        {
            //Lisätään aloitustavarat listaan
            items.Add("Whip");
            items.Add("Hat");
            items.Add("Cicar");

            //just for testing:
            //items.Add("Ankh");
            // items.Add("Ancient key");

            /// Caveinfo [y,x,z]  
            /// z = 0    Description of room (Look)
            /// 1 picture filename
            /// 2 Loot action description
            /// 3 Item gained from Loot 
            /// 4 Examine (closer description)
            /// 5 Use item fail
            /// 6 Use item success
            /// 7 Item needed
            /// 8 Item gained from use item
            /// 9 Use item success picture
            /// 10 Examine picture 
            /// todo: add item to List

            caveInfo[2, 2, 0] = "You died!";
            caveInfo[2, 2, 1] = "../../gameover.jpg";
           
            caveInfo[19, 10, 0] = "Welcome to the Dungeon of Doom! Developed by Rami Sihvo, Finnish College Jam Game 2024. (Press North to start your adventure)";
            caveInfo[19, 10, 1] = "../../picture1.jpg";
            caveInfo[19, 10, 2] = "You pick up some stones.";
            caveInfo[19, 10, 3] = "stones";
            caveInfo[19, 10, 4] = "You are standing on the doorway of Aztek temple (of Doom). Press North to continue.";
            caveInfo[19, 10, 5] = "You do not have stone to throw";
            caveInfo[19, 10, 6] = "You throw small stone into Aztek temple. You feel pretty good about yourself. Some moss is detached from wall because of your vandalism.";
            caveInfo[19, 10, 7] = "stones";
            caveInfo[19, 10, 8] = "moss";

            caveInfo[18, 10, 0] = "Daring lady doctor Croft has been lost to ancient Aztek Temple and it is up to you to find her. Here are stairs winding down to bowels of the earth.";
            caveInfo[18, 10, 1] = "../../picture2.jpg";
            caveInfo[18, 10, 4] = "That is why you are here, to examine.";
            caveInfo[18, 10, 5] = "Nothing to use here";

            caveInfo[17, 10, 0] = "Damp, ancient ruins. Probably some 2000 years old. About the age of my history teacher, that is.";
            caveInfo[17, 10, 1] = "../../picture3.jpg";
            caveInfo[17, 10, 4] = "You admire the decay.";
            caveInfo[17, 10, 5] = "Nothing to use here";

            caveInfo[16, 10, 0] = "You came across to ancient hall of previously unknown Aztek temple. Doctor Croft wasn't sure even what heathen god did they worship.";
            caveInfo[16, 10, 1] = "../../picture4.jpg";
            caveInfo[16, 10, 4] = "Exits: North, East, South, West. There is some kind of temple at north.";

            caveInfo[15, 10, 0] = "Shrine of the ancient aztek god with stone slab under it. The slab resembles doorway.";
            caveInfo[15, 10, 1] = "../../picture5.jpg";
            caveInfo[15, 10, 4] = "You uncover keyslot from stone slab.";
            caveInfo[15, 10, 5] = "You pick your nose instead of lock";
            caveInfo[15, 10, 6] = "You unlock the door with ancient key.";
            caveInfo[15, 10, 7] = "Ancient key";
            caveInfo[15, 10, 8] = "Key2";
            caveInfo[15, 10, 9] = "../../picture5a.jpg";        //korvaa jollain muulla

            caveInfo[16, 11, 0] = "Delipidated stone hewn corridor of Aztek temple.";
            caveInfo[16, 11, 1] = "../../picture6.jpg";

            caveInfo[16, 12, 0] = "Large hall with hieroglyphs on wall. Eastern passage has collapsed.";
            caveInfo[16, 12, 1] = "../../picture7.jpg";

            caveInfo[15, 12, 0] = "Room filled with hierogyphs. The hieroglyphs resemble flying saucers and ancient astronauts.";
            caveInfo[15, 12, 1] = "../../picture8.jpg";

            caveInfo[17, 12, 0] = "Room filled with hieroglyphical writing. There are writing tools of archeologists on the floor.";
            caveInfo[17, 12, 1] = "../../picture9.jpg";

            caveInfo[16, 13, 0] = "Collapsed passageway, there are something underneath.";
            caveInfo[16, 13, 1] = "../../picture10.jpg";
            caveInfo[16, 13, 4] = "There are blood and cloth under the rubble. Must be one of dr. Croft aides. The body is holding something.";
            caveInfo[16, 13, 10] = "../../skeleton.jpg";
            caveInfo[16, 13, 5] = "You need explosives to clear this rubble";
            caveInfo[16, 13, 6] = "You blow up the pile of rocks, revealing whats underneath.";
            caveInfo[16, 13, 7] = "Dynamite";
            caveInfo[16, 13, 8] = "Ancient key";
            caveInfo[16, 13, 9] = "../../picture10a.jpg";


            caveInfo[16, 9, 0] = "Recent tunnel dig through the ground. Supported with planks.";
            caveInfo[16, 9, 1] = "../../picture11.jpg";

            caveInfo[16, 8, 0] = "Large underground burial chamber. This time filled with camping equipment of doctor Croft expedition.";
            caveInfo[16, 8, 1] = "../../picture12.jpg";
            caveInfo[16, 8, 3] = "Lighter";
            caveInfo[16, 8, 4] = "Equipment of the expedition. Among them expensive lighter.";

            caveInfo[15, 8, 0] = "Archeological digsite around three ancient statue.";
            caveInfo[15, 8, 1] = "../../picture13.jpg";

            caveInfo[16, 7, 0] = "Nature sunlight seeps through the hole on the roof. Wines and roots enter the ruins with nature claiming the temple slowly.. Under the wines you can see remains of a skeleton.";
            caveInfo[16, 7, 1] = "../../picture14.jpg";
            caveInfo[16, 7, 10] = "../../picture14a.jpg";

            caveInfo[17, 8, 0] = "Explosive storage for expedition. Warning. Explosives can cause priceless archeological damage!";
            caveInfo[17, 8, 1] = "../../picture15.jpg";
            caveInfo[17, 8, 3] = "Dynamite";
            caveInfo[17, 8, 4] = "Boxes of dynamite stocked here.";
            caveInfo[17, 8, 5] = "Smoking here is prohibited.";
            caveInfo[17, 8, 6] = "You light up cicarette...";
            caveInfo[17, 8, 7] = "Lighter";
            caveInfo[17, 8, 8] = "Death";
            //caveInfo[17, 8, 9] = "xxx";  Picture of you blowing yourself up

            caveInfo[14, 10, 0] = "Ancient hidden doorwaye leading deeper to the dungeon of doom.";
            caveInfo[14, 10, 1] = "../../picture16.jpg";

            caveInfo[13, 10, 0] = "Passage leading you deeper..";
            caveInfo[13, 10, 1] = "../../picture17.jpg";

            caveInfo[12, 10, 0] = "How long is this passage going?";
            caveInfo[12, 10, 1] = "../../picture18.jpg";

            caveInfo[11, 10, 0] = "Ancient hidden passage with Ankh shape hole on the eastern wall.";
            caveInfo[11, 10, 1] = "../../picture19.jpg";
            caveInfo[11, 10, 4] = "There are strech marks on floor, maybe there is a hidden door?";
            caveInfo[11, 10, 5] = "You do not have ankh shaped key";
            caveInfo[11, 10, 6] = "You slot the Ankh to the hole and the eastern wall clicks open.";
            caveInfo[11, 10, 7] = "Ankh";
            caveInfo[11, 10, 8] = "Ankh";


            caveInfo[10, 10, 0] = "The corridor winds up.";
            caveInfo[10, 10, 1] = "../../picture20.jpg";

            caveInfo[9, 10, 0] = "Small stairs rising to another ancient part of the temple. You noticed a bit of charcoal littering the ground.";
            caveInfo[9, 10, 1] = "../../picture21.jpg";
            caveInfo[9, 10, 2] = "You scoop up some charoal. Now, how about combining it to something?";
            caveInfo[9, 10, 3] = "charcoal";
            caveInfo[9, 10, 4] = "Someone must have dropped the bag of charcoal here on accident.";
            caveInfo[9, 10, 5] = "You do not have sulfur";
            caveInfo[9, 10, 6] = "You mix some sulfur to charcoal";
            caveInfo[9, 10, 7] = "sulfur";
            caveInfo[9, 10, 8] = "sulfur+charcoal";
       

            caveInfo[8, 10, 0] = "Large hallway carved into volcanic rock. Corridors go to four different directions.";
            caveInfo[8, 10, 1] = "../../picture22.jpg";

            caveInfo[8, 11, 0] = "Hallway filled with spike traps";
            caveInfo[8, 11, 1] = "../../picture23.jpg";

            caveInfo[8, 12, 0] = "Crossroads room, with lipstick laying on floor.";
            caveInfo[8, 12, 1] = "../../picture24.jpg";
            //loot lipstick

            caveInfo[7, 12, 0] = "Room filled with small metal statues";
            caveInfo[7, 12, 1] = "../../picture25.jpg";
            caveInfo[7, 12, 2] = "Maybe you could stock up ammo here when you get some black powder?";
            caveInfo[7, 12, 4] = "Ancient azteks had steel? These statues range from large to very tiny, like something fitting to gun barrel";
            caveInfo[7, 12, 5] = "You could use statues as ammo, if you had black powder.";
            caveInfo[7, 12, 6] = "You gather statues as ammo";
            caveInfo[7, 12, 7] = "black powder";
            caveInfo[7, 12, 8] = "black powder+ammo";
            caveInfo[7, 12, 9] = "../../cerberos_dead.jpg";

            //loot ammo
            caveInfo[8, 13, 0] = "Evil room, probably used for human sacrifices or gigs for Cheek.";
            caveInfo[8, 13, 1] = "../../picture26.jpg";
           
            caveInfo[9, 12, 0] = "Aztek room filled with chemistry equipment. Apparently archeolgy team has visited here. ";
            caveInfo[9, 12, 1] = "../../picture27.jpg";
            caveInfo[9, 12, 2] = "Maybe you need to return here to make some ammunition when you find charcoal and sulfur.";
            caveInfo[9, 12, 4] = "Suspicious amount of salpieter is present. Maybe someone tried to make ammunition here?";
            caveInfo[9, 12, 5] = "You do not have enough items to make ammunition.";
            caveInfo[9, 12, 6] = "You make some black powder!";
            caveInfo[9, 12, 7] = "sulfur+charcoal";
            caveInfo[9, 12, 8] = "black powder";

            caveInfo[7, 10, 0] = "Large room, with equally large and mythical Cerberos looming over you. The monster waits your action!";
            caveInfo[7, 10, 1] = "../../picture28.jpg";
            caveInfo[7, 10, 2] = "You look around. While you fiddle with indecision Cerberus decides to eat you as snack.";
            caveInfo[7, 10, 3] = "Death";
            caveInfo[7, 10, 4] = "You are in large room with HUGE monster cerberos. Hope you have a good weapon!";
            caveInfo[7, 10, 5] = "You do not have ammunition!";
            caveInfo[7, 10, 6] = "You blast the Cerberos with ancient blunderbuss! The monster dies! Upon death you notice it was guarding golden ankh!";
            caveInfo[7, 10, 7] = "black powder+ammo";
            caveInfo[7, 10, 8] = "Ankh";

            //picture here
           
            caveInfo[8, 9, 0] = "Corridor hewn to volcanic rock. It's getting hot in here!.";
            caveInfo[8, 9, 1] = "../../picture29.jpg";

            caveInfo[8, 8, 0] = "Very hot room lava flow!";
            caveInfo[8, 8, 1] = "../../picture30.jpg";
        
            caveInfo[7, 8, 0] = "Very hot room with sulfur deposits on floor.";
            caveInfo[7, 8, 1] = "../../picture31.jpg";
            caveInfo[7, 8, 2] = "You pick up some sulfur.";
            caveInfo[7, 8, 3] = "sulfur";
            caveInfo[7, 8, 4] = "You are in the dead end but there's sulfur deposits here on floor.";
            caveInfo[7, 8, 5] = "You do not have charcoal.";
            caveInfo[7, 8, 6] = "You mix up some charcoal and sulfur. Only after that you think it might be toxic.";
            caveInfo[7, 8, 7] = "charcoal";
            caveInfo[7, 8, 8] = "sulfur+charcoal";

            caveInfo[9, 8, 0] = "Lake of lava. Very very hot in here!";
            caveInfo[9, 8, 1] = "../../picture32.jpg";

            caveInfo[11, 13, 0] = "Passage to darkness through wierd dimension!";
            caveInfo[11, 13, 1] = "../../picture33.jpg";

            caveInfo[11, 14, 0] = "Some kind of celestial temple in front of you! You can see someone, a human female waiting you on its front door.";
            caveInfo[11, 14, 1] = "../../picture34.jpg";

            caveInfo[19, 19, 0] = "Doctor Croft: Why are you late?";
            caveInfo[19, 19, 1] = "../../croft.jpg";

        }
    }
    }
