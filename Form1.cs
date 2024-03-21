using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonOfDoom
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            
        InitializeComponent();
        xyLabel.Text = Convert.ToString(Program.locX) + "," + Convert.ToString(Program.locY);
        checkWalls();
        updateRoom();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textField_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //päivitetään huoneen kuvaus
            updateRoom();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Käsitellään loot napin toimintaa

            textField.Text = Program.caveInfo[Program.locY, Program.locX, 2];

            //tarkistetaan onko jo esinettä
            bool alreadyHasItem = false;
            foreach (string item in Program.items)
            {
                if (item == Program.caveInfo[Program.locY, Program.locX, 3])
                {
                    alreadyHasItem = true;
                }
            }

            if (alreadyHasItem == false)
            {
                Program.items.Add(Program.caveInfo[Program.locY, Program.locX, 3]);
                updateRoom();
            }
        }

        private void actionItem_Click(object sender, EventArgs e)
        {
            //Tarkistetaan onko pelaajalla oikeaa esinettä, jos on kerrotaan onnistumisesta, poistetaan esine
            //ja annetaan (ehkä) pelaajalle jokin esine.
            bool rightItem = false;

            //käydään läpi lista, jos oikea esine löytyy kerrotaan tästä
            foreach (string item in Program.items)
            {
                if (item == Program.caveInfo[Program.locY, Program.locX, 7])
                {
                    rightItem = true;
                }
            }

            if (rightItem == true)
            {
                //poistetaan käytetty esine listasta
                Program.items.Remove(Program.caveInfo[Program.locY, Program.locX, 7]);
              
                //annetaan esine jos ei ole jo listassa
                if (!Program.items.Contains(Program.caveInfo[Program.locY, Program.locX, 8]))
                {
                    Program.items.Add(Program.caveInfo[Program.locY, Program.locX, 8]);
                }

                //kerrotaan onnistumisesta
                textField.Text = Program.caveInfo[Program.locY, Program.locX, 6];
                //päivitetään itemlist
                itemBox.Text = string.Join(" ", Program.items.ToArray());
            }
            else
            {
                //kerrotaan että pelaajalla ei ole oikeaa esinettä
                textField.Text = Program.caveInfo[Program.locY, Program.locX, 5];
            }

            //avainten ja erikoistilanteiden käsittely

            //Todo: Jos item on Death => siirrä 1,1 kohtaan (ja näytä gameover screen)
            //Todo: Jos item on Win = > siirrä 19,19 kohtaan (ja näyä endgame screen).

            //Jos pelajaalla on listassa avain, muutetaan se bool-arvoksi
            foreach (string item in Program.items)
            {
                if (item == "Death")
                {
                    Program.locY = 2; 
                    Program.locX = 2;
                    updateRoom();
                    checkWalls();
                    goSouth.Enabled = false;
                    goNorth.Enabled = false;
                    goWest.Enabled = false;
                    goEast.Enabled = false;
                    break;
                }
                if (item == "Key2")
                {
                    Program.key2 = true;
                    Program.items.Remove("Key2");
                    checkWalls();
                    break;
                }
                else if (item == "Ankh")
                {
                    Program.key3 = true;
                    Program.items.Remove("Key2");
                    checkWalls();

                    break;
                }
            }

            //Todo esineiden yhdistäminen
            //Kemiansetti: jos huone on oikein ja pelaajalla on salpieter, charcoal, sulfur => anna black powder

            //Kerberos: Jos pelaajalla on blunderbuss, ammo ja black powder, tuhoa cerberos
            //Program.kerberosDead == true;


        }

        private void label1_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //examine kertoo tarkemmin tilanteesta
            textField.Text = Program.caveInfo[Program.locY, Program.locX, 4];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goNorth_Click(object sender, EventArgs e)
        {
             
            Program.locY--;
            checkWalls();
            updateRoom();
        }

        private void goEast_Click(object sender, EventArgs e)
        {
            Program.locX++;
            checkWalls();
            updateRoom();
        }
           

        private void goSouth_Click(object sender, EventArgs e)
        {
            Program.locY++;
            checkWalls();
            updateRoom();

        }

        private void goWest_Click(object sender, EventArgs e)
        {
            Program.locX--;
            checkWalls();
            updateRoom();
        }

        public void updateRoom()
        {
            //tulostetaan tekstikenttään huoneen kuvaus
            textField.Text = Program.caveInfo[Program.locY, Program.locX, 0];
            //Tulostetaan kuva
            string picString = Program.caveInfo[Program.locY, Program.locX, 1];
            imageFrame.ImageLocation = picString;

            //päivitetään itemlist
            itemBox.Text = string.Join(" ", Program.items.ToArray());

            //merkataan harmaalla jos napille ei ole toimintoa (null array)
        }
        public void checkWalls()
        {

            
            if (Program.locArray[Program.locY - 1, Program.locX] == 2 & Program.key2 == true)
            {
                goNorth.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY - 1, Program.locX] == 3 & Program.key3 == true)
            {
                goNorth.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY - 1, Program.locX] > 0)
            {
                goNorth.Enabled = false;
            }
            else
            {
                goNorth.Enabled = true;
            }

           
            if (Program.locArray[Program.locY + 1, Program.locX] == 2 & Program.key2 == true)
            {
                goSouth.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY + 1, Program.locX] == 3 & Program.key3 == true)
            {
                goSouth.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY + 1, Program.locX] > 0)
            {
                goSouth.Enabled = false;
            }
            else
            {
                goSouth.Enabled = true;
            }

           
            if (Program.locArray[Program.locY, Program.locX - 1] == 2 & Program.key2 == true)
            {
                goWest.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY, Program.locX - 1] == 3 & Program.key3 == true)
            {
                goWest.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY, Program.locX - 1] > 0)
            {
                goWest.Enabled = false;
            }
            else
            {
                goWest.Enabled = true;
            }

            if (Program.locArray[Program.locY, Program.locX + 1] == 2 & Program.key2 == true)
            {
                goWest.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY, Program.locX + 1] == 3 & Program.key3 == true)
            {
                goWest.Enabled = true;
                textField.Text = "Used key!";
            }
            else if (Program.locArray[Program.locY, Program.locX + 1] > 0)
            {
                goEast.Enabled = false;
            }
            else
            {
                goEast.Enabled = true;
            }
            xyLabel.Text = Convert.ToString(Program.locX) + "," + Convert.ToString(Program.locY);

        }




        private void xyLabel_Click(object sender, EventArgs e)
        {
           // xyLabel.Text = Convert.ToString(Program.locX) + "," + Convert.ToString(Program.locY);

        }

        private void imageFrame_Click(object sender, EventArgs e)
        {

        }
    }
}
