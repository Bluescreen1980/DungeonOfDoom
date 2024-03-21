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
            {11,1,1,1,1,1,1,1,1,1,0,3,0,0,1,1,1,1,1,1,1},
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
            caveInfo[11, 10, 7] = "Key3";



        }


    }
}
