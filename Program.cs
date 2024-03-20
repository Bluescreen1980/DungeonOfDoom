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
            {2 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {3 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {4 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {5 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {6 ,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {7 ,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {8 ,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1},
            {9 ,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {10,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {11,1,1,1,1,1,1,1,1,1,0,3,0,0,1,1,1,1,1,1,1},
            {12,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {13,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {14,1,1,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1},
            {15,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,1},
            {16,1,1,1,1,1,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1},
            {17,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,1},
            {18,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
            {19,1,1,1,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1},
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
            SetInfo();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void SetInfo()
        {
            //Lisätään aloitustavarat listaan
            items.Add("Whip");
            items.Add("Hat");
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
            /// 9 
            /// todo: add item to List

            caveInfo[19, 10, 0] = "Welcome to the Dungeon of Doom! Developed by Rami Sihvo, Finnish College Jam Game 2024. (Press North to start your adventure)";
            caveInfo[19, 10, 1] = "../../picture.jpg";
            caveInfo[19, 10, 2] = "You pick up some stones.";
            caveInfo[19, 10, 3] = "stones";
            caveInfo[19, 10, 4] = "You are standing on the doorway of Aztek temple (of Doom). Press North to continue.";
            caveInfo[19, 10, 5] = "You do not have stone to throw";
            caveInfo[19, 10, 6] = "You throw small stone into Aztek temple. You feel pretty good about yourself. Some moss is detached from wall because of your vandalism.";
            caveInfo[19, 10, 7] = "stones";
            caveInfo[19, 10, 8] = "moss";
            caveInfo[18, 10, 0] = "Daring lady doctor Croft has been lost to ancient Aztek Temple and it is up to you to find her. Here are stairs winding down to bowels of the earth.";
            caveInfo[17, 10, 0] = "Damp, ancient ruins. Probably some 2000 years old. About the age of my history teacher, that is.";
            caveInfo[16, 10, 0] = "You came across to ancient hall of previously unknown Aztek temple. Doctor Croft wasn't sure even what heathen god did they worship.";
            caveInfo[15, 10, 0] = "Shrine of the ancient aztek god with stone slab under it. The slab resembles doorway.";

        }


    }
}
